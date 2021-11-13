﻿// CopyAudio is part of FFmpeg Catapult.

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
    class CopyAudio : Audio
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
                return 0;
            }
        }

        public override int[] Bitrates
        {
            get
            {
                return new int[]
                {
                    0
                };
            }
        }

        public override int[] SampleRates
        {
            get
            {
                return new int[]
                {
                    0
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
                return "copy";
            }
        }

        public override string[,] Encoders
        {
            get
            {
                return new string[,]
                {
                    { "Copy", "Copy" }
                };
            }
        }

        public CopyAudio()
        {
            Encoder = "copy";
        }
    }
}