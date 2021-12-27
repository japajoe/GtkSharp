using System;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Types
{
    public class GtkAdjustment : GObject
    {
        internal GtkAdjustment(IntPtr handle) : base(handle)
        {
        }

        public GtkAdjustment(double value, double valueMin, double valueMax, double stepIncrement, double pageIncrement, double pageSize)
        {
            handle = NativeAdjustment.gtk_adjustment_new(value, valueMin, valueMax, stepIncrement, pageIncrement, pageSize);
        }
    }
}