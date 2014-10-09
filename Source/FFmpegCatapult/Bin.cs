﻿// Binary is part of FFmpeg Catapult.
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
using System.Collections;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FFmpegCatapult
{
    class Bin
    {
        // Variables
        private static string ffmpegBin;
        private static string termBin;
        private static string termArgs;
        private static string nullPath;

        /// <summary>
        /// Produces command line arguments based on current properties and then run FFmpeg 
        /// in a seperate process.
        /// </summary>
        public static void Run()
        {
            // Variables
            string audio;
            string args;
            string input;
            string output;
            string video;
            string nullFile = nullPath;

            // Input arguments
            if (!string.IsNullOrEmpty(File.AudioStream))
            {
                input = string.Format("-i \"{0}\" -i \"{1}\"", File.Input, File.AudioStream);
            }
            else
            {
                input = string.Format("-i \"{0}\"", File.Input);
            }

            // Output arguments
            if (Session.Overwrite == true)
            {
                output = string.Format("-y \"{0}\"", File.Output);
            }
            else
            {
                output = string.Format("-n \"{0}\"", File.Output);
            }            

            // Threads arguments
            if (Session.MultiThreading)
            {
                output = string.Format("-threads {0} {1}", Session.Threads, output);
                nullFile = string.Format("-threads {0} {1}", Session.Threads, nullPath);
            }             

            // Audio arguments
            if (Audio.Codec != "none")
            {
                ArrayList audioArgs = new ArrayList();
                audioArgs.Add(string.Format("-codec:a {0}", Audio.Encoder));

                if (Audio.Codec != "copy")
                {
                    if (Audio.CodecProfile != "default")
                    {
                        audioArgs.Add(string.Format("-profile:a {0}", Audio.CodecProfile));
                    }

                    // Audio bitrates and quality
                    if (Audio.UseVBR == true)
                    {
                        audioArgs.Add(string.Format("-q:a {0}", Audio.Quality));
                    }
                    else
                    {
                        audioArgs.Add(string.Format("-b:a {0}k", Audio.Bitrate));
                    }

                    // Audio encoder switches
                    if (Audio.Encoder == "aac")
                    {
                        audioArgs.Add("-strict experimental");
                    }

                    // Audio output
                    if (Audio.Channels > 0)
                    {
                        audioArgs.Add(string.Format("-ac {0}", Audio.Channels));
                    }

                    if (Audio.SampleRate > 0)
                    {
                        audioArgs.Add(string.Format("-ar {0}", Audio.SampleRate));
                    }
                }

                audio = string.Join(" ", audioArgs.ToArray());
            }
            else
            {
                audio = "-an";
            }

            // Video arguments
            if (Video.Codec != "none" && !Methods.IsAudioFile())
            {
                ArrayList videoArgs = new ArrayList();
                videoArgs.Add(string.Format("-codec:v {0}", Video.Encoder));

                if (Video.Codec != "copy")
                {
                    if (!string.IsNullOrEmpty(Video.CodecProfile))
                    {
                        videoArgs.Add(string.Format("-profile:v {0}", Video.CodecProfile));
                    }

                    if (Video.CodecLevel > 0 && Video.Encoder == "libx264")
                    {
                        videoArgs.Add(string.Format("-level {0}", Video.CodecLevel));
                    }

                    // Video bitrates and quality settings
                    if (Video.UseCRF == true)
                    {
                        videoArgs.Add(string.Format("-crf {0}", Video.CRF));
                    }
                    else
                    {
                        videoArgs.Add(string.Format("-b:v {0}{1}", Video.Bitrate, Video.Bits));

                        if (Video.MinBitrate != 0)
                        {
                            videoArgs.Add(string.Format("-minrate {0}{1}", Video.MinBitrate, Video.Bits));
                        }

                        if (Video.MaxBitrate != 0)
                        {
                            videoArgs.Add(string.Format("-maxrate {0}{1}", Video.MaxBitrate, Video.Bits));
                        }
                    }

                    if (Video.Qmin != Video.Qmax)
                    {
                        videoArgs.Add(string.Format("-qmin {0}", Video.Qmin));
                    }

                    if (Video.Qmax != 0)
                    {
                        videoArgs.Add(string.Format("-qmax {0}", Video.Qmax));
                    }

                    if (Video.BufferSize != 0)
                    {
                        videoArgs.Add(string.Format("-bufsize {0}{1}", Video.BufferSize, Video.Bytes));
                    }

                    if (Video.GOPSize != 0)
                    {
                        videoArgs.Add(string.Format("-g {0}", Video.GOPSize));
                    }

                    if (Video.BFrames != 0)
                    {
                        videoArgs.Add(string.Format("-bf {0}", Video.BFrames));
                    }

                    if (Video.BFStrategy < 3)
                    {
                        videoArgs.Add(string.Format("-b_strategy {0}", Video.BFStrategy));
                    }

                    if (Video.MEMethod != "")
                    {
                        videoArgs.Add(string.Format("-me_method {0}", Video.MEMethod));
                    }

                    if (Video.DiaSize != 0)
                    {
                        videoArgs.Add(string.Format("-dia_size {0}", Video.DiaSize));
                    }

                    if (Video.CMP != 15)
                    {
                        videoArgs.Add(string.Format("-cmp {0}", Video.CMP));
                    }

                    if (Video.SubCMP != 15)
                    {
                        videoArgs.Add(string.Format("-subcmp {0}", Video.SubCMP));
                    }

                    if (Video.Trellis != 3)
                    {
                        videoArgs.Add(string.Format("-trellis {0}", Video.Trellis));
                    }

                    if (!string.IsNullOrEmpty(Video.PictureFormat))
                    {
                        videoArgs.Add(string.Format("-pix_fmt {0}", Video.PictureFormat));
                    }

                    if (Screen.FPS != 0)
                    {
                        videoArgs.Add(string.Format("-r {0}", Screen.FPS));
                    }

                    // Video filtering arguments
                    if (Methods.IsPictureScalable())
                    {
                        ArrayList filtering = new ArrayList();

                        if (Screen.Deinterlace == true)
                        {
                            filtering.Add("yadif=0:-1:0");
                        }

                        if (Screen.AspectRatio == true)
                        {
                            filtering.Add(string.Format("setdar={0}:{1}", Screen.RatioA, Screen.RatioB));
                        }

                        if (Screen.ScaleOption == 1)
                        {
                            if (Screen.Width > 0 && Screen.Height > 0)
                            {
                                filtering.Add(string.Format("scale={0}:{1}", Screen.Width, Screen.Height));
                            }
                            else if (Screen.Width > 0 && Screen.Height == 0)
                            {
                                filtering.Add(string.Format("scale=\"min({0}\\,iw):trunc(ow/a/2)*2\"", Screen.Width));
                            }
                            else
                            {
                                filtering.Add(string.Format("scale=\"trunc(oh*a/2)*2:min({0}\\,ih)\"", Screen.Height));
                            }
                        }
                        else if (Screen.ScaleOption == 2)
                        {
                            filtering.Add("scale=iw/2:-1");
                        }

                        if (Screen.PadVideo == true && Screen.CropVideo == false)
                        {
                            filtering.Add(string.Format("pad={0}:{1}:{2}:{3}:{4}", Screen.WinWidth, Screen.WinHeight, Screen.X, Screen.Y, Screen.VFColour));
                        }

                        if (Screen.CropVideo == true && Screen.CropVideo == false)
                        {
                            filtering.Add(string.Format("crop={0}:{1}:{2}:{3}", Screen.WinWidth, Screen.WinHeight, Screen.X, Screen.Y));
                        }

                        string filters = string.Join(",", filtering.ToArray());

                        if (filters.Length > 0)
                        {
                            videoArgs.Add(string.Format("-vf {0}", filters));

                            if (Screen.ScaleOption > 0)
                            {
                                videoArgs.Add(string.Format("-sws_flags {0}", Screen.ScalingMethod));
                            }
                        }
                    }
                }

                video = string.Join(" ", videoArgs.ToArray());
            }
            else
            {
                video = "-vn";
            }

            // Tagging switches
            if (File.Format != "raw")
            {
                ArrayList tagArgs = new ArrayList();

                if (!string.IsNullOrEmpty(Metadata.Album))
                {
                    tagArgs.Add(string.Format("-metadata album=\"{0}\"", Metadata.Album));
                }

                if (!string.IsNullOrEmpty(Metadata.AlbumArtist))
                {
                    tagArgs.Add(string.Format("-metadata album_artist=\"{0}\"", Metadata.AlbumArtist));
                }

                if (!string.IsNullOrEmpty(Metadata.Artist))
                {
                    tagArgs.Add(string.Format("-metadata artist=\"{0}\"", Metadata.Artist));
                }

                if (!string.IsNullOrEmpty(Metadata.Comment))
                {
                    tagArgs.Add(string.Format("-metadata comment=\"{0}\"", Metadata.Comment));
                }

                if (!string.IsNullOrEmpty(Metadata.Comment))
                {
                    tagArgs.Add(string.Format("-metadata genre=\"{0}\"", Metadata.Genre));
                }

                if (Metadata.Disc != 0)
                {
                    if (Metadata.TotalDiscs != 0)
                    {
                        tagArgs.Add(string.Format("-metadata disc={0}/{1}", Metadata.Disc, Metadata.TotalDiscs));
                    }
                    else
                    {
                        tagArgs.Add(string.Format("-metadata disc={0}", Metadata.Disc));
                    }
                }

                if (!string.IsNullOrEmpty(Metadata.Title))
                {
                    tagArgs.Add(string.Format("-metadata title=\"{0}\"", Metadata.Title));
                }

                if (Metadata.Track != 0)
                {
                    if (Metadata.TotalTracks != 0)
                    {
                        tagArgs.Add(string.Format("-metadata track={0}/{1}", Metadata.Track, Metadata.TotalTracks));
                    }
                    else
                    {
                        tagArgs.Add(string.Format("-metadata track={0}", Metadata.Track));
                    }
                }

                if (!string.IsNullOrEmpty(Metadata.Publisher))
                {
                    tagArgs.Add(string.Format("-metadata publisher=\"{0}\"", Metadata.Publisher));
                }

                if (Metadata.Year != 0)
                {
                    tagArgs.Add(string.Format("-metadata date={0}", Metadata.Year));
                }

                if (tagArgs.Count > 0)
                {
                    if (File.Format == "mp3")
                    {
                        tagArgs.Add("-id3v2_version 3");
                        tagArgs.Add("-write_id3v1 1");
                    }

                    output = string.Join(" ", tagArgs.ToArray()) + " " + output;
                }
            }

            // Launch process
            Process Term = new Process();

            try
            {
                Term.StartInfo.FileName = termBin;
                if (Session.TwoPassEncoding == true)
                {
                    string waitArgs;
                    if (termBin == "cmd.exe")
                    {
                        waitArgs = "/c start /wait";
                    }
                    else
                    {
                        waitArgs = termArgs;
                    }

                    // First pass
                    args = string.Format("-i \"{0}\" -pass 1 {1} -an -y -f rawvideo {2}", File.Input, video, nullFile);
                    Term.StartInfo.Arguments = string.Format("{0} {1} {2}", waitArgs, ffmpegBin, args);
                    Term.Start();
                    if (Session.WriteLog == true)
                    {
                        Log(args, "First pass");
                    }
                    Term.WaitForExit();

                    // Second pass
                    args = string.Format("{0} -pass 2 {1} {2} {3}", input, video, audio, output);
                    Term.StartInfo.Arguments = string.Format("{0} {1} {2}", termArgs, ffmpegBin, args);
                    Term.Start();
                    if (Session.WriteLog == true)
                    {
                        Log(args, "Second pass");
                    }
                }
                else
                {
                    // Single pass
                    args = string.Format(string.Format("{0} {1} {2} {3}", input, video, audio, output));
                    Term.StartInfo.Arguments = string.Format("{0} {1} {2}", termArgs, ffmpegBin, args);
                    Term.Start();
                    if (Session.WriteLog == true)
                    {
                        Log(args, "Single pass");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to run FFmpeg.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private static void Log(string args, string pass)
        {
            string fileName;
            if (!string.IsNullOrEmpty(File.Log))
            {
                fileName = File.Log + ".txt";
            }
            else
            {
                fileName = "FFmpegCatapult_Log.txt";
            }
            string logPath = Path.GetDirectoryName(File.Output);
            string output = Path.Combine(logPath, fileName);
            StreamWriter file;

            if (!System.IO.File.Exists(output))
            {
                file = new StreamWriter(output);
            }
            else
            {
                file = System.IO.File.AppendText(output);
            }

            file.WriteLine("Date: {0}", DateTime.Now);
            file.WriteLine("Input file: {0}", File.Input);
            file.WriteLine("Output file: {0}", File.Output);
            file.WriteLine("Preset: {0}", Session.Preset);
            file.WriteLine("Encoding: {0}", pass);
            file.WriteLine("Arguments: {0}", args);
            file.WriteLine();
            file.Close();
        }

        // Property methods
        public static string FFmpegBin
        {
            get { return ffmpegBin; }
            set { ffmpegBin = value; }
        }

        public static string TermArgs
        {
            get { return termArgs; }
            set { termArgs = value; }
        }

        public static string TermBin
        {
            get { return termBin; }
            set { termBin = value; }
        }

        public static string NullPath
        {
            get { return nullPath; }
            set { nullPath = value; }
        }
    }
}