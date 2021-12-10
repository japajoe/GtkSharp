using System;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class GLArea : Widget
    {
        private event GLAreaCreateContextEvent onCreateContextEvent;
        private event GLAreaResizeEvent onResizeEvent;
        private event GLAreaRenderEvent onRenderEvent;
        private event GLAreaRealizeEvent onRealizeEvent;
        private event GLAreaUnRealizeEvent onUnRealizeEvent;

        private GtkGLAreaCreateContextCallback onGLAreaCreateContextCallback;
        private GtkGLAreaResizeCallback onGLAreaResizeCallback;
        private GtkGLAreaRealizeCallback onGLAreaRealizeCallback;
        private GtkGLAreaUnRealizeCallback onGLAreaUnRealizeCallback;
        private GtkGLAreaRenderCallback onGLAreaRenderCallback;
        
        private GdkGLContextPointer context;

        public bool AutoRender
        {
            get
            {
                return GetAutoRender();
            }
            set
            {
                SetAutoRender(value);
            }
        }

        public GLAreaCreateContextEvent onCreateContext
        {
            get
            {
                return onCreateContextEvent;
            }
            set
            {
                onCreateContextEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onGLAreaCreateContextCallback.IsNullPointer())
                    {
                        onGLAreaCreateContextCallback = OnCreateContext;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "create-context", onGLAreaCreateContextCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public GLAreaResizeEvent onResize
        {
            get
            {
                return onResizeEvent;
            }
            set
            {
                onResizeEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onGLAreaResizeCallback.IsNullPointer())
                    {
                        onGLAreaResizeCallback = OnResize;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "resize", onGLAreaResizeCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public GLAreaRenderEvent onRender
        {
            get
            {
                return onRenderEvent;
            }
            set
            {
                onRenderEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onGLAreaRenderCallback.IsNullPointer())
                    {
                        onGLAreaRenderCallback = OnRender;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "render", onGLAreaRenderCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public GLAreaRealizeEvent onRealize
        {
            get
            {
                return onRealizeEvent;
            }
            set
            {
                onRealizeEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onGLAreaRealizeCallback.IsNullPointer())
                    {
                        onGLAreaRealizeCallback = OnRealize;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "realize", onGLAreaRealizeCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public GLAreaUnRealizeEvent onUnRealize
        {
            get
            {
                return onUnRealizeEvent;
            }
            set
            {
                onUnRealizeEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onGLAreaUnRealizeCallback.IsNullPointer())
                    {
                        onGLAreaUnRealizeCallback = OnUnRealize;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "unrealize", onGLAreaUnRealizeCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public GLArea()
        {
            NativeGLArea.GtkSharpGLAreaCreate(out handle);
        }

        public void QueueRender()
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.GtkSharpGLAreaQueueRender(out handle);
        }

        public void MakeCurrent()
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.GtkSharpGLAreaMakeCurrent(out handle);
        }

        public bool GetContext()
        {
            if(handle.IsNullPointer)
                return false;

            NativeGLArea.GtkSharpGLAreaGetContext(out handle, out context);
            return true;
        }

        
        public void SetRequiredVersion(int major, int minor)
        {
            if(handle.IsNullPointer)
                return;
            
            NativeGLArea.GtkSharpGLAreaSetRequiredVersion(out handle, major, minor);
        }

        
        public bool GetRequiredVersion(out int major, out int minor)
        {
            if(handle.IsNullPointer)
            {
                major = 0;
                minor = 0;
                return false;
            }

            NativeGLArea.GtkSharpGLAreaGetRequiredVersion(out handle, out major, out minor);
            return true;
        }
        
        public bool GetHasAlpha()
        {
            if(handle.IsNullPointer)
                return false;

            bool hasAlpha;
            NativeGLArea.GtkSharpGLAreaGetHasAlpha(out handle, out hasAlpha);
            return hasAlpha;
        }
        
        public void SetHasAlpha(bool hasAlpha)
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.GtkSharpGLAreaSetHasAlpha(out handle, hasAlpha);
        }
        
        public bool GetHasDepthBuffer()
        {
            if(handle.IsNullPointer)
                return false;

            bool hasDepthBuffer;
            NativeGLArea.GtkSharpGLAreaGetHasDepthBuffer(out handle, out hasDepthBuffer);
            return hasDepthBuffer;                
        }
        
        public void SetHasDepthBuffer(bool hasDepthBuffer)
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.GtkSharpGLAreaSetHasDepthBuffer(out handle, hasDepthBuffer);
        }
        
        public bool GetHasStencilBuffer()
        {
            if(handle.IsNullPointer)
                return false;

            bool hasStencilBuffer;
            NativeGLArea.GtkSharpGLAreaGetHasStencilBuffer(out handle, out hasStencilBuffer);
            return hasStencilBuffer;
        }
        
        public void SetHasStencilBuffer(bool hasStencilBuffer)
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.GtkSharpGLAreaSetHasStencilBuffer(out handle, hasStencilBuffer);
        }

        public bool GetAutoRender()
        {
            if(handle.IsNullPointer)
                return false;

            bool auto;
            NativeGLArea.GtkSharpGLAreaGetAutoRender(out handle, out auto);
            return auto;
        }

        public void SetAutoRender(bool auto)
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.GtkSharpGLAreaSetAutoRender(out handle, auto);
        }

        GdkGLContextPointer OnCreateContext(IntPtr area, IntPtr data)
        {
            NativeGLArea.GtkSharpGLAreaGetContext(out handle, out context);
            onCreateContextEvent?.Invoke();
            return context;
        }

        void OnResize(IntPtr area, int width, int height, IntPtr data)
        {
            onResizeEvent?.Invoke(width, height);
        }        

        private void OnRealize(IntPtr area)
        {
            onRealizeEvent?.Invoke();
        }

        private void OnUnRealize(IntPtr area)
        {
            onUnRealizeEvent?.Invoke();
        }

        private bool OnRender(IntPtr area, IntPtr context)
        {
            onRenderEvent?.Invoke();
            return true;
        }
    }
}