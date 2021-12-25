using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeScrolledWindow
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_scrolled_window_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_scrolled_window_new(GtkAdjustmentPointer hadjustment, GtkAdjustmentPointer vadjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_hadjustment(GObjectPointer scrolled_window, GtkAdjustmentPointer hadjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_vadjustment(GObjectPointer scrolled_window, GtkAdjustmentPointer vadjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkAdjustmentPointer gtk_scrolled_window_get_hadjustment(GObjectPointer scrolled_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkAdjustmentPointer gtk_scrolled_window_get_vadjustment(GObjectPointer scrolled_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_scrolled_window_get_hscrollbar(GObjectPointer scrolled_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_scrolled_window_get_vscrollbar(GObjectPointer scrolled_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_policy(GObjectPointer scrolled_window, GtkPolicyType hscrollbar_policy, GtkPolicyType vscrollbar_policy);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_get_policy(GObjectPointer scrolled_window, out GtkPolicyType hscrollbar_policy, out GtkPolicyType vscrollbar_policy);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_placement(GObjectPointer scrolled_window, GtkCornerType window_placement);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_unset_placement(GObjectPointer scrolled_window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkCornerType gtk_scrolled_window_get_placement(GObjectPointer scrolled_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_shadow_type(GObjectPointer scrolled_window, GtkShadowType type);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkShadowType gtk_scrolled_window_get_shadow_type(GObjectPointer scrolled_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_add_with_viewport(GObjectPointer scrolled_window, GObjectPointer child); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_scrolled_window_get_min_content_width(GObjectPointer scrolled_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_min_content_width(GObjectPointer scrolled_window, int width);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_scrolled_window_get_min_content_height(GObjectPointer scrolled_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_min_content_height(GObjectPointer scrolled_window, int height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_kinetic_scrolling(GObjectPointer scrolled_window, bool kinetic_scrolling);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_scrolled_window_get_kinetic_scrolling(GObjectPointer scrolled_window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_capture_button_press(GObjectPointer scrolled_window, bool capture_button_press);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_scrolled_window_get_capture_button_press(GObjectPointer scrolled_window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_scrolled_window_set_overlay_scrolling(GObjectPointer scrolled_window, bool overlay_scrolling);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_scrolled_window_get_overlay_scrolling(GObjectPointer scrolled_window);
    }
}