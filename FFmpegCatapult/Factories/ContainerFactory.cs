using System;
using System.Xml;
using FFmpegCatapult.Models;

namespace FFmpegCatapult.Factories
{
    public static class ContainerFactory
    {
        public static readonly string[,] Containers =
        {
            { "3GP", "3gp" }, { "AVI", "avi" }, { "M4A", "m4a" }, { "Matroska", "matroska" }, { "MP3", "mp3" },
            { "MP4", "mp4" }, { "MPEG Program Stream", "mpeg" }, { "MPEG Transport Stream", "mpegts" },
            { "Ogg", "ogg" }, { "WebM", "webm" }, { "Windows Media Audio", "wma" },
            { "Windows Media Video", "wmv" }
        };

        public static Container Create(string format)
        {
            switch (format)
            {
                case "3gp":
                    return new MP43GP();
                case "avi":
                    return new AVI();
                case "matroska":
                    return new Matroska();
                case "mpeg":
                    return new MPG();
                case "mpegts":
                    return new MPEGTS();
                case "mp3":
                    return new MP3();
                case "mp4":
                    return new MP4();
                case "m4a":
                    return new MP4Audio();
                case "ogg":
                    return new Ogg();
                case "webm":
                    return new WebM();
                case "wma":
                    return new WindowsAudio();
                case "wmv":
                    return new WindowsVideo();
                default:
                    return new AVI();
            }
        }

        public static Container Create(string xmlPath, string presetName)
        {
            Container container = Create("mp4");

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            string path = @"/presets/preset[@name='" + presetName + @"']";
            XmlNodeList nodes = doc.SelectNodes(path);

            foreach (XmlNode node in nodes)
            {
                if (node != null)
                {
                    if (node["format"] != null)
                    {
                        string format = node["format"].InnerText;
                        container = Create(format);
                    }

                    if (node["faststart"] != null)
                        container.FastStartTagging = bool.TryParse(node["faststart"].InnerText, out bool fStart) && fStart;
                }
            }

            return container;
        }
    }
}
