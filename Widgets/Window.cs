using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Window : Bin
    {
        public Window(GtkWindowType type)
        {
            handle = NativeWindow.gtk_window_new(type);
            onDestroy += OnClosing;
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
            onDestroyed?.Invoke();
        }                
    }
}