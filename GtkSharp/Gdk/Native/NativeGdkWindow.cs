using System;
using System.Runtime.InteropServices;
using GtkSharp.Cairo.Native.Types;
using GtkSharp.Cairo.Types;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gdk.Types;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gdk.Native
{
    public static class NativeGdkWindow
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_window_has_native(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_type_hint(GObjectPointer window, GdkWindowTypeHint hint);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkWindowTypeHint gdk_window_get_type_hint(GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_window_get_modal_hint(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_modal_hint(GObjectPointer window, bool modal); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_skip_taskbar_hint(GObjectPointer window, bool skips_taskbar);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_skip_pager_hint(GObjectPointer window, bool skips_pager);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_urgency_hint(GObjectPointer window, bool urgent); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_geometry_hints(GObjectPointer window, ref GdkGeometry geometry, GdkWindowHints geom_mask); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern CairoRegionPointer gdk_window_get_clip_region(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern CairoRegionPointer gdk_window_get_visible_region(GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_begin_paint_rect(GObjectPointer window, ref GdkRectangle rectangle);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_mark_paint_from_clip(GObjectPointer window, CairoPointer cr);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_begin_paint_region(GObjectPointer window, CairoRegionPointer region);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_end_paint(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_flush(GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_title(GObjectPointer window, string title);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_role(GObjectPointer window, string role);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_startup_id(GObjectPointer window, string startup_id);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_transient_for(GObjectPointer window, GObjectPointer parent);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_background(GObjectPointer window, ref GdkColor color);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_background_rgba(GObjectPointer window, ref GdkRGBA rgba);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_background_pattern(GObjectPointer window, CairoPatternPointer pattern);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern CairoPatternPointer gdk_window_get_background_pattern(GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_cursor(GObjectPointer window, GObjectPointer cursor);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_window_get_cursor(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_device_cursor(GObjectPointer window, GdkDevicePointer device, GObjectPointer cursor);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_window_get_device_cursor(GObjectPointer window, GdkDevicePointer device);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_get_user_data(GObjectPointer window, IntPtr data);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_get_geometry(GObjectPointer window, out int x, out int y, out int width, out int height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_window_get_width(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_window_get_height(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_get_position(GObjectPointer window, out int x, out int y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_window_get_origin(GObjectPointer window, out int x, out int y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_get_root_coords(GObjectPointer window, int x, int y, out int root_x, out int root_y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_coords_to_parent(GObjectPointer window, double x, double y, out double parent_x, out double parent_y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_coords_from_parent(GObjectPointer window, double parent_x, double parent_y, out double x, out double y); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_get_root_origin(GObjectPointer window, out int x, out int y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_get_frame_extents(GObjectPointer window, out GdkRectangle rect); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_window_get_scale_factor(GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_window_get_pointer(GObjectPointer window, out int x, out int y, ref GdkModifierType mask); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_window_get_device_position(GObjectPointer window, GdkDevicePointer device, out int x, out int y, out GdkModifierType mask);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_window_get_device_position_double(GObjectPointer window, GdkDevicePointer device, out double x, out double y, out GdkModifierType mask);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_window_get_parent(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_window_get_toplevel(GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_window_get_effective_parent(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_window_get_effective_toplevel(GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GListPointer gdk_window_get_children(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GListPointer gdk_window_peek_children(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GListPointer gdk_window_get_children_with_user_data(GObjectPointer window, IntPtr user_data); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkEventMask gdk_window_get_events(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_events(GObjectPointer window, GdkEventMask event_mask);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_device_events(GObjectPointer window, GdkDevicePointer device, GdkEventMask event_mask);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkEventMask gdk_window_get_device_events(GObjectPointer window, GdkDevicePointer device); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_source_events(GObjectPointer window, GdkInputSource source, GdkEventMask event_mask);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkEventMask gdk_window_get_source_events(GObjectPointer window, GdkInputSource source); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_icon_list(GObjectPointer window, GListPointer pixbufs);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_icon_name(GObjectPointer window, string name);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_group(GObjectPointer window, GObjectPointer leader);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_window_get_group(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_decorations(GObjectPointer window, GdkWMDecoration decorations);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_window_get_decorations(GObjectPointer window, out GdkWMDecoration decorations);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_functions(GObjectPointer window, GdkWMFunction functions); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern CairoSurfacePointer gdk_window_create_similar_surface(GObjectPointer window, CairoContent content, int width, int height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern CairoSurfacePointer gdk_window_create_similar_image_surface(GObjectPointer window, CairoFormat format, int width, int height, int scale); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_beep(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_iconify(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_deiconify(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_stick(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_unstick(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_maximize(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_unmaximize(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_fullscreen(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_fullscreen_on_monitor(GObjectPointer window, int monitor);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_fullscreen_mode(GObjectPointer window, GdkFullscreenMode mode);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkFullscreenMode gdk_window_get_fullscreen_mode(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_unfullscreen(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_keep_above(GObjectPointer window, bool setting);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_keep_below(GObjectPointer window, bool setting);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_opacity(GObjectPointer window, double opacity);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_register_dnd(GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkDragProtocol gdk_window_get_drag_protocol(GObjectPointer window, GObjectPointer target); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_begin_resize_drag(GObjectPointer window, GdkWindowEdge edge, int button, int root_x, int root_y, uint timestamp);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_begin_resize_drag_for_device(GObjectPointer window, GdkWindowEdge edge, GdkDevicePointer device, int button, int root_x, int root_y, uint timestamp);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_begin_move_drag(GObjectPointer window, int button, int root_x, int root_y, uint timestamp);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_begin_move_drag_for_device(GObjectPointer window, GdkDevicePointer device, int button, int root_x, int root_y, uint timestamp);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_invalidate_rect(GObjectPointer window, ref GdkRectangle rect, bool invalidate_children);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_invalidate_region(GObjectPointer window, CairoRegionPointer region, bool invalidate_children);
        
        public delegate bool GdkWindowChildFunc(GObjectPointer window, IntPtr user_data);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_invalidate_maybe_recurse(GObjectPointer window, CairoRegionPointer region, IntPtr child_func, IntPtr user_data);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern CairoRegionPointer gdk_window_get_update_area(GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_freeze_updates(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_thaw_updates(GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_freeze_toplevel_updates_libgtk_only(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_thaw_toplevel_updates_libgtk_only(GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_process_all_updates();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_process_updates(GObjectPointer window, bool update_children); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_debug_updates(bool setting); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_constrain_size(ref GdkGeometry geometry, GdkWindowHints flags, int width, int height, out int new_width, out int new_height); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_enable_synchronized_configure(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_configure_finished(GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_get_default_root_window();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern CairoSurfacePointer  gdk_offscreen_window_get_surface(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_offscreen_window_set_embedder(GObjectPointer window, GObjectPointer embedder);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_offscreen_window_get_embedder(GObjectPointer window);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_geometry_changed(GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_support_multidevice(GObjectPointer window, bool support_multidevice);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_window_get_support_multidevice(GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkFrameClockPointer gdk_window_get_frame_clock(GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_opaque_region(GObjectPointer window, CairoRegionPointer region); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_event_compression(GObjectPointer window, bool event_compression);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_window_get_event_compression(GObjectPointer window); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_window_set_shadow_width(GObjectPointer window, int left, int right, int top, int bottom);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_window_show_window_menu(GObjectPointer window, ref IntPtr gdkEvent); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkGLContextPointer gdk_window_create_gl_context(GObjectPointer window, GErrorPointer error);
    }
}