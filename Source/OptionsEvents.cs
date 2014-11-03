﻿// Options tab event handlers for FFmpeg Catapult.
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
        void textBoxFFmpegBin_TextChanged(object sender, EventArgs e)
        {
            Bin.FFmpegBin = textBoxFFmpegBin.Text;
        }

        void textBoxTermBin_TextChanged(object sender, EventArgs e)
        {
            Bin.TermBin = textBoxTermBin.Text;
        }

        void textBoxTermArgs_TextChanged(object sender, EventArgs e)
        {
            Bin.TermArgs = textBoxTermArgs.Text;
        }

        void textBoxLog_TextChanged(object sender, EventArgs e)
        {
            File.Log = textBoxLog.Text;
        }

        void buttonBrowseFFmpegBin_Click(object sender, EventArgs e)
        {
            OpenFileDialog binFile = new OpenFileDialog();
            binFile.Filter = "Executable (*.exe) | *.exe | Any file (*.*) | *.*";
            binFile.ShowDialog();

            if (binFile.FileName != "")
            {
                textBoxFFmpegBin.Text = binFile.FileName;
            }
        }

        void checkBoxWriteLog_CheckedChanged(object sender, EventArgs e)
        {
            Session.WriteLog = checkBoxWriteLog.Checked;
            EnableLogFileTextBox(Session.WriteLog);
        }

        void checkBoxSaveSettings_CheckedChanged(object sender, EventArgs e)
        {
            Session.SaveProperties = checkBoxSaveSettings.Checked;
            Properties.Settings.Default.SaveSettings = Session.SaveProperties;
            Properties.Settings.Default.Save();
        }

        void buttonBrowseTermBin_Click(object sender, EventArgs e)
        {
            OpenFileDialog termBinFile = new OpenFileDialog();
            termBinFile.Filter = "Executable (*.exe) | *.exe | Any file (*.*) | *.*";
            termBinFile.ShowDialog();

            if (termBinFile.FileName != "")
            {
                textBoxTermBin.Text = termBinFile.FileName;
            }
        }
    }
}
