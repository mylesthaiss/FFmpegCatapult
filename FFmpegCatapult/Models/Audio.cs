// Audio is part of FFmpeg Catapult.

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
using System.Xml;

namespace FFmpegCatapult.Models
{
    interface IAudio : IOutput, IEncoder
    {
        bool IsVBRSupported { get; }
        bool UseVBR { get; set; }
        int[] Bitrates { get; }
        int SampleRate { get; set; }
        int[] SampleRates { get; }
        int Channels { get; set; }
        int MaxChannels { get; }
    }

    class Audio : IAudio
    {
        private int[] bitrates;
        private string codec;       
        private string encoder;

        public bool IsVBRSupported { get; private set; }
        public bool UseVBR { get; set; }
        public bool PreferNonfreeEncoder { get; set; }
        public int Bitrate { get; set; }
        public int Channels { get; set; }
        public int MaxChannels { get; private set; }
        public int Quality { get; set; }
        public int SampleRate { get; set; }
        public int[] SampleRates { get; private set; }
        public int[] VBRModes { get; private set; }
        public string Profile { get; set; }
        public string[,] Encoders { get; private set; }
        public string[,] Profiles { get; private set; }

        /// <summary>
        /// Determines and returns supported bitrates that is based on 
        /// the audio codec and sample rates.
        /// </summary>
        public int[] Bitrates
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
                        if (SampleRate == 16000 || SampleRate == 22050 || SampleRate == 24000)
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
                        if (SampleRate == 8000 || SampleRate == 11025 || SampleRate == 12000)
                        {
                            // MPEG-2.5 Layer III bitrates
                            bitrates = new int[] {
                                8, 16, 24, 32, 40, 48, 56, 64
                            };
                        }
                        else if (SampleRate == 16000 || SampleRate == 22050 || SampleRate == 24000)
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

