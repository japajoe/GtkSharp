using GtkSharp.Native;

namespace GtkSharp
{
	public struct ImageFormat
	{
		public GdkColorspace colorspace;
		public int channels;
		public int bitsPerSample;
		public bool hasAlpha;
		public int width;
		public int height;
		public int rowstride;

        public ImageFormat(GdkColorspace colorspace, int channels, int bitsPerSample, bool hasAlpha, int width, int height, int rowstride)
        {
            this.colorspace = colorspace;
            this.channels = channels;
            this.bitsPerSample = bitsPerSample;
            this.hasAlpha = hasAlpha;
            this.width = width;
            this.height = height;
            this.rowstride = rowstride;
        }

		public static ImageFormat FromPixbuf(GdkPixbufPointer pixbuf)
		{
            if(pixbuf.IsNullPointer)
            {
                return default;
            }

            GdkColorspace colorspace;
            int channels;			
			int bitsPerSample;
			bool hasAlpha;
			int width;
			int height;
			int rowStride;

            Gdk.GdkSharpPixbufGetColorspace(out pixbuf.pointer, out colorspace);
			Gdk.GdkSharpPixbufGetChannelCount(out pixbuf.pointer, out channels);
            Gdk.GdkSharpPixbufGetBitsPerSample(out pixbuf.pointer, out bitsPerSample);
            Gdk.GdkSharpPixbufGetHasAlpha(out pixbuf.pointer, out hasAlpha);
            Gdk.GdkSharpPixbufGetWidth(out pixbuf.pointer, out width);
            Gdk.GdkSharpPixbufGetHeight(out pixbuf.pointer, out height);
            Gdk.GdkSharpPixbufGetRowstride(out pixbuf.pointer, out rowStride);

			return new ImageFormat(colorspace, channels, bitsPerSample, hasAlpha, width, height, rowStride);
		}
	};
}