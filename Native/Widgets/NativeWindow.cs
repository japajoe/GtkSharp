using System;
using System.Text;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeWindow
    {
        const string NATIVELIBNAME = "gtksharp";

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetType(out uint type);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowCreate(out IntPtr window, GtkWindowType type);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetTitle(out IntPtr window, string title);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetTitle(out IntPtr window, StringBuilder title);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetTitleLength(out IntPtr window, out int length);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetWmclass(out IntPtr window, string wmclassName, string wmclassClass);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetRole(out IntPtr window, string role);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetStartupId(out IntPtr window, string startupId);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetRole(out IntPtr window, StringBuilder role);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetRoleLength(out IntPtr window, out int length);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowAddAccelGroup(out IntPtr window, out IntPtr accelGroup);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowRemoveAccelGroup(out IntPtr window, out IntPtr accelGroup);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetPosition(out IntPtr window, GtkWindowPosition position);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowActivateFocus(out IntPtr window);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetFocus(out IntPtr window, out IntPtr focus);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetFocus(out IntPtr window, out IntPtr focus);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDefault(out IntPtr window, out IntPtr defaultWidget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetDefaultWidget(out IntPtr window, out IntPtr defaultWidget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowActivateDefault(out IntPtr window);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetTransientFor(out IntPtr window, out IntPtr parent);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetTransientFor(out IntPtr window, out IntPtr parent);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetAttachedTo(out IntPtr window, out IntPtr attachWidget);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetAttachedTo(out IntPtr window);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetOpacity(out IntPtr window, double opacity);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetOpacity(out IntPtr window, out double opacity);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetTypeHint(out IntPtr window, GdkWindowTypeHint hint);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetTypeHint(out IntPtr window, out GdkWindowTypeHint hint);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetSkipTaskbarHint(out IntPtr window, bool hint);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetSkipTaskbarHint(out IntPtr window, out bool hint);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetSkipPagerHint(out IntPtr window, bool hint);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetSkipPagerHint(out IntPtr window, out bool hint);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetUrgencyHint(out IntPtr window, bool hint);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetUrgencyHint(out IntPtr window, out bool hint);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetAcceptFocus(out IntPtr window, bool accept);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetAcceptFocus(out IntPtr window, out bool accept);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetFocusOnMap(out IntPtr window, bool focus);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetFocusOnMap(out IntPtr window, out bool focus);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDestroyWithParent(out IntPtr window, bool setting);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetDestroyWithParent(out IntPtr window, out bool setting);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetHideTitlebarWhenMaximized(out IntPtr window, bool setting);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetHideTitlebarWhenMaximized(out IntPtr window, out bool setting);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetMnemonicsVisible(out IntPtr window, bool setting);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetMnemonicsVisible(out IntPtr window, out bool setting);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetFocusVisible(out IntPtr window, bool setting);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetFocusVisible(out IntPtr window, out bool setting);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetResizable(out IntPtr window, bool resizable);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetResizable(out IntPtr window, out bool resizable);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetGravity(out IntPtr window, GdkGravity gravity);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetGravity(out IntPtr window, out GdkGravity gravity);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetGeometryHints(out IntPtr window, out IntPtr geometryWidget, out IntPtr geometry, GdkWindowHints geomMask);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetScreen(out IntPtr window, out IntPtr screen);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetScreen(out IntPtr window, out IntPtr screen);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowIsActive(out IntPtr window, out bool isActive);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowHasToplevelFocus(out IntPtr window, out bool hasToplevelFocus);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDecorated(out IntPtr window, bool setting);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetDecorated(out IntPtr window, out bool setting);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDeletable(out IntPtr window, bool setting);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetDeletable(out IntPtr window, out bool setting);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetIconList(out IntPtr window, out IntPtr list);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetIconList(out IntPtr window, out IntPtr list);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetIcon(out IntPtr window, out IntPtr icon);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetIconName(out IntPtr window, string name);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetIconFromFile(out IntPtr window, string filename, out IntPtr error);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetIcon(out IntPtr window, out IntPtr icon);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetIconName(out IntPtr window);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDefaultIconList(out IntPtr list);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetDefaultIconList();

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDefaultIcon(out IntPtr icon);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDefaultIconName(string name);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetDefaultIconName(StringBuilder name);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetDefaultIconNameLength(out int length);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDefaultIconFromFile(string filename, out IntPtr error);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetAutoStartupNotification(bool setting);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetModal(out IntPtr window, bool modal);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetModal(out IntPtr window, out bool modal);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowListToplevels(out IntPtr list);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetHasUserRefCount(out IntPtr window, bool setting);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowAddMnemonic(out IntPtr window, uint keyval, out IntPtr target);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowRemoveMnemonic(out IntPtr window, uint keyval, out IntPtr target);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowMnemonicActivate(out IntPtr window, uint keyval, GdkModifierType modifier, out bool result);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetMnemonicModifier(out IntPtr window, GdkModifierType modifier);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetMnemonicModifier(out IntPtr window, out GdkModifierType modifier);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowActivateKey(out IntPtr window, out IntPtr evnt);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowPropagateKeyEvent(out IntPtr window, out IntPtr evnt);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowPresent(out IntPtr window);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowPresentWithTime(out IntPtr window, uint timestamp);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowIconify(out IntPtr window);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowDeiconify(out IntPtr window);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowStick(out IntPtr window);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowUnstick(out IntPtr window);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowMaximize(out IntPtr window);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowUnmaximize(out IntPtr window);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowFullscreen(out IntPtr window);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowUnfullscreen(out IntPtr window);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowFullscreenOnMonitor(out IntPtr window, out IntPtr screen, int monitor);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowClose(out IntPtr window);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetKeepAbove(out IntPtr window, bool setting);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetKeepBelow(out IntPtr window, bool setting);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowBeginResizeDrag(out IntPtr window, GdkWindowEdge edge, int button, int rootX, int rootY, uint timestamp);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowBeginMoveDrag(out IntPtr window, int button, int rootX, int rootY, uint timestamp);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDefaultSize(out IntPtr window, int width, int height);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetDefaultSize(out IntPtr window, out int width, out int height);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowResize(out IntPtr window, int width, int height);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetSize(out IntPtr window, out int width, out int height);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowMove(out IntPtr window, int x, int y);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetPosition(out IntPtr window, out int rootX, out int rootY);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowParseGeometry(out IntPtr window, string geometry);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetDefaultGeometry(out IntPtr window, int width, int height);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowResizeToGeometry(out IntPtr window, int width, int height);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetGroup(out IntPtr window, out IntPtr group);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowHasGroup(out IntPtr window, out bool hasGroup);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowReshowWithInitialSize(out IntPtr window);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetWindowType(out IntPtr window);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetApplication(out IntPtr window, out IntPtr application);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetApplication(out IntPtr window, out IntPtr application);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetHasResizeGrip(out IntPtr window, bool value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetHasResizeGrip(out IntPtr window, out bool value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowResizeGripIsVisible(out IntPtr window, out bool value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetResizeGripArea(out IntPtr window, out GdkRectangle rect);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetTitlebar(out IntPtr window, out IntPtr titlebar);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowGetTitlebar(out IntPtr window, out IntPtr titlebar);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowIsMaximized(out IntPtr window, out bool value);

        [DllImport(NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpWindowSetInteractiveDebugging(bool enable);        
    }
}