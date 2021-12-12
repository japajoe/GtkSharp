using System;
using System.Runtime.InteropServices;
using GtkSharp.Native.Types;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeTextBuffer
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_text_buffer_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_text_buffer_new(GtkTextTagTablePointer table);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_text_buffer_get_line_count(GtkWidgetPointer buffer);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_text_buffer_get_char_count(GtkWidgetPointer buffer); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextTagTablePointer gtk_text_buffer_get_tag_table(GtkWidgetPointer buffer); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_set_text(GtkWidgetPointer buffer, string text, int len); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_insert(GtkWidgetPointer buffer, GtkTextIterPointer iter, string text, int len);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_insert_at_cursor(GtkWidgetPointer buffer, string text, int len); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_insert_interactive(GtkWidgetPointer buffer, GtkTextIterPointer iter, string text, int len, bool default_editable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_insert_interactive_at_cursor(GtkWidgetPointer buffer, string text, int len, bool default_editable); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_insert_range(GtkWidgetPointer buffer, GtkTextIterPointer iter, GtkTextIterPointer start, GtkTextIterPointer end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_insert_range_interactive(GtkWidgetPointer buffer, GtkTextIterPointer iter, GtkTextIterPointer start, GtkTextIterPointer end, bool default_editable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_insert_markup(GtkWidgetPointer buffer, GtkTextIterPointer iter, string markup, int len); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_delete(GtkWidgetPointer buffer, ref GtkTextIter start, ref GtkTextIter end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_delete_interactive(GtkWidgetPointer buffer, GtkTextIterPointer start_iter, GtkTextIterPointer end_iter, bool default_editable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_backspace(GtkWidgetPointer buffer, GtkTextIterPointer iter, bool interactive, bool default_editable); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_text_buffer_get_text(GtkWidgetPointer buffer, ref GtkTextIter start, ref GtkTextIter end, bool include_hidden_chars); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_text_buffer_get_slice(GtkWidgetPointer buffer, GtkTextIterPointer start, GtkTextIterPointer end, bool include_hidden_chars); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_insert_pixbuf(GtkWidgetPointer buffer, GtkTextIterPointer iter, GdkPixbufPointer pixbuf); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_insert_child_anchor(GtkWidgetPointer buffer, GtkTextIterPointer iter, GtkTextChildAnchorPointer anchor); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextChildAnchorPointer gtk_text_buffer_create_child_anchor(GtkWidgetPointer buffer, GtkTextIterPointer iter); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_add_mark(GtkWidgetPointer buffer, GtkTextMarkPointer mark, GtkTextIterPointer where);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextMarkPointer gtk_text_buffer_create_mark(GtkWidgetPointer buffer, string mark_name, GtkTextIterPointer where, bool left_gravity);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_move_mark(GtkWidgetPointer buffer, GtkTextMarkPointer mark, GtkTextIterPointer where);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_delete_mark(GtkWidgetPointer buffer, GtkTextMarkPointer mark);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextMarkPointer gtk_text_buffer_get_mark(GtkWidgetPointer buffer, string name); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_move_mark_by_name(GtkWidgetPointer buffer, string name, GtkTextIterPointer where);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_delete_mark_by_name(GtkWidgetPointer buffer, string name); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextMarkPointer gtk_text_buffer_get_insert(GtkWidgetPointer buffer);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextMarkPointer gtk_text_buffer_get_selection_bound(GtkWidgetPointer buffer); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_place_cursor(GtkWidgetPointer buffer, GtkTextIterPointer where);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_select_range(GtkWidgetPointer buffer, GtkTextIterPointer ins, GtkTextIterPointer bound); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_apply_tag(GtkWidgetPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_remove_tag(GtkWidgetPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_apply_tag_by_name(GtkWidgetPointer buffer, string name, GtkTextIterPointer start, GtkTextIterPointer end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_remove_tag_by_name(GtkWidgetPointer buffer, string name, GtkTextIterPointer start, GtkTextIterPointer end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_remove_all_tags(GtkWidgetPointer buffer, GtkTextIterPointer start, GtkTextIterPointer end); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_iter_at_line_offset(GtkWidgetPointer buffer, out GtkTextIterPointer iter, int line_number, int char_offset);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_iter_at_line_index(GtkWidgetPointer buffer, out GtkTextIterPointer iter, int line_number, int byte_index);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_iter_at_offset(GtkWidgetPointer buffer, out GtkTextIterPointer iter, int char_offset);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_iter_at_line(GtkWidgetPointer buffer, out GtkTextIterPointer iter, int line_number);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_start_iter(GtkWidgetPointer buffer, out GtkTextIterPointer iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_end_iter(GtkWidgetPointer buffer, out GtkTextIterPointer iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_bounds(GtkWidgetPointer buffer, out GtkTextIter start, out GtkTextIter end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_iter_at_mark(GtkWidgetPointer buffer, out GtkTextIterPointer iter, GtkTextMarkPointer mark); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_iter_at_child_anchor(GtkWidgetPointer buffer, GtkTextIterPointer iter, GtkTextChildAnchorPointer anchor); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_get_modified(GtkWidgetPointer buffer);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_set_modified(GtkWidgetPointer buffer, bool setting); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_get_has_selection(GtkWidgetPointer buffer); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_add_selection_clipboard(GtkWidgetPointer buffer, GtkClipboardPointer clipboard);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_remove_selection_clipboard(GtkWidgetPointer buffer, GtkClipboardPointer clipboard); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_cut_clipboard(GtkWidgetPointer buffer, GtkClipboardPointer clipboard, bool default_editable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_copy_clipboard(GtkWidgetPointer buffer, GtkClipboardPointer clipboard);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_paste_clipboard(GtkWidgetPointer buffer, GtkClipboardPointer clipboard, GtkTextIterPointer override_location, bool default_editable); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_get_selection_bounds(GtkWidgetPointer buffer, out GtkTextIterPointer start, out GtkTextIterPointer end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_delete_selection(GtkWidgetPointer buffer, bool interactive, bool default_editable); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_begin_user_action(GtkWidgetPointer buffer);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_end_user_action(GtkWidgetPointer buffer); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTargetListPointer gtk_text_buffer_get_copy_target_list(GtkWidgetPointer buffer);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTargetListPointer gtk_text_buffer_get_paste_target_list(GtkWidgetPointer buffer); 
    }
}