using System;
using GtkSharp.Native;

namespace GtkSharp
{
    public class Window : Widget
    {
        private string title;
        private GtkCallback onWindowClosingNative;

        public event WindowClosingEvent onClosing;
        public event WindowClosedEvent onClosed;

        public string Title
        {
            get { return title; }
        }

        public Window()
        {
            Gtk.GtkSharpWindowCreate(out handle.pointer);
            onWindowClosingNative = GtkSharpDelegate.Create<GtkCallback>(this, "OnClosing");
            Gtk.GtkSharpCallbackConnect(out handle.pointer, "destroy", onWindowClosingNative, out handle.pointer);
        }

        public void SetTitle(string title)
        {
            if(handle.IsNullPointer)
                return;

            this.title = title;

            Gtk.GtkSharpWindowSetTitle(out handle.pointer, title);
        }

        public void SetStyleSheet(string filepath)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpWindowSetStyleSheet(out handle.pointer, filepath);
        }

        public void Add(Widget child)
        {
            if(handle.IsNullPointer)
                return;

            if(child.handle.IsNullPointer)
                return;

            Gtk.GtkSharpWindowAdd(out handle.pointer, out child.handle.pointer);
        }

        public void Close()
        {
            Destroy();
        }
         
        private void OnClosing(IntPtr widget, IntPtr data)
        {
            onClosing?.Invoke();
            Destroy();
            onClosed?.Invoke();
        }
    }
}