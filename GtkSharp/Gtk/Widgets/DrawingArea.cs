using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Widgets
{
    public class DrawingArea : Widget
    {
        public DrawingArea()
        {
            handle = NativeDrawingArea.gtk_drawing_area_new();
        }
    }
}