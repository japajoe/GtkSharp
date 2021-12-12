using System.Runtime.InteropServices;
using GtkSharp.Native.Types;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeColorChooserDialog
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong gtk_color_chooser_dialog_get_type();

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GtkWidgetPointer gtk_color_chooser_dialog_new(string title, GtkWidgetPointer parentWindow);
    }
}