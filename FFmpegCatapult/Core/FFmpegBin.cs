// FFmpegBin is part of FFmpeg Catapult.

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
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using FFmpegCatapult.Models;

namespace FFmpegCatapult.Core
{
    partial class FFmpegBin
    {
        public void Run(IFileFormat file, IAudio audio, IVideo video, IPicture picture,
                        ITags tagging, IFilePaths paths, ISettings settings)
        {
            string audioArgs = GetAudioArgs(audio);
            string pictureArgs = GetPictureArgs(picture, video);
            string videoArgs = !string.IsNullOrEmpty(pictureArgs) ? string.Format("{0} {1}", GetVideoArgs(video, settings), pictureArgs) : GetVideoArgs(video, settings);
            string taggingArgs = GetTaggingArgs(tagging, file);
            string formatArgs = !string.IsNullOrEmpty(taggingArgs) ? string.Format("-f {0} {1}", file.Format, taggingArgs) : string.Format("-f {0}", file.Format);
            string inArgs = string.IsNullOrEmpty(paths.Audio) ? string.Format("-i \"{0}\"", paths.Source) : string.Format("-i \"{0}\" -i \"{1}\"", paths.Source, paths.Audio);
            string outArgs = paths.Overwrite ? string.Format("-y \"{0}\"", paths.Output) : string.Format("\"{0}\"", paths.Output);
            string userArgs = !string.IsNullOrEmpty(settings.FFmpegArguments) ? string.Format(" {0} ", settings.FFmpegArguments) : "";
            string ffmpegArgs;
            Process termProcess = new Process();

            try
            {
                termProcess.StartInfo.FileName = settings.TerminalPath;
                if (video.TwoPassEncoding)
                {
                    string waitTermArgs = (settings.TerminalPath == "cmd.exe") ? "/c start \"\" /wait" : settings.TerminalArguments;

                    //
                    // First pass
                    //
                    ffmpegArgs = string.Format("-i \"{0}\" -pass 1 {1} -an -y {2}-f rawvideo {3}", paths.Source, videoArgs, userArgs, settings.NullFilePath);
                    termProcess.StartInfo.Arguments = string.Format("{0} \"{1}\" {2}", waitTermArgs, settings.FFmpegPath, ffmpegArgs);
                    LogFFmpegLaunch(ffmpegArgs, "First pass", settings, paths);
                    termProcess.Start();
                    termProcess.WaitForExit();

                    //
                    // Second pass
                    //
                    ffmpegArgs = string.Format("{0} -pass 2 {1} {2} {3}{4} {5}", inArgs, videoArgs, audioArgs, userArgs, formatArgs, outArgs);
                    termProcess.StartInfo.Arguments = string.Format("{0} \"{1}\" {2}", settings.TerminalArguments, settings.FFmpegPath, ffmpegArgs);
                    LogFFmpegLaunch(ffmpegArgs, "Second pass", settings, paths);
                    termProcess.Start();
                }
                else
                {
                    //
                    // Single pass
                    //
                    ffmpegArgs = string.Format("{0} {1} {2} {3}{4} {5}", inArgs, videoArgs, audioArgs, userArgs, formatArgs, outArgs);
                    termProcess.StartInfo.Arguments = string.Format("{0} \"{1}\" {2}", settings.TerminalArguments, settings.FFmpegPath, ffmpegArgs);
                    LogFFmpegLaunch(ffmpegArgs, "Single pass", settings, paths);
                    termProcess.Start();
                }
            }
            catch (FileNotFoundException)
            {
                FFmpegLaunchErrorMessage("File not found.");
            }
            catch (DirectoryNotFoundException)
            {
                FFmpegLaunchErrorMessage("Invalid folder path.");
            }
            catch (UnauthorizedAccessException)
            {
                FFmpegLaunchErrorMessage("Permission denied.");
            }
            catch (Exception)
            {
                FFmpegLaunchErrorMessage("Unable to run FFmpeg.");
            }
        }

        private void LogFFmpegLaunch(string args, string encoding, ISettings settings, IFilePaths paths)
        {
            if (settings.WriteLog)
            {
                string parentFolder = Path.GetDirectoryName(paths.Source);
                string logPath = Path.Combine(parentFolder, settings.LogFilename);
                StreamWriter logFile;

                if (!System.IO.File.Exists(logPath))
                    logFile = new StreamWriter(logPath);
                else
                    logFile = System.IO.File.AppendText(logPath);

                logFile.WriteLine("Date:        {0}", DateTime.Now);
                logFile.WriteLine("Input file:  {0}", paths.Source);
                logFile.WriteLine("Output file: {0}", paths.Output);
                logFile.WriteLine("Encoding:    {0}", encoding);
                logFile.WriteLine("Arguments:   {0}", args);
                logFile.WriteLine();
                logFile.Close();
            }
            else
            {
                Debug.WriteLine(string.Format("{0} encoding for {1}:", encoding, paths.Source));
                Debug.WriteLine(args);
            }
        }

        private void FFmpegLaunchErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        public FFmpegBin() {}
    }
}
