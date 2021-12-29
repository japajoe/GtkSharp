using System;
using System.Runtime.InteropServices;
using GtkSharp.Cairo.Native.Types;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    public static class NativeContainer
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gtk_container_get_type();        
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_set_border_width(GObjectPointer container, uint border_width);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint gtk_container_get_border_width(GObjectPointer container);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_add(GObjectPointer container, GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_remove(GObjectPointer container, GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_set_resize_mode(GObjectPointer container, GtkResizeMode resize_mode);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkResizeMode gtk_container_get_resize_mode(GObjectPointer container); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_check_resize(GObjectPointer container); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_foreach(GObjectPointer container, GtkCallbackPointer callback, IntPtr callback_data);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GListPointer gtk_container_get_children(GObjectPointer container); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_propagate_draw(GObjectPointer container, GObjectPointer child, CairoPointer cr); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_set_focus_chain(GObjectPointer container, GListPointer focusable_widgets);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_container_get_focus_chain(GObjectPointer container, GListPointer focusable_widgets);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_unset_focus_chain(GObjectPointer container);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_set_reallocate_redraws(GObjectPointer container, bool needs_redraws);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_set_focus_child(GObjectPointer container, GObjectPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_container_get_focus_child(GObjectPointer container);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_set_focus_vadjustment(GObjectPointer container, GtkAdjustmentPointer adjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkAdjustmentPointer gtk_container_get_focus_vadjustment(GObjectPointer container);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_set_focus_hadjustment(GObjectPointer container, GtkAdjustmentPointer adjustment);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkAdjustmentPointer gtk_container_get_focus_hadjustment(GObjectPointer container); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_resize_children(GObjectPointer container);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gtk_container_child_type(GObjectPointer container); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_class_install_child_property(GtkContainerClassPointer cclass, uint property_id, GParamSpecPointer pspec);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_class_install_child_properties(GtkContainerClassPointer cclass, uint n_pspecs, GParamSpecPointer pspecs);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GParamSpecPointer gtk_container_class_find_child_property(GObjectClassPointer cclass, string property_name);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GParamSpecPointer gtk_container_class_list_child_properties(GObjectClassPointer cclass, out int n_properties);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_child_set_property(GObjectPointer container, GObjectPointer child, string property_name, GValuePointer value);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_child_get_property(GObjectPointer container, GObjectPointer child, string property_name, GValuePointer value);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_child_notify(GObjectPointer container, GObjectPointer child, string child_property); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_child_notify_by_pspec(GObjectPointer container, GObjectPointer child, GParamSpecPointer pspec);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_forall(GObjectPointer container, GtkCallbackPointer callback, IntPtr callback_data); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_container_class_handle_border_width(GtkContainerClassPointer klass); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkWidgetPathPointer gtk_container_get_path_for_child(GObjectPointer container, GObjectPointer child);        
    }
}
