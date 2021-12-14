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
        internal static extern GtkWidgetPointer gtk_entry_new();

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_entry_new_with_buffer(GtkWidgetPointer buffer); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkEntryBufferPointer gtk_entry_get_buffer(GtkWidgetPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_buffer(GtkWidgetPointer entry, GtkEntryBufferPointer buffer); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_get_text_area(GtkWidgetPointer entry, out GdkRectangle text_area); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_visibility(GtkWidgetPointer entry, bool visible);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_entry_get_visibility(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_invisible_char(GtkWidgetPointer entry, uint ch);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_entry_get_invisible_char(GtkWidgetPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_unset_invisible_char(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_has_frame(GtkWidgetPointer entry, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_entry_get_has_frame(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_inner_border(GtkWidgetPointer entry, ref GtkBorder border);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkBorderPointer gtk_entry_get_inner_border(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_overwrite_mode(GtkWidgetPointer entry, bool overwrite);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_entry_get_overwrite_mode(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_max_length(GtkWidgetPointer entry, int max);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_entry_get_max_length(GtkWidgetPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ushort gtk_entry_get_text_length(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_activates_default(GtkWidgetPointer entry, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_entry_get_activates_default(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_width_chars(GtkWidgetPointer entry, int n_chars);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_entry_get_width_chars(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_max_width_chars(GtkWidgetPointer entry, int n_chars);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_entry_get_max_width_chars(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_text(GtkWidgetPointer entry, string text); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_entry_get_text(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern PangoLayoutPointer gtk_entry_get_layout(GtkWidgetPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_get_layout_offsets(GtkWidgetPointer entry, out int x, out int y);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_alignment(GtkWidgetPointer entry, float xalign);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern float gtk_entry_get_alignment(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_completion(GtkWidgetPointer entry, GtkEntryCompletionPointer completion);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkEntryCompletionPointer gtk_entry_get_completion(GtkWidgetPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_entry_layout_index_to_text_index(GtkWidgetPointer entry, int layout_index);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_entry_text_index_to_layout_index(GtkWidgetPointer entry, int text_index); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_cursor_hadjustment(GtkWidgetPointer entry, GtkAdjustmentPointer adjustment);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkAdjustmentPointer gtk_entry_get_cursor_hadjustment(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_progress_fraction(GtkWidgetPointer entry, double fraction);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern double gtk_entry_get_progress_fraction(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_progress_pulse_step(GtkWidgetPointer entry, double fraction);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern double gtk_entry_get_progress_pulse_step(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_progress_pulse(GtkWidgetPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_entry_get_placeholder_text(GtkWidgetPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_placeholder_text(GtkWidgetPointer entry, string text); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_from_pixbuf(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos, GdkPixbufPointer pixbuf);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_from_stock(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos, string stock_id);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_from_icon_name(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos, string icon_name);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_from_gicon(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos, GIconPointer icon);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkImageType gtk_entry_get_icon_storage_type(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkPixbufPointer gtk_entry_get_icon_pixbuf(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_entry_get_icon_stock(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_entry_get_icon_name(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GIconPointer gtk_entry_get_icon_gicon(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_activatable(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos, bool activatable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_entry_get_icon_activatable(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_sensitive(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos, bool sensitive);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_entry_get_icon_sensitive(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_entry_get_icon_at_pos(GtkWidgetPointer entry, int x, int y);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_tooltip_text(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos, string tooltip);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr  gtk_entry_get_icon_tooltip_text(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_tooltip_markup(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos, string tooltip);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr  gtk_entry_get_icon_tooltip_markup(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_icon_drag_source(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos, GtkTargetListPointer target_list, GdkDragAction actions);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_entry_get_current_icon_drag_source(GtkWidgetPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_get_icon_area(GtkWidgetPointer entry, GtkEntryIconPosition icon_pos, out GdkRectangle icon_area); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_entry_im_context_filter_keypress(GtkWidgetPointer entry, GdkEventKeyPointer evnt);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_reset_im_context(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_input_purpose(GtkWidgetPointer entry, GtkInputPurpose purpose);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkInputPurpose gtk_entry_get_input_purpose(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_input_hints(GtkWidgetPointer entry, GtkInputHints hints);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkInputHints gtk_entry_get_input_hints(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_attributes(GtkWidgetPointer entry, PangoAttrListPointer attrs);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern PangoAttrListPointer gtk_entry_get_attributes(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_set_tabs(GtkWidgetPointer entry, PangoTabArrayPointer tabs); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern PangoTabArrayPointer gtk_entry_get_tabs(GtkWidgetPointer entry); 

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_entry_grab_focus_without_selecting(GtkWidgetPointer entry);

    }
}