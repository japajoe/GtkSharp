using System;
using System.Runtime.InteropServices;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class Menu : Widget
    {
        private GEventHandler<MenuMoveScrollCallback,MenuMoveScrollEvent> moveScrollHandler = new GEventHandler<MenuMoveScrollCallback, MenuMoveScrollEvent>();
        private GEventHandler<MenuPoppedUpCallback,MenuPoppedUpEvent> poppedUpHandler = new GEventHandler<MenuPoppedUpCallback, MenuPoppedUpEvent>();

        public MenuMoveScrollEvent MoveScroll
        {
            get
            {
                return moveScrollHandler.Event;
            }
            set
            {
                moveScrollHandler.Event = value;
                moveScrollHandler.SignalConnect(handle.pointer, "move-scroll", OnMoveScroll, handle.pointer);
            }
        }

        public MenuPoppedUpEvent PoppedUp
        {
            get
            {
                return poppedUpHandler.Event;
            }
            set
            {
                poppedUpHandler.Event = value;
                poppedUpHandler.SignalConnect(handle.pointer, "popped-up", OnPoppedUp, handle.pointer);
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
            NativeMenuShell.gtk_menu_shell_append(handle, menuItem.Handle);
        }

        public void ShellPrepend(MenuItem menuItem)
        {
            NativeMenuShell.gtk_menu_shell_prepend(handle, menuItem.Handle);
        }

        private void OnMoveScroll(IntPtr widget, IntPtr scrollType, IntPtr data)
        {
            int val = Marshal.ReadInt32(scrollType);
            GtkScrollType st = (GtkScrollType)val;
            MoveScroll?.Invoke(st);
        }

        private void OnPoppedUp(IntPtr widget, IntPtr flippedRect, IntPtr finalRect, bool flippedX, bool flippedY, IntPtr data)
        {
            PoppedUp?.Invoke(flippedX, flippedY);
        }
    }
}