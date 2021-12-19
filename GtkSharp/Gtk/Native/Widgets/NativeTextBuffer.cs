using System;
using System.Runtime.InteropServices;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeTextBuffer
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_text_buffer_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_text_buffer_new(GtkTextTagTablePointer table);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_text_buffer_get_line_count(GObjectPointer buffer);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_text_buffer_get_char_count(GObjectPointer buffer); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextTagTablePointer gtk_text_buffer_get_tag_table(GObjectPointer buffer); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_set_text(GObjectPointer buffer, string text, int len); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_insert(GObjectPointer buffer, GtkTextIterPointer iter, string text, int len);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_insert_at_cursor(GObjectPointer buffer, string text, int len); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_insert_interactive(GObjectPointer buffer, GtkTextIterPointer iter, string text, int len, bool default_editable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_insert_interactive_at_cursor(GObjectPointer buffer, string text, int len, bool default_editable); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_insert_range(GObjectPointer buffer, GtkTextIterPointer iter, GtkTextIterPointer start, GtkTextIterPointer end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_insert_range_interactive(GObjectPointer buffer, GtkTextIterPointer iter, GtkTextIterPointer start, GtkTextIterPointer end, bool default_editable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_insert_markup(GObjectPointer buffer, GtkTextIterPointer iter, string markup, int len); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_delete(GObjectPointer buffer, ref GtkTextIter start, ref GtkTextIter end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_delete_interactive(GObjectPointer buffer, GtkTextIterPointer start_iter, GtkTextIterPointer end_iter, bool default_editable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_backspace(GObjectPointer buffer, GtkTextIterPointer iter, bool interactive, bool default_editable); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_text_buffer_get_text(GObjectPointer buffer, ref GtkTextIter start, ref GtkTextIter end, bool include_hidden_chars); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_text_buffer_get_slice(GObjectPointer buffer, GtkTextIterPointer start, GtkTextIterPointer end, bool include_hidden_chars); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_insert_pixbuf(GObjectPointer buffer, GtkTextIterPointer iter, GdkPixbufPointer pixbuf); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_insert_child_anchor(GObjectPointer buffer, GtkTextIterPointer iter, GtkTextChildAnchorPointer anchor); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextChildAnchorPointer gtk_text_buffer_create_child_anchor(GObjectPointer buffer, GtkTextIterPointer iter); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_add_mark(GObjectPointer buffer, GtkTextMarkPointer mark, GtkTextIterPointer where);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextMarkPointer gtk_text_buffer_create_mark(GObjectPointer buffer, string mark_name, GtkTextIterPointer where, bool left_gravity);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_move_mark(GObjectPointer buffer, GtkTextMarkPointer mark, GtkTextIterPointer where);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_delete_mark(GObjectPointer buffer, GtkTextMarkPointer mark);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextMarkPointer gtk_text_buffer_get_mark(GObjectPointer buffer, string name); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_move_mark_by_name(GObjectPointer buffer, string name, GtkTextIterPointer where);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_delete_mark_by_name(GObjectPointer buffer, string name); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextMarkPointer gtk_text_buffer_get_insert(GObjectPointer buffer);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextMarkPointer gtk_text_buffer_get_selection_bound(GObjectPointer buffer); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_place_cursor(GObjectPointer buffer, GtkTextIterPointer where);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_select_range(GObjectPointer buffer, GtkTextIterPointer ins, GtkTextIterPointer bound); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_apply_tag(GObjectPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_remove_tag(GObjectPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_apply_tag_by_name(GObjectPointer buffer, string name, GtkTextIterPointer start, GtkTextIterPointer end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_remove_tag_by_name(GObjectPointer buffer, string name, GtkTextIterPointer start, GtkTextIterPointer end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_remove_all_tags(GObjectPointer buffer, GtkTextIterPointer start, GtkTextIterPointer end); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_iter_at_line_offset(GObjectPointer buffer, out GtkTextIterPointer iter, int line_number, int char_offset);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_iter_at_line_index(GObjectPointer buffer, out GtkTextIterPointer iter, int line_number, int byte_index);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_iter_at_offset(GObjectPointer buffer, out GtkTextIterPointer iter, int char_offset);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_iter_at_line(GObjectPointer buffer, out GtkTextIterPointer iter, int line_number);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_start_iter(GObjectPointer buffer, out GtkTextIterPointer iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_end_iter(GObjectPointer buffer, out GtkTextIterPointer iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_bounds(GObjectPointer buffer, out GtkTextIter start, out GtkTextIter end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_iter_at_mark(GObjectPointer buffer, out GtkTextIterPointer iter, GtkTextMarkPointer mark); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_get_iter_at_child_anchor(GObjectPointer buffer, GtkTextIterPointer iter, GtkTextChildAnchorPointer anchor); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_get_modified(GObjectPointer buffer);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_set_modified(GObjectPointer buffer, bool setting); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_get_has_selection(GObjectPointer buffer); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_add_selection_clipboard(GObjectPointer buffer, GtkClipboardPointer clipboard);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_remove_selection_clipboard(GObjectPointer buffer, GtkClipboardPointer clipboard); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_cut_clipboard(GObjectPointer buffer, GtkClipboardPointer clipboard, bool default_editable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_copy_clipboard(GObjectPointer buffer, GtkClipboardPointer clipboard);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_paste_clipboard(GObjectPointer buffer, GtkClipboardPointer clipboard, GtkTextIterPointer override_location, bool default_editable); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_get_selection_bounds(GObjectPointer buffer, out GtkTextIterPointer start, out GtkTextIterPointer end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_buffer_delete_selection(GObjectPointer buffer, bool interactive, bool default_editable); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_begin_user_action(GObjectPointer buffer);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_buffer_end_user_action(GObjectPointer buffer); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTargetListPointer gtk_text_buffer_get_copy_target_list(GObjectPointer buffer);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTargetListPointer gtk_text_buffer_get_paste_target_list(GObjectPointer buffer); 
    }
}