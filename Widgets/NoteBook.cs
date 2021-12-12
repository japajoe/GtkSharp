using System;
using GtkSharp.Callbacks;
using GtkSharp.Native;
using GtkSharp.Native.Callbacks;
using GtkSharp.Native.Types;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class NoteBook : Container
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
                        GLib.g_signal_connect(handle.pointer, "change-current-page", onNoteBookChangeCurrentPageCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "create-window", onNoteBookCreateWindowCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "focus-tab", onNoteBookFocusTabCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "move-focus-out", onNoteBookMoveFocusOutCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "page-added", onNoteBookPageAddedCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "page-removed", onNoteBookPageRemovedCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "page-reordered", onNoteBookPageReorderedCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "reorder-tab", onNoteBookReorderTabCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "select-page", onNoteBookSelectPageCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "switch-page", onNoteBookSwitchPageCallback.ToIntPtr(), handle.pointer);
                    }
                }
            }
        }
                
        public NoteBook()
        {
            handle = NativeNoteBook.gtk_notebook_new();
        }

        public int AppendPage(Widget widget, Widget label)
        {
            if(handle.IsNullPointer)
                return -1;
            
            return NativeNoteBook.gtk_notebook_append_page(handle, widget.handle, label.handle);
        }

        public int AppendPageMenu(Widget widget, Widget tabLabel, Widget menuLabel)
        {
            if(handle.IsNullPointer)
                return -1;
            
            return NativeNoteBook.gtk_notebook_append_page_menu(handle, widget.handle, tabLabel.handle, menuLabel.handle);
        }        

        public int PrependPage(Widget widget, Widget label)       
        {
            if(handle.IsNullPointer)
                return -1;

            return NativeNoteBook.gtk_notebook_prepend_page(handle, widget.handle, label.handle);
        }

        public int PrependPageMenu(Widget widget, Widget tabLabel, Widget menuLabel)
        {
            if(handle.IsNullPointer)
                return -1;
            
            return NativeNoteBook.gtk_notebook_prepend_page_menu(handle, widget.handle, tabLabel.handle, menuLabel.handle);
        }

        public int InsertPage(Widget widget, Widget label, int index)
        {
            if(handle.IsNullPointer)
                return -1;
            
            return NativeNoteBook.gtk_notebook_insert_page(handle, widget.handle, label.handle, index);
        }

        public int InsertPageMenu(Widget widget, Widget tabLabel, Widget menuLabel, int index)
        {
            if(handle.IsNullPointer)
                return -1;
            
            return NativeNoteBook.gtk_notebook_insert_page_menu(handle, widget.handle, tabLabel.handle, menuLabel.handle, index);
        }

        public void RemovePage(int index)
        {
            if(handle.IsNullPointer)
                return;

            NativeNoteBook.gtk_notebook_remove_page(handle, index);
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
            GtkNoteBookPointer p = new GtkNoteBookPointer();

            if(onCreateWindow != null)
            {
                Widget w = new Widget(widget);
                NoteBook b = onCreateWindow(w, x, y);
                p.pointer = b.handle.pointer;
                return p;
            }
            
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
            if(onPageAdded != null)
            {
                Widget c = new Widget(widget);            
                onPageAdded(c, pageNum);
            }
        }

        void OnPageRemoved(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data)
        {
            if(onPageRemoved != null)
            {
                Widget c = new Widget(widget);
                onPageRemoved(c, pageNum);
            }
        }

        void OnPageReordered(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data)
        {
            if(onPageReordered != null)
            {
                Widget c = new Widget(widget);
                onPageReordered(c, pageNum);
            }
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
            if(onSwitchPage != null)
            {
                Widget p = new Widget(page.pointer);
                onSwitchPage(p, pageNum);
            }
        }        
    }
}