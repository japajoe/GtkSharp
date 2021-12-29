using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Pango.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    public static class NativeProgressBar
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gtk_progress_bar_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gtk_progress_bar_new(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_progress_bar_pulse(GObjectPointer pbar);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_progress_bar_set_text(GObjectPointer pbar, string text);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_progress_bar_set_fraction(GObjectPointer pbar, double fraction); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_progress_bar_set_pulse_step(GObjectPointer pbar, double fraction);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_progress_bar_set_inverted(GObjectPointer pbar, bool inverted); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern string gtk_progress_bar_get_text(GObjectPointer pbar);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double gtk_progress_bar_get_fraction(GObjectPointer pbar);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double gtk_progress_bar_get_pulse_step(GObjectPointer pbar); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_progress_bar_get_inverted(GObjectPointer pbar);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_progress_bar_set_ellipsize(GObjectPointer pbar, PangoEllipsizeMode mode);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern PangoEllipsizeMode gtk_progress_bar_get_ellipsize(GObjectPointer pbar); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_progress_bar_set_show_text(GObjectPointer pbar, bool show_text);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_progress_bar_get_show_text(GObjectPointer pbar);
    }
}