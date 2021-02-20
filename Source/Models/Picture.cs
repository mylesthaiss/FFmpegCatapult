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

using System;
using System.Xml;

namespace FFmpegCatapult.Models
{
    class Picture : IPicture
    {
        private bool aspectRatio = false;
        private bool crop = false;
        private bool pad = false;
        private bool deinterlace = false;
        private int fps;
        private int width;
        private int height;
        private int winWidth;
        private int winHeight;
        private int scaleOption;
        private int x;
        private int y;
        private string ratio;
        private string scalingMethod = "lanczos";
        private string vfColour;
        private string[,] scalingMethods = new string[,] {
            {"Bicubic", "bicubic"}, {"Bilinear", "bilinear"},
            {"Gaussian", "gauss"}, {"Lanczos", "lanczos"},
            {"Sinc", "sinc"}, {"Spline", "spline"}
        };

        public bool AspectRatio
        {
            get { return aspectRatio; }
            set { aspectRatio = value; }
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

        public int WinWidth
        {
            get { return winWidth; }
            set { winWidth = value; }
        }

        public int WinHeight
        {
            get { return winHeight; }
            set { winHeight = value; }
        }

        public int ScaleOption
        {
            get { return scaleOption; }
            set { scaleOption = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
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

        public string VideoFilterColour
        {
            get { return vfColour; }
            set { vfColour = value; }
        }

        public string[,] ScalingMethods
        {
            get { return scalingMethods; }
        }

        public Picture()
        {
            Width = 512;
            Height = 0;
            ScaleOption = 1;
        }

        public Picture(string xmlPath, string presetName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            string path = @"/presets/preset[@name='" + presetName + @"']";
            XmlNodeList nodes = doc.SelectNodes(path);

            foreach (XmlNode node in nodes)
            {
                if (node != null)
                {
                    if (node["aspect"] != null)
                    {
                        AspectRatio = Convert.ToBoolean(node["aspect"].InnerText);
                    }
                   
                    if (node["pad"] != null)
                    {
                        Pad = Convert.ToBoolean(node["pad"].InnerText);
                    }
                        
                    if (node["crop"] != null)
                    {
                        Crop = Convert.ToBoolean(node["crop"].InnerText);
                    }                        

                    if (node["deinterlace"] != null)
                    {
                        Deinterlace = Convert.ToBoolean(node["deinterlace"].InnerText);
                    }                        

                    if (node["scale"] != null)
                    {
                        ScaleOption = Convert.ToInt16(node["scale"].InnerText);
                    }                        

                    if (node["width"] != null)
                    {
                        Width = Convert.ToInt16(node["width"].InnerText);
                    }                        

                    if (node["height"] != null)
                    {
                        Height = Convert.ToInt16(node["height"].InnerText);
                    }

                    if (node["winwidth"] != null)
                    {
                        WinWidth = Convert.ToInt16(node["winwidth"].InnerText);
                    }
                    
                    if (node["winheight"] != null)
                    {
                        WinHeight = Convert.ToInt16(node["winheight"].InnerText);
                    }

                    if (node["x"] != null)
                    {
                        X = Convert.ToInt16(node["x"].InnerText);
                    }

                    if (node["y"] != null)
                    {
                        Y = Convert.ToInt16(node["y"].InnerText);
                    }

                    if (node["fps"] != null)
                    {
                        FPS = Convert.ToInt16(node["fps"].InnerText);
                    }                        

                    if (node["ratio"] != null)
                    {
                        Ratio = node["ratio"].InnerText;
                    }                        

                    if (node["scalemethod"] != null)
                    {
                        ScalingMethod = node["scalemethod"].InnerText;
                    }
                    
                    if (node["vfcolour"] != null)
                    {
                        VideoFilterColour = node["vfcolour"].InnerText;
                    }
                }
            }
        }
    }
}
