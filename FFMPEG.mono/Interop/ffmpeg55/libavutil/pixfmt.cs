/*
 * copyright (c) 20013 Crazyender
 *
 * This file is part of FFmpeg.mono
 *
 * FFmpeg.mono is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * FFmpeg.mono is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with FFmpeg; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA
 */


using System;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security;
namespace SharpFFmpeg
{
    public partial class NativeMethods55 
{
		#if WIN32
		public const string PIXFMT = "avutil-52.dll";
		#else
		public const string PIXFMT = "avutil";
		#endif

public static readonly uint AVPALETTE_SIZE = 1024;
public static readonly uint AVPALETTE_COUNT = 256;
public static readonly AVPixelFormat AV_PIX_FMT_XVMC = AVPixelFormat.AV_PIX_FMT_XVMC_MPEG2_IDCT;
public static readonly AVPixelFormat AV_PIX_FMT_Y400A = AVPixelFormat.AV_PIX_FMT_GRAY8A;
public static readonly AVPixelFormat AV_PIX_FMT_GBR24P = AVPixelFormat.AV_PIX_FMT_GBRP;
public static readonly AVPixelFormat AV_PIX_FMT_RGB32 = AVPixelFormat.AV_PIX_FMT_BGRA;
public static readonly AVPixelFormat AV_PIX_FMT_RGB32_1 = AVPixelFormat.AV_PIX_FMT_ABGR;
public static readonly AVPixelFormat AV_PIX_FMT_BGR32 = AVPixelFormat.AV_PIX_FMT_RGBA;
public static readonly AVPixelFormat AV_PIX_FMT_BGR32_1 = AVPixelFormat.AV_PIX_FMT_ARGB;
public static readonly AVPixelFormat AV_PIX_FMT_0RGB32 = AVPixelFormat.AV_PIX_FMT_BGR0;
public static readonly AVPixelFormat AV_PIX_FMT_0BGR32 = AVPixelFormat.AV_PIX_FMT_RGB0;
public static readonly AVPixelFormat AV_PIX_FMT_GRAY16 = AVPixelFormat.AV_PIX_FMT_GRAY16LE;
public static readonly AVPixelFormat AV_PIX_FMT_RGB48 = AVPixelFormat.AV_PIX_FMT_RGB48LE;
public static readonly AVPixelFormat AV_PIX_FMT_RGB565 = AVPixelFormat.AV_PIX_FMT_RGB565LE;
public static readonly AVPixelFormat AV_PIX_FMT_RGB555 = AVPixelFormat.AV_PIX_FMT_RGB555LE;
public static readonly AVPixelFormat AV_PIX_FMT_RGB444 = AVPixelFormat.AV_PIX_FMT_RGB444LE;
public static readonly AVPixelFormat AV_PIX_FMT_BGR48 = AVPixelFormat.AV_PIX_FMT_BGR48LE;
public static readonly AVPixelFormat AV_PIX_FMT_BGR565 = AVPixelFormat.AV_PIX_FMT_BGR565LE;
public static readonly AVPixelFormat AV_PIX_FMT_BGR555 = AVPixelFormat.AV_PIX_FMT_BGR555LE;
public static readonly AVPixelFormat AV_PIX_FMT_BGR444 = AVPixelFormat.AV_PIX_FMT_BGR444LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUV420P9 = AVPixelFormat.AV_PIX_FMT_YUV420P9LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUV422P9 = AVPixelFormat.AV_PIX_FMT_YUV422P9LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUV444P9 = AVPixelFormat.AV_PIX_FMT_YUV444P9LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUV420P10 = AVPixelFormat.AV_PIX_FMT_YUV420P10LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUV422P10 = AVPixelFormat.AV_PIX_FMT_YUV422P10LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUV444P10 = AVPixelFormat.AV_PIX_FMT_YUV444P10LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUV420P12 = AVPixelFormat.AV_PIX_FMT_YUV420P12LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUV422P12 = AVPixelFormat.AV_PIX_FMT_YUV422P12LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUV444P12 = AVPixelFormat.AV_PIX_FMT_YUV444P12LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUV420P14 = AVPixelFormat.AV_PIX_FMT_YUV420P14LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUV422P14 = AVPixelFormat.AV_PIX_FMT_YUV422P14LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUV444P14 = AVPixelFormat.AV_PIX_FMT_YUV444P14LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUV420P16 = AVPixelFormat.AV_PIX_FMT_YUV420P16LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUV422P16 = AVPixelFormat.AV_PIX_FMT_YUV422P16LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUV444P16 = AVPixelFormat.AV_PIX_FMT_YUV444P16LE;
public static readonly AVPixelFormat AV_PIX_FMT_RGBA64 = AVPixelFormat.AV_PIX_FMT_RGBA64LE;
public static readonly AVPixelFormat AV_PIX_FMT_BGRA64 = AVPixelFormat.AV_PIX_FMT_BGRA64LE;
public static readonly AVPixelFormat AV_PIX_FMT_GBRP9 = AVPixelFormat.AV_PIX_FMT_GBRP9LE;
public static readonly AVPixelFormat AV_PIX_FMT_GBRP10 = AVPixelFormat.AV_PIX_FMT_GBRP10LE;
public static readonly AVPixelFormat AV_PIX_FMT_GBRP12 = AVPixelFormat.AV_PIX_FMT_GBRP12LE;
public static readonly AVPixelFormat AV_PIX_FMT_GBRP14 = AVPixelFormat.AV_PIX_FMT_GBRP14LE;
public static readonly AVPixelFormat AV_PIX_FMT_GBRP16 = AVPixelFormat.AV_PIX_FMT_GBRP16LE;
public static readonly AVPixelFormat AV_PIX_FMT_GBRAP16 = AVPixelFormat.AV_PIX_FMT_GBRAP16LE;
public static readonly AVPixelFormat AV_PIX_FMT_BAYER_BGGR16 = AVPixelFormat.AV_PIX_FMT_BAYER_BGGR16LE;
public static readonly AVPixelFormat AV_PIX_FMT_BAYER_RGGB16 = AVPixelFormat.AV_PIX_FMT_BAYER_RGGB16LE;
public static readonly AVPixelFormat AV_PIX_FMT_BAYER_GBRG16 = AVPixelFormat.AV_PIX_FMT_BAYER_GBRG16LE;
public static readonly AVPixelFormat AV_PIX_FMT_BAYER_GRBG16 = AVPixelFormat.AV_PIX_FMT_BAYER_GRBG16LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUVA420P9 = AVPixelFormat.AV_PIX_FMT_YUVA420P9LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUVA422P9 = AVPixelFormat.AV_PIX_FMT_YUVA422P9LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUVA444P9 = AVPixelFormat.AV_PIX_FMT_YUVA444P9LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUVA420P10 = AVPixelFormat.AV_PIX_FMT_YUVA420P10LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUVA422P10 = AVPixelFormat.AV_PIX_FMT_YUVA422P10LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUVA444P10 = AVPixelFormat.AV_PIX_FMT_YUVA444P10LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUVA420P16 = AVPixelFormat.AV_PIX_FMT_YUVA420P16LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUVA422P16 = AVPixelFormat.AV_PIX_FMT_YUVA422P16LE;
public static readonly AVPixelFormat AV_PIX_FMT_YUVA444P16 = AVPixelFormat.AV_PIX_FMT_YUVA444P16LE;
public static readonly AVPixelFormat AV_PIX_FMT_XYZ12 = AVPixelFormat.AV_PIX_FMT_XYZ12LE;
public static readonly AVPixelFormat AV_PIX_FMT_NV20 = AVPixelFormat.AV_PIX_FMT_NV20LE;

public static readonly AVPixelFormat PIX_FMT_Y400A = AV_PIX_FMT_Y400A;
public static readonly AVPixelFormat PIX_FMT_GBR24P = AV_PIX_FMT_GBR24P;
public static readonly AVPixelFormat PIX_FMT_RGB32 = AV_PIX_FMT_RGB32;
public static readonly AVPixelFormat PIX_FMT_RGB32_1 = AV_PIX_FMT_RGB32_1;
public static readonly AVPixelFormat PIX_FMT_BGR32 = AV_PIX_FMT_BGR32;
public static readonly AVPixelFormat PIX_FMT_BGR32_1 = AV_PIX_FMT_BGR32_1;
public static readonly AVPixelFormat PIX_FMT_0RGB32 = AV_PIX_FMT_0RGB32;
public static readonly AVPixelFormat PIX_FMT_0BGR32 = AV_PIX_FMT_0BGR32;
public static readonly AVPixelFormat PIX_FMT_GRAY16 = AV_PIX_FMT_GRAY16;
public static readonly AVPixelFormat PIX_FMT_RGB48 = AV_PIX_FMT_RGB48;
public static readonly AVPixelFormat PIX_FMT_RGB565 = AV_PIX_FMT_RGB565;
public static readonly AVPixelFormat PIX_FMT_RGB555 = AV_PIX_FMT_RGB555;
public static readonly AVPixelFormat PIX_FMT_RGB444 = AV_PIX_FMT_RGB444;
public static readonly AVPixelFormat PIX_FMT_BGR48 = AV_PIX_FMT_BGR48;
public static readonly AVPixelFormat PIX_FMT_BGR565 = AV_PIX_FMT_BGR565;
public static readonly AVPixelFormat PIX_FMT_BGR555 = AV_PIX_FMT_BGR555;
public static readonly AVPixelFormat PIX_FMT_BGR444 = AV_PIX_FMT_BGR444;
public static readonly AVPixelFormat PIX_FMT_YUV420P9 = AV_PIX_FMT_YUV420P9;
public static readonly AVPixelFormat PIX_FMT_YUV422P9 = AV_PIX_FMT_YUV422P9;
public static readonly AVPixelFormat PIX_FMT_YUV444P9 = AV_PIX_FMT_YUV444P9;
public static readonly AVPixelFormat PIX_FMT_YUV420P10 = AV_PIX_FMT_YUV420P10;
public static readonly AVPixelFormat PIX_FMT_YUV422P10 = AV_PIX_FMT_YUV422P10;
public static readonly AVPixelFormat PIX_FMT_YUV444P10 = AV_PIX_FMT_YUV444P10;
public static readonly AVPixelFormat PIX_FMT_YUV420P12 = AV_PIX_FMT_YUV420P12;
public static readonly AVPixelFormat PIX_FMT_YUV422P12 = AV_PIX_FMT_YUV422P12;
public static readonly AVPixelFormat PIX_FMT_YUV444P12 = AV_PIX_FMT_YUV444P12;
public static readonly AVPixelFormat PIX_FMT_YUV420P14 = AV_PIX_FMT_YUV420P14;
public static readonly AVPixelFormat PIX_FMT_YUV422P14 = AV_PIX_FMT_YUV422P14;
public static readonly AVPixelFormat PIX_FMT_YUV444P14 = AV_PIX_FMT_YUV444P14;
public static readonly AVPixelFormat PIX_FMT_YUV420P16 = AV_PIX_FMT_YUV420P16;
public static readonly AVPixelFormat PIX_FMT_YUV422P16 = AV_PIX_FMT_YUV422P16;
public static readonly AVPixelFormat PIX_FMT_YUV444P16 = AV_PIX_FMT_YUV444P16;
public static readonly AVPixelFormat PIX_FMT_RGBA64 = AV_PIX_FMT_RGBA64;
public static readonly AVPixelFormat PIX_FMT_BGRA64 = AV_PIX_FMT_BGRA64;
public static readonly AVPixelFormat PIX_FMT_GBRP9 = AV_PIX_FMT_GBRP9;
public static readonly AVPixelFormat PIX_FMT_GBRP10 = AV_PIX_FMT_GBRP10;
public static readonly AVPixelFormat PIX_FMT_GBRP12 = AV_PIX_FMT_GBRP12;
public static readonly AVPixelFormat PIX_FMT_GBRP14 = AV_PIX_FMT_GBRP14;
public static readonly AVPixelFormat PIX_FMT_GBRP16 = AV_PIX_FMT_GBRP16;
public enum AVPixelFormat
{
	AV_PIX_FMT_NONE = -1,
	AV_PIX_FMT_YUV420P = 0,
	AV_PIX_FMT_YUYV422 = 1,
	AV_PIX_FMT_RGB24 = 2,
	AV_PIX_FMT_BGR24 = 3,
	AV_PIX_FMT_YUV422P = 4,
	AV_PIX_FMT_YUV444P = 5,
	AV_PIX_FMT_YUV410P = 6,
	AV_PIX_FMT_YUV411P = 7,
	AV_PIX_FMT_GRAY8 = 8,
	AV_PIX_FMT_MONOWHITE = 9,
	AV_PIX_FMT_MONOBLACK = 10,
	AV_PIX_FMT_PAL8 = 11,
	AV_PIX_FMT_YUVJ420P = 12,
	AV_PIX_FMT_YUVJ422P = 13,
	AV_PIX_FMT_YUVJ444P = 14,
	AV_PIX_FMT_XVMC_MPEG2_MC = 15,
	AV_PIX_FMT_XVMC_MPEG2_IDCT = 16,
	AV_PIX_FMT_UYVY422 = 17,
	AV_PIX_FMT_UYYVYY411 = 18,
	AV_PIX_FMT_BGR8 = 19,
	AV_PIX_FMT_BGR4 = 20,
	AV_PIX_FMT_BGR4_BYTE = 21,
	AV_PIX_FMT_RGB8 = 22,
	AV_PIX_FMT_RGB4 = 23,
	AV_PIX_FMT_RGB4_BYTE = 24,
	AV_PIX_FMT_NV12 = 25,
	AV_PIX_FMT_NV21 = 26,
	AV_PIX_FMT_ARGB = 27,
	AV_PIX_FMT_RGBA = 28,
	AV_PIX_FMT_ABGR = 29,
	AV_PIX_FMT_BGRA = 30,
	AV_PIX_FMT_GRAY16BE = 31,
	AV_PIX_FMT_GRAY16LE = 32,
	AV_PIX_FMT_YUV440P = 33,
	AV_PIX_FMT_YUVJ440P = 34,
	AV_PIX_FMT_YUVA420P = 35,
	AV_PIX_FMT_VDPAU_H264 = 36,
	AV_PIX_FMT_VDPAU_MPEG1 = 37,
	AV_PIX_FMT_VDPAU_MPEG2 = 38,
	AV_PIX_FMT_VDPAU_WMV3 = 39,
	AV_PIX_FMT_VDPAU_VC1 = 40,
	AV_PIX_FMT_RGB48BE = 41,
	AV_PIX_FMT_RGB48LE = 42,
	AV_PIX_FMT_RGB565BE = 43,
	AV_PIX_FMT_RGB565LE = 44,
	AV_PIX_FMT_RGB555BE = 45,
	AV_PIX_FMT_RGB555LE = 46,
	AV_PIX_FMT_BGR565BE = 47,
	AV_PIX_FMT_BGR565LE = 48,
	AV_PIX_FMT_BGR555BE = 49,
	AV_PIX_FMT_BGR555LE = 50,
	AV_PIX_FMT_VAAPI_MOCO = 51,
	AV_PIX_FMT_VAAPI_IDCT = 52,
	AV_PIX_FMT_VAAPI_VLD = 53,
	AV_PIX_FMT_YUV420P16LE = 54,
	AV_PIX_FMT_YUV420P16BE = 55,
	AV_PIX_FMT_YUV422P16LE = 56,
	AV_PIX_FMT_YUV422P16BE = 57,
	AV_PIX_FMT_YUV444P16LE = 58,
	AV_PIX_FMT_YUV444P16BE = 59,
	AV_PIX_FMT_VDPAU_MPEG4 = 60,
	AV_PIX_FMT_DXVA2_VLD = 61,
	AV_PIX_FMT_RGB444LE = 62,
	AV_PIX_FMT_RGB444BE = 63,
	AV_PIX_FMT_BGR444LE = 64,
	AV_PIX_FMT_BGR444BE = 65,
	AV_PIX_FMT_GRAY8A = 66,
	AV_PIX_FMT_BGR48BE = 67,
	AV_PIX_FMT_BGR48LE = 68,
	AV_PIX_FMT_YUV420P9BE = 69,
	AV_PIX_FMT_YUV420P9LE = 70,
	AV_PIX_FMT_YUV420P10BE = 71,
	AV_PIX_FMT_YUV420P10LE = 72,
	AV_PIX_FMT_YUV422P10BE = 73,
	AV_PIX_FMT_YUV422P10LE = 74,
	AV_PIX_FMT_YUV444P9BE = 75,
	AV_PIX_FMT_YUV444P9LE = 76,
	AV_PIX_FMT_YUV444P10BE = 77,
	AV_PIX_FMT_YUV444P10LE = 78,
	AV_PIX_FMT_YUV422P9BE = 79,
	AV_PIX_FMT_YUV422P9LE = 80,
	AV_PIX_FMT_VDA_VLD = 81,
	AV_PIX_FMT_GBRP = 82,
	AV_PIX_FMT_GBRP9BE = 83,
	AV_PIX_FMT_GBRP9LE = 84,
	AV_PIX_FMT_GBRP10BE = 85,
	AV_PIX_FMT_GBRP10LE = 86,
	AV_PIX_FMT_GBRP16BE = 87,
	AV_PIX_FMT_GBRP16LE = 88,
	AV_PIX_FMT_YUVA422P_LIBAV = 89,
	AV_PIX_FMT_YUVA444P_LIBAV = 90,
	AV_PIX_FMT_YUVA420P9BE = 91,
	AV_PIX_FMT_YUVA420P9LE = 92,
	AV_PIX_FMT_YUVA422P9BE = 93,
	AV_PIX_FMT_YUVA422P9LE = 94,
	AV_PIX_FMT_YUVA444P9BE = 95,
	AV_PIX_FMT_YUVA444P9LE = 96,
	AV_PIX_FMT_YUVA420P10BE = 97,
	AV_PIX_FMT_YUVA420P10LE = 98,
	AV_PIX_FMT_YUVA422P10BE = 99,
	AV_PIX_FMT_YUVA422P10LE = 100,
	AV_PIX_FMT_YUVA444P10BE = 101,
	AV_PIX_FMT_YUVA444P10LE = 102,
	AV_PIX_FMT_YUVA420P16BE = 103,
	AV_PIX_FMT_YUVA420P16LE = 104,
	AV_PIX_FMT_YUVA422P16BE = 105,
	AV_PIX_FMT_YUVA422P16LE = 106,
	AV_PIX_FMT_YUVA444P16BE = 107,
	AV_PIX_FMT_YUVA444P16LE = 108,
	AV_PIX_FMT_VDPAU = 109,
	AV_PIX_FMT_XYZ12LE = 110,
	AV_PIX_FMT_XYZ12BE = 111,
	AV_PIX_FMT_NV16 = 112,
	AV_PIX_FMT_NV20LE = 113,
	AV_PIX_FMT_NV20BE = 114,
	AV_PIX_FMT_RGBA64BE = 291,
	AV_PIX_FMT_RGBA64LE = 292,
	AV_PIX_FMT_BGRA64BE = 293,
	AV_PIX_FMT_BGRA64LE = 294,
	AV_PIX_FMT_0RGB = 295,
	AV_PIX_FMT_RGB0 = 296,
	AV_PIX_FMT_0BGR = 297,
	AV_PIX_FMT_BGR0 = 298,
	AV_PIX_FMT_YUVA444P = 299,
	AV_PIX_FMT_YUVA422P = 300,
	AV_PIX_FMT_YUV420P12BE = 301,
	AV_PIX_FMT_YUV420P12LE = 302,
	AV_PIX_FMT_YUV420P14BE = 303,
	AV_PIX_FMT_YUV420P14LE = 304,
	AV_PIX_FMT_YUV422P12BE = 305,
	AV_PIX_FMT_YUV422P12LE = 306,
	AV_PIX_FMT_YUV422P14BE = 307,
	AV_PIX_FMT_YUV422P14LE = 308,
	AV_PIX_FMT_YUV444P12BE = 309,
	AV_PIX_FMT_YUV444P12LE = 310,
	AV_PIX_FMT_YUV444P14BE = 311,
	AV_PIX_FMT_YUV444P14LE = 312,
	AV_PIX_FMT_GBRP12BE = 313,
	AV_PIX_FMT_GBRP12LE = 314,
	AV_PIX_FMT_GBRP14BE = 315,
	AV_PIX_FMT_GBRP14LE = 316,
	AV_PIX_FMT_GBRAP = 317,
	AV_PIX_FMT_GBRAP16BE = 318,
	AV_PIX_FMT_GBRAP16LE = 319,
	AV_PIX_FMT_YUVJ411P = 320,
	AV_PIX_FMT_BAYER_BGGR8 = 321,
	AV_PIX_FMT_BAYER_RGGB8 = 322,
	AV_PIX_FMT_BAYER_GBRG8 = 323,
	AV_PIX_FMT_BAYER_GRBG8 = 324,
	AV_PIX_FMT_BAYER_BGGR16LE = 325,
	AV_PIX_FMT_BAYER_BGGR16BE = 326,
	AV_PIX_FMT_BAYER_RGGB16LE = 327,
	AV_PIX_FMT_BAYER_RGGB16BE = 328,
	AV_PIX_FMT_BAYER_GBRG16LE = 329,
	AV_PIX_FMT_BAYER_GBRG16BE = 330,
	AV_PIX_FMT_BAYER_GRBG16LE = 331,
	AV_PIX_FMT_BAYER_GRBG16BE = 332,
	AV_PIX_FMT_NB = 333,
	PIX_FMT_NONE = -1,
	PIX_FMT_YUV420P = 0,
	PIX_FMT_YUYV422 = 1,
	PIX_FMT_RGB24 = 2,
	PIX_FMT_BGR24 = 3,
	PIX_FMT_YUV422P = 4,
	PIX_FMT_YUV444P = 5,
	PIX_FMT_YUV410P = 6,
	PIX_FMT_YUV411P = 7,
	PIX_FMT_GRAY8 = 8,
	PIX_FMT_MONOWHITE = 9,
	PIX_FMT_MONOBLACK = 10,
	PIX_FMT_PAL8 = 11,
	PIX_FMT_YUVJ420P = 12,
	PIX_FMT_YUVJ422P = 13,
	PIX_FMT_YUVJ444P = 14,
	PIX_FMT_XVMC_MPEG2_MC = 15,
	PIX_FMT_XVMC_MPEG2_IDCT = 16,
	PIX_FMT_UYVY422 = 17,
	PIX_FMT_UYYVYY411 = 18,
	PIX_FMT_BGR8 = 19,
	PIX_FMT_BGR4 = 20,
	PIX_FMT_BGR4_BYTE = 21,
	PIX_FMT_RGB8 = 22,
	PIX_FMT_RGB4 = 23,
	PIX_FMT_RGB4_BYTE = 24,
	PIX_FMT_NV12 = 25,
	PIX_FMT_NV21 = 26,
	PIX_FMT_ARGB = 27,
	PIX_FMT_RGBA = 28,
	PIX_FMT_ABGR = 29,
	PIX_FMT_BGRA = 30,
	PIX_FMT_GRAY16BE = 31,
	PIX_FMT_GRAY16LE = 32,
	PIX_FMT_YUV440P = 33,
	PIX_FMT_YUVJ440P = 34,
	PIX_FMT_YUVA420P = 35,
	PIX_FMT_VDPAU_H264 = 36,
	PIX_FMT_VDPAU_MPEG1 = 37,
	PIX_FMT_VDPAU_MPEG2 = 38,
	PIX_FMT_VDPAU_WMV3 = 39,
	PIX_FMT_VDPAU_VC1 = 40,
	PIX_FMT_RGB48BE = 41,
	PIX_FMT_RGB48LE = 42,
	PIX_FMT_RGB565BE = 43,
	PIX_FMT_RGB565LE = 44,
	PIX_FMT_RGB555BE = 45,
	PIX_FMT_RGB555LE = 46,
	PIX_FMT_BGR565BE = 47,
	PIX_FMT_BGR565LE = 48,
	PIX_FMT_BGR555BE = 49,
	PIX_FMT_BGR555LE = 50,
	PIX_FMT_VAAPI_MOCO = 51,
	PIX_FMT_VAAPI_IDCT = 52,
	PIX_FMT_VAAPI_VLD = 53,
	PIX_FMT_YUV420P16LE = 54,
	PIX_FMT_YUV420P16BE = 55,
	PIX_FMT_YUV422P16LE = 56,
	PIX_FMT_YUV422P16BE = 57,
	PIX_FMT_YUV444P16LE = 58,
	PIX_FMT_YUV444P16BE = 59,
	PIX_FMT_VDPAU_MPEG4 = 60,
	PIX_FMT_DXVA2_VLD = 61,
	PIX_FMT_RGB444LE = 62,
	PIX_FMT_RGB444BE = 63,
	PIX_FMT_BGR444LE = 64,
	PIX_FMT_BGR444BE = 65,
	PIX_FMT_GRAY8A = 66,
	PIX_FMT_BGR48BE = 67,
	PIX_FMT_BGR48LE = 68,
	PIX_FMT_YUV420P9BE = 69,
	PIX_FMT_YUV420P9LE = 70,
	PIX_FMT_YUV420P10BE = 71,
	PIX_FMT_YUV420P10LE = 72,
	PIX_FMT_YUV422P10BE = 73,
	PIX_FMT_YUV422P10LE = 74,
	PIX_FMT_YUV444P9BE = 75,
	PIX_FMT_YUV444P9LE = 76,
	PIX_FMT_YUV444P10BE = 77,
	PIX_FMT_YUV444P10LE = 78,
	PIX_FMT_YUV422P9BE = 79,
	PIX_FMT_YUV422P9LE = 80,
	PIX_FMT_VDA_VLD = 81,
	PIX_FMT_GBRP = 82,
	PIX_FMT_GBRP9BE = 83,
	PIX_FMT_GBRP9LE = 84,
	PIX_FMT_GBRP10BE = 85,
	PIX_FMT_GBRP10LE = 86,
	PIX_FMT_GBRP16BE = 87,
	PIX_FMT_GBRP16LE = 88,
	PIX_FMT_RGBA64BE = 291,
	PIX_FMT_RGBA64LE = 292,
	PIX_FMT_BGRA64BE = 293,
	PIX_FMT_BGRA64LE = 294,
	PIX_FMT_0RGB = 295,
	PIX_FMT_RGB0 = 296,
	PIX_FMT_0BGR = 297,
	PIX_FMT_BGR0 = 298,
	PIX_FMT_YUVA444P = 299,
	PIX_FMT_YUVA422P = 300,
	PIX_FMT_YUV420P12BE = 301,
	PIX_FMT_YUV420P12LE = 302,
	PIX_FMT_YUV420P14BE = 303,
	PIX_FMT_YUV420P14LE = 304,
	PIX_FMT_YUV422P12BE = 305,
	PIX_FMT_YUV422P12LE = 306,
	PIX_FMT_YUV422P14BE = 307,
	PIX_FMT_YUV422P14LE = 308,
	PIX_FMT_YUV444P12BE = 309,
	PIX_FMT_YUV444P12LE = 310,
	PIX_FMT_YUV444P14BE = 311,
	PIX_FMT_YUV444P14LE = 312,
	PIX_FMT_GBRP12BE = 313,
	PIX_FMT_GBRP12LE = 314,
	PIX_FMT_GBRP14BE = 315,
	PIX_FMT_GBRP14LE = 316,
	PIX_FMT_NB = 317,
}

}
}
