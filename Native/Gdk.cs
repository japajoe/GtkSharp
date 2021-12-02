using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Native
{
    internal static unsafe class Gdk
    {
        const string NATIVELIBNAME = "gtksharp";

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GdkSharpPixbufCreateFromFile(out IntPtr buffer, string filepath);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GdkSharpPixbufCreateFromData(out IntPtr buffer, byte* data, int width, int height, bool hasAlpha);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GdkSharpPixbufScaleSimple(out IntPtr buffer, int width, int height, GdkInterpolationType interpolationType);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GdkSharpPixbufGetColorspace(out IntPtr buffer, out GdkColorspace colorspace);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GdkSharpPixbufGetChannelCount(out IntPtr buffer, out int count);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GdkSharpPixbufGetBitsPerSample(out IntPtr buffer, out int bitsPerSample);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GdkSharpPixbufGetHasAlpha(out IntPtr buffer, out bool hasAlpha);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GdkSharpPixbufGetWidth(out IntPtr buffer, out int width);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GdkSharpPixbufGetHeight(out IntPtr buffer, out int height);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GdkSharpPixbufGetRowstride(out IntPtr buffer, out int stride);
    }
}
