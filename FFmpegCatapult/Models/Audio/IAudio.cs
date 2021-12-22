// IAudio is part of FFmpeg Catapult.

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

namespace FFmpegCatapult.Models
{
    interface IAudio : IOutput, IEncoder
    {
        bool IsVBRSupported { get; }
        bool UseVBR { get; set; }
        int Channels { get; set; }
        int CompressionLevel { get; set; }
        int HighPass { get; set; }
        int LowPass { get; set; }
        int MaxChannels { get; }
        int ResamplerPrecision { get; set; }
        int SampleRate { get; set; }
        int VolumeBoost { get; set; }
        int[] Bitrates { get; }
        int[] SampleRates { get; }
        string DitherMethod { get; set; }
        string Resampler { get; set; }
    }
}
