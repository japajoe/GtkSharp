using System;
using GtkSharp.Native;
using GtkSharp.Drawing;

namespace GtkSharp
{
    public class DrawingArea : Widget
    {
        public event DrawEvent onDraw;

        private GtkDrawingAreaDrawCallback onDrawNative;
        private Cairo cairo;

        public DrawingArea(int width, int height)
        {
            Gtk.GtkSharpDrawingAreaCreate(out handle, width, height);
            SetSize(width, height);
            
            cairo = new Cairo();
            onDrawNative = GtkSharpDelegate.Create<GtkDrawingAreaDrawCallback>(this, "OnDraw");

            Gtk.GtkSharpDrawingAreaDrawCallbackConnect(out handle, onDrawNative);
        }

        private bool OnDraw(IntPtr widget, IntPtr cr, IntPtr data)
        {
            cairo.cr.pointer = cr;
            onDraw?.Invoke(cairo);
            return false;
        }
    }
}