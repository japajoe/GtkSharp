using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gdk.Types;
using GtkSharp.Cairo.Types;
using GtkSharp.Gtk.Types;
using GtkSharp.Utilities;

namespace GtkSharp.Gtk.Widgets
{
    //Works a bit clumsy but it's a beginning :)
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
        private Vector2 curPosition = Vector2.zero;
        private float valueMin;
        private float valueMax;

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

        bool MouseMove(GdkEventMotion eventMotion)
        {
            if(mouseButtonState == MouseButtonState.Down)
            {
                curPosition = new Vector2((float)eventMotion.x, (float)eventMotion.y);
                float angle = (Mathf.Atan2(curPosition.y, curPosition.x) * 180.0f / Mathf.PI);
                angle = Mathf.Clamp(angle, -135.0f, 135f);
                float t = Mathf.InverseLerp(-135.0f, 135f, angle);
                spriteIndex = (int)Mathf.Floor(t * (numSprites - 1 ));
                this.QueueDraw();
            }
            
            return false;
        }

        private bool MouseDown(GdkEventButton eventButton)
        {
            if(eventButton.button == 1)
            {
                mouseButtonState = MouseButtonState.Down;
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
    }
}