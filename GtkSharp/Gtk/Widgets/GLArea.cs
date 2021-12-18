using System;
using GtkSharp.Gtk.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gdk.Native.Types;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class GLArea : Widget
    {
        private GEventHandler<GLAreaCreateContextCallback,GLAreaCreateContextEvent> createContextHandler = new GEventHandler<GLAreaCreateContextCallback, GLAreaCreateContextEvent>();
        private GEventHandler<GLAreaResizeCallback,GLAreaResizeEvent> resizeHandler = new GEventHandler<GLAreaResizeCallback, GLAreaResizeEvent>();
        private GEventHandler<GLAreaRenderCallback,GLAreaRenderEvent> renderHandler = new GEventHandler<GLAreaRenderCallback, GLAreaRenderEvent>();
        
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

        public bool Hasalpha
        {
            get
            {
                return GetHasAlpha();
            }
            set
            {
                SetHasAlpha(value);
            }
        }

        public bool HasDepthBuffer
        {
            get
            {
                return GetHasDepthBuffer();
            }
            set
            {
                SetHasDepthBuffer(value);
            }
        }

        public bool HasStencilBuffer
        {
            get
            {
                return GetHasStencilBuffer();
            }
            set
            {
                SetHasStencilBuffer(value);
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
        
        private bool GetHasAlpha()
        {
            if(handle.IsNullPointer)
                return false;

            bool hasAlpha;
            hasAlpha = NativeGLArea.gtk_gl_area_get_has_alpha(handle);
            return hasAlpha;
        }
        
        private void SetHasAlpha(bool hasAlpha)
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.gtk_gl_area_set_has_alpha(handle, hasAlpha);
        }
        
        private bool GetHasDepthBuffer()
        {
            if(handle.IsNullPointer)
                return false;

            bool hasDepthBuffer = NativeGLArea.gtk_gl_area_get_has_depth_buffer(handle);
            return hasDepthBuffer;                
        }
        
        private void SetHasDepthBuffer(bool hasDepthBuffer)
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.gtk_gl_area_set_has_depth_buffer(handle, hasDepthBuffer);
        }
        
        private bool GetHasStencilBuffer()
        {
            if(handle.IsNullPointer)
                return false;

            bool hasStencilBuffer;
            hasStencilBuffer = NativeGLArea.gtk_gl_area_get_has_stencil_buffer(handle);
            return hasStencilBuffer;
        }
        
        private void SetHasStencilBuffer(bool hasStencilBuffer)
        {
            if(handle.IsNullPointer)
                return;

            NativeGLArea.gtk_gl_area_set_has_stencil_buffer(handle, hasStencilBuffer);
        }

        private bool GetAutoRender()
        {
            if(handle.IsNullPointer)
                return false;

            bool auto = NativeGLArea.gtk_gl_area_get_auto_render(handle);
            return auto;
        }

        private void SetAutoRender(bool auto)
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

        bool OnRender(IntPtr area, IntPtr context)
        {
            Render?.Invoke();
            return true;
        }
    }
}