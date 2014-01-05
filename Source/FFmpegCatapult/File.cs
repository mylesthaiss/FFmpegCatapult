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

        // File extentions table     
        private static String[,] formats = new String[,]
        {
            {"AVI", "avi"}, {"Matroska", "mkv"}, {"MP4", "mp4"},
            {"MPEG Program Stream", "mpg"}, {"MPEG Transport Stream", "ts"},
            {"Ogg", "ogg"}, {"WebM", "webm"}, {"Windows Media Video", "wmv"},
            {"Custom", "custom"}
        };

        // Property methods
        public static String Audio
        {
            get { return audio; }
            set { audio = value; }
        }

        public static String Format
        {
            get { return format; }
            set { format = value; }
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