        /// <summary>
        /// Stores audio codec value and determines available encoders for 
        /// FFmpeg to use. Also new settings such as bitrate and samplerate 
        /// will be set if codec value is changed.
        /// </summary>
        public string Codec
        {
            get { return codec; }
            set
            {
                codec = value;

                // Init codec values
                switch (codec)
                {
                    case "ac3":
                        Bitrate = 384;
                        Channels = 0;
                        MaxChannels = 6;                        
                        SampleRate = 48000;
                        Encoder = "ac3";
                        Encoders = new string[,] {
                            {"AC3", "ac3"}, {"AC3 Fixed", "ac3_fixed"}
                        };
                        SampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000
                        };
                        break;
                    case "aac":
                        Bitrate = 128;
                        Channels = 0;
                        MaxChannels = 8;
                        Encoder = PreferNonfreeEncoder ? "libfdk_aac" : "aac";
                        SampleRate = 0;                       
                        Encoders = new string[,] {
                            {"AAC (FFmpeg)", "aac"}, {"Fraunhofer FDK", "libfdk_aac"}
                        };
                        SampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000, 96000, 192000
                        };                     
                        break;
                    case "flac":
                        Bitrate = 0;
                        Channels = 0;
                        MaxChannels = 8;
                        SampleRate = 44100;
                        Encoder = "flac";                        
                        Encoders = new string[,] {
                            {"FLAC", "flac"}
                        };                        
                        SampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000, 96000, 192000
                        };                       
                        break;
                    case "heaac":
                        Bitrate = 64;
                        Channels = 0;
                        MaxChannels = 8;
                        SampleRate = 0;
                        Encoder = "libfdk_aac";
                        Encoders = new string[,] {
                            {"AAC Plus (libaacplus)", "libaacplus"}, {"Fraunhofer FDK", "libfdk_aac"}
                        };                        
                        SampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000, 96000, 192000
                        };                        
                        break;
                    case "mp2":
                        Bitrate = 192;
                        Channels = 0;
                        MaxChannels = 2;
                        SampleRate = 0;
                        Encoder = "libtwolame";
                        Encoders = new string[,] {
                            {"MP2 (FFmpeg)", "mp2"}, {"TwoLAME", "libtwolame"}
                        };              
                        SampleRates = new int[] {
                            16000, 22050, 24000, 32000, 44100, 48000
                        };                      
                        break;
                    case "mp3":
                        Bitrate = 128;
                        Channels = 0;
                        MaxChannels = 2;                      
                        SampleRate = 0;
                        Encoder = "libmp3lame";
                        Encoders = new string[,] {
                            {"LAME", "libmp3lame"}
                        };
                        SampleRates = new int[] {
                            8000, 11025, 12000, 16000, 22050, 24000, 
                            32000, 44100, 48000
                        };                        
                        break;
                    case "opus":
                        Bitrate = 96;
                        Channels = 0;
                        MaxChannels = 8;
                        SampleRate = 0;
                        Encoder = "libopus";
                        Encoders = new string[,] {
                            {"Opus", "libopus"}
                        };                        
                        SampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000, 96000, 192000
                        };                       
                        break;
                    case "pcm":
                        Channels = 0;
                        MaxChannels = 8;                        
                        SampleRate = 0;
                        Encoder = "pcm_s16le";
                        Encoders = new string[,] {
                            {"8-bit (Unsigned)", "u8"}, {"16-bit (Signed)", "s16le"},
                            {"24-bit (Signed)", "s24le"}, {"32-bit (Signed)", "s32le"},
                            {"A-law", "alaw"}, {"mu-law", "mulaw"}
                        };
                        SampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000, 96000, 192000
                        };                        
                        break;
                    case "speex":
                        Bitrate = 16;
                        Channels = 0;
                        MaxChannels = 8;
                        SampleRate = 0;
                        Encoder = "libspeex";
                        Encoders = new string[,] {
                            {"Speex", "libspeex"}
                        };                       
                        SampleRates = new int[] {
                            8000, 16000, 22050, 32000, 44100, 48000
                        };                       
                        break;
                    case "vorbis":
                        Bitrate = 128;
                        Channels = 0;
                        MaxChannels = 8;
                        SampleRate = 0;
                        Encoder = "libvorbis";
                        Encoders = new string[,] {
                            {"Vorbis (FFmpeg)", "vorbis"}, {"Vorbis", "libvorbis"}
                        };                       
                        SampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000, 96000, 192000
                        };                        
                        break;
                    case "wma":
                        Bitrate = 128;
                        Channels = 0;
                        MaxChannels = 8;
                        SampleRate = 0;
                        Encoder = "wmav2";
                        Encoders = new string[,] {
                            {"WMA Version 1", "wmav1"}, {"WMA Version 2", "wmav2"}
                        };                       
                        SampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000, 96000, 192000
                        };                      
                        break;
                    default:
                        Bitrate = 128;
                        Channels = 0;
                        MaxChannels = 8;                       
                        SampleRate = 0;
                        Encoder = codec;
                        Encoders = new string[,] {
                            {codec, codec}
                        };
                        SampleRates = new int[] {
                            8000, 11025, 16000, 22050, 32000, 44100, 
                            48000, 96000, 192000
                        };                      
                        break;
                }
            }
        }
   
        /// <summary>
        /// Stores audio encoder value and determines encoder settings and presets.
        /// </summary>
        public string Encoder
        {
            get { return encoder; }
            set
            {
                encoder = value;
                Profile = null;

                switch (encoder)
                {
                    case "libfaac":
                        IsVBRSupported = true;
                        Profiles = null;
                        Quality = 100;
                        VBRModes = new int[] {
                            20, 50, 70, 90, 100, 120, 140, 160, 180, 200
                        };
                        break;
                    case "libfdk_aac":
                        IsVBRSupported = true;
                        Quality = 3;
                        VBRModes = new int[] {
                            1, 2, 3, 4
                        };

                        if (codec == "heaac")
                        {
                            Profile = "aac_he";
                            Profiles = new string[,] {
                                {"High Efficiency", "aac_he"}, {"High Efficiency v2", "aac_he_v2"}
                            };
                        }
                        else
                        {                            
                            Profiles = new string[,] {
                                {"Default", "default"}, {"Low Complexity", "aac_low"},
                                {"High Efficiency", "aac_he"}, {"High Efficiency v2", "aac_he_v2"},
                                {"Low Delay", "aac_ld"}, {"Enhanced Low Delay", "aac_eld"}
                            };
                        }
                        break;
                    case "libmp3lame":
                        IsVBRSupported = true;
                        Profiles = null;
                        Quality = 4;
                        VBRModes = new int[] {
                            9, 8, 7, 6, 5, 4, 3, 2, 1, 0
                        };
                        break;
                    case "libvorbis":
                        IsVBRSupported = true;
                        Profiles = null;
                        Quality = 2;
                        VBRModes = new int[] {
                            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
                        };                        
                        break;
                    default:
                        IsVBRSupported = false;
                        Profiles = null;
                        UseVBR = false;
                        VBRModes = null;
                        break;
                }
            }
        }

        public Audio()
        {
            Codec = "mp3";
            Channels = 2;
            SampleRate = 44100;
        }

        public Audio(string xmlPath, string presetName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            string path = @"/presets/preset[@name='" + presetName + @"']";
            XmlNodeList nodes = doc.SelectNodes(path);

            foreach (XmlNode node in nodes)
            {
                if (node != null)
                {
                    if (node["nonfree"] != null)
                        PreferNonfreeEncoder = Convert.ToBoolean(node["nonfree"].InnerText);

                    if (node["acodec"] != null)
                        Codec = node["acodec"].InnerText;
                    else
                        Codec = "none";

                    if (node["aencoder"] != null)
                        Encoder = node["aencoder"].InnerText;

                    if (node["ab"] != null)
                        Bitrate = Convert.ToInt32(node["ab"].InnerText);

                    if (node["channels"] != null)
                        Channels = Convert.ToInt32(node["channels"].InnerText);

                    if (node["samplerate"] != null)
                        SampleRate = Convert.ToInt32(node["samplerate"].InnerText);
                }
            }
        }
    }
}
