using System;
using System.Text;
using GtkSharp.Native;

namespace GtkSharp
{
    public abstract class FileChooserDialog : Widget
    {
        private event FileChooserConfirmOverwriteEvent onConfirmOverwriteEvent;
        private event FileChooserCurrentFolderChangedEvent onCurrentFolderChangedEvent;
        private event FileChooserFileActivatedEvent onFileActivatedEvent;
        private event FileChooserSelectionChangedEvent onSelectionChangedEvent;
        private event FileChooserUpdatePreviewEvent onUpdatePreviewEvent;

        private GtkFileChooserConfirmOverwriteCallback onFileChooserConfirmOverwriteCallback;
        private GtkFileChooserCurrentFolderChangedCallback onFileChooserCurrentFolderChangedCallback;
        private GtkFileChooserFileActivatedCallback onFileChooserFileActivatedCallback;
        private GtkFileChooserSelectionChangedCallback onFileChooserSelectionChangedCallback;
        private GtkFileChooserUpdatePreviewCallback onFileChooserUpdatePreviewCallback;

        protected Window parent;
        protected StringBuilder stringBuilder;
        protected string fileName;
        protected string title;

        public string FileName
        {
            get { return fileName; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public FileChooserConfirmOverwriteEvent onConfirmOverwrite
        {
            get
            {
                return onConfirmOverwriteEvent;
            }
            set
            {
                onConfirmOverwriteEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onFileChooserConfirmOverwriteCallback.IsNullPointer())
                    {
                        onFileChooserConfirmOverwriteCallback = OnConfirmOverwrite;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "confirm-overwrite", onFileChooserConfirmOverwriteCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public FileChooserCurrentFolderChangedEvent onCurrentFolderChanged
        {
            get
            {
                return onCurrentFolderChangedEvent;
            }
            set
            {
                onCurrentFolderChangedEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onFileChooserCurrentFolderChangedCallback.IsNullPointer())
                    {
                        onFileChooserCurrentFolderChangedCallback = OnCurrentFolderChanged;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "current-folder-changed", onFileChooserCurrentFolderChangedCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public FileChooserFileActivatedEvent onFileActivated
        {
            get
            {
                return onFileActivatedEvent;
            }
            set
            {
                onFileActivatedEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onFileChooserFileActivatedCallback.IsNullPointer())
                    {
                        onFileChooserFileActivatedCallback = OnFileActivated;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "file-activated", onFileChooserFileActivatedCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public FileChooserSelectionChangedEvent onSelectionChanged
        {
            get
            {
                return onSelectionChangedEvent;
            }
            set
            {
                onSelectionChangedEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onFileChooserSelectionChangedCallback.IsNullPointer())
                    {
                        onFileChooserSelectionChangedCallback = OnSelectionChanged;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "selection-changed", onFileChooserSelectionChangedCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public FileChooserUpdatePreviewEvent onUpdatePreview
        {
            get
            {
                return onUpdatePreviewEvent;
            }
            set
            {
                onUpdatePreviewEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onFileChooserUpdatePreviewCallback.IsNullPointer())
                    {
                        onFileChooserUpdatePreviewCallback = OnUpdatePreview;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "update-preview", onFileChooserUpdatePreviewCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }


        public FileChooserDialog(Window parent)
        {
            this.parent = parent;
            this.stringBuilder = new StringBuilder(1024);
        }

        public virtual GtkResponseType ShowDialog()
        {
            return GtkResponseType.None;            
        }

        GtkFileChooserConfirmation OnConfirmOverwrite(IntPtr widget, IntPtr data)
        {
            if(onConfirmOverwrite != null)
            {
                return onConfirmOverwrite();
            }
            return GtkFileChooserConfirmation.Confirm;
        }

        void OnCurrentFolderChanged(IntPtr widget, IntPtr data)
        {
            onCurrentFolderChanged?.Invoke();
        }

        void OnFileActivated(IntPtr widget, IntPtr data)
        {
            onFileActivated?.Invoke();
        }

        void OnSelectionChanged(IntPtr widget, IntPtr data)
        {
            onSelectionChanged?.Invoke();
        }

        void OnUpdatePreview(IntPtr widget, IntPtr data)
        {
            onUpdatePreview?.Invoke();
        }        
    }
}