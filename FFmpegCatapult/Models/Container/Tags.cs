// Tags is part of FFmpeg Catapult.

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
    class Tags : ITags
    {
        public bool Compilation { get; set; } = false;
        public int Disc { get; set; } = 0;
        public int Track { get; set; } = 0;
        public int TotalDiscs { get; set; } = 0;
        public int TotalTracks { get; set; } = 0;
        public int Year { get; set; } = 0;
        public string Album { get; set; }
        public string AlbumArtist { get; set; }
        public string Artist { get; set; }
        public string Comment { get; set; }
        public string Copyright { get; set; }
        public string Description { get; set; }
        public string EpisodeId { get; set; }
        public string Genre { get; set; }
        public string Network { get; set; }
        public string Publisher { get; set; }
        public string Show { get; set; }
        public string Synopsis { get; set; }
        public string Title { get; set; }
    }
}
