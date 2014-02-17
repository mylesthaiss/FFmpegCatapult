// Methods used for FFmpeg Catapult.
// Copyright (C) 2013 Myles Thaiss

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
        // Misc methods
        public static String IntToText(int x)
        {
            String value;
            if (x > 0)
            {
                value = Convert.ToString(x);
            }
            else
            {
                value = "";
            }
            return value;
        }

        public static int TextToInt(String value)
        {
            int x;

            try
            {
                if (value != "")
                {
                    x = Convert.ToInt16(value);
                }
                else
                {
                    x = 0;
                }
            }
            catch (Exception)
            {
                x = 0;
            }

            return x;
        }
    }
}
