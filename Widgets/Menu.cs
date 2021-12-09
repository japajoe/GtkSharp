using System;
using System.Runtime.InteropServices;
using GtkSharp.Native;

namespace GtkSharp
{
    public class Menu : Widget
    {
        public event GtkMenuMoveScrollEvent onMoveScroll;
        public event GtkMenuPoppedUpEvent onPoppedUp;

        private GtkMenuMoveScrollCallback onMenuMoveScroll;
        private GtkMenuPoppedUpCallback onMenuPoppedUp;

        public Menu(IntPtr widgetPointer)
        {
            this.handle.pointer = widgetPointer;
        }
        
        public Menu()
        {
            Gtk.GtkSharpMenuCreate(out handle);
            RegisterCallbacks();
        }

        protected override void RegisterCallbacks()
        {
            onMenuMoveScroll = OnMoveScroll;
            onMenuPoppedUp = OnPoppedUp;
            Gtk.GtkSharpSignalConnect(out handle.pointer, "move-scroll", onMenuMoveScroll.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "popped-up", onMenuPoppedUp.ToIntPtr(), out handle.pointer);
        }        

        public void ShellAppend(MenuItem menuItem)
        {
            Gtk.GtkSharpMenuShellAppend(out handle.pointer, out menuItem.handle.pointer);
        }

        private void OnMoveScroll(IntPtr widget, IntPtr scrollType, IntPtr data)
        {
            int val = Marshal.ReadInt32(scrollType);
            GtkScrollType st = (GtkScrollType)val;
            onMoveScroll?.Invoke(st);
        }

        private void OnPoppedUp(IntPtr widget, IntPtr flippedRect, IntPtr finalRect, bool flippedX, bool flippedY, IntPtr data)
        {
            onPoppedUp?.Invoke(flippedX, flippedY);
        }
    }
}