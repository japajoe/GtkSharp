using System;

namespace GtkSharp.Native
{
    internal delegate void GtkCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkTextBufferChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkSourceBufferChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkEntryBufferDeletedCallback(IntPtr textbuffer, uint position, uint n_chars, IntPtr data);
    internal delegate void GtkEntryBufferInsertedCallback(IntPtr textbuffer, uint position, IntPtr chars, uint n_chars, IntPtr data);
    internal delegate bool GtkDrawingAreaDrawCallback(IntPtr widget, IntPtr cr, IntPtr data);
    internal delegate void GtkSpinButtonValueChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkToggleButtonValueChangedCallback(IntPtr widget, IntPtr data);
    internal delegate void GtkNoteBookSelectedIndexChangedCallback(IntPtr notebook, IntPtr page, uint page_num, IntPtr data);
    internal delegate void GDestroyNotify(IntPtr data);
    internal delegate bool GtkTickCallback(IntPtr widget, IntPtr frame_clock,  IntPtr user_data);
    internal delegate void GtkGLAreaRealizeCallback(IntPtr area);
    internal delegate void GtkGLAreaUnRealizeCallback(IntPtr area);
    internal delegate bool GtkGLAreaRenderCallback(IntPtr area, IntPtr context);
    internal delegate void GtkWindowSizeAllocateCallback(IntPtr widget, IntPtr allocation);
}
