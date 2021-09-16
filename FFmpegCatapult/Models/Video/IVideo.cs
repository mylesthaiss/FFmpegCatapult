// IVideo is part of FFmpeg Catapult.

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
    public interface IVideo : IOutput, IEncoder
    {
        bool AutoAltRef { get; set; }
        bool FrameParallel { get; set; }
        bool TwoPassEncoding { get; set; }
        bool UseCRF { get; set; }
        double CodecLevel { get; set; }
        int BFrames { get; set; }
        int BFStrategy { get; set; }
        int BufferSize { get; set; }
        int DiaSize { get; set; }
        int GOPSize { get; set; }
        int LagInFrames { get; set; }
        int MacroBlockingCompare { get; set; }
        int MaxBitrate { get; set; }
        int MinBitrate { get; set; }
        int MotionEstimateCompare { get; set; }
        int MotionEstimatePreCompare { get; set; }
        int MotionEstimateSubCompare { get; set; }
        int QMax { get; set; }
        int QMin { get; set; }
        int Speed { get; set; }
        int TargetSize { get; set; }
        int TileColumns { get; set; }
        int TileRows { get; set; }
        int Trellis { get; set; }
        string MotionEstimateMethod { get; set; }
        string PixelFormat { get; set; }
    }
}
