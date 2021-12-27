using System;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class Container : Widget
    {
        private GEventHandler<ContainerAddCallback,ContainerAddEvent> addHandler = new GEventHandler<ContainerAddCallback, ContainerAddEvent>();
        private GEventHandler<ContainerCheckResizeCallback,ContainerCheckResizeEvent> checkResizeHandler = new GEventHandler<ContainerCheckResizeCallback, ContainerCheckResizeEvent>();
        private GEventHandler<ContainerRemoveCallback,ContainerRemoveEvent> removeHandler = new GEventHandler<ContainerRemoveCallback, ContainerRemoveEvent>();
        private GEventHandler<ContainerSetFocusChildCallback,ContainerSetFocusChildEvent> setFocusChildHandler = new GEventHandler<ContainerSetFocusChildCallback, ContainerSetFocusChildEvent>();

        public ContainerAddEvent AddWidget
        {
            get
            {
                return addHandler.Event;
            }
            set
            {
                addHandler.Event = value;
                addHandler.SignalConnect(handle.pointer, "add", OnAdd, handle.pointer);
            }
        }

        public ContainerCheckResizeEvent CheckResize
        {
            get
            {
                return checkResizeHandler.Event;
            }
            set
            {
                checkResizeHandler.Event = value;
                checkResizeHandler.SignalConnect(handle.pointer, "check-resize", OnCheckResize, handle.pointer);
            }
        }

        public ContainerRemoveEvent RemoveWidget
        {
            get
            {
                return removeHandler.Event;
            }
            set
            {
                removeHandler.Event = value;
                removeHandler.SignalConnect(handle.pointer, "remove", OnRemove, handle.pointer);
            }
        }

        public ContainerSetFocusChildEvent SetFocusChild
        {
            get
            {
                return setFocusChildHandler.Event;
            }
            set
            {
                setFocusChildHandler.Event = value;
                setFocusChildHandler.SignalConnect(handle.pointer, "set-focus-child", OnSetFocusChild, handle.pointer);
            }
        }


        public void Add(Widget widget)
        {
            if(handle.IsNullPointer)
                return;
            NativeContainer.gtk_container_add(handle, widget.handle);
        }

        public void Remove(Widget widget)
        {
            if(handle.IsNullPointer)
                return;
            NativeContainer.gtk_container_remove(handle, widget.handle);
        }

        void OnAdd(IntPtr widget, IntPtr obj, IntPtr data)
        {
            AddWidget?.Invoke(new Widget(obj));
        }

        void OnCheckResize(IntPtr widget, IntPtr data)
        {
            CheckResize?.Invoke();
        }

        void OnRemove(IntPtr widget, IntPtr obj, IntPtr data)
        {
            RemoveWidget?.Invoke(new Widget(obj));
        }

        void OnSetFocusChild(IntPtr widget, IntPtr obj, IntPtr data)
        {
            SetFocusChild?.Invoke(new Widget(obj));
        }
    }
}