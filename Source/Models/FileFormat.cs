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

using System;
using System.Xml;

namespace FFmpegCatapult.Models
{
    class FileFormat : IFileFormat
    {
        private bool fastStart = false;
        private bool tagging;
        private string format;
        private string[,] audioCodecs;
        private string[,] videoCodecs;

        // Supported container formats
        private string[,] formats = new string[,] {
            {"3GP", "3gp"}, {"AVI", "avi"}, {"M4A", "m4a"}, {"Matroska", "mkv"}, {"MP3", "mp3"},
            {"MP4", "mp4"}, {"MPEG Program Stream", "mpg"}, {"MPEG Transport Stream", "ts"},
            {"Ogg", "ogg"}, {"WebM", "webm"}, {"Windows Media Audio", "wma"},
            {"Windows Media Video", "wmv"}, {"Custom", "custom"}
        };

        public string Format
        {
            get { return format; }
            set
            { 
                format = value;

                switch (format)
                {
                    case "3gp":
                        tagging = true;
                        audioCodecs = new string[,] {
                            { "AAC", "aac"}, { "HE-AAC", "heaac"}, { "Copy", "copy"}
                        };

                        videoCodecs = new string[,] {
                            {"H.263", "h263"}, {"H.264", "h264"}, {"MPEG-4", "mpeg4"},
                            {"Copy", "copy"}, {"None", "none"}
                        };
                        break;
                    case "avi":
                    case "mkv":
                        tagging = true;
                        audioCodecs = new string[,] {
                            {"AC3", "ac3"}, {"AAC", "aac"}, {"FLAC", "flac"}, {"HE-AAC", "heaac"},
                            {"MP2", "mp2"}, {"MP3", "mp3"}, {"Opus", "opus"}, {"PCM", "pcm"},
                            {"Speex", "speex"}, {"Vorbis", "vorbis"}, {"WMA", "wma"},
                            {"Copy", "copy"}, {"None", "none"}
                        };

                        videoCodecs = new string[,] {
                            {"AV1", "av1" }, {"H.264", "h264"}, {"H.265", "h265"}, {"MPEG-2", "mpeg2"},
                            {"MPEG-4", "mpeg4"}, {"Theora", "theora"}, {"VP8", "vp8"}, {"VP9", "vp9"},
                            {"WMV", "wmv"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        break;
                    case "m4a":
                        tagging = true;
                        audioCodecs = new string[,] {
                            {"AAC", "aac"}, {"HE-AAC", "heaac"}, {"Copy", "copy"}
                        };

                        videoCodecs = new string[,] {
                            {"None", "none"}
                        };
                        break;
                    case "mp4":
                        tagging = true;
                        audioCodecs = new string[,] {
                            {"AC-3", "ac3"}, {"AAC", "aac"}, {"HE-AAC", "heaac"},
                            {"MP3", "mp3"}, {"Copy", "copy"}, {"None", "none"}
                        };

                        videoCodecs = new string[,] {
                            {"H.264", "h264"}, {"H.265", "h265"}, {"MPEG-2", "mpeg2"},
                            {"MPEG-4", "mpeg4"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        break;
                    case "mpg":
                        tagging = false;
                        audioCodecs = new string[,] {
                            {"MP2", "mp2"}, {"MP3", "mp3"}, {"Copy", "copy"}, {"None", "none"}
                        };

                        videoCodecs = new string[,] {
                            {"MPEG-2", "mpeg2"}, {"Copy", "copy"}
                        };
                        break;
                    case "ts":
                        tagging = false;
                        audioCodecs = new string[,] {
                            {"AC-3", "ac3"}, {"AAC", "aac"}, {"MP2", "mp2"},
                            {"MP3", "mp3"}, {"Copy", "copy"}, {"None", "none"}
                        };

                        videoCodecs = new string[,] {
                            {"H.264", "h264"}, {"MPEG-2", "mpeg2"}, {"Copy", "copy"}
                        };
                        break;
                    case "ogg":
                        tagging = true;
                        audioCodecs = new string[,] {
                            {"FLAC", "flac"}, {"Opus", "opus"}, {"Speex", "speex"},
                            {"Vorbis", "vorbis"}, {"Copy", "copy"}, {"None", "none"}
                        };

                        videoCodecs = new string[,] {
                            {"Theora", "theora"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        break;
                    case "webm":
                        tagging = true;
                        audioCodecs = new string[,] {
                            {"Opus", "opus"}, {"Vorbis", "vorbis"}, {"Copy", "copy"}, {"None", "none"}
                        };

                        videoCodecs = new string[,] {
                            {"VP8", "vp8"}, {"VP9", "vp9"}, {"Copy", "copy"}
                        };
                        break;
                    case "wma":
                        tagging = true;
                        audioCodecs = new string[,] {
                            {"WMA", "wma"}, {"Copy", "copy"}
                        };

                        videoCodecs = new string[,] {
                            {"None", "none"}
                        };
                        break;
                    case "wmv":
                        tagging = true;
                        audioCodecs = new string[,] {
                            {"WMA", "wma"}, {"Copy", "copy"}, {"None", "none"}
                        };

                        videoCodecs = new string[,] {
                            {"WMV", "wmv"}, {"Copy", "copy"}
                        };
                        break;
                }
            }
        }

        public string[,] Formats
        {
            get { return formats; }
        }

        public string[,] SupportedAudioCodecs
        {
            get { return audioCodecs; }
        }

        public string[,] SupportedVideoCodecs
        {
            get { return videoCodecs; }
        }

        public bool FastStartTagging
        {
            get { return fastStart; }
            set
            {
                switch (format)
                {
                    case "mp4":
                    case "m4a":
                    case "mov":
                        fastStart = value;
                        break;
                    default:
                        fastStart = false;
                        break;
                }
            }
        }

        public bool Tagging
        {
            get { return tagging; }
        }

        public bool IsAudioCodecSupported(string codec)
        {
            foreach (var audioCodec in audioCodecs)
            {
                if (audioCodec.Contains(codec))
                    return true;
            }

            return false;           
        }

        public bool IsVideoCodecSupported(string codec)
        {
            foreach (var videoCodec in videoCodecs)
            {
                if (videoCodec.Contains(codec))
                    return true;
            }

            return false;
        }

        public FileFormat()
        {
            Format = "avi";
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
                    {
                        Format = node["format"].InnerText;
                    }

                    if (node["faststart"] != null)
                    {
                        FastStartTagging = Convert.ToBoolean(node["faststart"].InnerText);
                    }                        
                }
            }
        }
    }
}
