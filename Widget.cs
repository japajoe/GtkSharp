using System;
using GtkSharp.Native;

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

            Gtk.GtkSharpWidgetSetSize(out handle.pointer, ref width, ref height);
            this.width = width;
            this.height = height;
        }

        public void CalculaterPreferredSize()
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpWidgetCalculatePreferredSize(out handle.pointer, ref width, ref height);
        }

        public void Show()
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpWidgetShow(out handle.pointer);
        }

        public void ShowAll()
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpWidgetShowAll(out handle.pointer);
        }

        public void Focus()
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpWidgetSetFocus(out handle.pointer);
        }

        public void Destroy()
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpWidgetDestroy(out handle.pointer);
        }

        public void QueueDraw()
        {
            if(handle.IsNullPointer)
                return;
            
            Gtk.GtkSharpWidgetQueueDraw(out handle.pointer);
        }

        public void SetMargins(double top, double left, double bottom, double right)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpWidgetSetMargins(out handle.pointer, top, left, bottom, right);
        }
    }
}