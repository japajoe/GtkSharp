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
        
        private WidgetDrawEvent onDrawEvent;
        private WidgetDestroyEvent onDestroyEvent;
        private WidgetDestroyedEvent onDestroyedEvent;
        private WidgetSizeAllocateEvent onSizeAllocateEvent;
        private WidgetKeyPressEvent onKeyPressEvent;
        private WidgetKeyReleaseEvent onKeyReleaseEvent;
        private WidgetButtonPressEvent onButtonPressEvent;
        private WidgetButtonReleaseEvent onButtonReleaseEvent;
        private WidgetMotionNotifyEvent onMotionNotifyEvent;
        
        private GtkWidgetDrawCallback onWidgetDrawCallback;
        private GtkWidgetDestroyCallback onWidgetDestroyCallback;
        private GtkWidgetDestroyedCallback onWidgetDestroyedCallback;
        private GtkWidgetSizeAllocateCallback onWidgetSizeAllocateCallback;
        private GtkWidgetKeyPressCallback onWidgetKeyPressCallback;
        private GtkWidgetKeyReleaseCallback onWidgetKeyReleaseCallback;
        private GtkWidgetButtonPressCallback onWidgetButtonPressCallback;
        private GtkWidgetButtonReleaseCallback onWidgetButtonReleaseCallback;
        private GtkWidgetMotionNotifyCallback onWidgetMotionNotifyCallback;

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
                return onDrawEvent;
            }
            set
            {
                onDrawEvent = value;

                if(!handle.IsNullPointer)
                {
                    if(onWidgetDrawCallback.IsNullPointer())
                    {
                        cairo = new Cairo();
                        onWidgetDrawCallback = OnDraw;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "draw", onWidgetDrawCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public WidgetDestroyEvent onDestroy
        {
            get
            {
                return onDestroyEvent;
            }
            set
            {
                onDestroyEvent = value;                

                if(!handle.IsNullPointer)
                {
                    if(onWidgetDestroyCallback.IsNullPointer())
                    {
                        onWidgetDestroyCallback = OnDestroy;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "destroy", onWidgetDestroyCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public WidgetDestroyedEvent onDestroyed
        {
            get
            {
                return onDestroyedEvent;
            }
            set
            {
                onDestroyedEvent = value;

                if(!handle.IsNullPointer)
                {
                    if(onWidgetDestroyedCallback.IsNullPointer())
                    {
                        onWidgetDestroyedCallback = OnDestroyed;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "destroy-event", onWidgetDestroyedCallback.ToIntPtr(), out handle.pointer);
                    }
                }                
            }
        }

        public WidgetSizeAllocateEvent onSizeAllocate
        {
            get
            {
                return onSizeAllocateEvent;
            }
            set
            {
                onSizeAllocateEvent = value;

                if(!handle.IsNullPointer)
                {
                    if(onWidgetSizeAllocateCallback.IsNullPointer())
                    {                        
                        onWidgetSizeAllocateCallback = OnSizeAllocate;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "size-allocate", onWidgetSizeAllocateCallback.ToIntPtr(), out handle.pointer);
                    }
                } 
            }
        }        

        public WidgetKeyPressEvent onKeyPress
        {
            get
            {
                return onKeyPressEvent;
            }
            set
            {
                onKeyPressEvent = value;

                if(!handle.IsNullPointer)
                {
                    if(onWidgetKeyPressCallback.IsNullPointer())
                    {                        
                        onWidgetKeyPressCallback = OnKeyPress;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "key-press-event", onWidgetKeyPressCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public WidgetKeyReleaseEvent onKeyRelease
        {
            get
            {
                return onKeyReleaseEvent;
            }
            set
            {
                onKeyReleaseEvent = value;

                if(!handle.IsNullPointer)
                {
                    if(onWidgetKeyReleaseCallback.IsNullPointer())
                    {                        
                        onWidgetKeyReleaseCallback = OnKeyRelease;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "key-release-event", onWidgetKeyReleaseCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }    

        public WidgetButtonPressEvent onButtonPress
        {
            get
            {
                return onButtonPressEvent;
            }
            set
            {
                onButtonPressEvent = value;

                if(!handle.IsNullPointer)
                {
                    if(onWidgetButtonPressCallback.IsNullPointer())
                    {                        
                        onWidgetButtonPressCallback = OnButtonPress;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "button-press-event", onWidgetButtonPressCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public WidgetButtonReleaseEvent onButtonRelease
        {
            get
            {
                return onButtonReleaseEvent;
            }
            set
            {
                onButtonReleaseEvent = value;

                if(!handle.IsNullPointer)
                {
                    if(onWidgetButtonReleaseCallback.IsNullPointer())
                    {                        
                        onWidgetButtonReleaseCallback = OnButtonRelease;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "button-release-event", onWidgetButtonReleaseCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public WidgetMotionNotifyEvent onMotionNotify
        {
            get
            {
                return onMotionNotifyEvent;
            }
            set
            {
                onMotionNotifyEvent = value;

                if(!handle.IsNullPointer)
                {
                    if(onWidgetMotionNotifyCallback.IsNullPointer())
                    {                        
                        onWidgetMotionNotifyCallback = OnMotionNotify;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "motion-notify-event", onWidgetMotionNotifyCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public static Widget CreateFromHandle(IntPtr handle)
        {
            Widget widget = new Widget();
            widget.handle.pointer = handle;
            return widget;
        }

        public static void DumpWidgetTypes()
        {
            NativeWidget.GtkSharpWidgetDumpTypes();
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

        bool OnButtonPress(IntPtr widget, GdkEventButtonPointer eventButton, IntPtr userData)
        {
            if(onButtonPress != null)
            {
                GdkEventButton button = Marshal.PtrToStructure<GdkEventButton>(eventButton.pointer);
                return onButtonPress(button);
            }
            return true;
        }

        bool OnButtonRelease(IntPtr widget, GdkEventButtonPointer eventButton, IntPtr userData)
        {
            if(onButtonRelease != null)
            {
                GdkEventButton button = Marshal.PtrToStructure<GdkEventButton>(eventButton.pointer);
                return onButtonRelease(button);
            }
            return true;
        }

        bool OnMotionNotify(IntPtr widget, GdkEventMotionPointer eventMotion, IntPtr userData)
        {
            if(onMotionNotify != null)
            {
                GdkEventMotion motion = Marshal.PtrToStructure<GdkEventMotion>(eventMotion.pointer);
                return onMotionNotify(motion);
            }
            return true;
        }

        void OnDestroy(IntPtr widget, IntPtr userData)
        {
            onDestroy?.Invoke();
        }

        bool OnDestroyed(IntPtr widget, GdkEventPointer evnt, IntPtr userData)
        {
            System.Console.WriteLine("ONDESTROYED");
            if(onDestroyed != null)
                return onDestroyed();
            return false;
        }

        void OnSizeAllocate(IntPtr widget, GtkAllocationPointer allocation)
        {
            if(onSizeAllocate != null)
            {
                GtkAllocation a = Marshal.PtrToStructure<GtkAllocation>(allocation.pointer);
                onSizeAllocate(a);
            }
        }
    }
}