using System;

namespace GtkSharp.Native
{
    internal delegate void GtkCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkTextBufferChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkSourceBufferChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkEntryBufferDeletedCallback(IntPtr textbuffer, uint position, uint n_chars, IntPtr data);
    internal delegate void GtkEntryBufferInsertedCallback(IntPtr textbuffer, uint position, IntPtr chars, uint n_chars, IntPtr data);

    
}