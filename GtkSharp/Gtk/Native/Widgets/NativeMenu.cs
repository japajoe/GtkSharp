using System;
using System.Runtime.InteropServices;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    public static class NativeMenu
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gtk_menu_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_menu_new(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_menu_new_from_model(GMenuModelPointer model); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_popup(GObjectPointer menu, GObjectPointer parent_menu_shell, GObjectPointer parent_menu_item, IntPtr menuPositionFunc, IntPtr data, uint button, uint activate_time);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_popup_for_device(GObjectPointer menu, GdkDevicePointer device, GObjectPointer parent_menu_shell, GObjectPointer parent_menu_item, IntPtr menuPositionFunc, IntPtr data, IntPtr destroyCallback, uint button, uint activate_time); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_reposition(GObjectPointer menu); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_popdown(GObjectPointer menu); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_menu_get_active(GObjectPointer menu);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_set_active(GObjectPointer menu, uint index);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_set_accel_group(GObjectPointer menu, GtkAccelGroupPointer accel_group);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkAccelGroupPointer gtk_menu_get_accel_group(GObjectPointer menu);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_set_accel_path(GObjectPointer menu, string accel_path);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern string gtk_menu_get_accel_path(GObjectPointer menu); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_attach_to_widget(GObjectPointer menu, GObjectPointer attach_widget, IntPtr menuDetachFunc);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_detach(GObjectPointer menu); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_menu_get_attach_widget(GObjectPointer menu); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_set_tearoff_state(GObjectPointer menu, bool torn_off);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_menu_get_tearoff_state(GObjectPointer menu); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_set_title(GObjectPointer menu, string title);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern string  gtk_menu_get_title(GObjectPointer menu); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_reorder_child(GObjectPointer menu, GObjectPointer child, int position); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_set_screen(GObjectPointer menu, GdkScreenPointer screen); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_attach(GObjectPointer menu, GObjectPointer child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_set_monitor(GObjectPointer menu, int monitor_num);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_menu_get_monitor(GObjectPointer menu);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GListPointer gtk_menu_get_for_attach_widget(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_set_reserve_toggle_size(GObjectPointer menu, bool reserve_toggle_size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_menu_get_reserve_toggle_size(GObjectPointer menu);
    }
}