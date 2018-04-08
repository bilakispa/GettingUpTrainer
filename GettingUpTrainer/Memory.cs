using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GettingUpTrainer
{
    class Memory
    {
        private static IntPtr pHandle = IntPtr.Zero;

        public static IntPtr OpenProcess(int pId)
        {
            pHandle = Imports.OpenProcess(Imports.PROCESS_VM_READ | Imports.PROCESS_VM_WRITE | Imports.PROCESS_VM_OPERATION, false, pId);
            return pHandle;
        }

        public static IntPtr GetHandle()
        {
            return pHandle;
        }

        public static void CloseProcess()
        {
            Imports.CloseHandle(pHandle);
        }

        public static T Read<T>(Int32 address)
        {
            byte[] Buffer = new byte[Marshal.SizeOf(typeof(T))];
            IntPtr ByteRead;
            Imports.ReadProcessMemory(pHandle, address, Buffer, (uint)Buffer.Length, out ByteRead);

            // Get Struct from Buffer
            GCHandle handle = GCHandle.Alloc(Buffer, GCHandleType.Pinned);
            T stuff = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            handle.Free();
            // Return
            return stuff;
        }

        public static bool Write<T>(Int64 address, T t)
        {
            Byte[] Buffer = new Byte[Marshal.SizeOf(typeof(T))];
            GCHandle handle = GCHandle.Alloc(t, GCHandleType.Pinned);
            Marshal.Copy(handle.AddrOfPinnedObject(), Buffer, 0, Buffer.Length);
            handle.Free();

            uint oldProtect;
            Imports.VirtualProtectEx(pHandle, (IntPtr)address, (uint)Buffer.Length, Imports.PAGE_READWRITE, out oldProtect);
            IntPtr ptrBytesWritten;
            return Imports.WriteProcessMemory(pHandle, address, Buffer, (uint)Buffer.Length, out ptrBytesWritten);
        }
       
        public static string ReadString(Int32 address, UInt32 _Size)
        {
            byte[] buffer = new byte[_Size];
            IntPtr BytesRead;

            Imports.ReadProcessMemory(pHandle, address, buffer, _Size, out BytesRead);
            return Encoding.ASCII.GetString(buffer);
        }

        public static bool IsValid(Int64 Address)
        {
            return (Address >= 0x400000 && Address < 0x7FFE88EFFFFF);
        }
    }
}
