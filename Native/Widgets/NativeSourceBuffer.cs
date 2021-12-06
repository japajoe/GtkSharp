using System;
using System.Text;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeSourceBuffer
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferSetText(out GtkSourceBufferPointer buffer, string text, int length);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferDelete(out GtkSourceBufferPointer buffer, out GtkTextIterPointer iterStart, out GtkTextIterPointer iterEnd);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferGetText(out GtkSourceBufferPointer buffer, out GtkTextIterPointer iterStart, out GtkTextIterPointer iterEnd, bool includeHiddenChars, StringBuilder text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferGetTextLength(out GtkSourceBufferPointer buffer, out GtkTextIterPointer iterStart, out GtkTextIterPointer iterEnd, bool includeHiddenChars, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferGetBounds(out GtkSourceBufferPointer buffer, out GtkTextIterPointer iterStart, out GtkTextIterPointer iterEnd);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferGetCharCount(out GtkSourceBufferPointer buffer, out int count);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextIterFree(out GtkTextIterPointer textIter);

    }
}