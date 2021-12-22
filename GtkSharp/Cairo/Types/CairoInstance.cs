using GtkSharp.Cairo.Native;
using GtkSharp.Cairo.Native.Types;
using GtkSharp.Gdk.Native;
using GtkSharp.Gdk.Types;

namespace GtkSharp.Cairo.Types
{
    public class CairoInstance
    {
        internal CairoPointer cr;

        public CairoInstance()
        {
            
        }

        public void Fill()
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_fill(cr);
        }

        public void FillPreserve()
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_fill_preserve(cr);
        }

        public void Stroke()
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_stroke(cr);
        }

        public void StrokePreserve()
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_stroke_preserve(cr);
        }

        public void SetSourceRGB(double r, double g, double b)
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_set_source_rgb(cr, r, g, b);
        }

        public void SetSourceRGBA(double r, double g, double b, double a)
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_set_source_rgba(cr, r, g, b, a);
        }

        public void SetSourceColor(GdkColor color)
        {
            if(cr.IsNullPointer)
                return;            
            NativeGdkCairo.gdk_cairo_set_source_color(cr, ref color);
        }

        public void SetSourceRGBA(GdkRGBA color)
        {
            if(cr.IsNullPointer)
                return;
            NativeGdkCairo.gdk_cairo_set_source_rgba(cr, ref color);
        }

        public void SetSourcePixbuf(GdkPixbuf pixbuf, double x, double y)
        {
            if(cr.IsNullPointer)
                return;
            NativeGdkCairo.gdk_cairo_set_source_pixbuf(cr, pixbuf.handle, x, y);
        }

        public void SetSourceSurface(CairoSurface surface, double x, double y)
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_set_source_surface(cr, surface.handle, x, y);
        }

        public void Arc(double xc, double yc, double radius, double angle1, double angle2)
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_arc(cr, xc, yc, radius, angle1, angle2);
        }

        public void Rectangle(double x, double y, double width, double height)
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_rectangle(cr, x, y, width, height);
        }

        public void Rectangle(GdkRectangle rectangle)
        {
            if(cr.IsNullPointer)
                return;
            NativeGdkCairo.gdk_cairo_rectangle(cr, ref rectangle);
        }

        public void LineTo(double x, double y)
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_line_to(cr, x, y);
        }

        public void MoveTo(float x, float y)
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_move_to(cr, (double)x, (double)y);
        }

        public void MoveTo(double x, double y)
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_move_to(cr, x, y);
        }

        public void ShowText(string text)
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_show_text(cr, text);
        }

        public void SetLineWidth(double width)
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_set_line_width(cr, width);
        }

        public void Rotate(double angle)
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_rotate(cr, angle);
        }

        public void Scale(double sx, double sy)
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_scale(cr, sx, sy);
        }

        public void Translate(double tx, double ty)
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_translate(cr, tx, ty);
        }

        public void NewPath()
        {
            if(cr.IsNullPointer)
                return;

            CairoLib.cairo_new_path(cr);
        }

        public void NewSubPath()
        {
            if(cr.IsNullPointer)
                return;

            CairoLib.cairo_new_sub_path(cr);
        }

        public void ClosePath()
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_close_path(cr);
        }

        public void SelectFontFace(string font, CairoFontSlant slant, CairoFontWeight weight)
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_select_font_face(cr, font, slant, weight);
        }

        public void SetFontSize(double size)
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_set_font_size(cr, size);
        }

        public void Save()
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_save(cr);
        }

        public void Restore()
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_restore(cr);
        }

        public void Paint()
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_paint(cr);
        }

        public void PaintWithAlpha(double alpha)
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_paint_with_alpha(cr, alpha);
        }

        public void Clip()
        {
            if(cr.IsNullPointer)
                return;
            CairoLib.cairo_clip(cr);
        }

        public bool ClipRectangle(out GdkRectangle rectangle)
        {
            if(cr.IsNullPointer)
            {
                rectangle = new GdkRectangle();
                return false;
            }
            return NativeGdkCairo.gdk_cairo_get_clip_rectangle(cr, out rectangle);
        }
    }
}