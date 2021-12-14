using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class Window : Bin
    {
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