using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeSourceView
    {
        const string NATIVELIBNAME = "gtksourceview-3.0";

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_source_view_get_type();
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_source_view_new();
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_source_view_new_with_buffer(GObjectPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_set_show_line_numbers(GtkWidgetPointer view, bool show);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_view_get_show_line_numbers(GtkWidgetPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_set_tab_width(GtkWidgetPointer view, uint width);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_source_view_get_tab_width(GtkWidgetPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_set_indent_width(GtkWidgetPointer view, int width);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_source_view_get_indent_width(GtkWidgetPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_set_auto_indent(GtkWidgetPointer view, bool enable);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_view_get_auto_indent(GtkWidgetPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_set_insert_spaces_instead_of_tabs(GtkWidgetPointer view, bool enable);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_view_get_insert_spaces_instead_of_tabs(GtkWidgetPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_set_indent_on_tab(GtkWidgetPointer view, bool enable);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_view_get_indent_on_tab(GtkWidgetPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_indent_lines(GtkWidgetPointer view, ref GtkTextIter start, ref GtkTextIter end);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_unindent_lines(GtkWidgetPointer view, ref GtkTextIter start, ref GtkTextIter end);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_set_highlight_current_line(GtkWidgetPointer view, bool highlight);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_view_get_highlight_current_line(GtkWidgetPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_set_show_right_margin(GtkWidgetPointer view, bool show);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_view_get_show_right_margin(GtkWidgetPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_set_right_margin_position(GtkWidgetPointer view, uint pos);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_source_view_get_right_margin_position(GtkWidgetPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_set_show_line_marks(GtkWidgetPointer view, bool show);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_view_get_show_line_marks(GtkWidgetPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_set_mark_attributes(GtkWidgetPointer view, string category, GtkSourceMarkAttributesPointer attributes, int priority);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceMarkAttributesPointer gtk_source_view_get_mark_attributes(GtkWidgetPointer view, string category, out int priority);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_set_smart_backspace(GtkWidgetPointer view, bool smart_backspace);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_view_get_smart_backspace(GtkWidgetPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_set_smart_home_end(GtkWidgetPointer view, GtkSourceSmartHomeEndType smart_home_end);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceSmartHomeEndType gtk_source_view_get_smart_home_end(GtkWidgetPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_set_draw_spaces(GtkWidgetPointer view, GtkSourceDrawSpacesFlags flags);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceDrawSpacesFlags gtk_source_view_get_draw_spaces(GtkWidgetPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_source_view_get_visual_column(GtkWidgetPointer view, ref GtkTextIter iter);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceCompletionPointer gtk_source_view_get_completion(GtkWidgetPointer view);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceGutterPointer gtk_source_view_get_gutter(GtkWidgetPointer view, GtkTextWindowType window_type);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_view_set_background_pattern(GtkWidgetPointer view, GtkSourceBackgroundPatternType background_pattern);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceBackgroundPatternType gtk_source_view_get_background_pattern(GtkWidgetPointer view);   
    }
}