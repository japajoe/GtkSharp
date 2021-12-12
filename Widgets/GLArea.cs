using System;
using GtkSharp.Callbacks;
using GtkSharp.Native.Callbacks;
using GtkSharp.Native.Types;
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
                        GLib.g_signal_connect(handle.pointer, "create-context", onGLAreaCreateContextCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "resize", onGLAreaResizeCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "render", onGLAreaRenderCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "realize", onGLAreaRealizeCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "unrealize", onGLAreaUnRealizeCallback.ToIntPtr(), handle.pointer);
                    }
                }
            }
        }

        public GLArea()
        {
            handle = NativeGLArea.gtk_gl_area_new();
        }

        public void QueueRender()
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.gtk_gl_area_queue_render(handle);
        }

        public void MakeCurrent()
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.gtk_gl_area_make_current(handle);
        }

        public bool GetContext()
        {
            if(handle.IsNullPointer)
                return false;

            context = NativeGLArea.gtk_gl_area_get_context(handle);
            return true;
        }

        
        public void SetRequiredVersion(int major, int minor)
        {
            if(handle.IsNullPointer)
                return;
            
            NativeGLArea.gtk_gl_area_set_required_version(handle, major, minor);
        }

        
        public bool GetRequiredVersion(out int major, out int minor)
        {
            if(handle.IsNullPointer)
            {
                major = 0;
                minor = 0;
                return false;
            }

            NativeGLArea.gtk_gl_area_get_required_version(handle, out major, out minor);
            return true;
        }
        
        public bool GetHasAlpha()
        {
            if(handle.IsNullPointer)
                return false;

            bool hasAlpha;
            hasAlpha = NativeGLArea.gtk_gl_area_get_has_alpha(handle);
            return hasAlpha;
        }
        
        public void SetHasAlpha(bool hasAlpha)
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.gtk_gl_area_set_has_alpha(handle, hasAlpha);
        }
        
        public bool GetHasDepthBuffer()
        {
            if(handle.IsNullPointer)
                return false;

            bool hasDepthBuffer = NativeGLArea.gtk_gl_area_get_has_depth_buffer(handle);
            return hasDepthBuffer;                
        }
        
        public void SetHasDepthBuffer(bool hasDepthBuffer)
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.gtk_gl_area_set_has_depth_buffer(handle, hasDepthBuffer);
        }
        
        public bool GetHasStencilBuffer()
        {
            if(handle.IsNullPointer)
                return false;

            bool hasStencilBuffer;
            hasStencilBuffer = NativeGLArea.gtk_gl_area_get_has_stencil_buffer(handle);
            return hasStencilBuffer;
        }
        
        public void SetHasStencilBuffer(bool hasStencilBuffer)
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.gtk_gl_area_set_has_stencil_buffer(handle, hasStencilBuffer);
        }

        public bool GetAutoRender()
        {
            if(handle.IsNullPointer)
                return false;

            bool auto = NativeGLArea.gtk_gl_area_get_auto_render(handle);
            return auto;
        }

        public void SetAutoRender(bool auto)
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.gtk_gl_area_set_auto_render(handle, auto);
        }

        GdkGLContextPointer OnCreateContext(IntPtr area, IntPtr data)
        {
            context = NativeGLArea.gtk_gl_area_get_context(handle);
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