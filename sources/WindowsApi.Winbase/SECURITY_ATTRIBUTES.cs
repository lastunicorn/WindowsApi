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
using System.Runtime.InteropServices;

namespace DustInTheWind.WindowsApi.Winbase
{
    /// <summary>
    /// The SECURITY_ATTRIBUTES structure contains the security descriptor for an object
    /// and specifies whether the handle retrieved by specifying this structure is inheritable.
    /// This structure provides security settings for objects created by various functions,
    /// such as CreateFile, CreatePipe, CreateProcess, RegCreateKeyEx, or RegSaveKeyEx.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_ATTRIBUTES
    {
        /// <summary>
        /// The size, in bytes, of this structure. Set this value to the size of the
        /// SECURITY_ATTRIBUTES structure.
        /// </summary>
        public uint nLength;

        /// <summary>
        /// <para>
        /// A pointer to a SECURITY_DESCRIPTOR structure that controls access to the object.
        /// If the value of this member is NULL, the object is assigned the default security
        /// descriptor associated with the access token of the calling process. This is not
        /// the same as granting access to everyone by assigning a NULL discretionary access
        /// control list (DACL). By default, the default DACL in the access token of a process
        /// allows access only to the user represented by the access token.
        /// </para>
        /// </summary>
        public IntPtr lpSecurityDescriptor;

        /// <summary>
        /// A Boolean value that specifies whether the returned handle is inherited when a new
        /// process is created. If this member is TRUE, the new process inherits the handle.
        /// </summary>
        public bool bInheritHandle;
    }
}