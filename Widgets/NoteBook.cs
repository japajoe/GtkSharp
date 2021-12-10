using System;
using GtkSharp.Native;

namespace GtkSharp
{
    public class NoteBook : Widget
    {
        private event NoteBookSelectedIndexChanged onSelectedIndexChangedCallback;

        private GtkNoteBookSelectedIndexChangedCallback onNoteBookSelectedIndexChanged;
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
                return onSelectedIndexChangedCallback;
            }
            set
            {
                onSelectedIndexChangedCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onNoteBookSelectedIndexChanged.IsNullPointer())
                    {
                        onNoteBookSelectedIndexChanged = OnSelectedIndexChanged;
                        Gtk.GtkSharpSignalConnectAfter(out handle.pointer, "switch-page", onNoteBookSelectedIndexChanged.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public NoteBook()
        {
            Gtk.GtkSharpNoteBookCreate(out handle);
        }

        public void Append(Widget child, Widget label)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpNoteBookAppend(out handle, out child.handle.pointer, out label.handle.pointer);
        }

        public void Remove(int index)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpNoteBookRemove(out handle, index);
        }

        public int GetPageCount()
        {
            if(handle.IsNullPointer)
                return 0;

            Gtk.GtkSharpNoteBookGetPageCount(out handle, out pageCount);

            return pageCount;
        }

        public int GetSelectedIndex()
        {
            if(handle.IsNullPointer)
                return -1;

            Gtk.GtkSharpNoteBookGetSelectedIndex(out handle, out selectedIndex);
            return selectedIndex;
        }

        public void SetSelectedIndex(int index)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpNoteBookSetSelectedIndex(out handle, index);
            selectedIndex = index;
        }

        private void OnSelectedIndexChanged(IntPtr notebook, IntPtr page, uint page_num, IntPtr data)
        {
            onSelectedIndexChangedCallback?.Invoke(page_num);
        }
    }
}