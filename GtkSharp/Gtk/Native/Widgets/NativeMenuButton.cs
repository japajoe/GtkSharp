using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeMenuButton
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_menu_button_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_menu_button_new(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_button_set_popup(GtkWidgetPointer menu_button, GtkWidgetPointer menu);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_menu_button_get_popup(GtkWidgetPointer menu_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_button_set_popover(GtkWidgetPointer menu_button, GtkWidgetPointer popover);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_menu_button_get_popover(GtkWidgetPointer menu_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_button_set_direction(GtkWidgetPointer menu_button, GtkArrowType direction);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkArrowType gtk_menu_button_get_direction(GtkWidgetPointer menu_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_button_set_menu_model(GtkWidgetPointer menu_button, GMenuModelPointer menu_model);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GMenuModelPointer gtk_menu_button_get_menu_model(GtkWidgetPointer menu_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_button_set_align_widget(GtkWidgetPointer menu_button, GtkWidgetPointer align_widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_menu_button_get_align_widget(GtkWidgetPointer menu_button); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_menu_button_set_use_popover(GtkWidgetPointer menu_button, bool use_popover); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_menu_button_get_use_popover(GtkWidgetPointer menu_button);

    }
}