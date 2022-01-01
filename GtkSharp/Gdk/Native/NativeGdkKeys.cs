using System;
using System.Runtime.InteropServices;
using GtkSharp.Gdk.Types;
using GtkSharp.Glib.Native.Types;
using GtkSharp.Pango.Types;

namespace GtkSharp.Gdk.Native
{
    public static class NativeGdkKeys
    {        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong gdk_keymap_get_type();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_keymap_get_default();
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GObjectPointer gdk_keymap_get_for_display(GObjectPointer display); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint gdk_keymap_lookup_key(GObjectPointer keymap, ref GdkKeymapKey key);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe bool gdk_keymap_translate_keyboard_state(GObjectPointer keymap, uint hardware_keycode, GdkModifierType state, int group, uint* keyval, int* effective_group, int* level, GdkModifierType* consumed_modifiers);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe bool gdk_keymap_get_entries_for_keyval(GObjectPointer keymap, uint keyval, GdkKeymapKey** keys, out int n_keys);

        public static unsafe bool gdk_keymap_get_entries_for_keyval(GObjectPointer keymap, uint keyval, out GdkKeymapKey[] keys)
        {
            keys = null;

            GdkKeymapKey* k = null;

            if (gdk_keymap_get_entries_for_keyval(keymap, keyval, &k, out int count)) 
            {
                keys = new GdkKeymapKey[count];

                for(int i = 0; i < count; i++)
                {
                    GdkKeymapKey key = new GdkKeymapKey();
                    key.group = k[i].group;
                    key.keycode = k[i].keycode;
                    key.level = k[i].level;
                    keys[i] = key;
                }

                GLib.Native.GLibLib.g_free(k);
                return true;
            }

            return false;
        }
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe bool gdk_keymap_get_entries_for_keycode(GObjectPointer keymap, uint hardware_keycode, GdkKeymapKey** keys, uint** keyvals, int* n_entries); 
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern PangoDirection gdk_keymap_get_direction(GObjectPointer keymap);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_keymap_have_bidi_layouts(GObjectPointer keymap);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_keymap_get_caps_lock_state(GObjectPointer keymap);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_keymap_get_num_lock_state(GObjectPointer keymap);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_keymap_get_scroll_lock_state(GObjectPointer keymap);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint gdk_keymap_get_modifier_state(GObjectPointer keymap);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_keymap_add_virtual_modifiers(GObjectPointer keymap, ref GdkModifierType state);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_keymap_map_virtual_modifiers(GObjectPointer keymap, ref GdkModifierType state);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern GdkModifierType gdk_keymap_get_modifier_mask(GObjectPointer keymap, GdkModifierIntent intent);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gdk_keyval_name(uint keyval);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint gdk_keyval_from_name(string keyval_name);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gdk_keyval_convert_case(uint symbol, ref uint lower, ref uint upper);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint gdk_keyval_to_upper(uint keyval);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint gdk_keyval_to_lower(uint keyval);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_keyval_is_upper(uint keyval);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gdk_keyval_is_lower(uint keyval);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint gdk_keyval_to_unicode(uint keyval);
        
        [DllImport(GtkSharpBase.NATIVELIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint gdk_unicode_to_keyval(uint wc);
    }
}