using System;
using System.Text;
using System.Runtime.InteropServices;
using GtkSharp.Drawing;

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
        internal static extern void GtkSharpCallbackConnect(out IntPtr widget, string eventName, GtkCallback callback, out IntPtr userdata);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpTextBufferChangedCallbackConnect(out IntPtr buffer, GtkTextBufferChangedCallback callback);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSourceBufferChangedCallbackConnect(out IntPtr buffer, GtkSourceBufferChangedCallback callback);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferDeletedCallbackConnect(out IntPtr buffer, GtkEntryBufferDeletedCallback callback);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryBufferInsertedCallbackConnect(out IntPtr buffer, GtkEntryBufferInsertedCallback callback);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpDrawingAreaDrawCallbackConnect(out IntPtr widget, GtkDrawingAreaDrawCallback callback);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSpinButtonValueChangedCallbackConnect(out IntPtr widget, GtkSpinButtonValueChangedCallback callback);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpToggleButtonValueChangedCallbackConnect(out IntPtr widget, GtkToggleButtonValueChangedCallback callback);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNoteBookSelectedIndexChangedCallbackConnect(out IntPtr widget, GtkNoteBookSelectedIndexChangedCallback callback);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetShow(out IntPtr widget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetShowAll(out IntPtr widget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetSize(out IntPtr widget, ref int width, ref int height);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetCalculatePreferredSize(out IntPtr widget, ref int width, ref int height);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetFocus(out IntPtr widget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetDestroy(out IntPtr widget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetMargins(out IntPtr widget, double top, double left, double bottom, double right);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetQueueDraw(out IntPtr widget);

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
        internal static extern void GtkSharpButtonSetImage(out IntPtr widget, out IntPtr image);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpImageCreateFromIconName(out IntPtr widget, string iconName, GtkIconSize size);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpImageCreateFromFile(out IntPtr widget, string filepath);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpImageCreateFromPixbuf(out IntPtr widget, out IntPtr pixbuf);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpImageGetPixbuf(out IntPtr widget, out IntPtr pixbuf);

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

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSpinButtonCreate(out IntPtr widget, double value, double valueMin, double valueMax, double stepSize);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSpinButtonGetValue(out IntPtr widget, out double value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSpinButtonSetValue(out IntPtr widget, double value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpToggleButtonCreate(out IntPtr widget, bool value, string label);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpToggleButtonGetValue(out IntPtr widget, out bool value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpToggleButtonSetValue(out IntPtr widget, bool value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNoteBookCreate(out IntPtr widget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNoteBookAppend(out IntPtr widget, out IntPtr child, out IntPtr tabLabel);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNoteBookRemove(out IntPtr widget, int index);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNoteBookGetSelectedIndex(out IntPtr widget, out int index);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNoteBookSetSelectedIndex(out IntPtr widget, int index);
        
        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNoteBookGetPageCount(out IntPtr widget, out int count);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpDrawingAreaCreate(out IntPtr widget, int width, int height);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpMenuBarCreate(out IntPtr widget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpMenuCreate(out IntPtr widget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpMenuItemCreateWithlabel(out IntPtr widget, string label);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpMenuItemSetSubMenu(out IntPtr menuItem, out IntPtr menuWidget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpMenuShellAppend(out IntPtr menuBar, out IntPtr menuItem);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFileChooserDialogCreate(out IntPtr widget, out IntPtr parentWindow, string title, GtkFileChooserAction action, string firstButtonText, GtkResponseType firstButtonResponse, string secondButtonText, GtkResponseType secondButtonResponse);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFileChooserGetFileName(out IntPtr widget, StringBuilder text);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFileChooserGetFileNameLength(out IntPtr widget, out int length);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFileChooserGetOverwriteConfirmation(out IntPtr widget, out bool confirm);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFileChooserSetOverwriteConfirmation(out IntPtr widget, bool confirm);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFileChooserSetCurrentName(out IntPtr widget, string name);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpFileChooserSetFileName(out IntPtr widget, string name);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpColorChooserDialogCreate(out IntPtr widget, out IntPtr parentWindow, string title);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpColorChooserGetRGBA(out IntPtr widget, out GdkRGBA selectedColor);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpColorChooserSetRGBA(out IntPtr widget, GdkRGBA selectedColor);        

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpDialogRun(out IntPtr widget, out GtkResponseType response);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpSeparatorCreate(out IntPtr widget, GtkOrientation orientation);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarCreate(out IntPtr widget, double minValue, double maxValue);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarAddOffsetValue(out IntPtr widget, string name, double value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarGetValue(out IntPtr widget, out double value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarSetValue(out IntPtr widget, double value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarGetMinValue(out IntPtr widget, out double value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarSetMinValue(out IntPtr widget, double value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarGetMaxValue(out IntPtr widget, out double value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarSetMaxValue(out IntPtr widget, double value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarGetMode(out IntPtr widget, out GtkLevelBarMode mode);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpLevelBarSetMode(out IntPtr widget, GtkLevelBarMode mode);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarCreate(out IntPtr widget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarPulse(out IntPtr widget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarSetText(out IntPtr widget, string text);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarSetfraction(out IntPtr widget, double value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarSetPulseStep(out IntPtr widget, double value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarSetInverted(out IntPtr widget, bool inverted);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarGetText(out IntPtr widget, StringBuilder text);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarGetTextLength(out IntPtr widget, out int length);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarGetFraction(out IntPtr widget, out double value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarGetPulsestep(out IntPtr widget, out double value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarGetInverted(out IntPtr widget, out bool value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarSetEllipsize(out IntPtr widget, PangoEllipsizeMode mode);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarGetEllipsize(out IntPtr widget, out PangoEllipsizeMode mode);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarSetShowText(out IntPtr widget, bool show);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpProgressBarGetShowText(out IntPtr widget, out bool show);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoFill(out IntPtr cr);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoFillPreserve(out IntPtr cr);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoStroke(out IntPtr cr);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoStrokePreserve(out IntPtr cr);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoSetSourceRGB(out IntPtr cr, double r, double g, double b);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoSetSourceRGBA(out IntPtr cr, double r, double g, double b, double a);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoArc(out IntPtr cr, double xc, double yc, double radius, double angle1, double angle2);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoRectangle(out IntPtr cr, double x, double y, double width, double height);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoLineTo(out IntPtr cr, double x, double y);    

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoMoveTo(out IntPtr cr, double x, double y);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoShowText(out IntPtr cr, string text);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoSetLineWidth(out IntPtr cr, double width);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoRotate(out IntPtr cr, double angle);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoScale(out IntPtr cr, double sx, double sy);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoTranslate(out IntPtr cr, double tx, double ty);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoClosePath(out IntPtr cr);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoSelectFontFace(out IntPtr cr, string font, FontSlant slant, FontWeight weight);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoSetFontSize(out IntPtr cr, double size);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoSave(out IntPtr cr);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoRestore(out IntPtr cr);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoPaint(out IntPtr cr);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoPaintWithAlpha(out IntPtr cr, double alpha);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpCairoClip(out IntPtr cr);
    }
}