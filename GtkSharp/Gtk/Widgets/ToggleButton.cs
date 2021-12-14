using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Widgets
{
    public class ToggleButton : ToggleButtonBase
    {
        public ToggleButton(string text)
        {
            handle = NativeToggleButton.gtk_toggle_button_new_with_label(text);
        }

        public ToggleButton()
        {
            handle = NativeToggleButton.gtk_toggle_button_new();
        }
    }
}