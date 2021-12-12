using System.Runtime.InteropServices;
using GtkSharp.Native.Types;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeDialog
    {      
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_dialog_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_dialog_new(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_dialog_new_with_buttons(string title, GtkWidgetPointer parentWindow, GtkDialogFlags flags, string first_button_text, GtkResponseType first_button_reponse, string second_button_text, GtkResponseType second_button_reponse); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_dialog_add_action_widget(GtkWidgetPointer dialog, GtkWidgetPointer child, int response_id);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_dialog_add_button(GtkWidgetPointer dialog, string button_text, int response_id);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_dialog_add_buttons(GtkWidgetPointer dialog, string first_button_text, int first_button_response_id, string second_button_text, int second_button_response_id); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_dialog_set_response_sensitive(GtkWidgetPointer dialog, int response_id, bool setting);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_dialog_set_default_response(GtkWidgetPointer dialog, int response_id);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_dialog_get_widget_for_response(GtkWidgetPointer dialog, int response_id);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_dialog_get_response_for_widget(GtkWidgetPointer dialog, GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_alternative_dialog_button_order(GdkScreenPointer screen);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_dialog_set_alternative_button_order(GtkWidgetPointer dialog, int first_response_id, int response_id_minus_one);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_dialog_set_alternative_button_order(GtkWidgetPointer dialog, int first_response_id, int second_response_id, int response_id_minus_one);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_dialog_set_alternative_button_order(GtkWidgetPointer dialog, int first_response_id, int second_response_id, int third_response_id, int response_id_minus_one);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_dialog_set_alternative_button_order_from_array(GtkWidgetPointer dialog, int n_params, out int new_order); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_dialog_response(GtkWidgetPointer dialog, int response_id); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_dialog_run(GtkWidgetPointer dialog); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_dialog_get_action_area(GtkWidgetPointer dialog);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_dialog_get_content_area(GtkWidgetPointer dialog);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_dialog_get_header_bar(GtkWidgetPointer dialog);
    }
}