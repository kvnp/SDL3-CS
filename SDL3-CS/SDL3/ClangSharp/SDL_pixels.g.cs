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

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static SDL.SDL_ArrayOrder;
using static SDL.SDL_BitmapOrder;
using static SDL.SDL_ChromaLocation;
using static SDL.SDL_ColorPrimaries;
using static SDL.SDL_ColorRange;
using static SDL.SDL_ColorType;
using static SDL.SDL_MatrixCoefficients;
using static SDL.SDL_PackedLayout;
using static SDL.SDL_PackedOrder;
using static SDL.SDL_PixelType;
using static SDL.SDL_TransferCharacteristics;

namespace SDL
{
    public enum SDL_PixelType
    {
        SDL_PIXELTYPE_UNKNOWN,
        SDL_PIXELTYPE_INDEX1,
        SDL_PIXELTYPE_INDEX4,
        SDL_PIXELTYPE_INDEX8,
        SDL_PIXELTYPE_PACKED8,
        SDL_PIXELTYPE_PACKED16,
        SDL_PIXELTYPE_PACKED32,
        SDL_PIXELTYPE_ARRAYU8,
        SDL_PIXELTYPE_ARRAYU16,
        SDL_PIXELTYPE_ARRAYU32,
        SDL_PIXELTYPE_ARRAYF16,
        SDL_PIXELTYPE_ARRAYF32,
        SDL_PIXELTYPE_INDEX2,
    }

    public enum SDL_BitmapOrder
    {
        SDL_BITMAPORDER_NONE,
        SDL_BITMAPORDER_4321,
        SDL_BITMAPORDER_1234,
    }

    public enum SDL_PackedOrder
    {
        SDL_PACKEDORDER_NONE,
        SDL_PACKEDORDER_XRGB,
        SDL_PACKEDORDER_RGBX,
        SDL_PACKEDORDER_ARGB,
        SDL_PACKEDORDER_RGBA,
        SDL_PACKEDORDER_XBGR,
        SDL_PACKEDORDER_BGRX,
        SDL_PACKEDORDER_ABGR,
        SDL_PACKEDORDER_BGRA,
    }

    public enum SDL_ArrayOrder
    {
        SDL_ARRAYORDER_NONE,
        SDL_ARRAYORDER_RGB,
        SDL_ARRAYORDER_RGBA,
        SDL_ARRAYORDER_ARGB,
        SDL_ARRAYORDER_BGR,
        SDL_ARRAYORDER_BGRA,
        SDL_ARRAYORDER_ABGR,
    }

    public enum SDL_PackedLayout
    {
        SDL_PACKEDLAYOUT_NONE,
        SDL_PACKEDLAYOUT_332,
        SDL_PACKEDLAYOUT_4444,
        SDL_PACKEDLAYOUT_1555,
        SDL_PACKEDLAYOUT_5551,
        SDL_PACKEDLAYOUT_565,
        SDL_PACKEDLAYOUT_8888,
        SDL_PACKEDLAYOUT_2101010,
        SDL_PACKEDLAYOUT_1010102,
    }

