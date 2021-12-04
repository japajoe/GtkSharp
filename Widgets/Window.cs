using System;
using System.Text;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Window : Widget
    {
        private StringBuilder stringBuilder;
        private GtkCallback onWindowClosingNative;

        public event WindowClosingEvent onClosing;
        public event WindowClosedEvent onClosed;

        public string Title
        {
            get
            {
                return GetTitle();
            }
            set
            {
                SetTitle(value);            
            }
        }

        public bool HideTitleBarWhenMaximized
        {
            get
            {
                return GetHideTitleBarWhenMaximized();
            }
            set
            {
                SetHideTitleBarWhenMaximized(value);
            }
        }

        public bool Resizable
        {
            get
            {
                return GetResizable();
            }
            set
            {
                SetResizable(value);
            }
        }

        public Window(GtkWindowType type)
        {
            stringBuilder = new StringBuilder(1024);
            NativeWindow.GtkSharpWindowCreate(out handle.pointer, type);

            GdkEventMask events = GdkEventMask.KeyPress | GdkEventMask.ButtonPress | GdkEventMask.PointerMotion;
            this.AddEvents(events);

            onWindowClosingNative = GtkSharpDelegate.Create<GtkCallback>(this, "OnClosing");
            Gtk.GtkSharpCallbackConnect(out handle.pointer, "destroy", onWindowClosingNative, out handle.pointer);
        }

        public string GetTitle()
        {
            if(handle.IsNullPointer)
                return string.Empty;

            stringBuilder.Clear();

            int length = 0;
            NativeWindow.GtkSharpWindowGetTitleLength(out handle.pointer, out length);

            if(length > stringBuilder.Capacity)
            {
                stringBuilder.Capacity = length;
                stringBuilder.EnsureCapacity(length);
            }

            NativeWindow.GtkSharpWindowGetTitle(out handle.pointer, stringBuilder);

            string title = stringBuilder.ToString().Substring(0, (int)length);            
            return title;
        }

        public void SetTitle(string title)
        {
            if(handle.IsNullPointer)
                return;

            NativeWindow.GtkSharpWindowSetTitle(out handle.pointer, title);
        }

        public void Add(Widget child)
        {
            if(handle.IsNullPointer)
                return;

            if(child.handle.IsNullPointer)
                return;

            Gtk.GtkSharpContainerAdd(out handle.pointer, out child.handle.pointer);
        }

        public void SetPosition(GtkWindowPosition position)
        {
            if(handle.IsNullPointer)
                return;

            NativeWindow.GtkSharpWindowSetPosition(out handle.pointer, position);
        }

        public void SetFocusedWidget(Widget widget)
        {
            if(handle.IsNullPointer)
                return;

            if(widget.handle.IsNullPointer)
                return;

            NativeWindow.GtkSharpWindowSetFocus(out handle.pointer, out widget.handle.pointer);
        }

        public Widget GetFocusedWidget()
        {
            if(handle.IsNullPointer)
                return null;

            Widget widget = new Widget();
            NativeWindow.GtkSharpWindowGetFocus(out handle.pointer, out widget.handle.pointer);
            return widget;
        }

        public bool GetHideTitleBarWhenMaximized()
        {
            if(handle.IsNullPointer)
                return false;

            bool hide;
            NativeWindow.GtkSharpWindowGetHideTitlebarWhenMaximized(out handle.pointer, out hide);
            return hide;
        }

        public void SetHideTitleBarWhenMaximized(bool hide)
        {
            if(handle.IsNullPointer)
                return;
            NativeWindow.GtkSharpWindowSetHideTitlebarWhenMaximized(out handle.pointer, hide);
        }

        public bool GetResizable()
        {
            if(handle.IsNullPointer)
                return false;

            bool resizable;
            NativeWindow.GtkSharpWindowGetResizable(out handle.pointer, out resizable);
            return resizable;
        }

        public void SetResizable(bool resizable)
        {
            if(handle.IsNullPointer)
                return;

            NativeWindow.GtkSharpWindowSetResizable(out handle.pointer, resizable);
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