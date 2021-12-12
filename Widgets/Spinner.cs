using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Spinner : Widget
    {
        public Spinner()
        {
            handle = NativeSpinner.gtk_spinner_new();
        }

        public void Start()
        {
            if(handle.IsNullPointer)
                return;

            NativeSpinner.gtk_spinner_start(handle);
        }

        public void Stop()
        {
            if(handle.IsNullPointer)
                return;

            NativeSpinner.gtk_spinner_stop(handle);
        }
    }
}