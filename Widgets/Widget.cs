using System;
using GtkSharp.Callbacks;
using GtkSharp.Native;
using GtkSharp.Native.Types;
using GtkSharp.Native.Widgets;
using GtkSharp.Native.Callbacks;
using System.Runtime.InteropServices;
using GtkSharp.Drawing;

namespace GtkSharp
{
    public class Widget
    {
        internal GtkWidgetPointer handle;
        private Cairo cairo;

        private WidgetDestroyEvent onDestroyEvent;
        private WidgetDestroyedEvent onDestroyedEvent;
        private WidgetSizeAllocateEvent onSizeAllocateEvent;
        private WidgetKeyPressEvent onKeyPressEvent;
        private WidgetKeyReleaseEvent onKeyReleaseEvent;
        private WidgetButtonPressEvent onButtonPressEvent;
        private WidgetButtonReleaseEvent onButtonReleaseEvent;
        private WidgetMotionNotifyEvent onMotionNotifyEvent;
        private WidgetDrawEvent onDrawEvent;

        private GtkWidgetDestroyCallback onWidgetDestroyCallback;
        private GtkWidgetDestroyedCallback onWidgetDestroyedCallback;
        private GtkWidgetSizeAllocateCallback onWidgetSizeAllocateCallback;
        private GtkWidgetKeyPressCallback onWidgetKeyPressCallback;
        private GtkWidgetKeyReleaseCallback onWidgetKeyReleaseCallback;
        private GtkWidgetButtonPressCallback onWidgetButtonPressCallback;
        private GtkWidgetButtonReleaseCallback onWidgetButtonReleaseCallback;
        private GtkWidgetMotionNotifyCallback onWidgetMotionNotifyCallback;
        private GtkWidgetDrawCallback onWidgetDrawCallback;

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
                        GLib.g_signal_connect(handle.pointer, "destroy", onWidgetDestroyCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "destroy-event", onWidgetDestroyedCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "size-allocate", onWidgetSizeAllocateCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "key-press-event", onWidgetKeyPressCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "key-release-event", onWidgetKeyReleaseCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "button-press-event", onWidgetButtonPressCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "button-release-event", onWidgetButtonReleaseCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "motion-notify-event", onWidgetMotionNotifyCallback.ToIntPtr(), handle.pointer);
                    }
                }
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
                        GLib.g_signal_connect(handle.pointer, "draw", onWidgetDrawCallback.ToIntPtr(), handle.pointer);
                    }
                }
            }
        }

        public Widget()
        {
            
        }

        internal Widget(IntPtr handle)
        {
            this.handle.pointer = handle;
        }

        public void Show()
        {
            if(handle.IsNullPointer)
                return;

            NativeWidget.gtk_widget_show(handle);
        }

        public void ShowAll()
        {
            if(handle.IsNullPointer)
                return;

            NativeWidget.gtk_widget_show_all(handle);
        }

        public void SetSizeRequest(int width, int height)
        {
            if(handle.IsNullPointer)
                return;
            
            NativeWidget.gtk_widget_set_size_request(handle, width, height);
        }

        public void SetMargins(int top, int left, int bottom, int right)
        {
            if(handle.IsNullPointer)
                return;

            NativeWidget.gtk_widget_set_margin_bottom(handle, bottom);
            NativeWidget.gtk_widget_set_margin_top(handle, bottom);
            NativeWidget.gtk_widget_set_margin_left(handle, bottom);
            NativeWidget.gtk_widget_set_margin_right(handle, bottom);
        }

        public void AddEvents(GdkEventMask events)
        {
            if(handle.IsNullPointer)
                return;

            int e = (int)events;
            NativeWidget.gtk_widget_add_events(handle, e);
        }

        public void Destroy()
        {
            if(!handle.IsNullPointer)
            {
                NativeWidget.gtk_widget_destroy(handle);
                handle.pointer = IntPtr.Zero;
            }
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

        private bool OnDraw(IntPtr widget, IntPtr cr, IntPtr data)
        {
            cairo.cr.pointer = cr;
            
            if(onDraw != null)
            {
                return onDraw(cairo);
            }
            return false;
        }    
    }
}