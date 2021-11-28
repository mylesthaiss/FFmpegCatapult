// VideoFactory is part of FFmpeg Catapult.

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
using System.Xml;
using FFmpegCatapult.Models;

namespace FFmpegCatapult.Factories
{
    public static class VideoFactory
    {
        public static Video Create(string video, ISettings settings)
        {
            switch (video)
            {
                case "av1":
                    return new AV1(settings); 
                case "h264":
                    return new H264();
                case "h265":
                    return new H265();
                case "mpeg2":
                    return new MPEG2();
                case "mpeg4":
                    return new MPEG4();
                case "theora":
                    return new Theora();
                case "vp8":
                    return new VP8();
                case "vp9":
                    return new VP9();
                case "wmv":
                    return new WMV();
                case "copy":
                    return new CopyVideo();
                case "none":
                    return new NoVideo();
                default:
                    return new H264();
            }
        }

        public static Video Create(string video)
        {
            Settings settings = new Settings();
            return Create(video, settings);
        }

        public static Video Create(string presetFile, string presetName, ISettings settings)
        {
            Video video = Create("none", settings);

            XmlDocument doc = new XmlDocument();
            doc.Load(presetFile);
            string path = @"/presets/preset[@name='" + presetName + @"']";
            XmlNodeList nodes = doc.SelectNodes(path);

            foreach (XmlNode node in nodes)
            {
                if (node != null)
                {
                    if (node["vcodec"] != null)
                    {
                        string codec = node["vcodec"].InnerText;
                        video = Create(codec, settings);
                    }

                    if (node["autoaltref"] != null)
                        video.AutoAltRef = bool.TryParse(node["autoaltref"].InnerText, out bool autoAltRef) && autoAltRef;

                    if (node["frameparallel"] != null)
                        video.FrameParallel = bool.TryParse(node["frameparallel"].InnerText, out bool fParallel) && fParallel;

                    if (node["nonfree"] != null)
                        video.PreferNonfreeEncoder = bool.TryParse(node["nonfree"].InnerText, out bool nonfree) && nonfree;

                    if (node["twopass"] != null)
                        video.TwoPassEncoding = bool.TryParse(node["twopass"].InnerText, out bool twopass) && twopass;

                    if (node["vencoder"] != null)
                        video.Encoder = node["vencoder"].InnerText;

                    if (node["vprofile"] != null)
                        video.Profile = node["vprofile"].InnerText;

                    if (node["level"] != null)
                        video.CodecLevel = Double.TryParse(node["level"].InnerText, out double level) ? level : 0;

                    if (node["vpreset"] != null)
                        video.EncoderPreset = node["vpreset"].InnerText;

                    if (node["vb"] != null)
                    {
                        video.UseCRF = false;
                        video.Bitrate = int.TryParse(node["vb"].InnerText, out int vb) ? vb : 500;
                    }

                    if (node["maxvb"] != null)
                        video.MaxBitrate = int.TryParse(node["maxvb"].InnerText, out int maxVb) ? maxVb : 0;

                    if (node["buffersize"] != null)
                        video.BufferSize = int.TryParse(node["buffersize"].InnerText, out int bSize) ? bSize : 0;

                    if (node["bframes"] != null)
                        video.BFrames = int.TryParse(node["bframes"].InnerText, out int bFrames) ? bFrames : 0;

                    if (node["bfstrategy"] != null)
                        video.BFStrategy = int.TryParse(node["bfstrategy"].InnerText, out int bfStrat) ? bfStrat : 0;

                    if (node["cmp"] != null)
                        video.MotionEstimateCompare = int.TryParse(node["cmp"].InnerText, out int cmp) ? cmp : 0;

                    if (node["quality"] != null)
                    {
                        video.UseCRF = true;
                        video.Quality = int.TryParse(node["quality"].InnerText, out int crf) ? crf : 20;
                    }

                    if (node["diasize"] != null)
                        video.DiaSize = int.TryParse(node["diasize"].InnerText, out int diaSize) ? diaSize : 0;

                    if (node["gopsize"] != null)
                        video.GOPSize = int.TryParse(node["gopsize"].InnerText, out int gopSize) ? gopSize : 0;

                    if (node["laginframes"] != null)
                        video.LagInFrames = int.TryParse(node["laginframes"].InnerText, out int lagInFrames) ? lagInFrames : 0;

                    if (node["memethod"] != null)
                        video.MotionEstimateMethod = node["memethod"].InnerText;

                    if (node["pixformat"] != null)
                        video.PixelFormat = node["pixformat"].InnerText;

                    if (node["qmin"] != null)
                        video.QMin = int.TryParse(node["qmin"].InnerText, out int qMin) ? qMin : 0;

                    if (node["qmax"] != null)
                        video.QMax = int.TryParse(node["qmax"].InnerText, out int qMax) ? qMax : 0;

                    if (node["subcmp"] != null)
                        video.MotionEstimateSubCompare = int.TryParse(node["subcmp"].InnerText, out int subCmp) ? subCmp : 0;

                    if (node["tilecolumns"] != null)
                        video.TileColumns = int.TryParse(node["tilecolumns"].InnerText, out int tileCols) ? tileCols : 0;

                    if (node["tilerows"] != null)
                        video.TileRows = int.TryParse(node["tilerows"].InnerText, out int tileRows) ? tileRows : 0;

                    if (node["trellis"] != null)
                        video.Trellis = int.TryParse(node["trellis"].InnerText, out int trellis) ? trellis : 0;

                    if (node["precmp"] != null)
                        video.MotionEstimatePreCompare = int.TryParse(node["precmp"].InnerText, out int preCmp) ? preCmp : 0;

                    if (node["mbcmp"] != null)
                        video.MacroBlockingCompare = int.TryParse(node["mbcmp"].InnerText, out int mbCmp) ? mbCmp : 0;
                }
            }

            return video;
        }
    }
}
