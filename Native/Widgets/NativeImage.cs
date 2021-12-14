using System.Runtime.InteropServices;
using GtkSharp.Native.Types;
using System;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeImage
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_image_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_image_new();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_image_new_from_file(string filename);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_image_new_from_resource(string resource_path);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_image_new_from_pixbuf(GdkPixbufPointer pixbuf);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_image_new_from_stock(string stock_id, GtkIconSize size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_image_new_from_icon_set(GtkIconSetPointer icon_set, GtkIconSize size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_image_new_from_animation(GdkPixbufAnimationPointer animation);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_image_new_from_icon_name(string icon_name, GtkIconSize size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_image_new_from_gicon(GIconPointer icon, GtkIconSize size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_image_new_from_surface(CairoSurfacePointer surface);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_image_clear(GtkWidgetPointer image);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_image_set_from_file(GtkWidgetPointer image, string filename);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_image_set_from_resource(GtkWidgetPointer image, string resource_path);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_image_set_from_pixbuf(GtkWidgetPointer image, GdkPixbufPointer pixbuf);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_image_set_from_stock(GtkWidgetPointer image, string stock_id, GtkIconSize size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_image_set_from_icon_set(GtkWidgetPointer image, GtkIconSetPointer icon_set, GtkIconSize size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_image_set_from_animation(GtkWidgetPointer image, GdkPixbufAnimationPointer animation);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_image_set_from_icon_name(GtkWidgetPointer image, string icon_name, GtkIconSize size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_image_set_from_gicon(GtkWidgetPointer image, GIconPointer icon, GtkIconSize size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_image_set_from_surface(GtkWidgetPointer image, CairoSurfacePointer surface);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_image_set_pixel_size(GtkWidgetPointer image, int pixel_size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkImageType gtk_image_get_storage_type(GtkWidgetPointer image);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkPixbufPointer gtk_image_get_pixbuf(GtkWidgetPointer image);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_image_get_stock(GtkWidgetPointer image, IntPtr stock_id, ref GtkIconSize size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_image_get_icon_set(GtkWidgetPointer image, GtkIconSetPointer icon_set, ref GtkIconSize size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GdkPixbufAnimationPointer gtk_image_get_animation(GtkWidgetPointer image);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_image_get_icon_name(GtkWidgetPointer image, IntPtr icon_name, out GtkIconSize size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_image_get_gicon(GtkWidgetPointer image, GIconPointer gicon, ref GtkIconSize size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int gtk_image_get_pixel_size(GtkWidgetPointer image);
    }
}