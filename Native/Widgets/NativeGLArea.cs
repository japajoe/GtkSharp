using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeGLArea
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaGetType(out ulong type);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaCreate(out GtkWidgetPointer area);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaSetRequiredVersion(out GtkWidgetPointer area, int major, int minor);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaGetRequiredVersion(out GtkWidgetPointer area, out int major, out int minor);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaGetHasAlpha(out GtkWidgetPointer area, out bool hasAlpha);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaSetHasAlpha(out GtkWidgetPointer area, bool hasAlpha);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaGetHasDepthBuffer(out GtkWidgetPointer area, out bool hasDepthBuffer);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaSetHasDepthBuffer(out GtkWidgetPointer area, bool hasDepthBuffer);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaGetHasStencilBuffer(out GtkWidgetPointer area, out bool hasStencilBuffer);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaSetHasStencilBuffer(out GtkWidgetPointer area, bool hasStencilBuffer);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaGetAutoRender(out GtkWidgetPointer area, out bool autoRender);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaSetAutoRender(out GtkWidgetPointer area, bool autoRender);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaQueueRender(out GtkWidgetPointer area);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaGetContext(out GtkWidgetPointer area, out GdkGLContextPointer context);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaMakeCurrent(out GtkWidgetPointer area);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaAttachBuffers(out GtkWidgetPointer area);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaSetError(out GtkWidgetPointer area, out GErrorPointer error);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpGLAreaGetError(out GtkWidgetPointer area, out GErrorPointer error);        
    }
}
