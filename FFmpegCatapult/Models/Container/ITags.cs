// ITags is part of FFmpeg Catapult.

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
    public interface ITags
    {
        bool Compilation { get; set; }
        int Disc { get; set; }
        int TotalDiscs { get; set; }
        int TotalTracks { get; set; }
        int Track { get; set; }
        int Year { get; set; }
        string Album { get; set; }
        string AlbumArtist { get; set; }
        string Artist { get; set; }
        string Comment { get; set; }
        string Copyright { get; set; }
        string Description { get; set; }
        string EpisodeId { get; set; }
        string Genre { get; set; }
        string Network { get; set; }
        string Publisher { get; set; }
        string Show { get; set; }
        string Synopsis { get; set; }
        string Title { get; set; }
    }
}
