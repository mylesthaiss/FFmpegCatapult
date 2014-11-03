﻿// Main tab event handlers for FFmpeg Catapult.
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
        private void textBoxInFile_TextChanged(object sender, EventArgs e)
        {
            File.Input = textBoxInFile.Text;

            if (textBoxInFile.Text != "" && textBoxOutFile.Text != "")
            {
                buttonRun.Enabled = true;
            }
            else
            {
                buttonRun.Enabled = false;
            }
        }

        private void textBoxOutFile_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOutFile.Text != "")
            {
                File.Output = textBoxOutFile.Text;
                textBoxOutFile.Text = File.Output;
            }
            else
            {
                File.Output = "";
            }

            if (textBoxInFile.Text != "" && textBoxOutFile.Text != "")
            {
                buttonRun.Enabled = true;
            }
            else
            {
                buttonRun.Enabled = false;
            }
        }

        private void buttonBrowseInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog inFile = new OpenFileDialog();
            inFile.ShowDialog();
            inFile.Filter = "Any file (*.*) | *.*";

            if (inFile.FileName != "")
            {
                textBoxInFile.Text = inFile.FileName;
                textBoxOutFile.Text = inFile.FileName;
            }
        }

        private void buttonBrowseOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog outFile = new SaveFileDialog();
            if (fileExtension == "custom")
            {
                outFile.Filter = "Any file *.* | *.*";
            }
            else
            {
                outFile.Filter = String.Format("{0} (*.{1}) | *.{1}", fileContainer, fileExtension);
            }
            outFile.ShowDialog();

            if (outFile.FileName != "")
            {
                textBoxOutFile.Text = outFile.FileName;
            }
        }

        void textBoxInFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        void textBoxInFile_DragDrop(object sender, DragEventArgs e)
        {
            String[] file = (String[])e.Data.GetData(DataFormats.FileDrop);
            if (file != null && file.Length != 0)
            {
                textBoxInFile.Text = file[0];
                textBoxOutFile.Text = file[0];
            }
        }

        void checkBoxOverwrite_CheckedChanged(object sender, EventArgs e)
        {
            Session.Overwrite = checkBoxOverwrite.Checked;
        }

        void checkBoxMultiThreading_CheckedChanged(object sender, EventArgs e)
        {
            Session.MultiThreading = checkBoxMultiThreading.Checked;
            comboBoxThreads.Enabled = Session.MultiThreading;
        }

        void comboBoxContainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListComboContent format = (ListComboContent)comboBoxContainers.SelectedItem;

            if (format.Value != File.Format)
            {
                File.Format = format.Value;
                fileContainer = format.Name;
                fileExtension = format.Value;

                if (textBoxOutFile.Text != "" && File.Format != "custom")
                {
                    textBoxOutFile.TextChanged -= new EventHandler(textBoxOutFile_TextChanged);
                    File.Output = textBoxOutFile.Text;
                    textBoxOutFile.Text = File.Output;
                    textBoxOutFile.TextChanged += new EventHandler(textBoxOutFile_TextChanged);
                }
            }

            InitTabs();
            InitAudio();
            InitVideo();
            InitMetadata();
        }

        void comboBoxPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListComboContent preset = (ListComboContent)comboBoxPresets.SelectedItem;
            Session.Preset = preset.Value;
            Preset.InitPreset();
            InitTabs();
            InitMain();
            InitPicture();
            InitVideo();
            InitAudio();
            InitMetadata();
        }

        void comboBoxThreads_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListComboIntContent threads = (ListComboIntContent)comboBoxThreads.SelectedItem;
            Session.Threads = threads.Value;
        }

        void radioButtonKeep_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKeep.Checked == true)
            {
                Session.KeepValues = true;
            }
        }

        void radioButtonRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRefresh.Checked == true)
            {
                Session.KeepValues = false;
            }
        }
    }
}
