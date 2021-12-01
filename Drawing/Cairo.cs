using GtkSharp.Native;

namespace GtkSharp.Drawing
{
    public class Cairo
    {
        internal CairoPointer cr;

        public Cairo()
        {
            
        }

        public void Fill()
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoFill(out cr.pointer);
        }

        public void FillPreserve()
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoFillPreserve(out cr.pointer);
        }

        public void Stroke()
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoStroke(out cr.pointer);
        }

        public void StrokePreserve()
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoStrokePreserve(out cr.pointer);
        }

        public void SetSourceRGB(double r, double g, double b)
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoSetSourceRGB(out cr.pointer, r, g, b);
        }

        public void SetSourceRGBA(double r, double g, double b, double a)
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoSetSourceRGBA(out cr.pointer, r, g, b, a);
        }

        public void Arc(double xc, double yc, double radius, double angle1, double angle2)
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoArc(out cr.pointer, xc, yc, radius, angle1, angle2);
        }

        public void Rectangle(double x, double y, double width, double height)
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoRectangle(out cr.pointer, x, y, width, height);
        }

        public void LineTo(double x, double y)
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoLineTo(out cr.pointer, x, y);
        }

        public void MoveTo(double x, double y)
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoMoveTo(out cr.pointer, x, y);
        }

        public void ShowText(string text)
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoShowText(out cr.pointer, text);
        }

        public void SetLineWidth(double width)
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoSetLineWidth(out cr.pointer, width);
        }

        public void Rotate(double angle)
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoRotate(out cr.pointer, angle);
        }

        public void Scale(double sx, double sy)
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoScale(out cr.pointer, sx, sy);
        }

        public void Translate(double tx, double ty)
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoTranslate(out cr.pointer, tx, ty);
        }

        public void ClosePath()
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoClosePath(out cr.pointer);
        }

        public void SelectFontFace(string font, FontSlant slant, FontWeight weight)
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoSelectFontFace(out cr.pointer, font, slant, weight);
        }

        public void SetFontSize(double size)
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoSetFontSize(out cr.pointer, size);
        }

        public void Save()
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoSave(out cr.pointer);
        }

        public void Restore()
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoRestore(out cr.pointer);
        }

        public void Paint()
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoPaint(out cr.pointer);
        }

        public void PaintWithAlpha(double alpha)
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoPaintWithAlpha(out cr.pointer, alpha);
        }

        public void Clip()
        {
            if(cr.IsNullPointer)
                return;
            Gtk.GtkSharpCairoClip(out cr.pointer);
        }
    }
}