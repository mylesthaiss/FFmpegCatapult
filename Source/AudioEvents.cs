﻿// Audio tab event handlers for FFmpeg Catapult.
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
        void buttonAudioCodecProperties_Clicked(object sender, EventArgs e)
        {
            AudioSettingsForm audioProperties = new AudioSettingsForm();
            audioProperties.StartPosition = FormStartPosition.CenterParent;
            audioProperties.ShowDialog(this);
        }

        void comboBoxAudioCodecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListComboContent codec = (ListComboContent)comboBoxAudioCodecs.SelectedItem;
            if (codec.Value != Audio.Codec)
            {
                Audio.Codec = codec.Value;
                InitAudio();
            }
        }

        void comboBoxAudioEncoders_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListComboContent encoder = (ListComboContent)comboBoxAudioEncoders.SelectedItem;
            if (encoder.Value != Audio.Encoder)
            {
                Audio.Encoder = encoder.Value;
                InitAudioEncPropertiesButton();
                InitAudioBitrates();
            }
        }

        void comboBoxSampleRates_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListComboContent sampleRate = (ListComboContent)comboBoxSampleRates.SelectedItem;
            if (sampleRate.X != Audio.SampleRate)
            {
                Audio.SampleRate = sampleRate.X;
                InitAudioBitrates();
            }
        }

        void comboBoxChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListComboContent channels = (ListComboContent)comboBoxChannels.SelectedItem;
            if (channels.X != Audio.Channels)
            {
                Audio.Channels = channels.X;
            }
        }

        void checkBoxUseAudioVBR_CheckedChanged(object sender, EventArgs e)
        {
            Audio.UseVBR = checkBoxUseAudioVBR.Checked;
            InitAudioBitrates();
        }

        void comboBoxAudioBitrates_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListComboContent bitrate = (ListComboContent)comboBoxAudioBitrates.SelectedItem;

            if (Audio.UseVBR == true)
            {
                Audio.Quality = bitrate.X;
            }
            else
            {
                Audio.Bitrate = bitrate.X;
            }
        }

        void buttonBrowseAudioStream_Click(object sender, EventArgs e)
        {
            OpenFileDialog audioFile = new OpenFileDialog();
            audioFile.ShowDialog();

            if (audioFile.FileName != "")
            {
                textBoxAudioStream.Text = audioFile.FileName;
            }
        }

        void textBoxAudioStream_TextChanged(object sender, EventArgs e)
        {
            File.AudioStream = textBoxAudioStream.Text;
        }
    }
}
