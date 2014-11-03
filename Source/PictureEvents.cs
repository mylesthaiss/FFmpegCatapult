﻿// Picture tab event handlers for FFmpeg Catapult.
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
        void radioButtonKeepRes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKeepRes.Checked == true)
            {
                Screen.ScaleOption = 0;
                EnableResControls(false);
            }
        }

        void radioButtonCustomRes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCustomRes.Checked == true)
            {
                Screen.ScaleOption = 1;
                EnableResControls(true);
            }
        }

        void radioButtonHalfRes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHalfRes.Checked == true)
            {
                Screen.ScaleOption = 2;
                EnableResControls(false);
            }
        }

        void checkBoxAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            Screen.AspectRatio = checkBoxAspectRatio.Checked;
            EnableRatioControls(Screen.AspectRatio);
        }

        void checkBoxCrop_CheckedChanged(object sender, EventArgs e)
        {
            Screen.CropVideo = checkBoxCrop.Checked;
            EnableLayoutControls(Screen.CropVideo);
        }

        void checkBoxDeinterlace_CheckedChanged(object sender, EventArgs e)
        {
            Screen.Deinterlace = checkBoxDeinterlace.Checked;
        }

        void checkBoxPad_CheckedChanged(object sender, EventArgs e)
        {
            Screen.PadVideo = checkBoxPad.Checked;
            EnableLayoutControls(Screen.PadVideo);
        }

        void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            Screen.Width = Methods.TextToInt(textBoxWidth.Text);
        }

        void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            Screen.Height = Methods.TextToInt(textBoxHeight.Text);
        }

        void textBoxRatioA_TextChanged(object sender, EventArgs e)
        {
            Screen.RatioA = Methods.TextToInt(textBoxRatioA.Text);
        }

        void textBoxRatioB_TextChanged(object sender, EventArgs e)
        {
            Screen.RatioB = Methods.TextToInt(textBoxRatioB.Text);
        }

        void textBoxFPS_TextChanged(object sender, EventArgs e)
        {
            Screen.FPS = Methods.TextToInt(textBoxFPS.Text);
        }

        void textBoxLayoutWidth_TextChanged(object sender, EventArgs e)
        {
            Screen.WinWidth = Methods.TextToInt(textBoxLayoutWidth.Text);
        }

        void textBoxLayoutHeight_TextChanged(object sender, EventArgs e)
        {
            Screen.WinHeight = Methods.TextToInt(textBoxLayoutHeight.Text);
        }

        void textBoxLayoutVert_TextChanged(object sender, EventArgs e)
        {
            Screen.X = Methods.TextToInt(textBoxLayoutVert.Text);
        }

        void textBoxLayoutHoriz_TextChanged(object sender, EventArgs e)
        {
            Screen.Y = Methods.TextToInt(textBoxLayoutHoriz.Text);
        }

        void comboBoxScalingMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListComboContent scalingMethod = (ListComboContent)comboBoxScalingMethods.SelectedItem;
            Screen.ScalingMethod = scalingMethod.Value;
        }
    }
}
