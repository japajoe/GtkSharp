using System.Runtime.InteropServices;
using GtkSharp.Cairo.Native.Types;
using GtkSharp.Cairo.Types;

namespace GtkSharp.Cairo.Native
{
    public static class CairoLib
    {
        const string NATIVELIBNAME = "cairo";
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_stroke(CairoPointer cr);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_stroke_preserve(CairoPointer cr);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_stroke_extents(CairoPointer cr, out double x1, out double y1, out double x2, out double y2);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_fill(CairoPointer cr);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_fill_preserve(CairoPointer cr);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_set_source_rgb(CairoPointer cr, double red, double green, double blue);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_set_source_rgba(CairoPointer cr, double red, double green, double blue, double alpha);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_set_source_surface(CairoPointer cr, CairoSurfacePointer surface, double x, double y);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_set_line_join(CairoPointer cr, CairoLineJoin line_join);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        unsafe public static extern void cairo_set_dash(CairoPointer cr, double* dashes, int num_dashes, double offset);

        unsafe public static void cairo_set_dash(CairoPointer cr, double[] dashes, int num_dashes, double offset)
        {
            fixed(double* ptr = &dashes[0])
            {
                cairo_set_dash(cr, ptr, num_dashes, offset);
            }
        }
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_set_miter_limit(CairoPointer cr, double limit);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_translate(CairoPointer cr, double tx, double ty);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_scale(CairoPointer cr, double sx, double sy);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_rotate(CairoPointer cr, double angle);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_transform(CairoPointer cr, ref CairoMatrix matrix);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_set_matrix(CairoPointer cr, ref CairoMatrix matrix);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_identity_matrix(CairoPointer cr);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_user_to_device(CairoPointer cr, out double x, out double y);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_user_to_device_distance(CairoPointer cr, out double dx, out double dy);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_device_to_user(CairoPointer cr, out double x, out double y);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_device_to_user_distance(CairoPointer cr, out double dx, out double dy); 
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_new_path(CairoPointer cr);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_move_to(CairoPointer cr, double x, double y);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_new_sub_path(CairoPointer cr);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_line_to(CairoPointer cr, double x, double y);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_curve_to(CairoPointer cr, double x1, double y1, double x2, double y2, double x3, double y3);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_arc(CairoPointer cr, double xc, double yc, double radius, double angle1, double angle2);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_arc_negative(CairoPointer cr, double xc, double yc, double radius, double angle1, double angle2);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_rel_move_to(CairoPointer cr, double dx, double dy);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_rel_line_to(CairoPointer cr, double dx, double dy);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_rel_curve_to(CairoPointer cr, double dx1, double dy1, double dx2, double dy2, double dx3, double dy3);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_rectangle(CairoPointer cr, double x, double y, double width, double height); 
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_close_path(CairoPointer cr);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_path_extents(CairoPointer cr, out double x1, out double y1, out double x2, out double y2); 
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_paint(CairoPointer cr);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_paint_with_alpha(CairoPointer cr, double alpha);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_show_text(CairoPointer cr, string utf8);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_set_line_width(CairoPointer cr, double width);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_select_font_face(CairoPointer cr, string family, CairoFontSlant slant, CairoFontWeight weight);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_set_font_size(CairoPointer cr, double size);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_save(CairoPointer cr);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_restore(CairoPointer cr);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_reset_clip(CairoPointer cr);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_clip(CairoPointer cr);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_clip_preserve(CairoPointer cr);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_clip_extents(CairoPointer cr, out double x1, out double y1, out double x2, out double y2);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void cairo_fill_extents(CairoPointer cr, out double x1, out double y1, out double x2, out double y2);
    }
}