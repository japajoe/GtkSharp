using System;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Widgets
{
    public class Adjustment : Widget
    {
        internal Adjustment(IntPtr handle)
        {
            this.handle.pointer = handle;
        }

        public Adjustment(double value, double valueMin, double valueMax, double stepIncrement, double pageIncrement, double pageSize)
        {
            handle = NativeAdjustment.gtk_adjustment_new(value, valueMin, valueMax, stepIncrement, pageIncrement, pageSize);
        }        
    }
}