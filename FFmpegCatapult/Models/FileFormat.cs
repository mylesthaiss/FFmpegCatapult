// FileFormat is part of FFmpeg Catapult.

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

using System.Xml;

namespace FFmpegCatapult.Models
{
    class FileFormat : IFileFormat
    {
        private bool fastStart = false;
        private string format;
        private string[,] formats = new string[,] {
            {"3GP", "3gp"}, {"AVI", "avi"}, {"M4A", "m4a"}, {"Matroska", "mkv"}, {"MP3", "mp3"},
            {"MP4", "mp4"}, {"MPEG Program Stream", "mpg"}, {"MPEG Transport Stream", "ts"},
            {"Ogg", "ogg"}, {"WebM", "webm"}, {"Windows Media Audio", "wma"},
            {"Windows Media Video", "wmv"}, {"Custom", "custom"}
        };

        public bool Tagging { get; private set; }
        public string[,] SupportedAudioCodecs { get; private set; }
        public string[,] SupportedVideoCodecs { get; private set; }

        public string Format
        {
            get { return format; }
            set
            { 
                format = value;

                switch (format)
                {
                    case "3gp":
                        Tagging = true;
                        SupportedAudioCodecs = new string[,] {
                            { "AAC", "aac"}, { "HE-AAC", "heaac"}, { "Copy", "copy"}
                        };
                        SupportedVideoCodecs = new string[,] {
                            {"H.263", "h263"}, {"H.264", "h264"}, {"MPEG-4", "mpeg4"},
                            {"Copy", "copy"}, {"None", "none"}
                        };
                        break;
                    case "avi":
                    case "mkv":
                        Tagging = true;
                        SupportedAudioCodecs = new string[,] {
                            {"AC3", "ac3"}, {"AAC", "aac"}, {"FLAC", "flac"}, {"HE-AAC", "heaac"},
                            {"MP2", "mp2"}, {"MP3", "mp3"}, {"Opus", "opus"}, {"PCM", "pcm"},
                            {"Speex", "speex"}, {"Vorbis", "vorbis"}, {"WMA", "wma"},
                            {"Copy", "copy"}, {"None", "none"}
                        };
                        SupportedVideoCodecs = new string[,] {
                            {"AV1", "av1" }, {"H.264", "h264"}, {"H.265", "h265"}, {"MPEG-2", "mpeg2"},
                            {"MPEG-4", "mpeg4"}, {"Theora", "theora"}, {"VP8", "vp8"}, {"VP9", "vp9"},
                            {"WMV", "wmv"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        break;
                    case "m4a":
                        Tagging = true;
                        SupportedAudioCodecs = new string[,] {
                            {"AAC", "aac"}, {"HE-AAC", "heaac"}, {"Copy", "copy"}
                        };
                        SupportedVideoCodecs = new string[,] {
                            {"None", "none"}
                        };
                        break;
                    case "mp4":
                        Tagging = true;
                        SupportedAudioCodecs = new string[,] {
                            {"AC-3", "ac3"}, {"AAC", "aac"}, {"HE-AAC", "heaac"},
                            {"MP3", "mp3"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        SupportedVideoCodecs = new string[,] {
                            {"H.264", "h264"}, {"H.265", "h265"}, {"MPEG-2", "mpeg2"},
                            {"MPEG-4", "mpeg4"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        break;
                    case "mpg":
                        Tagging = false;
                        SupportedAudioCodecs = new string[,] {
                            {"MP2", "mp2"}, {"MP3", "mp3"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        SupportedVideoCodecs = new string[,] {
                            {"MPEG-2", "mpeg2"}, {"Copy", "copy"}
                        };
                        break;
                    case "ts":
                        Tagging = false;
                        SupportedAudioCodecs = new string[,] {
                            {"AC-3", "ac3"}, {"AAC", "aac"}, {"MP2", "mp2"},
                            {"MP3", "mp3"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        SupportedVideoCodecs = new string[,] {
                            {"H.264", "h264"}, {"MPEG-2", "mpeg2"}, {"Copy", "copy"}
                        };
                        break;
                    case "ogg":
                        Tagging = true;
                        SupportedAudioCodecs = new string[,] {
                            {"FLAC", "flac"}, {"Opus", "opus"}, {"Speex", "speex"},
                            {"Vorbis", "vorbis"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        SupportedVideoCodecs = new string[,] {
                            {"Theora", "theora"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        break;
                    case "webm":
                        Tagging = true;
                        SupportedAudioCodecs = new string[,] {
                            {"Opus", "opus"}, {"Vorbis", "vorbis"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        SupportedVideoCodecs = new string[,] {
                            {"VP8", "vp8"}, {"VP9", "vp9"}, {"Copy", "copy"}
                        };
                        break;
                    case "wma":
                        Tagging = true;
                        SupportedAudioCodecs = new string[,] {
                            {"WMA", "wma"}, {"Copy", "copy"}
                        };
                        SupportedVideoCodecs = new string[,] {
                            {"None", "none"}
                        };
                        break;
                    case "wmv":
                        Tagging = true;
                        SupportedAudioCodecs = new string[,] {
                            {"WMA", "wma"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        SupportedVideoCodecs = new string[,] {
                            {"WMV", "wmv"}, {"Copy", "copy"}
                        };
                        break;
                    case "mp3":
                        Tagging = true;
                        SupportedAudioCodecs = new string[,] {
                            {"MP3", "mp3" }, {"Copy", "copy"}
                        };
                        SupportedVideoCodecs = new string[,] {
                            {"None", "none"}
                        };
                        break;
                }
            }
        }

        public string[,] Formats
        {
            get { return formats; }
        }

        public bool FastStartTagging
        {
            get { return !IsFastStartSupported() ? false : fastStart; }
            set { fastStart = value; }
        }

        public FileFormat()
        {
            Format = "mp4";
        }

        public FileFormat(string xmlPath, string presetName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            string path = @"/presets/preset[@name='" + presetName + @"']";
            XmlNodeList nodes = doc.SelectNodes(path);

            foreach (XmlNode node in nodes)
            {
                if (node != null)
                {
                    if (node["format"] != null)
                        Format = node["format"].InnerText;

                    if (node["faststart"] != null)
                        FastStartTagging = bool.TryParse(node["faststart"].InnerText, out bool fStart) && fStart;                  
                }
            }
        }

        public bool IsCodecSupported(IOutput stream)
        {
            string[,] codecs;

            if (stream is Audio)
            {
                // Vorbis in a AVI container is possible, but not recommended.
                if (format == "avi" && stream.Codec == "vorbis")
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

        public bool IsFastStartSupported() 
        {
            switch (format)
            {
                case "mp4":
                case "m4a":
                case "mov":
                    return true;
                default:
                    return false;
            }
        }
    }
}
