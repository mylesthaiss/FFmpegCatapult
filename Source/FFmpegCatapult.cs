// FFmpeg Catapult
// A WinForms GUI launcher for FFmpeg.
// Copyright (C) 2014 Myles Thaiss

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
            // Variables
            bool initPreset;

            if (Properties.Settings.Default.TermBin == "")
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
            }
            else
            {
                Bin.FFmpegBin = Properties.Settings.Default.FFmpegBin;
                Bin.TermBin = Properties.Settings.Default.TermBin;
                Bin.TermArgs = Properties.Settings.Default.TermArgs;
                Bin.NullPath = Properties.Settings.Default.NullPath;
            }

            if (Properties.Settings.Default.Threads == -1 | Properties.Settings.Default.Threads > Session.MaxThreads)
            {
                Session.Threads = Session.MaxThreads;
            }
            else
            {
                Session.Threads = Properties.Settings.Default.Threads;
            }

            initPreset = Properties.Settings.Default.InitPreset;
            Session.Preset = Properties.Settings.Default.Preset;
            Session.KeepValues = Properties.Settings.Default.KeepValues;
            Session.Overwrite = Properties.Settings.Default.OverwriteFiles;
            Session.TwoPassEncoding = Properties.Settings.Default.TwoPassEncoding;
            Session.MultiThreading = Properties.Settings.Default.MultiThreading;
            Session.WriteLog = Properties.Settings.Default.WriteLog;
            Session.SaveProperties = Properties.Settings.Default.SaveSettings;
            File.Log = Properties.Settings.Default.LogFileName;

            // Command line interface
            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    int n = i + 1;
                    if (n >= args.Length)
                    {
                        n = i;
                    }

                    switch (args[i])
                    {
                        case "-preset":
                            if (!args[n].StartsWith("-"))
                            {
                                i = n;
                                initPreset = true;
                                Session.Preset = args[i];
                            }
                            break;
                        case "-out":
                            if (!args[n].StartsWith("-"))
                            {
                                i = n;
                                File.Format = "custom";
                                File.Output = args[i];
                            }
                            break;
                        case "-bin":
                            if (!args[n].StartsWith("-"))
                            {
                                i = n;
                                Bin.FFmpegBin = args[i];
                            }
                            break;
                        case "-term":
                            if (!args[n].StartsWith("-"))
                            {
                                i = n;
                                Bin.TermBin = args[i];
                            }
                            break;
                        case "-termargs":
                            if (!args[n].StartsWith("-"))
                            {
                                i = n;
                                Bin.TermArgs = args[i];
                            }
                            break;
                        default:
                            File.Input = args[i];
                            break;
                    }
                }
            }

            // Init settings
            if (initPreset)
            {
                Preset.InitPreset();
            }
            else
            {
                Session.LoadSettings();
            }

            // Load main form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
