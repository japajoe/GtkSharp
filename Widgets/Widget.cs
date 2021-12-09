using System;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;
using GtkSharp.Drawing;
using System.Runtime.InteropServices;

namespace GtkSharp
{
    public class Widget
    {
        internal GtkWidgetPointer handle;        
        
        private int width;
        private int height;
        private Cairo cairo;
        private WidgetDrawEvent onDrawCallback;
        
        private WidgetKeyPressEvent onKeyPressCallback;
        private WidgetKeyReleaseEvent onKeyReleaseCallback;
        
        private GtkWidgetDrawCallback onWidgetDraw;
        
        private GtkWidgetKeyPressCallback onWidgetKeyPress;
        private GtkWidgetKeyReleaseCallback onWidgetKeyRelease;

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

        public bool AppPaintable
        {
            get
            {
                return GetAppPaintable();
            }
            set
            {
                SetAppPaintable(value);
            }
        }

        public WidgetDrawEvent onDraw
        {
            get
            {
                return onDrawCallback;
            }
            set
            {
                onDrawCallback = value;

                if(!handle.IsNullPointer)
                {
                    if(onWidgetDraw == null)
                    {
                        cairo = new Cairo();
                        onWidgetDraw = OnDraw;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "draw", onWidgetDraw.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public WidgetKeyPressEvent onKeyPress
        {
            get
            {
                return onKeyPressCallback;
            }
            set
            {
                onKeyPressCallback = value;

                if(!handle.IsNullPointer)
                {
                    if(onWidgetKeyPress == null)
                    {                        
                        onWidgetKeyPress = OnKeyPress;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "key-press-event", onWidgetKeyPress.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public WidgetKeyReleaseEvent onKeyRelease
        {
            get
            {
                return onKeyReleaseCallback;
            }
            set
            {
                onKeyReleaseCallback = value;

                if(!handle.IsNullPointer)
                {
                    if(onWidgetKeyRelease == null)
                    {                        
                        onWidgetKeyRelease = OnKeyRelease;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "key-release-event", onWidgetKeyRelease.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }        

        protected virtual void RegisterCallbacks()
        {
            
        }

        public bool GetAppPaintable()
        {
            if(handle.IsNullPointer)
                return false;

            bool paintable;
            NativeWidget.GtkSharpWidgetGetAppPaintable(out handle, out paintable);
            return paintable;
        }

        public void SetAppPaintable(bool paintable)
        {
            if(handle.IsNullPointer)
                return;
            
            NativeWidget.GtkSharpWidgetSetAppPaintable(out handle, paintable);
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

        private bool OnDraw(IntPtr widget, IntPtr cr, IntPtr data)
        {
            cairo.cr.pointer = cr;
            
            if(onDraw != null)
            {
                return onDraw(cairo);
            }
            return false;
        }

        bool OnKeyPress(IntPtr widget, GdkEventKeyPointer eventKey, IntPtr userData)
        {
            if(onKeyPress != null)
            {
                GdkEventKey key = Marshal.PtrToStructure<GdkEventKey>(eventKey.pointer);
                return onKeyPress(key);
            }
            return true;
        }
        bool OnKeyRelease(IntPtr widget, GdkEventKeyPointer eventKey, IntPtr userData)
        {
            if(onKeyRelease != null)
            {
                GdkEventKey key = Marshal.PtrToStructure<GdkEventKey>(eventKey.pointer);
                return onKeyRelease(key);
            }
            return true;
        }
    }
}