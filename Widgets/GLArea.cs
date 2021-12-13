using System;
using GtkSharp.Callbacks;
using GtkSharp.Native.Callbacks;
using GtkSharp.Native.Types;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class GLArea : Widget
    {
        private GEventHandler<GLAreaCreateContextCallback,GLAreaCreateContextEvent> createContextHandler = new GEventHandler<GLAreaCreateContextCallback, GLAreaCreateContextEvent>();
        private GEventHandler<GLAreaResizeCallback,GLAreaResizeEvent> resizeHandler = new GEventHandler<GLAreaResizeCallback, GLAreaResizeEvent>();
        private GEventHandler<GLAreaRenderCallback,GLAreaRenderEvent> renderHandler = new GEventHandler<GLAreaRenderCallback, GLAreaRenderEvent>();
        private GEventHandler<GLAreaRealizeCallback,GLAreaRealizeEvent> realizeHandler = new GEventHandler<GLAreaRealizeCallback, GLAreaRealizeEvent>();
        private GEventHandler<GLAreaUnrealizeCallback,GLAreaUnrealizeEvent> unrealizeHandler = new GEventHandler<GLAreaUnrealizeCallback, GLAreaUnrealizeEvent>();
        
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

        public GLAreaCreateContextEvent CreateContext
        {
            get
            {
                return createContextHandler.Event;
            }
            set
            {
                createContextHandler.Event = value;
                createContextHandler.SignalConnect(handle.pointer, "create-context", OnCreateContext, handle.pointer);
            }
        }

        public GLAreaResizeEvent Resize
        {
            get
            {
                return resizeHandler.Event;
            }
            set
            {
                resizeHandler.Event = value;
                resizeHandler.SignalConnect(handle.pointer, "resize", OnResize, handle.pointer);
            }
        }

        public GLAreaRenderEvent Render
        {
            get
            {
                return renderHandler.Event;
            }
            set
            {
                renderHandler.Event = value;
                renderHandler.SignalConnect(handle.pointer, "render", OnRender, handle.pointer);
            }
        }

        public GLAreaRealizeEvent Realize
        {
            get
            {
                return realizeHandler.Event;
            }
            set
            {
                realizeHandler.Event = value;
                realizeHandler.SignalConnect(handle.pointer, "realize", OnRealize, handle.pointer);
            }
        }

        public GLAreaUnrealizeEvent Unrealize
        {
            get
            {
                return unrealizeHandler.Event;
            }
            set
            {
                unrealizeHandler.Event = value;
                unrealizeHandler.SignalConnect(handle.pointer, "unrealize", OnUnRealize, handle.pointer);
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
            CreateContext?.Invoke();
            return context;
        }

        void OnResize(IntPtr area, int width, int height, IntPtr data)
        {
            Resize?.Invoke(width, height);
        }        

        private void OnRealize(IntPtr area)
        {
            Realize?.Invoke();
        }

        private void OnUnRealize(IntPtr area)
        {
            Unrealize?.Invoke();
        }

        private bool OnRender(IntPtr area, IntPtr context)
        {
            Render?.Invoke();
            return true;
        }
    }
}