using GtkSharp.Gtk.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gdk.Types;
using GtkSharp.Cairo.Types;
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
        private Image image;
        private MouseButtonState mouseButtonState = MouseButtonState.Up;
        private Vector2 mousePosition = Vector2.zero;
        private float valueMin;
        private float valueMax;
        private float angleMin;
        private float angleMax;
        private float initAngle = 0;
        private float currentAngle = 0;
        private int steps;
        private int stepInterval;
        private Widget topLevelWidget;
        private bool useImage = false;

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

        public Knob(string filepath, int numSprites, GtkOrientation orientation, float valueMin, float valueMax, float value, int steps, float angleMin = -135.0f, float angleMax = 135.0f)
        {
            if(steps < 2)
                steps = 2;
            if(steps > numSprites)
                steps = numSprites;

            steps -= 1;

            this.steps = steps;
            this.stepInterval = numSprites / steps;

            this.numSprites = numSprites;
            this.orientation = orientation;
            this.valueMin = valueMin;
            this.valueMax = valueMax;
            this.angleMin = angleMin;
            this.angleMax = angleMax;

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
            this.AddEvents(GdkEventMask.PointerMotion | GdkEventMask.ButtonPress | GdkEventMask.ButtonRelease | GdkEventMask.Scroll);

            this.MotionNotify += MouseMove;
            this.ButtonPress += MouseDown;
            this.ButtonRelease += MouseUp;
            this.Scroll += MouseScroll;
            this.Draw += OnDrawKnob;
            this.DestroyEvent += OnDestroyWidget;

            SetValue(value);
        }

        public Knob(Image image, int numSprites, GtkOrientation orientation, float valueMin, float valueMax, float value, int steps, float angleMin = -135.0f, float angleMax = 135.0f)
        {
            useImage = true;

            if(steps < 2)
                steps = 2;
            if(steps > numSprites)
                steps = numSprites;

            steps -= 1;

            this.steps = steps;
            this.stepInterval = numSprites / steps;

            this.numSprites = numSprites;
            this.orientation = orientation;
            this.valueMin = valueMin;
            this.valueMax = valueMax;
            this.angleMin = angleMin;
            this.angleMax = angleMax;

            handle = NativeEventBox.gtk_event_box_new();
            
            this.image = image;

            if(orientation == GtkOrientation.Vertical)
            {
                dummy = new Image(new GdkPixbuf(GdkColorspace.RGB, true, 8, image.Pixbuf.Format.width, image.Pixbuf.Format.height / numSprites));
                offset = image.Pixbuf.Format.height / numSprites;
            }
            else
            {
                dummy = new Image(new GdkPixbuf(GdkColorspace.RGB, true, 8, image.Pixbuf.Format.width / numSprites, image.Pixbuf.Format.height));
                offset = image.Pixbuf.Format.width / numSprites;
            }

            dummy.Clear(new GdkRGBA(0.0, 0.0, 0.0, 0.0));
            
            this.Add(this.dummy);
            this.AddEvents(GdkEventMask.PointerMotion | GdkEventMask.ButtonPress | GdkEventMask.ButtonRelease | GdkEventMask.Scroll);

            this.MotionNotify += MouseMove;
            this.ButtonPress += MouseDown;
            this.ButtonRelease += MouseUp;
            this.Scroll += MouseScroll;
            this.Draw += OnDrawKnob;

            SetValue(value);
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
            QueueDraw();
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

        private float GetRotationAngle(Vector2 mousePosition, Vector2 widgetPosition)
        {
            Vector2 currentVector = mousePosition - widgetPosition;
            return Mathf.Atan2(currentVector.y, currentVector.x) * Mathf.Rad2Deg;
        }

        float RoundToNearestStep(float pos, float stepSize)
        {
            float xDiff = pos % stepSize;
            pos -= xDiff;
            if (xDiff > (stepSize / 2))
            {
                pos += stepSize;
            }
            return pos;
        }

        bool MouseMove(GdkEventMotion eventMotion)
        {
            mousePosition = new Vector2((float)eventMotion.x, (float)eventMotion.y);

            if(mouseButtonState == MouseButtonState.Down)
            {
                Vector2 widgetPosition = GetWidgetPosition();
                currentAngle = GetRotationAngle(mousePosition, widgetPosition);
                float angle = currentAngle - initAngle;                        
                angle = Mathf.Clamp(angle, angleMin, angleMax);
                angle = Mathf.InverseLerp(angleMin, angleMax, angle);
                angle = RoundToNearestStep(angle * (numSprites - 1 ), stepInterval);                
                spriteIndex = (int)angle;
                spriteIndex = Mathf.Clamp(spriteIndex, 0, numSprites - 1);
                SetToolTip(Value.ToString());
                QueueDraw();
            }
            
            return false;
        }

        private bool MouseDown(GdkEventButton eventButton)
        {
            if(eventButton.button == 1)
            {
                mouseButtonState = MouseButtonState.Down;
                Vector2 widgetPosition = GetWidgetPosition();
                initAngle = GetRotationAngle(mousePosition, widgetPosition);
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

        private bool MouseScroll(GdkEventScroll eventScroll)
        {
            if(eventScroll.direction == GdkScrollDirection.Up)
            {
                if((spriteIndex + stepInterval) <= (numSprites - 1))
                {
                    spriteIndex += stepInterval;
                    spriteIndex = Mathf.Clamp(spriteIndex, 0, numSprites - 1);
                    SetToolTip(Value.ToString());
                    QueueDraw();
                }
                else
                {
                    spriteIndex = numSprites - 1;
                    SetToolTip(Value.ToString());
                    QueueDraw();                        
                }
            }
            if(eventScroll.direction == GdkScrollDirection.Down)
            {
                if((spriteIndex - stepInterval) >= 0)
                {
                    spriteIndex -= stepInterval;
                    spriteIndex = Mathf.Clamp(spriteIndex, 0, numSprites - 1);
                    SetToolTip(Value.ToString());
                    QueueDraw();
                }
                else
                {
                    spriteIndex = 0;
                    SetToolTip(Value.ToString());
                    QueueDraw();
                }
            }
            
            return false;
        }

        private bool OnDrawKnob(CairoInstance cr)
        {
            if(!useImage)
                DrawFromSurface(cr);
            else
                DrawFromImage(cr);
            
            return false;
        }

        private void DrawFromSurface(CairoInstance cr)
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
        }

        private void DrawFromImage(CairoInstance cr)
        {
            int width = image.Pixbuf.Format.width;
            int height = image.Pixbuf.Format.height;

            if(orientation == GtkOrientation.Vertical)
                cr.Translate(0, spriteIndex * -offset);
            else
                cr.Translate(spriteIndex * -offset, 0);

            cr.SetSourcePixbuf(image.Pixbuf, 0, 0);
            cr.Rectangle(0, 0, width, height);
            cr.Fill();
        }

        private void OnDestroyWidget()
        {
            surface.Destroy();
        }
    }
}