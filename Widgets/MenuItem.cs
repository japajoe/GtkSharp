using GtkSharp.Native;

namespace GtkSharp
{
    public class MenuItem : Widget
    {
        public MenuItem(string label)
        {
            Gtk.GtkSharpMenuItemCreateWithlabel(out handle, label);
        }

        public void SetSubMenu(Menu menu)
        {
            Gtk.GtkSharpMenuItemSetSubMenu(out handle.pointer, out menu.handle.pointer);
        }
    }
}