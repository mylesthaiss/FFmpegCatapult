﻿// Preset is part of FFmpeg Catapult.
// Copyright (C) 2014 Myles Thaiss

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
using System.Xml;

namespace FFmpegCatapult
{
    class Preset : Methods
    {
        public static void InitPreset(string name, string file)
        {
            if (name == "Default" & file == null)
            {
                File.Format = "avi";
                Video.Codec = "mpeg4";
                Video.Bitrate = 1000;
                Video.MaxBitrate = 1500;
                Video.BufferSize = 2;
                Video.BFrames = 2;
                Video.BFStrategy = 2;
                Video.GOPSize = 300;
                Video.Trellis = 2;
                Audio.Codec = "mp3";
                Audio.Channels = 2;
                Audio.SampleRate = 44100;
                Screen.Width = 512;
                Screen.Height = 0;
                Screen.ScaleOption = 1;
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                string path = @"/presets/preset[@name='" + name + @"']";
                XmlNodeList nodes = doc.SelectNodes(path);

                foreach (XmlNode node in nodes)
                {
                    if (node != null)
                    {
                        if (node["format"] != null)
                        {
                            string format = node["format"].InnerText;
                            if (IsValid(format, File.Formats))
                            {
                                File.Format = format;
                            }
                        }

                        if (node["vcodec"] != null)
                        {
                            string codec = node["vcodec"].InnerText;
                            if (IsValid(codec, Video.Codecs))
                            {
                                Video.Codec = codec;
                            }
                        }

                        if (node["videoenc"] != null)
                        {
                            string encoder = node["videoenc"].InnerText;
                            if (IsValid(encoder, Video.Encoders))
                            {
                                Video.Encoder = encoder;
                            }
                        }

                        if (node["vprofile"] != null)
                        {
                            string profile = node["vprofile"].InnerText;
                            if (IsValid(profile, Video.CodecProfiles))
                            {
                                Video.CodecProfile = profile;
                            }
                        }

                        if (node["level"] != null)
                        {
                            Video.CodecLevel = TextToDouble(node["level"].InnerText);
                        }

                        if (node["vb"] != null)
                        {
                            Video.Bitrate = TextToDouble(node["vb"].InnerText);
                        }

                        if (node["minvb"] != null)
                        {
                            Video.MinBitrate = TextToInt(node["minvb"].InnerText);
                        }

                        if (node["maxvb"] != null)
                        {
                            Video.MaxBitrate = TextToInt(node["maxvb"].InnerText);
                        }

                        if (node["buffersize"] != null)
                        {
                            Video.BufferSize = TextToInt(node["buffersize"].InnerText);
                        }

                        if (node["crf"] != null)
                        {
                            Video.UseCRF = TextToBoolean(node["crf"].InnerText);
                        }

                        if (node["vq"] != null)
                        {
                            Video.CRF = TextToInt(node["vq"].InnerText);
                        }

                        if (node["qmin"] != null)
                        {
                            Video.Qmin = TextToInt(node["qmin"].InnerText);
                        }

                        if (node["memethod"] != null)
                        {
                            string meMethod = node["memethod"].InnerText;
                            if (IsValid(meMethod, Video.MEMethods))
                            {
                                Video.MEMethod = meMethod;
                            }
                        }

                        if (node["trellis"] != null)
                        {
                            Video.Trellis = TextToInt(node["trellis"].InnerText);
                        }

                        if (node["gopsize"] != null)
                        {
                            Video.GOPSize = TextToInt(node["gopsize"].InnerText);
                        }

                        if (node["bframes"] != null)
                        {
                            Video.BFrames = TextToInt(node["bframes"].InnerText);
                        }

                        if (node["bftrategy"] != null)
                        {
                            Video.BFStrategy = TextToInt(node["bftrategy"].InnerText);
                        }

                        if (node["acodec"] != null)
                        {
                            string codec = node["acodec"].InnerText;
                            if (IsValid(codec, Audio.Codecs))
                            {
                                Audio.Codec = codec;
                            }
                        }

                        if (node["audioenc"] != null)
                        {
                            string encoder = node["audioenc"].InnerText;
                            if (IsValid(encoder, Audio.Encoders))
                            {
                                Audio.Encoder = encoder;
                            }
                        }

                        if (node["aprofile"] != null)
                        {
                            string profile = node["aprofile"].InnerText;
                            if (IsValid(profile, Audio.CodecProfiles))
                            {
                                Audio.CodecProfile = profile;
                            }
                        }

                        if (node["ab"] != null)
                        {
                            int bitrate = TextToInt(node["ab"].InnerText);
                            if (IsValid(bitrate, Audio.Bitrates))
                            {
                                Audio.Bitrate = bitrate;
                            }
                        }

                        if (node["samplerate"] != null)
                        {
                            int samplerate = TextToInt(node["samplerate"].InnerText);
                            if (IsValid(samplerate, Audio.SampleRates))
                            {
                                Audio.SampleRate = samplerate;
                            }
                        }

                        if (node["channels"] != null)
                        {
                            int channels = TextToInt(node["channels"].InnerText);
                            if (channels <= Audio.MaxChannels)
                            {
                                Audio.Channels = channels;
                            }
                        }

                        if (node["scale"] != null)
                        {
                            Screen.ScaleOption = TextToInt(node["scale"].InnerText);
                        }

                        if (node["width"] != null)
                        {
                            Screen.Width = TextToInt(node["width"].InnerText);
                        }

                        if (node["height"] != null)
                        {
                            Screen.Height = TextToInt(node["height"].InnerText);
                        }

                        if (node["fps"] != null)
                        {
                            Screen.FPS = TextToInt(node["fps"].InnerText);
                        }

                        if (node["aspect"] != null)
                        {
                            Screen.AspectRatio = TextToBoolean(node["aspect"].InnerText);
                        }

                        if (node["ratio"] != null)
                        {
                            string ratio = node["ratio"].InnerText;
                            string[] values = ratio.Split(':');
                            if (values.Length == 2)
                            {
                                Screen.RatioA = TextToInt(values[0]);
                                Screen.RatioB = TextToInt(values[1]);
                            }
                        }
                    }
                }
            }
        }
    }
}
