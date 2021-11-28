// AudioFactory is part of FFmpeg Catapult.

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

using System.Xml;
using FFmpegCatapult.Models;

namespace FFmpegCatapult.Factories
{
    public static class AudioFactory
    {
        public static Audio Create(string audio, ISettings settings)
        {
            switch (audio)
            {
                case "aac":
                    return new AAC(settings);
                case "ac3":
                    return new AC3();
                case "copy":
                    return new CopyAudio();
                case "flac":
                    return new FLAC();
                case "mp2":
                    return new MP2();
                case "mp3":
                    return new MP3();
                case "none":
                    return new NoAudio();
                case "opus":
                    return new Opus();
                case "pcm":
                    return new PCM();
                case "speex":
                    return new Speex();
                case "vorbis":
                    return new Vorbis();
                case "wma":
                    return new WMA();
                default:
                    return new MP3();
            }
        }

        public static Audio Create(string audio)
        {
            Settings settings = new Settings();
            return Create(audio, settings);
        }

        public static Audio Create(string presetFile, string presetName, ISettings settings)
        {
            Audio audio = Create("none", settings);

            XmlDocument doc = new XmlDocument();
            doc.Load(presetFile);
            string path = @"/presets/preset[@name='" + presetName + @"']";
            XmlNodeList nodes = doc.SelectNodes(path);

            foreach (XmlNode node in nodes)
            {
                if (node != null)
                {
                    if (node["acodec"] != null)
                    {
                        string codec = node["vcodec"].InnerText;
                        audio = Create(codec, settings);
                    }

                    if (node["nonfree"] != null)
                        audio.PreferNonfreeEncoder = bool.TryParse(node["nonfree"].InnerText, out bool nonfree) && nonfree;

                    if (node["aencoder"] != null)
                        audio.Encoder = node["aencoder"].InnerText;

                    if (node["ab"] != null)
                        audio.Bitrate = int.TryParse(node["ab"].InnerText, out int ab) ? ab : 0;

                    if (node["vbr"] != null)
                    {
                        audio.UseVBR = true;
                        audio.Quality = int.TryParse(node["vbr"].InnerText, out int vbr) ? vbr : 0;
                    }

                    if (node["channels"] != null)
                        audio.Channels = int.TryParse(node["channels"].InnerText, out int ch) ? ch : 0;

                    if (node["samplerate"] != null)
                        audio.SampleRate = int.TryParse(node["samplerate"].InnerText, out int ar) ? ar : 0;

                    if (node["volume"] != null)
                        audio.VolumeBoost = int.TryParse(node["volume"].InnerText, out int vol) ? vol : 0;
                }
            }

            return audio;
        }
    }    
}
