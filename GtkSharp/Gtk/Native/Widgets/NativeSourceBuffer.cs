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
        internal static extern GObjectPointer gtk_source_buffer_new(GtkTextTagTablePointer table);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_source_buffer_new_with_language(GtkSourceLanguagePointer language);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_get_highlight_syntax(GObjectPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_set_highlight_syntax(GObjectPointer buffer, bool highlight);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_get_highlight_matching_brackets(GObjectPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_set_highlight_matching_brackets(GObjectPointer buffer, bool highlight);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_source_buffer_get_max_undo_levels(GObjectPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_set_max_undo_levels(GObjectPointer buffer, int max_undo_levels);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceLanguagePointer gtk_source_buffer_get_language(GObjectPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_set_language(GObjectPointer buffer, GtkSourceLanguagePointer language);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_can_undo(GObjectPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_can_redo(GObjectPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceStyleSchemePointer gtk_source_buffer_get_style_scheme(GObjectPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_set_style_scheme(GObjectPointer buffer, GtkSourceStyleSchemePointer scheme);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_ensure_highlight(GObjectPointer buffer, ref GtkTextIter start, ref GtkTextIter end);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_undo(GObjectPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_redo(GObjectPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_begin_not_undoable_action(GObjectPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_end_not_undoable_action(GObjectPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceMarkPointer gtk_source_buffer_create_source_mark(GObjectPointer buffer, string name, string category, ref GtkTextIter where);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_forward_iter_to_source_mark(GObjectPointer buffer, ref GtkTextIter iter, string category);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_backward_iter_to_source_mark(GObjectPointer buffer, ref GtkTextIter iter, string category);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GSListPointer gtk_source_buffer_get_source_marks_at_iter(GObjectPointer buffer, ref GtkTextIter iter, string category);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GSListPointer gtk_source_buffer_get_source_marks_at_line(GObjectPointer buffer, int line, string category);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_remove_source_marks(GObjectPointer buffer, ref GtkTextIter start, ref GtkTextIter end, string category);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_iter_has_context_class(GObjectPointer buffer, ref GtkTextIter iter, string context_class);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_source_buffer_get_context_classes_at_iter(GObjectPointer buffer, ref GtkTextIter iter);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_iter_forward_to_context_class_toggle(GObjectPointer buffer, ref GtkTextIter iter, string context_class);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_iter_backward_to_context_class_toggle (GObjectPointer buffer, ref GtkTextIter iter, string context_class);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_change_case(GObjectPointer buffer, GtkSourceChangeCaseType case_type, ref GtkTextIter start, ref GtkTextIter end);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_join_lines(GObjectPointer buffer, ref GtkTextIter start, ref GtkTextIter end);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_sort_lines(GObjectPointer buffer, ref GtkTextIter start, ref GtkTextIter end, GtkSourceSortFlags flags, int column);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSourceUndoManagerPointer gtk_source_buffer_get_undo_manager(GObjectPointer buffer);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_set_undo_manager(GObjectPointer buffer, GtkSourceUndoManagerPointer manager);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_source_buffer_set_implicit_trailing_newline(GObjectPointer buffer, bool implicit_trailing_newline);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_source_buffer_get_implicit_trailing_newline(GObjectPointer buffer);
    }
}