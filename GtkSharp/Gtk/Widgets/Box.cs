using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class Box : Container
    {
        public bool Homogeneous
        {
            get
            {
                return GetHomogeneous();
            }
            set
            {
                SetHomogeneous(value);
            }
        }

        public Box()
        {
            handle = NativeBox.gtk_box_new(GtkOrientation.Vertical, 0);
        }

        public Box(GtkOrientation orientation, int spacing)
        {
            handle = NativeBox.gtk_box_new(orientation, spacing);
        }

        public bool GetHomogeneous()
        {
            if(handle.IsNullPointer)
                return false;

            return NativeBox.gtk_box_get_homogeneous(handle);
        }

        public void SetHomogeneous(bool homogeneous)
        {
            if(handle.IsNullPointer)
                return;
            
            NativeBox.gtk_box_set_homogeneous(handle, homogeneous);
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