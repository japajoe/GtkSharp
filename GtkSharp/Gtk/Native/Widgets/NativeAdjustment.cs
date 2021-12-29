using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    public static class NativeAdjustment
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gtk_adjustment_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_adjustment_new(double value, double lower, double upper, double step_increment, double page_increment, double page_size); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_adjustment_changed(GObjectPointer adjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_adjustment_value_changed(GObjectPointer adjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_adjustment_clamp_page(GObjectPointer adjustment, double lower, double upper); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double gtk_adjustment_get_value(GObjectPointer adjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_adjustment_set_value(GObjectPointer adjustment, double value);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double gtk_adjustment_get_lower(GObjectPointer adjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_adjustment_set_lower(GObjectPointer adjustment, double lower);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double gtk_adjustment_get_upper(GObjectPointer adjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_adjustment_set_upper(GObjectPointer adjustment, double upper);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double gtk_adjustment_get_step_increment(GObjectPointer adjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_adjustment_set_step_increment(GObjectPointer adjustment, double step_increment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double gtk_adjustment_get_page_increment(GObjectPointer adjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_adjustment_set_page_increment(GObjectPointer adjustment, double page_increment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double gtk_adjustment_get_page_size(GObjectPointer adjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_adjustment_set_page_size(GObjectPointer adjustment, double page_size); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_adjustment_configure(GObjectPointer adjustment, double value, double lower, double upper, double step_increment, double page_increment, double page_size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double gtk_adjustment_get_minimum_increment(GObjectPointer adjustment);
    }
}