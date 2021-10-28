// MP3 is part of FFmpeg Catapult.

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

namespace FFmpegCatapult.Models
{
    class MP3 : Audio
    {
        private bool vbrSupported;
        private int vbrMode;
        private int[] vbrModes;
        private string encoder;

        public override bool IsVBRSupported
        {
            get
            {
                return vbrSupported;
            }
        }

        public override int MaxChannels
        {
            get
            {
                return 2;
            }
        }

        public override int Quality
        {
            get
            {
                return vbrMode;
            }
            set
            {
                vbrMode = value;
            }
        }

        public override int[] Bitrates
        {
            get
            {
                switch (SampleRate)
                {
                    case 8000:
                    case 11025:
                    case 12000:
                        // MPEG-2.5 Layer III bitrates
                        return new int[]
                        {
                            8, 16, 24, 32, 40, 48, 56, 64
                        };
                    case 16000:
                    case 22050:
                    case 24000:
                        // MPEG-2 Layer III bitrates
                        return new int[]
                        {
                            8, 16, 24, 32, 40, 48, 56, 64, 80, 96,
                            112, 128, 144, 160
                        };
                    default:
                        // MPEG-1 Layer III bitrates
                        return new int[]
                        {
                            32, 40, 48, 56, 64, 80, 96, 112, 128,
                            144, 160, 192, 224, 256, 320
                        };
                }
            }
        }

        public override int[] SampleRates
        {
            get
            {
                return new int[]
                {
                    8000, 11025, 12000, 16000, 22050, 24000,
                    32000, 44100, 48000
                };
            }
        }

        public override int[] VBRModes
        {
            get
            {
                return vbrModes;
            }
        }

        public override string Encoder
        {
            get
            {
                return encoder;
            }
            set
            {
                encoder = value;

                switch (encoder)
                {
                    case "libmp3lame":
                        vbrSupported = true;
                        vbrMode = 2;
                        vbrModes = new int[]
                        {
                            9, 8, 7, 6, 5, 4, 3, 2, 1, 0
                        };
                        break;
                    default:
                        vbrSupported = false;
                        vbrMode = 0;
                        vbrModes = null;
                        break;
                }
            }
        }

        public override string Codec
        {
            get
            {
                return "mp3";
            }
        }

        public override string[,] Encoders
        {
            get
            {
                return new string[,]
                {
                    { "LAME", "libmp3lame" }, { "Shine", "libshine" }
                };
            }
        }

        public MP3()
        {
            Encoder = "libmp3lame";
            Bitrate = 192;
        }
    }
}
