using System;
using System.Runtime.InteropServices;
using GtkSharp.Atk.Native.Types;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    public static class NativeComboBox
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gtk_combo_box_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_combo_box_new();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_combo_box_new_with_area(GObjectPointer cellArea);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_combo_box_new_with_area_and_entry(GObjectPointer cellArea);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_combo_box_new_with_entry();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_combo_box_new_with_model(GtkTreeModelPointer model);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_combo_box_new_with_model_and_entry(GtkTreeModelPointer model); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_combo_box_get_wrap_width(GObjectPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_set_wrap_width(GObjectPointer combo_box, int width);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_combo_box_get_row_span_column(GObjectPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_set_row_span_column(GObjectPointer combo_box, int row_span);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_combo_box_get_column_span_column(GObjectPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_set_column_span_column(GObjectPointer combo_box, int column_span); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_combo_box_get_add_tearoffs(GObjectPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_set_add_tearoffs(GObjectPointer combo_box, bool add_tearoffs); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern string gtk_combo_box_get_title(GObjectPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_set_title(GObjectPointer combo_box, string title); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_combo_box_get_focus_on_click(GObjectPointer combo);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_set_focus_on_click(GObjectPointer combo, bool focus_on_click); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_combo_box_get_active(GObjectPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_set_active(GObjectPointer combo_box, int index_);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_combo_box_get_active_iter(GObjectPointer combo_box, out GtkTreeIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_set_active_iter(GObjectPointer combo_box, ref GtkTreeIter iter); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_set_model(GObjectPointer combo_box, GtkTreeModelPointer model);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkTreeModelPointer gtk_combo_box_get_model(GObjectPointer combo_box); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_combo_box_get_row_separator_func(GObjectPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_set_row_separator_func(GObjectPointer combo_box, IntPtr treeViewRowSeparatorFunc, IntPtr data, IntPtr destroyNotifyFunc); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_set_button_sensitivity(GObjectPointer combo_box, GtkSensitivityType sensitivity);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkSensitivityType gtk_combo_box_get_button_sensitivity(GObjectPointer combo_box); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_combo_box_get_has_entry(GObjectPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_set_entry_text_column(GObjectPointer combo_box, int text_column);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_combo_box_get_entry_text_column(GObjectPointer combo_box); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_set_popup_fixed_width(GObjectPointer combo_box, bool fixxed);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_combo_box_get_popup_fixed_width(GObjectPointer combo_box); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_popup(GObjectPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_popup_for_device(GObjectPointer combo_box, GdkDevicePointer device);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_popdown(GObjectPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern AtkObjectPointer gtk_combo_box_get_popup_accessible(GObjectPointer combo_box); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_combo_box_get_id_column(GObjectPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_combo_box_set_id_column(GObjectPointer combo_box, int id_column);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern string gtk_combo_box_get_active_id(GObjectPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_combo_box_set_active_id(GObjectPointer combo_box, string active_id);
    }
}