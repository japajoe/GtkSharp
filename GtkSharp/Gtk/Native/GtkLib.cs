using System.Runtime.InteropServices;

namespace GtkSharp.Gtk.Native
{
    public static class GtkLib
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_init(int argc, string[] argv);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_main();

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_main_quit();
    }
}