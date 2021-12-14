using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeMenuShell
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_menu_shell_get_type(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_shell_append(GtkWidgetPointer menu_shell, GtkWidgetPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_shell_prepend(GtkWidgetPointer menu_shell, GtkWidgetPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_shell_insert(GtkWidgetPointer menu_shell, GtkWidgetPointer child, int position);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_shell_deactivate(GtkWidgetPointer menu_shell);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_shell_select_item(GtkWidgetPointer menu_shell, GtkWidgetPointer menu_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_shell_deselect(GtkWidgetPointer menu_shell);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_shell_activate_item(GtkWidgetPointer menu_shell, GtkWidgetPointer menu_item, bool force_deactivate);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_shell_select_first(GtkWidgetPointer menu_shell, bool search_sensitive);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_shell_cancel(GtkWidgetPointer menu_shell);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_menu_shell_get_take_focus(GtkWidgetPointer menu_shell);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_shell_set_take_focus(GtkWidgetPointer menu_shell, bool take_focus); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_menu_shell_get_selected_item(GtkWidgetPointer menu_shell);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_menu_shell_get_parent_shell(GtkWidgetPointer menu_shell); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_shell_bind_model(GtkWidgetPointer menu_shell, GMenuModelPointer model, string action_namespace, bool with_separators);
    }
}