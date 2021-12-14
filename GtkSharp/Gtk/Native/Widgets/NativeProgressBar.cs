using System.Runtime.InteropServices;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Pango.Types;

namespace GtkSharp.Gtk.Native.Widgets
{
    internal static class NativeProgressBar
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_progress_bar_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_progress_bar_new(); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_progress_bar_pulse(GtkWidgetPointer pbar);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_progress_bar_set_text(GtkWidgetPointer pbar, string text);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_progress_bar_set_fraction(GtkWidgetPointer pbar, double fraction); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_progress_bar_set_pulse_step(GtkWidgetPointer pbar, double fraction);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_progress_bar_set_inverted(GtkWidgetPointer pbar, bool inverted); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string gtk_progress_bar_get_text(GtkWidgetPointer pbar);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern double gtk_progress_bar_get_fraction(GtkWidgetPointer pbar);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern double gtk_progress_bar_get_pulse_step(GtkWidgetPointer pbar); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_progress_bar_get_inverted(GtkWidgetPointer pbar);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_progress_bar_set_ellipsize(GtkWidgetPointer pbar, PangoEllipsizeMode mode);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern PangoEllipsizeMode gtk_progress_bar_get_ellipsize(GtkWidgetPointer pbar); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_progress_bar_set_show_text(GtkWidgetPointer pbar, bool show_text);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool gtk_progress_bar_get_show_text(GtkWidgetPointer pbar);
    }
}