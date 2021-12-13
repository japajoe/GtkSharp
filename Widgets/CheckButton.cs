using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class CheckButton : ToggleButtonBase
    {
        public CheckButton()
        {
            handle = NativeCheckButton.gtk_check_button_new();
        }

        public CheckButton(string label)
        {
            handle = NativeCheckButton.gtk_check_button_new_with_label(label);
        }
    }
}