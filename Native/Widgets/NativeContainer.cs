using System;
using System.Runtime.InteropServices;
using GtkSharp.Native.Types;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeContainer
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_container_get_type();        
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_set_border_width(GtkWidgetPointer container, uint border_width);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_container_get_border_width(GtkWidgetPointer container);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_add(GtkWidgetPointer container, GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_remove(GtkWidgetPointer container, GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_set_resize_mode(GtkWidgetPointer container, GtkResizeMode resize_mode);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkResizeMode gtk_container_get_resize_mode(GtkWidgetPointer container); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_check_resize(GtkWidgetPointer container); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_foreach(GtkWidgetPointer container, GtkCallbackPointer callback, IntPtr callback_data);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GListPointer gtk_container_get_children(GtkWidgetPointer container); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_propagate_draw(GtkWidgetPointer container, GtkWidgetPointer child, CairoPointer cr); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_set_focus_chain(GtkWidgetPointer container, GListPointer focusable_widgets);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_container_get_focus_chain(GtkWidgetPointer container, GListPointer focusable_widgets);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_unset_focus_chain(GtkWidgetPointer container);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_set_reallocate_redraws(GtkWidgetPointer container, bool needs_redraws);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_set_focus_child(GtkWidgetPointer container, GtkWidgetPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_container_get_focus_child(GtkWidgetPointer container);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_set_focus_vadjustment(GtkWidgetPointer container, GtkAdjustmentPointer adjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkAdjustmentPointer gtk_container_get_focus_vadjustment(GtkWidgetPointer container);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_set_focus_hadjustment(GtkWidgetPointer container, GtkAdjustmentPointer adjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkAdjustmentPointer gtk_container_get_focus_hadjustment(GtkWidgetPointer container); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_resize_children(GtkWidgetPointer container);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_container_child_type(GtkWidgetPointer container); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_class_install_child_property(GtkContainerClassPointer cclass, uint property_id, GParamSpecPointer pspec);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_class_install_child_properties(GtkContainerClassPointer cclass, uint n_pspecs, GParamSpecPointer pspecs);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GParamSpecPointer gtk_container_class_find_child_property(GObjectClassPointer cclass, string property_name);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GParamSpecPointer gtk_container_class_list_child_properties(GObjectClassPointer cclass, out int n_properties);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_child_set_property(GtkWidgetPointer container, GtkWidgetPointer child, string property_name, GValuePointer value);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_child_get_property(GtkWidgetPointer container, GtkWidgetPointer child, string property_name, GValuePointer value);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_child_notify(GtkWidgetPointer container, GtkWidgetPointer child, string child_property); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_child_notify_by_pspec(GtkWidgetPointer container, GtkWidgetPointer child, GParamSpecPointer pspec);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_forall(GtkWidgetPointer container, GtkCallbackPointer callback, IntPtr callback_data); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_container_class_handle_border_width(GtkContainerClassPointer klass); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPathPointer gtk_container_get_path_for_child(GtkWidgetPointer container, GtkWidgetPointer child);        
    }
}
