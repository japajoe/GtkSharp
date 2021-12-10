using System.Text;
using System.Runtime.InteropServices;

namespace GtkSharp.Native.Widgets
{
    internal static class NativeNoteBook
    {
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetType(out ulong type);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookCreate(out GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookAppendPage(out GtkWidgetPointer notebook, out GtkWidgetPointer child, out GtkWidgetPointer tabLabel, out int pageIndex);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookAppendPageMenu(out GtkWidgetPointer notebook, out GtkWidgetPointer child, out GtkWidgetPointer tabLabel, out GtkWidgetPointer menuLabel, out int pageIndex);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookPrependPage(out GtkWidgetPointer notebook, out GtkWidgetPointer child, out GtkWidgetPointer tabLabel, out int pageIndex);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookPrependPageMenu(out GtkWidgetPointer notebook, out GtkWidgetPointer child, out GtkWidgetPointer tabLabel, out GtkWidgetPointer menuLabel, out int pageIndex);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookInsertPage(out GtkWidgetPointer notebook, out GtkWidgetPointer child, out GtkWidgetPointer tabLabel, int position, out int pageIndex);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookInsertPageMenu(out GtkWidgetPointer notebook, out GtkWidgetPointer child, out GtkWidgetPointer tabLabel, out GtkWidgetPointer menuLabel, int position, out int pageIndex);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookRemovePage(out GtkWidgetPointer notebook, int pageIndex);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookSetGroupName(out GtkWidgetPointer notebook, string groupName);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetGroupName(out GtkWidgetPointer notebook, StringBuilder groupName);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetGroupNameLength(out GtkWidgetPointer notebook, out int length);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetCurrentPage(out GtkWidgetPointer notebook, out int pageIndex);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetNthPage(out GtkWidgetPointer notebook, out GtkWidgetPointer widget, int pageIndex);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetNPages(out GtkWidgetPointer notebook, out int numPages);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookPageNum(out GtkWidgetPointer notebook, out GtkWidgetPointer child, out int pageIndex);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookSetCurrentPage(out GtkWidgetPointer notebook, int pageIndex);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookNextPage(out GtkWidgetPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookPrevPage(out GtkWidgetPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookSetShowBorder(out GtkWidgetPointer notebook, bool showBorder);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetShowBorder(out GtkWidgetPointer notebook, out bool showBorder);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookSetShowTabs(out GtkWidgetPointer notebook, bool showTabs);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetShowTabs(out GtkWidgetPointer notebook, out bool showTabs);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookSetTabPos(out GtkWidgetPointer notebook, GtkPositionType pos);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetTabPos(out GtkWidgetPointer notebook, out GtkPositionType positionType);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookSetScrollable(out GtkWidgetPointer notebook, bool scrollable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetScrollable(out GtkWidgetPointer notebook, out bool scrollable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetTabHborder(out GtkWidgetPointer notebook, out ushort horizontalWidth);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetTabVborder(out GtkWidgetPointer notebook, out ushort verticalWidth);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookPopupEnable(out GtkWidgetPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookPopupDisable(out GtkWidgetPointer notebook);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetTabLabel(out GtkWidgetPointer notebook, out GtkWidgetPointer child, out GtkWidgetPointer tabLabel);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookSetTabLabel(out GtkWidgetPointer notebook, out GtkWidgetPointer child, out GtkWidgetPointer tabLabel);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookSetTabLabelText(out GtkWidgetPointer notebook, out GtkWidgetPointer child, string text);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetTabLabelText(out GtkWidgetPointer notebook, out GtkWidgetPointer child, StringBuilder text);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetTabLabelTextLength(out GtkWidgetPointer notebook, out GtkWidgetPointer child, out int length);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetMenuLabel(out GtkWidgetPointer notebook, out GtkWidgetPointer child, out GtkWidgetPointer label);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookSetMenuLabel(out GtkWidgetPointer notebook, out GtkWidgetPointer child, out GtkWidgetPointer menuLabel);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookSetMenuLabelText(out GtkWidgetPointer notebook, out GtkWidgetPointer child, string menuText);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetMenuLabelText(out GtkWidgetPointer notebook, out GtkWidgetPointer child, StringBuilder text);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetMenuLabelTextLength(out GtkWidgetPointer notebook, out GtkWidgetPointer child, out int length);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookReorderChild(out GtkWidgetPointer notebook, out GtkWidgetPointer child, int position);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetTabReorderable(out GtkWidgetPointer notebook, out GtkWidgetPointer child, out bool reorderable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookSetTabReorderable(out GtkWidgetPointer notebook, out GtkWidgetPointer child, bool reorderable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetTabDetachable(out GtkWidgetPointer notebook, out GtkWidgetPointer child, out bool detachable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookSetTabDetachable(out GtkWidgetPointer notebook, out GtkWidgetPointer child, bool detachable);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookDetachTab(out GtkWidgetPointer notebook, out GtkWidgetPointer child);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookGetActionWidget(out GtkWidgetPointer notebook, GtkPackType packType, out GtkWidgetPointer widget);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void GtkSharpNotebookSetActionWidget(out GtkWidgetPointer notebook, out GtkWidgetPointer widget, GtkPackType packType);
    }
}