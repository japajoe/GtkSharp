using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gdk.Types;
using GtkSharp.Cairo.Types;
using GtkSharp.Utilities;

namespace GtkSharp.Gtk.Widgets
{
    //Unfinished business
    public class Knob : EventBox
    {
        private Image dummy;
        private float angle;
        private int steps;
        private CairoImageSurface surface;

        public Knob(string filepath, int steps)
        {
            this.steps = steps;

            handle = NativeEventBox.gtk_event_box_new();
            
            surface = new CairoImageSurface(filepath);

            dummy = new Image(new GdkPixbuf(GdkColorspace.RGB, true, 8, surface.Width, surface.Height));
            dummy.Clear(new GdkRGBA(0.0, 0.0, 0.0, 0.0));
            
            this.Add(this.dummy);

            this.AddEvents(GdkEventMask.PointerMotion | GdkEventMask.ButtonPress | GdkEventMask.ButtonRelease);

            this.MotionNotify += MouseMove;
            this.ButtonPress += MouseDown;
            this.ButtonRelease += MouseUp;

            this.Draw += OnDrawKnob;
        }

        bool MouseMove(GdkEventMotion eventMotion)
        {
            return false;
        }

        private bool MouseDown(GdkEventButton eventButton)
        {
            if(eventButton.button == 1)
                angle += (Mathf.Deg2Rad * (360.0f / steps));
            if(eventButton.button == 3)
                angle -= (Mathf.Deg2Rad * (360.0f / steps));
            return false;
        }

        private bool MouseUp(GdkEventButton eventButton)
        {
            return false;
        }

        private bool OnDrawKnob(CairoInstance cr)
        {
            int width = surface.Width;
            int height = surface.Height;

            cr.Translate(width / 2, height / 2);
            cr.Rotate(angle);
            cr.Translate(-width / 2, -height / 2);
            cr.SetSourceSurface(surface, 0, 0);            
            cr.Paint();
            
            this.QueueDraw();
            return false;
        }
    }
}