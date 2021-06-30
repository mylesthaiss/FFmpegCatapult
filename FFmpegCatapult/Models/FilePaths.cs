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

using System.IO;

namespace FFmpegCatapult.Models
{
    class FilePaths : IFilePaths
    {
        private bool overwrite;
        private string output;

        public string Audio { get; set; }
        public string Source { get; set; }

        public bool Overwrite
        {
            get
            {
                if (Source == Output)
                    return false;                 
                else
                    return overwrite;              
            }
            set { overwrite = value; }
        }

        public string Output
        {
            get { return output; }
            set
            {
                if (value == Source)
                    output = string.Format("{0}_output{1}", Path.ChangeExtension(value, null), Path.GetExtension(value));    
                else
                    output = value;                 
            }
        }

        public FilePaths()
        {
            Overwrite = false;
        }
    }
}
