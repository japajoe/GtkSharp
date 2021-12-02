using GtkSharp.Native;

namespace GtkSharp
{
    public unsafe class Image : Widget
    {
        private GdkPixbufPointer pixbuf;
        private byte[] data;
        private ImageFormat format;

        public ImageFormat Format
        {
            get
            {
                return format;
            }
        }

        public Image(string iconName, GtkIconSize size)
        {
            Gtk.GtkSharpImageCreateFromIconName(out handle.pointer, iconName, size);

            if(!handle.IsNullPointer)
            {
                Gtk.GtkSharpImageGetPixbuf(out handle.pointer, out pixbuf.pointer);
                format = ImageFormat.FromPixbuf(pixbuf);
            }
        }

        public Image(string filepath)
        {
            Gtk.GtkSharpImageCreateFromFile(out handle.pointer, filepath);

            if(!handle.IsNullPointer)
            {
                Gtk.GtkSharpImageGetPixbuf(out handle.pointer, out pixbuf.pointer);
                format = ImageFormat.FromPixbuf(pixbuf);
            }            
        }

        public Image(GdkPixbufPointer pixbuf)
        {
            Gtk.GtkSharpImageCreateFromPixbuf(out handle.pointer, out pixbuf.pointer);
            this.pixbuf = pixbuf;
            format = ImageFormat.FromPixbuf(pixbuf);
        }

        public Image(byte[] data, int width, int height, bool hasAlpha)
        {
            this.data = data;
	        int bitsPerSample = 24 + (hasAlpha ? 8 : 0);
	        int size = width * height * bitsPerSample;
            
            fixed(byte* ptr = &data[0])
            {
                Gdk.GdkSharpPixbufCreateFromData(out pixbuf.pointer, ptr, width, height, hasAlpha);
            }
            
            format = ImageFormat.FromPixbuf(pixbuf);
        }

        public static int CalculateDataLength(int width, int height, bool hasAlpha)
        {
            int bitsPerSample = 24 + (hasAlpha ? 8 : 0);
	        return width * height * bitsPerSample;	        
        }
    }
}