using Mono.Unix;

namespace Budaisoft.FileSystem
{
    internal static class FileIDPosix
    {
        public static ulong GetUniqueFileID(string path)
        {
            var file = new UnixFileInfo(path);
            return (ulong)file.Inode;
        }
    }
}