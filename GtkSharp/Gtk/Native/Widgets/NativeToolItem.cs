using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;
using GtkSharp.Pango.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    public static class NativeToolItem
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gtk_tool_item_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_tool_item_new(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_tool_item_set_homogeneous(GObjectPointer tool_item, bool homogeneous);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_tool_item_get_homogeneous(GObjectPointer tool_item); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_tool_item_set_expand(GObjectPointer tool_item, bool expand);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_tool_item_get_expand(GObjectPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_tool_item_set_tooltip_text(GObjectPointer tool_item, string text);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_tool_item_set_tooltip_markup(GObjectPointer tool_item, string markup); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_tool_item_set_use_drag_window(GObjectPointer tool_item, bool use_drag_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_tool_item_get_use_drag_window(GObjectPointer tool_item); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_tool_item_set_visible_horizontal(GObjectPointer tool_item, bool visible_horizontal);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_tool_item_get_visible_horizontal(GObjectPointer tool_item); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_tool_item_set_visible_vertical(GObjectPointer tool_item, bool visible_vertical);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_tool_item_get_visible_vertical(GObjectPointer tool_item); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_tool_item_get_is_important(GObjectPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_tool_item_set_is_important(GObjectPointer tool_item, bool is_important); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern PangoEllipsizeMode gtk_tool_item_get_ellipsize_mode(GObjectPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkIconSize gtk_tool_item_get_icon_size(GObjectPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkOrientation gtk_tool_item_get_orientation(GObjectPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkToolbarStyle gtk_tool_item_get_toolbar_style(GObjectPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkReliefStyle gtk_tool_item_get_relief_style(GObjectPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern float gtk_tool_item_get_text_alignment(GObjectPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkOrientation gtk_tool_item_get_text_orientation(GObjectPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkSizeGroupPointer gtk_tool_item_get_text_size_group(GObjectPointer tool_item); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_tool_item_retrieve_proxy_menu_item(GObjectPointer tool_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_tool_item_get_proxy_menu_item(GObjectPointer tool_item, string menu_item_id);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_tool_item_set_proxy_menu_item(GObjectPointer tool_item, string menu_item_id, GObjectPointer menu_item);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_tool_item_rebuild_menu(GObjectPointer tool_item); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_tool_item_toolbar_reconfigured(GObjectPointer tool_item);
    }
}