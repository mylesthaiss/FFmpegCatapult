// FilePaths is part of FFmpeg Catapult.

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

namespace FFmpegCatapult.Models
{
    class FilePaths : IFilePaths
    {
        private bool overwrite;
        private string source;
        private string output;
        private string log;

        public bool Overwrite
        {
            get { return overwrite; }
            set
            {
                if (source != output)
                {
                    overwrite = value;
                }                    
                else
                {
                    overwrite = false;
                }                    
            }
        }

        public string Source
        {
            get { return source; }
            set { source = value; }
        }

        public string Output
        {
            get { return output; }
            set { output = value; }
        }

        public string Log
        {
            get { return log; }
            set { log = value; }
        }

        public FilePaths()
        {
            log = "FFmpegCatapult.txt";
            overwrite = false;
        }
    }
}
