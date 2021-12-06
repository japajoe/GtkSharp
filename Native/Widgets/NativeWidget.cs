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
        internal static extern void GtkSharpWidgetDestroy(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetUnparent(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetShow(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetHide(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetShowNow(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetShowAll(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetNoShowAll(out GtkWidgetPointer widget, bool noShowAll);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetNoShowAll(out GtkWidgetPointer widget, out bool noShowAll);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetMap(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetUnmap(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetRealize(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetUnrealize(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetDraw(out GtkWidgetPointer widget, out CairoPointer cr);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetQueueDraw(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetQueueDrawArea(out GtkWidgetPointer widget, int x, int y, int width, int height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetQueueDrawRegion(out GtkWidgetPointer widget, out CairoRegionPointer region);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetQueueResize(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetQueueResizeNoRedraw(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetFrameClock(out GtkWidgetPointer widget, out GdkFrameClockPointer frameclock);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSizeRequest(out GtkWidgetPointer widget, out GtkRequisition requisition);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSizeAllocate(out GtkWidgetPointer widget, out GtkAllocation allocation);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSizeAllocateWithBaseline(out GtkWidgetPointer widget, out GtkAllocation allocation, int baseline);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetRequestMode(out GtkWidgetPointer widget, out GtkSizeRequestMode mode);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPreferredWidth(out GtkWidgetPointer widget, out int minimumWidth, out int naturalWidth);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPreferredHeightForWidth(out GtkWidgetPointer widget, int width, out int minimumHeight, out int naturalHeight);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPreferredHeight(out GtkWidgetPointer widget, out int minimumHeight, out int naturalHeight);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPreferredWidthForHeight(out GtkWidgetPointer widget, int height, out int minimumWidth, out int naturalWidth);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPreferredHeightAndBaselineForWidth(out GtkWidgetPointer widget, int width, out int minimumHeight, out int naturalHeight, out int minimumBaseline, out int naturalBaseline);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPreferredSize(out GtkWidgetPointer widget, out GtkRequisition minimumSize, out GtkRequisition naturalSize);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetChildRequisition(out GtkWidgetPointer widget, out GtkRequisition requisition);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetAddAccelerator(out GtkWidgetPointer widget, string accelSignal, out GtkAccelGroupPointer accelGroup, uint accelKey, GdkModifierType accelMods, GtkAccelFlags accelFlags);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetRemoveAccelerator(out GtkWidgetPointer widget, out GtkAccelGroupPointer accelGroup, uint accelKey, GdkModifierType accelMods);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetAccelPath(out GtkWidgetPointer widget, string accelPath, out GtkAccelGroupPointer accelGroup);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetListAccelClosures(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetCanActivateAccel(out GtkWidgetPointer widget, uint signalId, out bool value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetMnemonicActivate(out GtkWidgetPointer widget, bool groupCycling);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetEvent(out GtkWidgetPointer widget, out GdkEventPointer evnt);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSendExpose(out GtkWidgetPointer widget, out GdkEventPointer evnt);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSendFocusChange(out GtkWidgetPointer widget, out GdkEventPointer evnt);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetActivate(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetReparent(out GtkWidgetPointer widget, out GtkWidgetPointer newParent);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetIntersect(out GtkWidgetPointer widget, out GdkRectangle area, out GdkRectangle intersection);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetRegionIntersect(out GtkWidgetPointer widget, out CairoRegionPointer region);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetFreezeChildNotify(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetChildNotify(out GtkWidgetPointer widget, string childProperty);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetThawChildNotify(out GtkWidgetPointer widget);    

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetCanFocus(out GtkWidgetPointer widget, bool canFocus);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetCanFocus(out GtkWidgetPointer widget, out bool canFocus);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetHasFocus(out GtkWidgetPointer widget, out bool hasFocus);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetIsFocus(out GtkWidgetPointer widget, out bool isFocus);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetHasVisibleFocus(out GtkWidgetPointer widget, out bool hasVisibleFocus);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGrabFocus(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetCanDefault(out GtkWidgetPointer widget, bool canDefault);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetCanDefault(out GtkWidgetPointer widget, out bool canDefault);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetHasDefault(out GtkWidgetPointer widget, out bool hasDefault);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGrabDefault(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetReceivesDefault(out GtkWidgetPointer widget, bool receivesDefault);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetReceivesDefault(out GtkWidgetPointer widget, out bool receivesDefault);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetHasGrab(out GtkWidgetPointer widget, out bool hasGrab);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetDeviceIsShadowed(out GtkWidgetPointer widget, out GdkDevicePointer device, out bool isShadowed);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetName(out GtkWidgetPointer widget, string name);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetName(out GtkWidgetPointer widget, StringBuilder name);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetNameLength(out GtkWidgetPointer widget, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetState(out GtkWidgetPointer widget, GtkStateType state);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetState(out GtkWidgetPointer widget, out GtkStateType state);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetStateFlags(out GtkWidgetPointer widget, GtkStateFlags flags, bool clear);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetUnsetStateFlags(out GtkWidgetPointer widget, GtkStateFlags flags);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetStateFlags(out GtkWidgetPointer widget, out GtkStateFlags flags);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetSensitive(out GtkWidgetPointer widget, bool sensitive);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetSensitive(out GtkWidgetPointer widget, out bool sensitive);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetIsSensitive(out GtkWidgetPointer widget, out bool isSensitive);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetVisible(out GtkWidgetPointer widget, bool visible);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetVisible(out GtkWidgetPointer widget, out bool visible);    

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetIsVisible(out GtkWidgetPointer widget, out bool isVisible);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetHasWindow(out GtkWidgetPointer widget, bool hasWindow);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetHasWindow(out GtkWidgetPointer widget, out bool hasWindow);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetIsToplevel(out GtkWidgetPointer widget, out bool isTopLevel);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetIsDrawable(out GtkWidgetPointer widget, out bool isDrawablel);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetRealized(out GtkWidgetPointer widget, bool realized);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetRealized(out GtkWidgetPointer widget, out bool realized);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetMapped(out GtkWidgetPointer widget, bool mapped);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetMapped(out GtkWidgetPointer widget, out bool mapped);    

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetAppPaintable(out GtkWidgetPointer widget, bool appPaintable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetAppPaintable(out GtkWidgetPointer widget, out bool appPaintable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetDoubleBuffered(out GtkWidgetPointer widget, bool doubleBuffered);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetDoubleBuffered(out GtkWidgetPointer widget, out bool doubleBuffered);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetRedrawOnAllocate(out GtkWidgetPointer widget, bool redrawOnAllocate);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetParent(out GtkWidgetPointer widget, out GtkWidgetPointer parent);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetParent(out GtkWidgetPointer widget, out GtkWidgetPointer parent);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetParentWindow(out GtkWidgetPointer widget, out GdkWindowPointer parentWindow);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetParentWindow(out GtkWidgetPointer widget, out GdkWindowPointer parentWindow);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetChildVisible(out GtkWidgetPointer widget, bool isVisible);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetChildVisible(out GtkWidgetPointer widget, out bool isVisible);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetWindow(out GtkWidgetPointer widget, out GdkWindowPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetWindow(out GtkWidgetPointer widget, out GdkWindowPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetRegisterWindow(out GtkWidgetPointer widget, out GdkWindowPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetUnregisterWindow(out GtkWidgetPointer widget, out GdkWindowPointer window);    

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetAllocatedWidth(out GtkWidgetPointer widget, out int width);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetAllocatedHeight(out GtkWidgetPointer widget, out int height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetAllocatedBaseline(out GtkWidgetPointer widget, out int baseline);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetAllocation(out GtkWidgetPointer widget, out GtkAllocation allocation);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetAllocation(out GtkWidgetPointer widget, out GtkAllocation allocation);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetClip(out GtkWidgetPointer widget, out GtkAllocation clip);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetClip(out GtkWidgetPointer widget, out GtkAllocation clip);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetRequisition(out GtkWidgetPointer widget, out GtkRequisition requisition);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetChildFocus(out GtkWidgetPointer widget, GtkDirectionType direction);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetKeynavFailed(out GtkWidgetPointer widget, GtkDirectionType direction);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetErrorBell(out GtkWidgetPointer widget);    

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetSizeRequest(out GtkWidgetPointer widget, int width, int height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetSizeRequest(out GtkWidgetPointer widget, out int width, out int height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetEvents(out GtkWidgetPointer widget, int events);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetAddEvents(out GtkWidgetPointer widget, int events);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetDeviceEvents(out GtkWidgetPointer widget, out GdkDevicePointer device, GdkEventMask events);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetAddDeviceEvents(out GtkWidgetPointer widget, out GdkDevicePointer device, GdkEventMask events);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetOpacity(out GtkWidgetPointer widget, double opacity);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetOpacity(out GtkWidgetPointer widget, out double opacity);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetDeviceEnabled(out GtkWidgetPointer widget, out GdkDevicePointer device, bool enabled);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetDeviceEnabled(out GtkWidgetPointer widget, out GdkDevicePointer device, out bool enabled);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetToplevel(out GtkWidgetPointer widget, out GtkWidgetPointer toplevel);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetAncestor(out GtkWidgetPointer widget, ulong widgetType, out GtkWidgetPointer ancestor);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetVisual(out GtkWidgetPointer widget, out GdkVisualPointer visual);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetVisual(out GtkWidgetPointer widget, out GdkVisualPointer visual);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetScreen(out GtkWidgetPointer widget, out GdkScreenPointer screen);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetHasScreen(out GtkWidgetPointer widget, out bool hasScreen);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetScaleFactor(out GtkWidgetPointer widget, out int factor);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetDisplay(out GtkWidgetPointer widget, out GdkDisplayPointer display);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetRootWindow(out GtkWidgetPointer widget, out GdkWindowPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetSettings(out GtkWidgetPointer widget, out GtkSettingsPointer settings);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetClipboard(out GtkWidgetPointer widget, out GdkAtomPointer selection, out GtkClipboardPointer clipboard);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetHexpand(out GtkWidgetPointer widget, out bool expand);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetHexpand(out GtkWidgetPointer widget, bool expand);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetHexpandSet(out GtkWidgetPointer widget, out bool expand);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetHexpandSet(out GtkWidgetPointer widget, bool expand);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetVexpand(out GtkWidgetPointer widget, out bool expand);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetVexpand(out GtkWidgetPointer widget, bool expand);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetVexpandSet(out GtkWidgetPointer widget, out bool expand);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetVexpandSet(out GtkWidgetPointer widget, bool expand);    

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetQueueComputeExpand(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetComputeExpand(out GtkWidgetPointer widget, GtkOrientation orientation, out bool value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetSupportMultidevice(out GtkWidgetPointer widget, out bool supportMultidevice);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetSupportMultidevice(out GtkWidgetPointer widget, bool supportMultidevice);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetClassSetAccessibleType(out GtkWidgetPointer widgetClass, ulong type);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetClassSetAccessibleRole(out GtkWidgetPointer widgetClass, AtkRole role);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetAccessible(out GtkWidgetPointer widget, out AtkObjectPointer atkObject);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetHalign(out GtkWidgetPointer widget, out GtkAlign align);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetHalign(out GtkWidgetPointer widget, GtkAlign align);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetValign(out GtkWidgetPointer widget, out GtkAlign align);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetValignWithBaseline(out GtkWidgetPointer widget, out GtkAlign align);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetValign(out GtkWidgetPointer widget, GtkAlign align);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetMarginLeft(out GtkWidgetPointer widget, out int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetMarginLeft(out GtkWidgetPointer widget, int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetMarginRight(out GtkWidgetPointer widget, out int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetMarginRight(out GtkWidgetPointer widget, int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetMarginStart(out GtkWidgetPointer widget, out int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetMarginStart(out GtkWidgetPointer widget, int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetMarginEnd(out GtkWidgetPointer widget, out int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetMarginEnd(out GtkWidgetPointer widget, int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetMarginTop(out GtkWidgetPointer widget, out int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetMarginTop(out GtkWidgetPointer widget, int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetMarginBottom(out GtkWidgetPointer widget, out int margin);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetMarginBottom(out GtkWidgetPointer widget, int margin);    

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetEvents(out GtkWidgetPointer widget, out int events);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetDeviceEvents(out GtkWidgetPointer widget, out GdkDevicePointer device, out GdkEventMask events);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPointer(out GtkWidgetPointer widget, out int x, out int y);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetIsAncestor(out GtkWidgetPointer widget, out GtkWidgetPointer ancestor, out bool isAncestor);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetTranslateCoordinates(out GtkWidgetPointer srcWidget, out GtkWidgetPointer destWidget, int srcX, int srcY, out int destX, out int destY);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetHideOnDelete(out GtkWidgetPointer widget, out bool hide);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetOverrideColor(out GtkWidgetPointer widget, GtkStateFlags state, ref GdkRGBA color);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetOverrideBackgroundColor(out GtkWidgetPointer widget, GtkStateFlags state, ref GdkRGBA color);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetOverrideFont(out GtkWidgetPointer widget, out PangoFontDescriptionPointer fontDesc);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetOverrideSymbolicColor(out GtkWidgetPointer widget, string name, ref GdkRGBA color);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetOverrideCursor(out GtkWidgetPointer widget, ref GdkRGBA cursor, ref GdkRGBA secondaryCursor);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetResetStyle(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetCreatePangoContext(out GtkWidgetPointer widget, out PangoContextPointer pangoContext);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPangoContext(out GtkWidgetPointer widget, out PangoContextPointer pangoContext);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetFontOptions(out GtkWidgetPointer widget, out CairoFontOptionsPointer cairoFontOptions);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetFontOptions(out GtkWidgetPointer widget, out CairoFontOptionsPointer cairoFontOptions);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetCreatePangoLayout(out GtkWidgetPointer widget, string text, out PangoLayoutPointer pangoLayout);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetRenderIconPixbuf(out GtkWidgetPointer widget, string stockId, GtkIconSize size, out GdkPixbufPointer pixbuf);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetCompositeName(out GtkWidgetPointer widget, string name);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetCompositeName(out GtkWidgetPointer widget, StringBuilder name);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetCompositeNameLength(out GtkWidgetPointer widget, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetPushCompositeChild();

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetPopCompositeChild();

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetStyleGetProperty(out GtkWidgetPointer widget, string propertyName, out GValuePointer value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetDirection(out GtkWidgetPointer widget, GtkTextDirection dir);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetDirection(out GtkWidgetPointer widget, out GtkTextDirection dir);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetDefaultDirection(GtkTextDirection dir);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetDefaultDirection(out GtkTextDirection dir);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetIsComposited(out GtkWidgetPointer widget, out bool isComposited);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetShapeCombineRegion(out GtkWidgetPointer widget, out CairoRegionPointer region);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetInputShapeCombineRegion(out GtkWidgetPointer widget, out CairoRegionPointer region);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetListMnemonicLabels(out GtkWidgetPointer widget, out GListPointer list);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetAddMnemonicLabel(out GtkWidgetPointer widget, out GtkWidgetPointer label);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetRemoveMnemonicLabel(out GtkWidgetPointer widget, out GtkWidgetPointer label);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetTooltipWindow(out GtkWidgetPointer widget, out GtkWindowPointer customWindow);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetTooltipWindow(out GtkWidgetPointer widget, out GtkWindowPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetTriggerTooltipQuery(out GtkWidgetPointer widget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetTooltipText(out GtkWidgetPointer widget, string text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetTooltipText(out GtkWidgetPointer widget, StringBuilder text);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetTooltipTextLength(out GtkWidgetPointer widget, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetTooltipMarkup(out GtkWidgetPointer widget, string markup);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetTooltipMarkup(out GtkWidgetPointer widget, StringBuilder markup);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetTooltipMarkupLength(out GtkWidgetPointer widget, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetSetHasTooltip(out GtkWidgetPointer widget, bool hasTooltip);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetHasTooltip(out GtkWidgetPointer widget, out bool hasTooltip);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetInDestruction(out GtkWidgetPointer widget, out bool inDestruction);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetStyleContext(out GtkWidgetPointer widget, out GtkStyleContextPointer styleContext);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetPath(out GtkWidgetPointer widget, out GtkWidgetPointer widgetPath);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetGetModifierMask(out GtkWidgetPointer widget, GdkModifierIntent intent, out GdkModifierType modifierType);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetInsertActionGroup(out GtkWidgetPointer widget, string name, out GActionGroupPointer group);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetAddTickCallback(out GtkWidgetPointer widget, GtkTickCallback callback, IntPtr userData, GDestroyNotify notify);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWidgetRemoveTickCallback(out GtkWidgetPointer widget, uint id);     
    }
}