using System;
using System.Text;
using System.Runtime.InteropServices;
using GtkSharp.Drawing;

namespace GtkSharp.Native
{
    internal static class Gtk
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpInit(int argc, string[] argv);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpMain();

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpMainQuit();

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSignalConnect(out GtkWidgetPointer widget, string eventName, IntPtr callback, out IntPtr userdata);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSignalConnectAfter(out GtkWidgetPointer widget, string eventName, IntPtr callback, out IntPtr userdata);        

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCallbackConnect(out GtkWidgetPointer widget, string eventName, GtkCallback callback, out IntPtr userdata);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferChangedCallbackConnect(out IntPtr buffer, GtkTextBufferChangedCallback callback);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceBufferChangedCallbackConnect(out IntPtr buffer, GtkSourceBufferChangedCallback callback);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferDeletedCallbackConnect(out IntPtr buffer, GtkEntryBufferDeletedCallback callback);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferInsertedCallbackConnect(out IntPtr buffer, GtkEntryBufferInsertedCallback callback);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpDrawingAreaDrawCallbackConnect(out GtkWidgetPointer widget, GtkDrawingAreaDrawCallback callback);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSpinButtonValueChangedCallbackConnect(out GtkWidgetPointer widget, GtkSpinButtonValueChangedCallback callback);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpToggleButtonValueChangedCallbackConnect(out GtkWidgetPointer widget, GtkToggleButtonValueChangedCallback callback);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNoteBookSelectedIndexChangedCallbackConnect(out GtkWidgetPointer widget, GtkNoteBookSelectedIndexChangedCallback callback);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpContainerAdd(out GtkWidgetPointer widget, out IntPtr child);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpImageCreateFromIconName(out GtkWidgetPointer widget, string iconName, GtkIconSize size);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpImageCreateFromFile(out GtkWidgetPointer widget, string filepath);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpImageCreateFromPixbuf(out GtkWidgetPointer widget, out GdkPixbufPointer pixbuf);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpImageGetPixbuf(out GtkWidgetPointer widget, out GdkPixbufPointer pixbuf);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelCreate(out GtkWidgetPointer widget, string text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLabelSetText(out GtkWidgetPointer widget, string text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferGetLength(out IntPtr buffer, out uint length);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFixedCreate(out GtkWidgetPointer widget, int width, int height);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFixedAdd(out GtkWidgetPointer widget, out IntPtr child, int x, int y);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpPanedCreate(out GtkWidgetPointer widget, GtkOrientation orientation);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpPanedAdd(out GtkWidgetPointer widget, out IntPtr child, uint location, bool resize, bool shrink);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpPanedSetSeparatorPosition(out GtkWidgetPointer widget, int position);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpScrolledWindowCreate(out GtkWidgetPointer widget, out IntPtr horizontalAdjustment, out IntPtr verticalAdjustment, GtkPolicyType horizontalPolicy,  GtkPolicyType verticalPolicy);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpScrolledWindowAdd(out GtkWidgetPointer widget, out IntPtr child);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpScrolledWindowGetScrollPosition(out GtkWidgetPointer widget, out IntPtr horizontalAdjustment, out IntPtr verticalAdjustment, out double x, out double y);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSpinButtonCreate(out GtkWidgetPointer widget, double value, double valueMin, double valueMax, double stepSize);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSpinButtonGetValue(out GtkWidgetPointer widget, out double value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSpinButtonSetValue(out GtkWidgetPointer widget, double value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpToggleButtonCreate(out GtkWidgetPointer widget, bool value, string label);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpToggleButtonGetValue(out GtkWidgetPointer widget, out bool value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpToggleButtonSetValue(out GtkWidgetPointer widget, bool value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNoteBookCreate(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNoteBookAppend(out GtkWidgetPointer widget, out IntPtr child, out IntPtr tabLabel);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNoteBookRemove(out GtkWidgetPointer widget, int index);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNoteBookGetSelectedIndex(out GtkWidgetPointer widget, out int index);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNoteBookSetSelectedIndex(out GtkWidgetPointer widget, int index);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNoteBookGetPageCount(out GtkWidgetPointer widget, out int count);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpDrawingAreaCreate(out GtkWidgetPointer widget, int width, int height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpMenuBarCreate(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpMenuCreate(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpMenuItemCreateWithlabel(out GtkWidgetPointer widget, string label);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpMenuItemSetSubMenu(out IntPtr menuItem, out IntPtr menuWidget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpMenuShellAppend(out IntPtr menuBar, out IntPtr menuItem);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFileChooserDialogCreate(out GtkWidgetPointer widget, out GtkWidgetPointer parentWindow, string title, GtkFileChooserAction action, string firstButtonText, GtkResponseType firstButtonResponse, string secondButtonText, GtkResponseType secondButtonResponse);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFileChooserGetFileName(out GtkWidgetPointer widget, StringBuilder text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFileChooserGetFileNameLength(out GtkWidgetPointer widget, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFileChooserGetOverwriteConfirmation(out GtkWidgetPointer widget, out bool confirm);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFileChooserSetOverwriteConfirmation(out GtkWidgetPointer widget, bool confirm);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFileChooserSetCurrentName(out GtkWidgetPointer widget, string name);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFileChooserSetFileName(out GtkWidgetPointer widget, string name);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpColorChooserDialogCreate(out GtkWidgetPointer widget, out IntPtr parentWindow, string title);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpColorChooserGetRGBA(out GtkWidgetPointer widget, out GdkRGBA selectedColor);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpColorChooserSetRGBA(out GtkWidgetPointer widget, GdkRGBA selectedColor);        

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpDialogRun(out GtkWidgetPointer widget, out GtkResponseType response);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSeparatorCreate(out GtkWidgetPointer widget, GtkOrientation orientation);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoFill(out IntPtr cr);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoFillPreserve(out IntPtr cr);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoStroke(out IntPtr cr);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoStrokePreserve(out IntPtr cr);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoSetSourceRGB(out IntPtr cr, double r, double g, double b);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoSetSourceRGBA(out IntPtr cr, double r, double g, double b, double a);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoArc(out IntPtr cr, double xc, double yc, double radius, double angle1, double angle2);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoRectangle(out IntPtr cr, double x, double y, double width, double height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoLineTo(out IntPtr cr, double x, double y);    

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoMoveTo(out IntPtr cr, double x, double y);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoShowText(out IntPtr cr, string text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoSetLineWidth(out IntPtr cr, double width);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoRotate(out IntPtr cr, double angle);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoScale(out IntPtr cr, double sx, double sy);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoTranslate(out IntPtr cr, double tx, double ty);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoClosePath(out IntPtr cr);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoSelectFontFace(out IntPtr cr, string font, FontSlant slant, FontWeight weight);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoSetFontSize(out IntPtr cr, double size);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoSave(out IntPtr cr);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoRestore(out IntPtr cr);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoPaint(out IntPtr cr);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoPaintWithAlpha(out IntPtr cr, double alpha);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoClip(out IntPtr cr);
    }
}