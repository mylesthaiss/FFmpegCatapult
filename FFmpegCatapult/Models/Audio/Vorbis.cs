// Vorbis is part of FFmpeg Catapult.

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
    class Vorbis : Audio
    {
        public override bool IsVBRSupported
        {
            get
            {
                return true;
            }
        }

        public override int MaxChannels
        {
            get
            {
                return 8;
            }
        }

        public override int[] Bitrates
        {
            get
            {
                return new int[]
                {
                    32, 64, 80, 96, 112, 128, 160, 192, 224,
                    256, 320, 500
                };
            }
        }

        public override int[] SampleRates
        {
            get
            {
                return new int[]
                {
                    8000, 11025, 16000, 22050, 32000, 44100,
                    48000, 96000, 192000
                };
            }
        }

        public override int[] VBRModes
        {
            get
            {
                return new int[]
                {
                    0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
                };
            }
        }

        public override string Codec
        {
            get
            {
                return "vorbis";
            }
        }

        public override string[,] Encoders
        {
            get
            {
                return new string[,]
                {
                    { "Vorbis (FFmpeg)", "vorbis" }, { "Vorbis", "libvorbis" }
                };
            }
        }

        public Vorbis()
        {
            Encoder = "libvorbis";
            Bitrate = 128;
        }
    }
}
