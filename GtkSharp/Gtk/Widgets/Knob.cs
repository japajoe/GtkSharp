using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gdk.Types;
using GtkSharp.Cairo.Types;
using GtkSharp.Gtk.Types;
using GtkSharp.Utilities;

namespace GtkSharp.Gtk.Widgets
{
    //Still works a bit clumsy but it's a beginning :)
    public class Knob : EventBox
    {
        public enum MouseButtonState
        {
            Down,
            Up
        }

        private Image dummy;
        private int spriteIndex = 0;
        private int numSprites;
        private int offset = 0;
        private GtkOrientation orientation;
        private CairoImageSurface surface;
        private MouseButtonState mouseButtonState = MouseButtonState.Up;
        private Vector2 mousePosition = Vector2.zero;
        private float valueMin;
        private float valueMax;
        private Widget topLevelWidget;

        public float Value
        {
            get
            {
                return GetValue();
            }
            set
            {
                SetValue(value);
            }
        }

        public Knob(string filepath, int numSprites, GtkOrientation orientation, float valueMin, float valueMax)
        {
            numSprites++;
            this.numSprites = numSprites;
            this.orientation = orientation;
            this.valueMin = valueMin;
            this.valueMax = valueMax;

            handle = NativeEventBox.gtk_event_box_new();
            
            surface = new CairoImageSurface(filepath);

            if(orientation == GtkOrientation.Vertical)
            {
                dummy = new Image(new GdkPixbuf(GdkColorspace.RGB, true, 8, surface.Width, surface.Height / numSprites));
                offset = surface.Height / numSprites;
            }
            else
            {
                dummy = new Image(new GdkPixbuf(GdkColorspace.RGB, true, 8, surface.Width / numSprites, surface.Height));
                offset = surface.Width / numSprites;
            }

            dummy.Clear(new GdkRGBA(0.0, 0.0, 0.0, 0.0));
            
            this.Add(this.dummy);
            this.AddEvents(GdkEventMask.PointerMotion | GdkEventMask.ButtonPress | GdkEventMask.ButtonRelease);

            this.MotionNotify += MouseMove;
            this.ButtonPress += MouseDown;
            this.ButtonRelease += MouseUp;
            this.Draw += OnDrawKnob;
            this.DestroyEvent += OnDestroyWidget;
        }

        private float GetValue()
        {
            if(handle.IsNullPointer)
                return 0;
            
            float val = (1.0f / (numSprites - 1)) * spriteIndex;
            return valueMin + ((valueMax - valueMin) * val);
        }

        private void SetValue(float value)
        {
            if(handle.IsNullPointer)
                return;

            value = Mathf.Clamp(value, valueMin, valueMax);
            float t = Mathf.InverseLerp(valueMin, valueMax, value);
            int v = (int)Mathf.Ceil(t * (numSprites - 1));
            spriteIndex = v;
            this.QueueDraw();
        }

        private float initAngle = 0;
        private float currentAngle = 0;

        bool MouseMove(GdkEventMotion eventMotion)
        {
            mousePosition = new Vector2((float)eventMotion.x, (float)eventMotion.y);

            if(mouseButtonState == MouseButtonState.Down)
            {
                Vector2 widgetPosition = GetWidgetPosition();
                currentAngle = GetAngle(mousePosition, widgetPosition);

                float angle = currentAngle - initAngle;

                System.Console.WriteLine(angle);

                // float adj = mousePosition.x - widgetPositionX;
                // float opp = mousePosition.y - widgetPositionY;
                // float angle = Mathf.Atan2(opp, adj);                        

                // angle = angle / (Mathf.PI / 180.0f);                        
                angle = Mathf.Clamp(angle, -135.0f, 135.0f);
                angle = Mathf.InverseLerp(-135.0f, 135.0f, angle);

                spriteIndex = (int)Mathf.Floor(angle * (numSprites - 1 ));
                QueueDraw();

            }
            
            return false;
        }

        private Vector2 GetWidgetPosition()
        {
            Vector2 position = Vector2.zero;

            if(topLevelWidget == null)
            {
                topLevelWidget = GetTopLevel();
            }

            if(topLevelWidget != null)
            {
                int x = 0;
                int y = 0;                    

                if(TranslateCoordinates(topLevelWidget, 0, 0, out x, out y))
                {
                    position = new Vector2(x, y);
                }
            }

            return position;
        }

        private float GetAngle(Vector2 mousePosition, Vector2 widgetPosition)
        {
            Vector2 currentVector = mousePosition - widgetPosition;
            return Mathf.Atan2(currentVector.y, currentVector.x) * Mathf.Rad2Deg;
        }

        private bool MouseDown(GdkEventButton eventButton)
        {
            if(eventButton.button == 1)
            {
                mouseButtonState = MouseButtonState.Down;
                Vector2 widgetPosition = GetWidgetPosition();
                initAngle = GetAngle(mousePosition, widgetPosition);
            }            
            return false;
        }

        private bool MouseUp(GdkEventButton eventButton)
        {
            if(eventButton.button == 1)
            {
                mouseButtonState = MouseButtonState.Up;
            }
            return false;
        }

        private bool OnDrawKnob(CairoInstance cr)
        {
            int width = surface.Width;
            int height = surface.Height;

            if(orientation == GtkOrientation.Vertical)
                cr.Translate(0, spriteIndex * -offset);
            else
                cr.Translate(spriteIndex * -offset, 0);

            cr.SetSourceSurface(surface, 0, 0);
            cr.Rectangle(0, 0, width, height);
            cr.Fill();   
            
            return false;
        }

        private void OnDestroyWidget()
        {
            surface.Destroy();
        }
    }
}