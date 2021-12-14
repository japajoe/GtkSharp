using System;
using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeSourceBuffer
    {
        const string NATIVELIBNAME = "gtksourceview-3.0";

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_source_buffer_get_type();
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_source_buffer_new(GtkTextTagTablePointer table);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_source_buffer_new_with_language(GtkSourceLanguagePointer language);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_get_highlight_syntax(GtkWidgetPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_set_highlight_syntax(GtkWidgetPointer buffer, bool highlight);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_get_highlight_matching_brackets(GtkWidgetPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_set_highlight_matching_brackets(GtkWidgetPointer buffer, bool highlight);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_source_buffer_get_max_undo_levels(GtkWidgetPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_set_max_undo_levels(GtkWidgetPointer buffer, int max_undo_levels);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceLanguagePointer gtk_source_buffer_get_language(GtkWidgetPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_set_language(GtkWidgetPointer buffer, GtkSourceLanguagePointer language);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_can_undo(GtkWidgetPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_can_redo(GtkWidgetPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceStyleSchemePointer gtk_source_buffer_get_style_scheme(GtkWidgetPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_set_style_scheme(GtkWidgetPointer buffer, GtkSourceStyleSchemePointer scheme);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_ensure_highlight(GtkWidgetPointer buffer, ref GtkTextIter start, ref GtkTextIter end);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_undo(GtkWidgetPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_redo(GtkWidgetPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_begin_not_undoable_action(GtkWidgetPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_end_not_undoable_action(GtkWidgetPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceMarkPointer gtk_source_buffer_create_source_mark(GtkWidgetPointer buffer, string name, string category, ref GtkTextIter where);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_forward_iter_to_source_mark(GtkWidgetPointer buffer, ref GtkTextIter iter, string category);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_backward_iter_to_source_mark(GtkWidgetPointer buffer, ref GtkTextIter iter, string category);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GSListPointer gtk_source_buffer_get_source_marks_at_iter(GtkWidgetPointer buffer, ref GtkTextIter iter, string category);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GSListPointer gtk_source_buffer_get_source_marks_at_line(GtkWidgetPointer buffer, int line, string category);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_remove_source_marks(GtkWidgetPointer buffer, ref GtkTextIter start, ref GtkTextIter end, string category);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_iter_has_context_class(GtkWidgetPointer buffer, ref GtkTextIter iter, string context_class);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_source_buffer_get_context_classes_at_iter(GtkWidgetPointer buffer, ref GtkTextIter iter);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_iter_forward_to_context_class_toggle(GtkWidgetPointer buffer, ref GtkTextIter iter, string context_class);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_iter_backward_to_context_class_toggle (GtkWidgetPointer buffer, ref GtkTextIter iter, string context_class);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_change_case(GtkWidgetPointer buffer, GtkSourceChangeCaseType case_type, ref GtkTextIter start, ref GtkTextIter end);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_join_lines(GtkWidgetPointer buffer, ref GtkTextIter start, ref GtkTextIter end);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_sort_lines(GtkWidgetPointer buffer, ref GtkTextIter start, ref GtkTextIter end, GtkSourceSortFlags flags, int column);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceUndoManagerPointer gtk_source_buffer_get_undo_manager(GtkWidgetPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_set_undo_manager(GtkWidgetPointer buffer, GtkSourceUndoManagerPointer manager);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_set_implicit_trailing_newline(GtkWidgetPointer buffer, bool implicit_trailing_newline);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_get_implicit_trailing_newline(GtkWidgetPointer buffer);
    }
}