// VideoArgs is part of FFmpeg Catapult.

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

using FFmpegCatapult.Models;
using System.Collections.Generic;

namespace FFmpegCatapult.Core
{
    partial class FFmpegBin
    {
        public string GetVideoArgs(IVideo video, ISettings settings)
        {
            List<string> videoArgs = new List<string>();

            if (video.Codec != "none")
            {
                videoArgs.Add(string.Format("-c:v {0}", video.Encoder));

                if (video.Codec != "copy")
                {
                    if (!string.IsNullOrEmpty(video.Profile))
                        videoArgs.Add(string.Format("-profile:v {0}", video.Profile));

                    if (video.CodecLevel > 0 && video.Codec == "h264")
                        videoArgs.Add(string.Format("-level {0:0.0}", video.CodecLevel));

                    if (!string.IsNullOrEmpty(video.EncoderPreset))
                        videoArgs.Add(string.Format("-preset {0}", video.EncoderPreset));

                    // Video bitrates and quality settings
                    if (video.UseCRF == true)
                    {
                        videoArgs.Add(string.Format("-crf {0}", video.Quality));
                    }
                    else
                    {
                        videoArgs.Add(string.Format("-b:v {0}k", video.Bitrate));

                        if (video.MinBitrate != 0)
                            videoArgs.Add(string.Format("-minrate {0}k", video.MinBitrate));

                        if (video.MaxBitrate != 0)
                            videoArgs.Add(string.Format("-maxrate {0}k", video.MaxBitrate));
                    }

                    if (video.QMin != video.QMax)
                        videoArgs.Add(string.Format("-qmin {0}", video.QMin));

                    if (video.QMax != 0)
                        videoArgs.Add(string.Format("-qmax {0}", video.QMax));

                    if (video.BufferSize != 0)
                        videoArgs.Add(string.Format("-bufsize {0}k", video.BufferSize));

                    if (video.GOPSize != 0)
                        videoArgs.Add(string.Format("-g {0}", video.GOPSize));

                    if (video.BFrames != 0)
                        videoArgs.Add(string.Format("-bf {0}", video.BFrames));

                    if (video.BFStrategy > 0)
                        videoArgs.Add(string.Format("-b_strategy {0}", video.BFStrategy));

                    if (!string.IsNullOrEmpty(video.MotionEstimateMethod))
                        videoArgs.Add(string.Format("-me_method {0}", video.MotionEstimateMethod));

                    if (video.DiaSize != 0)
                        videoArgs.Add(string.Format("-dia_size {0}", video.DiaSize));

                    if (video.MotionEstimateCompare != 0)
                        videoArgs.Add(string.Format("-cmp {0}", video.MotionEstimateCompare));

                    if (video.MotionEstimateSubCompare != 0)
                        videoArgs.Add(string.Format("-subcmp {0}", video.MotionEstimateSubCompare));

                    if (video.MotionEstimatePreCompare != 0)
                        videoArgs.Add(string.Format("-precmp {0}", video.MotionEstimatePreCompare));

                    if (video.MacroBlockingCompare != 0)
                        videoArgs.Add(string.Format("-mbcmp {0}", video.MacroBlockingCompare));

                    if (video.Trellis > 0)
                        videoArgs.Add(string.Format("-trellis {0}", video.Trellis));

                    // VP8, VP9 and AV1 settings
                    switch (video.Codec)
                    {
                        case "vp8":
                        case "vp9":
                        case "av1":
                            if (video.TileColumns > 0)
                                videoArgs.Add(string.Format("-tile-columns {0}", video.TileColumns));

                            if (video.TileRows > 0)
                                videoArgs.Add(string.Format("-tile-rows {0}", video.TileRows));

                            if (video.Speed > 0)
                                videoArgs.Add(string.Format("-speed {0}", video.Speed));

                            if (settings.Threads > 0)
                                videoArgs.Add("-row-mt 1");

                            if (settings.Processors > 1 && video.Encoder == "libaom-av1")
                                videoArgs.Add(string.Format("-cpu-used {0}", settings.Processors));
                            break;
                        default:
                            break;
                    }

                    // Threads settings
                    if (settings.Threads > 0)
                        videoArgs.Add(string.Format("-threads {0}", settings.Threads));
                }
            }
            else
            {
                videoArgs.Add("-vn");
            }

            return string.Join(" ", videoArgs);
        }
    }
}
