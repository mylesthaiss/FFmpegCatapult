﻿// File is part of FFmpeg Catapult.

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

using System.IO;

namespace FFmpegCatapult
{
    class File : Methods
    {
        // Variables
        private static string audio = "";
        private static string format = "";
        private static string input = "";
        private static string log = "";
        private static string output = "";

        // Container formats
        private static string[,] formats = new string[,]
        {
            {"3GP", "3gp"}, {"AVI", "avi"}, {"M4A", "m4a"}, {"Matroska", "mkv"}, {"MP3", "mp3"}, 
            {"MP4", "mp4"}, {"MPEG Program Stream", "mpg"}, {"MPEG Transport Stream", "ts"},
            {"Ogg", "ogg"}, {"WebM", "webm"}, {"Windows Media Audio", "wma"},
            {"Windows Media Video", "wmv"}, {"Custom", "custom"}
        };

        // Property methods
        public static string AudioStream
        {
            get { return audio; }
            set { audio = value; }
        }

        /// <summary>
        /// Stores file container value and determines available supported audio 
        /// and video codecs. Unsupported codec values will be changed to default.
        /// </summary>
        public static string Format
        {
            get { return format; }
            set
            {
                format = value;

                switch (format)
                {
                    case "3gp":
                        Audio.Codecs = new string[,] {
                            {"AAC", "aac"}, {"HE-AAC", "heaac"}, {"Copy", "copy"}
                        };
                        Video.Codecs = new string[,] {
                            {"H.263", "h263"}, {"H.264", "h264"}, {"MPEG-4", "mpeg4"},
                             {"Copy", "copy"}, {"None", "none"}
                        };
                        if (!IsValid(Audio.Codec, Audio.Codecs))
                        {
                            Audio.Codec = "heaac";
                        }
                        if (!IsValid(Video.Codec, Video.Codecs))
                        {
                            Video.Codec = "h264";
                        }
                        break;
                    case "avi":
                    case "custom":
                    case "mkv":
                        Audio.Codecs = new string[,] {
                            {"AC3", "ac3"}, {"AAC", "aac"}, {"FLAC", "flac"}, {"HE-AAC", "heaac"},
                            {"MP2", "mp2"}, {"MP3", "mp3"}, {"Opus", "opus"}, {"PCM", "pcm"},
                            {"Speex", "speex"}, {"Vorbis", "vorbis"}, {"WMA", "wma"},
                            {"Copy", "copy"}, {"None", "none"}
                        };
                        Video.Codecs = new string[,] {
                            {"H.264", "h264"}, {"H.265", "h265"}, {"MPEG-2", "mpeg2"}, {"MPEG-4", "mpeg4"},
                            {"Theora", "theora"}, {"VP8", "vp8"}, {"VP9", "vp9"}, {"WMV", "wmv"},
                            {"Copy", "copy"}, {"None", "none"}
                        };

                        // Using Vorbis with AVI is not recommended.
                        if (format == "avi" && Audio.Codec == "vorbis")
                        {
                            Audio.Codec = "mp3";
                        }                    
                        break;
                    case "m4a":
                        Audio.Codecs = new string[,] {
                            {"AAC", "aac"}, {"HE-AAC", "heaac"}, {"Copy", "copy"}
                        };
                        Video.Codecs = new string[,] {
                            {"None", "none"}
                        };
                        if (!IsValid(Audio.Codec, Audio.Codecs))
                        {
                            Audio.Codec = "aac";
                        }
                        break;                    
                    case "mp3":
                        Audio.Codecs = new string[,]
                        {
                            {"MP3", "mp3"}, {"Copy", "copy"}
                        };
                        Video.Codecs = new string[,]
                        {
                            {"None", "none"}
                        };
                        if (!IsValid(Audio.Codec, Audio.Codecs))
                        {
                            Audio.Codec = "mp3";
                        }
                        break;
                    case "mp4":
                        Audio.Codecs = new string[,]
                        {
                            {"AC-3", "ac3"}, {"AAC", "aac"}, {"HE-AAC", "heaac"},
                            {"MP3", "mp3"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        Video.Codecs = new string[,]
                        {
                            {"H.264", "h264"}, {"H.265", "h265"}, {"MPEG-2", "mpeg2"}, 
                            {"MPEG-4", "mpeg4"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        if (!IsValid(Audio.Codec, Audio.Codecs) | Audio.Codec == "mp3")
                        {
                            Audio.Codec = "aac";
                        }
                        if (!IsValid(Video.Codec, Video.Codecs))
                        {
                            Video.Codec = "mpeg4";
                        }
                        break;
                    case "mpg":
                        Audio.Codecs = new string[,]
                        {
                            {"MP2", "mp2"}, {"MP3", "mp3"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        Video.Codecs = new string[,]
                        {
                            {"MPEG-2", "mpeg2"}, {"Copy", "copy"}
                        };
                        if (!IsValid(Audio.Codec, Audio.Codecs))
                        {
                            Audio.Codec = "mp2";
                        }
                        if (!IsValid(Video.Codec, Video.Codecs))
                        {
                            Video.Codec = "mpeg2";
                        }
                        break;
                    case "ts":
                        Audio.Codecs = new string[,]
                        {
                            {"AC-3", "ac3"}, {"AAC", "aac"}, {"MP2", "mp2"},
                            {"MP3", "mp3"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        Video.Codecs = new string[,] {
                            {"H.264", "h264"}, {"MPEG-2", "mpeg2"}, {"Copy", "copy"}
                        };
                        if (!IsValid(Audio.Codec, Audio.Codecs))
                        {
                            Audio.Codec = "mp2";
                        }
                        if (!IsValid(Video.Codec, Video.Codecs))
                        {
                            Video.Codec = "mpeg2";
                        }
                        break;
                    case "ogg":
                        Audio.Codecs = new string[,] {
                            {"FLAC", "flac"}, {"Opus", "opus"}, {"Speex", "speex"},
                            {"Vorbis", "vorbis"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        Video.Codecs = new string[,] {
                            {"Theora", "theora"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        if (!IsValid(Audio.Codec, Audio.Codecs))
                        {
                            Audio.Codec = "vorbis";
                        }
                        if (!IsValid(Video.Codec, Video.Codecs))
                        {
                            Video.Codec = "theora";
                        }
                        break;
                    case "webm":
                        Audio.Codecs = new string[,] {
                            {"Opus", "opus"}, {"Vorbis", "vorbis"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        Video.Codecs = new string[,] {
                            {"VP8", "vp8"}, {"VP9", "vp9"}, {"Copy", "copy"}
                        };
                        if (!IsValid(Audio.Codec, Audio.Codecs))
                        {
                            Audio.Codec = "vorbis";
                        }
                        if (!IsValid(Video.Codec, Video.Codecs))
                        {
                            Video.Codec = "vp8";
                        }
                        break;
                    case "wma":
                        Audio.Codecs = new string[,] {
                            {"WMA", "wma"}, {"Copy", "copy"}
                        };
                        Video.Codecs = new string[,] {
                            {"None", "none"}
                        };
                        if (!IsValid(Audio.Codec, Audio.Codecs))
                        {
                            Audio.Codec = "wma";
                        }
                        break;
                    case "wmv":
                        Audio.Codecs = new string[,] {
                            {"WMA", "wma"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        Video.Codecs = new string[,] {
                            {"WMV", "wmv"}, {"Copy", "copy"}
                        };
                        if (!IsValid(Audio.Codec, Audio.Codecs))
                        {
                            Audio.Codec = "wma";
                        }
                        if (!IsValid(Video.Codec, Video.Codecs))
                        {
                            Video.Codec = "wmv";
                        }
                        break;                    
                }
            }
        }

        public static string[,] Formats
        {
            get { return formats; }
        }

        public static string Input
        {
            get { return input; }
            set { input = value; }
        }

        public static string Log
        {
            get { return log; }
            set { log = value; }
        }

        /// <summary>
        /// Sets output file name for FFmpeg to use. File extension is automatically
        /// added if File.Format property is not set to 'custom'.
        /// </summary>
        public static string Output
        {
            get { return output; }
            set
            {
                if (format == "custom")
                {
                    output = value;
                }
                else
                {
                    string outfile = "";

                    if (value != "")
                    {
                        outfile = Path.ChangeExtension(value, format);
                    }

                    // Avoid conflicting file names
                    if (outfile == input)
                    {
                        outfile = Path.ChangeExtension(value, null);
                        outfile = string.Format("{0}_output.{1}", outfile, format);
                    }

                    output = outfile;
                }
            }
        }
    }
}