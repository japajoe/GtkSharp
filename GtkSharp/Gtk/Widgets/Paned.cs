using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class Paned : Container
    {
        public int HandlePosition
        {
            get
            {
                return GetHandlePosition();
            }
            set
            {
                SetHandlePosition(value);
            }
        }

        public bool WideHandle
        {
            get
            {
                return GetWideHandle();
            }
            set
            {
                SetWideHandle(value);
            }
        }

        public Paned(GtkOrientation orientation)
        {
            handle = NativePaned.gtk_paned_new(orientation);
        }

        public void Add(Widget widget, uint location, bool resize, bool shrink)
        {
            if(handle.IsNullPointer)
                return;
            if(location == 0)
                NativePaned.gtk_paned_pack1(handle, widget.handle, resize, shrink);
            else
                NativePaned.gtk_paned_pack2(handle, widget.handle, resize, shrink);
        }

        public int GetHandlePosition()
        {
            if(handle.IsNullPointer)
                return 0;

            return NativePaned.gtk_paned_get_position(handle);
        }

        public void SetHandlePosition(int position)
        {
            if(handle.IsNullPointer)
                return;

            NativePaned.gtk_paned_set_position(handle, position);
        }

        public bool GetWideHandle()
        {
            if(handle.IsNullPointer)
                return false;

            return NativePaned.gtk_paned_get_wide_handle(handle);
        }

        public void SetWideHandle(bool wide)
        {
            if(handle.IsNullPointer)
                return;

            NativePaned.gtk_paned_set_wide_handle(handle, wide);
        }
    }
}