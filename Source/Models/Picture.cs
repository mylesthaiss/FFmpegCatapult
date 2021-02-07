// Picture is part of FFmpeg Catapult.

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
    class Picture : IPicture
    {
        private bool aspectRatio = false;
        private bool scale = false;
        private bool crop = false;
        private bool pad = false;
        private bool deinterlace = false;
        private int fps;
        private int width;
        private int height;
        private string ratio;
        private string scalingMethod = "lanczos";
        private string[,] scalingMethods = new string[,] {
            {"Bicubic", "bicubic"} , {"Bilinear", "bilinear"},
            {"Gaussian", "gauss"}, {"Lanczos", "lanczos"},
            {"Sinc", "sinc"}, {"Spline", "spline"}
        };

        public bool AspectRatio
        {
            get { return aspectRatio; }
            set { aspectRatio = value; }
        }

        public bool Scale
        {
            get { return scale; }
            set { scale = value; }
        }

        public bool Crop
        {
            get { return crop; }
            set { crop = value; }
        }

        public bool Pad
        {
            get { return pad; }
            set { pad = value; }
        }

        public bool Deinterlace
        {
            get { return deinterlace; }
            set { deinterlace = value; }
        }

        public int FPS
        {
            get { return fps; }
            set { fps = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public string Ratio
        {
            get { return ratio; }
            set { ratio = value; }
        }

        public string ScalingMethod
        {
            get { return scalingMethod; }
            set { scalingMethod = value; }
        }

        public string[,] ScalingMethods
        {
            get { return scalingMethods; }
        }
    }
}
