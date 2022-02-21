using System.Runtime.InteropServices;

namespace GtkSharp.Gdk.Native
{
    public static class GdkLib
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]        
        public static extern string gdk_get_program_class();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_set_program_class(string program_class);
    }
}