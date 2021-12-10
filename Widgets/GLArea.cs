using System;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class GLArea : Widget
    {
        private event GLAreaCreateContextEvent onCreateContextCallback;
        private event GLAreaResizeEvent onResizeCallback;
        private event GLAreaRenderEvent onRenderCallback;
        private event GLAreaRealizeEvent onRealizeCallback;
        private event GLAreaUnRealizeEvent onUnRealizeCallback;

        private GtkGLAreaCreateContextCallback onGLAreaCreateContext;
        private GtkGLAreaResizeCallback onGLAreaResize;
        private GtkGLAreaRealizeCallback onGLAreaRealize;
        private GtkGLAreaUnRealizeCallback onGLAreaUnRealize;
        private GtkGLAreaRenderCallback onGLAreaRender;
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
                return onCreateContextCallback;
            }
            set
            {
                onCreateContextCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onGLAreaCreateContext.IsNullPointer())
                    {
                        onGLAreaCreateContext = OnCreateContext;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "create-context", onGLAreaCreateContext.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public GLAreaResizeEvent onResize
        {
            get
            {
                return onResizeCallback;
            }
            set
            {
                onResizeCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onGLAreaResize.IsNullPointer())
                    {
                        onGLAreaResize = OnResize;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "resize", onGLAreaResize.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public GLAreaRenderEvent onRender
        {
            get
            {
                return onRenderCallback;
            }
            set
            {
                onRenderCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onGLAreaRender.IsNullPointer())
                    {
                        onGLAreaRender = OnRender;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "realize", onGLAreaRealize.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public GLAreaRealizeEvent onRealize
        {
            get
            {
                return onRealizeCallback;
            }
            set
            {
                onRealizeCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onGLAreaRealize.IsNullPointer())
                    {
                        onGLAreaRealize = OnRealize;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "unrealize", onGLAreaUnRealize.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public GLAreaUnRealizeEvent onUnRealize
        {
            get
            {
                return onUnRealizeCallback;
            }
            set
            {
                onUnRealizeCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onGLAreaUnRealize.IsNullPointer())
                    {
                        onGLAreaUnRealize = OnUnRealize;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "render", onGLAreaRender.ToIntPtr(), out handle.pointer);
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
            onCreateContextCallback?.Invoke();
            return context;
        }

        void OnResize(IntPtr area, int width, int height, IntPtr data)
        {
            onResizeCallback?.Invoke(width, height);
        }        

        private void OnRealize(IntPtr area)
        {
            onRealizeCallback?.Invoke();
        }

        private void OnUnRealize(IntPtr area)
        {
            onUnRealizeCallback?.Invoke();
        }

        private bool OnRender(IntPtr area, IntPtr context)
        {
            onRenderCallback?.Invoke();
            return true;
        }
    }
}