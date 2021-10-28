// MPEG is part of FFmpeg Catapult.

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
    class MPG : Container
    {
        public override bool Tagging
        {
            get
            {
                return false;
            }
        }

        public override string Format
        {
            get
            {
                return "mpg";
            }
        }

        public override string[,] SupportedAudioCodecs
        {
            get
            {
                return new string[,]
                {
                    { "MP2", "mp2" }, { "MP3", "mp3" }, { "Copy", "copy" }, { "None", "none" }
                };
            }
        }

        public override string[,] SupportedVideoCodecs
        {
            get
            {
                return new string[,]
                {
                    { "MPEG-2", "mpeg2" }, { "Copy", "copy" }
                };
            }
        }
    }

    class MPEGTS : Container
    {
        public override bool Tagging
        {
            get
            {
                return false;
            }
        }

        public override string DefaultFileExtension
        {
            get
            {
                return "ts";
            }
        }

        public override string Format
        {
            get
            {
                return "mpegts";
            }
        }

        public override string[,] SupportedAudioCodecs
        {
            get
            {
                return new string[,]
                {
                    { "AC-3", "ac3" }, { "AAC", "aac" }, { "MP2", "mp2" },
                    { "MP3", "mp3" }, { "Copy", "copy" }, { "None", "none" }
                };
            }
        }

        public override string[,] SupportedVideoCodecs
        {
            get
            {
                return new string[,]
                {
                    { "H.264", "h264" }, { "MPEG-2", "mpeg2" }, { "Copy", "copy" }
                };
            }
        }
    }

    class MP3Stream : Container
    {
        public override string Format
        {
            get
            {
                return "mp3";
            }
        }

        public override string[,] SupportedAudioCodecs
        {
            get
            {
                return new string[,]
                {
                    { "MP3", "mp3" }, { "Copy", "copy" }
                };
            }
        }

        public override string[,] SupportedVideoCodecs
        {
            get
            {
                return new string[,]
                {
                    { "None", "none" }
                };
            }
        }
    }
}
