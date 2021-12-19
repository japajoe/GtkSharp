using System;
using GtkSharp.Glib.Native.Types;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Types
{
    public class GtkAdjustment : GObject
    {
        internal GObjectPointer handle;
        
        internal GtkAdjustment(IntPtr handle)
        {
            this.handle.pointer = handle;
        }

        public GtkAdjustment(double value, double valueMin, double valueMax, double stepIncrement, double pageIncrement, double pageSize)
        {
            handle = NativeAdjustment.gtk_adjustment_new(value, valueMin, valueMax, stepIncrement, pageIncrement, pageSize);
        }        
    }
}