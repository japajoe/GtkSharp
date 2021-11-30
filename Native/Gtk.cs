using System;
using System.Text;
using System.Runtime.InteropServices;

namespace GtkSharp.Native
{
    internal static class Gtk
    {
        const string NATIVELIBNAME = "gtksharp";

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpInit(int argc, string[] argv);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpMain();

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpMainQuit();

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSignalConnect(out IntPtr widget, string eventName, GtkCallback callback);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetShow(out IntPtr widget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetSize(out IntPtr widget, ref int width, ref int height);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetCalculatePreferredSize(out IntPtr widget, ref int width, ref int height);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetFocus(out IntPtr widget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetDestroy(out IntPtr widget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowCreate(out IntPtr widget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowAdd(out IntPtr widget, out IntPtr child);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetStyleSheet(out IntPtr widget, string path);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetTitle(out IntPtr widget, string title);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxCreate(out IntPtr widget, GtkOrientation orientation, int spacing, bool homogeneous);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpBoxAdd(out IntPtr widget, out IntPtr child, bool expand, bool fill, uint padding);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonCreate(out IntPtr widget, string text);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpButtonSetText(out IntPtr widget, string text);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelCreate(out IntPtr widget, string text);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetText(out IntPtr widget, string text);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextEntryCreate(out IntPtr widget, out IntPtr buffer);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextEntrySetText(out IntPtr widget, out IntPtr buffer, string text);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextEntryGetText(out IntPtr widget, out IntPtr buffer, StringBuilder text);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextEntryClearText(out IntPtr widget, out IntPtr buffer);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferGetLength(out IntPtr buffer, out uint length);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewCreate(out IntPtr widget, out IntPtr buffer);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewSetText(out IntPtr widget, out IntPtr buffer, string text);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewGetText(out IntPtr widget, out IntPtr buffer, StringBuilder text);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextViewClearText(out IntPtr widget, out IntPtr buffer);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferGetLength(out IntPtr buffer, out uint length);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewCreate(out IntPtr widget, out IntPtr buffer, string language);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewSetText(out IntPtr widget, out IntPtr buffer, string text);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewGetText(out IntPtr widget, out IntPtr buffer, StringBuilder text);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewClearText(out IntPtr widget, out IntPtr buffer);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceViewToggleLineNumbers(out IntPtr widget, bool visible);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceBufferGetLength(out IntPtr buffer, out uint length);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFixedCreate(out IntPtr widget, int width, int height);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFixedAdd(out IntPtr widget, out IntPtr child, int x, int y);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpPanedCreate(out IntPtr widget, GtkOrientation orientation);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpPanedAdd(out IntPtr widget, out IntPtr child, uint location, bool resize, bool shrink);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpPanedSetSeparatorPosition(out IntPtr widget, int position);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpScrolledWindowCreate(out IntPtr widget, out IntPtr horizontalAdjustment, out IntPtr verticalAdjustment, GtkPolicyType horizontalPolicy,  GtkPolicyType verticalPolicy);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpScrolledWindowAdd(out IntPtr widget, out IntPtr child);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpScrolledWindowGetScrollPosition(out IntPtr widget, out IntPtr horizontalAdjustment, out IntPtr verticalAdjustment, out double x, out double y);
    }
}
