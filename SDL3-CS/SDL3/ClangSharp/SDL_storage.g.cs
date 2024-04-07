/*
  <auto-generated/>
  C# bindings for Simple DirectMedia Layer.
  Original copyright notice of input files:

  Simple DirectMedia Layer
  Copyright (C) 1997-2024 Sam Lantinga <slouken@libsdl.org>

  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.
*/

using System;
using System.Runtime.InteropServices;

namespace SDL
{
    public unsafe partial struct SDL_StorageInterface
    {
        [NativeTypeName("int (*)(void *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, int> close;

        [NativeTypeName("SDL_bool (*)(void *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, SDL_bool> ready;

        [NativeTypeName("int (*)(void *, const char *, SDL_EnumerateDirectoryCallback, void *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, byte*, delegate* unmanaged[Cdecl]<IntPtr, byte*, byte*, int>, IntPtr, int> enumerate;

        [NativeTypeName("int (*)(void *, const char *, SDL_PathInfo *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, byte*, SDL_PathInfo*, int> info;

        [NativeTypeName("int (*)(void *, const char *, void *, Uint64)")]
        public delegate* unmanaged[Cdecl]<IntPtr, byte*, IntPtr, ulong, int> read_file;

        [NativeTypeName("int (*)(void *, const char *, const void *, Uint64)")]
        public delegate* unmanaged[Cdecl]<IntPtr, byte*, IntPtr, ulong, int> write_file;

        [NativeTypeName("int (*)(void *, const char *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, byte*, int> mkdir;

        [NativeTypeName("int (*)(void *, const char *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, byte*, int> remove;

        [NativeTypeName("int (*)(void *, const char *, const char *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, byte*, byte*, int> rename;

        [NativeTypeName("Uint64 (*)(void *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, ulong> space_remaining;
    }

    public partial struct SDL_Storage
    {
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Storage* SDL_OpenTitleStorage([NativeTypeName("const char *")] byte* @override, SDL_PropertiesID props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Storage* SDL_OpenUserStorage([NativeTypeName("const char *")] byte* org, [NativeTypeName("const char *")] byte* app, SDL_PropertiesID props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Storage* SDL_OpenFileStorage([NativeTypeName("const char *")] byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Storage* SDL_OpenStorage([NativeTypeName("const SDL_StorageInterface *")] SDL_StorageInterface* iface, [NativeTypeName("void*")] IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_CloseStorage(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_StorageReady(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetStorageFileSize(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("Uint64 *")] ulong* length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_ReadStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("void*")] IntPtr destination, [NativeTypeName("Uint64")] ulong length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_WriteStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("const void *")] IntPtr source, [NativeTypeName("Uint64")] ulong length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_CreateStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_EnumerateStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("SDL_EnumerateDirectoryCallback")] delegate* unmanaged[Cdecl]<IntPtr, byte*, byte*, int> callback, [NativeTypeName("void*")] IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RemoveStoragePath(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenameStoragePath(SDL_Storage* storage, [NativeTypeName("const char *")] byte* oldpath, [NativeTypeName("const char *")] byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetStoragePathInfo(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, SDL_PathInfo* info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern ulong SDL_GetStorageSpaceRemaining(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern byte** SDL_GlobStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("const char *")] byte* pattern, [NativeTypeName("Uint32")] uint flags, int* count);
    }
}