using System;
using System.Runtime.InteropServices;
using GtkSharp.Native.Types;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeWidget
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_destroy(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_widget_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_destroyed(GtkWidgetPointer widget, GtkWidgetPointer widget_pointer);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_unparent(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_show(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_hide(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_show_now(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_show_all(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_no_show_all(GtkWidgetPointer widget, bool no_show_all);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_no_show_all(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_map(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_unmap(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_realize(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_unrealize(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_draw(GtkWidgetPointer widget, CairoPointer cr); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_queue_draw(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_queue_draw_area(GtkWidgetPointer widget, int x, int y, int width, int height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_queue_draw_region(GtkWidgetPointer widget, CairoRegionPointer region);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_queue_resize(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_queue_resize_no_redraw(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkFrameClockPointer gtk_widget_get_frame_clock(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_size_request(GtkWidgetPointer widget, out GtkRequisition requisition);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_size_allocate(GtkWidgetPointer widget, out GtkAllocation allocation);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_size_allocate_with_baseline(GtkWidgetPointer widget, out GtkAllocation allocation, int baseline); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSizeRequestMode gtk_widget_get_request_mode(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_get_preferred_width(GtkWidgetPointer widget, out int minimum_width, out int natural_width);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_get_preferred_height_for_width(GtkWidgetPointer widget, int width, out int minimum_height, out int natural_height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_get_preferred_height(GtkWidgetPointer widget, out int minimum_height, out int natural_height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_get_preferred_width_for_height(GtkWidgetPointer widget, int height, out int minimum_width, out int natural_width);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_get_preferred_height_and_baseline_for_width(GtkWidgetPointer widget, int width, out int minimum_height, out int natural_height, out int minimum_baseline, out int natural_baseline);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_get_preferred_size(GtkWidgetPointer widget, out GtkRequisition minimum_size, out GtkRequisition natural_size); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_get_child_requisition(GtkWidgetPointer widget, out GtkRequisition requisition);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_add_accelerator(GtkWidgetPointer widget, string accel_signal, GtkAccelGroupPointer accel_group, uint accel_key, GdkModifierType accel_mods, GtkAccelFlags accel_flags);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_remove_accelerator(GtkWidgetPointer widget, GtkAccelGroupPointer accel_group, uint accel_key, GdkModifierType accel_mods);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_accel_path(GtkWidgetPointer widget, string accel_path, GtkAccelGroupPointer accel_group);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GListPointer gtk_widget_list_accel_closures(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_can_activate_accel(GtkWidgetPointer widget, uint signal_id);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_mnemonic_activate(GtkWidgetPointer widget, bool group_cycling);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_evnt(GtkWidgetPointer widget, GdkEventPointer evnt);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_widget_send_expose(GtkWidgetPointer widget, GdkEventPointer evnt);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_send_focus_change(GtkWidgetPointer widget, GdkEventPointer evnt); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_activate(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_reparent(GtkWidgetPointer widget, GtkWidgetPointer new_parent);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_intersect(GtkWidgetPointer widget, out GdkRectangle area, out GdkRectangle intersection);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CairoRegionPointer gtk_widget_region_intersect(GtkWidgetPointer widget, CairoRegionPointer region); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_freeze_child_notify(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_child_notify(GtkWidgetPointer widget, string child_property);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_thaw_child_notify(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_can_focus(GtkWidgetPointer widget, bool can_focus);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_can_focus(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_has_focus(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_is_focus(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_has_visible_focus(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_grab_focus(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_can_default(GtkWidgetPointer widget, bool can_default);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_can_default(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_has_default(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_grab_default(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_receives_default(GtkWidgetPointer widget, bool receives_default);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_receives_default(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_has_grab(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_device_is_shadowed(GtkWidgetPointer widget, GdkDevicePointer device); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_name(GtkWidgetPointer widget, string name);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_widget_get_name(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_state(GtkWidgetPointer widget, GtkStateType state); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkStateType gtk_widget_get_state(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_state_flags(GtkWidgetPointer widget, GtkStateFlags flags, bool clear);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_unset_state_flags(GtkWidgetPointer widget, GtkStateFlags flags);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkStateFlags gtk_widget_get_state_flags(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_sensitive(GtkWidgetPointer widget, bool sensitive);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_sensitive(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_is_sensitive(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_visible(GtkWidgetPointer widget, bool visible);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_visible(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_is_visible(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_has_window(GtkWidgetPointer widget, bool has_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_has_window(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_is_toplevel(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_is_drawable(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_realized(GtkWidgetPointer widget, bool realized);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_realized(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_mapped(GtkWidgetPointer widget, bool mapped);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_mapped(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_app_paintable(GtkWidgetPointer widget, bool app_paintable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_app_paintable(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_double_buffered(GtkWidgetPointer widget, bool double_buffered);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_double_buffered(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_redraw_on_allocate(GtkWidgetPointer widget, bool redraw_on_allocate); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_parent(GtkWidgetPointer widget, GtkWidgetPointer parent);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_widget_get_parent(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_parent_window(GtkWidgetPointer widget, GdkWindowPointer parent_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkWindowPointer gtk_widget_get_parent_window(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_child_visible(GtkWidgetPointer widget, bool is_visible);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_child_visible(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_window(GtkWidgetPointer widget, GdkWindowPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkWindowPointer gtk_widget_get_window(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_register_window(GtkWidgetPointer widget, GdkWindowPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_unregister_window(GtkWidgetPointer widget, GdkWindowPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_widget_get_allocated_width(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_widget_get_allocated_height(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_widget_get_allocated_baseline(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_get_allocation(GtkWidgetPointer widget, out GtkAllocation allocation);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_allocation(GtkWidgetPointer widget, out GtkAllocation allocation);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_clip(GtkWidgetPointer widget, out GtkAllocation clip);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_get_clip(GtkWidgetPointer widget, out GtkAllocation clip); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_get_requisition(GtkWidgetPointer widget, out GtkRequisition requisition);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_child_focus(GtkWidgetPointer widget, GtkDirectionType direction);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_keynav_failed(GtkWidgetPointer widget, GtkDirectionType direction);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_error_bell(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_size_request(GtkWidgetPointer widget, int width, int height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_get_size_request(GtkWidgetPointer widget, out int width, out int height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_events(GtkWidgetPointer widget, int events);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_add_events(GtkWidgetPointer widget, int events);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_device_events(GtkWidgetPointer widget, GdkDevicePointer device, GdkEventMask events);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_add_device_events(GtkWidgetPointer widget, GdkDevicePointer device, GdkEventMask events);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_opacity(GtkWidgetPointer widget, double opacity);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern double gtk_widget_get_opacity(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_device_enabled(GtkWidgetPointer widget, GdkDevicePointer device, bool enabled);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_device_enabled(GtkWidgetPointer widget, GdkDevicePointer device); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_widget_get_toplevel(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_widget_get_ancestor(GtkWidgetPointer widget, ulong widget_type);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkVisualPointer gtk_widget_get_visual(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_visual(GtkWidgetPointer widget, GdkVisualPointer visual); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkScreenPointer gtk_widget_get_screen(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_has_screen(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_widget_get_scale_factor(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkDisplayPointer gtk_widget_get_display(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkWindowPointer gtk_widget_get_root_window(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkSettingsPointer gtk_widget_get_settings(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkClipboardPointer gtk_widget_get_clipboard(GtkWidgetPointer widget, GdkAtomPointer selection);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_hexpand(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_hexpand(GtkWidgetPointer widget, bool expand);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_hexpand_set(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_hexpand_set(GtkWidgetPointer widget, bool set);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_vexpand(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_vexpand(GtkWidgetPointer widget, bool expand);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_vexpand_set(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_vexpand_set(GtkWidgetPointer widget, bool set);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_queue_compute_expand(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_compute_expand(GtkWidgetPointer widget, GtkOrientation orientation);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_support_multidevice(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_support_multidevice(GtkWidgetPointer widget, bool support_multidevice); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_class_set_accessible_type(GtkWidgetClassPointer widget_class, ulong type);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_class_set_accessible_role(GtkWidgetClassPointer widget_class, AtkRole role);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern AtkObjectPointer gtk_widget_get_accessible(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkAlign gtk_widget_get_halign(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_halign(GtkWidgetPointer widget, GtkAlign align);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkAlign gtk_widget_get_valign(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkAlign gtk_widget_get_valign_with_baseline(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_valign(GtkWidgetPointer widget, GtkAlign align);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_widget_get_margin_left(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_margin_left(GtkWidgetPointer widget, int margin);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_widget_get_margin_right(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_margin_right(GtkWidgetPointer widget, int margin);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_widget_get_margin_start(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_margin_start(GtkWidgetPointer widget, int margin);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_widget_get_margin_end(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_margin_end(GtkWidgetPointer widget, int margin);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_widget_get_margin_top(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_margin_top(GtkWidgetPointer widget, int margin);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_widget_get_margin_bottom(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_margin_bottom(GtkWidgetPointer widget, int margin); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_widget_get_events(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkEventMask gtk_widget_get_device_events(GtkWidgetPointer widget, GdkDevicePointer device);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_get_pointer(GtkWidgetPointer widget, out int x, out int y); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_is_ancestor(GtkWidgetPointer widget, GtkWidgetPointer ancestor); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_translate_coordinates(GtkWidgetPointer src_widget, GtkWidgetPointer dest_widget, int src_x, int src_y, out int dest_x, out int dest_y); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_hide_on_delete(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_override_color(GtkWidgetPointer widget, GtkStateFlags state, out GdkRGBA color);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_override_background_color(GtkWidgetPointer widget, GtkStateFlags state, out GdkRGBA color); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_override_font(GtkWidgetPointer widget, PangoFontDescriptionPointer font_desc); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_override_symbolic_color(GtkWidgetPointer widget, string name, out GdkRGBA color);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_override_cursor(GtkWidgetPointer widget, out GdkRGBA cursor, out GdkRGBA secondary_cursor); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_reset_style(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern PangoContextPointer gtk_widget_create_pango_context(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern PangoContextPointer gtk_widget_get_pango_context(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_font_options(GtkWidgetPointer widget, CairoFontOptionsPointer options);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CairoFontOptionsPointer gtk_widget_get_font_options(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern PangoLayoutPointer gtk_widget_create_pango_layout(GtkWidgetPointer widget, string text); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkPixbufPointer gtk_widget_render_icon_pixbuf(GtkWidgetPointer widget, string stock_id, GtkIconSize size); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_composite_name(GtkWidgetPointer widget, string name);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_widget_get_composite_name(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_push_composite_child();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_pop_composite_child(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_style_get_property(GtkWidgetPointer widget, string property_name, out ulong value);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_direction(GtkWidgetPointer widget, GtkTextDirection dir);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextDirection gtk_widget_get_direction(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_default_direction(GtkTextDirection dir);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkTextDirection gtk_widget_get_default_direction(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_is_composited(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_shape_combine_region(GtkWidgetPointer widget, CairoRegionPointer region);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_input_shape_combine_region(GtkWidgetPointer widget, CairoRegionPointer region); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GListPointer gtk_widget_list_mnemonic_labels(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_add_mnemonic_label(GtkWidgetPointer widget, GtkWidgetPointer label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_remove_mnemonic_label(GtkWidgetPointer widget, GtkWidgetPointer label); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_tooltip_window(GtkWidgetPointer widget, GtkWindowPointer custom_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWindowPointer gtk_widget_get_tooltip_window(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_trigger_tooltip_query(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_tooltip_text(GtkWidgetPointer widget, string text);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_widget_get_tooltip_text(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_tooltip_markup(GtkWidgetPointer widget, string markup);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_widget_get_tooltip_markup(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_has_tooltip(GtkWidgetPointer widget, bool has_tooltip);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_get_has_tooltip(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_cairo_should_draw_window(CairoPointer cr, GdkWindowPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_cairo_transform_to_window(CairoPointer cr, GtkWidgetPointer widget, GdkWindowPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_requisition_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkRequisitionPointer gtk_requisition_new();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkRequisitionPointer gtk_requisition_copy(out GtkRequisition requisition);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_requisition_free(out GtkRequisition requisition); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_widget_in_destruction(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkStyleContextPointer gtk_widget_get_style_context(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPathPointer gtk_widget_get_path(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkModifierType gtk_widget_get_modifier_mask(GtkWidgetPointer widget, GdkModifierIntent intent); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_insert_action_group(GtkWidgetPointer widget, string name, GActionGroupPointer group);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint gtk_widget_add_tick_callback(GtkWidgetPointer widget, GtkTickCallbackPointer callback, IntPtr user_data, GDestroyNotifyPointer notify); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_remove_tick_callback(GtkWidgetPointer widget, uint id);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_init_template(GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GObjectPointer gtk_widget_get_template_child(GtkWidgetPointer widget, ulong widget_type, string name);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_class_bind_template_child_full(GtkWidgetClassPointer widget_class, string name, bool internal_child, long struct_offset); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GActionGroupPointer gtk_widget_get_action_group(GtkWidgetPointer widget, string prefix); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr gtk_widget_list_action_prefixes(GtkWidgetPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_widget_set_font_map(GtkWidgetPointer widget, PangoFontMapPointer font_map);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern PangoFontMapPointer gtk_widget_get_font_map(GtkWidgetPointer widget);
    }
}
