// TaggingArgs is part of FFmpeg Catapult.

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

using FFmpegCatapult.Models;

namespace FFmpegCatapult.Core
{
    partial class FFmpegBin
    {
        public string GetTaggingArgs(ITags tags, IFileFormat format)
        {
            string taggingArgs = null;

            if (format.Tagging)
            {
                if (!string.IsNullOrEmpty(tags.Title))
                {
                    taggingArgs += string.Format("-metadata title=\"{0}\" ", tags.Title);
                }

                if (!string.IsNullOrEmpty(tags.Album))
                {
                    taggingArgs += string.Format("-metadata album=\"{0}\" ", tags.Album);
                }

                if (!string.IsNullOrEmpty(tags.AlbumArtist))
                {
                    taggingArgs += string.Format("-metadata album_artist=\"{0}\" ", tags.AlbumArtist);
                }

                if (!string.IsNullOrEmpty(tags.Artist))
                {
                    taggingArgs += string.Format("-metadata artist=\"{0}\" ", tags.Artist);
                }

                if (!string.IsNullOrEmpty(tags.Comment))
                {
                    taggingArgs += string.Format("-metadata comment=\"{0}\" ", tags.Comment);
                }

                if (!string.IsNullOrEmpty(tags.Genre))
                {
                    taggingArgs += string.Format("-metadata genre=\"{0}\" ", tags.Genre);
                }

                if (tags.Disc != 0)
                {
                    if (tags.TotalDiscs != 0)
                    {
                        taggingArgs += string.Format("-metadata disc={0}/{1} ", tags.Disc, tags.TotalDiscs);
                    }
                    else
                    {
                        taggingArgs += string.Format("-metadata disc={0} ", tags.Disc);
                    }
                }

                if (tags.Track != 0)
                {
                    if (tags.TotalTracks != 0)
                    {
                        taggingArgs += string.Format("-metadata track={0}/{1} ", tags.Track, tags.TotalTracks);
                    }
                    else
                    {
                        taggingArgs += string.Format("-metadata track={0} ", tags.Track);
                    }
                }

                if (!string.IsNullOrEmpty(tags.Publisher))
                {
                    taggingArgs += string.Format("-metadata publisher=\"{0}\" ", tags.Publisher);
                }

                if (tags.Year != 0)
                {
                    taggingArgs += string.Format("-metadata date={0} ", tags.Year);
                }

                if (format.Format == "mp3")
                {
                    taggingArgs += "-id3v2_version 3 -write_id3v1 1 ";
                }

                if (format.FastStartTagging)
                {
                    taggingArgs += "-movflags +faststart ";
                }
            }

            return string.IsNullOrEmpty(taggingArgs) ? null : taggingArgs.Trim();
        }
    }
}
