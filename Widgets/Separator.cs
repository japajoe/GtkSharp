using GtkSharp.Native;

namespace GtkSharp
{
    public class Separator : Widget
    {
        public Separator(GtkOrientation orientation)
        {
            Gtk.GtkSharpSeparatorCreate(out handle.pointer, orientation);
        }
    }
}