using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace Pavlov
{
    class MemRead
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadProcessMemory(IntPtr process, IntPtr baseAddress, [Out] byte[] buffer, int size, out IntPtr bytesRead);

        private int processNum;
        private Process curProcess;
        private IntPtr intimacyAddress;
        private IntPtr foodAddress;
        private IntPtr nameAddress;
        private IntPtr idAddress;

        public void GetProcess()
        {
            try
            {
                var prosesses = Process.GetProcessesByName("Ragexe");
                if (processNum >= prosesses.Count()) processNum = 0;
                curProcess = prosesses[processNum++];
            }
            catch
            {
                processNum = 0;
                curProcess = null;
            }
            if (curProcess != null)
            {
                SigScan sigScan = new SigScan { Process = curProcess, DumpSize = 0x5B8D80 };
                intimacyAddress = sigScan.FindAddress(new byte[] { 0x8B, 0x43, 0x07, 0xA3, 0x00, 0x00, 0x00, 0x00, 0x85, 0xFF }, "xxxx????xx", 4);
                foodAddress = intimacyAddress - 0x4;
                nameAddress = intimacyAddress - 0x30;
                idAddress = intimacyAddress - 0xC;
            }
        }

        public GameInfo GetValues()
        {
            try
            {
                return new GameInfo
                {
                    PetName = ReadString(curProcess.Handle, nameAddress),
                    Food = ReadInt(curProcess.Handle, foodAddress),
                    Intimacy = ReadInt(curProcess.Handle, intimacyAddress),
                    PetId = ReadUInt(curProcess.Handle, idAddress)
                };
            }
            catch
            {
                return null;
            }
        }

        private static string ReadString(IntPtr process, IntPtr baseAddress)
        {
            var buffer = new byte[8];
            ReadProcessMemory(process, baseAddress, buffer, 8, out IntPtr bytesRead);
            return System.Text.Encoding.Default.GetString(buffer).Replace("\0", string.Empty);
        }

        private static int ReadInt(IntPtr process, IntPtr baseAddress)
        {
            var buffer = new byte[4];
            ReadProcessMemory(process, baseAddress, buffer, 4, out IntPtr bytesRead);
            return BitConverter.ToInt32(buffer, 0);
        }

        private static uint ReadUInt(IntPtr process, IntPtr baseAddress)
        {
            var buffer = new byte[4];
            ReadProcessMemory(process, baseAddress, buffer, 4, out IntPtr bytesRead);
            return BitConverter.ToUInt32(buffer, 0);
        }
    }
}
