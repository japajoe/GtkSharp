using System;
using System.Runtime.InteropServices;
using GtkSharp.Native.Types;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeComboBox
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_combo_box_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_combo_box_new();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_combo_box_new_with_area(GtkWidgetPointer cellArea);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_combo_box_new_with_area_and_entry(GtkWidgetPointer cellArea);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_combo_box_new_with_entry();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_combo_box_new_with_model(GtkTreeModelPointer model);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_combo_box_new_with_model_and_entry(GtkTreeModelPointer model); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_combo_box_get_wrap_width(GtkWidgetPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_set_wrap_width(GtkWidgetPointer combo_box, int width);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_combo_box_get_row_span_column(GtkWidgetPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_set_row_span_column(GtkWidgetPointer combo_box, int row_span);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_combo_box_get_column_span_column(GtkWidgetPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_set_column_span_column(GtkWidgetPointer combo_box, int column_span); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_combo_box_get_add_tearoffs(GtkWidgetPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_set_add_tearoffs(GtkWidgetPointer combo_box, bool add_tearoffs); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_combo_box_get_title(GtkWidgetPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_set_title(GtkWidgetPointer combo_box, string title); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_combo_box_get_focus_on_click(GtkWidgetPointer combo);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_set_focus_on_click(GtkWidgetPointer combo, bool focus_on_click); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_combo_box_get_active(GtkWidgetPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_set_active(GtkWidgetPointer combo_box, int index_);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_combo_box_get_active_iter(GtkWidgetPointer combo_box, out GtkTreeIter iter);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_set_active_iter(GtkWidgetPointer combo_box, ref GtkTreeIter iter); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_set_model(GtkWidgetPointer combo_box, GtkTreeModelPointer model);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTreeModelPointer gtk_combo_box_get_model(GtkWidgetPointer combo_box); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_combo_box_get_row_separator_func(GtkWidgetPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_set_row_separator_func(GtkWidgetPointer combo_box, IntPtr treeViewRowSeparatorFunc, IntPtr data, IntPtr destroyNotifyFunc); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_set_button_sensitivity(GtkWidgetPointer combo_box, GtkSensitivityType sensitivity);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSensitivityType gtk_combo_box_get_button_sensitivity(GtkWidgetPointer combo_box); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_combo_box_get_has_entry(GtkWidgetPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_set_entry_text_column(GtkWidgetPointer combo_box, int text_column);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_combo_box_get_entry_text_column(GtkWidgetPointer combo_box); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_set_popup_fixed_width(GtkWidgetPointer combo_box, bool fixxed);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_combo_box_get_popup_fixed_width(GtkWidgetPointer combo_box); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_popup(GtkWidgetPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_popup_for_device(GtkWidgetPointer combo_box, GdkDevicePointer device);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_popdown(GtkWidgetPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern AtkObjectPointer gtk_combo_box_get_popup_accessible(GtkWidgetPointer combo_box); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_combo_box_get_id_column(GtkWidgetPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_combo_box_set_id_column(GtkWidgetPointer combo_box, int id_column);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_combo_box_get_active_id(GtkWidgetPointer combo_box);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_combo_box_set_active_id(GtkWidgetPointer combo_box, string active_id);
    }
}