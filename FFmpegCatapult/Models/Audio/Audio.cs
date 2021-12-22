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

namespace FFmpegCatapult.Models
{
    public abstract class Audio : IAudio
    {
        public abstract bool IsVBRSupported { get; }
        public abstract int MaxChannels { get; }
        public abstract int[] SampleRates { get; }
        public abstract int[] VBRModes { get; }
        public abstract string Codec { get; }
        public abstract string[,] Encoders { get; }
        public virtual bool PreferNonfreeEncoder { get; set; }
        public virtual bool UseVBR { get; set; }
        public virtual int Bitrate { get; set; }
        public virtual int Channels { get; set; }
        public virtual int CompressionLevel { get; set; } = 0;
        public virtual int HighPass { get; set; } = 0;
        public virtual int LowPass { get; set; } = 0;
        public virtual int Quality { get; set; }
        public virtual int ResamplerPrecision { get; set; }
        public virtual int SampleRate { get; set; }
        public virtual int VolumeBoost { get; set; } = 0;
        public virtual string DitherMethod { get; set; }
        public virtual string Encoder { get; set; }
        public virtual string EncoderPreset { get; set; } = null;
        public virtual string Profile { get; set; } = null;
        public virtual string Resampler { get; set; } = "soxr";

        public virtual int[] Bitrates
        {
            get
            {
                return new int[] { };
            }
        }

        public virtual int[] CompressionLevels
        {
            get
            {
                return new int[] { };
            }
        }

        public virtual string[,] DitherMethods
        {
            get
            {
                return new string[,]
                {
                    { "Rectangular", "rectangular" }, { "Triangular", "triangular" }, { "High-pass Triangular", "triangular_hp" },
                    { "Lipshitz", "lipshitz" }, { "Shibata", "shibata" }, { "Low Shibata", "low_shibta" },
                    { "High Shibata", "high_shibata" }, { "F-weighted", "f_weighted" }, { "Modified e-weighted", "modified_e_weighted" },
                    { "Improved e-weighted", "improved_e_weighted" }
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

        public virtual string[,] Profiles
        {
            get
            {
                return new string[,] { };
            }
        }

        public virtual string[,] Resamplers
        {
            get
            {
                return new string[,]
                {
                    { "SW", "swr" }, { "SoX", "soxr" }
                };
            }
        }
    }
}
