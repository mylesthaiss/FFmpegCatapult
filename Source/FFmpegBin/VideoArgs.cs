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

namespace FFmpegCatapult.FFmpegBin
{
    partial class FFmpegBin
    {
        public string GetVideoArgs(IVideo video, ISettings settings)
        {
            string videoArgs;

            if (video.Codec != "none")
            {
                videoArgs = string.Format("-vcodec {0} ", video.Codec);

                if (video.Codec != "copy")
                {
                    if (!string.IsNullOrEmpty(video.Profile))
                    {
                        videoArgs += string.Format("-profile:v {0} ", video.Profile);
                    }

                    if (!string.IsNullOrEmpty(video.EncoderPreset))
                    {
                        videoArgs += string.Format("-preset {0} ", video.EncoderPreset);
                    }

                    if (video.CodecLevel > 0 && video.Encoder == "libx264")
                    {
                        videoArgs += string.Format("-level {0} ", video.CodecLevel);
                    }

                    // Video bitrates and quality settings
                    if (video.UseCRF == true)
                    {
                        if (video.Encoder == "libx265")
                        {
                            videoArgs += string.Format("-x265-params crf={0} ", video.CRF);
                        }
                        else
                        {
                            videoArgs += string.Format("-crf {0} ", video.CRF);
                        }
                    }
                    else
                    {
                        videoArgs += string.Format("-b:v {0}k ", video.Bitrate);

                        if (video.MinBitrate != 0)
                        {
                            videoArgs += string.Format("-minrate {0}k ", video.MinBitrate);
                        }

                        if (video.MaxBitrate != 0)
                        {
                            videoArgs += string.Format("-maxrate {0}k ", video.MaxBitrate);
                        }
                    }

                    if (video.QMin != video.QMax)
                    {
                        videoArgs += string.Format("-qmin {0} ", video.QMin);
                    }

                    if (video.QMax != 0)
                    {
                        videoArgs += string.Format("-qmax {0} ", video.QMax);
                    }

                    if (video.BufferSize != 0)
                    {
                        videoArgs += string.Format("-bufsize {0}k ", video.BufferSize);
                    }

                    if (video.GOPSize != 0)
                    {
                        videoArgs += string.Format("-g {0} ", video.GOPSize);
                    }

                    if (video.BFrames != 0)
                    {
                        videoArgs += string.Format("-bf {0} ", video.BFrames);
                    }

                    if (video.BFStrategy < 3)
                    {
                        videoArgs += string.Format("-b_strategy {0} ", video.BFStrategy);
                    }

                    if (video.MEMethod != "")
                    {
                        videoArgs += string.Format("-me_method {0} ", video.MEMethod);
                    }

                    if (video.DiaSize != 0)
                    {
                        videoArgs += string.Format("-dia_size {0} ", video.DiaSize);
                    }

                    if (video.CMP != 15)
                    {
                        videoArgs += string.Format("-cmp {0} ", video.CMP);
                    }

                    if (video.SubCMP != 15)
                    {
                        videoArgs += string.Format("-subcmp {0} ", video.SubCMP);
                    }

                    if (video.Trellis != 3)
                    {
                        videoArgs += string.Format("-trellis {0} ", video.Trellis);
                    }

                    // VPX encoder arguments
                    if (video.Codec == "vp8" | video.Codec == "vp9")
                    {
                        if (video.Encoder == "libvpx-vp9")
                        {
                            int aRef = video.AutoAltRef ? 1 : 0;
                            int frameParallel = video.FrameParallel ? 1 : 0;
                            videoArgs += string.Format("-speed {0} ", video.Speed);
                            videoArgs += string.Format("-tile-columns {0} ", video.TileColumns);
                            videoArgs += string.Format("-frame-parallel {0} ", frameParallel);
                            videoArgs += string.Format("-auto-alt-ref {0} ", aRef);
                            videoArgs += string.Format("-lag-in-frames {0} ", video.LagInFrames);
                        }
                    }

                    // AOMedia AV1 encoder arguments
                    if (video.Encoder == "libaom-av1")
                    {
                        videoArgs += string.Format("-tile-columns {0} ", video.TileColumns);
                        videoArgs += string.Format("-tile-rows {0} ", video.TileRows);

                        if (settings.Processors > 1)
                        {
                            videoArgs += string.Format("-cpu-used {0} -row-mt 1 ", settings.Processors);
                        }
                    }

                    if (settings.Threads > 0)
                    {
                        videoArgs += string.Format("-threads {0} ", settings.Threads);
                    }
                }
            }
            else
            {
                videoArgs = "-vn ";
            }

            return videoArgs;
        }
    }
}