    [NativeTypeName("int")]
    public enum SDL_PixelFormatEnum : uint
    {
        SDL_PIXELFORMAT_UNKNOWN,
        SDL_PIXELFORMAT_INDEX1LSB = ((1 << 28) | ((SDL_PIXELTYPE_INDEX1) << 24) | ((SDL_BITMAPORDER_4321) << 20) | ((0) << 16) | ((1) << 8) | ((0) << 0)),
        SDL_PIXELFORMAT_INDEX1MSB = ((1 << 28) | ((SDL_PIXELTYPE_INDEX1) << 24) | ((SDL_BITMAPORDER_1234) << 20) | ((0) << 16) | ((1) << 8) | ((0) << 0)),
        SDL_PIXELFORMAT_INDEX2LSB = ((1 << 28) | ((SDL_PIXELTYPE_INDEX2) << 24) | ((SDL_BITMAPORDER_4321) << 20) | ((0) << 16) | ((2) << 8) | ((0) << 0)),
        SDL_PIXELFORMAT_INDEX2MSB = ((1 << 28) | ((SDL_PIXELTYPE_INDEX2) << 24) | ((SDL_BITMAPORDER_1234) << 20) | ((0) << 16) | ((2) << 8) | ((0) << 0)),
        SDL_PIXELFORMAT_INDEX4LSB = ((1 << 28) | ((SDL_PIXELTYPE_INDEX4) << 24) | ((SDL_BITMAPORDER_4321) << 20) | ((0) << 16) | ((4) << 8) | ((0) << 0)),
        SDL_PIXELFORMAT_INDEX4MSB = ((1 << 28) | ((SDL_PIXELTYPE_INDEX4) << 24) | ((SDL_BITMAPORDER_1234) << 20) | ((0) << 16) | ((4) << 8) | ((0) << 0)),
        SDL_PIXELFORMAT_INDEX8 = ((1 << 28) | ((SDL_PIXELTYPE_INDEX8) << 24) | ((0) << 20) | ((0) << 16) | ((8) << 8) | ((1) << 0)),
        SDL_PIXELFORMAT_RGB332 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED8) << 24) | ((SDL_PACKEDORDER_XRGB) << 20) | ((SDL_PACKEDLAYOUT_332) << 16) | ((8) << 8) | ((1) << 0)),
        SDL_PIXELFORMAT_XRGB4444 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_XRGB) << 20) | ((SDL_PACKEDLAYOUT_4444) << 16) | ((12) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_RGB444 = SDL_PIXELFORMAT_XRGB4444,
        SDL_PIXELFORMAT_XBGR4444 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_XBGR) << 20) | ((SDL_PACKEDLAYOUT_4444) << 16) | ((12) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_BGR444 = SDL_PIXELFORMAT_XBGR4444,
        SDL_PIXELFORMAT_XRGB1555 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_XRGB) << 20) | ((SDL_PACKEDLAYOUT_1555) << 16) | ((15) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_RGB555 = SDL_PIXELFORMAT_XRGB1555,
        SDL_PIXELFORMAT_XBGR1555 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_XBGR) << 20) | ((SDL_PACKEDLAYOUT_1555) << 16) | ((15) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_BGR555 = SDL_PIXELFORMAT_XBGR1555,
        SDL_PIXELFORMAT_ARGB4444 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_ARGB) << 20) | ((SDL_PACKEDLAYOUT_4444) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_RGBA4444 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_RGBA) << 20) | ((SDL_PACKEDLAYOUT_4444) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_ABGR4444 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_ABGR) << 20) | ((SDL_PACKEDLAYOUT_4444) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_BGRA4444 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_BGRA) << 20) | ((SDL_PACKEDLAYOUT_4444) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_ARGB1555 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_ARGB) << 20) | ((SDL_PACKEDLAYOUT_1555) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_RGBA5551 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_RGBA) << 20) | ((SDL_PACKEDLAYOUT_5551) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_ABGR1555 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_ABGR) << 20) | ((SDL_PACKEDLAYOUT_1555) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_BGRA5551 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_BGRA) << 20) | ((SDL_PACKEDLAYOUT_5551) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_RGB565 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_XRGB) << 20) | ((SDL_PACKEDLAYOUT_565) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_BGR565 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_XBGR) << 20) | ((SDL_PACKEDLAYOUT_565) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_RGB24 = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYU8) << 24) | ((SDL_ARRAYORDER_RGB) << 20) | ((0) << 16) | ((24) << 8) | ((3) << 0)),
        SDL_PIXELFORMAT_BGR24 = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYU8) << 24) | ((SDL_ARRAYORDER_BGR) << 20) | ((0) << 16) | ((24) << 8) | ((3) << 0)),
        SDL_PIXELFORMAT_XRGB8888 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_XRGB) << 20) | ((SDL_PACKEDLAYOUT_8888) << 16) | ((24) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_RGBX8888 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_RGBX) << 20) | ((SDL_PACKEDLAYOUT_8888) << 16) | ((24) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_XBGR8888 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_XBGR) << 20) | ((SDL_PACKEDLAYOUT_8888) << 16) | ((24) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_BGRX8888 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_BGRX) << 20) | ((SDL_PACKEDLAYOUT_8888) << 16) | ((24) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_ARGB8888 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_ARGB) << 20) | ((SDL_PACKEDLAYOUT_8888) << 16) | ((32) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_RGBA8888 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_RGBA) << 20) | ((SDL_PACKEDLAYOUT_8888) << 16) | ((32) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_ABGR8888 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_ABGR) << 20) | ((SDL_PACKEDLAYOUT_8888) << 16) | ((32) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_BGRA8888 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_BGRA) << 20) | ((SDL_PACKEDLAYOUT_8888) << 16) | ((32) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_XRGB2101010 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_XRGB) << 20) | ((SDL_PACKEDLAYOUT_2101010) << 16) | ((32) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_XBGR2101010 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_XBGR) << 20) | ((SDL_PACKEDLAYOUT_2101010) << 16) | ((32) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_ARGB2101010 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_ARGB) << 20) | ((SDL_PACKEDLAYOUT_2101010) << 16) | ((32) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_ABGR2101010 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_ABGR) << 20) | ((SDL_PACKEDLAYOUT_2101010) << 16) | ((32) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_RGB48 = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYU16) << 24) | ((SDL_ARRAYORDER_RGB) << 20) | ((0) << 16) | ((48) << 8) | ((6) << 0)),
        SDL_PIXELFORMAT_BGR48 = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYU16) << 24) | ((SDL_ARRAYORDER_BGR) << 20) | ((0) << 16) | ((48) << 8) | ((6) << 0)),
        SDL_PIXELFORMAT_RGBA64 = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYU16) << 24) | ((SDL_ARRAYORDER_RGBA) << 20) | ((0) << 16) | ((64) << 8) | ((8) << 0)),
        SDL_PIXELFORMAT_ARGB64 = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYU16) << 24) | ((SDL_ARRAYORDER_ARGB) << 20) | ((0) << 16) | ((64) << 8) | ((8) << 0)),
        SDL_PIXELFORMAT_BGRA64 = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYU16) << 24) | ((SDL_ARRAYORDER_BGRA) << 20) | ((0) << 16) | ((64) << 8) | ((8) << 0)),
        SDL_PIXELFORMAT_ABGR64 = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYU16) << 24) | ((SDL_ARRAYORDER_ABGR) << 20) | ((0) << 16) | ((64) << 8) | ((8) << 0)),
        SDL_PIXELFORMAT_RGB48_FLOAT = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYF16) << 24) | ((SDL_ARRAYORDER_RGB) << 20) | ((0) << 16) | ((48) << 8) | ((6) << 0)),
        SDL_PIXELFORMAT_BGR48_FLOAT = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYF16) << 24) | ((SDL_ARRAYORDER_BGR) << 20) | ((0) << 16) | ((48) << 8) | ((6) << 0)),
        SDL_PIXELFORMAT_RGBA64_FLOAT = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYF16) << 24) | ((SDL_ARRAYORDER_RGBA) << 20) | ((0) << 16) | ((64) << 8) | ((8) << 0)),
        SDL_PIXELFORMAT_ARGB64_FLOAT = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYF16) << 24) | ((SDL_ARRAYORDER_ARGB) << 20) | ((0) << 16) | ((64) << 8) | ((8) << 0)),
        SDL_PIXELFORMAT_BGRA64_FLOAT = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYF16) << 24) | ((SDL_ARRAYORDER_BGRA) << 20) | ((0) << 16) | ((64) << 8) | ((8) << 0)),
        SDL_PIXELFORMAT_ABGR64_FLOAT = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYF16) << 24) | ((SDL_ARRAYORDER_ABGR) << 20) | ((0) << 16) | ((64) << 8) | ((8) << 0)),
        SDL_PIXELFORMAT_RGB96_FLOAT = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYF32) << 24) | ((SDL_ARRAYORDER_RGB) << 20) | ((0) << 16) | ((96) << 8) | ((12) << 0)),
        SDL_PIXELFORMAT_BGR96_FLOAT = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYF32) << 24) | ((SDL_ARRAYORDER_BGR) << 20) | ((0) << 16) | ((96) << 8) | ((12) << 0)),
        SDL_PIXELFORMAT_RGBA128_FLOAT = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYF32) << 24) | ((SDL_ARRAYORDER_RGBA) << 20) | ((0) << 16) | ((128) << 8) | ((16) << 0)),
        SDL_PIXELFORMAT_ARGB128_FLOAT = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYF32) << 24) | ((SDL_ARRAYORDER_ARGB) << 20) | ((0) << 16) | ((128) << 8) | ((16) << 0)),
        SDL_PIXELFORMAT_BGRA128_FLOAT = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYF32) << 24) | ((SDL_ARRAYORDER_BGRA) << 20) | ((0) << 16) | ((128) << 8) | ((16) << 0)),
        SDL_PIXELFORMAT_ABGR128_FLOAT = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYF32) << 24) | ((SDL_ARRAYORDER_ABGR) << 20) | ((0) << 16) | ((128) << 8) | ((16) << 0)),
        SDL_PIXELFORMAT_RGBA32 = SDL_PIXELFORMAT_ABGR8888,
        SDL_PIXELFORMAT_ARGB32 = SDL_PIXELFORMAT_BGRA8888,
        SDL_PIXELFORMAT_BGRA32 = SDL_PIXELFORMAT_ARGB8888,
        SDL_PIXELFORMAT_ABGR32 = SDL_PIXELFORMAT_RGBA8888,
        SDL_PIXELFORMAT_RGBX32 = SDL_PIXELFORMAT_XBGR8888,
        SDL_PIXELFORMAT_XRGB32 = SDL_PIXELFORMAT_BGRX8888,
        SDL_PIXELFORMAT_BGRX32 = SDL_PIXELFORMAT_XRGB8888,
        SDL_PIXELFORMAT_XBGR32 = SDL_PIXELFORMAT_RGBX8888,
        SDL_PIXELFORMAT_YV12 = (unchecked(((uint)((byte)('Y')) << 0) | ((uint)((byte)('V')) << 8) | ((uint)((byte)('1')) << 16) | ((uint)((byte)('2')) << 24))),
        SDL_PIXELFORMAT_IYUV = (unchecked(((uint)((byte)('I')) << 0) | ((uint)((byte)('Y')) << 8) | ((uint)((byte)('U')) << 16) | ((uint)((byte)('V')) << 24))),
        SDL_PIXELFORMAT_YUY2 = (unchecked(((uint)((byte)('Y')) << 0) | ((uint)((byte)('U')) << 8) | ((uint)((byte)('Y')) << 16) | ((uint)((byte)('2')) << 24))),
        SDL_PIXELFORMAT_UYVY = (unchecked(((uint)((byte)('U')) << 0) | ((uint)((byte)('Y')) << 8) | ((uint)((byte)('V')) << 16) | ((uint)((byte)('Y')) << 24))),
        SDL_PIXELFORMAT_YVYU = (unchecked(((uint)((byte)('Y')) << 0) | ((uint)((byte)('V')) << 8) | ((uint)((byte)('Y')) << 16) | ((uint)((byte)('U')) << 24))),
        SDL_PIXELFORMAT_NV12 = (unchecked(((uint)((byte)('N')) << 0) | ((uint)((byte)('V')) << 8) | ((uint)((byte)('1')) << 16) | ((uint)((byte)('2')) << 24))),
        SDL_PIXELFORMAT_NV21 = (unchecked(((uint)((byte)('N')) << 0) | ((uint)((byte)('V')) << 8) | ((uint)((byte)('2')) << 16) | ((uint)((byte)('1')) << 24))),
        SDL_PIXELFORMAT_P010 = (unchecked(((uint)((byte)('P')) << 0) | ((uint)((byte)('0')) << 8) | ((uint)((byte)('1')) << 16) | ((uint)((byte)('0')) << 24))),
        SDL_PIXELFORMAT_EXTERNAL_OES = (unchecked(((uint)((byte)('O')) << 0) | ((uint)((byte)('E')) << 8) | ((uint)((byte)('S')) << 16) | ((uint)((byte)(' ')) << 24))),
    }

    public enum SDL_ColorType
    {
        SDL_COLOR_TYPE_UNKNOWN = 0,
        SDL_COLOR_TYPE_RGB = 1,
        SDL_COLOR_TYPE_YCBCR = 2,
    }

    public enum SDL_ColorRange
    {
        SDL_COLOR_RANGE_UNKNOWN = 0,
        SDL_COLOR_RANGE_LIMITED = 1,
        SDL_COLOR_RANGE_FULL = 2,
    }

    public enum SDL_ColorPrimaries
    {
        SDL_COLOR_PRIMARIES_UNKNOWN = 0,
        SDL_COLOR_PRIMARIES_BT709 = 1,
        SDL_COLOR_PRIMARIES_UNSPECIFIED = 2,
        SDL_COLOR_PRIMARIES_BT470M = 4,
        SDL_COLOR_PRIMARIES_BT470BG = 5,
        SDL_COLOR_PRIMARIES_BT601 = 6,
        SDL_COLOR_PRIMARIES_SMPTE240 = 7,
        SDL_COLOR_PRIMARIES_GENERIC_FILM = 8,
        SDL_COLOR_PRIMARIES_BT2020 = 9,
        SDL_COLOR_PRIMARIES_XYZ = 10,
        SDL_COLOR_PRIMARIES_SMPTE431 = 11,
        SDL_COLOR_PRIMARIES_SMPTE432 = 12,
        SDL_COLOR_PRIMARIES_EBU3213 = 22,
        SDL_COLOR_PRIMARIES_CUSTOM = 31,
    }

    public enum SDL_TransferCharacteristics
    {
        SDL_TRANSFER_CHARACTERISTICS_UNKNOWN = 0,
        SDL_TRANSFER_CHARACTERISTICS_BT709 = 1,
        SDL_TRANSFER_CHARACTERISTICS_UNSPECIFIED = 2,
        SDL_TRANSFER_CHARACTERISTICS_GAMMA22 = 4,
        SDL_TRANSFER_CHARACTERISTICS_GAMMA28 = 5,
        SDL_TRANSFER_CHARACTERISTICS_BT601 = 6,
        SDL_TRANSFER_CHARACTERISTICS_SMPTE240 = 7,
        SDL_TRANSFER_CHARACTERISTICS_LINEAR = 8,
        SDL_TRANSFER_CHARACTERISTICS_LOG100 = 9,
        SDL_TRANSFER_CHARACTERISTICS_LOG100_SQRT10 = 10,
        SDL_TRANSFER_CHARACTERISTICS_IEC61966 = 11,
        SDL_TRANSFER_CHARACTERISTICS_BT1361 = 12,
        SDL_TRANSFER_CHARACTERISTICS_SRGB = 13,
        SDL_TRANSFER_CHARACTERISTICS_BT2020_10BIT = 14,
        SDL_TRANSFER_CHARACTERISTICS_BT2020_12BIT = 15,
        SDL_TRANSFER_CHARACTERISTICS_PQ = 16,
        SDL_TRANSFER_CHARACTERISTICS_SMPTE428 = 17,
        SDL_TRANSFER_CHARACTERISTICS_HLG = 18,
        SDL_TRANSFER_CHARACTERISTICS_CUSTOM = 31,
    }

    public enum SDL_MatrixCoefficients
    {
        SDL_MATRIX_COEFFICIENTS_IDENTITY = 0,
        SDL_MATRIX_COEFFICIENTS_BT709 = 1,
        SDL_MATRIX_COEFFICIENTS_UNSPECIFIED = 2,
        SDL_MATRIX_COEFFICIENTS_FCC = 4,
        SDL_MATRIX_COEFFICIENTS_BT470BG = 5,
        SDL_MATRIX_COEFFICIENTS_BT601 = 6,
        SDL_MATRIX_COEFFICIENTS_SMPTE240 = 7,
        SDL_MATRIX_COEFFICIENTS_YCGCO = 8,
        SDL_MATRIX_COEFFICIENTS_BT2020_NCL = 9,
        SDL_MATRIX_COEFFICIENTS_BT2020_CL = 10,
        SDL_MATRIX_COEFFICIENTS_SMPTE2085 = 11,
        SDL_MATRIX_COEFFICIENTS_CHROMA_DERIVED_NCL = 12,
        SDL_MATRIX_COEFFICIENTS_CHROMA_DERIVED_CL = 13,
        SDL_MATRIX_COEFFICIENTS_ICTCP = 14,
        SDL_MATRIX_COEFFICIENTS_CUSTOM = 31,
    }

    public enum SDL_ChromaLocation
    {
        SDL_CHROMA_LOCATION_NONE = 0,
        SDL_CHROMA_LOCATION_LEFT = 1,
        SDL_CHROMA_LOCATION_CENTER = 2,
        SDL_CHROMA_LOCATION_TOPLEFT = 3,
    }

    [NativeTypeName("int")]
    public enum SDL_Colorspace : uint
    {
        SDL_COLORSPACE_UNKNOWN,
        SDL_COLORSPACE_SRGB = (unchecked(((uint)(SDL_COLOR_TYPE_RGB) << 28) | ((uint)(SDL_COLOR_RANGE_FULL) << 24) | ((uint)(SDL_CHROMA_LOCATION_NONE) << 20) | ((uint)(SDL_COLOR_PRIMARIES_BT709) << 10) | ((uint)(SDL_TRANSFER_CHARACTERISTICS_SRGB) << 5) | ((uint)(SDL_MATRIX_COEFFICIENTS_IDENTITY) << 0))),
        SDL_COLORSPACE_SRGB_LINEAR = (unchecked(((uint)(SDL_COLOR_TYPE_RGB) << 28) | ((uint)(SDL_COLOR_RANGE_FULL) << 24) | ((uint)(SDL_CHROMA_LOCATION_NONE) << 20) | ((uint)(SDL_COLOR_PRIMARIES_BT709) << 10) | ((uint)(SDL_TRANSFER_CHARACTERISTICS_LINEAR) << 5) | ((uint)(SDL_MATRIX_COEFFICIENTS_IDENTITY) << 0))),
        SDL_COLORSPACE_HDR10 = (unchecked(((uint)(SDL_COLOR_TYPE_RGB) << 28) | ((uint)(SDL_COLOR_RANGE_FULL) << 24) | ((uint)(SDL_CHROMA_LOCATION_NONE) << 20) | ((uint)(SDL_COLOR_PRIMARIES_BT2020) << 10) | ((uint)(SDL_TRANSFER_CHARACTERISTICS_PQ) << 5) | ((uint)(SDL_MATRIX_COEFFICIENTS_IDENTITY) << 0))),
        SDL_COLORSPACE_JPEG = (unchecked(((uint)(SDL_COLOR_TYPE_YCBCR) << 28) | ((uint)(SDL_COLOR_RANGE_FULL) << 24) | ((uint)(SDL_CHROMA_LOCATION_NONE) << 20) | ((uint)(SDL_COLOR_PRIMARIES_BT709) << 10) | ((uint)(SDL_TRANSFER_CHARACTERISTICS_BT601) << 5) | ((uint)(SDL_MATRIX_COEFFICIENTS_BT601) << 0))),
        SDL_COLORSPACE_BT601_LIMITED = (unchecked(((uint)(SDL_COLOR_TYPE_YCBCR) << 28) | ((uint)(SDL_COLOR_RANGE_LIMITED) << 24) | ((uint)(SDL_CHROMA_LOCATION_LEFT) << 20) | ((uint)(SDL_COLOR_PRIMARIES_BT601) << 10) | ((uint)(SDL_TRANSFER_CHARACTERISTICS_BT601) << 5) | ((uint)(SDL_MATRIX_COEFFICIENTS_BT601) << 0))),
        SDL_COLORSPACE_BT601_FULL = (unchecked(((uint)(SDL_COLOR_TYPE_YCBCR) << 28) | ((uint)(SDL_COLOR_RANGE_FULL) << 24) | ((uint)(SDL_CHROMA_LOCATION_LEFT) << 20) | ((uint)(SDL_COLOR_PRIMARIES_BT601) << 10) | ((uint)(SDL_TRANSFER_CHARACTERISTICS_BT601) << 5) | ((uint)(SDL_MATRIX_COEFFICIENTS_BT601) << 0))),
        SDL_COLORSPACE_BT709_LIMITED = (unchecked(((uint)(SDL_COLOR_TYPE_YCBCR) << 28) | ((uint)(SDL_COLOR_RANGE_LIMITED) << 24) | ((uint)(SDL_CHROMA_LOCATION_LEFT) << 20) | ((uint)(SDL_COLOR_PRIMARIES_BT709) << 10) | ((uint)(SDL_TRANSFER_CHARACTERISTICS_BT709) << 5) | ((uint)(SDL_MATRIX_COEFFICIENTS_BT709) << 0))),
        SDL_COLORSPACE_BT709_FULL = (unchecked(((uint)(SDL_COLOR_TYPE_YCBCR) << 28) | ((uint)(SDL_COLOR_RANGE_FULL) << 24) | ((uint)(SDL_CHROMA_LOCATION_LEFT) << 20) | ((uint)(SDL_COLOR_PRIMARIES_BT709) << 10) | ((uint)(SDL_TRANSFER_CHARACTERISTICS_BT709) << 5) | ((uint)(SDL_MATRIX_COEFFICIENTS_BT709) << 0))),
        SDL_COLORSPACE_BT2020_LIMITED = (unchecked(((uint)(SDL_COLOR_TYPE_YCBCR) << 28) | ((uint)(SDL_COLOR_RANGE_LIMITED) << 24) | ((uint)(SDL_CHROMA_LOCATION_LEFT) << 20) | ((uint)(SDL_COLOR_PRIMARIES_BT2020) << 10) | ((uint)(SDL_TRANSFER_CHARACTERISTICS_PQ) << 5) | ((uint)(SDL_MATRIX_COEFFICIENTS_BT2020_NCL) << 0))),
        SDL_COLORSPACE_BT2020_FULL = (unchecked(((uint)(SDL_COLOR_TYPE_YCBCR) << 28) | ((uint)(SDL_COLOR_RANGE_FULL) << 24) | ((uint)(SDL_CHROMA_LOCATION_LEFT) << 20) | ((uint)(SDL_COLOR_PRIMARIES_BT2020) << 10) | ((uint)(SDL_TRANSFER_CHARACTERISTICS_PQ) << 5) | ((uint)(SDL_MATRIX_COEFFICIENTS_BT2020_NCL) << 0))),
        SDL_COLORSPACE_RGB_DEFAULT = SDL_COLORSPACE_SRGB,
        SDL_COLORSPACE_YUV_DEFAULT = SDL_COLORSPACE_JPEG,
    }

    public partial struct SDL_Color
    {
        [NativeTypeName("Uint8")]
        public byte r;

        [NativeTypeName("Uint8")]
        public byte g;

        [NativeTypeName("Uint8")]
        public byte b;

        [NativeTypeName("Uint8")]
        public byte a;
    }

    public partial struct SDL_FColor
    {
        public float r;

        public float g;

        public float b;

        public float a;
    }

    public unsafe partial struct SDL_Palette
    {
        public int ncolors;

        public SDL_Color* colors;

        [NativeTypeName("Uint32")]
        public uint version;

        public int refcount;
    }

    public unsafe partial struct SDL_PixelFormat
    {
        public SDL_PixelFormatEnum format;

        public SDL_Palette* palette;

        [NativeTypeName("Uint8")]
        public byte bits_per_pixel;

        [NativeTypeName("Uint8")]
        public byte bytes_per_pixel;

        [NativeTypeName("Uint8[2]")]
        public _padding_e__FixedBuffer padding;

        [NativeTypeName("Uint32")]
        public uint Rmask;

        [NativeTypeName("Uint32")]
        public uint Gmask;

        [NativeTypeName("Uint32")]
        public uint Bmask;

        [NativeTypeName("Uint32")]
        public uint Amask;

        [NativeTypeName("Uint8")]
        public byte Rloss;

        [NativeTypeName("Uint8")]
        public byte Gloss;

        [NativeTypeName("Uint8")]
        public byte Bloss;

        [NativeTypeName("Uint8")]
        public byte Aloss;

        [NativeTypeName("Uint8")]
        public byte Rshift;

        [NativeTypeName("Uint8")]
        public byte Gshift;

        [NativeTypeName("Uint8")]
        public byte Bshift;

        [NativeTypeName("Uint8")]
        public byte Ashift;

        public int refcount;

        [NativeTypeName("struct SDL_PixelFormat *")]
        public SDL_PixelFormat* next;

        [InlineArray(2)]
        public partial struct _padding_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPixelFormatName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetPixelFormatName(SDL_PixelFormatEnum format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GetMasksForPixelFormatEnum(SDL_PixelFormatEnum format, int* bpp, [NativeTypeName("Uint32 *")] uint* Rmask, [NativeTypeName("Uint32 *")] uint* Gmask, [NativeTypeName("Uint32 *")] uint* Bmask, [NativeTypeName("Uint32 *")] uint* Amask);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PixelFormatEnum SDL_GetPixelFormatEnumForMasks(int bpp, [NativeTypeName("Uint32")] uint Rmask, [NativeTypeName("Uint32")] uint Gmask, [NativeTypeName("Uint32")] uint Bmask, [NativeTypeName("Uint32")] uint Amask);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PixelFormat* SDL_CreatePixelFormat(SDL_PixelFormatEnum pixel_format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyPixelFormat(SDL_PixelFormat* format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Palette* SDL_CreatePalette(int ncolors);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetPixelFormatPalette(SDL_PixelFormat* format, SDL_Palette* palette);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetPaletteColors(SDL_Palette* palette, [NativeTypeName("const SDL_Color *")] SDL_Color* colors, int firstcolor, int ncolors);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyPalette(SDL_Palette* palette);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_MapRGB([NativeTypeName("const SDL_PixelFormat *")] SDL_PixelFormat* format, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_MapRGBA([NativeTypeName("const SDL_PixelFormat *")] SDL_PixelFormat* format, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetRGB([NativeTypeName("Uint32")] uint pixel, [NativeTypeName("const SDL_PixelFormat *")] SDL_PixelFormat* format, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetRGBA([NativeTypeName("Uint32")] uint pixel, [NativeTypeName("const SDL_PixelFormat *")] SDL_PixelFormat* format, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

        [NativeTypeName("#define SDL_ALPHA_OPAQUE 255")]
        public const int SDL_ALPHA_OPAQUE = 255;

        [NativeTypeName("#define SDL_ALPHA_TRANSPARENT 0")]
        public const int SDL_ALPHA_TRANSPARENT = 0;
    }
}