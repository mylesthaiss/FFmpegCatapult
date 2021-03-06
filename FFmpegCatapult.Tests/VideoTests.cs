﻿// VideoTests is part of FFmpeg Catapult.

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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using FFmpegCatapult.Core;
using FFmpegCatapult.Models;

namespace FFmpegCatapult.Tests
{
    [TestClass]
    public class VideoTests
    {
        private FFmpegBin ffmpegBin;
        private Settings settings;
        private Video video;

        [TestInitialize]
        public void Setup()
        {
            ffmpegBin = new FFmpegBin();
            settings = new Settings();
            video = new Video();
        }

        [TestMethod]
        public void No_Video_Stream_Argument_String_Is_Valid()
        {
            video.Codec = "none";
            string arguments = ffmpegBin.GetVideoArgs(video, settings);

            Assert.AreEqual("-vn", arguments);
        }

        [TestMethod]
        public void Copy_Video_Stream_Argument_String_Is_Valid()
        {
            video.Codec = "copy";
            string arguments = ffmpegBin.GetVideoArgs(video, settings);

            Assert.AreEqual("-vcodec copy", arguments);
        }

        [TestMethod]
        public void Standard_Definition_H264_Argument_String_Is_Valid()
        {
            video.Codec = "h264";
            video.Profile = "main";
            video.CodecLevel = 3.0;
            video.Bitrate = 1000;
            video.EncoderPreset = "medium";
            string arguments = ffmpegBin.GetVideoArgs(video, settings);

            Assert.AreEqual("-vcodec libx264 -profile:v main -preset medium -level 3.0 -b:v 1000k", arguments);
        }

        [TestMethod]
        public void High_Definition_H264_Argument_String_Is_Valid()
        {
            video.Codec = "h264";
            video.Profile = "high";
            video.CodecLevel = 4.0;
            video.EncoderPreset = "medium";
            video.Quality = 22;
            video.UseCRF = true;
            string arguments = ffmpegBin.GetVideoArgs(video, settings);

            Assert.AreEqual("-vcodec libx264 -profile:v high -preset medium -level 4.0 -crf 22", arguments);
        }
    }
}
