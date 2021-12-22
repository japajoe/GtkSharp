using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Widgets
{
    public class EventBox : Bin
    {
        public EventBox()
        {
            handle = NativeEventBox.gtk_event_box_new();
        }
    }
}