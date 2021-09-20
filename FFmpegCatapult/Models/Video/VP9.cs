// VP9 is part of FFmpeg Catapult.

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
    class VP9 : Video
    {
        public override string Codec
        {
            get
            {
                return "vp9";
            }
        }

        public override string[,] Encoders
        {
            get
            {
                return new string[,]
                {
                    { "VPX", "libvpx-vp9" }
                };
            }
        }

        public VP9()
        {
            AutoAltRef = true;
            Bitrate = 1000;
            Encoder = "libvpx-vp9";
            FrameParallel = true;
            LagInFrames = 25;
            Speed = 1;
            TileColumns = 6;
        }
    }
}
