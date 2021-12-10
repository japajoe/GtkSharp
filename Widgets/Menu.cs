using System;
using System.Runtime.InteropServices;
using GtkSharp.Native;

namespace GtkSharp
{
    public class Menu : Widget
    {
        private event MenuMoveScrollEvent onMoveScrollEvent;
        private event MenuPoppedUpEvent onPoppedUpEvent;

        private GtkMenuMoveScrollCallback onMenuMoveScrollCallback;
        private GtkMenuPoppedUpCallback onMenuPoppedUpCallback;

        public MenuMoveScrollEvent onMoveScroll
        {
            get
            {
                return onMoveScrollEvent;
            }
            set
            {
                onMoveScrollEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onMenuMoveScrollCallback.IsNullPointer())
                    {
                        onMenuMoveScrollCallback = OnMoveScroll;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "move-scroll", onMenuMoveScrollCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public MenuPoppedUpEvent onPoppedUp
        {
            get
            {
                return onPoppedUpEvent;
            }
            set
            {
                onPoppedUpEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onMenuPoppedUpCallback.IsNullPointer())
                    {
                        onMenuPoppedUpCallback = OnPoppedUp;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "popped-up", onMenuPoppedUpCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }        

        public Menu(IntPtr widgetPointer)
        {
            this.handle.pointer = widgetPointer;
        }
        
        public Menu()
        {
            Gtk.GtkSharpMenuCreate(out handle);
        }

        public void ShellAppend(MenuItem menuItem)
        {
            Gtk.GtkSharpMenuShellAppend(out handle.pointer, out menuItem.handle.pointer);
        }

        private void OnMoveScroll(IntPtr widget, IntPtr scrollType, IntPtr data)
        {
            int val = Marshal.ReadInt32(scrollType);
            GtkScrollType st = (GtkScrollType)val;
            onMoveScrollEvent?.Invoke(st);
        }

        private void OnPoppedUp(IntPtr widget, IntPtr flippedRect, IntPtr finalRect, bool flippedX, bool flippedY, IntPtr data)
        {
            onPoppedUpEvent?.Invoke(flippedX, flippedY);
        }
    }
}