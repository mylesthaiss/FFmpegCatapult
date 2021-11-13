// AAC is part of FFmpeg Catapult.

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
    class AAC : Audio
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
                return 8;
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
                return new int[]
                {
                    8, 16, 32, 40, 48, 56, 64, 80, 96, 112, 128, 160,
                    192, 224, 256, 320, 384, 448
                };
            }
        }

        public override int[] SampleRates
        {
            get
            {
                return new int[]
                {
                    8000, 11025, 16000, 22050, 32000, 44100,
                    48000, 96000, 192000
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
                    case "libfdk_aac":
                        vbrSupported = true;
                        vbrMode = 3;
                        vbrModes = new int[]
                        {
                            1, 2, 3, 4
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
                return "aac";
            }
        }

        public override string[,] Encoders
        {
            get
            {
                return new string[,]
                {
                    { "AAC (FFmpeg)", "aac" }, { "Fraunhofer FDK", "libfdk_aac" }
                };
            }
        }

        public AAC(ISettings settings)
        {
            if (settings.PreferNonFree)
            {
                Encoder = "libfdk_aac";
                Bitrate = 128;
            }
            else
            {
                Encoder = "aac";
                Bitrate = 192;
            }            
        }
    }

    class HEAAC : Audio
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
                return 8;
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
                return new int[]
                {
                    8, 16, 32, 40, 48, 56, 64, 80, 96, 112, 128, 160,
                    192, 224, 256, 320, 384, 448
                };
            }
        }

        public override int[] SampleRates
        {
            get
            {
                return new int[]
                {
                    8000, 11025, 16000, 22050, 32000, 44100,
                    48000, 96000, 192000
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
                    case "libfdk_aac":
                        vbrSupported = true;
                        vbrMode = 3;
                        vbrModes = new int[]
                        {
                            1, 2, 3, 4
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
                return "heaac";
            }
        }

        public override string[,] Encoders
        {
            get
            {
                return new string[,]
                {
                    { "AAC (FFmpeg)", "aac" }, { "Fraunhofer FDK", "libfdk_aac" }
                };
            }
        }

        public HEAAC()
        {
            Encoder = "libfdk_aac";
            Bitrate = 64;
        }
    }
}
