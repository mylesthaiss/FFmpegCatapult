// WebM is part of FFmpeg Catapult.

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
    class WebM : Container
    {
        public override string Format
        {
            get
            {
                return "webm";
            }
        }

        public override string[,] SupportedAudioCodecs
        {
            get
            {
                return new string[,]
                {
                    { "Opus", "opus" }, { "Vorbis", "vorbis" }, { "Copy", "copy" }, { "None", "none" }
                };
            }
        }

        public override string[,] SupportedVideoCodecs
        {
            get
            {
                return new string[,]
                {
                    { "VP8", "vp8" }, { "VP9", "vp9" }, { "Copy", "copy" }
                };
            }
        }
    }
}
