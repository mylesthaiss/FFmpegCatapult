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
    interface IPicture
    {
        bool AspectRatio { get; set; }
        bool Crop { get; set; }
        bool Pad { get; set; }
        bool Deinterlace { get; set; }
        int FPS { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        int WinWidth { get; set; }
        int WinHeight { get; set; }
        int X { get; set; }
        int Y { get; set; }
        int ScaleOption { get; set; }
        string Ratio { get; set; }
        string ScalingMethod { get; set; }
        string VideoFilterColour { get; set; }
    }

    class Picture : IPicture
    {
        private string[,] scalingMethods = new string[,] {
            {"Bicubic", "bicubic"}, {"Bilinear", "bilinear"},
            {"Gaussian", "gauss"}, {"Lanczos", "lanczos"},
            {"Sinc", "sinc"}, {"Spline", "spline"}
        };

        public bool AspectRatio { get; set; }
        public bool Crop { get; set; }
        public bool Pad { get; set; }
        public bool Deinterlace { get; set; }
        public int FPS { get; set; }
        public int Width { get; set; } = 512;
        public int Height { get; set; } = 0;
        public int WinWidth { get; set; }
        public int WinHeight { get; set; }
        public int ScaleOption { get; set; } = 1;
        public int X { get; set; }
        public int Y { get; set; }
        public string Ratio { get; set; } = "16:9";
        public string ScalingMethod { get; set; } = "lanczos";
        public string VideoFilterColour { get; set; }
        public string[,] ScalingMethods
        {
            get { return scalingMethods; }
        }

        public Picture() {}

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
                        AspectRatio = Convert.ToBoolean(node["aspect"].InnerText);
                   
                    if (node["pad"] != null)
                        Pad = Convert.ToBoolean(node["pad"].InnerText);
                        
                    if (node["crop"] != null)
                        Crop = Convert.ToBoolean(node["crop"].InnerText);                  

                    if (node["deinterlace"] != null)
                        Deinterlace = Convert.ToBoolean(node["deinterlace"].InnerText);                

                    if (node["scale"] != null)
                        ScaleOption = Convert.ToInt16(node["scale"].InnerText); 

                    if (node["width"] != null)
                        Width = Convert.ToInt16(node["width"].InnerText);                     

                    if (node["height"] != null)
                        Height = Convert.ToInt16(node["height"].InnerText);

                    if (node["winwidth"] != null)
                        WinWidth = Convert.ToInt16(node["winwidth"].InnerText);
                    
                    if (node["winheight"] != null)
                        WinHeight = Convert.ToInt16(node["winheight"].InnerText);

                    if (node["x"] != null)
                        X = Convert.ToInt16(node["x"].InnerText);

                    if (node["y"] != null)
                        Y = Convert.ToInt16(node["y"].InnerText);

                    if (node["fps"] != null)
                        FPS = Convert.ToInt16(node["fps"].InnerText);                   

                    if (node["ratio"] != null)
                        Ratio = node["ratio"].InnerText;                      

                    if (node["scalemethod"] != null)
                        ScalingMethod = node["scalemethod"].InnerText;
                    
                    if (node["vfcolour"] != null)
                        VideoFilterColour = node["vfcolour"].InnerText;
                }
            }
        }
    }
}
