// PictureArgs is part of FFmpeg Catapult.

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
        public string GetPictureArgs(IPicture picture, IVideo video)
        {
            List<string> pictureArgs = new List<string>();
            List<string> filterArgs = new List<string>();

            if (video.Encoder == "copy" | video.Codec == "none")
                return null;

            if (picture.Deinterlace == true)
                filterArgs.Add("yadif=0:-1:0");

            if (picture.AspectRatio == true)
                filterArgs.Add(string.Format("setdar={0}", picture.Ratio));

            if (picture.ScaleOption == 1)
            {
                if (picture.Width > 0 && picture.Height > 0)
                {
                    filterArgs.Add(string.Format("scale={0}:{1}", picture.Width, picture.Height));
                }
                else if (picture.Width > 0 && picture.Height == 0)
                {
                    filterArgs.Add(string.Format("scale=\"min({0}\\,iw):trunc(ow/a/2)*2\"", picture.Width));
                }
                else
                {
                    filterArgs.Add(string.Format("scale=\"trunc(oh*a/2)*2:min({0}\\,ih)\"", picture.Height));
                }
            }
            else if (picture.ScaleOption == 2)
            {
                filterArgs.Add("scale=iw/2:-1");
            }

            if (picture.Pad == true && picture.Crop == false)
                filterArgs.Add(string.Format("pad={0}:{1}:{2}:{3}:{4}", picture.WinWidth, picture.WinHeight, picture.X, picture.Y, picture.VideoFilterColour));

            if (picture.Crop == true && picture.Pad == false)
                filterArgs.Add(string.Format("crop={0}:{1}:{2}:{3}", picture.WinWidth, picture.WinHeight, picture.X, picture.Y));

            if (filterArgs.Count  != 0)
            {
                pictureArgs.Add(string.Join(",", filterArgs));

                if (picture.ScaleOption > 0)
                    pictureArgs.Add(string.Format("-sws_flags {0}", picture.ScalingMethod));
            }

            if (!string.IsNullOrEmpty(video.PixelFormat))
                pictureArgs.Add(string.Format("-pix_fmt {0}", video.PixelFormat));

            if (picture.FPS != 0)
                pictureArgs.Add(string.Format("-r {0}", picture.FPS));

            return string.Join(" ", pictureArgs);
        }
    }
}
