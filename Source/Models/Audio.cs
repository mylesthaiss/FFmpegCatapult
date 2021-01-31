﻿// Audio is part of FFmpeg Catapult.
 
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

namespace FFmpegCatapult
{
    class Audio
    {
        // Variables
        public static bool UseVBR;
        public static bool VBRSupported;
        private static int bitrate;
        private static int[] bitrates;
        private static int channels;
        private static int maxChannels;
        private static int quality;
        private static int sampleRate;
        private static int[] sampleRates;
        private static int[] vbrModes;
        private static string codec;
        private static string codecProfile;
        private static string[,] codecProfiles;
        private static string[,] codecs;
        private static string encoder;
        private static string[,] encoders;

        /// <summary>
        /// Stores audio codec value and determines available encoders for 
        /// FFmpeg to use. Also new settings such as bitrate and samplerate 
        /// will be set if codec value is changed.
        /// </summary>
        public static string Codec
        {
            get { return codec; }
            set
            {
                codec = value;

                // Init codec values
                switch (codec)
                {
                    case "ac3":
                        bitrate = 384;
                        channels = 0;
                        maxChannels = 6;
                        encoders = new string[,] {
                            {"AC3", "ac3"}, {"AC3 Fixed", "ac3_fixed"}
                        };
                        sampleRate = 48000;
                        sampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000
                        };
                        Encoder = "ac3";
                        break;
                    case "aac":
                        bitrate = 128;
                        channels = 0;
                        maxChannels = 8;
                        encoders = new string[,] {
                            {"AAC (FFmpeg)", "aac"}, {"FAAC", "libfaac"}, 
                            {"Fraunhofer FDK", "libfdk_aac"}, {"Visual On", "libvo_aacenc"}
                        };
                        sampleRate = 0;
                        sampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000, 96000, 192000
                        };
                        Encoder = "libvo_aacenc";
                        break;
                    case "flac":
                        bitrate = 0;
                        channels = 0;
                        maxChannels = 8;
                        encoders = new string[,] {
                            {"FLAC", "flac"}
                        };
                        sampleRate = 44100;
                        sampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000, 96000, 192000
                        };
                        Encoder = "flac";
                        break;
                    case "heaac":
                        bitrate = 64;
                        channels = 0;
                        maxChannels = 8;
                        encoders = new string[,] {
                            {"AAC Plus (libaacplus)", "libaacplus"}, {"Fraunhofer FDK", "libfdk_aac"}
                        };
                        sampleRate = 0;
                        sampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000, 96000, 192000
                        };
                        Encoder = "libfdk_aac";
                        break;
                    case "mp2":
                        bitrate = 192;
                        channels = 0;
                        maxChannels = 2;
                        encoders = new string[,] {
                            {"MP2 (FFmpeg)", "mp2"}, {"TwoLAME", "libtwolame"}
                        };
                        sampleRate = 0;
                        sampleRates = new int[] {
                            16000, 22050, 24000, 32000, 44100, 48000
                        };
                        Encoder = "libtwolame";
                        break;
                    case "mp3":
                        bitrate = 128;
                        channels = 0;
                        maxChannels = 2;
                        encoders = new string[,] {
                            {"LAME", "libmp3lame"}
                        };
                        sampleRate = 0;
                        sampleRates = new int[] {
                            8000, 11025, 12000, 16000, 22050, 24000, 
                            32000, 44100, 48000
                        };
                        Encoder = "libmp3lame";
                        break;
                    case "opus":
                        bitrate = 96;
                        channels = 0;
                        maxChannels = 8;
                        encoders = new string[,] {
                            {"Opus", "libopus"}
                        };
                        sampleRate = 0;
                        sampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000, 96000, 192000
                        };
                        Encoder = "libopus";
                        break;
                    case "pcm":
                        channels = 0;
                        maxChannels = 8;
                        encoders = new string[,] {
                            {"8-bit (Unsigned)", "u8"}, {"16-bit (Signed)", "s16le"}, 
                            {"24-bit (Signed)", "s24le"}, {"32-bit (Signed)", "s32le"},
                            {"A-law", "alaw"}, {"mu-law", "mulaw"}                            
                        };
                        sampleRate = 0;
                        sampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000, 96000, 192000
                        };
                        Encoder = "pcm_s16le";
                        break;
                    case "speex":
                        bitrate = 16;
                        channels = 0;
                        maxChannels = 8;
                        encoders = new string[,] {
                            {"Speex", "libspeex"}
                        };
                        sampleRate = 0;
                        sampleRates = new int[] {
                            8000, 16000, 22050, 32000, 44100, 48000
                        };
                        Encoder = codec;
                        break;
                    case "vorbis":
                        bitrate = 128;
                        channels = 0;
                        maxChannels = 8;
                        encoders = new string[,] {
                            {"Vorbis (FFmpeg)", "vorbis"}, {"Vorbis", "libvorbis"}
                        };
                        sampleRate = 0;
                        sampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000, 96000, 192000
                        };
                        Encoder = "libvorbis";
                        break;
                    case "wma":
                        bitrate = 128;
                        channels = 0;
                        maxChannels = 8;
                        encoders = new string[,] {
                            {"WMA Version 1", "wmav1"}, {"WMA Version 2", "wmav2"}
                        };
                        sampleRate = 0;
                        sampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000, 96000, 192000
                        };
                        Encoder = "wmav2";
                        break;
                    default:
                        bitrate = 128;
                        channels = 0;
                        maxChannels = 8;
                        encoders = new string[,] {
                            {codec, codec}
                        };
                        sampleRate = 0;
                        sampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000, 96000, 192000
                        };
                        Encoder = codec;
                        break;
                }
            }
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

        public static string[,] Codecs
        {
            get { return codecs; }
            set { codecs = value; }
        }

        public static int Bitrate
        {
            get { return bitrate; }
            set { bitrate = value; }
        }

        /// <summary>
        /// Determines and returns supported bitrates that is based on 
        /// the audio codec and sample rates.
        /// </summary>
        public static int[] Bitrates
        {
            get
            {
                switch (codec)
                {
                    case "ac3":
                        // AC3 Bitrates
                        bitrates = new int[] {
                            32, 40, 48, 56, 64, 80, 96, 112, 128, 160, 192, 
                            224, 256, 320, 384, 448
                        };
                        break;
                    case "aac":
                    case "heaac":
                        // Advance Audio Coding bitrates
                        bitrates = new int[] {
                            8, 16, 32, 40, 48, 56, 64, 80, 96, 112, 128, 160, 
                            192, 224, 256, 320, 384, 448
                        };
                        break;
                    case "mp2":
                        if (sampleRate == 16000 || sampleRate == 22050 || sampleRate == 24000)
                        {
                            // Low-freq MP2 bitrates
                            bitrates = new int[] {
                                8, 16, 24, 32, 40, 48, 56, 64, 80, 96, 112, 128, 
                                144, 160
                            };
                        }
                        else
                        {
                            // Standard MP2 bitrates
                            bitrates = new int[] {
                                32, 48, 56, 64, 80, 96, 112, 128, 160, 192, 
                                224, 256, 320, 384
                            };
                        }
                        break;
                    case "mp3":
                        if (sampleRate == 8000 || sampleRate == 11025 || sampleRate == 12000)
                        {
                            // MPEG-2.5 Layer III bitrates
                            bitrates = new int[] {
                                8, 16, 24, 32, 40, 48, 56, 64
                            };
                        }
                        else if (sampleRate == 16000 || sampleRate == 22050 || sampleRate == 24000)
                        {
                            // MPEG-2 Layer III bitrates
                            bitrates = new int[] {
                                8, 16, 24, 32, 40, 48, 56, 64, 80, 96, 
                                112, 128, 144, 160
                            };
                        }
                        else
                        {
                            // MPEG-1 Layer III bitrates
                            bitrates = new int[] {
                                32, 40, 48, 56, 64, 80, 96, 112, 128, 
                                144, 160, 192, 224, 256, 320
                            };
                        }
                        break;
                    case "vorbis":
                        bitrates = new int[] {
                            32, 64, 80, 96, 112, 128, 160, 192, 224, 
                            256, 320, 500
                        };
                        break;
                    case "speex":
                        bitrates = new int[] {
                            2, 4, 8, 16, 24, 32, 40, 44
                        };
                        break;
                    case "wma":
                        bitrates = new int[] {
                            32, 48, 80, 96, 128, 160, 192
                        };
                        break;
                    default:
                        bitrates = new int[] {
                            8, 16, 32, 40, 48, 56, 64, 80, 96, 112, 128, 160, 
                            192, 224, 256, 320
                        };
                        break;
                }

                return bitrates;
            }
        }

        public static int Channels
        {
            get { return channels; }
            set { channels = value; }
        }

        /// <summary>
        /// Stores audio encoder value and determines encoder settings and presets.
        /// </summary>
        public static string Encoder
        {
            get { return encoder; }
            set
            {
                encoder = value;
                codecProfile = "default";

                switch (encoder)
                {
                    case "libfaac":
                        VBRSupported = true;
                        quality = 100;
                        vbrModes = new int[] {
                            20, 50, 70, 90, 100, 120, 140, 160, 180, 200
                        };
                        break;
                    case "libfdk_aac":
                        VBRSupported = true;
                        quality = 3;
                        vbrModes = new int[] {
                            1, 2, 3, 4
                        };

                        if (codec == "heaac")
                        {
                            codecProfile = "aac_he";
                            codecProfiles = new string[,] {
                                {"High Efficiency", "aac_he"}, {"High Efficiency v2", "aac_he_v2"}
                            };
                        }
                        else
                        {                            
                            codecProfiles = new string[,] {
                                {"Default", "default"}, {"Low Complexity", "aac_low"},
                                {"High Efficiency", "aac_he"}, {"High Efficiency v2", "aac_he_v2"},
                                {"Low Delay", "aac_ld"}, {"Enhanced Low Delay", "aac_eld"}
                            };
                        }

                        break;
                    case "libmp3lame":
                        VBRSupported = true;
                        quality = 4;
                        vbrModes = new int[] {
                            9, 8, 7, 6, 5, 4, 3, 2, 1, 0
                        };
                        break;
                    case "libvorbis":
                        VBRSupported = true;
                        quality = 2;
                        vbrModes = new int[] {
                            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
                        };
                        break;
                    default:
                        VBRSupported = false;
                        UseVBR = false;
                        break;
                }
            }
        }

        public static string[,] Encoders
        {
            get { return encoders; }
        }

        public static int MaxChannels
        {
            get { return maxChannels; }
            set { maxChannels = value; }
        }

        public static int Quality
        {
            get { return quality; }
            set { quality = value; }
        }

        public static int SampleRate
        {
            get { return sampleRate; }
            set { sampleRate = value; }
        }

        public static int[] SampleRates
        {
            get { return sampleRates; }
        }

        public static int[] VBRModes
        {
            get { return vbrModes; }
        }
    }
}
