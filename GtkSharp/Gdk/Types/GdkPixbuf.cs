using System;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gdk.Native;
using GtkSharp.GLib.Types;
using GtkSharp.Utilities;
using GtkSharp.Glib.Native.Types;
using System.Runtime.InteropServices;

namespace GtkSharp.Gdk.Types
{
    public class GdkPixbuf : GObject
    {
        //internal GdkPixbufPointer handle;
        private GdkImageFormat format;
        private GEventHandler<DestroyNotifyCallback,DestroyNotifyEvent> destroyNotifyHandler = new GEventHandler<DestroyNotifyCallback, DestroyNotifyEvent>();

        public GdkImageFormat Format
        {
            get
            {
                return format;
            }
        }

        public DestroyNotifyEvent DestroyNotify
        {
            get
            {
                return destroyNotifyHandler.Event;
            }
            set
            {
                destroyNotifyHandler.Event = value;
            }
        }

        internal GdkPixbuf(GObjectPointer handle)
        {
            this.handle = handle;

            if(!handle.IsNullPointer)
                format = GdkImageFormat.FromPixbuf(handle);
        }

        public GdkPixbuf(string filepath)
        {
            GErrorPointer error;
            handle = NativeGdkPixbuf.gdk_pixbuf_new_from_file(filepath, out error);

            if(!handle.IsNullPointer)
                format = GdkImageFormat.FromPixbuf(handle);
        }

        public GdkPixbuf(GdkColorspace colorspace, bool hasAlpha, int bitsPerSample, int width, int height)
        {
            handle = NativeGdkPixbuf.gdk_pixbuf_new(colorspace, hasAlpha, bitsPerSample, width, height);

            if(!handle.IsNullPointer)
                format = GdkImageFormat.FromPixbuf(handle);
        }

        public GdkPixbuf(byte[] data, int width, int height, bool hasAlpha)
        {
            int bitsPerSample = 8;
            int size = width * height * bitsPerSample;
            int rowstride = width * format.channels;
            destroyNotifyHandler.Callback = OnDestroyNotify;
            handle = NativeGdkPixbuf.gdk_pixbuf_new_from_data(data, GdkColorspace.RGB, hasAlpha, bitsPerSample, width, height, rowstride, destroyNotifyHandler.Callback.ToIntPtr(), IntPtr.Zero);

            if(!handle.IsNullPointer)
                format = GdkImageFormat.FromPixbuf(handle);
        }

        public void Scale(float scaleX, float scaleY)
        {
            if(handle.IsNullPointer)
                return;

            int width = (int)(format.width * scaleX);
            int height = (int)(format.height * scaleY);
            handle = NativeGdkPixbuf.gdk_pixbuf_scale_simple(handle, width, height, GdkInterpType.Bilinear);
            format = GdkImageFormat.FromPixbuf(handle);            
        }

        public IntPtr GetPixels()
        {
            if(handle.IsNullPointer)
                return IntPtr.Zero;
            
            return NativeGdkPixbuf.gdk_pixbuf_get_pixels(handle);
        }

        public bool GetPixel(int x, int y, out GdkRGBA color)
        {
            color = new GdkRGBA();

            if(handle.IsNullPointer)
                return false;
                            
            if(format.colorspace != GdkColorspace.RGB)
                return false;
                
            if(format.bitsPerSample != 8)
                return false;

            if(x < 0 && x >= format.width)
                return false;
            
            if(y < 0 && y >= format.height)
                return false;
            
            IntPtr pixelbuffer = NativeGdkPixbuf.gdk_pixbuf_get_pixels(handle);
            pixelbuffer += y * format.rowstride + x * format.channels;

            byte r = Marshal.ReadByte(pixelbuffer, 0);
            byte g = Marshal.ReadByte(pixelbuffer, 1);
            byte b = Marshal.ReadByte(pixelbuffer, 2);
            byte a = 255;

            if(format.channels == 4)
                a = Marshal.ReadByte(pixelbuffer, 3);

            color = new GdkRGBA(r, g, b, a);
            return true;
        }

        public void SetPixel(int x, int y, GdkRGBA color)
        {
            if(handle.IsNullPointer)
                return;
                            
            if(format.colorspace != GdkColorspace.RGB)
                return;

            if(format.bitsPerSample != 8)
                return;

            if(x < 0 && x >= format.width)
                return;
            
            if(y < 0 && y >= format.height)
                return;
            
            IntPtr pixelbuffer = NativeGdkPixbuf.gdk_pixbuf_get_pixels(handle);
            pixelbuffer += y * format.rowstride + x * format.channels;

            Marshal.WriteByte(pixelbuffer, 0, (byte)(color.red * 255));
            Marshal.WriteByte(pixelbuffer, 1, (byte)(color.green * 255));
            Marshal.WriteByte(pixelbuffer, 2, (byte)(color.blue * 255));
            if(format.channels == 4)
                Marshal.WriteByte(pixelbuffer, 3, (byte)(color.alpha * 255));
        }

        public bool Save(string filename, string format)
        {
            if(handle.IsNullPointer)
                return false;
            
            return NativeGdkPixbuf.gdk_pixbuf_save(handle, filename, format, IntPtr.Zero, IntPtr.Zero);
        }

        private void OnDestroyNotify(IntPtr pixels, IntPtr data)
        {
            DestroyNotify?.Invoke();
        }
    }
}