﻿// Screen is part of FFmpeg Catapult.
// Copyright (C) 2014 Myles Thaiss

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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFmpegCatapult
{
    class Screen
    {
        // Variables
        public static bool AspectRatio = false;
        public static bool CropVideo = false;
        public static bool Deinterlace = false;
        public static bool PadVideo = false;
        private static int vfX = 0;
        private static int vfY = 0;
        private static int fps = 0;
        private static int height = 0;
        private static int width = 0;
        private static int ratioA = 16;
        private static int ratioB = 9;
        private static int scaleOption = 0;
        private static int winHeight;
        private static int winWidth;
        private static string vfColour;
        private static string scalingMethod = "lanczos";
        private static string[,] scalingMethods = new string[,] {
            {"Bicubic", "bicubic"} , {"Bilinear", "bilinear"},
            {"Gaussian", "gauss"}, {"Lanczos", "lanczos"},
            {"Sinc", "sinc"}, {"Spline", "spline"}
        };

        // Property methods
        public static string VFColour
        {
            get { return vfColour; }
            set { vfColour = value; }
        }

        public static int FPS
        {
            get { return fps; }
            set { fps = value; }
        }

        public static int Height
        {
            get { return height; }
            set { height = value; }
        }

        public static int WinHeight
        {
            get { return winHeight; }
            set { winHeight = value; }
        }

        public static int WinWidth
        {
            get { return winWidth; }
            set { winWidth = value; }
        }

        public static int Width
        {
            get { return width; }
            set { width = value; }
        }

        public static int ScaleOption
        {
            get { return scaleOption; }
            set { scaleOption = value; }
        }

        public static int RatioA
        {
            get { return ratioA; }
            set { ratioA = value; }
        }

        public static int RatioB
        {
            get { return ratioB; }
            set { ratioB = value; }
        }

        public static string ScalingMethod
        {
            get { return scalingMethod; }
            set { scalingMethod = value; }
        }

        public static string[,] ScalingMethods
        {
            get { return scalingMethods; }
        }

        public static int X
        {
            get { return vfX; }
            set { vfX = value; }
        }

        public static int Y
        {
            get { return vfY; }
            set { vfY = value; }
        }
    }
}
