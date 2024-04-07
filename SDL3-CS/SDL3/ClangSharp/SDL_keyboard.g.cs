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

using System.Runtime.InteropServices;

namespace SDL
{
    public partial struct SDL_Keysym
    {
        public SDL_Scancode scancode;

        public SDL_Keycode sym;

        [NativeTypeName("Uint16")]
        public ushort mod;

        [NativeTypeName("Uint32")]
        public uint unused;
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasKeyboard();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_KeyboardID* SDL_GetKeyboards(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboardInstanceName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetKeyboardInstanceName(SDL_KeyboardID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_GetKeyboardFocus();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const Uint8 *")]
        public static extern byte* SDL_GetKeyboardState(int* numkeys);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ResetKeyboard();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Keymod SDL_GetModState();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetModState(SDL_Keymod modstate);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Keycode SDL_GetKeyFromScancode(SDL_Scancode scancode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Scancode SDL_GetScancodeFromKey(SDL_Keycode key);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetScancodeName(SDL_Scancode scancode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Scancode SDL_GetScancodeFromName([NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetKeyName(SDL_Keycode key);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Keycode SDL_GetKeyFromName([NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_StartTextInput();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_TextInputActive();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_StopTextInput();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ClearComposition();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetTextInputRect([NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasScreenKeyboardSupport();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_ScreenKeyboardShown(SDL_Window* window);
    }
}