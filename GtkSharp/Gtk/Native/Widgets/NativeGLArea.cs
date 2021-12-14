using System.Runtime.InteropServices;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Gtk.Native.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeGLArea
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_gl_area_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_gl_area_new();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_gl_area_set_required_version(GtkWidgetPointer area, int major, int minor);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_gl_area_get_required_version(GtkWidgetPointer area, out int major, out int minor);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_gl_area_get_has_alpha(GtkWidgetPointer area);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_gl_area_set_has_alpha(GtkWidgetPointer area, bool has_alpha);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_gl_area_get_has_depth_buffer(GtkWidgetPointer area);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_gl_area_set_has_depth_buffer(GtkWidgetPointer area, bool has_depth_buffer);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_gl_area_get_has_stencil_buffer(GtkWidgetPointer area);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_gl_area_set_has_stencil_buffer(GtkWidgetPointer area, bool has_stencil_buffer);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_gl_area_get_auto_render(GtkWidgetPointer area);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_gl_area_set_auto_render(GtkWidgetPointer area, bool auto_render);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_gl_area_queue_render(GtkWidgetPointer area);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkGLContextPointer gtk_gl_area_get_context(GtkWidgetPointer area);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_gl_area_make_current(GtkWidgetPointer area);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_gl_area_attach_buffers(GtkWidgetPointer area);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_gl_area_set_error(GtkWidgetPointer area, GErrorPointer error);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GErrorPointer gtk_gl_area_get_error(GtkWidgetPointer area);
    }
}