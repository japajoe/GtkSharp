using GtkSharp.Native;

namespace GtkSharp
{
    public class Spinner : Widget
    {
        public Spinner()
        {
            Gtk.GtkSharpSpinnerCreate(out handle.pointer);
        }

        public void Start()
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpSpinnerStart(out handle.pointer);
        }

        public void Stop()
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpSpinnerStop(out handle.pointer);
        }        
    }
}