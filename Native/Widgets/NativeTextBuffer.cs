using System;
using System.Text;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeTextBuffer
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferCreate(out GtkTextBufferPointer buffer, out GtkTextTagTablePointer table);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferSetText(out GtkTextBufferPointer buffer, string text, int length);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferDelete(out GtkTextBufferPointer buffer, out GtkTextIterPointer iterStart, out GtkTextIterPointer iterEnd);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferGetText(out GtkTextBufferPointer buffer, out GtkTextIterPointer iterStart, out GtkTextIterPointer iterEnd, bool includeHiddenChars, StringBuilder text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferGetTextLength(out GtkTextBufferPointer buffer, out GtkTextIterPointer iterStart, out GtkTextIterPointer iterEnd, bool includeHiddenChars, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferGetBounds(out GtkTextBufferPointer buffer, out GtkTextIterPointer iterStart, out GtkTextIterPointer iterEnd);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferGetCharCount(out GtkTextBufferPointer buffer, out int count);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextIterFree(out GtkTextIterPointer textIter);

    }
}