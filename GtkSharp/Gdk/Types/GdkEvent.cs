using System;
using System.Runtime.InteropServices;
using GtkSharp.Cairo.Native.Types;

namespace GtkSharp.Gdk.Types
{
    //Untested
    [StructLayout(LayoutKind.Explicit)]
    public struct GdkEvent
    {
        [FieldOffset(0)] public GdkEventType type;
        [FieldOffset(0)] public GdkEventAny any;
        [FieldOffset(0)] public GdkEventExpose expose;
        [FieldOffset(0)] public GdkEventVisibility visibility;
        [FieldOffset(0)] public GdkEventMotion motion;
        [FieldOffset(0)] public GdkEventButton button;
        [FieldOffset(0)] public GdkEventTouch touch;
        [FieldOffset(0)] public GdkEventScroll scroll;
        [FieldOffset(0)] public GdkEventKey key;
        [FieldOffset(0)] public GdkEventCrossing crossing;
        [FieldOffset(0)] public GdkEventFocus focus_change;
        [FieldOffset(0)] public GdkEventConfigure configure;
        [FieldOffset(0)] public GdkEventProperty property;
        [FieldOffset(0)] public GdkEventSelection selection;
        [FieldOffset(0)] public GdkEventOwnerChange owner_change;
        [FieldOffset(0)] public GdkEventProximity proximity;
        [FieldOffset(0)] public GdkEventDND dnd;
        [FieldOffset(0)] public GdkEventWindowState window_state;
        [FieldOffset(0)] public GdkEventSetting setting;
        [FieldOffset(0)] public GdkEventGrabBroken grab_broken;
        [FieldOffset(0)] public GdkEventTouchpadSwipe touchpad_swipe;
        [FieldOffset(0)] public GdkEventTouchpadPinch touchpad_pinch;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventAny
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventExpose
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
        public GdkRectangle area;
        public CairoRegionPointer region;
        public int count; // If non-zero, how many more events follow
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventVisibility
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
        public GdkVisibilityState state;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventTouch
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
        public uint time;
        public double x;
        public double y;
        public IntPtr axes;
        public uint state;
        public IntPtr sequence;
        public bool emulating_pointer;
        public IntPtr device;
        public double x_root;
        public double y_root;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventCrossing
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
        public IntPtr subwindow;
        public uint time;
        public double x;
        public double y;
        public double x_root;
        public double y_root;
        public GdkCrossingMode mode;
        public GdkNotifyType detail;
        public bool focus;
        public uint state;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventFocus
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
        public short inn;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventConfigure
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
        public int x;
        public int y;
        public int width;
        public int height;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventProperty
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
        public IntPtr atom;
        public uint time;
        public uint state;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventSelection
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
        public IntPtr selection;
        public IntPtr target;
        public IntPtr property;
        public uint time;
        public IntPtr requestor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventOwnerChange
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
        public IntPtr owner;
        public GdkOwnerChange reason;
        public IntPtr selection;
        public uint time;
        public uint selection_time;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventProximity
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
        public uint time;
        public IntPtr device;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventSetting
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
        public GdkSettingAction action;
        public IntPtr name;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventWindowState
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
        public GdkWindowState changed_mask;
        public GdkWindowState new_window_state;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventGrabBroken 
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
        public bool keyboard;
        public bool implct;
        public IntPtr grab_window;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventDND 
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
        public IntPtr context;
        public uint time;
        public short x_root;
        public short y_root;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventTouchpadSwipe 
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
        public byte phase;
        public byte n_fingers;
        public uint time;
        public double x;
        public double y;
        public double dx;
        public double dy;
        public double x_root;
        public double y_root;
        public uint state;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventTouchpadPinch 
    {
        public GdkEventType type;
        public IntPtr window;
        public sbyte send_event;
        public byte phase;
        public byte n_fingers;
        public uint time;
        public double x;
        public double y;
        public double dx;
        public double dy;
        public double angle_delta;
        public double scale;
        public double x_root;
        public double y_root;
        public uint state;
    }    
}

