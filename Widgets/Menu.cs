using System;
using System.Runtime.InteropServices;
using GtkSharp.Callbacks;
using GtkSharp.Native;
using GtkSharp.Native.Callbacks;
using GtkSharp.Native.Widgets;

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
                        GLib.g_signal_connect(handle.pointer, "move-scroll", onMenuMoveScrollCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "popped-up", onMenuPoppedUpCallback.ToIntPtr(), handle.pointer);
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
            handle = NativeMenu.gtk_menu_new();
        }

        public void ShellAppend(MenuItem menuItem)
        {
            NativeMenuShell.gtk_menu_shell_append(handle, menuItem.handle);
        }

        public void ShellPrepend(MenuItem menuItem)
        {
            NativeMenuShell.gtk_menu_shell_prepend(handle, menuItem.handle);
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