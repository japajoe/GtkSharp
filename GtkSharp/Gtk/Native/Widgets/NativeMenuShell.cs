using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    public static class NativeMenuShell
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gtk_menu_shell_get_type(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_shell_append(GObjectPointer menu_shell, GObjectPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_shell_prepend(GObjectPointer menu_shell, GObjectPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_shell_insert(GObjectPointer menu_shell, GObjectPointer child, int position);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_shell_deactivate(GObjectPointer menu_shell);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_shell_select_item(GObjectPointer menu_shell, GObjectPointer menu_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_shell_deselect(GObjectPointer menu_shell);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_shell_activate_item(GObjectPointer menu_shell, GObjectPointer menu_item, bool force_deactivate);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_shell_select_first(GObjectPointer menu_shell, bool search_sensitive);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_shell_cancel(GObjectPointer menu_shell);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_menu_shell_get_take_focus(GObjectPointer menu_shell);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_shell_set_take_focus(GObjectPointer menu_shell, bool take_focus); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_menu_shell_get_selected_item(GObjectPointer menu_shell);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_menu_shell_get_parent_shell(GObjectPointer menu_shell); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_menu_shell_bind_model(GObjectPointer menu_shell, GMenuModelPointer model, string action_namespace, bool with_separators);
    }
}