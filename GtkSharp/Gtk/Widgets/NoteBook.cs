using System;
using GtkSharp.Gtk.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class NoteBook : Container
    {
        private GEventHandler<NoteBookChangeCurrentPageCallback,NoteBookChangeCurrentPageEvent> changeCurrentPageHandler = new GEventHandler<NoteBookChangeCurrentPageCallback, NoteBookChangeCurrentPageEvent>();
        private GEventHandler<NoteBookCreateWindowCallback,NoteBookCreateWindowEvent> createWindowHandler = new GEventHandler<NoteBookCreateWindowCallback, NoteBookCreateWindowEvent>();
        private GEventHandler<NoteBookFocusTabCallback,NoteBookFocusTabEvent> focusTabHandler = new GEventHandler<NoteBookFocusTabCallback, NoteBookFocusTabEvent>();
        private GEventHandler<NoteBookMoveFocusOutCallback,NoteBookMoveFocusOutEvent> moveFocusOutHandler = new GEventHandler<NoteBookMoveFocusOutCallback, NoteBookMoveFocusOutEvent>();
        private GEventHandler<NoteBookPageAddedCallback,NoteBookPageAddedEvent> pageAddedHandler = new GEventHandler<NoteBookPageAddedCallback, NoteBookPageAddedEvent>();
        private GEventHandler<NoteBookPageRemovedCallback,NoteBookPageRemovedEvent> pageRemovedHandler = new GEventHandler<NoteBookPageRemovedCallback, NoteBookPageRemovedEvent>();
        private GEventHandler<NoteBookPageReorderedCallback,NoteBookPageReorderedEvent> pageReorderedHandler = new GEventHandler<NoteBookPageReorderedCallback, NoteBookPageReorderedEvent>();
        private GEventHandler<NoteBookReorderTabCallback,NoteBookReorderTabEvent> reorderTabHandler = new GEventHandler<NoteBookReorderTabCallback, NoteBookReorderTabEvent>();
        private GEventHandler<NoteBookSelectPageCallback,NoteBookSelectPageEvent> selectPageHandler = new GEventHandler<NoteBookSelectPageCallback, NoteBookSelectPageEvent>();
        private GEventHandler<NoteBookSwitchPageCallback,NoteBookSwitchPageEvent> switchPageHandler = new GEventHandler<NoteBookSwitchPageCallback, NoteBookSwitchPageEvent>();

        public NoteBookChangeCurrentPageEvent ChangeCurrentPage
        {
            get
            {
                return changeCurrentPageHandler.Event;
            }
            set
            {
                changeCurrentPageHandler.Event = value;
                changeCurrentPageHandler.SignalConnect(handle.pointer, "change-current-page", OnChangeCurrentPage, handle.pointer);
            }
        }

        public NoteBookCreateWindowEvent CreateWindow
        {
            get
            {
                return createWindowHandler.Event;
            }
            set
            {
                createWindowHandler.Event = value;
                createWindowHandler.SignalConnect(handle.pointer, "create-window", OnCreateWindow, handle.pointer);
            }
        }

        public NoteBookFocusTabEvent FocusTab
        {
            get
            {
                return focusTabHandler.Event;
            }
            set
            {
                focusTabHandler.Event = value;
                focusTabHandler.SignalConnect(handle.pointer, "focus-tab", OnFocusTab, handle.pointer);
            }
        }

        public NoteBookMoveFocusOutEvent MoveFocusOut
        {
            get
            {
                return moveFocusOutHandler.Event;
            }
            set
            {
                moveFocusOutHandler.Event = value;
                moveFocusOutHandler.SignalConnect(handle.pointer, "move-focus-out", OnMoveFocusOut, handle.pointer);
            }
        }

        public NoteBookPageAddedEvent PageAdded
        {
            get
            {
                return pageAddedHandler.Event;
            }
            set
            {
                pageAddedHandler.Event = value;
                pageAddedHandler.SignalConnect(handle.pointer, "page-added", OnPageAdded, handle.pointer);
            }
        }

        public NoteBookPageRemovedEvent PageRemoved
        {
            get
            {
                return pageRemovedHandler.Event;
            }
            set
            {
                pageRemovedHandler.Event = value;
                pageRemovedHandler.SignalConnect(handle.pointer, "page-removed", OnPageRemoved, handle.pointer);
            }
        }

        public NoteBookPageReorderedEvent PageReordered
        {
            get
            {
                return pageReorderedHandler.Event;
            }
            set
            {
                pageReorderedHandler.Event = value;
                pageReorderedHandler.SignalConnect(handle.pointer, "page-reordered", OnPageReordered, handle.pointer);
            }
        }

        public NoteBookReorderTabEvent ReorderTab
        {
            get
            {
                return reorderTabHandler.Event;
            }
            set
            {
                reorderTabHandler.Event = value;
                reorderTabHandler.SignalConnect(handle.pointer, "reorder-tab", OnReorderTab, handle.pointer);
            }
        }

        public NoteBookSelectPageEvent SelectPage
        {
            get
            {
                return selectPageHandler.Event;
            }
            set
            {
                selectPageHandler.Event = value;
                selectPageHandler.SignalConnect(handle.pointer, "select-page", OnSelectPage, handle.pointer);
            }
        }

        public NoteBookSwitchPageEvent SwitchPage
        {
            get
            {
                return switchPageHandler.Event;
            }
            set
            {
                switchPageHandler.Event = value;
                switchPageHandler.SignalConnect(handle.pointer, "switch-page", OnSwitchPage, handle.pointer);
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
            if(ChangeCurrentPage != null)
            {
                return ChangeCurrentPage(obj);
            }
            return false;
        }

        GtkNoteBookPointer OnCreateWindow(IntPtr widget, GtkWidgetPointer page, int x, int y, IntPtr data)
        {
            GtkNoteBookPointer p = new GtkNoteBookPointer();

            if(CreateWindow != null)
            {
                Widget w = new Widget(widget);
                NoteBook b = CreateWindow(w, x, y);
                p.pointer = b.handle.pointer;
                return p;
            }
            
            p.pointer = IntPtr.Zero;
            return p;
        }

        bool OnFocusTab(IntPtr widget, GtkNotebookTab tab, IntPtr data)
        {
            if(FocusTab != null)
            {
                return FocusTab(tab);
            }
            return false;
        }

        void OnMoveFocusOut(IntPtr widget, GtkDirectionType directionType, IntPtr data)
        {
            MoveFocusOut?.Invoke(directionType);
        }

        void OnPageAdded(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data)
        {
            if(PageAdded != null)
            {
                Widget c = new Widget(widget);            
                PageAdded(c, pageNum);
            }
        }

        void OnPageRemoved(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data)
        {
            if(PageRemoved != null)
            {
                Widget c = new Widget(widget);
                PageRemoved(c, pageNum);
            }
        }

        void OnPageReordered(IntPtr widget, GtkWidgetPointer child, uint pageNum, IntPtr data)
        {
            if(PageReordered != null)
            {
                Widget c = new Widget(widget);
                PageReordered(c, pageNum);
            }
        }

        bool OnReorderTab(IntPtr widget, GtkDirectionType directionType, bool p0, IntPtr data)
        {
            if(ReorderTab != null)
            {
                return ReorderTab(directionType, p0);
            }
            return false;
        }

        bool OnSelectPage(IntPtr widget, bool obj, IntPtr data)
        {
            if(SelectPage != null)
            {
                return SelectPage(obj);
            }
            return false;
        }

        void OnSwitchPage(IntPtr widget, GtkWidgetPointer page, uint pageNum, IntPtr data)
        {
            if(SwitchPage != null)
            {
                Widget p = new Widget(page.pointer);
                SwitchPage(p, pageNum);
            }
        }        
    }
}