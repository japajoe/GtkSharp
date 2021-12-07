using GtkSharp.Native;

namespace GtkSharp
{
    public class DrawingArea : Widget
    {
        public DrawingArea(int width, int height)
        {
            Gtk.GtkSharpDrawingAreaCreate(out handle, width, height);
            SetSize(width, height);
        }
    }
}