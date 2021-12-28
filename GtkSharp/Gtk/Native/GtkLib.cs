using System.Runtime.InteropServices;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Native
{
    public static class GtkLib
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_init(int argc, string[] argv);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_main();

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void gtk_main_quit();

        public static void Init(int argc, string[] argv)
        {
            gtk_init(argc, argv);

            //Workaround so GtkBuilder can properly instantiate this type
            GtkSharp.GLib.Native.GLibLib.g_type_ensure(NativeSourceView.gtk_source_view_get_type());
        }

        public static void Main()
        {
            gtk_main();
        }

        public static void MainQuit()
        {
            gtk_main_quit();
        }
    }
}