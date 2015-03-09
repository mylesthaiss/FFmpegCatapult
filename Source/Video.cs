﻿// Video is part of FFmpeg Catapult.
// Copyright (C) 2015 Myles Thaiss

// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFmpegCatapult
{
    class Video
    {
        // Variables
        private static bool useCRF = false;
        private static double bitrate;
        private static double bufferSize;
        private static double codecLevel;
        private static double maxBitrate;
        private static double minBitrate;
        private static int bFrames;
        private static int bFStrat;
        private static int cmp;
        private static int crf;
        private static int diaSize;
        private static int gopSize;
        private static int qmax;
        private static int qmin;
        private static int subcmp;
        private static int trellis;
        private static string bits;
        private static string bytes;
        private static string codec;
        private static string[,] codecs;
        private static string codecProfile;
        private static string[,] codecProfiles;
        private static string encoder;
        private static string[,] encoders;
        private static string encoderPreset;
        private static string[,] encoderPresets;
        private static string[] cmpFuncs = new string[] {
            "sad", "sse", "satd", "dct", "psnr", "bit", "rd", "zero", "vsad",
            "vsse", "nsse", "w53", "w97", "dctmax", "chroma", "Default"
        };
        private static string meMethod;
        private static string[,] meMethods = new string[,] {
            {"Zero", "zero"}, {"Full", "full"}, {"EPZS", "epzs"}, {"Esa", "esa"},
            {"Tesa", "tesa"}, {"Dia", "dia"}, {"Log", "log"}, {"Phods", "phods"},
            {"X1", "x1"}, {"Hex", "hex"}, {"Umh", "umh"}, {"Iter", "iter"},
            {"Default", ""}
        };
        private static string pictureFormat = "";
        private static string[,] pictureFormats = new string[,] {
            {"YUV 4:2:0", "yuv420p"}, {"YUYV 4:2:2", "yuyv422"}, {"RGB 24", "rgb24"},
            {"BGR 24","bgr24"}, {"YUV 4:2:2", "yuv422p"}, {"YUV 4:4:4", "yuv44p"},
            {"YUV 4:1:0", "yuv410p"}, {"YUV 4:1:1", "yuv411p"}, {"Gray", "gray"},
            {"Default", ""}
        };

        // Property methods
        public static double Bitrate
        {
            get { return bitrate; }
            set { bitrate = value; }
        }

        public static int BFrames
        {
            get { return bFrames; }
            set { bFrames = value; }
        }

        public static int BFStrategy
        {
            get { return bFStrat; }
            set { bFStrat = value; }
        }

        public static string Bits
        {
            get { return bits; }
            set { bits = value; }
        }

        public static double BufferSize
        {
            get { return bufferSize; }
            set { bufferSize = value; }
        }

        public static string Bytes
        {
            get { return bytes; }
            set { bytes = value; }
        }

        public static int CMP
        {
            get { return cmp; }
            set { cmp = value; }
        }

        public static string[] CMPFuncs
        {
            get { return cmpFuncs; }
        }

        /// <summary>
        /// Stores video codec value and determines supported video encoders for
        /// FFmpeg to use. Also all codec settings are set to default when codec
        /// value is changed.
        /// </summary>
        public static string Codec
        {
            get { return codec; }
            set
            {
                codec = value;

                // Reset to default values
                useCRF = false;
                bits = "k";
                bytes = "M";
                bFrames = 0;
                bFStrat = 3;
                bufferSize = 0;
                cmp = 15;
                diaSize = 0;
                gopSize = 0;
                maxBitrate = 0;
                meMethod = "";
                minBitrate = 0;
                qmax = 0;
                qmin = 0;
                subcmp = 15;
                trellis = 3;

                // Init codec values
                switch (codec)
                {
                    case "h264":
                        bitrate = 1000;
                        codecLevel = 3.1;
                        codecProfile = "main";
                        encoders = new string[,] {
                            {"x264", "libx264"}
                        };
                        Encoder = "libx264";
                        break;
                    case "mpeg2":
                        bitrate = 4000;
                        encoders = new string[,] {
                            {"MPEG-2 Video", "mpeg2video"}
                        };
                        Encoder = "mpeg2video";
                        break;
                    case "mpeg4":
                        bitrate = 1500;
                        encoders = new string[,] {
                            {"MPEG-4 (FFmpeg)", "mpeg4"}, {"Xvid", "libxvid"}
                        };
                        Encoder = "libxvid";
                        break;
                    case "theora":
                        bitrate = 1800;
                        encoders = new string[,] {
                            {"Theora", "libtheora"}
                        };
                        Encoder = "libtheora";
                        break;
                    case "vp8":
                        bitrate = 1500;
                        encoders = new string[,] {
                            {"VPX", "libvpx"}
                        };
                        Encoder = "libvpx";
                        break;
                    case "wmv":
                        bitrate = 1500;
                        encoders = new string[,] {
                            {"WMV 7 (wmv1)", "wmv1"}, {"WMV 8 (wmv2)", "wmv2"}
                        };
                        Encoder = "wmv2";
                        break;
                    default:
                        bitrate = 1500;
                        encoders = new string[,] {
                            {codec, codec}
                        };
                        Encoder = codec;
                        break;
                }
            }
        }

        public static string[,] Codecs
        {
            get { return codecs; }
            set { codecs = value; }
        }

        public static double CodecLevel
        {
            get { return codecLevel; }
            set { codecLevel = value; }
        }

        public static string CodecProfile
        {
            get { return codecProfile; }
            set { codecProfile = value; }
        }

        public static string[,] CodecProfiles
        {
            get { return codecProfiles; }
        }

        public static int CRF
        {
            get { return crf; }
            set { crf = value; }
        }

        public static int DiaSize
        {
            get { return diaSize; }
            set { diaSize = value; }
        }

        /// <summary>
        /// Stores video encoder value and determines encoder settings and presets.
        /// </summary>
        public static string Encoder
        {
            get { return encoder; }
            set
            {
                encoder = value;

                switch (encoder)
                {
                    case "libx264":
                        codecProfiles = new string[,] {
                            {"Baseline", "baseline"}, {"Main", "main"}, {"High", "high"}
                        };
                        encoderPreset = "medium";
                        encoderPresets = new string[,] {
                            {"Ultra Fast", "ultrafast"}, {"Super Fast", "superfast"},
                            {"Very Fast", "veryfast"}, {"Faster", "faster"}, {"Fast", "fast"},
                            {"Medium", "medium"}, {"Slow", "slow"}, {"Slower", "slower"},
                            {"Very Slow", "veryslow"}, {"Placebo", "placebo"}
                        };
                        break;
                    default:
                        codecProfile = "";
                        encoderPreset = "";
                        break;
                }
            }
        }

        public static string[,] Encoders
        {
            get { return encoders; }
        }

        public static string EncoderPreset
        {
            get { return encoderPreset; }
            set { encoderPreset = value; }
        }

        public static string[,] EncoderPresets
        {
            get { return encoderPresets; }
        }

        public static int GOPSize
        {
            get { return gopSize; }
            set { gopSize = value; }
        }

        public static double MaxBitrate
        {
            get { return maxBitrate; }
            set { maxBitrate = value; }
        }

        public static string MEMethod
        {
            get { return meMethod; }
            set { meMethod = value; }
        }

        public static string[,] MEMethods
        {
            get { return meMethods; }
        }

        public static double MinBitrate
        {
            get { return minBitrate; }
            set { minBitrate = value; }
        }

        public static string PictureFormat
        {
            get { return pictureFormat; }
            set { pictureFormat = value; }
        }

        public static string[,] PictureFormats
        {
            get { return pictureFormats; }
        }

        public static int Qmax
        {
            get { return qmax; }
            set { qmax = value; }
        }

        public static int Qmin
        {
            get { return qmin; }
            set { qmin = value; }
        }

        public static int SubCMP
        {
            get { return subcmp; }
            set { subcmp = value; }
        }

        public static int Trellis
        {
            get { return trellis; }
            set { trellis = value; }
        }

        public static bool UseCRF
        {
            get
            {
                if(Session.TwoPassEncoding)
                {
                    return false;
                }
                else
                {
                    return useCRF;
                }
            }
            set { useCRF = value; }
        }
    }
}