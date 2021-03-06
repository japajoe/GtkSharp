using System;
using System.Runtime.InteropServices;
using GtkSharp.Gdk.Types;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gdk.Native
{
    public static class NativeGdkPixbuf
    {
        const string NATIVELIB_GDKPIXBUF = "gdk_pixbuf-2.0";

        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_pixbuf_new(GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height);        
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_pixbuf_new_from_file(string filename, out GErrorPointer error);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_pixbuf_new_from_file_at_size(string filename, int width, int height, out GErrorPointer error);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_pixbuf_new_from_file_at_scale(string filename, int width, int height, bool preserve_aspect_ratio, out GErrorPointer error);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_pixbuf_new_from_resource(string resource_path, out GErrorPointer error);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_pixbuf_new_from_resource_at_scale(string resource_path, int width, int height, bool preserve_aspect_ratio, out GErrorPointer error);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe GObjectPointer gdk_pixbuf_new_from_data(byte* data, GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride, IntPtr gdkPixbufDestroyNotify, IntPtr destroy_fn_data);

        public static unsafe GObjectPointer gdk_pixbuf_new_from_data(byte[] data, GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride, IntPtr gdkPixbufDestroyNotify, IntPtr destroy_fn_data)
        {
            GObjectPointer p;

            fixed(byte* ptr = &data[0])
            {
                p = gdk_pixbuf_new_from_data(ptr, colorspace, has_alpha, bits_per_sample, width, height, rowstride, gdkPixbufDestroyNotify, destroy_fn_data);
            }

            return p;
        }

        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_pixbuf_scale_simple(GObjectPointer src, int dest_width, int dest_height, GdkInterpType interp_type);        
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkColorspace gdk_pixbuf_get_colorspace(GObjectPointer pixbuf);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_pixbuf_get_n_channels(GObjectPointer pixbuf);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_pixbuf_get_has_alpha(GObjectPointer pixbuf);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_pixbuf_get_bits_per_sample(GObjectPointer pixbuf);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gdk_pixbuf_get_pixels(GObjectPointer pixbuf);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_pixbuf_get_width(GObjectPointer pixbuf);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_pixbuf_get_height(GObjectPointer pixbuf);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern int gdk_pixbuf_get_rowstride(GObjectPointer pixbuf);
        
        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gdk_pixbuf_get_byte_length(GObjectPointer pixbuf);

        [DllImport(NATIVELIB_GDKPIXBUF, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_pixbuf_save(GObjectPointer pixbuf, string filename, string type, IntPtr error, IntPtr data);
    }
}