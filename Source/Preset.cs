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
            if (file == "default")
            {
                InitDefault();
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
                            File.Format = node["format"].InnerText;
                        }
                        if (node["vcodec"] != null)
                        {
                            Video.Codec = node["vcodec"].InnerText;
                        }                      
                        if (node["videoenc"] != null)
                        {
                            Video.Encoder = node["videoenc"].InnerText;
                        }
                        if (node["vprofile"] != null)
                        {
                            Video.CodecProfile = node["vprofile"].InnerText;
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
                            Video.MEMethod = node["memethod"].InnerText;
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
                            Audio.Codec = node["acodec"].InnerText;
                        }
                        if (node["audioenc"] != null)
                        {
                            Audio.Encoder = node["audioenc"].InnerText;
                        }
                        if (node["aprofile"] != null)
                        {
                            Audio.CodecProfile = node["aprofile"].InnerText;
                        }
                        if (node["ab"] != null)
                        {
                            Audio.Bitrate = TextToInt(node["ab"].InnerText);
                        }
                        if (node["samplerate"] != null)
                        {
                            Audio.SampleRate = TextToInt(node["samplerate"].InnerText);
                        }
                        if (node["channels"] != null)
                        {
                            Audio.Channels = TextToInt(node["channels"].InnerText);
                        }
                        if (node["scale"] != null)
                        {
                            Screen.ScaleOption = TextToInt(node["scale"].InnerText);
                        }
                        if (node["width"] !=  null)
                        {
                            Screen.Width = TextToInt(node["width"].InnerText);
                        }
                        if (node["height"] != null)
                        {
                            Screen.Height = TextToInt(node["height"].InnerText);
                        }
                        if (node["aspect"] != null)
                        {
                            Screen.AspectRatio = TextToBoolean(node["aspect"].InnerText);
                        }
                    }
                }
            }            
        }

        private static void InitDefault()
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
    }
}
