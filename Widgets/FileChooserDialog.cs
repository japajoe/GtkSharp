using System;
using System.Text;
using GtkSharp.Callbacks;
using GtkSharp.Native.Callbacks;

namespace GtkSharp
{
    public abstract class FileChooserDialog : Widget
    {
        private GEventHandler<FileChooserConfirmOverwriteCallback,FileChooserConfirmOverwriteEvent> confirmOverwriteHandler = new GEventHandler<FileChooserConfirmOverwriteCallback, FileChooserConfirmOverwriteEvent>();
        private GEventHandler<FileChooserCurrentFolderChangedCallback,FileChooserCurrentFolderChangedEvent> currentFolderChangedHandler = new GEventHandler<FileChooserCurrentFolderChangedCallback, FileChooserCurrentFolderChangedEvent>();
        private GEventHandler<FileChooserFileActivatedCallback,FileChooserFileActivatedEvent> fileActivatedHandler = new GEventHandler<FileChooserFileActivatedCallback, FileChooserFileActivatedEvent>();
        private GEventHandler<FileChooserSelectionChangedCallback,FileChooserSelectionChangedEvent> selectionChangedHandler = new GEventHandler<FileChooserSelectionChangedCallback, FileChooserSelectionChangedEvent>();
        private GEventHandler<FileChooserUpdatePreviewCallback,FileChooserUpdatePreviewEvent> updatePreviewHandler = new GEventHandler<FileChooserUpdatePreviewCallback, FileChooserUpdatePreviewEvent>();

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

        public FileChooserConfirmOverwriteEvent ConfirmOverwrite
        {
            get
            {
                return confirmOverwriteHandler.Event;
            }
            set
            {
                confirmOverwriteHandler.Event = value;
                confirmOverwriteHandler.SignalConnect(handle.pointer, "confirm-overwrite", OnConfirmOverwrite, handle.pointer);
            }
        }

        public FileChooserCurrentFolderChangedEvent CurrentFolderChanged
        {
            get
            {
                return currentFolderChangedHandler.Event;
            }
            set
            {
                currentFolderChangedHandler.Event = value;
                currentFolderChangedHandler.SignalConnect(handle.pointer, "current-folder-changed", OnCurrentFolderChanged, handle.pointer);
            }
        }

        public FileChooserFileActivatedEvent FileActivated
        {
            get
            {
                return fileActivatedHandler.Event;
            }
            set
            {
                fileActivatedHandler.Event = value;
                fileActivatedHandler.SignalConnect(handle.pointer, "file-activated", OnFileActivated, handle.pointer);
            }
        }

        public FileChooserSelectionChangedEvent SelectionChanged
        {
            get
            {
                return selectionChangedHandler.Event;
            }
            set
            {
                selectionChangedHandler.Event = value;
                selectionChangedHandler.SignalConnect(handle.pointer, "selection-changed", OnSelectionChanged, handle.pointer);
            }
        }

        public FileChooserUpdatePreviewEvent UpdatePreview
        {
            get
            {
                return updatePreviewHandler.Event;
            }
            set
            {
                updatePreviewHandler.Event = value;
                updatePreviewHandler.SignalConnect(handle.pointer, "update-preview", OnUpdatePreview, handle.pointer);
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
            if(ConfirmOverwrite != null)
            {
                return ConfirmOverwrite();
            }
            return GtkFileChooserConfirmation.Confirm;
        }

        void OnCurrentFolderChanged(IntPtr widget, IntPtr data)
        {
            CurrentFolderChanged?.Invoke();
        }

        void OnFileActivated(IntPtr widget, IntPtr data)
        {
            FileActivated?.Invoke();
        }

        void OnSelectionChanged(IntPtr widget, IntPtr data)
        {
            SelectionChanged?.Invoke();
        }

        void OnUpdatePreview(IntPtr widget, IntPtr data)
        {
            UpdatePreview?.Invoke();
        }        
    }
}