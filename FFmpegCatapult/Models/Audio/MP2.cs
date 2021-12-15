// MP2 is part of FFmpeg Catapult.

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
    class MP2 : Audio
    {
        public override bool IsVBRSupported
        {
            get
            {
                return false;
            }
        }

        public override int MaxChannels
        {
            get
            {
                return 2;
            }
        }

        public override int[] Bitrates
        {
            get
            {
                switch (SampleRate)
                {
                    case 16000:
                    case 22050:
                    case 24000:
                        // Low-freq MP2 bitrates
                        return new int[]
                        {
                            8, 16, 24, 32, 40, 48, 56, 64, 80, 96, 112, 128,
                            144, 160
                        };
                    default:
                        // Standard MP2 bitrates
                        return new int[]
                        {
                            32, 48, 56, 64, 80, 96, 112, 128, 160, 192,
                            224, 256, 320, 384
                        };
                }
            }
        }

        public override int[] SampleRates
        {
            get
            {
                return new int[]
                {
                    16000, 22050, 24000, 32000, 44100, 48000
                };
            }
        }

        public override int[] VBRModes
        {
            get
            {
                return new int[] { };
            }
        }

        public override string Codec
        {
            get
            {
                return "mp2";
            }
        }

        public override string[,] Encoders
        {
            get
            {
                return new string[,]
                {
                    { "MP2 (FFmpeg)", "mp2" }, { "TwoLAME", "libtwolame" }
                };
            }
        }

        public MP2()
        {
            Encoder = "libtwolame";
            Bitrate = 224;
        }
    }
}
