// VideoTests is part of FFmpeg Catapult.

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

            Assert.AreEqual("-c:v copy", arguments);
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

            Assert.AreEqual("-c:v libx264 -profile:v main -level 3.0 -preset medium -b:v 1000k", arguments);
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

            Assert.AreEqual("-c:v libx264 -profile:v high -level 4.0 -preset medium -crf 22", arguments);
        }

        [TestMethod]
        public void Standard_Definition_MPEG4_Argument_String_Is_Valid()
        {
            video.Codec = "mpeg4";
            string arguments = ffmpegBin.GetVideoArgs(video, settings);

            Assert.AreEqual("-c:v libxvid -b:v 15000k", arguments);
        }

        [TestMethod]
        public void High_Definition_MPEG4_Argument_String_Is_Valid()
        {
            video.Codec = "mpeg4";
            video.Bitrate = 8000;
            string arguments = ffmpegBin.GetVideoArgs(video, settings);

            Assert.AreEqual("-c:v libxvid -b:v 8000k", arguments);
        }

        [TestMethod]
        public void High_Definintion_H265_Argument_String_Is_Valid()
        {
            video.Codec = "h265";
            video.Quality = 22;
            string arguments = ffmpegBin.GetVideoArgs(video, settings);

            Assert.AreEqual("-c:v libx265 -preset medium -crf 22", arguments);
        }

        [TestMethod]
        public void Low_Bitrate_H265_Argument_String_Is_Valid()
        {
            video.Codec = "h265";
            video.UseCRF = false;
            video.Bitrate = 500;
            string arguments = ffmpegBin.GetVideoArgs(video, settings);

            Assert.AreEqual("-c:v libx265 -preset medium -b:v 500k", arguments);
        }

        [TestMethod]
        public void Standard_Definintion_VP9_Argument_String_Is_Valid()
        {
            video.Codec = "vp9";
            string arguments = ffmpegBin.GetVideoArgs(video, settings);

            Assert.AreEqual("-c:v libvpx-vp9 -b:v 1000k -tilecolumns 6 -speed 1", arguments);
        }

        [TestMethod]
        public void Standard_Definintion_AV1_Argument_String_Is_Valid()
        {
            video.Codec = "av1";
            string arguments = ffmpegBin.GetVideoArgs(video, settings);

            Assert.AreEqual("-c:v libaom-av1 -b:v 768k", arguments);
        }

        [TestMethod]
        public void High_Definintion_AV1_Argument_String_Is_Valid()
        {
            video.Codec = "av1";
            video.UseCRF = true;
            video.Quality = 30;
            string arguments = ffmpegBin.GetVideoArgs(video, settings);

            Assert.AreEqual("-c:v libaom-av1 -crf 30", arguments);
        }

        [TestMethod]
        public void Standard_Definintion_MPEG2_Argument_String_Is_Valid()
        {
            video.Codec = "mpeg2";
            string arguments = ffmpegBin.GetVideoArgs(video, settings);

            Assert.AreEqual("-c:v mpeg2video -b:v 4000k", arguments);
        }

        [TestMethod]
        public void High_Definintion_MPEG2_Argument_String_Is_Valid()
        {
            video.Codec = "mpeg2";
            video.Bitrate = 120000;
            string arguments = ffmpegBin.GetVideoArgs(video, settings);

            Assert.AreEqual("-c:v mpeg2video -b:v 120000k", arguments);
        }
    }
}
