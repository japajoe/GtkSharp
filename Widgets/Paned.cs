using GtkSharp.Native;

namespace GtkSharp
{
    public class Paned : Widget
    {
        public Paned(GtkOrientation orientation)
        {
            Gtk.GtkSharpPanedCreate(out handle, orientation);
        }

        public void Add(Widget child, uint location, bool resize, bool shrink)
        {
            if(handle.IsNullPointer)
                return;

            if(child.handle.IsNullPointer)
                return;

            Gtk.GtkSharpPanedAdd(out handle, out child.handle.pointer, location, resize, shrink);
        }

        public void SetSeparatorPosition(int position)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpPanedSetSeparatorPosition(out handle, position);
        }
    }
}