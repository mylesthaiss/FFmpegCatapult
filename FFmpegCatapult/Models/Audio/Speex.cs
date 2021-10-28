// Speex is part of FFmpeg Catapult.

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
    class Speex : Audio
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
                return 8;
            }
        }

        public override int[] Bitrates
        {
            get
            {
                return new int[]
                {
                    2, 4, 8, 16, 24, 32, 40, 44
                };
            }
        }

        public override int[] SampleRates
        {
            get
            {
                return new int[]
                {
                    8000, 16000, 22050, 32000, 44100, 48000
                };
            }
        }

        public override int[] VBRModes
        {
            get
            {
                return null;
            }
        }

        public override string Codec
        {
            get
            {
                return "speex";
            }
        }

        public override string[,] Encoders
        {
            get
            {
                return new string[,]
                {
                    { "Speex", "libspeex" }
                };
            }
        }

        public Speex()
        {
            Encoder = "libspeex";
            Bitrate = 24;
        }
    }
}
