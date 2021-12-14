using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gdk.Types;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class Image : Widget
    {
        private GdkPixbuf pixbuf;

        public GdkPixbuf Pixbuf
        {
            get
            {
                return GetPixbuf();
            }
            set
            {
                SetPixbuf(value);
            }
        }

        public Image()
        {
            handle = NativeImage.gtk_image_new();
        }

        public Image(string filepath)
        {
            handle = NativeImage.gtk_image_new_from_file(filepath);
        }

        public Image(GdkPixbuf pixbuf)
        {
            if(!pixbuf.handle.IsNullPointer)
                handle = NativeImage.gtk_image_new_from_pixbuf(pixbuf.handle);
        }

        public Image(GIcon icon, GtkIconSize size)
        {
            handle = NativeImage.gtk_image_new_from_gicon(icon.handle, size);            
        }

        public Image(string stockId, GtkIconSize size)
        {
            handle = NativeImage.gtk_image_new_from_stock(stockId, size);
        }

        internal Image(GtkWidgetPointer handle)
        {
            this.handle = handle;
        }

        public GdkPixbuf GetPixbuf()
        {
            if(handle.IsNullPointer)
                return null;
            
            GdkPixbufPointer p = NativeImage.gtk_image_get_pixbuf(handle);
            if(pixbuf == null)
                pixbuf = new GdkPixbuf(p);
            else
                pixbuf.handle = p;
            return pixbuf;
        }

        public void SetPixbuf(GdkPixbuf pixbuf)
        {
            this.pixbuf = pixbuf;
        }
    }
}