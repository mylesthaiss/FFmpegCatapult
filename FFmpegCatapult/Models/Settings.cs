// Settings is part of FFmpeg Catapult.

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
    interface ISettings
    {
        bool UrlFileNames { get; set; }
        bool WriteLog { get; set; }
        int Threads { get; set; }
        int Processors { get; set; }
        string DefaultFileName { get; set; }
        string DefaultOutputFolder { get; set; }
        string DefaultSourceFolder { get; set; }
        string FFmpegPath { get; set; }
        string FFmpegArguments { get; set; }
        string LogFilename { get; set; }
        string NullFilePath { get; }
        string TerminalArguments { get; set; }
        string TerminalPath { get; set; }
    }

    class Settings : ISettings
    {
        public bool UrlFileNames { get; set; } = false;
        public bool KeepValues { get; set; }
        public bool SaveSettings { get; set; }
        public bool WriteLog { get; set; }
        public int Threads { get; set; }
        public int Processors { get; set; }
        public int MaxThreads { get; private set; }
        public int MaxProcessors { get; private set; }
        public string DefaultFileName { get; set; }
        public string DefaultOutputFolder { get; set; }
        public string DefaultSourceFolder { get; set; }
        public string FFmpegPath { get; set; }
        public string FFmpegArguments { get; set; }
        public string LogFilename { get; set; }
        public string NullFilePath { get; private set; }
        public string TerminalPath { get; set; }
        public string TerminalArguments { get; set; }

        public Settings()
        {
            MaxThreads = Environment.ProcessorCount;
            Threads = 0;
            MaxProcessors = Environment.ProcessorCount / 2;
            Processors = MaxProcessors;

            // Determine default paths based on operation system
            switch (Convert.ToInt16(Environment.OSVersion.Platform))
            {
                case 4:
                case 6:
                case 128:
                    FFmpegPath = "ffmpeg";
                    TerminalPath = "xterm";
                    TerminalArguments = "-e";
                    NullFilePath = "/dev/null";
                    LogFilename = "ffmpeg_catapalt.log";
                    break;
                default:
                    FFmpegPath = "ffmpeg.exe";
                    TerminalPath = "cmd.exe";
                    TerminalArguments = "/c start \"\"";
                    NullFilePath = "NULL";
                    LogFilename = "FFmpegCatapult.txt";
                    break;
            }
        }

        public void Load()
        {
            UrlFileNames = Properties.Settings.Default.UrlFilenames;
            WriteLog = Properties.Settings.Default.WriteLog;
            DefaultOutputFolder = Properties.Settings.Default.OutputFolder;
            DefaultSourceFolder = Properties.Settings.Default.SourceFolder;
            FFmpegArguments = Properties.Settings.Default.FFmpegArguments;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.LogFilename))
                LogFilename = Properties.Settings.Default.LogFilename;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.FFmegPath))
                FFmpegPath = Properties.Settings.Default.FFmegPath;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.TerminalPath))
                TerminalPath = Properties.Settings.Default.TerminalPath;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.TerminalArguments))
                TerminalArguments = Properties.Settings.Default.TerminalArguments;
        }

        public void Save()
        {
            Properties.Settings.Default.UrlFilenames = UrlFileNames;
            Properties.Settings.Default.WriteLog = WriteLog;
            Properties.Settings.Default.LogFilename = LogFilename;
            Properties.Settings.Default.OutputFolder = DefaultOutputFolder;
            Properties.Settings.Default.SourceFolder = DefaultSourceFolder;
            Properties.Settings.Default.FFmegPath = FFmpegPath;
            Properties.Settings.Default.FFmpegArguments = FFmpegArguments;
            Properties.Settings.Default.TerminalPath = TerminalPath;
            Properties.Settings.Default.TerminalArguments = TerminalArguments;
            Properties.Settings.Default.Save();
        }
    }
}
