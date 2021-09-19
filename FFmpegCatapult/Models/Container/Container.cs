// Container is part of FFmpeg Catapult.

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
    public abstract class Container : IContainer
    {
        public abstract string Format { get; }
        public virtual bool Compilation { get; set; } = false;
        public virtual bool FastStartSupported { get; private set; } = false;
        public virtual bool FastStartTagging { get; set; } = false;
        public virtual bool Tagging { get; private set; } = true;
        public virtual int Disc { get; set; } = 0;
        public virtual int TotalDiscs { get; set; } = 0;
        public virtual int TotalTracks { get; set; } = 0;
        public virtual int Track { get; set; } = 0;
        public virtual int Year { get; set; } = 0;
        public virtual string Album { get; set; }
        public virtual string AlbumArtist { get; set; }
        public virtual string Artist { get; set; }
        public virtual string Comment { get; set; }
        public virtual string Copyright { get; set; }
        public virtual string Description { get; set; }
        public virtual string EpisodeId { get; set; }
        public virtual string Genre { get; set; }
        public virtual string Network { get; set; }
        public virtual string Publisher { get; set; }
        public virtual string Show { get; set; }
        public virtual string Synopsis { get; set; }
        public virtual string Title { get; set; }

        public virtual string DefaultFileExtension
        {
            get
            {
                return Format.ToLower();
            }
        }

        public virtual string[,] SupportedAudioCodecs 
        {             
            get
            {
                return new string[,]
                {
                    { "AC3", "ac3" }, { "AAC", "aac" }, { "FLAC", "flac" }, { "HE-AAC", "heaac" },
                    { "MP2", "mp2" }, { "MP3", "mp3" }, { "Opus", "opus" }, { "PCM", "pcm" },
                    { "Speex", "speex" }, { "Vorbis", "vorbis" }, { "WMA", "wma" },
                    { "Copy", "copy" }, { "None", "none" }
                };
            }
        }

        public virtual string[,] SupportedVideoCodecs
        {
            get
            {
                return new string[,]
                {
                    { "AV1", "av1" }, { "H.264", "h264" }, { "H.265", "h265" }, { "MPEG-2", "mpeg2" },
                    { "MPEG-4", "mpeg4" }, { "Theora", "theora" }, { "VP8", "vp8" }, { "VP9", "vp9" },
                    { "WMV", "wmv" }, { "Copy", "copy" }, { "None", "none" }
                };
            }
        }

        public bool IsCodecSupported(IOutput stream)
        {
            string[,] codecs;

            if (stream is Audio)
            {
                // Vorbis in a AVI container is possible, but not recommended.
                if (Format == "avi" && stream.Codec == "vorbis")
                    return false;

                codecs = SupportedAudioCodecs;
            }
            else
            {
                codecs = SupportedVideoCodecs;
            }

            foreach (var codec in codecs)
            {
                if (codec.Contains(stream.Codec))
                    return true;
            }

            return false;
        }
    }
}
