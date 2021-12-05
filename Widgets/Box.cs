using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Box : Widget
    {
        public Box()
        {
            NativeBox.GtkSharpBoxCreate(out handle.pointer, GtkOrientation.Vertical, 0);
            SetHomogeneous(false);
        }

        public bool Homogeneous
        {
            get
            {
                return GetHomogeneous();
            }
            set
            {
                SetHomogeneous(value);
            }
        }

        public Box(GtkOrientation orientation, int spacing, bool homogeneous)
        {
            NativeBox.GtkSharpBoxCreate(out handle.pointer, orientation, spacing);
            SetHomogeneous(homogeneous);
        }

        public bool GetHomogeneous()
        {
            if(handle.IsNullPointer)
                return false;

            bool homogeneous;
            NativeBox.GtkSharpBoxGetHomogeneous(out handle.pointer, out homogeneous);
            return homogeneous;
        }

        public void SetHomogeneous(bool homogeneous)
        {
            if(handle.IsNullPointer)
                return;

            NativeBox.GtkSharpBoxSetHomogeneous(out handle.pointer, homogeneous);
        }

        public void Add(Widget child, bool expand, bool fill, uint padding)
        {
            if(handle.IsNullPointer)
                return;

            if(child.handle.IsNullPointer)
                return;

            NativeBox.GtkSharpBoxPackStart(out handle.pointer, out child.handle.pointer, expand, fill, padding);            
        }
    }
}