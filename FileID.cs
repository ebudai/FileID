using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Budaisoft.FileSystem
{
    public static class FileID
    {
        public static ulong GetUniqueFileID(string path) => RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
            ? FileIDWindows.GetUniqueFileID(path)
            : FileIDPosix.GetUniqueFileID(path);        

        public static ulong GetUniqueFileID(FileSystemInfo file) => GetUniqueFileID(file.FullName);
    }
}
