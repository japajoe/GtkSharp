using GtkSharp.Gdk.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class Window : Bin
    {
        public Window()
        {
            handle = NativeWindow.gtk_window_new(GtkWindowType.TopLevel);
            DestroyWidget += OnClosing;
        }

        public Window(GtkWindowType type)
        {
            handle = NativeWindow.gtk_window_new(type);
            DestroyWidget += OnClosing;
        }

        public void SetTitle(string title)
        {
            if(handle.IsNullPointer)
                return;            
            NativeWindow.gtk_window_set_title(handle, title);
        }

        public void SetIcon(string filepath)
        {
            if(handle.IsNullPointer)
                return;
            NativeWindow.gtk_window_set_icon_from_file(handle, filepath, new Glib.Native.Types.GErrorPointer());
        }

        public void SetPosition(GtkWindowPosition position)
        {
            if(handle.IsNullPointer)
                return;

            NativeWindow.gtk_window_set_position(handle, position);
        }

        public void SetTitleBar(Widget widget)
        {
            if(handle.IsNullPointer)
                return;
            
            if(widget.Handle.IsNullPointer)
                return;
                
            NativeWindow.gtk_window_set_titlebar(handle, widget.Handle);
        }

        public void Close()
        {
            Destroy();
        }

        private void OnClosing()
        {
            Destroyed?.Invoke();
        }                
    }
}