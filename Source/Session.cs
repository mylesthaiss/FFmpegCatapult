﻿// Session is part of FFmpeg Catapult.
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
    class Session
    {
        // Variables
        public static bool KeepValues;
        public static bool TwoPassEncoding;
        public static bool Overwrite;
        public static bool WriteLog;
        public static bool SaveProperties;
        public static bool MultiThreading;
        private static int maxThreads = Environment.ProcessorCount;
        private static int threads;
        private static string preset;

        // Property methods
        public static string Preset
        {
            get { return preset; }
            set { preset = value; }
        }

        public static int Threads
        {
            get { return threads; }
            set { threads = value; }
        }

        public static int MaxThreads
        {
            get { return maxThreads; }
            set { maxThreads = value; }
        }

        // Load and save methods
        public static void LoadSettings()
        {
            File.Format = Properties.Settings.Default.FileFormat;

            // Picure settings
            Screen.AspectRatio = Properties.Settings.Default.AspectRatio;
            Screen.CropVideo = Properties.Settings.Default.Crop;
            Screen.Deinterlace = Properties.Settings.Default.Deinterlace;
            Screen.PadVideo = Properties.Settings.Default.Pad;
            Screen.ScaleOption = Properties.Settings.Default.ScaleMode;
            Screen.Width = Properties.Settings.Default.Width;
            Screen.Height = Properties.Settings.Default.Height;
            Screen.RatioA = Properties.Settings.Default.RatioA;
            Screen.RatioB = Properties.Settings.Default.RatioB;
            Screen.FPS = Properties.Settings.Default.FPS;
            Screen.WinHeight = Properties.Settings.Default.LayoutHeight;
            Screen.WinWidth = Properties.Settings.Default.LayoutWidth;
            Screen.X = Properties.Settings.Default.X;
            Screen.Y = Properties.Settings.Default.Y;
            Screen.ScalingMethod = Properties.Settings.Default.ScaleMethod;
            Screen.VFColour = Properties.Settings.Default.PadColour;

            // Audio settings
            Audio.Codec = Properties.Settings.Default.AudioCodec;
            Audio.Encoder = Properties.Settings.Default.AudioEncoder;
            Audio.CodecProfile = Properties.Settings.Default.AudioCodecProfile;
            Audio.Channels = Properties.Settings.Default.Channels;
            Audio.SampleRate = Properties.Settings.Default.SampleRate;
            Audio.Bitrate = Properties.Settings.Default.AudioBitrate;
            Audio.Quality = Properties.Settings.Default.AudioQuality;
            Audio.UseVBR = Properties.Settings.Default.UseVBR;

            // Video settings
            Video.Codec = Properties.Settings.Default.VideoCodec;
            Video.Encoder = Properties.Settings.Default.VideoEncoder;
            Video.CodecProfile = Properties.Settings.Default.VideoCodecProfile;
            Video.CodecLevel = Properties.Settings.Default.CodecLevel;
            Video.EncoderPreset = Properties.Settings.Default.VideoEncoderPreset;
            Video.Bitrate = Properties.Settings.Default.VideoBitrate;
            Video.MaxBitrate = Properties.Settings.Default.VideoMaxBitrate;
            Video.MinBitrate = Properties.Settings.Default.VideoMinBitrate;
            Video.BufferSize = Properties.Settings.Default.BufferSize;
            Video.CRF = Properties.Settings.Default.CRF;
            Video.Qmax = Properties.Settings.Default.Qmax;
            Video.Qmin = Properties.Settings.Default.Qmin;
            Video.UseCRF = Properties.Settings.Default.UseCRF;
            Video.Bits = Properties.Settings.Default.Bits;
            Video.Bytes = Properties.Settings.Default.Bytes;
            Video.MEMethod = Properties.Settings.Default.MEMethod;
            Video.CMP = Properties.Settings.Default.CMP;
            Video.SubCMP = Properties.Settings.Default.SubCMP;
            Video.Trellis = Properties.Settings.Default.Trellis;
            Video.DiaSize = Properties.Settings.Default.DiaSize;
            Video.BFrames = Properties.Settings.Default.BFrames;
            Video.BFStrategy = Properties.Settings.Default.BFStrat;
            Video.GOPSize = Properties.Settings.Default.GOPSize;
            Video.PictureFormat = Properties.Settings.Default.PixelFormat;
        }

        public static void SaveSettings()
        {
            // User and host settings
            Properties.Settings.Default.KeepValues = Session.KeepValues;
            Properties.Settings.Default.OverwriteFiles = Session.Overwrite;
            Properties.Settings.Default.TwoPassEncoding = Session.TwoPassEncoding;
            Properties.Settings.Default.Threads = Session.Threads;
            Properties.Settings.Default.Preset = Session.Preset;
            Properties.Settings.Default.FileFormat = File.Format;
            Properties.Settings.Default.FFmpegBin = Bin.FFmpegBin;
            Properties.Settings.Default.TermArgs = Bin.TermArgs;
            Properties.Settings.Default.TermBin = Bin.TermBin;
            Properties.Settings.Default.NullPath = Bin.NullPath;
            Properties.Settings.Default.WriteLog = Session.WriteLog;
            Properties.Settings.Default.LogFileName = File.Log;

            // Picture settings
            Properties.Settings.Default.ScaleMethod = Screen.ScalingMethod;
            Properties.Settings.Default.ScaleMode = Screen.ScaleOption;
            Properties.Settings.Default.PixelFormat = Video.PictureFormat;
            Properties.Settings.Default.Height = Screen.Height;
            Properties.Settings.Default.Width = Screen.Width;
            Properties.Settings.Default.LayoutHeight = Screen.WinHeight;
            Properties.Settings.Default.LayoutWidth = Screen.WinWidth;
            Properties.Settings.Default.X = Screen.X;
            Properties.Settings.Default.Y = Screen.Y;
            Properties.Settings.Default.PadColour = Screen.VFColour;
            Properties.Settings.Default.RatioA = Screen.RatioA;
            Properties.Settings.Default.RatioB = Screen.RatioB;
            Properties.Settings.Default.Deinterlace = Screen.Deinterlace;
            Properties.Settings.Default.AspectRatio = Screen.AspectRatio;
            Properties.Settings.Default.Crop = Screen.CropVideo;
            Properties.Settings.Default.Pad = Screen.PadVideo;

            // Audio settings
            Properties.Settings.Default.AudioCodec = Audio.Codec;
            Properties.Settings.Default.AudioCodecProfile = Audio.CodecProfile;
            Properties.Settings.Default.AudioBitrate = Audio.Bitrate;
            Properties.Settings.Default.AudioEncoder = Audio.Encoder;
            Properties.Settings.Default.AudioQuality = Audio.Quality;
            Properties.Settings.Default.UseVBR = Audio.UseVBR;
            Properties.Settings.Default.Channels = Audio.Channels;
            Properties.Settings.Default.SampleRate = Audio.SampleRate;

            // Video settings
            Properties.Settings.Default.VideoCodec = Video.Codec;
            Properties.Settings.Default.VideoCodecProfile = Video.CodecProfile;
            Properties.Settings.Default.CodecLevel = Video.CodecLevel;
            Properties.Settings.Default.VideoEncoder = Video.Encoder;
            Properties.Settings.Default.VideoEncoderPreset = Video.EncoderPreset;
            Properties.Settings.Default.VideoBitrate = Video.Bitrate;
            Properties.Settings.Default.VideoMinBitrate = Video.MinBitrate;
            Properties.Settings.Default.VideoMaxBitrate = Video.MaxBitrate;
            Properties.Settings.Default.BufferSize = Video.BufferSize;
            Properties.Settings.Default.Bits = Video.Bits;
            Properties.Settings.Default.Bytes = Video.Bytes;
            Properties.Settings.Default.CRF = Video.CRF;
            Properties.Settings.Default.UseCRF = Video.UseCRF;
            Properties.Settings.Default.Qmax = Video.Qmax;
            Properties.Settings.Default.Qmin = Video.Qmin;
            Properties.Settings.Default.MEMethod = Video.MEMethod;
            Properties.Settings.Default.CMP = Video.CMP;
            Properties.Settings.Default.SubCMP = Video.SubCMP;
            Properties.Settings.Default.Trellis = Video.Trellis;
            Properties.Settings.Default.DiaSize = Video.DiaSize;
            Properties.Settings.Default.GOPSize = Video.GOPSize;
            Properties.Settings.Default.BFrames = Video.BFrames;
            Properties.Settings.Default.BFStrat = Video.BFStrategy;

            Properties.Settings.Default.InitPreset = false;
            Properties.Settings.Default.Save();
        }
    }
}
