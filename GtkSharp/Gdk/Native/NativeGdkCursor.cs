using System.Runtime.InteropServices;
using GtkSharp.Cairo.Native.Types;
using GtkSharp.Gdk.Types;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gdk.Native
{
    public static class NativeGdkCursor
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gdk_cursor_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_cursor_new_for_display(GObjectPointer display, GdkCursorType cursor_type);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_cursor_new(GdkCursorType cursor_type);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_cursor_new_from_pixbuf(GObjectPointer display, GObjectPointer pixbuf, int x, int y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_cursor_new_from_surface(GObjectPointer display, CairoSurfacePointer surface, double x, double y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_cursor_new_from_name(GObjectPointer display, string name);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_cursor_get_display(GObjectPointer cursor);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_cursor_ref(GObjectPointer cursor);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_cursor_unref(GObjectPointer cursor);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_cursor_get_image(GObjectPointer cursor);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern CairoSurfacePointer gdk_cursor_get_surface(GObjectPointer cursor, ref double x_hot, ref double y_hot);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkCursorType gdk_cursor_get_cursor_type(GObjectPointer cursor);
    }
}