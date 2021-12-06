using System;
using System.Text;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeEntry
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetType(out ulong type);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryCreate(out GtkWidgetPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryCreateWithBuffer(out GtkWidgetPointer entry, out GtkEntryBufferPointer buffer);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetBuffer(out GtkWidgetPointer entry, out GtkEntryBufferPointer buffer);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetBuffer(out GtkWidgetPointer entry, out GtkEntryBufferPointer buffer);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetTextArea(out GtkWidgetPointer entry, out GdkRectangle textArea);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetVisibility(out GtkWidgetPointer entry, bool visible);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetVisibility(out GtkWidgetPointer entry, out bool visible);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetInvisibleChar(out GtkWidgetPointer entry, UInt32 ch);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetInvisibleChar(out GtkWidgetPointer entry, out UInt32 ch);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryUnsetInvisibleChar(out GtkWidgetPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetHasFrame(out GtkWidgetPointer entry, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetHasFrame(out GtkWidgetPointer entry, out bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetInnerBorder(out GtkWidgetPointer entry, ref GtkBorder border);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetInnerBorder(out GtkWidgetPointer entry, out GtkBorder border);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetOverwriteMode(out GtkWidgetPointer entry, bool overwrite);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetOverwriteMode(out GtkWidgetPointer entry, out bool overwrite);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetMaxLength(out GtkWidgetPointer entry, int max);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetMaxLength(out GtkWidgetPointer entry, out int max);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetActivatesDefault(out GtkWidgetPointer entry, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetActivatesDefault(out GtkWidgetPointer entry, out bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetWidthChars(out GtkWidgetPointer entry, int numChars);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetWidthChars(out GtkWidgetPointer entry, out int numChars);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetMaxWidthChars(out GtkWidgetPointer entry, int numChars);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetMaxWidthChars(out GtkWidgetPointer entry, out int numChars);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetText(out GtkWidgetPointer entry, string text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetText(out GtkWidgetPointer entry, StringBuilder text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetTextLength(out GtkWidgetPointer entry, out UInt16 length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetLayout(out GtkWidgetPointer entry, out PangoLayoutPointer pangoLayout);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetLayoutOffsets(out GtkWidgetPointer entry, out int x, out int y);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetAlignment(out GtkWidgetPointer entry, float xalign);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetAlignment(out GtkWidgetPointer entry, out float xalign);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetCompletion(out GtkWidgetPointer entry, out GtkEntryCompletionPointer completion);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetCompletion(out GtkWidgetPointer entry, out GtkEntryCompletionPointer completion);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryLayoutIndexToTextIndex(out GtkWidgetPointer entry, int layoutIndex, out int textIndex);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryTextIndexToLayoutIndex(out GtkWidgetPointer entry, int textIndex, out int layoutIndex);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetCursorHadjustment(out GtkWidgetPointer entry, out GtkAdjustmentPointer adjustment);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetCursorHadjustment(out GtkWidgetPointer entry, out GtkAdjustmentPointer adjustment);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetProgressFraction(out GtkWidgetPointer entry, double fraction);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetProgressFraction(out GtkWidgetPointer entry, out double fraction);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetProgressPulseStep(out GtkWidgetPointer entry, double fraction);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetProgressPulseStep(out GtkWidgetPointer entry, out double fraction);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryProgressPulse(out GtkWidgetPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetPlaceholderText(out GtkWidgetPointer entry, StringBuilder text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetPlaceholderTextLength(out GtkWidgetPointer entry, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetPlaceholderText(out GtkWidgetPointer entry, string text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetIconFromPixbuf(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, out GdkPixbufPointer pixbuf);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetIconFromStock(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, string stockId);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetIconFromIconName(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, string iconName);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetIconFromGicon(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, out GIconPointer icon);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetIconStorageType(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, out GtkImageType imageType);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetIconPixbuf(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, out GdkPixbufPointer pixbuf);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetIconStock(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, StringBuilder text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetIconStockLength(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetIconName(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, StringBuilder text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetIconNameLength(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetIconGicon(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, out GIconPointer icon);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetIconActivatable(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, bool activatable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetIconActivatable(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, out bool activatable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetIconSensitive(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, bool sensitive);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetIconSensitive(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, out bool sensitive);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetIconAtPos(out GtkWidgetPointer entry, int x, int y, out int icon);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetIconTooltipText(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, string tooltip);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetIconTooltipText(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, StringBuilder tooltip);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetIconTooltipTextLength(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetIconTooltipMarkup(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, string tooltip);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetIconTooltipMarkup(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, StringBuilder tooltip);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetIconTooltipMarkupLength(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetIconDragSource(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, out GtkTargetListPointer targetList, GdkDragAction actions);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetCurrentIconDragSource(out GtkWidgetPointer entry, out int dragSource);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetIconArea(out GtkWidgetPointer entry, GtkEntryIconPosition iconPos, out GdkRectangle iconArea);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryImContextFilterKeypress(out GtkWidgetPointer entry, out GdkEventKeyPointer evnt, out bool keypress);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryResetImContext(out GtkWidgetPointer entry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetInputPurpose(out GtkWidgetPointer entry, GtkInputPurpose purpose);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetInputPurpose(out GtkWidgetPointer entry, out GtkInputPurpose purpose);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetInputHints(out GtkWidgetPointer entry, GtkInputHints hints);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetInputHints(out GtkWidgetPointer entry, out GtkInputHints hints);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetAttributes(out GtkWidgetPointer entry, PangoAttrListPointer attrs);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetAttributes(out GtkWidgetPointer entry, PangoAttrListPointer attrs);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntrySetTabs(out GtkWidgetPointer entry, out PangoTabArrayPointer tabs);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGetTabs(out GtkWidgetPointer entry, out PangoTabArrayPointer tabs);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpEntryGrabFocusWithoutSelecting(out GtkWidgetPointer entry);        
    }
}