// AudioArgs is part of FFmpeg Catapult.

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
        public string GetAudioArgs(IAudio audio)
        {
            string audioArgs;

            if (audio.Codec != "none")
            {
                audioArgs = string.Format("-acodec {0} ", audio.Encoder);

                if (audio.Codec != "copy")
                {
                    if (audio.Profile != null | audio.Profile != "default")
                    {
                        audioArgs += string.Format("-profile:a {0} ", audio.Profile);
                    }

                    if (audio.Bitrate > 0 && !audio.UseVBR)
                    {
                        audioArgs += string.Format("-ab {0}k ", audio.Bitrate);
                    }
                    else if (audio.UseVBR)
                    {
                        audioArgs += string.Format("-q:a {0} ", audio.VBRMode);
                    }

                    if (audio.Channels > 0)
                    {
                        audioArgs += string.Format("-ac {0} ", audio.Channels);
                    }

                    if (audio.SampleRate > 0)
                    {
                        audioArgs += string.Format("-ar {0} ", audio.SampleRate);
                    }          
                }
            }
            else
            {
                audioArgs = "-an ";
            }

            return audioArgs;
        }
    }
}
