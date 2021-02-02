﻿﻿// AudioSettingsForm is part of FFmpeg Catapult.

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
using System.Windows.Forms;

namespace FFmpegCatapult
{
    public partial class AudioSettingsForm : Form
    {
        public AudioSettingsForm()
        {
            InitializeComponent();
        }

        private void AudioSettingsForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Audio.CodecProfiles.GetLength(0); i++)
            {
                comboBoxCodecProfiles.Items.Add(new Methods.ListComboContent(Audio.CodecProfiles[i, 0], Audio.CodecProfiles[i, 1]));

                if (Audio.CodecProfile == Audio.CodecProfiles[i, 1])
                {
                    comboBoxCodecProfiles.SelectedIndex = i;
                }
            }

            buttonApply.Enabled = false;
        }

        // Event handlers
        private void ValueChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            Methods.ListComboContent codecProfile = (Methods.ListComboContent)comboBoxCodecProfiles.SelectedItem;
            Audio.CodecProfile = codecProfile.Value;
            this.Close();
        }       
    }
}
