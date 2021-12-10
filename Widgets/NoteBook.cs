using System;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class NoteBook : Widget
    {
        private event NoteBookChangeCurrentPageEvent onChangeCurrentPageEvent;
        private event NoteBookCreateWindowEvent onCreateWindowEvent;
        private event NoteBookFocusTabEvent onFocusTabEvent;
        private event NoteBookMoveFocusOutEvent onMoveFocusOutEvent;
        private event NoteBookPageAddedEvent onPageAddedEvent;
        private event NoteBookPageRemovedEvent onPageRemovedEvent;
        private event NoteBookPageReorderedEvent onPageReorderedEvent;
        private event NoteBookReorderTabEvent onReorderTabEvent;
        private event NoteBookSelectPageEvent onSelectPageEvent;
        private event NoteBookSwitchPageEvent onSwitchPageEvent;

        private GtkNoteBookChangeCurrentPageCallback onNoteBookChangeCurrentPageCallback;
        private GtkNoteBookCreateWindowCallback onNoteBookCreateWindowCallback;
        private GtkNoteBookFocusTabCallback onNoteBookFocusTabCallback;
        private GtkNoteBookMoveFocusOutCallback onNoteBookMoveFocusOutCallback;
        private GtkNoteBookPageAddedCallback onNoteBookPageAddedCallback;
        private GtkNoteBookPageRemovedCallback onNoteBookPageRemovedCallback;
        private GtkNoteBookPageReorderedCallback onNoteBookPageReorderedCallback;
        private GtkNoteBookReorderTabCallback onNoteBookReorderTabCallback;
        private GtkNoteBookSelectPageCallback onNoteBookSelectPageCallback;
        private GtkNoteBookSwitchPageCallback onNoteBookSwitchPageCallback;

        private int pageCount;
        private int selectedIndex;

        public int PageCount
        {
            get
            {
                return GetPageCount();
            }
        }

        public int SelectedIndex
        {
            get
            {
                return GetSelectedIndex();
            }
            set
            {
                SetSelectedIndex(value);
            }
        }

        public NoteBookChangeCurrentPageEvent onChangeCurrentPage
        {
            get
            {
                return onChangeCurrentPageEvent;
            }
            set
            {
                onChangeCurrentPageEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onNoteBookChangeCurrentPageCallback.IsNullPointer())
                    {
                        onNoteBookChangeCurrentPageCallback = OnChangeCurrentPage;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "change-current-page", onNoteBookChangeCurrentPageCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public NoteBookCreateWindowEvent onCreateWindow
        {
            get
            {
                return onCreateWindowEvent;
            }
            set
            {
                onCreateWindowEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onNoteBookCreateWindowCallback.IsNullPointer())
                    {
                        onNoteBookCreateWindowCallback = OnCreateWindow;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "create-window", onNoteBookCreateWindowCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public NoteBookFocusTabEvent onFocusTab
        {
            get
            {
                return onFocusTabEvent;
            }
            set
            {
                onFocusTabEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onNoteBookFocusTabCallback.IsNullPointer())
                    {
                        onNoteBookFocusTabCallback = OnFocusTab;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "focus-tab", onNoteBookFocusTabCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public NoteBookMoveFocusOutEvent onMoveFocusOut
        {
            get
            {
                return onMoveFocusOutEvent;
            }
            set
            {
                onMoveFocusOutEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onNoteBookMoveFocusOutCallback.IsNullPointer())
                    {
                        onNoteBookMoveFocusOutCallback = OnMoveFocusOut;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "move-focus-out", onNoteBookMoveFocusOutCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public NoteBookPageAddedEvent onPageAdded
        {
            get
            {
                return onPageAddedEvent;
            }
            set
            {
                onPageAddedEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onNoteBookPageAddedCallback.IsNullPointer())
                    {
                        onNoteBookPageAddedCallback = OnPageAdded;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "page-added", onNoteBookPageAddedCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public NoteBookPageRemovedEvent onPageRemoved
        {
            get
            {
                return onPageRemovedEvent;
            }
            set
            {
                onPageRemovedEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onNoteBookPageRemovedCallback.IsNullPointer())
                    {
                        onNoteBookPageRemovedCallback = OnPageRemoved;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "page-removed", onNoteBookPageRemovedCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public NoteBookPageReorderedEvent onPageReordered
        {
            get
            {
                return onPageReorderedEvent;
            }
            set
            {
                onPageReorderedEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onNoteBookPageReorderedCallback.IsNullPointer())
                    {
                        onNoteBookPageReorderedCallback = OnPageReordered;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "page-reordered", onNoteBookPageReorderedCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public NoteBookReorderTabEvent onReorderTab
        {
            get
            {
                return onReorderTabEvent;
            }
            set
            {
                onReorderTabEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onNoteBookReorderTabCallback.IsNullPointer())
                    {
                        onNoteBookReorderTabCallback = OnReorderTab;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "reorder-tab", onNoteBookReorderTabCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public NoteBookSelectPageEvent onSelectPage
        {
            get
            {
                return onSelectPageEvent;
            }
            set
            {
                onSelectPageEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onNoteBookSelectPageCallback.IsNullPointer())
                    {
                        onNoteBookSelectPageCallback = OnSelectPage;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "select-page", onNoteBookSelectPageCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public NoteBookSwitchPageEvent onSwitchPage
        {
            get
            {
                return onSwitchPageEvent;
            }
            set
            {
                onSwitchPageEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onNoteBookSwitchPageCallback.IsNullPointer())
                    {
                        onNoteBookSwitchPageCallback = OnSwitchPage;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "switch-page", onNoteBookSwitchPageCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public NoteBook()
        {
            NativeNoteBook.GtkSharpNotebookCreate(out handle);
        }

        public void Append(Widget child, Widget label)
        {
            if(handle.IsNullPointer)
                return;

            int index;
            NativeNoteBook.GtkSharpNotebookAppendPage(out handle, out child.handle, out label.handle, out index);
        }

        public void Remove(int index)
        {
            if(handle.IsNullPointer)
                return;

            NativeNoteBook.GtkSharpNotebookRemovePage(out handle, index);
        }

        public int GetPageCount()
        {
            if(handle.IsNullPointer)
                return 0;

            NativeNoteBook.GtkSharpNotebookGetNPages(out handle, out pageCount);

            return pageCount;
        }

        public int GetSelectedIndex()
        {
            if(handle.IsNullPointer)
                return -1;

            NativeNoteBook.GtkSharpNotebookGetCurrentPage(out handle, out selectedIndex);
            return selectedIndex;
        }

        public void SetSelectedIndex(int index)
        {
            if(handle.IsNullPointer)
                return;

            NativeNoteBook.GtkSharpNotebookSetCurrentPage(out handle, index);
            selectedIndex = index;
        }

        bool OnChangeCurrentPage(IntPtr widget, int obj, IntPtr data)
        {
            if(onChangeCurrentPage != null)
            {
                return onChangeCurrentPage(obj);
            }
            return false;
        }

        GtkNoteBookPointer OnCreateWindow(IntPtr widget, GtkWidgetPointer page, int x, int y, IntPtr data)
        {
            if(onCreateWindow != null)
            {
                return onCreateWindow(page, x, y);
            }
            GtkNoteBookPointer p = new GtkNoteBookPointer();
            p.pointer = IntPtr.Zero;
            return p;
        }

        bool OnFocusTab(IntPtr widget, GtkNotebookTab tab, IntPtr data)
        {
            if(onFocusTab != null)
            {
                return onFocusTab(tab);
            }
            return false;
        }

        void OnMoveFocusOut(IntPtr widget, GtkDirectionType directionType, IntPtr data)
        {
            onMoveFocusOut?.Invoke(directionType);
        }

        void OnPageAdded(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data)
        {
            onPageAdded?.Invoke(child, pageNum);
        }

        void OnPageRemoved(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data)
        {
            onPageRemoved?.Invoke(child, pageNum);
        }

        void OnPageReordered(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data)
        {
            onPageReordered?.Invoke(child, pageNum);
        }

        bool OnReorderTab(IntPtr widget, GtkDirectionType directionType, bool p0, IntPtr data)
        {
            if(onReorderTab != null)
            {
                return onReorderTab(directionType, p0);
            }
            return false;
        }

        bool OnSelectPage(IntPtr widget, bool obj, IntPtr data)
        {
            if(onSelectPage != null)
            {
                return onSelectPage(obj);
            }
            return false;
        }

        void OnSwitchPage(IntPtr widget, GtkWidgetPointer page, uint pageNum, IntPtr data)
        {
            onSwitchPage?.Invoke(page, pageNum);
        }
    }
}