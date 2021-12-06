using System;
using System.Text;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeTextBuffer
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferSetText(out IntPtr buffer, string text, int length);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferDelete(out IntPtr buffer, out IntPtr iterStart, out IntPtr iterEnd);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferGetText(out IntPtr buffer, out IntPtr iterStart, out IntPtr iterEnd, bool includeHiddenChars, StringBuilder text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferGetTextLength(out IntPtr buffer, out IntPtr iterStart, out IntPtr iterEnd, bool includeHiddenChars, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferGetBounds(out IntPtr buffer, out IntPtr iterStart, out IntPtr iterEnd);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferGetCharCount(out IntPtr buffer, out int count);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextIterFree(out IntPtr textIter);

    }
}