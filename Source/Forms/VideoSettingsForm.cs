﻿// VideoSettingsForm is part of FFmpeg Catapult.

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
    public partial class VideoSettingsForm : Form
    {
        public VideoSettingsForm()
        {
            InitializeComponent();
        }

        private void VideoSettingsForm_Load(object sender, EventArgs e)
        {
            // Codec profiles
            if (Video.CodecProfiles[0, 0] != null)
            {
                groupBoxCodec.Enabled = true;
                for (int i = 0; i < Video.CodecProfiles.GetLength(0); i++)
                {
                    comboBoxCodecProfiles.Items.Add(new Methods.ListComboContent(Video.CodecProfiles[i, 0], Video.CodecProfiles[i, 1]));

                    if (Video.CodecProfile == Video.CodecProfiles[i, 1])
                    {
                        comboBoxCodecProfiles.SelectedIndex = i;
                    }
                }

                if (Video.Codec == "h264")
                {
                    labelEncodingLevel.Enabled = true;
                    textBoxCodecLevel.Enabled = true;
                    textBoxCodecLevel.Text = Methods.NumToText(Video.CodecLevel);
                }
            }

            // Encoder presets
            if (Video.EncoderPresets[0, 0] != null)
            {
                labelEncoderPreset.Enabled = true;
                comboBoxEncoderPresets.Enabled = true;
                for (int i = 0; i < Video.EncoderPresets.GetLength(0); i++)
                {
                    comboBoxEncoderPresets.Items.Add(new Methods.ListComboContent(Video.EncoderPresets[i, 0], Video.EncoderPresets[i, 1]));

                    if (Video.EncoderPreset == Video.EncoderPresets[i, 1])
                    {
                        comboBoxEncoderPresets.SelectedIndex = i;
                    }
                }
            }

            // Comboboxes
            comboBoxTrellis.Items.Add(new Methods.ListComboContent("None", 0));
            comboBoxTrellis.Items.Add(new Methods.ListComboContent("Final", 1));
            comboBoxTrellis.Items.Add(new Methods.ListComboContent("All RD", 2));
            comboBoxTrellis.Items.Add(new Methods.ListComboContent("Default", 3));
            comboBoxTrellis.SelectedIndex = Video.Trellis;

            comboBoxBFStrats.Items.Add(new Methods.ListComboContent("Always", 0));
            comboBoxBFStrats.Items.Add(new Methods.ListComboContent("Avoid high motion", 1));
            comboBoxBFStrats.Items.Add(new Methods.ListComboContent("Less or more", 2));
            comboBoxBFStrats.Items.Add(new Methods.ListComboContent("Default", 3));
            comboBoxBFStrats.SelectedIndex = Video.BFStrategy;

            for (int i = 0; i < Video.CMPFuncs.GetLength(0); i++)
            {
                comboBoxCMPFuncs.Items.Add(new Methods.ListComboContent(Video.CMPFuncs[i], i));
                comboBoxSubCMPFuncs.Items.Add(new Methods.ListComboContent(Video.CMPFuncs[i], i));
            }
            comboBoxCMPFuncs.SelectedIndex = Video.CMP;
            comboBoxSubCMPFuncs.SelectedIndex = Video.SubCMP;

            for (int i = 0; i < Video.MEMethods.GetLength(0); i++)
            {
                comboBoxMEMethods.Items.Add(new Methods.ListComboContent(Video.MEMethods[i, 0], Video.MEMethods[i, 1]));

                if (Video.MEMethod == Video.MEMethods[i, 1])
                {
                    comboBoxMEMethods.SelectedIndex = i;
                }
            }

            for (int i = 0; i < Video.PictureFormats.GetLength(0); i++)
            {
                comboBoxPictureFormats.Items.Add(new Methods.ListComboContent(Video.PictureFormats[i, 0], Video.PictureFormats[i, 1]));

                if (Video.PictureFormat == Video.PictureFormats[i, 1])
                {
                    comboBoxPictureFormats.SelectedIndex = i;
                }
            }

            // Text boxes
            textBoxBFrames.Text = Methods.NumToText(Video.BFrames);
            textBoxDiaSize.Text = Methods.NumToText(Video.DiaSize);
            textBoxGOPSize.Text = Methods.NumToText(Video.GOPSize);

            buttonApply.Enabled = false;
        }

        // Event handlers
        private void ValueChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void TextBox_KeyPressDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (e.KeyChar != '.')
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            Methods.ListComboContent meMethod = (Methods.ListComboContent)comboBoxMEMethods.SelectedItem;
            Methods.ListComboContent picFormat = (Methods.ListComboContent)comboBoxPictureFormats.SelectedItem;
            Methods.ListComboContent bstrat = (Methods.ListComboContent)comboBoxBFStrats.SelectedItem;
            Methods.ListComboContent cmp = (Methods.ListComboContent)comboBoxCMPFuncs.SelectedItem;
            Methods.ListComboContent subcmp = (Methods.ListComboContent)comboBoxSubCMPFuncs.SelectedItem;
            Methods.ListComboContent trellis = (Methods.ListComboContent)comboBoxTrellis.SelectedItem;

            Video.BFrames = Methods.TextToInt(textBoxBFrames.Text);
            Video.BFStrategy = bstrat.X;
            Video.CMP = cmp.X;
            Video.DiaSize = Methods.TextToInt(textBoxDiaSize.Text);
            Video.GOPSize = Methods.TextToInt(textBoxGOPSize.Text);
            Video.MEMethod = meMethod.Value;
            Video.PictureFormat = picFormat.Value;
            Video.SubCMP = subcmp.X;
            Video.Trellis = trellis.X;

            if (groupBoxCodec.Enabled == true)
            {
                Methods.ListComboContent codecProfile = (Methods.ListComboContent)comboBoxCodecProfiles.SelectedItem;
                Video.CodecLevel = Methods.TextToDouble(textBoxCodecLevel.Text);
                Video.CodecProfile = codecProfile.Value;
            }

            if (comboBoxEncoderPresets.Enabled == true)
            {
                Methods.ListComboContent encPreset = (Methods.ListComboContent)comboBoxEncoderPresets.SelectedItem;
                Video.EncoderPreset = encPreset.Value;
            }

            this.Close();
        }
    }
}
