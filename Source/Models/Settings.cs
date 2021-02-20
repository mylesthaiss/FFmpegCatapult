﻿// Settings is part of FFmpeg Catapult.

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

namespace FFmpegCatapult.Models
{
    class Settings : ISettings
    {
        private bool preferNonfreeEncoders = false;
        private bool writeLog;
        private bool multiThreading = true;
        private int threads;
        private int processorCount;
        private string ffmpegPath;
        private string termPath;
        private string termArgs;
        private string nullPath;
        private string preset;

        public bool PreferNonfreeEncoders
        {
            get { return preferNonfreeEncoders; }
            set { preferNonfreeEncoders = value; }
        }

        public bool WriteLog
        {
            get { return writeLog; }
            set { writeLog = value; }
        }

        public bool MultiThreading
        {
            get { return multiThreading; }
            set { multiThreading = value; }
        }

        public int Threads
        {
            get { return threads; }
            set { threads = value; }
        }

        public int ProcessorCount
        {
            get { return processorCount; }
            set { processorCount = value; }
        }

        public string FFmpegBinPath
        {
            get { return ffmpegPath; }
            set { ffmpegPath = value; }
        }

        public string TerminalPath
        {
            get { return termPath; }
            set { termPath = value; }
        }

        public string TerminalArgs
        {
            get { return termArgs; }
            set { termArgs = value; }
        }

        public string NullPath
        {
            get { return nullPath; }
        }

        public string Preset
        {
            get { return preset; }
            set { preset = value; }
        }

        public Settings()
        {
            // Determine default paths based on operation system
            switch (Convert.ToInt16(Environment.OSVersion.Platform))
            {
                case 4:
                case 6:
                case 128:
                    ffmpegPath = "ffmpeg";
                    termPath = "xterm";
                    termArgs = "-e";
                    nullPath = "/dev/null";
                    break;
                default:
                    ffmpegPath = "ffmpeg.exe";
                    termPath = "cmd.exe";
                    termArgs = "/c start";
                    nullPath = "NULL";
                    break;
            }
        }
    }
}