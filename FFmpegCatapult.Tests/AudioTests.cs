// AudioTests is part of FFmpeg Catapult.

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
    public class AudioTests
    {
        private FFmpegBin ffmpegBin;
        private Audio audio;

        [TestInitialize]
        public void Setup()
        {
            ffmpegBin = new FFmpegBin();
            audio = new Audio();
        }

        [TestMethod]
        public void No_Audio_Stream_Argument_String_Is_Valid()
        {
            audio.Codec = "none";
            string arguments = ffmpegBin.GetAudioArgs(audio);

            Assert.AreEqual("-an", arguments);
        }

        [TestMethod]
        public void Copy_Audio_Stream_Argument_String_Is_Valid()
        {
            audio.Codec = "copy";
            string arguments = ffmpegBin.GetAudioArgs(audio);

            Assert.AreEqual("-acodec copy", arguments);
        }
    }
}
