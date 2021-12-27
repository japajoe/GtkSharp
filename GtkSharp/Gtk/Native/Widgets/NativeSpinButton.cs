using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeSpinButton
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_spin_button_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_configure(GObjectPointer spin_button, GObjectPointer adjustment, double climb_rate, uint digits); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_spin_button_new(GObjectPointer adjustment, double climb_rate, uint digits); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_spin_button_new_with_range(double min, double max, double step); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_adjustment(GObjectPointer spin_button, GObjectPointer adjustment); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_spin_button_get_adjustment(GObjectPointer spin_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_digits(GObjectPointer spin_button, uint digits);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_spin_button_get_digits(GObjectPointer spin_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_increments(GObjectPointer spin_button, double step, double page);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_get_increments(GObjectPointer spin_button, out double step, out double page); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_range(GObjectPointer spin_button, double min, double max);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_get_range(GObjectPointer spin_button, out double min, out double max); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern double gtk_spin_button_get_value(GObjectPointer spin_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_spin_button_get_value_as_int(GObjectPointer spin_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_value(GObjectPointer spin_button, double value); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_update_policy(GObjectPointer spin_button, GtkSpinButtonUpdatePolicy policy);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSpinButtonUpdatePolicy gtk_spin_button_get_update_policy(GObjectPointer spin_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_numeric(GObjectPointer spin_button, bool numeric);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_spin_button_get_numeric(GObjectPointer spin_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_spin(GObjectPointer spin_button, GtkSpinType direction, double increment); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_wrap(GObjectPointer spin_button, bool wrap);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_spin_button_get_wrap(GObjectPointer spin_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_set_snap_to_ticks(GObjectPointer spin_button, bool snap_to_ticks);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_spin_button_get_snap_to_ticks(GObjectPointer spin_button);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_spin_button_update(GObjectPointer spin_button);
    }
}