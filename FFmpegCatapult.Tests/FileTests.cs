// FileTests is part of FFmpeg Catapult.

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
    public class FileTests
    {
        private FFmpegBin ffmpegBin;
        private FileFormat file;
        private FilePaths paths;
        private Audio audio;
        private Video video;

        [TestInitialize]
        public void Setup()
        {
            ffmpegBin = new FFmpegBin();
            file = new FileFormat();
            paths = new FilePaths();
            audio = new Audio();
            video = new Video();
        }

        [TestMethod]
        public void Audio_Codec_Is_Valid()
        {
            file.Format = "mp4";
            audio.Codec = "aac";

            Assert.IsTrue(file.IsCodecSupported(audio));
        }

        [TestMethod]
        public void Video_Codec_Is_Valid()
        {            
            file.Format = "mp4";
            video.Codec = "h264";

            Assert.IsTrue(file.IsCodecSupported(video));
        }

        [TestMethod]
        public void Handle_Dubplicate_File_Paths()
        {
            paths.Source = "test_s01e01.mp4";
            paths.Output = "test_s01e01.mp4";

            Assert.AreEqual("test_s01e01_output.mp4", paths.Output);
        }

        [TestMethod]
        public void Setting_Overwrite_Is_Valid()
        {
            paths.Source = "test_s01e01.mp4";
            paths.Output = "test_s01e01_h265.mp4";
            paths.Overwrite = true;

            Assert.IsTrue(paths.Overwrite);
        }

        [TestMethod]
        public void Setting_Overwrite_Is_Invalid()
        {
            paths.Overwrite = true;
            paths.Output = "test_s01e01.mp4";            
            paths.Source = "test_s01e01.mp4";            
            
            Assert.IsFalse(paths.Overwrite);
        }
    }
}
