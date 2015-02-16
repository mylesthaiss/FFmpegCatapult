// Methods is part of FFmpeg Catapult.
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
    class Methods
    {
        /// <summary>
        /// Converts numbers to string if a number is greater than zero.
        /// A 'null' value will return if x = 0.
        /// </summary>
        /// <param name="x"></param>       
        public static string NumToText(double x)
        {
            string value;
            if (x > 0)
            {
                value = Convert.ToString(x);
            }
            else
            {
                value = null;
            }
            return value;
        }

        public static string NumToText(int x)
        {
            string value;
            if (x > 0)
            {
                value = Convert.ToString(x);
            }
            else
            {
                value = null;
            }
            return value;
        }

        /// <summary>
        /// Converts a string value to a boolean type.     
        /// </summary>
        /// <param name="value"></param> 
        public static bool TextToBoolean(string value)
        {
            bool output;
            if (value == "true" | value == "1")
            {
                output = true;
            }
            else
            {
                output = false;
            }
            return output;
        }

        /// <summary>
        /// Converts string value to double type. Zero will be returned 
        /// if value is null or empty.
        /// </summary>
        /// <param name="value"></param>       
        public static double TextToDouble(string value)
        {
            double x;
            if (!string.IsNullOrEmpty(value) && double.TryParse(value, out x))
            {
                return x;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Converts string value to integer type. Zero will be returned 
        /// if value is null or empty.
        /// </summary>
        /// <param name="value"></param>        
        public static int TextToInt(string value)
        {
            int x;
            if (!string.IsNullOrEmpty(value) && int.TryParse(value, out x))
            {
                return x;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Determines if the current settings is used to encode audio files only.
        /// </summary>        
        public static bool IsAudioFile()
        {
            if (File.Format == "m4a" | File.Format == "mp3" | File.Format == "wma")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if value matches a value from a array.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="items"></param>
        public static bool IsValid(string value, string[] items)
        {
            bool valid = false;
            for (int i = 0; i < items.GetLength(0); i++)
            {
                if (value == items[i])
                {
                    valid = true;
                    break;
                }
            }
            return valid;
        }

        public static bool IsValid(string value, string[,] items)
        {
            bool valid = false;
            for (int i = 0; i < items.GetLength(0); i++)
            {
                if (value == items[i, 1])
                {
                    valid = true;
                    break;
                }
            }
            return valid;
        }

        public static bool IsValid(int x, int[] items)
        {
            bool valid = false;
            for (int i = 0; i < items.GetLength(0); i++)
            {
                if (x == items[i])
                {
                    valid = true;
                    break;
                }
            }
            return valid;
        }

        /// <summary>
        /// Determines if video scaling is available.
        /// </summary>        
        public static bool IsPictureScalable()
        {
            if (IsAudioFile() | Video.Codec == "copy" | Video.Codec == "none")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Combobox list helper.
        /// </summary>
        public class ListComboContent
        {
            private string name;
            private string value;
            private int x;

            public ListComboContent(string label, string arg)
            {
                name = label;
                value = arg;
            }

            public ListComboContent(string label, int y)
            {
                name = label;
                x = y;
            }

            public int X
            {
                get { return x; }
            }

            public string Value
            {
                get { return value; }
            }

            public string Name
            {
                get { return name; }
            }

            public override string ToString()
            {
                return name;
            }
        }
    }
}
