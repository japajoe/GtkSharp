using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Widgets
{
    public class Fixed : Container
    {
        public Fixed()
        {
            handle = NativeFixed.gtk_fixed_new();
        }

        public void Add(Widget widget, int x, int y)
        {
            Put(widget, x, y);
        }

        public void Put(Widget widget, int x, int y)
        {
            if(handle.IsNullPointer)
                return;
            
            NativeFixed.gtk_fixed_put(handle, widget.Handle, x, y);
        }

        public void Move(Widget widget, int x, int y)
        {
            if(handle.IsNullPointer)
                return;            
            NativeFixed.gtk_fixed_move(handle, widget.Handle, x, y);
        }
    }
}