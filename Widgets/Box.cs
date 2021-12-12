using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Box : Container
    {
        public Box()
        {
            handle = NativeBox.gtk_box_new(GtkOrientation.Vertical, 0);
        }

        public Box(GtkOrientation orientation, int spacing)
        {
            handle = NativeBox.gtk_box_new(orientation, spacing);
        }

        public void Add(Widget widget, bool expand, bool fill, uint padding)
        {
            PackStart(widget, expand, fill, padding);
        }

        public void PackStart(Widget widget, bool expand, bool fill, uint padding)
        {
            if(handle.IsNullPointer)
                return;
            NativeBox.gtk_box_pack_start(handle, widget.handle, expand, fill, padding);
        }

        public void PackEnd(Widget widget, bool expand, bool fill, uint padding)
        {
            if(handle.IsNullPointer)
                return;
            NativeBox.gtk_box_pack_end(handle, widget.handle, expand, fill, padding);
        }        
    }
}