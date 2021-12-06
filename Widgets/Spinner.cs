using GtkSharp.Native;

namespace GtkSharp
{
    public class Spinner : Widget
    {
        public Spinner()
        {
            Gtk.GtkSharpSpinnerCreate(out handle);
        }

        public void Start()
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpSpinnerStart(out handle);
        }

        public void Stop()
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpSpinnerStop(out handle);
        }        
    }
}