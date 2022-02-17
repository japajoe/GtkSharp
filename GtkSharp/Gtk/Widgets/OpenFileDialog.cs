using System;
using GtkSharp.Utilities;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.GLib.Native;
using GtkSharp.Gtk.Types;
using GtkSharp.Glib.Native.Types;
using GtkSharp.GLib.Types;
using System.Runtime.InteropServices;

namespace GtkSharp.Gtk.Widgets
{
    public class OpenFileDialog : FileChooserDialog
    {
        private bool multiSelect;

        public OpenFileDialog(Window parent, bool multiSelect = false) : base(parent)
        {
            this.title = "Open File";
            this.multiSelect = multiSelect;
            this.fileName = string.Empty;
            this.fileNames = new string[0]; //Prevents null reference exception when accessing while there is no data yet

            handle = NativeFileChooserDialog.gtk_file_chooser_dialog_new(title,
                                                                parent.Handle,
                                                                GtkFileChooserAction.Open,
                                                                "_Cancel",
                                                                GtkResponseType.Cancel,
                                                                "_Open",
                                                                GtkResponseType.Accept,
                                                                IntPtr.Zero);
        }

        public override GtkResponseType ShowDialog()
        {
            if(handle.IsNullPointer)
            {
                handle = NativeFileChooserDialog.gtk_file_chooser_dialog_new(title,
                                                                    parent.Handle,
                                                                    GtkFileChooserAction.Open,
                                                                    "_Cancel",
                                                                    GtkResponseType.Cancel,
                                                                    "_Open",
                                                                    GtkResponseType.Accept,
                                                                    IntPtr.Zero);  
            }

            if(multiSelect)
                NativeFileChooser.gtk_file_chooser_set_select_multiple(handle, multiSelect);

            GtkResponseType response = (GtkResponseType)NativeDialog.gtk_dialog_run(handle);
            
            if(response == GtkResponseType.Accept)
            {
                if(multiSelect)
                {
                    GSListPointer listPointer = NativeFileChooser.gtk_file_chooser_get_filenames(handle);

                    uint numItems = NativeGSList.g_slist_length(listPointer);

                    fileNames = new string[numItems];

                    for(uint i = 0; i < numItems; i++)
                    {
                        GSListPointer node = NativeGSList.g_slist_nth(listPointer, i);
                        GSList list = Marshal.PtrToStructure<GSList>(node.pointer);
                        string file = Marshal.PtrToStringUTF8(list.data);
                        fileNames[i] = file;
                        GLibLib.g_free(list.data);
                    }

                    NativeGSList.g_slist_free(listPointer);
                }
                else
                {
                    IntPtr ptr = NativeFileChooser.gtk_file_chooser_get_filename(handle);
                    fileName = MarshalHelper.MarshalPtrToString(ptr);
                    GLibLib.g_free(ptr);
                }

            }
            
            this.Destroy();

            return response;
        }
    }
}