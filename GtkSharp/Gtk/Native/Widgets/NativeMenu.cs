using System;
using System.Runtime.InteropServices;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeMenu
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_menu_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_menu_new(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_menu_new_from_model(GMenuModelPointer model); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_popup(GtkWidgetPointer menu, GtkWidgetPointer parent_menu_shell, GtkWidgetPointer parent_menu_item, IntPtr menuPositionFunc, IntPtr data, uint button, uint activate_time);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_popup_for_device(GtkWidgetPointer menu, GdkDevicePointer device, GtkWidgetPointer parent_menu_shell, GtkWidgetPointer parent_menu_item, IntPtr menuPositionFunc, IntPtr data, IntPtr destroyCallback, uint button, uint activate_time); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_reposition(GtkWidgetPointer menu); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_popdown(GtkWidgetPointer menu); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_menu_get_active(GtkWidgetPointer menu);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_set_active(GtkWidgetPointer menu, uint index);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_set_accel_group(GtkWidgetPointer menu, GtkAccelGroupPointer accel_group);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkAccelGroupPointer gtk_menu_get_accel_group(GtkWidgetPointer menu);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_set_accel_path(GtkWidgetPointer menu, string accel_path);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_menu_get_accel_path(GtkWidgetPointer menu); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_attach_to_widget(GtkWidgetPointer menu, GtkWidgetPointer attach_widget, IntPtr menuDetachFunc);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_detach(GtkWidgetPointer menu); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_menu_get_attach_widget(GtkWidgetPointer menu); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_set_tearoff_state(GtkWidgetPointer menu, bool torn_off);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_menu_get_tearoff_state(GtkWidgetPointer menu); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_set_title(GtkWidgetPointer menu, string title);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string  gtk_menu_get_title(GtkWidgetPointer menu); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_reorder_child(GtkWidgetPointer menu, GtkWidgetPointer child, int position); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_set_screen(GtkWidgetPointer menu, GdkScreenPointer screen); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_attach(GtkWidgetPointer menu, GtkWidgetPointer child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_set_monitor(GtkWidgetPointer menu, int monitor_num);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_menu_get_monitor(GtkWidgetPointer menu);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GListPointer gtk_menu_get_for_attach_widget(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_set_reserve_toggle_size(GtkWidgetPointer menu, bool reserve_toggle_size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_menu_get_reserve_toggle_size(GtkWidgetPointer menu);
    }
}