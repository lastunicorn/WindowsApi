﻿// WindowsApi
// Copyright (C) 2020-2023 Dust in the Wind
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace DustInTheWind.WindowsApi.Fileapi
{
    [Flags]
    public enum FlagsAndAttributes : uint
    {
        NONE = 0x00,

        /// <summary>
        /// The file is read only. Applications can read the file, but cannot write to or delete it.
        /// </summary>
        FILE_ATTRIBUTE_READONLY = 0x1,

        /// <summary>
        /// The file is hidden. Do not include it in an ordinary directory listing.
        /// </summary>
        FILE_ATTRIBUTE_HIDDEN = 0x2,

        /// <summary>
        /// The file is part of or used exclusively by an operating system.
        /// </summary>
        FILE_ATTRIBUTE_SYSTEM = 0x4,

        /// <summary>
        /// The file should be archived. Applications use this attribute to mark files for backup or removal. 
        /// </summary>
        FILE_ATTRIBUTES_ARCHIVE = 0x20,

        /// <summary>
        /// The file does not have other attributes set. This attribute is valid only if used alone.
        /// </summary>
        FILE_ATTRIBUTE_NORMAL = 0x80,

        /// <summary>
        /// The file is being used for temporary storage.
        /// For more information, see the Caching Behavior section of this topic.
        /// </summary>
        FILE_ATTRIBUTE_TEMPORARY = 0x100,

        /// <summary>
        /// The data of a file is not immediately available. This attribute indicates that file data
        /// is physically moved to offline storage. This attribute is used by Remote Storage,
        /// the hierarchical storage management software. Applications should not arbitrarily change
        /// this attribute. 
        /// </summary>
        FILE_ATTRIBUTE_OFFLINE = 0x1000,

        /// <summary>
        /// The file or directory is encrypted. For a file, this means that all data in the file is encrypted.
        /// For a directory, this means that encryption is the default for newly created files and subdirectories.
        /// For more information, see File Encryption.
        ///
        /// This flag has no effect if FILE_ATTRIBUTE_SYSTEM is also specified.
        ///
        /// This flag is not supported on Home, Home Premium, Starter, or ARM editions of Windows.
        /// </summary>
        FILE_ATTRIBUTE_ENCRYPTED = 0x4000,

        /// <summary>
        /// The file data is requested, but it should continue to be located in remote storage.
        /// It should not be transported back to local storage.
        /// This flag is for use by remote storage systems. 
        /// </summary>
        FILE_FLAG_OPEN_NO_CALL = 0x00100000,

        /// <summary>
        /// Normal reparse point processing will not occur; CreateFile will attempt to open the reparse point.
        /// When a file is opened, a file handle is returned, whether or not the filter that controls
        /// the reparse point is operational.
        ///
        /// This flag cannot be used with the CREATE_ALWAYS flag.
        ///
        /// If the file is not a reparse point, then this flag is ignored.
        ///
        /// For more information, see the Remarks section.
        /// </summary>
        FILE_FLAG_OPEN_REPARSE_POINT = 0x00200000,

        /// <summary>
        /// The file or device is being opened with session awareness. If this flag is not specified,
        /// then per-session devices (such as a device using RemoteFX USB Redirection) cannot be opened
        /// by processes running in session 0. This flag has no effect for callers not in session 0.
        /// This flag is supported only on server editions of Windows.
        ///
        /// Windows Server 2008 R2 and Windows Server 2008:  This flag is not supported before Windows Server 2012.
        /// </summary>
        FILE_FLAG_SESSION_AWARE = 0x00800000,

        /// <summary>
        /// Access will occur according to POSIX rules. This includes allowing multiple files with names,
        /// differing only in case, for file systems that support that naming. Use care when using this option,
        /// because files created with this flag may not be accessible by applications that are written
        /// for MS-DOS or 16-bit Windows. 
        /// </summary>
        FILE_FLAG_POSIX_SEMANTICS = 0x01000000,

        /// <summary>
        /// The file is being opened or created for a backup or restore operation.
        /// The system ensures that the calling process overrides file security checks when the process
        /// has SE_BACKUP_NAME and SE_RESTORE_NAME privileges. For more information,
        /// see Changing Privileges in a Token.
        /// 
        /// You must set this flag to obtain a handle to a directory. A directory handle can be passed
        /// to some functions instead of a file handle. For more information, see the Remarks section.
        /// </summary>
        FILE_FLAG_BACKUP_SEMANTICS = 0x02000000,

        /// <summary>
        /// The file is to be deleted immediately after all of its handles are closed, which includes
        /// the specified handle and any other open or duplicated handles.
        /// 
        /// If there are existing open handles to a file, the call fails unless they were all opened
        /// with the FILE_SHARE_DELETE share mode.
        /// 
        /// Subsequent open requests for the file fail, unless the FILE_SHARE_DELETE share mode is specified.
        /// </summary>
        FILE_FLAG_DELETE_ON_CLOSE = 0x04000000,

        /// <summary>
        /// Access is intended to be sequential from beginning to end. The system can use this as a hint to optimize file caching.
        /// This flag should not be used if read-behind (that is, reverse scans) will be used.
        ///
        /// This flag has no effect if the file system does not support cached I/O and FILE_FLAG_NO_BUFFERING.
        ///
        /// For more information, see the Caching Behavior section of this topic.
        /// </summary>
        FILE_FLAG_SEQUENTIAL_SCAN = 0x08000000,

        /// <summary>
        /// Access is intended to be random. The system can use this as a hint to optimize file caching.
        /// This flag has no effect if the file system does not support cached I/O and FILE_FLAG_NO_BUFFERING.
        ///
        /// For more information, see the Caching Behavior section of this topic.
        /// </summary>
        FILE_FLAG_RANDOM_ACCESS = 0x10000000,

        /// <summary>
        /// The file or device is being opened with no system caching for data reads and writes.
        /// This flag does not affect hard disk caching or memory mapped files.
        ///
        /// There are strict requirements for successfully working with files opened with CreateFile
        /// using the FILE_FLAG_NO_BUFFERING flag, for details see File Buffering.
        /// </summary>
        FILE_FLAG_NO_BUFFERING = 0x20000000,

        /// <summary>
        /// The file or device is being opened or created for asynchronous I/O.
        /// When subsequent I/O operations are completed on this handle, the event specified in
        /// the OVERLAPPED structure will be set to the signaled state.
        ///
        /// If this flag is specified, the file can be used for simultaneous read and write operations.
        ///
        /// If this flag is not specified, then I/O operations are serialized, even if the calls to
        /// the read and write functions specify an OVERLAPPED structure.
        ///
        /// For information about considerations when using a file handle created with this flag,
        /// see the Synchronous and Asynchronous I/O Handles section of this topic.
        /// </summary>
        FILE_FLAG_OVERLAPPED = 0x40000000,

        /// <summary>
        /// Write operations will not go through any intermediate cache, they will go directly to disk.
        /// For additional information, see the Caching Behavior section of this topic.
        /// </summary>
        FILE_FLAG_WRITE_THROUGH = 0x80000000
    }
}