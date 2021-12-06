using System;
using System.Text;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeEntryBuffer
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferGetType(out ulong type);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferNew(out GtkEntryBufferPointer buffer, string initialChars, int numInitialChars);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferGetBytes(out GtkEntryBufferPointer buffer, out ulong size);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferGetLength(out GtkEntryBufferPointer buffer, out uint length);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferGetText(out GtkEntryBufferPointer buffer, StringBuilder text);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferGetTextLength(out GtkEntryBufferPointer buffer, out int length);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferSetText(out GtkEntryBufferPointer buffer, string chars, int numChars);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferSetMaxLength(out GtkEntryBufferPointer buffer, int maxLength);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferGetMaxLength(out GtkEntryBufferPointer buffer, out int maxLength);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferInsertText(out GtkEntryBufferPointer buffer, uint position, string chars, int numChars, out uint newPosition);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferDeleteText(out GtkEntryBufferPointer buffer, uint position, int numChars, out uint newPosition);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferEmitInsertedText(out GtkEntryBufferPointer buffer, uint position, string chars, uint numChars);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferEmitDeletedText(out GtkEntryBufferPointer buffer, uint position, uint numChars);        
    }
}