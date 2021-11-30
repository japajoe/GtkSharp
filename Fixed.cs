using GtkSharp.Native;

namespace GtkSharp
{
    public class Fixed : Widget
    {
        public Fixed(int width, int height)
        {
            Gtk.GtkSharpFixedCreate(out handle.pointer, width, height);
        }

        public void Add(Widget child, int x, int y)
        {
            if(handle.IsNullPointer)
                return;

            if(child.handle.IsNullPointer)
                return;

            Gtk.GtkSharpFixedAdd(out handle.pointer, out child.handle.pointer, x, y);
        }
    }
}