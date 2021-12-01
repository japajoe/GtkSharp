using GtkSharp.Native;

namespace GtkSharp
{
    public class Image : Widget
    {
        public Image(string iconName, GtkIconSize size)
        {
            Gtk.GtkSharpImageCreateFromIconName(out handle.pointer, iconName, size);
        }
    }
}