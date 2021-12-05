using System;
using System.Text;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeWidget
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetType(out ulong type);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetDestroy(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetUnparent(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetShow(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetHide(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetShowNow(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetShowAll(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetNoShowAll(out IntPtr widget, bool noShowAll);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetNoShowAll(out IntPtr widget, out bool noShowAll);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetMap(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetUnmap(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetRealize(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetUnrealize(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetDraw(out IntPtr widget, out IntPtr cr);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetQueueDraw(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetQueueDrawArea(out IntPtr widget, int x, int y, int width, int height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetQueueDrawRegion(out IntPtr widget, out IntPtr region);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetQueueResize(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetQueueResizeNoRedraw(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetFrameClock(out IntPtr widget, out IntPtr frameclock);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSizeRequest(out IntPtr widget, out GtkRequisition requisition);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSizeAllocate(out IntPtr widget, out GtkAllocation allocation);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSizeAllocateWithBaseline(out IntPtr widget, out GtkAllocation allocation, int baseline);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetRequestMode(out IntPtr widget, out GtkSizeRequestMode mode);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPreferredWidth(out IntPtr widget, out int minimumWidth, out int naturalWidth);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPreferredHeightForWidth(out IntPtr widget, int width, out int minimumHeight, out int naturalHeight);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPreferredHeight(out IntPtr widget, out int minimumHeight, out int naturalHeight);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPreferredWidthForHeight(out IntPtr widget, int height, out int minimumWidth, out int naturalWidth);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPreferredHeightAndBaselineForWidth(out IntPtr widget, int width, out int minimumHeight, out int naturalHeight, out int minimumBaseline, out int naturalBaseline);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPreferredSize(out IntPtr widget, out GtkRequisition minimumSize, out GtkRequisition naturalSize);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetChildRequisition(out IntPtr widget, out GtkRequisition requisition);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetAddAccelerator(out IntPtr widget, string accelSignal, out IntPtr accelGroup, uint accelKey, GdkModifierType accelMods, GtkAccelFlags accelFlags);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetRemoveAccelerator(out IntPtr widget, out IntPtr accelGroup, uint accelKey, GdkModifierType accelMods);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetAccelPath(out IntPtr widget, string accelPath, out IntPtr accelGroup);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetListAccelClosures(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetCanActivateAccel(out IntPtr widget, uint signalId, out bool value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetMnemonicActivate(out IntPtr widget, bool groupCycling);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetEvent(out IntPtr widget, out IntPtr evnt);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSendExpose(out IntPtr widget, out IntPtr evnt);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSendFocusChange(out IntPtr widget, out IntPtr evnt);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetActivate(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetReparent(out IntPtr widget, out IntPtr newParent);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetIntersect(out IntPtr widget, out GdkRectangle area, out GdkRectangle intersection);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetRegionIntersect(out IntPtr widget, out IntPtr region);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetFreezeChildNotify(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetChildNotify(out IntPtr widget, string childProperty);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetThawChildNotify(out IntPtr widget);    

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetCanFocus(out IntPtr widget, bool canFocus);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetCanFocus(out IntPtr widget, out bool canFocus);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetHasFocus(out IntPtr widget, out bool hasFocus);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetIsFocus(out IntPtr widget, out bool isFocus);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetHasVisibleFocus(out IntPtr widget, out bool hasVisibleFocus);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGrabFocus(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetCanDefault(out IntPtr widget, bool canDefault);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetCanDefault(out IntPtr widget, out bool canDefault);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetHasDefault(out IntPtr widget, out bool hasDefault);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGrabDefault(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetReceivesDefault(out IntPtr widget, bool receivesDefault);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetReceivesDefault(out IntPtr widget, out bool receivesDefault);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetHasGrab(out IntPtr widget, out bool hasGrab);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetDeviceIsShadowed(out IntPtr widget, out IntPtr device, out bool isShadowed);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetName(out IntPtr widget, string name);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetName(out IntPtr widget, StringBuilder name);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetNameLength(out IntPtr widget, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetState(out IntPtr widget, GtkStateType state);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetState(out IntPtr widget, out GtkStateType state);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetStateFlags(out IntPtr widget, GtkStateFlags flags, bool clear);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetUnsetStateFlags(out IntPtr widget, GtkStateFlags flags);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetStateFlags(out IntPtr widget, out GtkStateFlags flags);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetSensitive(out IntPtr widget, bool sensitive);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetSensitive(out IntPtr widget, out bool sensitive);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetIsSensitive(out IntPtr widget, out bool isSensitive);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetVisible(out IntPtr widget, bool visible);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetVisible(out IntPtr widget, out bool visible);    

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetIsVisible(out IntPtr widget, out bool isVisible);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetHasWindow(out IntPtr widget, bool hasWindow);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetHasWindow(out IntPtr widget, out bool hasWindow);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetIsToplevel(out IntPtr widget, out bool isTopLevel);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetIsDrawable(out IntPtr widget, out bool isDrawablel);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetRealized(out IntPtr widget, bool realized);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetRealized(out IntPtr widget, out bool realized);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetMapped(out IntPtr widget, bool mapped);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetMapped(out IntPtr widget, out bool mapped);    

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetAppPaintable(out IntPtr widget, bool appPaintable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetAppPaintable(out IntPtr widget, out bool appPaintable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetDoubleBuffered(out IntPtr widget, bool doubleBuffered);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetDoubleBuffered(out IntPtr widget, out bool doubleBuffered);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetRedrawOnAllocate(out IntPtr widget, bool redrawOnAllocate);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetParent(out IntPtr widget, out IntPtr parent);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetParent(out IntPtr widget, out IntPtr parent);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetParentWindow(out IntPtr widget, out IntPtr parentWindow);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetParentWindow(out IntPtr widget, out IntPtr parentWindow);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetChildVisible(out IntPtr widget, bool isVisible);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetChildVisible(out IntPtr widget, out bool isVisible);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetWindow(out IntPtr widget, out IntPtr window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetWindow(out IntPtr widget, out IntPtr window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetRegisterWindow(out IntPtr widget, out IntPtr window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetUnregisterWindow(out IntPtr widget, out IntPtr window);    

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetAllocatedWidth(out IntPtr widget, out int width);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetAllocatedHeight(out IntPtr widget, out int height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetAllocatedBaseline(out IntPtr widget, out int baseline);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetAllocation(out IntPtr widget, out GtkAllocation allocation);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetAllocation(out IntPtr widget, out GtkAllocation allocation);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetClip(out IntPtr widget, out GtkAllocation clip);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetClip(out IntPtr widget, out GtkAllocation clip);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetRequisition(out IntPtr widget, out GtkRequisition requisition);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetChildFocus(out IntPtr widget, GtkDirectionType direction);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetKeynavFailed(out IntPtr widget, GtkDirectionType direction);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetErrorBell(out IntPtr widget);    

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetSizeRequest(out IntPtr widget, int width, int height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetSizeRequest(out IntPtr widget, out int width, out int height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetEvents(out IntPtr widget, int events);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetAddEvents(out IntPtr widget, int events);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetDeviceEvents(out IntPtr widget, out IntPtr device, GdkEventMask events);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetAddDeviceEvents(out IntPtr widget, out IntPtr device, GdkEventMask events);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetOpacity(out IntPtr widget, double opacity);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetOpacity(out IntPtr widget, out double opacity);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetDeviceEnabled(out IntPtr widget, out IntPtr device, bool enabled);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetDeviceEnabled(out IntPtr widget, out IntPtr device, out bool enabled);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetToplevel(out IntPtr widget, out IntPtr toplevel);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetAncestor(out IntPtr widget, ulong widgetType, out IntPtr ancestor);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetVisual(out IntPtr widget, out IntPtr visual);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetVisual(out IntPtr widget, out IntPtr visual);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetScreen(out IntPtr widget, out IntPtr screen);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetHasScreen(out IntPtr widget, out bool hasScreen);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetScaleFactor(out IntPtr widget, out int factor);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetDisplay(out IntPtr widget, out IntPtr display);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetRootWindow(out IntPtr widget, out IntPtr window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetSettings(out IntPtr widget, out IntPtr settings);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetClipboard(out IntPtr widget, out IntPtr selection, out IntPtr clipboard);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetHexpand(out IntPtr widget, out bool expand);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetHexpand(out IntPtr widget, bool expand);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetHexpandSet(out IntPtr widget, out bool expand);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetHexpandSet(out IntPtr widget, bool expand);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetVexpand(out IntPtr widget, out bool expand);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetVexpand(out IntPtr widget, bool expand);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetVexpandSet(out IntPtr widget, out bool expand);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetVexpandSet(out IntPtr widget, bool expand);    

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetQueueComputeExpand(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetComputeExpand(out IntPtr widget, GtkOrientation orientation, out bool value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetSupportMultidevice(out IntPtr widget, out bool supportMultidevice);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetSupportMultidevice(out IntPtr widget, bool supportMultidevice);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetClassSetAccessibleType(out IntPtr widgetClass, ulong type);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetClassSetAccessibleRole(out IntPtr widgetClass, AtkRole role);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetAccessible(out IntPtr widget, out IntPtr atkObject);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetHalign(out IntPtr widget, out GtkAlign align);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetHalign(out IntPtr widget, GtkAlign align);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetValign(out IntPtr widget, out GtkAlign align);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetValignWithBaseline(out IntPtr widget, out GtkAlign align);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetValign(out IntPtr widget, GtkAlign align);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetMarginLeft(out IntPtr widget, out int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetMarginLeft(out IntPtr widget, int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetMarginRight(out IntPtr widget, out int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetMarginRight(out IntPtr widget, int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetMarginStart(out IntPtr widget, out int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetMarginStart(out IntPtr widget, int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetMarginEnd(out IntPtr widget, out int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetMarginEnd(out IntPtr widget, int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetMarginTop(out IntPtr widget, out int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetMarginTop(out IntPtr widget, int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetMarginBottom(out IntPtr widget, out int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetMarginBottom(out IntPtr widget, int margin);    

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetEvents(out IntPtr widget, out int events);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetDeviceEvents(out IntPtr widget, out IntPtr device, out GdkEventMask events);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPointer(out IntPtr widget, out int x, out int y);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetIsAncestor(out IntPtr widget, out IntPtr ancestor, out bool isAncestor);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetTranslateCoordinates(out IntPtr srcWidget, out IntPtr destWidget, int srcX, int srcY, out int destX, out int destY);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetHideOnDelete(out IntPtr widget, out bool hide);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetOverrideColor(out IntPtr widget, GtkStateFlags state, ref GdkRGBA color);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetOverrideBackgroundColor(out IntPtr widget, GtkStateFlags state, ref GdkRGBA color);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetOverrideFont(out IntPtr widget, out IntPtr fontDesc);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetOverrideSymbolicColor(out IntPtr widget, string name, ref GdkRGBA color);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetOverrideCursor(out IntPtr widget, ref GdkRGBA cursor, ref GdkRGBA secondaryCursor);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetResetStyle(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetCreatePangoContext(out IntPtr widget, out IntPtr pangoContext);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPangoContext(out IntPtr widget, out IntPtr pangoContext);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetFontOptions(out IntPtr widget, out IntPtr cairoFontOptions);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetFontOptions(out IntPtr widget, out IntPtr cairoFontOptions);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetCreatePangoLayout(out IntPtr widget, string text, out IntPtr pangoLayout);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetRenderIconPixbuf(out IntPtr widget, string stockId, GtkIconSize size, out IntPtr pixbuf);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetCompositeName(out IntPtr widget, string name);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetCompositeName(out IntPtr widget, StringBuilder name);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetCompositeNameLength(out IntPtr widget, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetPushCompositeChild();

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetPopCompositeChild();

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetStyleGetProperty(out IntPtr widget, string propertyName, out IntPtr value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetDirection(out IntPtr widget, GtkTextDirection dir);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetDirection(out IntPtr widget, out GtkTextDirection dir);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetDefaultDirection(GtkTextDirection dir);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetDefaultDirection(out GtkTextDirection dir);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetIsComposited(out IntPtr widget, out bool isComposited);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetShapeCombineRegion(out IntPtr widget, out IntPtr region);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetInputShapeCombineRegion(out IntPtr widget, out IntPtr region);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetListMnemonicLabels(out IntPtr widget, out IntPtr list);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetAddMnemonicLabel(out IntPtr widget, out IntPtr label);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetRemoveMnemonicLabel(out IntPtr widget, out IntPtr label);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetTooltipWindow(out IntPtr widget, out IntPtr customWindow);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetTooltipWindow(out IntPtr widget, out IntPtr window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetTriggerTooltipQuery(out IntPtr widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetTooltipText(out IntPtr widget, string text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetTooltipText(out IntPtr widget, StringBuilder text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetTooltipTextLength(out IntPtr widget, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetTooltipMarkup(out IntPtr widget, string markup);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetTooltipMarkup(out IntPtr widget, StringBuilder markup);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetTooltipMarkupLength(out IntPtr widget, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetHasTooltip(out IntPtr widget, bool hasTooltip);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetHasTooltip(out IntPtr widget, out bool hasTooltip);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetInDestruction(out IntPtr widget, out bool inDestruction);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetStyleContext(out IntPtr widget, out IntPtr styleContext);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPath(out IntPtr widget, out IntPtr widgetPath);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetModifierMask(out IntPtr widget, GdkModifierIntent intent, out GdkModifierType modifierType);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetInsertActionGroup(out IntPtr widget, string name, out IntPtr group);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetAddTickCallback(out IntPtr widget, GtkTickCallback callback, IntPtr userData, GDestroyNotify notify);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetRemoveTickCallback(out IntPtr widget, uint id);     
    }
}