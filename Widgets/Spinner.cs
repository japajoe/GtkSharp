using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Spinner : Widget
    {
        public Spinner()
        {
            NativeSpinner.GtkSharpSpinnerCreate(out handle);
        }

        public void Start()
        {
            if(handle.IsNullPointer)
                return;

            NativeSpinner.GtkSharpSpinnerStart(out handle);
        }

        public void Stop()
        {
            if(handle.IsNullPointer)
                return;

            NativeSpinner.GtkSharpSpinnerStop(out handle);
        }        
    }
}