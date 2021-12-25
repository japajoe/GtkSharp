using System.Runtime.InteropServices;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gdk.Types;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;
using GtkSharp.Pango.Native.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeTextView
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_text_view_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_text_view_new();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_text_view_new_with_buffer(GObjectPointer buffer);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_buffer(GObjectPointer text_view, GObjectPointer buffer);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextBufferPointer gtk_text_view_get_buffer(GObjectPointer text_view);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_view_scroll_to_iter(GObjectPointer text_view, GtkTextIterPointer iter, double within_margin, bool use_align, double xalign, double yalign);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_scroll_to_mark(GObjectPointer text_view, GtkTextMarkPointer mark, double within_margin, bool use_align, double xalign, double yalign);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_scroll_mark_onscreen(GObjectPointer text_view, GtkTextMarkPointer mark);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_view_move_mark_onscreen(GObjectPointer text_view, GtkTextMarkPointer mark);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_view_place_cursor_onscreen(GObjectPointer text_view); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_get_visible_rect(GObjectPointer text_view, out GdkRectangle visible_rect);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_cursor_visible(GObjectPointer text_view, bool setting);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_view_get_cursor_visible(GObjectPointer text_view); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_get_cursor_locations(GObjectPointer text_view, GtkTextIterPointer iter, out GdkRectangle strong, out GdkRectangle weak);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_get_iter_location(GObjectPointer text_view, GtkTextIterPointer iter, out GdkRectangle location);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_get_iter_at_location(GObjectPointer text_view, GtkTextIterPointer iter, int x, int y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_get_iter_at_position(GObjectPointer text_view, GtkTextIterPointer iter, out int trailing, int x, int y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_get_line_yrange(GObjectPointer text_view, GtkTextIterPointer iter, out int y, out int height); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_get_line_at_y(GObjectPointer text_view, GtkTextIterPointer target_iter, int y, out int line_top); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_buffer_to_window_coords(GObjectPointer text_view, GtkTextWindowType win, int buffer_x, int buffer_y, out int window_x, out int window_y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_window_to_buffer_coords(GObjectPointer text_view, GtkTextWindowType win, int window_x, int window_y, out int buffer_x, out int buffer_y); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkAdjustmentPointer gtk_text_view_get_hadjustment(GObjectPointer text_view);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkAdjustmentPointer gtk_text_view_get_vadjustment(GObjectPointer text_view); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkWindowPointer gtk_text_view_get_window(GObjectPointer text_view, GtkTextWindowType win);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextWindowType gtk_text_view_get_window_type(GObjectPointer text_view, GdkWindowPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_border_window_size(GObjectPointer text_view, GtkTextWindowType type, int size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_text_view_get_border_window_size(GObjectPointer text_view, GtkTextWindowType type); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_view_forward_display_line(GObjectPointer text_view, GtkTextIterPointer iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_view_backward_display_line(GObjectPointer text_view, GtkTextIterPointer iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_view_forward_display_line_end(GObjectPointer text_view, GtkTextIterPointer iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_view_backward_display_line_start(GObjectPointer text_view, GtkTextIterPointer iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_view_starts_display_line(GObjectPointer text_view, GtkTextIterPointer iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_view_move_visually(GObjectPointer text_view, GtkTextIterPointer iter, int count); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_view_im_context_filter_keypress(GObjectPointer text_view, GdkEventKeyPointer EVNT);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_reset_im_context(GObjectPointer text_view); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_add_child_at_anchor(GObjectPointer text_view, GObjectPointer child, GtkTextChildAnchorPointer anchor); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_add_child_in_window(GObjectPointer text_view, GObjectPointer child, GtkTextWindowType which_window, int xpos, int ypos); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_move_child(GObjectPointer text_view, GObjectPointer child, int xpos, int ypos); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_wrap_mode(GObjectPointer text_view, GtkWrapMode wrap_mode);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWrapMode gtk_text_view_get_wrap_mode(GObjectPointer text_view);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_editable(GObjectPointer text_view, bool setting);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_view_get_editable(GObjectPointer text_view);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_overwrite(GObjectPointer text_view, bool overwrite);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_view_get_overwrite(GObjectPointer text_view);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_accepts_tab(GObjectPointer text_view, bool accepts_tab);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_view_get_accepts_tab(GObjectPointer text_view);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_pixels_above_lines(GObjectPointer text_view, int pixels_above_lines);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_text_view_get_pixels_above_lines(GObjectPointer text_view);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_pixels_below_lines(GObjectPointer text_view, int pixels_below_lines);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_text_view_get_pixels_below_lines(GObjectPointer text_view);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_pixels_inside_wrap(GObjectPointer text_view, int pixels_inside_wrap);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_text_view_get_pixels_inside_wrap(GObjectPointer text_view);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_justification(GObjectPointer text_view, GtkJustification justification);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkJustification gtk_text_view_get_justification(GObjectPointer text_view);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_left_margin(GObjectPointer text_view, int left_margin);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_text_view_get_left_margin(GObjectPointer text_view);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_right_margin(GObjectPointer text_view, int right_margin);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_text_view_get_right_margin(GObjectPointer text_view);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_top_margin(GObjectPointer text_view, int top_margin);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_text_view_get_top_margin(GObjectPointer text_view);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_bottom_margin(GObjectPointer text_view, int bottom_margin);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_text_view_get_bottom_margin(GObjectPointer text_view);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_indent(GObjectPointer text_view, int indent);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_text_view_get_indent(GObjectPointer text_view);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_tabs(GObjectPointer text_view, PangoTabArrayPointer tabs);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern PangoTabArrayPointer gtk_text_view_get_tabs(GObjectPointer text_view); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextAttributesPointer gtk_text_view_get_default_attributes(GObjectPointer text_view); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_input_purpose(GObjectPointer text_view, GtkInputPurpose purpose);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkInputPurpose gtk_text_view_get_input_purpose(GObjectPointer text_view); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_input_hints(GObjectPointer text_view, GtkInputHints hints);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkInputHints gtk_text_view_get_input_hints(GObjectPointer text_view); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_text_view_set_monospace(GObjectPointer text_view, bool monospace);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_text_view_get_monospace(GObjectPointer text_view);
    }
}