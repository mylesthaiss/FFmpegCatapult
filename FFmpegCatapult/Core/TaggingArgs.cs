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
using System.Collections.Generic;

namespace FFmpegCatapult.Core
{
    partial class FFmpegBin
    {
        public string GetTaggingArgs(IContainer container, IVideo video)
        {
            List<string> taggingArgs = new List<string>();

            if (container.Tagging)
            {
                if (!string.IsNullOrEmpty(container.Title))
                    taggingArgs.Add(string.Format("-metadata title=\"{0}\"", container.Title));

                if (!string.IsNullOrEmpty(container.Album))
                    taggingArgs.Add(string.Format("-metadata album=\"{0}\"", container.Album));

                if (!string.IsNullOrEmpty(container.AlbumArtist))
                    taggingArgs.Add(string.Format("-metadata album_artist=\"{0}\"", container.AlbumArtist));

                if (!string.IsNullOrEmpty(container.Artist))
                    taggingArgs.Add(string.Format("-metadata artist=\"{0}\"", container.Artist));

                if (!string.IsNullOrEmpty(container.Comment))
                    taggingArgs.Add(string.Format("-metadata comment=\"{0}\"", container.Comment));

                if (container.Compilation && container.Format == "mp3")
                    taggingArgs.Add("-metadata compilation=1");

                if (!string.IsNullOrEmpty(container.Copyright))
                    taggingArgs.Add(string.Format("-metadata copyright=\"{0}\"", container.Copyright));

                if (!string.IsNullOrEmpty(container.Description))
                    taggingArgs.Add(string.Format("-metadata description=\"{0}\"", container.Description));

                if (!string.IsNullOrEmpty(container.EpisodeId))
                    taggingArgs.Add(string.Format("-metadata episode_id=\"{0}\"", container.EpisodeId));

                if (!string.IsNullOrEmpty(container.Genre))
                    taggingArgs.Add(string.Format("-metadata genre=\"{0}\"", container.Genre));

                if (!string.IsNullOrEmpty(container.Network))
                    taggingArgs.Add(string.Format("-metadata network=\"{0}\"", container.Network));

                if (!string.IsNullOrEmpty(container.Show))
                    taggingArgs.Add(string.Format("-metadata show=\"{0}\"", container.Show));

                if (!string.IsNullOrEmpty(container.Synopsis))
                    taggingArgs.Add(string.Format("-metadata synopsis=\"{0}\"", container.Synopsis));

                if (container.Disc > 0)
                {
                    if (container.TotalDiscs > 0)
                        taggingArgs.Add(string.Format("-metadata disc={0}/{1}", container.Disc, container.TotalDiscs));
                    else
                        taggingArgs.Add(string.Format("-metadata disc={0}", container.Disc));
                }

                if (container.Track > 0)
                {
                    if (container.TotalTracks > 0)
                        taggingArgs.Add(string.Format("-metadata track={0}/{1}", container.Track, container.TotalTracks));
                    else
                        taggingArgs.Add(string.Format("-metadata track={0}", container.Track));
                }

                if (!string.IsNullOrEmpty(container.Publisher))
                    taggingArgs.Add(string.Format("-metadata publisher=\"{0}\"", container.Publisher));

                if (container.Year > 0)
                    taggingArgs.Add(string.Format("-metadata date={0}", container.Year));

                if (container.Format == "mp3")
                    taggingArgs.Add("-id3v2_version 3 -write_id3v1 1");

                if (container.FastStartTagging)
                    taggingArgs.Add("-movflags faststart");

                if (container.Format == "mp4" & video.Codec == "h265")
                    taggingArgs.Add("-tag:v hvc1");
            }

            return string.Join(" ", taggingArgs);
        }
    }
}
