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

namespace FFmpegCatapult.Models
{
    public abstract class Video : IVideo
    {
        public abstract string Codec { get; }
        public abstract string[,] Encoders { get; }
        public virtual bool AutoAltRef { get; set; }
        public virtual bool FrameParallel { get; set; }
        public virtual bool PreferNonfreeEncoder { get; set; } = false;
        public virtual bool TwoPassEncoding { get; set; } = false;
        public virtual bool UseCRF { get; set; } = false;
        public virtual double CodecLevel { get; set; }
        public virtual int BFrames { get; set; }
        public virtual int BFStrategy { get; set; }
        public virtual int Bitrate { get; set; }
        public virtual int BufferSize { get; set; }
        public virtual int DiaSize { get; set; }
        public virtual int GOPSize { get; set; }
        public virtual int LagInFrames { get; set; }
        public virtual int MacroBlockingCompare { get; set; }
        public virtual int MaxBitrate { get; set; }
        public virtual int MinBitrate { get; set; }
        public virtual int MotionEstimateCompare { get; set; }
        public virtual int MotionEstimatePreCompare { get; set; }
        public virtual int MotionEstimateSubCompare { get; set; }
        public virtual int QMax { get; set; }
        public virtual int QMin { get; set; }
        public virtual int Quality { get; set; }
        public virtual int Speed { get; set; }
        public virtual int TargetSize { get; set; }
        public virtual int TileColumns { get; set; }
        public virtual int TileRows { get; set; }
        public virtual int Trellis { get; set; }
        public virtual string Encoder { get; set; }
        public virtual string EncoderPreset { get; set; }
        public virtual string MotionEstimateMethod { get; set; }
        public virtual string PixelFormat { get; set; }
        public virtual string Profile { get; set; }

        public virtual double[] CodecLevels
        {
            get
            {
                return new double[] { };
            }
        }

        public virtual int MaxSupportedBitrate
        {
            get
            {
                return 80000;
            }
        }

        public virtual int MaxSupportBufferSize
        {
            get 
            { 
                return 10; 
            }
        }

        public virtual int MaxSupportGOPSize
        {
            get
            {
                return 120;
            }
        }

        public virtual int MaxSupportedTargetFileSize
        {
            get
            {
                return 4096;
            }
        }

        public string[] CompareFunctions
        {
            get
            {
                return new string[]
                {
                    "sad", "sse", "satd", "dct", "psnr", "bit", "rd", "zero", "vsad",
                    "vsse", "nsse", "w53", "w97", "dctmax", "chroma", "Default"
                };
            }
        }

        public virtual string[,] EncoderPresets
        {
            get
            {
                return new string[,] { };
            }
        }

        public string[,] MotionEstimateMethods
        {
            get
            {
                return new string[,]
                {
                    { "Zero", "zero" }, { "Full", "full" }, { "EPZS", "epzs" }, { "Esa", "esa" },
                    { "Tesa", "tesa" }, { "Dia", "dia" }, { "Log", "log" }, { "Phods", "phods" },
                    { "X1", "x1" }, { "Hex", "hex" }, { "Umh", "umh" }, { "Iter", "iter" },
                    { "Default", null }
                };
            }
        }

        public virtual string[,] PixelFormats
        {
            get
            {
                return new string[,]
                {
                    { "YUV 4:2:0", "yuv420p" }, { "YUYV 4:2:2", "yuyv422" }, { "RGB 24", "rgb24" },
                    { "BGR 24", "bgr24" }, { "YUV 4:2:2", "yuv422p" }, { "YUV 4:4:4", "yuv44p" },
                    { "YUV 4:1:0", "yuv410p" }, { "YUV 4:1:1", "yuv411p" }, { "Gray", "gray" },
                    { "Default", null }
                };
            }
        }

        public virtual string[,] Profiles
        {
            get
            {
                return new string[,] { };
            }
        }
    }
}