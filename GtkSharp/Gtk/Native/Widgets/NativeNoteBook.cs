using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeNoteBook
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_notebook_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_notebook_new();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_append_page(GObjectPointer notebook, GObjectPointer child, GObjectPointer tab_label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_append_page_menu(GObjectPointer notebook, GObjectPointer child, GObjectPointer tab_label, GObjectPointer menu_label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_prepend_page(GObjectPointer notebook, GObjectPointer child, GObjectPointer tab_label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_prepend_page_menu(GObjectPointer notebook, GObjectPointer child, GObjectPointer tab_label, GObjectPointer menu_label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_insert_page(GObjectPointer notebook, GObjectPointer child, GObjectPointer tab_label, int position);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_insert_page_menu(GObjectPointer notebook, GObjectPointer child, GObjectPointer tab_label, GObjectPointer menu_label, int position);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_remove_page(GObjectPointer notebook, int page_num); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_group_name(GObjectPointer notebook, string group_name);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_notebook_get_group_name(GObjectPointer notebook); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_get_current_page(GObjectPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_notebook_get_nth_page(GObjectPointer notebook, int page_num);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_get_n_pages(GObjectPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_notebook_page_num(GObjectPointer notebook, GObjectPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_current_page(GObjectPointer notebook, int page_num);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_next_page(GObjectPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_prev_page(GObjectPointer notebook); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_show_border(GObjectPointer notebook, bool show_border);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_notebook_get_show_border(GObjectPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_show_tabs(GObjectPointer notebook, bool show_tabs);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_notebook_get_show_tabs(GObjectPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_tab_pos(GObjectPointer notebook, GtkPositionType pos);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkPositionType gtk_notebook_get_tab_pos(GObjectPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_scrollable(GObjectPointer notebook, bool scrollable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_notebook_get_scrollable(GObjectPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ushort gtk_notebook_get_tab_hborder(GObjectPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ushort gtk_notebook_get_tab_vborder(GObjectPointer notebook); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_popup_enable(GObjectPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_popup_disable(GObjectPointer notebook); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_notebook_get_tab_label(GObjectPointer notebook, GObjectPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_tab_label(GObjectPointer notebook, GObjectPointer child, GObjectPointer tab_label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_tab_label_text(GObjectPointer notebook, GObjectPointer child, string tab_text);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_notebook_get_tab_label_text(GObjectPointer notebook, GObjectPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_notebook_get_menu_label(GObjectPointer notebook, GObjectPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_menu_label(GObjectPointer notebook, GObjectPointer child, GObjectPointer menu_label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_menu_label_text(GObjectPointer notebook, GObjectPointer child, string menu_text);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_notebook_get_menu_label_text(GObjectPointer notebook, GObjectPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_reorder_child(GObjectPointer notebook, GObjectPointer child, int position);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_notebook_get_tab_reorderable(GObjectPointer notebook, GObjectPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_tab_reorderable(GObjectPointer notebook, GObjectPointer child, bool reorderable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_notebook_get_tab_detachable(GObjectPointer notebook, GObjectPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_tab_detachable(GObjectPointer notebook, GObjectPointer child, bool detachable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_detach_tab(GObjectPointer notebook, GObjectPointer child); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_notebook_get_action_widget(GObjectPointer notebook, GtkPackType pack_type);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_notebook_set_action_widget(GObjectPointer notebook, GObjectPointer widget, GtkPackType pack_type); 
    }
}