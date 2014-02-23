// File properties interface for FFmpeg Catapult.
// Copyright (C) 2013 Myles Thaiss

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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FFmpegCatapult
{
    class File
    {
        // Variables
        private static String audio = "";
        private static String format = "";
        private static String input = "";
        private static String output = "";

        // Codecs and file extensions
        private static String[,] audioCodecs = new String[,]
        {
            {"AC3", "ac3"}, {"AAC", "aac"}, {"FLAC", "flac"}, {"MP2", "mp2"},
            {"MP3", "mp3"}, {"Opus", "opus"}, {"PCM", "pcm"}, {"Vorbis", "vorbis"},
            {"WMA", "wma"}, {"Copy", "copy"}, {"None", "none"}
        };        
        private static String[,] videoCodecs = new String[,]
        {
            {"Dirac", "dirac"}, {"H.264", "h264"}, {"MPEG-2", "mpeg2"},
            {"MPEG-4", "mpeg4"}, {"Theora", "theora"}, {"VP8", "vp8"},
            {"WMV", "wmv"}, {"Copy", "copy"}, {"None", "none"}
        };
        private static String[,] formats = new String[,]
        {
            {"AVI", "avi"}, {"Matroska", "mkv"}, {"MP3", "mp3"}, {"MP4", "mp4"},
            {"MPEG Program Stream", "mpg"}, {"MPEG Transport Stream", "ts"},
            {"Ogg", "ogg"}, {"WebM", "webm"}, {"Windows Media Audio", "wma"},
            {"Windows Media Video", "wmv"}, {"Custom", "custom"}
        };

        // Property methods
        public static String AudioStream
        {
            get { return audio; }
            set { audio = value; }
        }

        public static String Format
        {
            get { return format; }
            set 
            { 
                String oldFormat = format;
                format = value;

                switch (format)
                {
                    case "avi":
                        Audio.Codec = "mp3";
                        Audio.Codecs = audioCodecs;
                        Video.Codec = "mpeg4";
                        Video.Codecs = videoCodecs;
                        break;
                    case "mkv":
                        Audio.Codec = "aac";
                        Audio.Codecs = audioCodecs;
                        Video.Codec = "h264";
                        Video.Codecs = videoCodecs;
                        break;
                    case "mp3":
                        Audio.Codec = "mp3";
                        Audio.Codecs = new String[,]
                        {
                            {"MP3", "mp3"}, {"Copy", "copy"}
                        };
                        Video.Codec = "none";
                        Video.Codecs = new String[,]
                        {
                            {"None", "none"}
                        };
                        break;
                    case "mp4":                   
                        Audio.Codec = "aac";
                        Audio.Codecs = new String[,]
                        {
                            {"AC-3", "ac3"}, {"AAC", "aac"}, {"MP3", "mp3"},
                            {"Copy", "copy"}, {"None", "none"}
                        };
                        Video.Codec = "mpeg4";
                        Video.Codecs = new String[,]
                        {
                            {"H.264", "h264"}, {"MPEG-2", "mpeg2"}, {"MPEG-4", "mpeg4"},
                            {"Copy", "copy"}, {"None", "none"}
                        };
                        break;
                    case "mpg":
                        Audio.Codec = "mp2";
                        Audio.Codecs = new String[,]
                        {
                            {"MP2", "mp2"}, {"MP3", "mp3"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        Video.Codec = "mpeg2";
                        Video.Codecs = new String[,]
                        {
                            {"MPEG-2", "mpeg2"}, {"Copy", "copy"}
                        };
                        break;
                    case "ts":
                        Audio.Codec = "mp2";
                        Audio.Codecs = new String[,]
                        {
                            {"AC-3", "ac3"}, {"AAC", "aac"}, {"MP2", "mp2"},
                            {"MP3", "mp3"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        Video.Codec = "mpeg2";
                        Video.Codecs = new String[,] {
                            {"H.264", "h264"}, {"MPEG-2", "mpeg2"}, {"Copy", "copy"}
                        };
                        break;
                    case "ogg":
                        Audio.Codec = "vorbis";
                        Audio.Codecs = new String[,] {
                            {"FLAC", "flac"}, {"Opus", "opus"}, {"Vorbis", "vorbis"},
                            {"Copy", "copy"}, {"None", "none"}
                        };
                        Video.Codec = "theora";
                        Video.Codecs = new String[,] {
                            {"Dirac", "dirac"}, {"Theora", "theora"}, {"Copy", "copy"},
                            {"None", "none"}
                        };
                        break;
                    case "webm":
                        Audio.Codec = "vorbis";
                        Audio.Codecs = new String[,] {
                            {"Vorbis", "vorbis"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        Video.Codec = "vp8";
                        Video.Codecs = new String[,] {
                            {"VP8", "vp8"}, {"Copy", "copy"}
                        };
                        break;
                    case "wma":
                        Audio.Codec = "wma";
                        Audio.Codecs = new String[,] {
                            {"WMA", "wma"}, {"Copy", "copy"}
                        };
                        Video.Codec = "none";
                        Video.Codecs = new String[,] {
                            {"None", "none"}
                        };
                        break;
                    case "wmv":
                        Audio.Codec = "wma";
                        Audio.Codecs = new String[,] {
                            {"WMA", "wma"}, {"Copy", "copy"}, {"None", "none"}
                        };
                        Video.Codec = "wmv";
                        Video.Codecs = new String[,] {
                            {"WMV", "wmv"}, {"Copy", "copy"}
                        };
                        break;
                    default:
                        Audio.Codecs = audioCodecs;
                        Video.Codecs = videoCodecs;
                        break;
                }                
            }
        }

        public static String[,] Formats
        {
            get { return formats; }
        }

        public static string Input
        {
            get { return input; }
            set { input = value; }
        }

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
                    String outfile = "";

                    if (value != "")
                    {
                        outfile = Path.ChangeExtension(value, format);
                    }

                    // Avoid conflicting file names
                    if (outfile == input)
                    {
                        outfile = Path.ChangeExtension(value, null);
                        outfile = String.Format("{0}_output.{1}", outfile, format);
                    }

                    output = outfile;
                }
            }
        }
    }
}