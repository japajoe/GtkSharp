using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gdk.Native;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.Gdk.Types
{
	public struct GdkImageFormat
	{
		public GdkColorspace colorspace;
		public int channels;
		public int bitsPerSample;
		public bool hasAlpha;
		public int width;
		public int height;
		public int rowstride;

		public GdkImageFormat(GdkColorspace colorspace, int channels, int bitsPerSample, bool hasAlpha, int width, int height, int rowstride)
		{
			this.colorspace = colorspace;
			this.channels = channels;
			this.bitsPerSample = bitsPerSample;
			this.hasAlpha = hasAlpha;
			this.width = width;
			this.height = height;
			this.rowstride = rowstride;
		}

		public static GdkImageFormat FromPixbuf(GObjectPointer pixbuf)
		{
			if(pixbuf.IsNullPointer)
			{
				return default;
			}

			GdkColorspace colorspace = NativeGdkPixbuf.gdk_pixbuf_get_colorspace(pixbuf);
			int channels = NativeGdkPixbuf.gdk_pixbuf_get_n_channels(pixbuf);
			int bitsPerSample = NativeGdkPixbuf.gdk_pixbuf_get_bits_per_sample(pixbuf);
			bool hasAlpha = NativeGdkPixbuf.gdk_pixbuf_get_has_alpha(pixbuf);
			int width = NativeGdkPixbuf.gdk_pixbuf_get_width(pixbuf);
			int height = NativeGdkPixbuf.gdk_pixbuf_get_height(pixbuf);
			int rowStride = NativeGdkPixbuf.gdk_pixbuf_get_rowstride(pixbuf);

			return new GdkImageFormat(colorspace, channels, bitsPerSample, hasAlpha, width, height, rowStride);
		}
	}
}