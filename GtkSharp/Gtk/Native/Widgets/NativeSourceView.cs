using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    public static class NativeSourceView
    {
        const string NATIVELIBNAME = "gtksourceview-3.0";

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gtk_source_view_get_type();
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_source_view_new();
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_source_view_new_with_buffer(GObjectPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_set_show_line_numbers(GObjectPointer view, bool show);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_source_view_get_show_line_numbers(GObjectPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_set_tab_width(GObjectPointer view, uint width);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint gtk_source_view_get_tab_width(GObjectPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_set_indent_width(GObjectPointer view, int width);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_source_view_get_indent_width(GObjectPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_set_auto_indent(GObjectPointer view, bool enable);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_source_view_get_auto_indent(GObjectPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_set_insert_spaces_instead_of_tabs(GObjectPointer view, bool enable);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_source_view_get_insert_spaces_instead_of_tabs(GObjectPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_set_indent_on_tab(GObjectPointer view, bool enable);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_source_view_get_indent_on_tab(GObjectPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_indent_lines(GObjectPointer view, ref GtkTextIter start, ref GtkTextIter end);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_unindent_lines(GObjectPointer view, ref GtkTextIter start, ref GtkTextIter end);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_set_highlight_current_line(GObjectPointer view, bool highlight);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_source_view_get_highlight_current_line(GObjectPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_set_show_right_margin(GObjectPointer view, bool show);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_source_view_get_show_right_margin(GObjectPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_set_right_margin_position(GObjectPointer view, uint pos);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint gtk_source_view_get_right_margin_position(GObjectPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_set_show_line_marks(GObjectPointer view, bool show);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_source_view_get_show_line_marks(GObjectPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_set_mark_attributes(GObjectPointer view, string category, GtkSourceMarkAttributesPointer attributes, int priority);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkSourceMarkAttributesPointer gtk_source_view_get_mark_attributes(GObjectPointer view, string category, out int priority);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_set_smart_backspace(GObjectPointer view, bool smart_backspace);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_source_view_get_smart_backspace(GObjectPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_set_smart_home_end(GObjectPointer view, GtkSourceSmartHomeEndType smart_home_end);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkSourceSmartHomeEndType gtk_source_view_get_smart_home_end(GObjectPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_set_draw_spaces(GObjectPointer view, GtkSourceDrawSpacesFlags flags);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkSourceDrawSpacesFlags gtk_source_view_get_draw_spaces(GObjectPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint gtk_source_view_get_visual_column(GObjectPointer view, ref GtkTextIter iter);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkSourceCompletionPointer gtk_source_view_get_completion(GObjectPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkSourceGutterPointer gtk_source_view_get_gutter(GObjectPointer view, GtkTextWindowType window_type);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_source_view_set_background_pattern(GObjectPointer view, GtkSourceBackgroundPatternType background_pattern);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkSourceBackgroundPatternType gtk_source_view_get_background_pattern(GObjectPointer view);   
    }
}