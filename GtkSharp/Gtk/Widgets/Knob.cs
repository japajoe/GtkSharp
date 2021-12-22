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
        private Vector2 prevPosition = Vector2.zero;
        private GdkScreen screen;

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

        public Knob(string filepath, int numSprites, GtkOrientation orientation)
        {
            numSprites++;
            this.numSprites = numSprites;
            this.orientation = orientation;

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

            screen = new GdkScreen();
            
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
            
            return (1.0f / (numSprites - 1)) * spriteIndex;
        }

        private void SetValue(float value)
        {
            if(handle.IsNullPointer)
                return;

            value = Mathf.Clamp(value, 0.0f, 1.0f);
            float t = Mathf.InverseLerp(0.0f, 1.0f, value);
            int v = (int)Mathf.Ceil(t * (numSprites - 1));
            spriteIndex = v;
            this.QueueDraw();
        }

        bool MouseMove(GdkEventMotion eventMotion)
        {
            prevPosition = curPosition;
            curPosition = new Vector2((float)eventMotion.x, (float)eventMotion.y);
            Vector2 deltaPosition = curPosition - prevPosition;

            if(mouseButtonState == MouseButtonState.Down)
            {
                float direction = Mathf.Atan2(deltaPosition.x, deltaPosition.y);

                if(direction > 0)
                {
                    if(spriteIndex < numSprites - 1)
                    {
                        spriteIndex++;
                        this.QueueDraw();
                    }
                }

                if(direction < 0)
                {
                    if(spriteIndex > 0)
                    {
                        spriteIndex--;
                        this.QueueDraw();
                    }
                }                
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