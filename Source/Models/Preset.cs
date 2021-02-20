// Preset is part of FFmpeg Catapult.

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

namespace FFmpegCatapult.Models
{
    partial class Preset
    {
        private bool aspectRatio;
        private bool useCrf;
        private int audioBitrate;
        private int channels;
        private int sampleRate;
        private int videoBitrate;
        private int maxVideoBitrate;
        private int minVideoBitrate;
        private int bufferSize;
        private int bFrames;
        private int bFrameStrategy;
        private int gopSize;
        private int trellis;
        private int videoCrf;
        private int videoQmin;
        private int scaleMode;
        private int width;
        private int height;
        private int fps;
        private double codecLevel;
        private string fileFormat;
        private string audioCodec;
        private string audioEncoder;
        private string audioCodecProfile;
        private string videoCodec;
        private string videoEncoder;
        private string videoCodecProfile;
        private string meMethod;
        private string ratio;

        public class Format : Preset
        {
            public string Type
            {
                get { return fileFormat; }
            }
        }

        public class Audio : Preset
        {
            public int Bitrate
            {
                get { return audioBitrate; }
            }

            public int Channels
            {
                get { return channels; }
            }

            public int SampleRate
            {
                get { return sampleRate; }
            }

            public string Codec
            {
                get { return audioCodec; }
            }

            public string Encoder
            {
                get { return audioEncoder; }
            }

            public string Profile
            {
                get { return audioCodecProfile; }
            }
        }

        public class Video : Preset
        {
            public bool AspectRatio
            {
                get { return aspectRatio; }
            }

            public bool UseCRF
            {
                get { return useCrf; }
            }

            public int Bitrate
            {
                get { return videoBitrate; }
            }

            public int MaxBitrate
            {
                get { return maxVideoBitrate; }
            }

            public int MinBitrate
            {
                get { return minVideoBitrate; }
            }

            public int BufferSize
            {
                get { return bufferSize; }
            }

            public int BFrames
            {
                get { return bFrames; }
            }

            public int BFrameStrategy
            {
                get { return bFrameStrategy; }
            }

            public int GOPSize
            {
                get { return gopSize; }
            }

            public int Trellis
            {
                get { return trellis; }
            }

            public int CRF
            {
                get { return videoCrf; }
            }

            public int Qmin
            {
                get { return videoQmin; }
            }

            public double CodecLevel
            {
                get { return codecLevel; }
            }

            public string Codec
            {
                get { return videoCodec; }
            }

            public string Encoder
            {
                get { return videoEncoder; }
            }

            public string Profile
            {
                get { return videoCodecProfile; }
            }
        }

        private class Picture : Preset
        {
            public int ScaleMode
            {
                get { return scaleMode; }
            }

            public int Width
            {
                get { return width; }
            }

            public int Height
            {
                get { return height; }
            }

            public int FPS
            {
                get { return fps; }
            }
        }

        public Preset()
        {
            //
            // Default profile
            //
            fileFormat = "avi";
            videoCodec = "mpeg4";
            videoBitrate = 1000;
            maxVideoBitrate = 1500;
            bufferSize = 2;
            bFrames = 2;
            bFrameStrategy = 2;
            gopSize = 300;
            trellis = 2;
            audioCodec = "mp3";
            sampleRate = 44100;
            width = 512;
            height = 0;
            scaleMode = 1;
        }

        public Preset(string xmlPath, string presetName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            string path = @"/presets/preset[@name='" + presetName + @"']";
            XmlNodeList nodes = doc.SelectNodes(path);

            foreach (XmlNode node in nodes)
            {
                if (node != null)
                {
                    if (node["format"] != null)
                        fileFormat = node["format"].InnerText;

                    //
                    // Video Settings
                    //
                    if (node["vcodec"] != null)
                        videoCodec = node["vcodec"].InnerText;

                    if (node["videoenc"] != null)
                        videoEncoder = node["videoenc"].InnerText;

                    if (node["vprofile"] != null)
                        videoCodecProfile = node["vprofile"].InnerText;

                    if (node["level"] != null)
                        codecLevel = Convert.ToDouble(node["level"].InnerText);

                    if (node["vb"] != null)
                        videoBitrate = Convert.ToInt16(node["vb"].InnerText);

                    if (node["minvb"] != null)
                        minVideoBitrate = Convert.ToInt16(node["minvb"].InnerText);

                    if (node["maxvb"] != null)
                        maxVideoBitrate = Convert.ToInt16(node["maxvb"].InnerText);

                    if (node["buffersize"] != null)
                        bufferSize = Convert.ToInt16(node["buffersize"].InnerText);

                    if (node["crf"] != null)
                        videoCrf = Convert.ToInt16(node["crf"].InnerText);

                    if (node["qmin"] != null)
                        videoQmin = Convert.ToInt16(node["qmin"].InnerText);

                    if (node["memethod"] != null)
                        meMethod = node["memethod"].InnerText;

                    if (node["trellis"] != null)
                        trellis = Convert.ToInt16(node["trellis"].InnerText);

                    if (node["gopsize"] != null)
                        gopSize = Convert.ToInt16(node["gopsize"].InnerText);

                    if (node["bframes"] != null)
                        bFrames = Convert.ToInt16(node["bframes"].InnerText);

                    if (node["bfstrategy"] != null)
                        bFrameStrategy = Convert.ToInt16(node["bfstrategy"].InnerText);

                    //
                    // Audio Settings
                    //
                    if (node["acodec"] != null)
                        audioCodec = node["acodec"].InnerText;

                    if (node["audioenc"] != null)
                        audioEncoder = node["audioenc"].InnerText;

                    if (node["aprofile"] != null)
                        audioCodecProfile = node["aprofile"].InnerText;

                    if (node["ab"] != null)
                        audioBitrate = Convert.ToInt16(node["ab"].InnerText);

                    if (node["samplerate"] != null)
                        sampleRate = Convert.ToInt16(node["samplerate"].InnerText);

                    if (node["channels"] != null)
                        channels = Convert.ToInt16(node["channels"].InnerText);

                    //
                    // Picture Settings
                    //
                    if (node["scale"] != null)
                        scaleMode = Convert.ToInt16(node["scale"].InnerText);

                    if (node["width"] != null)
                        width = Convert.ToInt16(node["width"].InnerText);

                    if (node["height"] != null)
                        height = Convert.ToInt16(node["height"].InnerText);

                    if (node["fps"] != null)
                        fps = Convert.ToInt16(node["fps"].InnerText);

                    if (node["aspect"] != null)
                        aspectRatio = Convert.ToBoolean(node["aspect"].InnerText);

                    if (node["ratio"] != null)
                        ratio = node["ratio"].InnerText;
                }
            }
        }
    }
}
