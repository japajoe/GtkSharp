using GtkSharp.Gtk.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gdk.Types;
using GtkSharp.Cairo.Types;
using GtkSharp.Utilities;
using System;

namespace GtkSharp.Gtk.Widgets
{
    [Obsolete("KnobOld has been deprecated, use Knob instead")]
    public class KnobOld : EventBox
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
        private float angleMin;
        private float angleMax;
        private float initAngle = 0;
        private float currentAngle = 0;
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

        public KnobOld(string filepath, int numSprites, GtkOrientation orientation, float valueMin, float valueMax, float value, float angleMin = -135.0f, float angleMax = 135.0f)
        {
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
                spriteIndex = (int)Mathf.Floor(angle * (numSprites - 1 ));
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
                if(spriteIndex < numSprites - 1)
                {
                    spriteIndex++;
                    SetToolTip(Value.ToString());
                    QueueDraw();
                }
            }
            if(eventScroll.direction == GdkScrollDirection.Down)
            {
                if(spriteIndex > 0)
                {
                    spriteIndex--;
                    SetToolTip(Value.ToString());
                    QueueDraw();
                }
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