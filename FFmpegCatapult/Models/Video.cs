// Video is part of FFmpeg Catapult.

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
    interface IVideo : IOutput, IEncoder
    {
        bool AutoAltRef { get; set; }
        bool FrameParallel { get; set; }
        bool TwoPassEncoding { get; set; }
        bool UseCRF { get; set; }
        double CodecLevel { get; set; }
        int BufferSize { get; set; }
        int MaxBitrate { get; set; }
        int MinBitrate { get; set; }
        int BFrames { get; set; }
        int BFStrategy { get; set; }
        int CMP { get; set; }
        int DiaSize { get; set; }
        int GOPSize { get; set; }
        int LagInFrames { get; set; }
        int Speed { get; set; }
        int SubCMP { get; set; }
        int TargetSize { get; set; }
        int TileColumns { get; set; }
        int TileRows { get; set; }
        int Trellis { get; set; }
        int QMin { get; set; }
        int QMax { get; set; }
        string EncoderPreset { get; set; }
        string PixelFormat { get; set; }
        string MEMethod { get; set; }
        string[,] EncoderPresets { get; }
        string[,] PixelFormats { get; }
        string[,] MEMethods { get; }
    }

    class Video : IVideo
    {
        private string codec;
        private string encoder;
        private string[] cmpFuncs = new string[] {
            "sad", "sse", "satd", "dct", "psnr", "bit", "rd", "zero", "vsad",
            "vsse", "nsse", "w53", "w97", "dctmax", "chroma", "Default"
        };        
        private string[,] meMethods = new string[,] {
            {"Zero", "zero"}, {"Full", "full"}, {"EPZS", "epzs"}, {"Esa", "esa"},
            {"Tesa", "tesa"}, {"Dia", "dia"}, {"Log", "log"}, {"Phods", "phods"},
            {"X1", "x1"}, {"Hex", "hex"}, {"Umh", "umh"}, {"Iter", "iter"},
            {"Default", ""}
        };        
        private string[,] pixelFormats = new string[,] {
            {"YUV 4:2:0", "yuv420p"}, {"YUYV 4:2:2", "yuyv422"}, {"RGB 24", "rgb24"},
            {"BGR 24","bgr24"}, {"YUV 4:2:2", "yuv422p"}, {"YUV 4:4:4", "yuv44p"},
            {"YUV 4:1:0", "yuv410p"}, {"YUV 4:1:1", "yuv411p"}, {"Gray", "gray"},
            {"Default", ""}
        };

        public bool AutoAltRef { get; set; }
        public bool FrameParallel { get; set; }
        public bool UseCRF { get; set; } = false;
        public bool TwoPassEncoding { get; set; } = false;
        public bool PreferNonfreeEncoder { get; set; } = false;
        public double CodecLevel { get; set; }
        public double[] CodecLevels { get; private set; }
        public int Bitrate { get; set; }
        public int BFrames { get; set; }
        public int BFStrategy { get; set; }
        public int BufferSize { get; set; }
        public int Quality { get; set; }
        public int CMP { get; set; }
        public int DiaSize { get; set; }
        public int QMax { get; set; }
        public int QMin { get; set; }
        public int Speed { get; set; }
        public int SubCMP { get; set; }
        public int TargetSize { get; set; } = 0;
        public int TileColumns { get; set; }
        public int TileRows { get; set; }
        public int Trellis { get; set; }
        public int GOPSize { get; set; }
        public int LagInFrames { get; set; }
        public int MaxBitrate { get; set; }
        public int MinBitrate { get; set; }
        public string EncoderPreset { get; set; }
        public string MEMethod { get; set; }
        public string PixelFormat { get; set; }
        public string Profile { get; set; }
        public string[,] Encoders { get; private set; }
        public string[,] EncoderPresets { get; private set; }
        public string[,] Profiles { get; private set; }
        
        /// <summary>
        /// Stores video codec value and determines supported video encoders for
        /// FFmpeg to use. Also all codec settings are set to default when codec
        /// value is changed.
        /// </summary>
        public string Codec
        {
            get { return codec; }
            set
            {
                codec = value;

                // Reset to default values
                Profile = "";
                Quality = 0;
                UseCRF = false;
                BFrames = 0;
                BFStrategy = 3;
                BufferSize = 0;
                CMP = 15;
                DiaSize = 0;
                GOPSize = 0;
                MaxBitrate = 0;
                MEMethod = "";
                MinBitrate = 0;
                QMax = 0;
                QMin = 0;
                SubCMP = 15;
                Trellis = 3;

                switch (codec)
                {
                    case "av1":
                        Bitrate = 768;
                        CodecLevel = 0;
                        CodecLevels = null;
                        Profile = null;
                        Profiles = null;
                        Quality = 30;
                        Encoder = "libaom-av1";
                        Encoders = new string[,] {
                            {"libaom", "libaom-av1"}
                        };
                        break;
                    case "h264":
                        Bitrate = 1000;
                        CodecLevel = 3.1;
                        Profile = "main";
                        Encoder = "libx264";
                        Encoders = new string[,] {
                            {"x264", "libx264"}, {"Nvidia NVENC", "nvenc_h264"}
                        };
                        Profiles = new string[,] {
                            {"Baseline", "baseline"}, {"Main", "main"}, {"High", "high"}
                        };
                        CodecLevels = new double[] {
                            1.0, 1.1, 1.2, 1.3, 2.0, 2.1, 2.2, 3.0, 3.1, 3.2, 4.0,
                            4.2, 5.0, 5.1, 5.2
                        };
                        break;
                    case "h265":
                        Bitrate = 768;
                        CodecLevel = 0;
                        CodecLevels = null;
                        Profile = null;
                        Profiles = null;
                        Quality = 28;
                        UseCRF = true;
                        Encoder = "libx265";
                        Encoders = new string[,] {
                            {"x265", "libx265"}, {"Nvidia NVENC", "nvenc_hevc"}
                        };
                        break;
                    case "mpeg2":
                        Bitrate = 4000;
                        CodecLevel = 0;
                        CodecLevels = null;
                        Profile = null;
                        Profiles = null;
                        Encoder = "mpeg2video";
                        Encoders = new string[,] {
                            {"MPEG-2 Video", "mpeg2video"}
                        };                       
                        break;
                    case "mpeg4":
                        Bitrate = 1500;
                        CodecLevel = 0;
                        CodecLevels = null;
                        Profile = null;
                        Profiles = null;
                        Encoder = "libxvid";
                        Encoders = new string[,] {
                            {"MPEG-4 (FFmpeg)", "mpeg4"}, {"Xvid", "libxvid"}
                        };                     
                        break;
                    case "theora":
                        Bitrate = 1800;
                        CodecLevel = 0;
                        CodecLevels = null;
                        Profile = null;
                        Profiles = null;
                        Encoder = "libtheora";
                        Encoders = new string[,] {
                            {"Theora", "libtheora"}
                        };                        
                        break;
                    case "vp8":
                        Bitrate = 1500;
                        CodecLevel = 0;
                        CodecLevels = null;
                        Profile = null;
                        Profiles = null;
                        Encoder = "libvpx";
                        Encoders = new string[,] {
                            {"VPX", "libvpx"}
                        };                       
                        break;
                    case "vp9":
                        Bitrate = 1000;
                        CodecLevel = 0;
                        CodecLevels = null;
                        Profile = null;
                        Profiles = null;
                        Speed = 1;
                        TileColumns = 6;
                        LagInFrames = 25;
                        FrameParallel = true;
                        AutoAltRef = true;
                        Encoder = "libvpx-vp9";
                        Encoders = new string[,] {
                            {"VPX", "libvpx-vp9"}
                        };
                        break;
                    case "wmv":
                        Bitrate = 1500;
                        CodecLevel = 0;
                        CodecLevels = null;
                        Profile = null;
                        Profiles = null;
                        Encoder = "wmv2";
                        Encoders = new string[,] {
                            {"WMV 7 (wmv1)", "wmv1"}, {"WMV 8 (wmv2)", "wmv2"}
                        };                   
                        break;
                    default:
                        Bitrate = 1500;
                        CodecLevel = 0;
                        CodecLevels = null;
                        Profile = null;
                        Profiles = null;
                        Encoder = codec;
                        Encoders = new string[,] {
                            {codec, codec}
                        };                       
                        break;
                }
            }
        }

        /// <summary>
        /// Stores video encoder value and determines encoder settings and presets.
        /// </summary>
        public string Encoder
        {
            get { return encoder; }
            set
            {
                encoder = value;

                switch (encoder)
                {
                    case "libx264":
                    case "libx265":                       
                        EncoderPreset = "medium";
                        EncoderPresets = new string[,] {
                            {"Ultra Fast", "ultrafast"}, {"Super Fast", "superfast"},
                            {"Very Fast", "veryfast"}, {"Faster", "faster"}, {"Fast", "fast"},
                            {"Medium", "medium"}, {"Slow", "slow"}, {"Slower", "slower"},
                            {"Very Slow", "veryslow"}, {"Placebo", "placebo"}
                        };
                        break;
                    case "nvenc_h264":
                    case "nvenc_hevc":
                        EncoderPreset = "slow";
                        EncoderPresets = new string[,] {
                            {"Slow", "slow"}, {"Medium", "medium"}, {"Fast", "fast"},
                            {"High Quality", "hq"}, {"Low Latency", "ll"}, {"Low Latency HQ", "llhq"},
                            {"Low Latency HP", "llhp"}, {"Lossless", "lossless"}, {"Lossless HP", "losslesshp"}
                        };
                        break;
                    default:
                        EncoderPreset = null;
                        EncoderPresets = null;
                        break;
                }
            }
        }

        public string[] CMPFuncs
        {
            get { return cmpFuncs; }
        }

        public string[,] MEMethods
        {
            get { return meMethods; }
        }

        public string[,] PixelFormats
        {
            get { return pixelFormats; }
        }

        public Video()
        {
            Codec = "mpeg4";
            Bitrate = 1000;
            MaxBitrate = 1500;
            BufferSize = 2048;
            BFStrategy = 2;
            BFrames = 2;
            GOPSize = 300;
            Trellis = 2;
        }

        public Video(string xmlPath, string presetName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            string path = @"/presets/preset[@name='" + presetName + @"']";
            XmlNodeList nodes = doc.SelectNodes(path);

            foreach (XmlNode node in nodes)
            {
                if (node != null)
                {
                    if (node["autoaltref"] != null)
                    {
                        AutoAltRef = Convert.ToBoolean(node["autoaltref"].InnerText);
                    }

                    if (node["frameparallel"] != null)
                    {
                        FrameParallel = Convert.ToBoolean(node["frameparallel"].InnerText);
                    }

                    if (node["nonfree"] != null)
                    {
                        PreferNonfreeEncoder = Convert.ToBoolean(node["nonfree"].InnerText);
                    }

                    if (node["twopass"] != null)
                    {
                        TwoPassEncoding = Convert.ToBoolean(node["twopass"].InnerText);
                    }

                    if (node["vcodec"] != null)
                    {
                        Codec = node["vcodec"].InnerText;
                    }
                    else
                    {
                        Codec = "none";
                    }

                    if (node["vencoder"] != null)
                    {
                        Encoder = node["vencoder"].InnerText;
                    }

                    if (node["vprofile"] != null)
                    {
                        Profile = node["vprofile"].InnerText;
                    }

                    if (node["level"] != null)
                    {
                        CodecLevel = Convert.ToDouble(node["level"].InnerText);
                    }

                    if (node["vpreset"] != null)
                    {
                        EncoderPreset = node["vpreset"].InnerText;
                    }

                    if (node["vb"] != null)
                    {
                        UseCRF = false;
                        Bitrate = Convert.ToInt32(node["vb"].InnerText);
                    }

                    if (node["maxvb"] != null)
                    {
                        MaxBitrate = Convert.ToInt32(node["maxvb"].InnerText);
                    }

                    if (node["buffersize"] != null)
                    {
                        BufferSize = Convert.ToInt32(node["buffersize"].InnerText);
                    }

                    if (node["bframes"] != null)
                    {
                        BFrames = Convert.ToInt16(node["bframes"].InnerText);
                    }

                    if (node["bfstrategy"] != null)
                    {
                        BFStrategy = Convert.ToInt16(node["bfstrategy"].InnerText);
                    }

                    if (node["cmp"] != null)
                    {
                        CMP = Convert.ToInt16(node["cmp"].InnerText);
                    }

                    if (node["crf"] != null)
                    {
                        UseCRF = true;
                        Quality = Convert.ToInt32(node["crf"].InnerText);
                    }

                    if (node["diasize"] != null)
                    {
                        DiaSize = Convert.ToInt16(node["diasize"].InnerText);
                    }

                    if (node["gopsize"] != null)
                    {
                        GOPSize = Convert.ToInt16(node["gopsize"].InnerText);
                    }

                    if (node["laginframes"] != null)
                    {
                        LagInFrames = Convert.ToInt16(node["laginframes"].InnerText);
                    }

                    if (node["memethod"] != null)
                    {
                        MEMethod = node["memethod"].InnerText;
                    }

                    if (node["pixformat"] !=null)
                    {
                        PixelFormat = node["pixformat"].InnerText;
                    }

                    if (node["qmin"] != null)
                    {
                        QMin = Convert.ToInt16(node["qmin"].InnerText);
                    }

                    if (node["qmax"] != null)
                    {
                        QMax = Convert.ToInt16(node["qmax"].InnerText);
                    }

                    if (node["subcmp"] != null)
                    {
                        SubCMP = Convert.ToInt16(node["subcmp"].InnerText);
                    }

                    if (node["tilecolumns"] != null)
                    {
                        TileColumns = Convert.ToInt16(node["tilecolumns"].InnerText);
                    }

                    if (node["tilerows"] != null)
                    {
                        TileRows = Convert.ToInt16(node["tilerows"].InnerText);
                    }

                    if (node["trellis"] != null)
                    {
                        Trellis = Convert.ToInt16(node["trellis"].InnerText);
                    }
                }
            }
        }
    }
}