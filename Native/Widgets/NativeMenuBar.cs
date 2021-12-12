using System.Runtime.InteropServices;
using GtkSharp.Native.Types;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeMenuBar
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_menu_bar_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_menu_bar_new();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_menu_bar_new_from_model(GtkMenuModelPointer model); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkPackDirection gtk_menu_bar_get_pack_direction(GtkWidgetPointer menubar);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_bar_set_pack_direction(GtkWidgetPointer menubar, GtkPackDirection pack_dir);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkPackDirection gtk_menu_bar_get_child_pack_direction(GtkWidgetPointer menubar);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_bar_set_child_pack_direction(GtkWidgetPointer menubar, GtkPackDirection child_pack_dir);
    }
}