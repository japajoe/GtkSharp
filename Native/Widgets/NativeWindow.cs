using System;
using System.Text;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeWindow
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetType(out uint type);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowCreate(out GtkWidgetPointer window, GtkWindowType type);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetTitle(out GtkWidgetPointer window, string title);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetTitle(out GtkWidgetPointer window, StringBuilder title);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetTitleLength(out GtkWidgetPointer window, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetWmclass(out GtkWidgetPointer window, string wmclassName, string wmclassClass);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetRole(out GtkWidgetPointer window, string role);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetStartupId(out GtkWidgetPointer window, string startupId);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetRole(out GtkWidgetPointer window, StringBuilder role);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetRoleLength(out GtkWidgetPointer window, out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowAddAccelGroup(out GtkWidgetPointer window, out GtkAccelGroupPointer accelGroup);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowRemoveAccelGroup(out GtkWidgetPointer window, out GtkAccelGroupPointer accelGroup);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetPosition(out GtkWidgetPointer window, GtkWindowPosition position);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowActivateFocus(out GtkWidgetPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetFocus(out GtkWidgetPointer window, out GtkWidgetPointer focus);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetFocus(out GtkWidgetPointer window, out GtkWidgetPointer focus);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDefault(out GtkWidgetPointer window, out GtkWidgetPointer defaultWidget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetDefaultWidget(out GtkWidgetPointer window, out GtkWidgetPointer defaultWidget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowActivateDefault(out GtkWidgetPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetTransientFor(out GtkWidgetPointer window, out GtkWidgetPointer parent);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetTransientFor(out GtkWidgetPointer window, out GtkWidgetPointer parent);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetAttachedTo(out GtkWidgetPointer window, out GtkWidgetPointer attachWidget);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetAttachedTo(out GtkWidgetPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetOpacity(out GtkWidgetPointer window, double opacity);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetOpacity(out GtkWidgetPointer window, out double opacity);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetTypeHint(out GtkWidgetPointer window, GdkWindowTypeHint hint);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetTypeHint(out GtkWidgetPointer window, out GdkWindowTypeHint hint);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetSkipTaskbarHint(out GtkWidgetPointer window, bool hint);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetSkipTaskbarHint(out GtkWidgetPointer window, out bool hint);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetSkipPagerHint(out GtkWidgetPointer window, bool hint);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetSkipPagerHint(out GtkWidgetPointer window, out bool hint);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetUrgencyHint(out GtkWidgetPointer window, bool hint);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetUrgencyHint(out GtkWidgetPointer window, out bool hint);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetAcceptFocus(out GtkWidgetPointer window, bool accept);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetAcceptFocus(out GtkWidgetPointer window, out bool accept);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetFocusOnMap(out GtkWidgetPointer window, bool focus);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetFocusOnMap(out GtkWidgetPointer window, out bool focus);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDestroyWithParent(out GtkWidgetPointer window, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetDestroyWithParent(out GtkWidgetPointer window, out bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetHideTitlebarWhenMaximized(out GtkWidgetPointer window, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetHideTitlebarWhenMaximized(out GtkWidgetPointer window, out bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetMnemonicsVisible(out GtkWidgetPointer window, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetMnemonicsVisible(out GtkWidgetPointer window, out bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetFocusVisible(out GtkWidgetPointer window, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetFocusVisible(out GtkWidgetPointer window, out bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetResizable(out GtkWidgetPointer window, bool resizable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetResizable(out GtkWidgetPointer window, out bool resizable);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetGravity(out GtkWidgetPointer window, GdkGravity gravity);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetGravity(out GtkWidgetPointer window, out GdkGravity gravity);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetGeometryHints(out GtkWidgetPointer window, out GtkWidgetPointer geometryWidget, out GdkGeometryPointer geometry, GdkWindowHints geomMask);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetScreen(out GtkWidgetPointer window, out GdkScreenPointer screen);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetScreen(out GtkWidgetPointer window, out GdkScreenPointer screen);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowIsActive(out GtkWidgetPointer window, out bool isActive);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowHasToplevelFocus(out GtkWidgetPointer window, out bool hasToplevelFocus);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDecorated(out GtkWidgetPointer window, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetDecorated(out GtkWidgetPointer window, out bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDeletable(out GtkWidgetPointer window, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetDeletable(out GtkWidgetPointer window, out bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetIconList(out GtkWidgetPointer window, out GListPointer list);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetIconList(out GtkWidgetPointer window, out GListPointer list);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetIcon(out GtkWidgetPointer window, out GdkPixbufPointer icon);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetIconName(out GtkWidgetPointer window, string name);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetIconFromFile(out GtkWidgetPointer window, string filename, out GErrorPointer error);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetIcon(out GtkWidgetPointer window, out GdkPixbufPointer icon);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetIconName(out GtkWidgetPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDefaultIconList(out GListPointer list);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetDefaultIconList();

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDefaultIcon(out GdkPixbufPointer icon);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDefaultIconName(string name);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetDefaultIconName(StringBuilder name);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetDefaultIconNameLength(out int length);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDefaultIconFromFile(string filename, out GErrorPointer error);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetAutoStartupNotification(bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetModal(out GtkWidgetPointer window, bool modal);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetModal(out GtkWidgetPointer window, out bool modal);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowListToplevels(out GListPointer list);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetHasUserRefCount(out GtkWidgetPointer window, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowAddMnemonic(out GtkWidgetPointer window, uint keyval, out GtkWidgetPointer target);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowRemoveMnemonic(out GtkWidgetPointer window, uint keyval, out GtkWidgetPointer target);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowMnemonicActivate(out GtkWidgetPointer window, uint keyval, GdkModifierType modifier, out bool result);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetMnemonicModifier(out GtkWidgetPointer window, GdkModifierType modifier);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetMnemonicModifier(out GtkWidgetPointer window, out GdkModifierType modifier);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowActivateKey(out GtkWidgetPointer window, out GdkEventKeyPointer evnt);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowPropagateKeyEvent(out GtkWidgetPointer window, out GdkEventKeyPointer evnt);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowPresent(out GtkWidgetPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowPresentWithTime(out GtkWidgetPointer window, uint timestamp);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowIconify(out GtkWidgetPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowDeiconify(out GtkWidgetPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowStick(out GtkWidgetPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowUnstick(out GtkWidgetPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowMaximize(out GtkWidgetPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowUnmaximize(out GtkWidgetPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowFullscreen(out GtkWidgetPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowUnfullscreen(out GtkWidgetPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowFullscreenOnMonitor(out GtkWidgetPointer window, out GdkScreenPointer screen, int monitor);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowClose(out GtkWidgetPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetKeepAbove(out GtkWidgetPointer window, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetKeepBelow(out GtkWidgetPointer window, bool setting);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowBeginResizeDrag(out GtkWidgetPointer window, GdkWindowEdge edge, int button, int rootX, int rootY, uint timestamp);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowBeginMoveDrag(out GtkWidgetPointer window, int button, int rootX, int rootY, uint timestamp);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDefaultSize(out GtkWidgetPointer window, int width, int height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetDefaultSize(out GtkWidgetPointer window, out int width, out int height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowResize(out GtkWidgetPointer window, int width, int height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetSize(out GtkWidgetPointer window, out int width, out int height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowMove(out GtkWidgetPointer window, int x, int y);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetPosition(out GtkWidgetPointer window, out int rootX, out int rootY);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowParseGeometry(out GtkWidgetPointer window, string geometry);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDefaultGeometry(out GtkWidgetPointer window, int width, int height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowResizeToGeometry(out GtkWidgetPointer window, int width, int height);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetGroup(out GtkWidgetPointer window, out GtkWindowGroupPointer group);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowHasGroup(out GtkWidgetPointer window, out bool hasGroup);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowReshowWithInitialSize(out GtkWidgetPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetWindowType(out GtkWidgetPointer window);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetApplication(out GtkWidgetPointer window, out GtkApplicationPointer application);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetApplication(out GtkWidgetPointer window, out GtkApplicationPointer application);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetHasResizeGrip(out GtkWidgetPointer window, bool value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetHasResizeGrip(out GtkWidgetPointer window, out bool value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowResizeGripIsVisible(out GtkWidgetPointer window, out bool value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetResizeGripArea(out GtkWidgetPointer window, out GdkRectangle rect);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetTitlebar(out GtkWidgetPointer window, out GtkWidgetPointer titlebar);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetTitlebar(out GtkWidgetPointer window, out GtkWidgetPointer titlebar);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowIsMaximized(out GtkWidgetPointer window, out bool value);

        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetInteractiveDebugging(bool enable);        
    }
}