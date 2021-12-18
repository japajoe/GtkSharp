using System.Runtime.InteropServices;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;
using GtkSharp.Pango.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeToolItem
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_tool_item_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_tool_item_new(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tool_item_set_homogeneous(GtkWidgetPointer tool_item, bool homogeneous);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tool_item_get_homogeneous(GtkWidgetPointer tool_item); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tool_item_set_expand(GtkWidgetPointer tool_item, bool expand);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tool_item_get_expand(GtkWidgetPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tool_item_set_tooltip_text(GtkWidgetPointer tool_item, string text);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tool_item_set_tooltip_markup(GtkWidgetPointer tool_item, string markup); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tool_item_set_use_drag_window(GtkWidgetPointer tool_item, bool use_drag_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tool_item_get_use_drag_window(GtkWidgetPointer tool_item); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tool_item_set_visible_horizontal(GtkWidgetPointer tool_item, bool visible_horizontal);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tool_item_get_visible_horizontal(GtkWidgetPointer tool_item); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tool_item_set_visible_vertical(GtkWidgetPointer tool_item, bool visible_vertical);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tool_item_get_visible_vertical(GtkWidgetPointer tool_item); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_tool_item_get_is_important(GtkWidgetPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tool_item_set_is_important(GtkWidgetPointer tool_item, bool is_important); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern PangoEllipsizeMode gtk_tool_item_get_ellipsize_mode(GtkWidgetPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkIconSize gtk_tool_item_get_icon_size(GtkWidgetPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkOrientation gtk_tool_item_get_orientation(GtkWidgetPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkToolbarStyle gtk_tool_item_get_toolbar_style(GtkWidgetPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkReliefStyle gtk_tool_item_get_relief_style(GtkWidgetPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern float gtk_tool_item_get_text_alignment(GtkWidgetPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkOrientation gtk_tool_item_get_text_orientation(GtkWidgetPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSizeGroupPointer gtk_tool_item_get_text_size_group(GtkWidgetPointer tool_item); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_tool_item_retrieve_proxy_menu_item(GtkWidgetPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_tool_item_get_proxy_menu_item(GtkWidgetPointer tool_item, string menu_item_id);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tool_item_set_proxy_menu_item(GtkWidgetPointer tool_item, string menu_item_id, GtkWidgetPointer menu_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tool_item_rebuild_menu(GtkWidgetPointer tool_item); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_tool_item_toolbar_reconfigured(GtkWidgetPointer tool_item);
    }
}