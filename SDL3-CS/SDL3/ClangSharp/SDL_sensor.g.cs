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
    public partial struct SDL_Sensor
    {
    }

    public enum SDL_SensorType
    {
        SDL_SENSOR_INVALID = -1,
        SDL_SENSOR_UNKNOWN,
        SDL_SENSOR_ACCEL,
        SDL_SENSOR_GYRO,
        SDL_SENSOR_ACCEL_L,
        SDL_SENSOR_GYRO_L,
        SDL_SENSOR_ACCEL_R,
        SDL_SENSOR_GYRO_R,
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_SensorID *")]
        public static extern uint* SDL_GetSensors(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetSensorInstanceName([NativeTypeName("SDL_SensorID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_SensorType SDL_GetSensorInstanceType([NativeTypeName("SDL_SensorID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetSensorInstanceNonPortableType([NativeTypeName("SDL_SensorID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Sensor* SDL_OpenSensor([NativeTypeName("SDL_SensorID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Sensor* SDL_GetSensorFromInstanceID([NativeTypeName("SDL_SensorID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_GetSensorProperties(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetSensorName(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_SensorType SDL_GetSensorType(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetSensorNonPortableType(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_SensorID")]
        public static extern uint SDL_GetSensorInstanceID(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetSensorData(SDL_Sensor* sensor, float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CloseSensor(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UpdateSensors();

        [NativeTypeName("#define SDL_STANDARD_GRAVITY 9.80665f")]
        public const float SDL_STANDARD_GRAVITY = 9.80665f;
    }
}
