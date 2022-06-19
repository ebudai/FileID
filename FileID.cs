#if Windows
using OS = Budaisoft.FileSystem.FileIDWindows;
#else
using OS = Budaisoft.FileSystem.FileIDPosix;
#endif

using System.IO;

namespace Budaisoft.FileSystem
{
    public static class FileID
    {
        public static ulong GetUniqueFileID(string path) => OS.GetUniqueFileID(path);
        public static ulong GetUniqueFileID(FileSystemInfo file) => GetUniqueFileID(file.FullName);
    }
}
