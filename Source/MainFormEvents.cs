﻿// Main Windows Form event handlers for FFmpeg Catapult.
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
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitTabs();

            // Main tab
            if (File.Input != null)
            {
                textBoxInFile.Text = File.Input;
                buttonBrowseInput.Enabled = true;
            }
            textBoxInFile.DragDrop += new DragEventHandler(textBoxInFile_DragDrop);
            textBoxInFile.DragEnter += new DragEventHandler(textBoxInFile_DragEnter);
            textBoxInFile.TextChanged += new EventHandler(textBoxInFile_TextChanged);
            buttonBrowseInput.Click += new EventHandler(buttonBrowseInput_Click);

            if (File.Output != null)
            {
                textBoxOutFile.Text = File.Output;
            }
            textBoxOutFile.TextChanged += new EventHandler(textBoxOutFile_TextChanged);
            buttonBrowseOutput.Click += new EventHandler(buttonBrowseOutput_Click);

            for (int i = 0; i < File.Formats.GetLength(0); i++)
            {
                comboBoxContainers.Items.Add(new ListComboContent(File.Formats[i, 0], File.Formats[i, 1]));
            }

            for (int i = 0; i < Preset.GetPresets().GetLength(0); i++)
            {
                comboBoxPresets.Items.Add(new ListComboContent(Preset.GetPresets()[i, 0], Preset.GetPresets()[i, 1]));
            }
            for (int i = 0; i < Preset.GetPresets().GetLength(0); i++)
            {
                if (Session.Preset == Preset.GetPresets()[i, 1])
                {
                    comboBoxPresets.SelectedIndex = i;
                    break;
                }
            }
            comboBoxPresets.SelectedIndexChanged += new EventHandler(comboBoxPresets_SelectedIndexChanged);

            comboBoxThreads.Items.Add(new ListComboIntContent("Auto", 0));
            for (int i = 1; i <= Session.MaxThreads; i++)
            {
                comboBoxThreads.Items.Add(new ListComboIntContent(Convert.ToString(i), i));
            }

            if (Session.KeepValues == true)
            {
                radioButtonKeep.Checked = true;
            }
            else
            {
                radioButtonRefresh.Checked = true;
            }
            radioButtonKeep.CheckedChanged += new EventHandler(radioButtonKeep_CheckedChanged);
            radioButtonRefresh.CheckedChanged += new EventHandler(radioButtonRefresh_CheckedChanged);

            InitMain();

            checkBoxOverwrite.Checked = Session.Overwrite;
            checkBoxOverwrite.CheckedChanged += new EventHandler(checkBoxOverwrite_CheckedChanged);

            this.FormClosing += MainForm_Closing;
            buttonExit.Click += new EventHandler(buttonExit_Click);
            buttonRun.Click += new EventHandler(buttonRun_Click);

            // Streams
            textBoxAudioStream.TextChanged += new EventHandler(textBoxAudioStream_TextChanged);
            buttonBrowseAudioStream.Click += new EventHandler(buttonBrowseAudioStream_Click);

            // Picture tab
            for (int i = 0; i < Screen.ScalingMethods.GetLength(0); i++)
            {
                comboBoxScalingMethods.Items.Add(new ListComboContent(Screen.ScalingMethods[i, 0], Screen.ScalingMethods[i, 1]));
            }

            InitPicture();

            // Video tab
            comboBoxBits.Items.Add(new ListComboContent("Kbps", "k"));
            comboBoxBits.Items.Add(new ListComboContent("Mbps", "M"));
            comboBoxBytes.Items.Add(new ListComboContent("KB", "k"));
            comboBoxBytes.Items.Add(new ListComboContent("MB", "M"));
            comboBoxBytes.Items.Add(new ListComboContent("GB", "G"));

            buttonVideoCodecProperties.Click += new EventHandler(buttonVideoCodecProperties_Clicked);

            InitVideo();

            // Audio tab
            buttonAudioCodecProperties.Click += new EventHandler(buttonAudioCodecProperties_Clicked);

            InitAudio();

            // Options           
            if (Bin.FFmpegBin != null)
            {
                textBoxFFmpegBin.Text = Bin.FFmpegBin;
            }
            textBoxFFmpegBin.TextChanged += new EventHandler(textBoxFFmpegBin_TextChanged);
            buttonBrowseFFmpegBin.Click += new EventHandler(buttonBrowseFFmpegBin_Click);

            if (Bin.TermBin != null)
            {
                textBoxTermBin.Text = Bin.TermBin;
            }
            textBoxTermBin.TextChanged += new EventHandler(textBoxTermBin_TextChanged);
            buttonBrowseTermBin.Click += new EventHandler(buttonBrowseTermBin_Click);

            if (Bin.TermArgs != null)
            {
                textBoxTermArgs.Text = Bin.TermArgs;
            }
            textBoxTermArgs.TextChanged += new EventHandler(textBoxTermArgs_TextChanged);

            checkBoxWriteLog.Checked = Session.WriteLog;
            checkBoxWriteLog.CheckedChanged += new EventHandler(checkBoxWriteLog_CheckedChanged);
            EnableLogFileTextBox(Session.WriteLog);
            textBoxLog.Text = File.Log;
            textBoxLog.TextChanged += new EventHandler(textBoxLog_TextChanged);
            checkBoxSaveSettings.Checked = Session.SaveProperties;
            checkBoxSaveSettings.CheckedChanged += new EventHandler(checkBoxSaveSettings_CheckedChanged);

            // Metadata tab
            textBoxAlbum.TextChanged += new EventHandler(textBoxAlbum_TextChanged);
            textBoxAlbumArtist.TextChanged += new EventHandler(textBoxAlbumArtist_TextChanged);
            textBoxArtist.TextChanged += new EventHandler(textBoxArtist_TextChanged);
            textBoxComment.TextChanged += new EventHandler(textBoxComment_TextChanged);
            textBoxDisc.TextChanged += new EventHandler(textBoxDisc_TextChanged);
            textBoxGenre.TextChanged += new EventHandler(textBoxGenre_TextChanged);
            textBoxTitle.TextChanged += new EventHandler(textBoxTitle_TextChanged);
            textBoxTotalDiscs.TextChanged += new EventHandler(textBoxTotalDiscs_TextChanged);
            textBoxTotalTracks.TextChanged += new EventHandler(textBoxTotalTracks_TextChanged);
            textBoxTrack.TextChanged += new EventHandler(textBoxTrack_TextChanged);
            textBoxTrack.TextChanged += new EventHandler(textBoxTrack_TextChanged);
            textBoxYear.TextChanged += new EventHandler(textBoxYear_TextChanged);

            InitMetadata();
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            ExitFFmpegCatapult();
        }

        void buttonExit_Click(object sender, EventArgs e)
        {
            ExitFFmpegCatapult();
        }

        void buttonRun_Click(object sender, EventArgs e)
        {
            Bin.Run();

            if (Session.KeepValues == false)
            {
                textBoxInFile.Text = "";
                textBoxOutFile.Text = "";
                ClearMetadataFields();
            }
        }

        // Key press event handler for numbered values
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void textBoxBitrate_KeyPressDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (e.KeyChar != '.' | Video.Bits == "k")
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }
            }
        }

        private void textBoxBufferSize_KeyPressDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (e.KeyChar != '.' | Video.Bytes == "k")
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }
            }
        }
    }
}
