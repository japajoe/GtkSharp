using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class ComboBox : Bin
    {
        public ComboBox()
        {
            handle = NativeComboBox.gtk_combo_box_new();
        }

        public ComboBox(string entryText)
        {
            handle = NativeComboBox.gtk_combo_box_new_with_entry();
        }

        public Entry GetEntry()
        {
            if(handle.IsNullPointer)
                return null;
            
            if(!NativeComboBox.gtk_combo_box_get_has_entry(handle))
                return null;
            
            Widget widget = GetChild();
            
            if(widget == null)
                return null;

            Entry entry = (Entry)widget;
            return entry;
        }
    }
}