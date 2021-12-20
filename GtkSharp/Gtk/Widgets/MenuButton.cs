using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Widgets
{
    public class MenuButton : ToggleButtonBase
    {
        public MenuButton()
        {
            handle = NativeMenuButton.gtk_menu_button_new();
        }
    }
}