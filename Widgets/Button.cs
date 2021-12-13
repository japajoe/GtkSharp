using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Button : ButtonBase
    {        
        public Button()
        {
            handle = NativeButton.gtk_button_new();
        }

        public Button(string text)
        {
            handle = NativeButton.gtk_button_new();
            SetLabel(text);
        }
    }
}