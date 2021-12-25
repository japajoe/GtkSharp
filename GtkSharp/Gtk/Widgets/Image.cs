using System;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gdk.Types;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Types;
using GtkSharp.Glib.Native.Types;

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
            GetPixbuf();
        }

        public Image(string filepath)
        {
            handle = NativeImage.gtk_image_new_from_file(filepath);
            GetPixbuf();
        }

        public Image(GdkPixbuf pixbuf)
        {
            if(!pixbuf.handle.IsNullPointer)
                handle = NativeImage.gtk_image_new_from_pixbuf(pixbuf.handle);
            
            GetPixbuf();
        }

        public Image(GIcon icon, GtkIconSize size)
        {
            handle = NativeImage.gtk_image_new_from_gicon(icon.handle, size);
            GetPixbuf();
        }

        public Image(string stockId, GtkIconSize size)
        {
            handle = NativeImage.gtk_image_new_from_stock(stockId, size);
            GetPixbuf();
        }

        internal Image(GObjectPointer handle)
        {
            this.handle = handle;
            GetPixbuf();
        }

        protected GdkPixbuf GetPixbuf()
        {
            if(handle.IsNullPointer)
                return null;
            
            var p = NativeImage.gtk_image_get_pixbuf(handle);
            if(pixbuf == null)
                pixbuf = new GdkPixbuf(p);
            else
                pixbuf.handle = p;
            return pixbuf;
        }

        protected void SetPixbuf(GdkPixbuf pixbuf)
        {
            this.pixbuf = pixbuf;
        }

        public void Scale(float scaleX, float scaleY)
        {
            if(handle.IsNullPointer)
                return;
            
            pixbuf.Scale(scaleX, scaleY);

            NativeImage.gtk_image_set_from_pixbuf(handle, pixbuf.handle);
        }

        public bool GetPixel(int x, int y, out GdkRGBA color)
        {
            color = new GdkRGBA();

            if(handle.IsNullPointer)
                return false;
            
            return pixbuf.GetPixel(x, y, out color);
        }

        public void Clear(GdkRGBA color)
        {
            if(handle.IsNullPointer)
                return;
            
            for(int y = 0; y < pixbuf.Format.height; y++)
            {
                for(int x = 0; x < pixbuf.Format.width; x++)
                {
                    pixbuf.SetPixel(x, y, color);
                }
            }
        }

        public void SetPixel(int x, int y, GdkRGBA color)
        {
            if(handle.IsNullPointer)
                return;
            
            pixbuf.SetPixel(x, y, color);
        }

        public void DrawLine(int x1, int y1, int x2, int y2, GdkRGBA color)
        {
            if(handle.IsNullPointer)
                return;

            int dx = Math.Abs(x2 - x1);
            int sx = x1 < x2 ? 1 : -1;
            int dy = Math.Abs(y2 - y1);
            int sy = y1 < y2 ? 1 : -1;
            int err = (dx > dy ? dx : -dy) / 2;

            while (x1 != x2 || y1 != y2) 
            {
                pixbuf.SetPixel(x1, y1, color);
                int e2 = err;
                if (e2 > -dx) 
                { 
                    err -= dy; x1 += sx; 
                }
                if (e2 <  dy) 
                { 
                    err += dx; y1 += sy; 
                }
            }            
        }

        public void DrawRectangle(int x, int y, int width, int height, GdkRGBA color)
        {
            if(handle.IsNullPointer)
                return;

            int xStart = x;
            int xEnd = xStart + width;
            int yStart = y;
            int yEnd = yStart + height;
            
            for(int i = yStart; i < yEnd; i++)
            {
                for(int j = xStart; j < xEnd; j++)
                {
                    pixbuf.SetPixel(j, i, color);
                }
            }
        }

        public void DrawFilledCircle(int x, int y, int radius, GdkRGBA color)
        {
            if(handle.IsNullPointer)
                return;

            if (radius < 0 || x < -radius || y < -radius)
                return;

            if (radius > 0)
            {
                int x0 = 0;
                int y0 = radius;
                int d = 3 - 2 * radius;

                Action<int,int,int> drawline = (sx, ex, y) =>
                {
                    for (int x = sx; x <= ex; x++)
                        pixbuf.SetPixel(x, y, color);
                };

                while (y0 >= x0)
                {
                    drawline(x - y0, x + y0, y - x0);
                    if (x0 > 0)	
                        drawline(x - y0, x + y0, y + x0);

                    if (d < 0)
                        d += 4 * x0++ + 6;
                    else
                    {
                        if (x0 != y0)
                        {
                            drawline(x - x0, x + x0, y - y0);
                            drawline(x - x0, x + x0, y + y0);
                        }
                        d += 4 * (x0++ - y0--) + 10;
                    }
                }
            }
            else
                pixbuf.SetPixel(x, y, color);
        }
    }
}