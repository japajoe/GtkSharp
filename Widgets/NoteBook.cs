using System;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class NoteBook : Widget
    {
        private event NoteBookSelectedIndexChanged onSelectedIndexChangedEvent;

        private GtkNoteBookSelectedIndexChangedCallback onNoteBookSelectedIndexChangedCallback;
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

        public NoteBookSelectedIndexChanged onSelectedIndexChanged
        {
            get
            {
                return onSelectedIndexChangedEvent;
            }
            set
            {
                onSelectedIndexChangedEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onNoteBookSelectedIndexChangedCallback.IsNullPointer())
                    {
                        onNoteBookSelectedIndexChangedCallback = OnSelectedIndexChanged;
                        Gtk.GtkSharpSignalConnectAfter(out handle.pointer, "switch-page", onNoteBookSelectedIndexChangedCallback.ToIntPtr(), out handle.pointer);
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

        private void OnSelectedIndexChanged(IntPtr notebook, IntPtr page, uint page_num, IntPtr data)
        {
            onSelectedIndexChangedEvent?.Invoke(page_num);
        }
    }
}