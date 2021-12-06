using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Widget
    {
        internal GtkWidgetPointer handle;
        private int width;
        private int height;

        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return width; }
        }

        public GtkWidgetPointer Handle
        {
            get { return handle; }
        }

        public void SetSize(int width, int height)
        {
            if(handle.IsNullPointer)
                return;

            NativeWidget.GtkSharpWidgetSetSizeRequest(out handle, width, height);
            CalculatePreferredSize();            
        }

        public void CalculatePreferredSize()
        {
            if(handle.IsNullPointer)
                return;
            
            GtkRequisition naturalSize;
            GtkRequisition minimumSize;

            NativeWidget.GtkSharpWidgetGetPreferredSize(out handle, out minimumSize, out naturalSize);
            
            width  = naturalSize.width;
            height = naturalSize.height;
        }

        public void Show()
        {
            if(handle.IsNullPointer)
                return;

            NativeWidget.GtkSharpWidgetShow(out handle);
        }

        public void ShowAll()
        {
            if(handle.IsNullPointer)
                return;

            NativeWidget.GtkSharpWidgetShowAll(out handle);
        }

        public void Focus()
        {
            if(handle.IsNullPointer)
                return;

            NativeWidget.GtkSharpWidgetGrabFocus(out handle);
        }

        public void Destroy()
        {
            if(handle.IsNullPointer)
                return;

            NativeWidget.GtkSharpWidgetDestroy(out handle);
        }

        public void QueueDraw()
        {
            if(handle.IsNullPointer)
                return;
            
            NativeWidget.GtkSharpWidgetQueueDraw(out handle);
        }

        public void SetMargins(int top, int left, int bottom, int right)
        {
            if(handle.IsNullPointer)
                return;

            NativeWidget.GtkSharpWidgetSetMarginBottom(out handle, bottom);
            NativeWidget.GtkSharpWidgetSetMarginTop(out handle, bottom);
            NativeWidget.GtkSharpWidgetSetMarginLeft(out handle, bottom);
            NativeWidget.GtkSharpWidgetSetMarginRight(out handle, bottom);
        }

        public void AddEvents(GdkEventMask events)
        {
            if(handle.IsNullPointer)
                return;

            int e = (int)events;
            NativeWidget.GtkSharpWidgetAddEvents(out handle, e);
        }
    }
}