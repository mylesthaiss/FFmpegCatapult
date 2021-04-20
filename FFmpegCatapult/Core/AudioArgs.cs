﻿// AudioArgs is part of FFmpeg Catapult.

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
        public string GetAudioArgs(IAudio audio)
        {
            List<string> filterArgs = new List<string>();
            string audioArgs;

            if (audio.Codec != "none")
            {
                audioArgs = string.Format("-c:a {0} ", audio.Encoder);

                if (audio.Codec != "copy")
                {
                    if (audio.Profile != null)
                        audioArgs += string.Format("-profile:a {0} ", audio.Profile);

                    if (audio.Bitrate > 0 && !audio.UseVBR)
                    {
                        audioArgs += string.Format("-b:a {0}k ", audio.Bitrate);
                    }
                    else if (audio.UseVBR)
                    {
                        if (audio.Encoder == "libfdk_aac")
                            audioArgs += string.Format("-vbr {0}", audio.Quality);
                        else
                            audioArgs += string.Format("-q:a {0} ", audio.Quality);
                    }

                    if (audio.Channels > 0)
                        audioArgs += string.Format("-ac {0} ", audio.Channels);

                    if (audio.SampleRate > 0)
                        audioArgs += string.Format("-ar {0} ", audio.SampleRate);

                    //
                    // Audio filter arguments
                    //
                    if (audio.SampleRate > 0)
                    {
                        string resampleArgs = string.Format("aresample=resampler={0}", audio.Resampler);

                        if (audio.Resampler == "soxr")
                        {
                            if (audio.ResamplerPrecision > 0)
                                resampleArgs += string.Format(":precision={0}", audio.ResamplerPrecision);

                            if (audio.DitherMethod != null)
                                resampleArgs += string.Format(":dither_method={0}", audio.DitherMethod);
                        }

                        if (audio.VolumeBoost != 0)
                            resampleArgs += string.Format(",volume={0}dB", audio.VolumeBoost);

                        filterArgs.Add(resampleArgs);
                    }

                    if (audio.HighPass != 0)
                        filterArgs.Add(string.Format("highpass=f={0}", audio.HighPass));

                    if (audio.LowPass != 0)
                        filterArgs.Add(string.Format("lowpass=f={0}", audio.LowPass));

                    if (filterArgs.Count != 0)
                        audioArgs += string.Format("-af {0}", string.Join(",", filterArgs));
                }
            }
            else
            {
                audioArgs = "-an";
            }

            return audioArgs.Trim();
        }
    }
}
