using System;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gdk.Native;
using GtkSharp.GLib.Types;
using GtkSharp.Utilities;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gdk.Types
{
    public class GdkPixbuf : GObject
    {
        internal GdkPixbufPointer handle;
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

        internal GdkPixbuf(GdkPixbufPointer handle)
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

        public GdkPixbuf(byte[] data, int width, int height, bool hasAlpha)
        {
	        int bitsPerSample = 24 + (hasAlpha ? 8 : 0);
	        int size = width * height * bitsPerSample;
	        int rowstride = width * bitsPerSample;
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

        private void OnDestroyNotify(IntPtr pixels, IntPtr data)
        {
            DestroyNotify?.Invoke();
        }
    }
}