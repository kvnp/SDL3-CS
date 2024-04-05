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
    public partial struct SDL_Gamepad
    {
    }

    public enum SDL_GamepadType
    {
        SDL_GAMEPAD_TYPE_UNKNOWN = 0,
        SDL_GAMEPAD_TYPE_STANDARD,
        SDL_GAMEPAD_TYPE_XBOX360,
        SDL_GAMEPAD_TYPE_XBOXONE,
        SDL_GAMEPAD_TYPE_PS3,
        SDL_GAMEPAD_TYPE_PS4,
        SDL_GAMEPAD_TYPE_PS5,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_PRO,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_LEFT,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_RIGHT,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_PAIR,
        SDL_GAMEPAD_TYPE_MAX,
    }

    public enum SDL_GamepadButton
    {
        SDL_GAMEPAD_BUTTON_INVALID = -1,
        SDL_GAMEPAD_BUTTON_SOUTH,
        SDL_GAMEPAD_BUTTON_EAST,
        SDL_GAMEPAD_BUTTON_WEST,
        SDL_GAMEPAD_BUTTON_NORTH,
        SDL_GAMEPAD_BUTTON_BACK,
        SDL_GAMEPAD_BUTTON_GUIDE,
        SDL_GAMEPAD_BUTTON_START,
        SDL_GAMEPAD_BUTTON_LEFT_STICK,
        SDL_GAMEPAD_BUTTON_RIGHT_STICK,
        SDL_GAMEPAD_BUTTON_LEFT_SHOULDER,
        SDL_GAMEPAD_BUTTON_RIGHT_SHOULDER,
        SDL_GAMEPAD_BUTTON_DPAD_UP,
        SDL_GAMEPAD_BUTTON_DPAD_DOWN,
        SDL_GAMEPAD_BUTTON_DPAD_LEFT,
        SDL_GAMEPAD_BUTTON_DPAD_RIGHT,
        SDL_GAMEPAD_BUTTON_MISC1,
        SDL_GAMEPAD_BUTTON_RIGHT_PADDLE1,
        SDL_GAMEPAD_BUTTON_LEFT_PADDLE1,
        SDL_GAMEPAD_BUTTON_RIGHT_PADDLE2,
        SDL_GAMEPAD_BUTTON_LEFT_PADDLE2,
        SDL_GAMEPAD_BUTTON_TOUCHPAD,
        SDL_GAMEPAD_BUTTON_MISC2,
        SDL_GAMEPAD_BUTTON_MISC3,
        SDL_GAMEPAD_BUTTON_MISC4,
        SDL_GAMEPAD_BUTTON_MISC5,
        SDL_GAMEPAD_BUTTON_MISC6,
        SDL_GAMEPAD_BUTTON_MAX,
    }

    public enum SDL_GamepadButtonLabel
    {
        SDL_GAMEPAD_BUTTON_LABEL_UNKNOWN,
        SDL_GAMEPAD_BUTTON_LABEL_A,
        SDL_GAMEPAD_BUTTON_LABEL_B,
        SDL_GAMEPAD_BUTTON_LABEL_X,
        SDL_GAMEPAD_BUTTON_LABEL_Y,
        SDL_GAMEPAD_BUTTON_LABEL_CROSS,
        SDL_GAMEPAD_BUTTON_LABEL_CIRCLE,
        SDL_GAMEPAD_BUTTON_LABEL_SQUARE,
        SDL_GAMEPAD_BUTTON_LABEL_TRIANGLE,
    }

    public enum SDL_GamepadAxis
    {
        SDL_GAMEPAD_AXIS_INVALID = -1,
        SDL_GAMEPAD_AXIS_LEFTX,
        SDL_GAMEPAD_AXIS_LEFTY,
        SDL_GAMEPAD_AXIS_RIGHTX,
        SDL_GAMEPAD_AXIS_RIGHTY,
        SDL_GAMEPAD_AXIS_LEFT_TRIGGER,
        SDL_GAMEPAD_AXIS_RIGHT_TRIGGER,
        SDL_GAMEPAD_AXIS_MAX,
    }

    public enum SDL_GamepadBindingType
    {
        SDL_GAMEPAD_BINDTYPE_NONE = 0,
        SDL_GAMEPAD_BINDTYPE_BUTTON,
        SDL_GAMEPAD_BINDTYPE_AXIS,
        SDL_GAMEPAD_BINDTYPE_HAT,
    }

    public partial struct SDL_GamepadBinding
    {
        public SDL_GamepadBindingType input_type;

        [NativeTypeName("__AnonymousRecord_SDL_gamepad_L184_C5")]
        public _input_e__Union input;

        public SDL_GamepadBindingType output_type;

        [NativeTypeName("__AnonymousRecord_SDL_gamepad_L204_C5")]
        public _output_e__Union output;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _input_e__Union
        {
            [FieldOffset(0)]
            public int button;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_SDL_gamepad_L188_C9")]
            public _axis_e__Struct axis;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_SDL_gamepad_L195_C9")]
            public _hat_e__Struct hat;

            public partial struct _axis_e__Struct
            {
                public int axis;

                public int axis_min;

                public int axis_max;
            }

            public partial struct _hat_e__Struct
            {
                public int hat;

                public int hat_mask;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _output_e__Union
        {
            [FieldOffset(0)]
            public SDL_GamepadButton button;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_SDL_gamepad_L208_C9")]
            public _axis_e__Struct axis;

            public partial struct _axis_e__Struct
            {
                public SDL_GamepadAxis axis;

                public int axis_min;

                public int axis_max;
            }
        }
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AddGamepadMapping([NativeTypeName("const char *")] sbyte* mapping);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AddGamepadMappingsFromIO(SDL_IOStream* src, [NativeTypeName("SDL_bool")] int closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AddGamepadMappingsFromFile([NativeTypeName("const char *")] sbyte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_ReloadGamepadMappings();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** SDL_GetGamepadMappings(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_GetGamepadMappingForGUID([NativeTypeName("SDL_JoystickGUID")] SDL_GUID guid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_GetGamepadMapping(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetGamepadMapping([NativeTypeName("SDL_JoystickID")] uint instance_id, [NativeTypeName("const char *")] sbyte* mapping);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_bool")]
        public static extern int SDL_HasGamepad();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickID *")]
        public static extern uint* SDL_GetGamepads(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_bool")]
        public static extern int SDL_IsGamepad([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadInstanceName([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadInstancePath([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetGamepadInstancePlayerIndex([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickGUID")]
        public static extern SDL_GUID SDL_GetGamepadInstanceGUID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadInstanceVendor([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadInstanceProduct([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadInstanceProductVersion([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadType SDL_GetGamepadInstanceType([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadType SDL_GetRealGamepadInstanceType([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_GetGamepadInstanceMapping([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Gamepad* SDL_OpenGamepad([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Gamepad* SDL_GetGamepadFromInstanceID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Gamepad* SDL_GetGamepadFromPlayerIndex(int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_GetGamepadProperties(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickID")]
        public static extern uint SDL_GetGamepadInstanceID(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadName(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadPath(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadType SDL_GetGamepadType(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadType SDL_GetRealGamepadType(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetGamepadPlayerIndex(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetGamepadPlayerIndex(SDL_Gamepad* gamepad, int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadVendor(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadProduct(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadProductVersion(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadFirmwareVersion(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadSerial(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern ulong SDL_GetGamepadSteamHandle(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_JoystickConnectionState SDL_GetGamepadConnectionState(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PowerState SDL_GetGamepadPowerInfo(SDL_Gamepad* gamepad, int* percent);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_bool")]
        public static extern int SDL_GamepadConnected(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Joystick* SDL_GetGamepadJoystick(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetGamepadEventsEnabled([NativeTypeName("SDL_bool")] int enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_bool")]
        public static extern int SDL_GamepadEventsEnabled();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadBinding** SDL_GetGamepadBindings(SDL_Gamepad* gamepad, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UpdateGamepads();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadType SDL_GetGamepadTypeFromString([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadStringForType(SDL_GamepadType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadAxis SDL_GetGamepadAxisFromString([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadStringForAxis(SDL_GamepadAxis axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_bool")]
        public static extern int SDL_GamepadHasAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Sint16")]
        public static extern short SDL_GetGamepadAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadButton SDL_GetGamepadButtonFromString([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadStringForButton(SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_bool")]
        public static extern int SDL_GamepadHasButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint8")]
        public static extern byte SDL_GetGamepadButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadButtonLabel SDL_GetGamepadButtonLabelForType(SDL_GamepadType type, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadButtonLabel SDL_GetGamepadButtonLabel(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumGamepadTouchpads(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumGamepadTouchpadFingers(SDL_Gamepad* gamepad, int touchpad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetGamepadTouchpadFinger(SDL_Gamepad* gamepad, int touchpad, int finger, [NativeTypeName("Uint8 *")] byte* state, float* x, float* y, float* pressure);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_bool")]
        public static extern int SDL_GamepadHasSensor(SDL_Gamepad* gamepad, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetGamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type, [NativeTypeName("SDL_bool")] int enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_bool")]
        public static extern int SDL_GamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GetGamepadSensorDataRate(SDL_Gamepad* gamepad, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetGamepadSensorData(SDL_Gamepad* gamepad, SDL_SensorType type, float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RumbleGamepad(SDL_Gamepad* gamepad, [NativeTypeName("Uint16")] ushort low_frequency_rumble, [NativeTypeName("Uint16")] ushort high_frequency_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RumbleGamepadTriggers(SDL_Gamepad* gamepad, [NativeTypeName("Uint16")] ushort left_rumble, [NativeTypeName("Uint16")] ushort right_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetGamepadLED(SDL_Gamepad* gamepad, [NativeTypeName("Uint8")] byte red, [NativeTypeName("Uint8")] byte green, [NativeTypeName("Uint8")] byte blue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SendGamepadEffect(SDL_Gamepad* gamepad, [NativeTypeName("const void *")] void* data, int size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CloseGamepad(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadAppleSFSymbolsNameForButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadAppleSFSymbolsNameForAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

        [NativeTypeName("#define SDL_PROP_GAMEPAD_CAP_MONO_LED_BOOLEAN SDL_PROP_JOYSTICK_CAP_MONO_LED_BOOLEAN")]
        public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_MONO_LED_BOOLEAN => "SDL.joystick.cap.mono_led"u8;

        [NativeTypeName("#define SDL_PROP_GAMEPAD_CAP_RGB_LED_BOOLEAN SDL_PROP_JOYSTICK_CAP_RGB_LED_BOOLEAN")]
        public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_RGB_LED_BOOLEAN => "SDL.joystick.cap.rgb_led"u8;

        [NativeTypeName("#define SDL_PROP_GAMEPAD_CAP_PLAYER_LED_BOOLEAN SDL_PROP_JOYSTICK_CAP_PLAYER_LED_BOOLEAN")]
        public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_PLAYER_LED_BOOLEAN => "SDL.joystick.cap.player_led"u8;

        [NativeTypeName("#define SDL_PROP_GAMEPAD_CAP_RUMBLE_BOOLEAN SDL_PROP_JOYSTICK_CAP_RUMBLE_BOOLEAN")]
        public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_RUMBLE_BOOLEAN => "SDL.joystick.cap.rumble"u8;

        [NativeTypeName("#define SDL_PROP_GAMEPAD_CAP_TRIGGER_RUMBLE_BOOLEAN SDL_PROP_JOYSTICK_CAP_TRIGGER_RUMBLE_BOOLEAN")]
        public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_TRIGGER_RUMBLE_BOOLEAN => "SDL.joystick.cap.trigger_rumble"u8;
    }
}
