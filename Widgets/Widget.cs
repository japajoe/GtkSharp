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
        
        private GtkWidgetDrawCallback onWidgetDraw;


        private WidgetDestroyEvent onDestroyCallback;
        private WidgetDestroyedEvent onDestroyedCallback;
        private WidgetSizeAllocateEvent onSizeAllocateCallback;
        private WidgetKeyPressEvent onKeyPressCallback;
        private WidgetKeyReleaseEvent onKeyReleaseCallback;
        private WidgetButtonPressEvent onButtonPressCallback;
        private WidgetButtonReleaseEvent onButtonReleaseCallback;
        private WidgetMotionNotifyEvent onMotionNotifyCallback;
        
        private GtkWidgetDestroyCallback onWidgetDestroy;
        private GtkWidgetDestroyedCallback onWidgetDestroyed;
        private GtkWidgetSizeAllocateCallback onWidgetSizeAllocate;
        private GtkWidgetKeyPressCallback onWidgetKeyPress;
        private GtkWidgetKeyReleaseCallback onWidgetKeyRelease;
        private GtkWidgetButtonPressCallback onWidgetButtonPress;
        private GtkWidgetButtonReleaseCallback onWidgetButtonRelease;
        private GtkWidgetMotionNotifyCallback onWidgetMotionNotify;

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
                    if(onWidgetDraw.IsNullPointer())
                    {
                        cairo = new Cairo();
                        onWidgetDraw = OnDraw;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "draw", onWidgetDraw.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public WidgetDestroyEvent onDestroy
        {
            get
            {
                return onDestroyCallback;
            }
            set
            {
                onDestroyCallback = value;                

                if(!handle.IsNullPointer)
                {
                    if(onWidgetDestroy.IsNullPointer())
                    {
                        onWidgetDestroy = OnDestroy;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "destroy", onWidgetDestroy.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public WidgetDestroyedEvent onDestroyed
        {
            get
            {
                return onDestroyedCallback;
            }
            set
            {
                onDestroyedCallback = value;

                if(!handle.IsNullPointer)
                {
                    if(onWidgetDestroyed.IsNullPointer())
                    {
                        onWidgetDestroyed = OnDestroyed;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "destroy-event", onWidgetDestroyed.ToIntPtr(), out handle.pointer);
                    }
                }                
            }
        }

        public WidgetSizeAllocateEvent onSizeAllocate
        {
            get
            {
                return onSizeAllocateCallback;
            }
            set
            {
                onSizeAllocateCallback = value;

                if(!handle.IsNullPointer)
                {
                    if(onWidgetSizeAllocate.IsNullPointer())
                    {                        
                        onWidgetSizeAllocate = OnSizeAllocate;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "size-allocate", onWidgetSizeAllocate.ToIntPtr(), out handle.pointer);
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
                    if(onWidgetKeyPress.IsNullPointer())
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
                    if(onWidgetKeyRelease.IsNullPointer())
                    {                        
                        onWidgetKeyRelease = OnKeyRelease;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "key-release-event", onWidgetKeyRelease.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }    

        public WidgetButtonPressEvent onButtonPress
        {
            get
            {
                return onButtonPressCallback;
            }
            set
            {
                onButtonPressCallback = value;

                if(!handle.IsNullPointer)
                {
                    if(onWidgetButtonPress.IsNullPointer())
                    {                        
                        onWidgetButtonPress = OnButtonPress;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "button-press-event", onWidgetButtonPress.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public WidgetButtonReleaseEvent onButtonRelease
        {
            get
            {
                return onButtonReleaseCallback;
            }
            set
            {
                onButtonReleaseCallback = value;

                if(!handle.IsNullPointer)
                {
                    if(onWidgetButtonRelease.IsNullPointer())
                    {                        
                        onWidgetButtonRelease = OnButtonRelease;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "button-release-event", onWidgetButtonRelease.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public WidgetMotionNotifyEvent onMotionNotify
        {
            get
            {
                return onMotionNotifyCallback;
            }
            set
            {
                onMotionNotifyCallback = value;

                if(!handle.IsNullPointer)
                {
                    if(onWidgetMotionNotify.IsNullPointer())
                    {                        
                        onWidgetMotionNotify = OnMotionNotify;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "motion-notify-event", onWidgetMotionNotify.ToIntPtr(), out handle.pointer);
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