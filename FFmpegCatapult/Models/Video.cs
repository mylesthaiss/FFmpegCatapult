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
        public int MotionEstimatePreCompare { get; set; } = 0;
        public int MacroBlockingCompare { get; set; } = 0;
        public int Quality { get; set; }
        public int MotionEstimateCompare { get; set; } = 0;
        public int DiaSize { get; set; }
        public int QMax { get; set; }
        public int QMin { get; set; }
        public int Speed { get; set; }
        public int MotionEstimateSubCompare { get; set; } = 0;
        public int TargetSize { get; set; } = 0;
        public int TileColumns { get; set; }
        public int TileRows { get; set; }
        public int Trellis { get; set; }
        public int GOPSize { get; set; }
        public int LagInFrames { get; set; }
        public int MaxBitrate { get; set; }
        public int MinBitrate { get; set; }
        public string EncoderPreset { get; set; }
        public string MotionEstimateMethod { get; set; }
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
                Quality = 0;
                UseCRF = false;
                BFrames = 0;
                BFStrategy = 3;
                BufferSize = 0;
                DiaSize = 0;
                GOPSize = 0;
                MaxBitrate = 0;
                MotionEstimateMethod = "";
                MinBitrate = 0;
                QMax = 0;
                QMin = 0;
                Trellis = 3;

                switch (codec)
                {
                    case "av1":
                        Bitrate = 768;
                        CodecLevel = 0;
                        CodecLevels = null;
                        Quality = 30;
                        Encoder = "libaom-av1";
                        Encoders = new string[,] {
                            {"libaom", "libaom-av1"}
                        };
                        break;
                    case "h264":
                        Bitrate = 1000;
                        CodecLevel = 3.1;
                        Encoder = "libx264";
                        Encoders = new string[,] {
                            {"AMD AMF", "h264_amf"}, {"Nvidia NVENC", "nvenc_h264"}, {"x264", "libx264"}
                        };
                        
                        CodecLevels = new double[] {
                            1.0, 1.1, 1.2, 1.3, 2.0, 2.1, 2.2, 3.0, 3.1, 3.2, 4.0,
                            4.2, 5.0, 5.1, 5.2, 6.0, 6.1, 6.2
                        };
                        break;
                    case "h265":
                        Bitrate = 768;
                        CodecLevel = 0;
                        CodecLevels = null;
                        Quality = 28;
                        UseCRF = true;
                        Encoder = "libx265";
                        Encoders = new string[,] {
                            {"AMD AMF", "hevc_amf"}, {"Nvidia NVENC", "nvenc_hevc"}, {"x265", "libx265"}
                        };
                        break;
                    case "mpeg2":
                        Bitrate = 4000;
                        CodecLevel = 0;
                        CodecLevels = null;
                        Encoder = "mpeg2video";
                        Encoders = new string[,] {
                            {"MPEG-2 Video", "mpeg2video"}
                        };                       
                        break;
                    case "mpeg4":
                        Bitrate = 1500;
                        CodecLevel = 0;
                        CodecLevels = null;
                        Encoder = "libxvid";
                        Encoders = new string[,] {
                            {"MPEG-4 (FFmpeg)", "mpeg4"}, {"Xvid", "libxvid"}
                        };                     
                        break;
                    case "theora":
                        Bitrate = 1800;
                        CodecLevel = 0;
                        CodecLevels = null;
                        Encoder = "libtheora";
                        Encoders = new string[,] {
                            {"Theora", "libtheora"}
                        };                        
                        break;
                    case "vp8":
                        Bitrate = 1500;
                        CodecLevel = 0;
                        CodecLevels = null;
                        Encoder = "libvpx";
                        Encoders = new string[,] {
                            {"VPX", "libvpx"}
                        };                       
                        break;
                    case "vp9":
                        Bitrate = 1000;
                        CodecLevel = 0;
                        CodecLevels = null;
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
                        Encoder = "wmv2";
                        Encoders = new string[,] {
                            {"WMV 7 (wmv1)", "wmv1"}, {"WMV 8 (wmv2)", "wmv2"}
                        };                   
                        break;
                    default:
                        Bitrate = 1500;
                        CodecLevel = 0;
                        CodecLevels = null;
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
                        if (encoder == "libx264")
                        {
                            Profile = "main";
                            Profiles = new string[,] {
                                {"Baseline", "baseline"}, {"Main", "main"}, {"High", "high"}
                            };
                            EncoderPreset = "slow";
                        }
                        else
                        {
                            Profile = null;
                            Profiles = null;
                            EncoderPreset = "medium";
                        }

                        EncoderPreset = "medium";
                        EncoderPresets = new string[,] {
                            {"Ultra Fast", "ultrafast"}, {"Super Fast", "superfast"},
                            {"Very Fast", "veryfast"}, {"Faster", "faster"}, {"Fast", "fast"},
                            {"Medium", "medium"}, {"Slow", "slow"}, {"Slower", "slower"},
                            {"Very Slow", "veryslow"}, {"Placebo", "placebo"}
                        };
                        break;
                    case "h264_amf":
                    case "hevc_amf":
                        if (encoder == "h264_amf")
                        {
                            Profile = "main";
                            Profiles = new string[,] {
                                {"Baseline (Constrained)", "constrained_baseline"}, {"Main", "main"},
                                {"High", "high"}, {"High (Constrained)", ""}
                            };
                        }
                        else
                        {
                            Profile = null;
                            Profiles = null;
                        }

                        EncoderPreset = "transcoding";
                        EncoderPresets = new string[,] {
                            {"Transcoding", "transcoding"}, {"Ultra Low Latency", "ultralowlatency"},
                            {"Low Latency", "lowlatency"}, {"Webcam", "webcam"}
                        };
                        break;
                    case "nvenc_h264":
                    case "nvenc_hevc":
                        if (encoder == "nvenc_h264")
                        {
                            Profile = "main";
                            Profiles = new string[,] {
                                {"Baseline", "baseline"}, {"Main", "main"}, {"High", "high"}
                            };
                        }
                        else
                        {
                            Profile = null;
                            Profiles = null;
                        }

                        EncoderPreset = "slow";
                        EncoderPresets = new string[,] {
                            {"Slow", "slow"}, {"Medium", "medium"}, {"Fast", "fast"},
                            {"High Quality", "hq"}, {"Low Latency", "ll"}, {"Low Latency HQ", "llhq"},
                            {"Low Latency HP", "llhp"}, {"Lossless", "lossless"}, {"Lossless HP", "losslesshp"}
                        };
                        break;
                    default:
                        Profile = null;
                        Profiles = null;
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

        public string[,] MotionEstimateMethods
        {
            get { return meMethods; }
        }

        public string[,] PixelFormats
        {
            get { return pixelFormats; }
        }

        public Video()
        {
            Codec = "h264";
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
                        AutoAltRef = bool.TryParse(node["autoaltref"].InnerText, out bool autoAltRef) && autoAltRef;

                    if (node["frameparallel"] != null)
                        FrameParallel = bool.TryParse(node["frameparallel"].InnerText, out bool fParallel) && fParallel;

                    if (node["nonfree"] != null)
                        PreferNonfreeEncoder = bool.TryParse(node["nonfree"].InnerText, out bool nonfree) && nonfree;

                    if (node["twopass"] != null)
                        TwoPassEncoding = bool.TryParse(node["twopass"].InnerText, out bool twopass) && twopass;

                    if (node["vcodec"] != null)
                        Codec = node["vcodec"].InnerText;
                    else
                        Codec = "none";

                    if (node["vencoder"] != null)
                        Encoder = node["vencoder"].InnerText;

                    if (node["vprofile"] != null)
                        Profile = node["vprofile"].InnerText;

                    if (node["level"] != null)
                        CodecLevel = Double.TryParse(node["level"].InnerText, out double level) ? level : 0;

                    if (node["vpreset"] != null)
                        EncoderPreset = node["vpreset"].InnerText;

                    if (node["vb"] != null)
                    {
                        UseCRF = false;
                        Bitrate = int.TryParse(node["vb"].InnerText, out int vb) ? vb : 500;
                    }

                    if (node["maxvb"] != null)
                        MaxBitrate = int.TryParse(node["maxvb"].InnerText, out int maxVb) ? maxVb : 0;

                    if (node["buffersize"] != null)
                        BufferSize = int.TryParse(node["buffersize"].InnerText, out int bSize) ? bSize : 0;

                    if (node["bframes"] != null)
                        BFrames = int.TryParse(node["bframes"].InnerText, out int bFrames) ? bFrames : 0;

                    if (node["bfstrategy"] != null)
                        BFStrategy = int.TryParse(node["bfstrategy"].InnerText, out int bfStrat) ? bfStrat : 0;

                    if (node["cmp"] != null)
                        MotionEstimateCompare = int.TryParse(node["cmp"].InnerText, out int cmp) ? cmp : 0;

                    if (node["quality"] != null)
                    {
                        UseCRF = true;
                        Quality = int.TryParse(node["quality"].InnerText, out int crf) ? crf : 20;
                    }

                    if (node["diasize"] != null)
                        DiaSize = int.TryParse(node["diasize"].InnerText, out int diaSize) ? diaSize : 0;

                    if (node["gopsize"] != null)
                        GOPSize = int.TryParse(node["gopsize"].InnerText, out int gopSize) ? gopSize : 0;

                    if (node["laginframes"] != null)
                        LagInFrames = int.TryParse(node["laginframes"].InnerText, out int lagInFrames) ? lagInFrames : 0;

                    if (node["memethod"] != null)
                        MotionEstimateMethod = node["memethod"].InnerText;

                    if (node["pixformat"] !=null)
                        PixelFormat = node["pixformat"].InnerText;

                    if (node["qmin"] != null)
                        QMin = int.TryParse(node["qmin"].InnerText, out int qMin) ? qMin : 0;

                    if (node["qmax"] != null)
                        QMax = int.TryParse(node["qmax"].InnerText, out int qMax) ? qMax : 0;

                    if (node["subcmp"] != null)
                        MotionEstimateSubCompare = int.TryParse(node["subcmp"].InnerText, out int subCmp) ? subCmp : 0;

                    if (node["tilecolumns"] != null)
                        TileColumns = int.TryParse(node["tilecolumns"].InnerText, out int tileCols) ? tileCols : 0;

                    if (node["tilerows"] != null)
                        TileRows = int.TryParse(node["tilerows"].InnerText, out int tileRows) ? tileRows : 0;

                    if (node["trellis"] != null)
                        Trellis = int.TryParse(node["trellis"].InnerText, out int trellis) ? trellis : 0;

                    if (node["precmp"] != null)
                        MotionEstimatePreCompare = int.TryParse(node["precmp"].InnerText, out int preCmp) ? preCmp : 0;

                    if (node["mbcmp"] != null)
                        MacroBlockingCompare = int.TryParse(node["mbcmp"].InnerText, out int mbCmp) ? mbCmp : 0;
                }
            }
        }
    }
}