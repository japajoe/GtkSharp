using System;
using System.Runtime.InteropServices;
using GtkSharp.Atk.Native.Types;
using GtkSharp.Atk.Types;
using GtkSharp.Cairo.Native.Types;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gdk.Types;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;
using GtkSharp.Pango.Native.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    public static class NativeWidget
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_destroy(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gtk_widget_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_destroyed(GObjectPointer widget, GObjectPointer widget_pointer);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_unparent(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_show(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_hide(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_show_now(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_show_all(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_no_show_all(GObjectPointer widget, bool no_show_all);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_no_show_all(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_map(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_unmap(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_realize(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_unrealize(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_draw(GObjectPointer widget, CairoPointer cr); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_queue_draw(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_queue_draw_area(GObjectPointer widget, int x, int y, int width, int height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_queue_draw_region(GObjectPointer widget, CairoRegionPointer region);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_queue_resize(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_queue_resize_no_redraw(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkFrameClockPointer gtk_widget_get_frame_clock(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_size_request(GObjectPointer widget, out GtkRequisition requisition);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_size_allocate(GObjectPointer widget, out GtkAllocation allocation);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_size_allocate_with_baseline(GObjectPointer widget, out GtkAllocation allocation, int baseline); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkSizeRequestMode gtk_widget_get_request_mode(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_get_preferred_width(GObjectPointer widget, out int minimum_width, out int natural_width);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_get_preferred_height_for_width(GObjectPointer widget, int width, out int minimum_height, out int natural_height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_get_preferred_height(GObjectPointer widget, out int minimum_height, out int natural_height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_get_preferred_width_for_height(GObjectPointer widget, int height, out int minimum_width, out int natural_width);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_get_preferred_height_and_baseline_for_width(GObjectPointer widget, int width, out int minimum_height, out int natural_height, out int minimum_baseline, out int natural_baseline);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_get_preferred_size(GObjectPointer widget, out GtkRequisition minimum_size, out GtkRequisition natural_size); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_get_child_requisition(GObjectPointer widget, out GtkRequisition requisition);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_add_accelerator(GObjectPointer widget, string accel_signal, GtkAccelGroupPointer accel_group, uint accel_key, GdkModifierType accel_mods, GtkAccelFlags accel_flags);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_remove_accelerator(GObjectPointer widget, GtkAccelGroupPointer accel_group, uint accel_key, GdkModifierType accel_mods);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_accel_path(GObjectPointer widget, string accel_path, GtkAccelGroupPointer accel_group);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GListPointer gtk_widget_list_accel_closures(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_can_activate_accel(GObjectPointer widget, uint signal_id);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_mnemonic_activate(GObjectPointer widget, bool group_cycling);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_evnt(GObjectPointer widget, GdkEventPointer evnt);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_widget_send_expose(GObjectPointer widget, GdkEventPointer evnt);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_send_focus_change(GObjectPointer widget, GdkEventPointer evnt); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_activate(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_reparent(GObjectPointer widget, GObjectPointer new_parent);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_intersect(GObjectPointer widget, out GdkRectangle area, out GdkRectangle intersection);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern CairoRegionPointer gtk_widget_region_intersect(GObjectPointer widget, CairoRegionPointer region); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_freeze_child_notify(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_child_notify(GObjectPointer widget, string child_property);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_thaw_child_notify(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_can_focus(GObjectPointer widget, bool can_focus);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_can_focus(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_has_focus(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_is_focus(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_has_visible_focus(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_grab_focus(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_can_default(GObjectPointer widget, bool can_default);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_can_default(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_has_default(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_grab_default(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_receives_default(GObjectPointer widget, bool receives_default);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_receives_default(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_has_grab(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_device_is_shadowed(GObjectPointer widget, GdkDevicePointer device); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_name(GObjectPointer widget, string name);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern string gtk_widget_get_name(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_state(GObjectPointer widget, GtkStateType state); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkStateType gtk_widget_get_state(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_state_flags(GObjectPointer widget, GtkStateFlags flags, bool clear);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_unset_state_flags(GObjectPointer widget, GtkStateFlags flags);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkStateFlags gtk_widget_get_state_flags(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_sensitive(GObjectPointer widget, bool sensitive);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_sensitive(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_is_sensitive(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_visible(GObjectPointer widget, bool visible);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_visible(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_is_visible(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_has_window(GObjectPointer widget, bool has_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_has_window(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_is_toplevel(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_is_drawable(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_realized(GObjectPointer widget, bool realized);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_realized(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_mapped(GObjectPointer widget, bool mapped);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_mapped(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_app_paintable(GObjectPointer widget, bool app_paintable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_app_paintable(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_double_buffered(GObjectPointer widget, bool double_buffered);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_double_buffered(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_redraw_on_allocate(GObjectPointer widget, bool redraw_on_allocate); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_parent(GObjectPointer widget, GObjectPointer parent);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_widget_get_parent(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_parent_window(GObjectPointer widget, GObjectPointer parent_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_widget_get_parent_window(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_child_visible(GObjectPointer widget, bool is_visible);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_child_visible(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_window(GObjectPointer widget, GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_widget_get_window(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_register_window(GObjectPointer widget, GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_unregister_window(GObjectPointer widget, GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_widget_get_allocated_width(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_widget_get_allocated_height(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_widget_get_allocated_baseline(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_get_allocation(GObjectPointer widget, out GtkAllocation allocation);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_allocation(GObjectPointer widget, out GtkAllocation allocation);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_clip(GObjectPointer widget, out GtkAllocation clip);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_get_clip(GObjectPointer widget, out GtkAllocation clip); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_get_requisition(GObjectPointer widget, out GtkRequisition requisition);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_child_focus(GObjectPointer widget, GtkDirectionType direction);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_keynav_failed(GObjectPointer widget, GtkDirectionType direction);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_error_bell(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_size_request(GObjectPointer widget, int width, int height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_get_size_request(GObjectPointer widget, out int width, out int height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_events(GObjectPointer widget, int events);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_add_events(GObjectPointer widget, int events);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_device_events(GObjectPointer widget, GdkDevicePointer device, GdkEventMask events);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_add_device_events(GObjectPointer widget, GdkDevicePointer device, GdkEventMask events);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_opacity(GObjectPointer widget, double opacity);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double gtk_widget_get_opacity(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_device_enabled(GObjectPointer widget, GdkDevicePointer device, bool enabled);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_device_enabled(GObjectPointer widget, GdkDevicePointer device); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_widget_get_toplevel(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_widget_get_ancestor(GObjectPointer widget, ulong widget_type);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkVisualPointer gtk_widget_get_visual(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_visual(GObjectPointer widget, GdkVisualPointer visual); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkScreenPointer gtk_widget_get_screen(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_has_screen(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_widget_get_scale_factor(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkDisplayPointer gtk_widget_get_display(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_widget_get_root_window(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkSettingsPointer gtk_widget_get_settings(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkClipboardPointer gtk_widget_get_clipboard(GObjectPointer widget, GdkAtomPointer selection);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_hexpand(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_hexpand(GObjectPointer widget, bool expand);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_hexpand_set(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_hexpand_set(GObjectPointer widget, bool set);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_vexpand(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_vexpand(GObjectPointer widget, bool expand);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_vexpand_set(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_vexpand_set(GObjectPointer widget, bool set);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_queue_compute_expand(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_compute_expand(GObjectPointer widget, GtkOrientation orientation);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_support_multidevice(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_support_multidevice(GObjectPointer widget, bool support_multidevice); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_class_set_accessible_type(GtkWidgetClassPointer widget_class, ulong type);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_class_set_accessible_role(GtkWidgetClassPointer widget_class, AtkRole role);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern AtkObjectPointer gtk_widget_get_accessible(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkAlign gtk_widget_get_halign(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_halign(GObjectPointer widget, GtkAlign align);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkAlign gtk_widget_get_valign(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkAlign gtk_widget_get_valign_with_baseline(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_valign(GObjectPointer widget, GtkAlign align);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_widget_get_margin_left(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_margin_left(GObjectPointer widget, int margin);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_widget_get_margin_right(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_margin_right(GObjectPointer widget, int margin);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_widget_get_margin_start(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_margin_start(GObjectPointer widget, int margin);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_widget_get_margin_end(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_margin_end(GObjectPointer widget, int margin);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_widget_get_margin_top(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_margin_top(GObjectPointer widget, int margin);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_widget_get_margin_bottom(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_margin_bottom(GObjectPointer widget, int margin); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gtk_widget_get_events(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkEventMask gtk_widget_get_device_events(GObjectPointer widget, GdkDevicePointer device);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_get_pointer(GObjectPointer widget, out int x, out int y); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_is_ancestor(GObjectPointer widget, GObjectPointer ancestor); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_translate_coordinates(GObjectPointer src_widget, GObjectPointer dest_widget, int src_x, int src_y, out int dest_x, out int dest_y); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_hide_on_delete(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_override_color(GObjectPointer widget, GtkStateFlags state, out GdkRGBA color);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_override_background_color(GObjectPointer widget, GtkStateFlags state, out GdkRGBA color); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_override_font(GObjectPointer widget, PangoFontDescriptionPointer font_desc); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_override_symbolic_color(GObjectPointer widget, string name, out GdkRGBA color);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_override_cursor(GObjectPointer widget, out GdkRGBA cursor, out GdkRGBA secondary_cursor); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_reset_style(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern PangoContextPointer gtk_widget_create_pango_context(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern PangoContextPointer gtk_widget_get_pango_context(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_font_options(GObjectPointer widget, CairoFontOptionsPointer options);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern CairoFontOptionsPointer gtk_widget_get_font_options(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern PangoLayoutPointer gtk_widget_create_pango_layout(GObjectPointer widget, string text); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkPixbufPointer gtk_widget_render_icon_pixbuf(GObjectPointer widget, string stock_id, GtkIconSize size); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_composite_name(GObjectPointer widget, string name);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_widget_get_composite_name(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_push_composite_child();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_pop_composite_child(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_style_get_property(GObjectPointer widget, string property_name, out ulong value);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_direction(GObjectPointer widget, GtkTextDirection dir);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkTextDirection gtk_widget_get_direction(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_default_direction(GtkTextDirection dir);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkTextDirection gtk_widget_get_default_direction(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_is_composited(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_shape_combine_region(GObjectPointer widget, CairoRegionPointer region);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_input_shape_combine_region(GObjectPointer widget, CairoRegionPointer region); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GListPointer gtk_widget_list_mnemonic_labels(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_add_mnemonic_label(GObjectPointer widget, GObjectPointer label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_remove_mnemonic_label(GObjectPointer widget, GObjectPointer label); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_tooltip_window(GObjectPointer widget, GtkWindowPointer custom_window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkWindowPointer gtk_widget_get_tooltip_window(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_trigger_tooltip_query(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_tooltip_text(GObjectPointer widget, string text);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_widget_get_tooltip_text(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_tooltip_markup(GObjectPointer widget, string markup);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_widget_get_tooltip_markup(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_has_tooltip(GObjectPointer widget, bool has_tooltip);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_get_has_tooltip(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_cairo_should_draw_window(CairoPointer cr, GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_cairo_transform_to_window(CairoPointer cr, GObjectPointer widget, GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gtk_requisition_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkRequisitionPointer gtk_requisition_new();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkRequisitionPointer gtk_requisition_copy(out GtkRequisition requisition);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_requisition_free(out GtkRequisition requisition); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_widget_in_destruction(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkStyleContextPointer gtk_widget_get_style_context(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GtkWidgetPathPointer gtk_widget_get_path(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkModifierType gtk_widget_get_modifier_mask(GObjectPointer widget, GdkModifierIntent intent); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_insert_action_group(GObjectPointer widget, string name, GActionGroupPointer group);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint gtk_widget_add_tick_callback(GObjectPointer widget, GtkTickCallbackPointer callback, IntPtr user_data, GDestroyNotifyPointer notify); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_remove_tick_callback(GObjectPointer widget, uint id);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_init_template(GObjectPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_widget_get_template_child(GObjectPointer widget, ulong widget_type, string name);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_class_bind_template_child_full(GtkWidgetClassPointer widget_class, string name, bool public_child, long struct_offset); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GActionGroupPointer gtk_widget_get_action_group(GObjectPointer widget, string prefix); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_widget_list_action_prefixes(GObjectPointer widget); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_widget_set_font_map(GObjectPointer widget, PangoFontMapPointer font_map);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern PangoFontMapPointer gtk_widget_get_font_map(GObjectPointer widget);
    }
}
