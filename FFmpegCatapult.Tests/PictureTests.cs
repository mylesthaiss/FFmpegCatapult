// PictureTests is part of FFmpeg Catapult.

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
    public class PictureTests
    {
        private FFmpegBin ffmpegBin;
        private Picture picture;
        private Video video;

        [TestInitialize]
        public void Setup()
        {
            ffmpegBin = new FFmpegBin();
            picture = new Picture();
            video = new Video();
        }

        [TestMethod]
        public void Fixed_Screen_Height_Scale_Arguments_String()
        {
            picture.ScaleOption = 1;
            picture.Height = 512;
            picture.Width = 0;
            string arguments = ffmpegBin.GetPictureArgs(picture, video);

            Assert.AreEqual("-vf scale=\"trunc(oh*a/2)*2:min(512\\,ih)\" -sws_flags lanczos", arguments);
        }

        [TestMethod]
        public void Fixed_Screen_Width_Scale_Arguments_String()
        {
            picture.ScaleOption = 1;
            picture.Width = 256;
            picture.Height = 0;
            string arguments = ffmpegBin.GetPictureArgs(picture, video);

            Assert.AreEqual("-vf scale=\"min(256\\,iw):trunc(ow/a/2)*2\" -sws_flags lanczos", arguments);
        }

        [TestMethod]
        public void Half_Screen_Resoulation_Scale_Arguments_String()
        {
            picture.ScaleOption = 2;
            string arguments = ffmpegBin.GetPictureArgs(picture, video);

            Assert.AreEqual("-vf scale=iw/2:-1 -sws_flags lanczos", arguments);
        }
    }
}
