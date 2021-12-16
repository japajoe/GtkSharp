using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class Window : Bin
    {
        public Window()
        {
            handle = NativeWindow.gtk_window_new(GtkWindowType.TopLevel);
            DestroyEvent += OnClosing;
        }

        public Window(GtkWindowType type)
        {
            handle = NativeWindow.gtk_window_new(type);
            DestroyEvent += OnClosing;
        }

        public void SetTitle(string title)
        {
            if(handle.IsNullPointer)
                return;            
            NativeWindow.gtk_window_set_title(handle, title);
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
            
            if(widget.handle.IsNullPointer)
                return;
                
            NativeWindow.gtk_window_set_titlebar(handle, widget.handle);
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