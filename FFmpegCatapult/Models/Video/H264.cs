// H264 is part of FFmpeg Catapult.

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

namespace FFmpegCatapult.Models
{
    class H264 : Video
    {
        private string encoder = "libx264";

        public override string Codec
        {
            get
            {
                return "h264";
            }
        }

        public override double[] CodecLevels
        {
            get
            {
                return new double[]
                {
                    1.0, 1.1, 1.2, 1.3, 2.0, 2.1, 2.2, 3.0, 3.1, 3.2, 4.0, 4.1,
                    4.2, 5.0, 5.1, 5.2, 6.0, 6.1, 6.2
                };
            }
        }

        public override string Encoder
        {
            get { return encoder; }
            set
            {
                encoder = value;

                switch (value)
                {
                    case "libx264":
                        EncoderPreset = "slow";
                        BFStrategy = 1;
                        break;
                    case "nvenc_h264":
                        EncoderPreset = "slow";
                        BFStrategy = 0;
                        break;
                    case "h264_amf":
                        EncoderPreset = "transcoding";
                        BFStrategy = 0;
                        break;
                    default:
                        EncoderPreset = null;
                        BFStrategy = 0;
                        break;
                }
            }
        }

        public override string[,] Encoders
        {
            get
            {
                return new string[,]
                {
                    { "AMD AMF", "h264_amf" }, { "Nvidia NVENC", "nvenc_h264" }, { "x264", "libx264" }
                };
            }
        }

        public override string[,] EncoderPresets
        {
            get
            {
                switch (Encoder)
                {
                    case "libx264":
                        return new string[,]
                        {
                            { "Ultra Fast", "ultrafast" }, { "Super Fast", "superfast" },
                            { "Very Fast", "veryfast" }, { "Faster", "faster" }, { "Fast", "fast" },
                            { "Medium", "medium" }, { "Slow", "slow" }, { "Slower", "slower" },
                            { "Very Slow", "veryslow" }, { "Placebo", "placebo" }
                        };
                    case "h264_amf":
                        return new string[,]
                        {
                            { "Transcoding", "transcoding" }, { "Ultra Low Latency", "ultralowlatency" },
                            { "Low Latency", "lowlatency" }, { "Webcam", "webcam" }
                        };
                    case "nvenc_h264":
                        return new string[,]
                        {
                            { "Slow", "slow" }, { "Medium", "medium" }, { "Fast", "fast" },
                            { "High Quality", "hq" }, { "Low Latency", "ll" }, { "Low Latency HQ", "llhq" },
                            { "Low Latency HP", "llhp" }, { "Lossless", "lossless" }, { "Lossless HP", "losslesshp" }
                        };
                    default:
                        return null;
                }
            }
        }

        public override string[,] Profiles
        {
            get
            {
                switch (Encoder)
                {
                    case "h264_amf":
                        return new string[,]
                        {
                            { "Baseline (Constrained)", "constrained_baseline" }, { "Main", "main" },
                            { "High", "high" }, { "High (Constrained)", "" }
                        };
                    default:
                        return new string[,]
                        {
                            { "Baseline", "baseline" }, { "Main", "main" }, { "High", "high" }
                        };
                }
            }
        }

        public H264()
        {
            Bitrate = 1000;
            Encoder = "libx264";
            Quality = 20;
        }
    }
}
