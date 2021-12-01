using System;
using GtkSharp.Native;

namespace GtkSharp
{
    public class DrawingArea : Widget
    {
        public event DrawEvent onDraw;

        private GtkDrawingAreaDrawCallback onDrawNative;

        public DrawingArea(int width, int height)
        {
            Gtk.GtkSharpDrawingAreaCreate(out handle.pointer, width, height);
            SetSize(width, height);
            onDrawNative = GtkSharpDelegate.Create<GtkDrawingAreaDrawCallback>(this, "OnDraw");
            Gtk.GtkSharpDrawingAreaDrawCallbackConnect(out handle.pointer, onDrawNative);
        }

        private bool OnDraw(IntPtr widget, IntPtr cr, IntPtr data)
        {
            onDraw?.Invoke(cr);
            return false;
        }
    }
}