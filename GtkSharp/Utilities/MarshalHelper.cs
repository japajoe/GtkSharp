using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GtkSharp.Utilities
{
    /// <summary>
    /// Contains extra marshalling utilities that aren't available in the normal Marshal class.
    /// </summary>
    public static class MarshalHelper
    {
        /// <summary>
        /// Marshals a pointer to a null-terminated byte array to a new <c>System.String</c>.
        /// This method supports OpenTK and is not intended to be called by user code.
        /// </summary>
        /// <param name="ptr">A pointer to a null-terminated byte array.</param>
        /// <returns>
        /// A <c>System.String</c> with the data from <paramref name="ptr" />.
        /// </returns>
        public static string MarshalPtrToString(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                throw new ArgumentException("ptr");
            }

            unsafe
            {
                var str = (sbyte*)ptr;
                var len = 0;
                while (*str != 0)
                {
                    ++len;
                    ++str;
                }

                return new string((sbyte*)ptr, 0, len, Encoding.UTF8);
            }
        }

        /// <summary>
        /// Marshal a <c>System.String</c> to unmanaged memory.
        /// The resulting string is encoded in UTF8 and must be freed
        /// with <c>FreeStringPtr</c>.
        /// </summary>
        /// <param name="str">The <c>System.String</c> to marshal.</param>
        /// <returns>
        /// An unmanaged pointer containing the marshaled string.
        /// This pointer must be freed with <c>FreeStringPtr</c>.
        /// </returns>
        public static IntPtr MarshalStringToPtr(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return IntPtr.Zero;
            }

            // Allocate a buffer big enough to hold the marshaled string.
            // GetMaxByteCount() appears to allocate space for the final NUL
            // character, but allocate an extra one just in case (who knows
            // what old Mono version would do here.)
            var maxCount = Encoding.UTF8.GetMaxByteCount(str.Length) + 1;
            var ptr = Marshal.AllocHGlobal(maxCount);
            if (ptr == IntPtr.Zero)
            {
                throw new OutOfMemoryException();
            }

            // Pin the managed string and convert it to UTF8 using
            // the pointer overload of System.Encoding.UTF8.GetBytes().
            unsafe
            {
                fixed (char* pstr = str)
                {
                    var actualCount = Encoding.UTF8.GetBytes(pstr, str.Length, (byte*)ptr, maxCount);
                    Marshal.WriteByte(ptr, actualCount, 0); // Append '\0' at the end of the string
                    return ptr;
                }
            }
        }

        public static IntPtr MarshalStructureToPtr<T>(T v) where T : struct
        {
            int size = Marshal.SizeOf(v);            

            var ptr = Marshal.AllocHGlobal(size);

            if (ptr == IntPtr.Zero)
            {
                throw new OutOfMemoryException();
            }

            Marshal.StructureToPtr(v, ptr, false);
            
            return ptr;
        }

        public static IntPtr MarshalByteArrayToPtr(byte[] bytes)
        {
            if(bytes == null)
                return IntPtr.Zero;
            if(bytes.Length == 0)
                return IntPtr.Zero;

            var ptr = Marshal.AllocHGlobal(bytes.Length);

            if (ptr == IntPtr.Zero)
            {
                throw new OutOfMemoryException();
            }

            unsafe
            {
                fixed (byte* bptr = bytes)
                {
                    Marshal.Copy(bytes, 0, ptr, bytes.Length);                    
                    return ptr;
                }
            }                        
        }

        /// <summary>
        /// Frees a marshaled string that allocated by <c>MarshalStringToPtr</c>.
        /// </summary>
        /// <param name="ptr">An unmanaged pointer allocated with <c>MarshalStringToPtr</c>.</param>
        public static void FreeStringPtr(IntPtr ptr)
        {
            Marshal.FreeHGlobal(ptr);
        }

        public static void FreePtr(IntPtr ptr)
        {
            Marshal.FreeHGlobal(ptr);
        }

        /// <summary>
        /// Marshals a <c>System.String</c> array to unmanaged memory by calling
        /// Marshal.AllocHGlobal for each element.
        /// </summary>
        /// <returns>An unmanaged pointer to an array of null-terminated strings.</returns>
        /// <param name="strArray">The string array to marshal.</param>
        public static IntPtr MarshalStringArrayToPtr(string[] strArray)
        {
            var ptr = IntPtr.Zero;
            if (strArray != null && strArray.Length != 0)
            {
                ptr = Marshal.AllocHGlobal(strArray.Length * IntPtr.Size);
                if (ptr == IntPtr.Zero)
                {
                    throw new OutOfMemoryException();
                }

                var i = 0;
                try
                {
                    for (i = 0; i < strArray.Length; i++)
                    {
                        var str = MarshalStringToPtr(strArray[i]);
                        Marshal.WriteIntPtr(ptr, i * IntPtr.Size, str);
                    }
                }
                catch (OutOfMemoryException)
                {
                    for (i = i - 1; i >= 0; --i)
                    {
                        Marshal.FreeHGlobal(Marshal.ReadIntPtr(ptr, i * IntPtr.Size));
                    }

                    Marshal.FreeHGlobal(ptr);

                    throw;
                }
            }

            return ptr;
        }

        public static IntPtr MarshalStructureArrayToPtr<T>(T[] array) where T : struct
        {
            int size = Marshal.SizeOf<T>();

            var ptr = IntPtr.Zero;
            if (array != null && array.Length != 0)
            {
                //ptr = Marshal.AllocHGlobal(array.Length * IntPtr.Size);
                ptr = Marshal.AllocHGlobal(array.Length * size);
                
                if (ptr == IntPtr.Zero)
                {
                    throw new OutOfMemoryException();
                }

                int i = 0;

                unsafe
                {
                    int offset = 0;
                    for(i = 0; i < array.Length; i++)
                    {
                        var structure = MarshalStructureToPtr<T>(array[i]);
                        void* p = structure.ToPointer();
                        byte* bytes = (byte*)p;

                        for(int j = 0; j < size; j++)
                        {
                            Marshal.WriteByte(ptr, offset, bytes[j]);
                        }
                        
                        offset += size;

                        Marshal.FreeHGlobal(structure);
                    }
                }
                
                // try
                // {
                //     for (i = 0; i < array.Length; i++)
                //     {
                //         var str = MarshalStructureToPtr<T>(array[i]);
                //         Marshal.WriteIntPtr(ptr, i * IntPtr.Size, str);
                //     }
                // }
                // catch (OutOfMemoryException)
                // {
                //     for (i = i - 1; i >= 0; --i)
                //     {
                //         Marshal.FreeHGlobal(Marshal.ReadIntPtr(ptr, i * IntPtr.Size));
                //     }

                //     Marshal.FreeHGlobal(ptr);

                //     throw;
                // }
            }

            return ptr;

        }

        /// <summary>
        /// Frees a marshaled string that allocated by <c>MarshalStringArrayToPtr</c>.
        /// </summary>
        /// <param name="ptr">An unmanaged pointer allocated with <c>MarshalStringArrayToPtr</c>.</param>
        /// <param name="length">The length of the string array.</param>
        public static void FreeStringArrayPtr(IntPtr ptr, int length)
        {
            for (var i = 0; i < length; i++)
            {
                Marshal.FreeHGlobal(Marshal.ReadIntPtr(ptr, i * IntPtr.Size));
            }

            Marshal.FreeHGlobal(ptr);
        }

        public static unsafe String MarshalUnsafeCStringToString(IntPtr ptr, Encoding encoding) 
        {
            void *rawPointer = ptr.ToPointer();
            if (rawPointer == null) 
                return string.Empty;

            char* unsafeCString = (char*)rawPointer;

            int lengthOfCString = 0;
            while (unsafeCString[lengthOfCString] != '\0') 
            {
                lengthOfCString++;
            }

            // now that we have the length of the string, let's get its size in bytes
            int lengthInBytes = encoding.GetByteCount(unsafeCString, lengthOfCString);
            byte[] asByteArray = new byte[lengthInBytes];

            fixed (byte *ptrByteArray = asByteArray) 
            {
                encoding.GetBytes(unsafeCString, lengthOfCString, ptrByteArray, lengthInBytes);
            }

            // now get the string
            return encoding.GetString(asByteArray);
        }        
    }
}