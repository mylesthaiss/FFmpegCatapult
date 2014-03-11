// WinForms code and events for FFmpeg Catapult.
// Copyright (C) 2013 Myles Thaiss

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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            // H.264 values
            if (Video.Codec == "h264")
            {
                groupBoxCodec.Enabled = true;
                labelEncoderPreset.Enabled = true;
                comboBoxEncoderPresets.Enabled = true;

                for (int i = 0; i < Video.CodecProfiles.GetLength(0); i++)
                {
                    comboBoxCodecProfiles.Items.Add(new ListComboContent(Video.CodecProfiles[i, 0], Video.CodecProfiles[i, 1]));

                    if (Video.CodecProfile == Video.CodecProfiles[i, 1])
                    {
                        comboBoxCodecProfiles.SelectedIndex = i;
                    }
                }

                for (int i = 0; i < Video.EncoderPresets.GetLength(0); i++)
                {
                    comboBoxEncoderPresets.Items.Add(new ListComboContent(Video.EncoderPresets[i, 0], Video.EncoderPresets[i, 1]));

                    if (Video.EncoderPreset == Video.EncoderPresets[i, 1])
                    {
                        comboBoxEncoderPresets.SelectedIndex = i;
                    }
                }

                textBoxCodecLevel.Text = Methods.IntToText(Video.CodecLevel);
            }

            // Comboboxes
            comboBoxTrellis.Items.Add(new ListComboIntContent("None", 0));
            comboBoxTrellis.Items.Add(new ListComboIntContent("Final", 1));
            comboBoxTrellis.Items.Add(new ListComboIntContent("All RD", 2));
            comboBoxTrellis.Items.Add(new ListComboIntContent("", 3));
            comboBoxTrellis.SelectedIndex = Video.Trellis;

            comboBoxBFStrats.Items.Add(new ListComboIntContent("Always", 0));
            comboBoxBFStrats.Items.Add(new ListComboIntContent("Avoid high motion", 1));
            comboBoxBFStrats.Items.Add(new ListComboIntContent("Less or more", 2));
            comboBoxBFStrats.Items.Add(new ListComboIntContent("", 3));
            comboBoxBFStrats.SelectedIndex = Video.BFStrategy;

            for (int i = 0; i < Video.CMPFuncs.GetLength(0); i++)
            {
                comboBoxCMPFuncs.Items.Add(new ListComboIntContent(Video.CMPFuncs[i], i));
                comboBoxSubCMPFuncs.Items.Add(new ListComboIntContent(Video.CMPFuncs[i], i));
            }
            comboBoxCMPFuncs.SelectedIndex = Video.CMP;
            comboBoxSubCMPFuncs.SelectedIndex = Video.SubCMP;

            for (int i = 0; i < Video.MEMethods.GetLength(0); i++)
            {
                comboBoxMEMethods.Items.Add(new ListComboContent(Video.MEMethods[i, 0], Video.MEMethods[i, 1]));

                if (Video.MEMethod == Video.MEMethods[i, 1])
                {
                    comboBoxMEMethods.SelectedIndex = i;
                }
            }

            for (int i = 0; i < Video.PictureFormats.GetLength(0); i++)
            {
                comboBoxPictureFormats.Items.Add(new ListComboContent(Video.PictureFormats[i, 0], Video.PictureFormats[i, 1]));

                if (Video.PictureFormat == Video.PictureFormats[i, 1])
                {
                    comboBoxPictureFormats.SelectedIndex = i;
                }
            }

            // Text boxes
            textBoxBFrames.Text = Methods.IntToText(Video.BFrames);
            textBoxDiaSize.Text = Methods.IntToText(Video.DiaSize);
            textBoxGOPSize.Text = Methods.IntToText(Video.GOPSize);
        }

        // Combobox list helpers
        private class ListComboContent
        {
            public string Name;
            public string Value;

            public ListComboContent(string name, string value)
            {
                this.Name = name;
                this.Value = value;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        private class ListComboIntContent
        {
            public string Name;
            public int Value;

            public ListComboIntContent(string name, int x)
            {
                this.Name = name;
                this.Value = x;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        // Event handlers
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }  

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {            
            ListComboContent meMethod = (ListComboContent)comboBoxMEMethods.SelectedItem;
            ListComboContent picFormat = (ListComboContent)comboBoxPictureFormats.SelectedItem;
            ListComboIntContent bstrat = (ListComboIntContent)comboBoxBFStrats.SelectedItem;
            ListComboIntContent cmp = (ListComboIntContent)comboBoxCMPFuncs.SelectedItem;
            ListComboIntContent subcmp = (ListComboIntContent)comboBoxSubCMPFuncs.SelectedItem;
            ListComboIntContent trellis = (ListComboIntContent)comboBoxTrellis.SelectedItem;           

            Video.BFrames = Methods.TextToInt(textBoxBFrames.Text);
            Video.BFStrategy = bstrat.Value;
            Video.CMP = cmp.Value;                                  
            Video.DiaSize = Methods.TextToInt(textBoxDiaSize.Text);
            Video.GOPSize = Methods.TextToInt(textBoxGOPSize.Text);
            Video.MEMethod = meMethod.Value;
            Video.PictureFormat = picFormat.Value;
            Video.SubCMP = subcmp.Value;
            Video.Trellis = trellis.Value;

            if (groupBoxCodec.Enabled == true)
            {
                ListComboContent codecProfile = (ListComboContent)comboBoxCodecProfiles.SelectedItem;
                Video.CodecLevel = Methods.TextToInt(textBoxCodecLevel.Text);
                Video.CodecProfile = codecProfile.Value;
            }

            if (comboBoxEncoderPresets.Enabled == true)
            {
                ListComboContent encPreset = (ListComboContent)comboBoxEncoderPresets.SelectedItem;
                Video.EncoderPreset = encPreset.Value;
            }

            this.Close();
        }              
    }
}
