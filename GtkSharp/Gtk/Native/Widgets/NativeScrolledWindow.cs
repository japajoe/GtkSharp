using System.Runtime.InteropServices;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeScrolledWindow
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_scrolled_window_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_scrolled_window_new(GtkAdjustmentPointer hadjustment, GtkAdjustmentPointer vadjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_hadjustment(GtkWidgetPointer scrolled_window, GtkAdjustmentPointer hadjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_vadjustment(GtkWidgetPointer scrolled_window, GtkAdjustmentPointer vadjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkAdjustmentPointer gtk_scrolled_window_get_hadjustment(GtkWidgetPointer scrolled_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkAdjustmentPointer gtk_scrolled_window_get_vadjustment(GtkWidgetPointer scrolled_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_scrolled_window_get_hscrollbar(GtkWidgetPointer scrolled_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_scrolled_window_get_vscrollbar(GtkWidgetPointer scrolled_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_policy(GtkWidgetPointer scrolled_window, GtkPolicyType hscrollbar_policy, GtkPolicyType vscrollbar_policy);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_get_policy(GtkWidgetPointer scrolled_window, out GtkPolicyType hscrollbar_policy, out GtkPolicyType vscrollbar_policy);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_placement(GtkWidgetPointer scrolled_window, GtkCornerType window_placement);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_unset_placement(GtkWidgetPointer scrolled_window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkCornerType gtk_scrolled_window_get_placement(GtkWidgetPointer scrolled_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_shadow_type(GtkWidgetPointer scrolled_window, GtkShadowType type);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkShadowType gtk_scrolled_window_get_shadow_type(GtkWidgetPointer scrolled_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_add_with_viewport(GtkWidgetPointer scrolled_window, GtkWidgetPointer child); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_scrolled_window_get_min_content_width(GtkWidgetPointer scrolled_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_min_content_width(GtkWidgetPointer scrolled_window, int width);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_scrolled_window_get_min_content_height(GtkWidgetPointer scrolled_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_min_content_height(GtkWidgetPointer scrolled_window, int height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_kinetic_scrolling(GtkWidgetPointer scrolled_window, bool kinetic_scrolling);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_scrolled_window_get_kinetic_scrolling(GtkWidgetPointer scrolled_window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_capture_button_press(GtkWidgetPointer scrolled_window, bool capture_button_press);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_scrolled_window_get_capture_button_press(GtkWidgetPointer scrolled_window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_overlay_scrolling(GtkWidgetPointer scrolled_window, bool overlay_scrolling);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_scrolled_window_get_overlay_scrolling(GtkWidgetPointer scrolled_window);
    }
}