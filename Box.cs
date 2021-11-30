using GtkSharp.Native;

namespace GtkSharp
{
    public class Box : Widget
    {
        public Box()
        {
            Gtk.GtkSharpBoxCreate(out handle.pointer, GtkOrientation.Vertical, 0, false);
        }

        public Box(GtkOrientation orientation, int spacing, bool homogeneous)
        {
            Gtk.GtkSharpBoxCreate(out handle.pointer, orientation, spacing, homogeneous);
        }

        public void Add(Widget child, bool expand, bool fill, uint padding)
        {
            if(handle.IsNullPointer)
                return;

            if(child.handle.IsNullPointer)
                return;

            Gtk.GtkSharpBoxAdd(out handle.pointer, out child.handle.pointer, expand, fill, padding);
        }
    }
}