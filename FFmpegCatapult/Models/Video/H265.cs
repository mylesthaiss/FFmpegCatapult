// H265 is part of FFmpeg Catapult.

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
    class H265 : Video
    {
        private string encoder;

        public override string Codec
        {
            get
            {
                return "h265";
            }
        }

        public override double[] CodecLevels
        {
            get
            { 
                return null;
            }
        }

        public override string Encoder
        {
            get
            {
                return encoder;
            }
            set
            {
                encoder = value;

                switch (value)
                {
                    case "libx265":
                        EncoderPreset = "medium";
                        break;
                    case "nvenc_hevc":
                        EncoderPreset = "slow";
                        break;
                    case "hevc_amf":
                        EncoderPreset = "transcoding";
                        break;
                    default:
                        EncoderPreset = null;
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
                    { "AMD AMF", "hevc_amf" }, { "Nvidia NVENC", "nvenc_hevc" }, { "x265", "libx265" }
                };
            }
        }

        public override string[,] EncoderPresets
        {
            get
            {
                switch (Encoder)
                {
                    case "libx265":
                        return new string[,]
                        {
                            { "Ultra Fast", "ultrafast" }, { "Super Fast", "superfast" },
                            { "Very Fast", "veryfast" }, { "Faster", "faster" }, { "Fast", "fast" },
                            { "Medium", "medium" }, { "Slow", "slow" }, { "Slower", "slower" },
                            { "Very Slow", "veryslow" }, { "Placebo", "placebo" }
                        };
                    case "hevc_amf":
                        return new string[,]
                        {
                            { "Transcoding", "transcoding" }, { "Ultra Low Latency", "ultralowlatency" },
                            { "Low Latency", "lowlatency" }, { "Webcam", "webcam" }
                        };
                    case "nvenc_hevc":
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

        public H265()
        {
            UseCRF = true;
            Quality = 28;
            Encoder = "libx265";
            Bitrate = 768;
        }
    }
}
