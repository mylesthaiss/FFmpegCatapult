// MPEG4 is part of FFmpeg Catapult.

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
    class MP43GP : Container
    {
        public override string Format
        {
            get
            {
                return "3gp";
            }
        }

        public override string[,] SupportedAudioCodecs
        {
            get
            {
                return new string[,]
                {
                    { "AAC", "aac" }, { "HE-AAC", "heaac" }, { "Copy", "copy" }
                };
            }
        }

        public override string[,] SupportedVideoCodecs
        {
            get
            {
                return new string[,]
                {
                    { "H.263", "h263" }, { "H.264", "h264" }, { "MPEG-4", "mpeg4" },
                    { "Copy", "copy" }, { "None", "none" }
                };
            }
        }
    }

    class MP4 : Container
    {
        public override bool FastStartSupported
        {
            get
            {
                return true;
            }
        }

        public override string Format
        {
            get
            {
                return "mp4";
            }
        }

        public override string[,] SupportedAudioCodecs
        {
            get
            {
                return new string[,]
                {
                    { "AC-3", "ac3" }, { "AAC", "aac" }, { "HE-AAC", "heaac" },
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
                    { "H.264", "h264" }, { "H.265", "h265" }, { "MPEG-2", "mpeg2" },
                    { "MPEG-4", "mpeg4" }, { "Copy", "copy" }, { "None", "none" }
                };
            }
        }
    }

    class MP4Audio : Container
    {
        public override bool FastStartSupported
        {
            get
            {
                return true;
            }
        }

        public override string Format
        {
            get
            {
                return "m4a";
            }
        }

        public override string[,] SupportedAudioCodecs
        {
            get
            {
                return new string[,]
                {
                    { "AAC", "aac" }, { "HE-AAC", "heaac" }, { "Copy", "copy" }, { "None", "none" }
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
