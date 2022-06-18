# FileID

call using FileID.GetUniqueFileID(string|FileSystemInfo).

Returns a ulong from the operating system which will be unique only to the current volume.

NOTE on POSIX systems: the resulting long from inode is cast to a ulong.