// FFmpeg Catapult
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
using System.Linq;
using System.Windows.Forms;

namespace FFmpegCatapult
{
    static class FFmpegCatapult
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            // Determine running operating system
            int x = Convert.ToInt16(Environment.OSVersion.Platform);
            if (x == 4 || x == 6 || x == 128)
            {
                // Unix default settings
                Bin.FFmpegBin = "ffmpeg";
                Bin.TermBin = "xterm";
                Bin.TermArgs = "-e";
                Bin.NullPath = "/dev/null";
            }
            else
            {
                // Windows default settings
                Bin.FFmpegBin = "ffmpeg.exe";
                Bin.TermBin = "cmd.exe";
                Bin.TermArgs = "/c start";
                Bin.NullPath = "NULL";
            }

            // Command line interface
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "-preset":
                        i++;
                        Session.DefaultPreset = args[i];
                        break;
                    case "-out":
                        i++;
                        File.Format = "custom";
                        File.Output = args[i];
                        break;
                    case "-bin":
                        i++;
                        Bin.FFmpegBin = args[i];
                        break;
                    case "-term":
                        i++;
                        Bin.TermBin = args[i];
                        break;
                    case "-termargs":
                        i++;
                        Bin.TermArgs = args[i];
                        break;
                    default:
                        File.Input = args[i];
                        break;
                }
            }

            // Init preset
            Preset.SetPreset(Session.DefaultPreset);

            // Load main form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FFmpegCatapultForm());
        }
    }
}
