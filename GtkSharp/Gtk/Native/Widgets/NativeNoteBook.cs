using System.Runtime.InteropServices;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeNoteBook
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_notebook_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_notebook_new();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_append_page(GtkWidgetPointer notebook, GtkWidgetPointer child, GtkWidgetPointer tab_label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_append_page_menu(GtkWidgetPointer notebook, GtkWidgetPointer child, GtkWidgetPointer tab_label, GtkWidgetPointer menu_label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_prepend_page(GtkWidgetPointer notebook, GtkWidgetPointer child, GtkWidgetPointer tab_label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_prepend_page_menu(GtkWidgetPointer notebook, GtkWidgetPointer child, GtkWidgetPointer tab_label, GtkWidgetPointer menu_label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_insert_page(GtkWidgetPointer notebook, GtkWidgetPointer child, GtkWidgetPointer tab_label, int position);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_insert_page_menu(GtkWidgetPointer notebook, GtkWidgetPointer child, GtkWidgetPointer tab_label, GtkWidgetPointer menu_label, int position);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_remove_page(GtkWidgetPointer notebook, int page_num); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_group_name(GtkWidgetPointer notebook, string group_name);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_notebook_get_group_name(GtkWidgetPointer notebook); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_get_current_page(GtkWidgetPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_notebook_get_nth_page(GtkWidgetPointer notebook, int page_num);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_get_n_pages(GtkWidgetPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_page_num(GtkWidgetPointer notebook, GtkWidgetPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_current_page(GtkWidgetPointer notebook, int page_num);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_next_page(GtkWidgetPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_prev_page(GtkWidgetPointer notebook); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_show_border(GtkWidgetPointer notebook, bool show_border);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_notebook_get_show_border(GtkWidgetPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_show_tabs(GtkWidgetPointer notebook, bool show_tabs);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_notebook_get_show_tabs(GtkWidgetPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_tab_pos(GtkWidgetPointer notebook, GtkPositionType pos);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkPositionType gtk_notebook_get_tab_pos(GtkWidgetPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_scrollable(GtkWidgetPointer notebook, bool scrollable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_notebook_get_scrollable(GtkWidgetPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ushort gtk_notebook_get_tab_hborder(GtkWidgetPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ushort gtk_notebook_get_tab_vborder(GtkWidgetPointer notebook); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_popup_enable(GtkWidgetPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_popup_disable(GtkWidgetPointer notebook); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_notebook_get_tab_label(GtkWidgetPointer notebook, GtkWidgetPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_tab_label(GtkWidgetPointer notebook, GtkWidgetPointer child, GtkWidgetPointer tab_label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_tab_label_text(GtkWidgetPointer notebook, GtkWidgetPointer child, string tab_text);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_notebook_get_tab_label_text(GtkWidgetPointer notebook, GtkWidgetPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_notebook_get_menu_label(GtkWidgetPointer notebook, GtkWidgetPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_menu_label(GtkWidgetPointer notebook, GtkWidgetPointer child, GtkWidgetPointer menu_label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_menu_label_text(GtkWidgetPointer notebook, GtkWidgetPointer child, string menu_text);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_notebook_get_menu_label_text(GtkWidgetPointer notebook, GtkWidgetPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_reorder_child(GtkWidgetPointer notebook, GtkWidgetPointer child, int position);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_notebook_get_tab_reorderable(GtkWidgetPointer notebook, GtkWidgetPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_tab_reorderable(GtkWidgetPointer notebook, GtkWidgetPointer child, bool reorderable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_notebook_get_tab_detachable(GtkWidgetPointer notebook, GtkWidgetPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_tab_detachable(GtkWidgetPointer notebook, GtkWidgetPointer child, bool detachable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_detach_tab(GtkWidgetPointer notebook, GtkWidgetPointer child); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_notebook_get_action_widget(GtkWidgetPointer notebook, GtkPackType pack_type);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_action_widget(GtkWidgetPointer notebook, GtkWidgetPointer widget, GtkPackType pack_type); 
    }
}