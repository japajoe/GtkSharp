using System;
using System.Runtime.InteropServices;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gdk.Types;
using GtkSharp.Gtk.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Pango.Native.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeEntry
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_entry_get_type();

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_entry_new();

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_entry_new_with_buffer(GObjectPointer buffer); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkEntryBufferPointer gtk_entry_get_buffer(GObjectPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_buffer(GObjectPointer entry, GtkEntryBufferPointer buffer); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_get_text_area(GObjectPointer entry, out GdkRectangle text_area); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_visibility(GObjectPointer entry, bool visible);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_entry_get_visibility(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_invisible_char(GObjectPointer entry, uint ch);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_entry_get_invisible_char(GObjectPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_unset_invisible_char(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_has_frame(GObjectPointer entry, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_entry_get_has_frame(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_inner_border(GObjectPointer entry, ref GtkBorder border);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkBorderPointer gtk_entry_get_inner_border(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_overwrite_mode(GObjectPointer entry, bool overwrite);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_entry_get_overwrite_mode(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_max_length(GObjectPointer entry, int max);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_entry_get_max_length(GObjectPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ushort gtk_entry_get_text_length(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_activates_default(GObjectPointer entry, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_entry_get_activates_default(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_width_chars(GObjectPointer entry, int n_chars);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_entry_get_width_chars(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_max_width_chars(GObjectPointer entry, int n_chars);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_entry_get_max_width_chars(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_text(GObjectPointer entry, string text); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_entry_get_text(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern PangoLayoutPointer gtk_entry_get_layout(GObjectPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_get_layout_offsets(GObjectPointer entry, out int x, out int y);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_alignment(GObjectPointer entry, float xalign);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern float gtk_entry_get_alignment(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_completion(GObjectPointer entry, GtkEntryCompletionPointer completion);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkEntryCompletionPointer gtk_entry_get_completion(GObjectPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_entry_layout_index_to_text_index(GObjectPointer entry, int layout_index);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_entry_text_index_to_layout_index(GObjectPointer entry, int text_index); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_cursor_hadjustment(GObjectPointer entry, GtkAdjustmentPointer adjustment);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkAdjustmentPointer gtk_entry_get_cursor_hadjustment(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_progress_fraction(GObjectPointer entry, double fraction);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern double gtk_entry_get_progress_fraction(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_progress_pulse_step(GObjectPointer entry, double fraction);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern double gtk_entry_get_progress_pulse_step(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_progress_pulse(GObjectPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_entry_get_placeholder_text(GObjectPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_placeholder_text(GObjectPointer entry, string text); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_from_pixbuf(GObjectPointer entry, GtkEntryIconPosition icon_pos, GdkPixbufPointer pixbuf);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_from_stock(GObjectPointer entry, GtkEntryIconPosition icon_pos, string stock_id);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_from_icon_name(GObjectPointer entry, GtkEntryIconPosition icon_pos, string icon_name);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_from_gicon(GObjectPointer entry, GtkEntryIconPosition icon_pos, GIconPointer icon);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkImageType gtk_entry_get_icon_storage_type(GObjectPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkPixbufPointer gtk_entry_get_icon_pixbuf(GObjectPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_entry_get_icon_stock(GObjectPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_entry_get_icon_name(GObjectPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GIconPointer gtk_entry_get_icon_gicon(GObjectPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_activatable(GObjectPointer entry, GtkEntryIconPosition icon_pos, bool activatable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_entry_get_icon_activatable(GObjectPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_sensitive(GObjectPointer entry, GtkEntryIconPosition icon_pos, bool sensitive);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_entry_get_icon_sensitive(GObjectPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_entry_get_icon_at_pos(GObjectPointer entry, int x, int y);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_tooltip_text(GObjectPointer entry, GtkEntryIconPosition icon_pos, string tooltip);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr  gtk_entry_get_icon_tooltip_text(GObjectPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_tooltip_markup(GObjectPointer entry, GtkEntryIconPosition icon_pos, string tooltip);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr  gtk_entry_get_icon_tooltip_markup(GObjectPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_drag_source(GObjectPointer entry, GtkEntryIconPosition icon_pos, GtkTargetListPointer target_list, GdkDragAction actions);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_entry_get_current_icon_drag_source(GObjectPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_get_icon_area(GObjectPointer entry, GtkEntryIconPosition icon_pos, out GdkRectangle icon_area); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_entry_im_context_filter_keypress(GObjectPointer entry, GdkEventKeyPointer evnt);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_reset_im_context(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_input_purpose(GObjectPointer entry, GtkInputPurpose purpose);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkInputPurpose gtk_entry_get_input_purpose(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_input_hints(GObjectPointer entry, GtkInputHints hints);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkInputHints gtk_entry_get_input_hints(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_attributes(GObjectPointer entry, PangoAttrListPointer attrs);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern PangoAttrListPointer gtk_entry_get_attributes(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_tabs(GObjectPointer entry, PangoTabArrayPointer tabs); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern PangoTabArrayPointer gtk_entry_get_tabs(GObjectPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_grab_focus_without_selecting(GObjectPointer entry);

    }
}