using GtkSharp.Gtk.Types;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Widgets
{
    public class Grid : Container
    {
        public bool RowHomogeneous
        {
            get
            {
                return GetRowHomogeneous();
            }
            set
            {
                SetRowHomogeneous(value);
            }
        }

        public bool ColumnHomogeneous
        {
            get
            {
                return GetColumnHomogeneous();
            }
            set
            {
                SetColumnHomogeneous(value);
            }
        }    

        public uint RowSpacing
        {
            get
            {
                return GetRowSpacing();
            }
            set
            {
                SetRowSpacing(value);
            }            
        }

        public uint ColumnSpacing
        {
            get
            {
                return GetColumnSpacing();
            }
            set
            {
                SetColumnSpacing(value);
            }            
        }

        public Grid()
        {
            handle = NativeGrid.gtk_grid_new();
        }

        public bool GetRowHomogeneous()
        {
            if(handle.IsNullPointer)
                return false;
            
            return NativeGrid.gtk_grid_get_row_homogeneous(handle);
        }
            
        private void SetRowHomogeneous(bool homogeneous)
        {
            if(handle.IsNullPointer)
                return;

            NativeGrid.gtk_grid_set_row_homogeneous(handle, homogeneous);
        }
            
        private bool GetColumnHomogeneous()
        {
            if(handle.IsNullPointer)
                return false;

            return NativeGrid.gtk_grid_get_column_homogeneous(handle);
        }
            
        private void SetColumnHomogeneous(bool homogeneous)
        {
            if(handle.IsNullPointer)
                return;

            NativeGrid.gtk_grid_set_column_homogeneous(handle, homogeneous);
        } 

        private uint GetRowSpacing()
        {
            if(handle.IsNullPointer)
                return 0;

            return NativeGrid.gtk_grid_get_row_spacing(handle);
        }

        private void SetRowSpacing(uint spacing)
        {
            if(handle.IsNullPointer)
                return;

            NativeGrid.gtk_grid_set_row_spacing(handle, spacing);
        }

        private uint GetColumnSpacing()
        {
            if(handle.IsNullPointer)
                return 0;

            return NativeGrid.gtk_grid_get_column_spacing(handle);
        }

        private void SetColumnSpacing(uint spacing)
        {
            if(handle.IsNullPointer)
                return;

            NativeGrid.gtk_grid_set_column_spacing(handle, spacing);
        }

        private GtkBaselinePosition GetRowBaselinePosition(int row)
        {
            if(handle.IsNullPointer)
                return GtkBaselinePosition.Top;

            return NativeGrid.gtk_grid_get_row_baseline_position(handle, row);
        }
        
        private void SetRowBaselinePosition(int row, GtkBaselinePosition position)
        {
            if(handle.IsNullPointer)
                return;

            NativeGrid.gtk_grid_set_row_baseline_position(handle, row, position);
        }

        private int GetBaselineRow()
        {
            if(handle.IsNullPointer)
                return 0;

            return NativeGrid.gtk_grid_get_baseline_row(handle);
        }
        
        private void SetBaselineRow(int row)
        {
            if(handle.IsNullPointer)
                return;
            
            NativeGrid.gtk_grid_set_baseline_row(handle, row);
        }

        public Widget GetChildAt(int left, int top)
        {
            if(handle.IsNullPointer)
                return null;

            var w = NativeGrid.gtk_grid_get_child_at(handle, left, top);

            if(w.IsNullPointer)
                return null;

            Widget child = new Widget(w.pointer);
            return child;
        }

        public void Attach(Widget child, int left, int top, int width, int height)
        {
            if(handle.IsNullPointer)
                return;
            
            NativeGrid.gtk_grid_attach(handle, child.Handle, left, top, width, height);
        }

        public void AttachNextTo(Widget child, Widget sibling, GtkPositionType side, int width, int height)
        {
            if(handle.IsNullPointer)
                return;

            NativeGrid.gtk_grid_attach_next_to(handle, child.Handle, sibling.Handle, side, width, height);
        }

        public void InsertNextTo(Widget sibling, GtkPositionType side)
        {
            if(handle.IsNullPointer)
                return;

            NativeGrid.gtk_grid_insert_next_to(handle, sibling.Handle, side);
        }

        public void InsertRow(int position)
        {
            if(handle.IsNullPointer)
                return;

            NativeGrid.gtk_grid_insert_row(handle, position);
        }

        public void InsertColumn(int position)
        {
            if(handle.IsNullPointer)
                return;

            NativeGrid.gtk_grid_insert_column(handle, position);
        }
        
        public void RemoveRow(int position)
        {
            if(handle.IsNullPointer)
                return;

            NativeGrid.gtk_grid_remove_row(handle, position);
        }       
        
        public void RemoveColumn(int position)
        {
            if(handle.IsNullPointer)
                return;

            NativeGrid.gtk_grid_remove_column(handle, position);
        }
    }
}