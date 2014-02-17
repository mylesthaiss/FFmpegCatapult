// FFmpeg binary launcher for FFmpeg Catapult.
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
using System.Collections;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace FFmpegCatapult
{
    class Bin
    {
        // Variables
        private static String ffmpegBin;
        private static String termBin;
        private static String termArgs;
        private static String nullPath;

        // Run method
        public static void Run()
        {
            // Variables
            String audio;
            String input;
            String output;
            String threads;
            String video;
            
            // Input arguments
            if (File.Audio != "")
            {
                input = String.Format("-i \"{0}\" -i \"{1}\"", File.Input, File.Audio);
            }
            else
            {
                input = String.Format("-i \"{0}\"", File.Input);
            }

            // Output arguments
            if (Session.Overwrite == true)
            {
                output = String.Format("-y \"{0}\"", File.Output);
            }
            else
            {
                output = String.Format("-n \"{0}\"", File.Output);
            }

            // Threads arguments
            threads = String.Format("-threads {0}", Session.Threads);

            // Audio arguments
            if (Audio.Codec != "none")
            {
                ArrayList audioArgs = new ArrayList();
                audioArgs.Add(String.Format("-codec:a {0}", Audio.Encoder));

                if (Audio.Codec != "copy")
                {
                    // Audio bitrates and quality
                    if (Audio.UseVBR == true)
                    {
                        audioArgs.Add(String.Format("-q:a {0}", Audio.Quality));
                    }
                    else
                    {
                        audioArgs.Add(String.Format("-b:a {0}k", Audio.Bitrate));
                    }

                    // Audio encoder switches
                    if (Audio.Encoder == "aac")
                    {
                        audioArgs.Add("-strict experimental");
                    }

                    // Audio output
                    if (Audio.Channels > 0)
                    {
                        audioArgs.Add(String.Format("-ac {0}", Audio.Channels));
                    }

                    if (Audio.SampleRate > 0)
                    {
                        audioArgs.Add(String.Format("-ar {0}", Audio.SampleRate));
                    }
                }

                audio = String.Join(" ", audioArgs.ToArray());
            }
            else
            {
                audio = "-an";
            }

            // Video arguments
            if (Video.Codec != "none")
            {
                ArrayList videoArgs = new ArrayList();
                videoArgs.Add(String.Format("-codec:v {0}", Video.Encoder));

                if (Video.Codec != "copy")
                {
                    // x264 settings
                    if (Video.Encoder == "libx264")
                    {
                        if (Video.CodecProfile != "default")
                        {
                            videoArgs.Add(String.Format("-profile:v {0}", Video.CodecProfile));
                        }

                        if (Video.CodecLevel > 0)
                        {
                            videoArgs.Add(String.Format("-level {0}", Video.CodecLevel));
                        }
                    }

                    // Video bitrates and quality settings
                    if (Video.UseCRF == true)
                    {
                        videoArgs.Add(String.Format("-crf {0}", Video.CRF));
                    }
                    else
                    {
                        videoArgs.Add(String.Format("-b:v {0}{1}", Video.Bitrate, Video.Bits));

                        if (Video.MinBitrate != 0)
                        {
                            videoArgs.Add(String.Format("-minrate {0}{1}", Video.MinBitrate, Video.Bits));
                        }

                        if (Video.MaxBitrate != 0)
                        {
                            videoArgs.Add(String.Format("-maxrate {0}{1}", Video.MaxBitrate, Video.Bits));
                        }
                    }

                    if (Video.Qmin != Video.Qmax)
                    {
                        videoArgs.Add(String.Format("-qmin {0}", Video.Qmin));
                    }

                    if (Video.Qmax != 0)
                    {
                        videoArgs.Add(String.Format("-qmax {0}", Video.Qmax));
                    }

                    if (Video.BufferSize != 0)
                    {
                        videoArgs.Add(String.Format("-bufsize {0}{1}", Video.BufferSize, Video.Bytes));
                    }

                    if (Video.GOPSize != 0)
                    {
                        videoArgs.Add(String.Format("-g {0}", Video.GOPSize));
                    }

                    if (Video.BFrames != 0)
                    {
                        videoArgs.Add(String.Format("-bf {0}", Video.BFrames));
                    }

                    if (Video.BFStrategy != 0)
                    {
                        videoArgs.Add(String.Format("-b_strategy {0}", Video.BFStrategy));
                    }

                    if (Video.MEMethod != "default")
                    {
                        videoArgs.Add(String.Format("-me_methods {0}", Video.MEMethod));
                    }

                    if (Video.DiaSize != 0)
                    {
                        videoArgs.Add(String.Format("-dia_size {0}", Video.DiaSize));
                    }

                    if (Video.CMP != 15)
                    {
                        videoArgs.Add(String.Format("-cmp {0}", Video.CMP));
                    }

                    if (Video.SubCMP != 15)
                    {
                        videoArgs.Add(String.Format("-subcmp {0}", Video.SubCMP));
                    }

                    if (Video.Trellis != 3)
                    {
                        videoArgs.Add(String.Format("-trellis {0}", Video.Trellis));
                    }

                    if (Video.PictureFormat != "default")
                    {
                        videoArgs.Add(String.Format("-pix_fmt {0}", Video.PictureFormat));
                    }

                    if (Screen.FPS != 0)
                    {
                        videoArgs.Add(String.Format("-r {0}", Screen.FPS));
                    }

                    // Video filtering arguments
                    ArrayList filtering = new ArrayList();

                    if (Screen.Deinterlace == true)
                    {
                        filtering.Add("yadif=0:-1:0");
                    }

                    if (Screen.AspectRatio == true)
                    {
                        filtering.Add(String.Format("setdar={0}:{1}", Screen.RatioA, Screen.RatioB));
                    }

                    if (Screen.ScaleOption == 1)
                    {
                        if (Screen.Width > 0 && Screen.Height > 0)
                        {
                            filtering.Add(String.Format("scale={0}:{1}", Screen.Width, Screen.Height));
                        }
                        else if (Screen.Width > 0 && Screen.Height == 0)
                        {
                            filtering.Add(String.Format("scale=\"min({0}\\,iw):trunc(ow/a/2)*2\"", Screen.Width));
                        }
                        else
                        {
                            filtering.Add(String.Format("scale=\"trunc(oh*a/2)*2:min({0}\\,ih)\"", Screen.Height));
                        }
                    }
                    else if (Screen.ScaleOption == 2)
                    {
                        filtering.Add("scale=iw/2:-1");
                    }

                    if (Screen.PadVideo == true && Screen.CropVideo == false)
                    {
                        filtering.Add(String.Format("pad={0}:{1}:{2}:{3}:{4}", Screen.WinWidth, Screen.WinHeight, Screen.X, Screen.Y, Screen.VFColour));
                    }

                    if (Screen.CropVideo == true && Screen.CropVideo == false)
                    {
                        filtering.Add(String.Format("crop={0}:{1}:{2}:{3}", Screen.WinWidth, Screen.WinHeight, Screen.X, Screen.Y));
                    }

                    String filters = String.Join(",", filtering.ToArray());

                    if (filters.Length > 0)
                    {
                        videoArgs.Add(String.Format("-vf {0}", filters));

                        if (Screen.ScaleOption > 0)
                        {
                            videoArgs.Add(String.Format("-sws_flags {0}", Screen.ScalingMethod));
                        }
                    }
                }

                video = String.Join(" ", videoArgs.ToArray());
            }
            else
            {
                video = "-vn";
            }

            // Tagging switches
            if (File.Format != "raw")
            {
                ArrayList tagArgs = new ArrayList();

                if (Metadata.Album != "")
                {
                    tagArgs.Add(String.Format("-metadata album=\"{0}\"", Metadata.Album));
                }

                if (Metadata.AlbumArtist != "")
                {
                    tagArgs.Add(String.Format("-metadata album_artist=\"{0}\"", Metadata.AlbumArtist));
                }

                if (Metadata.Artist != "")
                {
                    tagArgs.Add(String.Format("-metadata artist=\"{0}\"", Metadata.Artist));
                }

                if (Metadata.Comment != "")
                {
                    tagArgs.Add(String.Format("-metadata comment=\"{0}\"", Metadata.Comment));
                }

                if (Metadata.Disc != 0)
                {
                    if (Metadata.TotalDiscs != 0)
                    {
                        tagArgs.Add(String.Format("-metadata disc={0}/{1}", Metadata.Disc, Metadata.TotalDiscs));
                    }
                    else
                    {
                        tagArgs.Add(String.Format("-metadata disc={0}", Metadata.Disc));
                    }
                }

                if (Metadata.Title != "")
                {
                    tagArgs.Add(String.Format("-metadata title=\"{0}\"", Metadata.Title));
                }
                
                if (Metadata.Track != 0)
                {
                    if (Metadata.TotalTracks != 0)
                    {
                        tagArgs.Add(String.Format("-metadata track={0}/{1}", Metadata.Track, Metadata.TotalTracks));
                    }
                    else
                    {
                        tagArgs.Add(String.Format("-metadata track={0}", Metadata.Track));
                    }                    
                }

                if (Metadata.Publisher != "")
                {
                    tagArgs.Add(String.Format("-metadata publisher=\"{0}\"", Metadata.Publisher));
                }

                if (Metadata.Year != 0)
                {
                    tagArgs.Add(String.Format("-metadata date={0}", Metadata.Year));
                }

                if (tagArgs.Count > 0)
                {
                    output = String.Join(" ", tagArgs.ToArray()) + " " + output;
                }                
            }
            
            // Launch process
            Process Term = new Process();
            Term.StartInfo.FileName = termBin;

            if (Session.TwoPassEncoding == true)
            {
                String waitArgs;
                if (termBin == "cmd.exe")
                {
                    waitArgs = "/c start /wait";
                }
                else
                {
                    waitArgs = termArgs;
                }

                // First pass
                Term.StartInfo.Arguments = String.Format("{0} {1} {2} {3} -pass 1 {4} -an -y -f rawvideo {5}", waitArgs, ffmpegBin, input, threads, video, nullPath);
                Term.Start();
                Term.WaitForExit();

                // Second pass                
                Term.StartInfo.Arguments = String.Format("{0} {1} {2} {3} -pass 2 {4} {5} {6}", termArgs, ffmpegBin, input, threads, audio, video, output);
                Term.Start();
            }
            else
            {
                // Single pass
                Term.StartInfo.Arguments = String.Format("{0} {1} {2} {3} {4} {5} {6}", termArgs, ffmpegBin, input, threads, audio, video, output);
                Term.Start();
            }
        }

        // Property methods
        public static String FFmpegBin
        {
            get { return ffmpegBin; }
            set { ffmpegBin = value; }
        }

        public static String TermArgs
        {
            get { return termArgs; }
            set { termArgs = value; }
        }

        public static String TermBin
        {
            get { return termBin; }
            set { termBin = value; }
        }

        public static String NullPath
        {
            get { return nullPath; }
            set { nullPath = value; }
        }
    }
}