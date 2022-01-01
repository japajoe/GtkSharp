using System;
using GtkSharp.Gdk.Native;
using GtkSharp.Utilities;

namespace GtkSharp.Gdk.Types
{    
    public static class GdkKeyval
    {        
        public static string GetName(uint keyval)
        {
            IntPtr ptr = NativeGdkKeys.gdk_keyval_name(keyval);
            if(ptr == IntPtr.Zero)
                return string.Empty;
            string s = MarshalHelper.MarshalPtrToString(ptr);
            return s;
        }
        
        public static uint GetFromName(string keyvalName)
        {
            return NativeGdkKeys.gdk_keyval_from_name(keyvalName);
        }
        
        public static void ConvertCase(uint symbol, ref uint lower, ref uint upper)
        {
            NativeGdkKeys.gdk_keyval_convert_case(symbol, ref lower, ref upper);
        }
        
        public static uint ToUpper(uint keyval)
        {
            return NativeGdkKeys.gdk_keyval_to_upper(keyval);
        }
        
        public static uint ToLower(uint keyval)
        {
            return NativeGdkKeys.gdk_keyval_to_lower(keyval);
        }
        
        public static bool IsUpper(uint keyval)
        {
            return NativeGdkKeys.gdk_keyval_is_upper(keyval);
        }
        
        public static bool IsLower(uint keyval)
        {
            return NativeGdkKeys.gdk_keyval_is_lower(keyval);
        }
        
        public static uint ToUnicode(uint keyval)
        {
            return NativeGdkKeys.gdk_keyval_to_unicode(keyval);
        }
        
        public static uint ToKeyval(uint wideCharacter)
        {
            return NativeGdkKeys.gdk_unicode_to_keyval(wideCharacter);
        }

        public static char ToUnicodeChar(uint keyval)
        {
            uint unicode = NativeGdkKeys.gdk_keyval_to_unicode(keyval);
            return Convert.ToChar(unicode);
        }
    }
}