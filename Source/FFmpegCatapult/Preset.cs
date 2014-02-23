// Encoding preset preset properties interface for FFmpeg Catapult.
// Copyright (C) 2013 Myles Thaiss

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
    class Preset
    {
        // Variables        
        private static String[,] presets = new String[,] {
            {"Xvid", "xvid"}, {"MPEG-2, Standard Definition", "mp2sd"},
            {"MPEG-2, High Definintion", "mp2hd"}, {"MPEG-4, Standard Definintion", "mp4sd"},
            {"MPEG-4, High Definintion", "mp4hd"}, {"H.264, Standard Definintion", "h264sd"},
            {"H.264, High Definintion", "h264hd"}, {"VP8, Standard Definintion", "vp8sd"},
            {"VP8, High Definintion", "vp8hd"}, {"iPod (5th Gen), 240p MPEG-4","ipod240mp4"},
            {"iPod (5th Gen), 240p H.264", "ipod240h264"}, {"iPod (5th Gen), 480p MPEG-4", "ipod480mp4"},
            {"iPod (5th Gen), 480p H.264", "ipod480h264"}, {"iPhone 4", "iphone4"},
            {"Sony PSP", "psp"}, {"Sony PSP, TV Out", "psptv"},            
            {"Extract audio stream to MP3", "tomp3"}, {"Copy audio and video to AVI","copyavi"},
            {"Copy audio and video to MKV", "copymkv"}, {"Copy audio and video to MP4", "copymp4"}
        };

        // Init preset method
        public static void SetPreset(string preset)
        {
            switch (preset)
            {
                case "xvid":
                    File.Format = "avi";
                    Video.Codec = "mpeg4";
                    Video.Bitrate = 1000;
                    Video.MaxBitrate = 1500;
                    Video.BufferSize = 2;
                    Video.BFrames = 2;
                    Video.BFStrategy = 2;
                    Video.GOPSize = 300;
                    Video.Trellis = 2;
                    Audio.Codec = "mp3";
                    Audio.Channels = 2;
                    Audio.SampleRate = 48000;
                    Screen.Width = 512;
                    Screen.Height = 0;
                    Screen.ScaleOption = 1;
                    break;
                case "h264sd":
                    File.Format = "mp4";
                    Video.Codec = "h264";
                    Video.CodecProfile = "main";
                    Video.CodecLevel = 40;
                    Video.UseCRF = true;
                    Video.CRF = 24;
                    Screen.ScaleOption = 1;
                    Screen.Width = 0;
                    Screen.Height = 480;
                    Screen.AspectRatio = false;
                    Screen.RatioA = 16;
                    Screen.RatioB = 9;
                    Audio.Codec = "aac";
                    break;
                case "h264hd":
                    File.Format = "mp4";
                    Video.Codec = "h264";
                    Video.CodecProfile = "high";
                    Video.CodecLevel = 41;
                    Video.UseCRF = true;
                    Video.CRF = 18;
                    Screen.ScaleOption = 1;
                    Screen.Width = 0;
                    Screen.Height = 720;
                    Screen.AspectRatio = false;
                    Screen.RatioA = 16;
                    Screen.RatioB = 9;
                    Audio.Codec = "aac";
                    Audio.Bitrate = 160;
                    break;
                case "ipod240h264":
                    File.Format = "mp4";
                    Video.Codec = "h264";
                    Video.CodecProfile = "baseline";
                    Video.CodecLevel = 13;
                    Video.Bitrate = 500;
                    Video.MaxBitrate = 768;
                    Video.BufferSize = 3;
                    Screen.ScaleOption = 1;
                    Screen.Width = 320;
                    Screen.Height = 0;
                    Screen.AspectRatio = false;
                    Screen.RatioA = 4;
                    Screen.RatioB = 3;
                    Audio.Codec = "aac";
                    Audio.Bitrate = 128;
                    Audio.SampleRate = 44100;
                    Audio.Channels = 2;
                    break;
                case "ipod240mp4":
                    File.Format = "mp4";
                    Video.Codec = "mpeg4";
                    Video.Bitrate = 768;
                    Video.MaxBitrate = 1000;
                    Video.BufferSize = 3;
                    Screen.ScaleOption = 1;
                    Screen.Width = 320;
                    Screen.Height = 0;
                    Screen.AspectRatio = false;
                    Screen.RatioA = 4;
                    Screen.RatioB = 3;
                    Audio.Codec = "aac";
                    Audio.Bitrate = 128;
                    Audio.SampleRate = 44100;
                    Audio.Channels = 2;
                    break;
                case "ipod480h264":
                    File.Format = "mp4";
                    Video.Codec = "h264";
                    Video.CodecProfile = "baseline";
                    Video.CodecLevel = 30;
                    Video.Bitrate = 768;
                    Video.MaxBitrate = 1000;
                    Video.BufferSize = 1;
                    Screen.ScaleOption = 1;
                    Screen.Width = 640;
                    Screen.Height = 0;
                    Screen.AspectRatio = false;
                    Screen.RatioA = 4;
                    Screen.RatioB = 3;
                    Audio.Codec = "aac";
                    Audio.Bitrate = 128;
                    Audio.SampleRate = 44100;
                    Audio.Channels = 2;
                    break;
                case "ipod480mp4":
                    File.Format = "mp4";
                    Video.Codec = "mpeg4";
                    Video.Bitrate = 1500;
                    Video.MaxBitrate = 2500;
                    Video.BufferSize = 3;
                    Screen.ScaleOption = 1;
                    Screen.Width = 640;
                    Screen.Height = 0;
                    Screen.AspectRatio = false;
                    Screen.RatioA = 4;
                    Screen.RatioB = 3;
                    Audio.Codec = "aac";
                    Audio.Bitrate = 128;
                    Audio.SampleRate = 44100;
                    Audio.Channels = 2;
                    break;
                case "iphone4":
                    File.Format = "mp4";
                    Video.Codec = "h264";
                    Video.CodecProfile = "main";
                    Video.CodecLevel = 31;
                    Video.Bitrate = 2000;
                    Video.MaxBitrate = 2500;
                    Video.BufferSize = 1;
                    Screen.ScaleOption = 1;
                    Screen.Width = 0;
                    Screen.Height = 720;
                    Screen.AspectRatio = false;
                    Screen.RatioA = 4;
                    Screen.RatioB = 3;
                    Audio.Codec = "aac";
                    Audio.Bitrate = 160;
                    Audio.SampleRate = 44100;
                    Audio.Channels = 2;
                    break;
                case "mp2sd":
                    File.Format = "mpg";
                    Video.Codec = "mpeg2";
                    Video.Bitrate = 4500;
                    Video.BFrames = 2;
                    Video.GOPSize = 16;
                    Video.MEMethod = "epzs";
                    Screen.ScaleOption = 1;
                    Screen.Width = 0;
                    Screen.Height = 480;
                    Audio.Codec = "mp2";
                    break;
                case "mp2hd":
                    File.Format = "ts";
                    Video.Codec = "mpeg2";
                    Video.Bitrate = 10000;
                    Video.BFrames = 2;
                    Video.GOPSize = 15;
                    Video.MEMethod = "epzs";
                    Screen.ScaleOption = 1;
                    Screen.Width = 0;
                    Screen.Height = 720;
                    Audio.Codec = "mp2";
                    Audio.Bitrate = 256;
                    break;
                case "psp":
                    File.Format = "mp4";
                    Video.Codec = "h264";
                    Video.CodecProfile = "baseline";
                    Video.CodecLevel = 21;
                    Video.Bitrate = 500;
                    Video.MaxBitrate = 768;
                    Video.BufferSize = 2;
                    Screen.ScaleOption = 1;
                    Screen.Width = 480;
                    Screen.Height = 0;
                    Screen.AspectRatio = false;
                    Screen.RatioA = 16;
                    Screen.RatioB = 9;
                    Audio.Codec = "aac";
                    Audio.Bitrate = 128;
                    Audio.SampleRate = 44100;
                    Audio.Channels = 2;
                    break;
                case "psptv":
                    File.Format = "mp4";
                    Video.Codec = "h264";
                    Video.CodecProfile = "baseline";
                    Video.CodecLevel = 30;
                    Video.Bitrate = 1500;
                    Video.MaxBitrate = 2000;
                    Video.BufferSize = 2;
                    Screen.ScaleOption = 1;
                    Screen.Width = 0;
                    Screen.Height = 480;
                    Screen.AspectRatio = false;
                    Screen.RatioA = 16;
                    Screen.RatioB = 9;
                    Audio.Codec = "aac";
                    Audio.Bitrate = 160;
                    Audio.SampleRate = 44100;
                    Audio.Channels = 2;
                    break;
                case "vp8sd":
                    File.Format = "webm";
                    Video.Codec = "vp8";
                    Video.Bitrate = 1000;
                    Video.MaxBitrate = 1500;
                    Video.Qmin = 0;
                    Video.Qmax = 63;
                    Screen.ScaleOption = 0;
                    Screen.Width = 0;
                    Screen.Height = 480;
                    Screen.RatioA = 16;
                    Screen.RatioB = 9;
                    Audio.Codec = "vorbis";
                    break;
                case "vp8hd":
                    File.Format = "webm";
                    Video.Codec = "vp8";
                    Video.Bitrate = 12000;
                    Video.MaxBitrate = 15000;
                    Video.Qmin = 10;
                    Video.Qmax = 52;
                    Screen.ScaleOption = 0;
                    Screen.Width = 0;
                    Screen.Height = 720;
                    Screen.RatioA = 16;
                    Screen.RatioB = 9;
                    Audio.Codec = "vorbis";
                    break;
                case "tomp3":
                    File.Format = "mp3";
                    Video.Codec = "none";
                    Audio.Codec = "mp3";
                    Audio.Bitrate = 192;
                    Audio.Channels = 2;
                    Audio.SampleRate = 44100;                    
                    break;
                case "copyavi":
                    File.Format = "avi";
                    Video.Codec = "copy";
                    Audio.Codec = "copy";
                    break;
                case "copymkv":
                    File.Format = "mkv";
                    Video.Codec = "copy";
                    Audio.Codec = "copy";
                    break;
                case "copymp4":
                    File.Format = "mp4";
                    Video.Codec = "copy";
                    Audio.Codec = "copy";
                    break;
                default:
                    File.Format = "mp4";
                    Video.Codec = "mpeg4";
                    Video.Bitrate = 2000;
                    Video.Encoder = "mpeg4";
                    Screen.Width = 0;
                    Screen.Height = 0;
                    Screen.ScaleOption = 0;
                    Audio.Codec = "aac";
                    break;
            }
        }

        public static String[,] GetPresets()
        {
            return presets;
        }
    }
}
