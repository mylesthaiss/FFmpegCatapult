﻿// Video tab event handlers for FFmpeg Catapult.
// Copyright (C) 2014 Myles Thaiss

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
    partial class MainForm : Form
    {
        void buttonVideoCodecProperties_Clicked(object sender, EventArgs e)
        {
            VideoSettingsForm videoProperties = new VideoSettingsForm();
            videoProperties.StartPosition = FormStartPosition.CenterParent;
            videoProperties.ShowDialog(this);
        }

        void comboBoxVideoCodecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListComboContent codec = (ListComboContent)comboBoxVideoCodecs.SelectedItem;
            if (codec.Value != Video.Codec)
            {
                Video.Codec = codec.Value;
                InitTabs();
                InitVideo();
            }
        }

        void comboBoxVideoEncoders_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListComboContent encoder = (ListComboContent)comboBoxVideoEncoders.SelectedItem;
            Video.Encoder = encoder.Value;
        }

        void comboBoxBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListComboContent bits = (ListComboContent)comboBoxBits.SelectedItem;
            Video.Bits = bits.Value;
            labelMaxBits.Text = bits.Name;
            labelMinBits.Text = bits.Name;
        }

        void comboBoxBytes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListComboContent bytes = (ListComboContent)comboBoxBytes.SelectedItem;
            Video.Bytes = bytes.Value;
        }

        void checkBoxTwoPassEncoding_CheckedChanged(object sender, EventArgs e)
        {
            Session.TwoPassEncoding = checkBoxTwoPassEncoding.Checked;
            if (Session.TwoPassEncoding)
            {
                checkBoxUseCRF.Enabled = false;
                EnableCRFControls(false);
            }
            else
            {
                checkBoxUseCRF.Enabled = true;
                EnableCRFControls(Video.UseCRF);
            }
        }

        void checkBoxUseCRF_CheckedChanged(object sender, EventArgs e)
        {
            Video.UseCRF = checkBoxUseCRF.Checked;
            EnableCRFControls(Video.UseCRF);
        }

        void textBoxVideoBitrate_TextChanged(object sender, EventArgs e)
        {
            Video.Bitrate = Methods.TextToDouble(textBoxVideoBitrate.Text);
        }

        void textBoxMinBitrate_TextChanged(object sender, EventArgs e)
        {
            Video.MinBitrate = Methods.TextToDouble(textBoxMinBitrate.Text);
        }

        void textBoxMaxBitrate_TextChanged(object sender, EventArgs e)
        {
            Video.MaxBitrate = Methods.TextToDouble(textBoxMaxBitrate.Text);
        }

        void textBoxBufferSize_TextChanged(object sender, EventArgs e)
        {
            Video.BufferSize = Methods.TextToDouble(textBoxBufferSize.Text);
        }

        void textBoxCRF_TextChanged(object sender, EventArgs e)
        {
            Video.CRF = Methods.TextToInt(textBoxCRF.Text);
        }

        void textBoxQmax_TextChanged(object sender, EventArgs e)
        {
            Video.Qmax = Methods.TextToInt(textBoxQmax.Text);
        }

        void textBoxQmin_TextChanged(object sender, EventArgs e)
        {
            Video.Qmin = Methods.TextToInt(textBoxQmin.Text);
        }
    }
}
