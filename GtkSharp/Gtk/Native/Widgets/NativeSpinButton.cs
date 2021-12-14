using System.Runtime.InteropServices;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeSpinButton
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_spin_button_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_configure(GtkWidgetPointer spin_button, GtkAdjustmentPointer adjustment, double climb_rate, uint digits); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_spin_button_new(GtkAdjustmentPointer adjustment, double climb_rate, uint digits); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_spin_button_new_with_range(double min, double max, double step); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_adjustment(GtkWidgetPointer spin_button, GtkAdjustmentPointer adjustment); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkAdjustmentPointer gtk_spin_button_get_adjustment(GtkWidgetPointer spin_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_digits(GtkWidgetPointer spin_button, uint digits);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_spin_button_get_digits(GtkWidgetPointer spin_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_increments(GtkWidgetPointer spin_button, double step, double page);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_get_increments(GtkWidgetPointer spin_button, out double step, out double page); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_range(GtkWidgetPointer spin_button, double min, double max);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_get_range(GtkWidgetPointer spin_button, out double min, out double max); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern double gtk_spin_button_get_value(GtkWidgetPointer spin_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_spin_button_get_value_as_int(GtkWidgetPointer spin_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_value(GtkWidgetPointer spin_button, double value); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_update_policy(GtkWidgetPointer spin_button, GtkSpinButtonUpdatePolicy policy);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSpinButtonUpdatePolicy gtk_spin_button_get_update_policy(GtkWidgetPointer spin_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_numeric(GtkWidgetPointer spin_button, bool numeric);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_spin_button_get_numeric(GtkWidgetPointer spin_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_spin(GtkWidgetPointer spin_button, GtkSpinType direction, double increment); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_wrap(GtkWidgetPointer spin_button, bool wrap);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_spin_button_get_wrap(GtkWidgetPointer spin_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_snap_to_ticks(GtkWidgetPointer spin_button, bool snap_to_ticks);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_spin_button_get_snap_to_ticks(GtkWidgetPointer spin_button);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_update(GtkWidgetPointer spin_button);
    }
}