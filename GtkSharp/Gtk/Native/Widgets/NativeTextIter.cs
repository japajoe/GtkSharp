using System;
using System.Runtime.InteropServices;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;
using GtkSharp.Pango.Native.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    public static class NativeTextIter
    { 
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gtk_text_iter_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkTextBufferPointer gtk_text_iter_get_buffer(out GtkTextIter iter); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkTextIterPointer gtk_text_iter_copy(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_text_iter_free(GtkTextIterPointer iter); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_text_iter_assign(out GtkTextIter iter, ref GtkTextIter other); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_text_iter_get_offset(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_text_iter_get_line(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_text_iter_get_line_offset(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_text_iter_get_line_index(ref GtkTextIter iter); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_text_iter_get_visible_line_offset(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_text_iter_get_visible_line_index(ref GtkTextIter iter); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint gtk_text_iter_get_char(ref GtkTextIter iter); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_text_iter_get_slice(ref GtkTextIter start, ref GtkTextIter end); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_text_iter_get_text(ref GtkTextIter start, ref GtkTextIter end); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_text_iter_get_visible_slice(ref GtkTextIter start, ref GtkTextIter end);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_text_iter_get_visible_text(ref GtkTextIter start, ref GtkTextIter end); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkPixbufPointer gtk_text_iter_get_pixbuf(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer gtk_text_iter_get_marks(ref GtkTextIter iter); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkTextChildAnchorPointer gtk_text_iter_get_child_anchor(ref GtkTextIter iter); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer gtk_text_iter_get_toggled_tags(ref GtkTextIter iter, bool toggled_on); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_begins_tag(ref GtkTextIter iter, GtkTextTagPointer tag); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_ends_tag(ref GtkTextIter iter, GtkTextTagPointer tag); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_toggles_tag(ref GtkTextIter iter, GtkTextTagPointer tag); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_has_tag(ref GtkTextIter iter, GtkTextTagPointer tag);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GSListPointer gtk_text_iter_get_tags(ref GtkTextIter iter); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_editable(ref GtkTextIter iter, bool default_setting);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_can_insert(ref GtkTextIter iter, bool default_editability); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_starts_word(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_ends_word(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_inside_word(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_starts_sentence(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_ends_sentence(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_inside_sentence(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_starts_line(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_ends_line(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_is_cursor_position(ref GtkTextIter iter); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_text_iter_get_chars_in_line(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_text_iter_get_bytes_in_line(ref GtkTextIter iter); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_get_attributes(ref GtkTextIter iter, GtkTextAttributesPointer values);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern PangoLanguagePointer gtk_text_iter_get_language(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_is_end(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_is_start(ref GtkTextIter iter); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_char(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_char(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_chars(ref GtkTextIter iter, int count);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_chars(ref GtkTextIter iter, int count);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_line(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_line(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_lines(ref GtkTextIter iter, int count);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_lines(ref GtkTextIter iter, int count);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_word_end(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_word_start(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_word_ends(ref GtkTextIter iter, int count);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_word_starts(ref GtkTextIter iter, int count); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_visible_line(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_visible_line(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_visible_lines(ref GtkTextIter iter, int count);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_visible_lines(ref GtkTextIter iter, int count); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_visible_word_end(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_visible_word_start(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_visible_word_ends(ref GtkTextIter iter, int count);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_visible_word_starts(ref GtkTextIter iter, int count); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_sentence_end(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_sentence_start(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_sentence_ends(ref GtkTextIter iter, int count);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_sentence_starts(ref GtkTextIter iter, int count); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_cursor_position(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_cursor_position(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_cursor_positions(ref GtkTextIter iter, int count);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_cursor_positions(ref GtkTextIter iter, int count); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_visible_cursor_position(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_visible_cursor_position(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_visible_cursor_positions(ref GtkTextIter iter, int count);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_visible_cursor_positions(ref GtkTextIter iter, int count); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_text_iter_set_offset(ref GtkTextIter iter, int char_offset);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_text_iter_set_line(ref GtkTextIter iter, int line_number);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_text_iter_set_line_offset(ref GtkTextIter iter, int char_on_line);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_text_iter_set_line_index(ref GtkTextIter iter, int byte_on_line);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_text_iter_forward_to_end(ref GtkTextIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_to_line_end(ref GtkTextIter iter); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_text_iter_set_visible_line_offset(ref GtkTextIter iter, int char_on_line);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_text_iter_set_visible_line_index(ref GtkTextIter iter, int byte_on_line); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_to_tag_toggle(ref GtkTextIter iter, GtkTextTagPointer tag); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_to_tag_toggle(ref GtkTextIter iter, GtkTextTagPointer tag); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_find_char(ref GtkTextIter iter, IntPtr predicate, IntPtr user_data, ref GtkTextIter limit);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_find_char(ref GtkTextIter iter, IntPtr predicate, IntPtr user_data, ref GtkTextIter limit); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_forward_search(ref GtkTextIter iter, string str, GtkTextSearchFlags flags, ref GtkTextIter match_start, ref GtkTextIter match_end, ref GtkTextIter limit); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_backward_search(ref GtkTextIter iter, string str, GtkTextSearchFlags flags, ref GtkTextIter match_start, ref GtkTextIter match_end, ref GtkTextIter limit); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_equal(ref GtkTextIter lhs, ref GtkTextIter rhs);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_text_iter_compare(ref GtkTextIter lhs, ref GtkTextIter rhs);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_text_iter_in_range(ref GtkTextIter iter, ref GtkTextIter start, ref GtkTextIter end); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_text_iter_order(ref GtkTextIter first, ref GtkTextIter second);
    }
}