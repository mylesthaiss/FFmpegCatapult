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
using FFmpegCatapult.Factories;

namespace FFmpegCatapult.Tests
{
    [TestClass]
    public class AudioTests
    {
        private FFmpegBin ffmpegBin;
        private Audio audio;
        private Settings settings;

        [TestInitialize]
        public void Setup()
        {
            ffmpegBin = new FFmpegBin();

        }

        [TestMethod]
        public void No_Audio_Stream_Argument_String_Is_Valid()
        {
            audio = AudioFactory.Create("none");
            string arguments = ffmpegBin.GetAudioArgs(audio);

            Assert.AreEqual("-an", arguments);
        }

        [TestMethod]
        public void Copy_Audio_Stream_Argument_String_Is_Valid()
        {
            audio = AudioFactory.Create("copy");
            string arguments = ffmpegBin.GetAudioArgs(audio);

            Assert.AreEqual("-c:a copy", arguments);
        }

        [TestMethod]
        public void Default_MP3_Audio_Stream_Argument_String_Is_Valid()
        {
            audio = AudioFactory.Create("mp3");
            string arguments = ffmpegBin.GetAudioArgs(audio);

            Assert.AreEqual("-c:a libmp3lame -b:a 192k", arguments);
        }

        [TestMethod]
        public void High_Quality_MP3_Audio_Stream_Argument_String_Is_Valid()
        {
            audio = AudioFactory.Create("mp3");
            audio.UseVBR = true;
            audio.Quality = 1;
            audio.Channels = 2;
            audio.SampleRate = 44100;
            string arguments = ffmpegBin.GetAudioArgs(audio);

            Assert.AreEqual("-c:a libmp3lame -q:a 1 -ac 2 -ar 44100 -af aresample=resampler=soxr", arguments);
        }

        [TestMethod]
        public void Default_AAC_Audio_Stream_Argument_String_Is_Valid()
        {
            audio = AudioFactory.Create("aac");
            string arguments = ffmpegBin.GetAudioArgs(audio);

            Assert.AreEqual("-c:a aac -b:a 192k", arguments);
        }

        [TestMethod]
        public void Multi_Channel_AAC_Audio_Stream_Argument_String_Is_Valid()
        {
            audio = AudioFactory.Create("aac");
            audio.Bitrate = 320;
            audio.Channels = 5;
            audio.SampleRate = 48000;
            string arguments = ffmpegBin.GetAudioArgs(audio);

            Assert.AreEqual("-c:a aac -b:a 320k -ac 5 -ar 48000 -af aresample=resampler=soxr", arguments);
        }

        [TestMethod]
        public void Nonfree_AAC_Audio_Stream_Argument_String_Is_Valid()
        {
            settings = new Settings();
            settings.PreferNonFree = true;
            audio = AudioFactory.Create("aac", settings);
            audio.PreferNonfreeEncoder = true;
            audio.UseVBR = true;
            audio.Quality = 3;
            string arguments = ffmpegBin.GetAudioArgs(audio);

            Assert.AreEqual("-c:a libfdk_aac -vbr 3", arguments);
        }

        [TestMethod]
        public void Default_Vorbis_Audio_Stream_Argument_Is_Valid()
        {
            audio = AudioFactory.Create("vorbis");
            string arguments = ffmpegBin.GetAudioArgs(audio);

            Assert.AreEqual("-c:a libvorbis -b:a 128k", arguments);
        }

        [TestMethod]
        public void High_Quality_Vorbis_Audio_Stream_Argument_Is_Valid()
        {
            audio = AudioFactory.Create("vorbis");
            audio.Bitrate = 224;
            string arguments = ffmpegBin.GetAudioArgs(audio);

            Assert.AreEqual("-c:a libvorbis -b:a 224k", arguments);
        }

        [TestMethod]
        public void Default_Opus_Audio_Stream_Argument_Is_Valid()
        {
            audio = AudioFactory.Create("opus");
            string arguments = ffmpegBin.GetAudioArgs(audio);

            Assert.AreEqual("-c:a libopus -b:a 96k", arguments);
        }

        [TestMethod]
        public void High_Quality_Opus_Audio_Stream_Argument_Is_Valid()
        {
            audio = AudioFactory.Create("opus");
            audio.Bitrate = 192;
            audio.SampleRate = 48000;
            string arguments = ffmpegBin.GetAudioArgs(audio);
            
            Assert.AreEqual("-c:a libopus -b:a 192k -ar 48000 -af aresample=resampler=soxr", arguments);
        }
    }
}
