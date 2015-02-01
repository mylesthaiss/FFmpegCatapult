﻿// Main Windows Form logic methods for FFmpeg Catapult
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
    public partial class MainForm : Form
    {
        // Variables
        private String fileContainer;
        private String fileExtension;

        public MainForm()
        {
            InitializeComponent();
        }

        // Methods
        private void InitTabs()
        {
            // Picture tab
            if (Methods.IsPictureScalable())
            {
                tabPicture.Enabled = true;
            }
            else
            {
                tabPicture.Enabled = false;
            }

            // Video tab
            if (Methods.IsAudioFile())
            {
                tabVideo.Enabled = false;
            }
            else
            {
                tabVideo.Enabled = true;
            }
        }

        private void InitMain()
        {
            // Combo boxes
            comboBoxContainers.SelectedIndexChanged -= new EventHandler(comboBoxContainers_SelectedIndexChanged);
            for (int i = 0; i < File.Formats.GetLength(0); i++)
            {
                if (File.Formats[i, 1] == File.Format)
                {
                    comboBoxContainers.SelectedIndex = i;
                    fileContainer = File.Formats[i, 0];
                    fileExtension = File.Formats[i, 1];
                    break;
                }
            }
            comboBoxContainers.SelectedIndexChanged += new EventHandler(comboBoxContainers_SelectedIndexChanged);

            comboBoxThreads.SelectedIndexChanged -= new EventHandler(comboBoxThreads_SelectedIndexChanged);
            comboBoxThreads.SelectedIndex = Session.Threads;
            comboBoxThreads.SelectedIndexChanged += new EventHandler(comboBoxThreads_SelectedIndexChanged);

            // Text boxes
            if (textBoxOutFile.Text != "")
            {
                textBoxOutFile.TextChanged -= new EventHandler(textBoxOutFile_TextChanged);
                File.Output = textBoxOutFile.Text;
                textBoxOutFile.Text = File.Output;
                textBoxOutFile.TextChanged += new EventHandler(textBoxOutFile_TextChanged);
            }

            // Checkboxes
            checkBoxMultiThreading.CheckedChanged -= new EventHandler(checkBoxMultiThreading_CheckedChanged);
            checkBoxMultiThreading.Checked = Session.MultiThreading;
            comboBoxThreads.Enabled = Session.MultiThreading;
            checkBoxMultiThreading.CheckedChanged += new EventHandler(checkBoxMultiThreading_CheckedChanged);
        }

        private void InitPicture()
        {
            // Resolution radio buttons
            radioButtonKeepRes.CheckedChanged -= new EventHandler(radioButtonKeepRes_CheckedChanged);
            radioButtonHalfRes.CheckedChanged -= new EventHandler(radioButtonHalfRes_CheckedChanged);
            radioButtonCustomRes.CheckedChanged -= new EventHandler(radioButtonCustomRes_CheckedChanged);
            if (Screen.ScaleOption == 0)
            {
                radioButtonKeepRes.Checked = true;
                EnableResControls(false);
            }
            else if (Screen.ScaleOption == 1)
            {
                radioButtonCustomRes.Checked = true;
                EnableResControls(true);
            }
            else
            {
                radioButtonHalfRes.Checked = true;
                EnableResControls(false);
            }
            radioButtonKeepRes.CheckedChanged += new EventHandler(radioButtonKeepRes_CheckedChanged);
            radioButtonHalfRes.CheckedChanged += new EventHandler(radioButtonHalfRes_CheckedChanged);
            radioButtonCustomRes.CheckedChanged += new EventHandler(radioButtonCustomRes_CheckedChanged);

            // Check boxes
            checkBoxAspectRatio.CheckedChanged -= new EventHandler(checkBoxAspectRatio_CheckedChanged);
            checkBoxAspectRatio.Checked = Screen.AspectRatio;
            EnableRatioControls(Screen.AspectRatio);
            checkBoxAspectRatio.CheckedChanged += new EventHandler(checkBoxAspectRatio_CheckedChanged);

            checkBoxCrop.CheckedChanged += new EventHandler(checkBoxCrop_CheckedChanged);
            checkBoxCrop.Checked = Screen.CropVideo;
            EnableLayoutControls(Screen.CropVideo);
            checkBoxCrop.CheckedChanged += new EventHandler(checkBoxCrop_CheckedChanged);

            checkBoxDeinterlace.CheckedChanged -= new EventHandler(checkBoxDeinterlace_CheckedChanged);
            checkBoxDeinterlace.Checked = Screen.Deinterlace;
            checkBoxDeinterlace.CheckedChanged += new EventHandler(checkBoxDeinterlace_CheckedChanged);

            checkBoxPad.CheckedChanged -= new EventHandler(checkBoxPad_CheckedChanged);
            checkBoxPad.Checked = Screen.PadVideo;
            EnableLayoutControls(Screen.PadVideo);
            checkBoxPad.CheckedChanged += new EventHandler(checkBoxPad_CheckedChanged);

            // Text boxes
            textBoxWidth.TextChanged -= new EventHandler(textBoxWidth_TextChanged);
            textBoxWidth.Text = Methods.NumToText(Screen.Width);
            textBoxWidth.TextChanged += new EventHandler(textBoxWidth_TextChanged);

            textBoxHeight.TextChanged -= new EventHandler(textBoxHeight_TextChanged);
            textBoxHeight.Text = Methods.NumToText(Screen.Height);
            textBoxHeight.TextChanged += new EventHandler(textBoxHeight_TextChanged);

            textBoxRatioA.TextChanged -= new EventHandler(textBoxRatioA_TextChanged);
            textBoxRatioA.Text = Methods.NumToText(Screen.RatioA);
            textBoxRatioA.TextChanged += new EventHandler(textBoxRatioA_TextChanged);

            textBoxRatioB.TextChanged -= new EventHandler(textBoxRatioB_TextChanged);
            textBoxRatioB.Text = Methods.NumToText(Screen.RatioB);
            textBoxRatioB.TextChanged += new EventHandler(textBoxRatioB_TextChanged);

            textBoxFPS.TextChanged -= new EventHandler(textBoxFPS_TextChanged);
            textBoxFPS.Text = Methods.NumToText(Screen.FPS);
            textBoxFPS.TextChanged += new EventHandler(textBoxFPS_TextChanged);

            textBoxLayoutWidth.TextChanged -= new EventHandler(textBoxLayoutWidth_TextChanged);
            textBoxLayoutWidth.Text = Methods.NumToText(Screen.WinWidth);
            textBoxLayoutWidth.TextChanged += new EventHandler(textBoxLayoutWidth_TextChanged);

            textBoxLayoutHeight.TextChanged -= new EventHandler(textBoxLayoutHeight_TextChanged);
            textBoxLayoutHeight.Text = Methods.NumToText(Screen.WinHeight);
            textBoxLayoutHeight.TextChanged += new EventHandler(textBoxLayoutHeight_TextChanged);

            textBoxLayoutVert.TextChanged -= new EventHandler(textBoxLayoutVert_TextChanged);
            textBoxLayoutVert.Text = Methods.NumToText(Screen.X);
            textBoxLayoutVert.TextChanged += new EventHandler(textBoxLayoutVert_TextChanged);

            textBoxLayoutHoriz.TextChanged -= new EventHandler(textBoxLayoutHoriz_TextChanged);
            textBoxLayoutHoriz.Text = Methods.NumToText(Screen.Y);
            textBoxLayoutHoriz.TextChanged += new EventHandler(textBoxLayoutHoriz_TextChanged);

            // Set selected scaling method
            comboBoxScalingMethods.SelectedIndexChanged -= new EventHandler(comboBoxScalingMethods_SelectedIndexChanged);
            for (int i = 0; i < Screen.ScalingMethods.GetLength(0); i++)
            {
                if (Screen.ScalingMethod == Screen.ScalingMethods[i, 1])
                {
                    comboBoxScalingMethods.SelectedIndex = i;
                    break;
                }
            }
            comboBoxScalingMethods.SelectedIndexChanged += new EventHandler(comboBoxScalingMethods_SelectedIndexChanged);
        }

        private void InitVideo()
        {
            comboBoxVideoCodecs.Items.Clear();
            for (int i = 0; i < Video.Codecs.GetLength(0); i++)
            {
                comboBoxVideoCodecs.Items.Add(new ListComboContent(Video.Codecs[i, 0], Video.Codecs[i, 1]));
            }

            if (Video.Codec == "copy" | Video.Codec == "none")
            {
                EnableVideoControls(false);
            }
            else
            {
                EnableVideoControls(true);
            }

            // Combo boxes
            comboBoxVideoCodecs.SelectedIndexChanged -= new EventHandler(comboBoxVideoCodecs_SelectedIndexChanged);
            for (int i = 0; i < Video.Codecs.GetLength(0); i++)
            {
                if (Video.Codec == Video.Codecs[i, 1])
                {
                    comboBoxVideoCodecs.SelectedIndex = i;
                    break;
                }
            }
            comboBoxVideoCodecs.SelectedIndexChanged += new EventHandler(comboBoxVideoCodecs_SelectedIndexChanged);

            comboBoxVideoEncoders.SelectedIndexChanged -= new EventHandler(comboBoxVideoEncoders_SelectedIndexChanged);
            comboBoxVideoEncoders.Items.Clear();
            for (int i = 0; i < Video.Encoders.GetLength(0); i++)
            {
                comboBoxVideoEncoders.Items.Add(new ListComboContent(Video.Encoders[i, 0], Video.Encoders[i, 1]));

                if (Video.Encoder == Video.Encoders[i, 1])
                {
                    comboBoxVideoEncoders.SelectedIndex = i;
                }
            }
            comboBoxVideoEncoders.SelectedIndexChanged += new EventHandler(comboBoxVideoEncoders_SelectedIndexChanged);

            comboBoxBits.SelectedIndexChanged -= new EventHandler(comboBoxBits_SelectedIndexChanged);
            if (Video.Bits == "k")
            {
                comboBoxBits.SelectedIndex = 0;
            }
            else
            {
                comboBoxBits.SelectedIndex = 1;
            }
            labelMinBits.Text = comboBoxBits.Text;
            labelMaxBits.Text = comboBoxBits.Text;
            comboBoxBits.SelectedIndexChanged += new EventHandler(comboBoxBits_SelectedIndexChanged);

            comboBoxBytes.SelectedIndexChanged -= new EventHandler(comboBoxBytes_SelectedIndexChanged);
            if (Video.Bytes == "k")
            {
                comboBoxBytes.SelectedIndex = 0;
            }
            else if (Video.Bytes == "M")
            {
                comboBoxBytes.SelectedIndex = 1;
            }
            else
            {
                comboBoxBytes.SelectedIndex = 2;
            }
            comboBoxBytes.SelectedIndexChanged += new EventHandler(comboBoxBytes_SelectedIndexChanged);

            // Check boxes
            checkBoxTwoPassEncoding.CheckedChanged -= new EventHandler(checkBoxTwoPassEncoding_CheckedChanged);
            checkBoxTwoPassEncoding.Checked = Session.TwoPassEncoding;
            checkBoxTwoPassEncoding.CheckedChanged += new EventHandler(checkBoxTwoPassEncoding_CheckedChanged);

            checkBoxUseCRF.CheckedChanged -= new EventHandler(checkBoxUseCRF_CheckedChanged);
            checkBoxUseCRF.Checked = Video.UseCRF;
            EnableCRFControls(Video.UseCRF);
            checkBoxUseCRF.CheckedChanged += new EventHandler(checkBoxUseCRF_CheckedChanged);

            // Text boxes
            textBoxVideoBitrate.TextChanged -= new EventHandler(textBoxVideoBitrate_TextChanged);
            textBoxVideoBitrate.Text = Methods.NumToText(Video.Bitrate);
            textBoxVideoBitrate.TextChanged += new EventHandler(textBoxVideoBitrate_TextChanged);

            textBoxMinBitrate.TextChanged -= new EventHandler(textBoxMinBitrate_TextChanged);
            textBoxMinBitrate.Text = Methods.NumToText(Video.MinBitrate);
            textBoxMinBitrate.TextChanged += new EventHandler(textBoxMinBitrate_TextChanged);

            textBoxMaxBitrate.TextChanged -= new EventHandler(textBoxMaxBitrate_TextChanged);
            textBoxMaxBitrate.Text = Methods.NumToText(Video.MaxBitrate);
            textBoxMaxBitrate.TextChanged += new EventHandler(textBoxMaxBitrate_TextChanged);

            textBoxBufferSize.TextChanged -= new EventHandler(textBoxBufferSize_TextChanged);
            textBoxBufferSize.Text = Methods.NumToText(Video.BufferSize);
            textBoxBufferSize.TextChanged += new EventHandler(textBoxBufferSize_TextChanged);

            textBoxCRF.TextChanged -= new EventHandler(textBoxCRF_TextChanged);
            textBoxCRF.Text = Methods.NumToText(Video.CRF);
            textBoxCRF.TextChanged += new EventHandler(textBoxCRF_TextChanged);

            textBoxQmax.TextChanged -= new EventHandler(textBoxQmax_TextChanged);
            textBoxQmax.Text = Methods.NumToText(Video.Qmax);
            textBoxQmax.TextChanged += new EventHandler(textBoxQmax_TextChanged);

            textBoxQmin.TextChanged -= new EventHandler(textBoxQmin_TextChanged);
            textBoxQmin.Text = Methods.NumToText(Video.Qmin);
            textBoxQmin.TextChanged += new EventHandler(textBoxQmin_TextChanged);
        }

        private void InitAudio()
        {
            comboBoxAudioCodecs.Items.Clear();
            for (int i = 0; i < Audio.Codecs.GetLength(0); i++)
            {
                comboBoxAudioCodecs.Items.Add(new ListComboContent(Audio.Codecs[i, 0], Audio.Codecs[i, 1]));
            }

            if (Audio.Codec == "copy" | Audio.Codec == "none")
            {
                EnableAudioControls(false);

                if (Audio.Codec == "copy")
                {
                    groupBoxAudioStream.Enabled = true;
                }
                else
                {
                    groupBoxAudioStream.Enabled = false;
                }
            }
            else
            {
                EnableAudioControls(true);
                groupBoxAudioStream.Enabled = true;
            }

            // Combo boxes
            comboBoxAudioCodecs.SelectedIndexChanged -= new EventHandler(comboBoxAudioCodecs_SelectedIndexChanged);
            for (int i = 0; i < Audio.Codecs.GetLength(0); i++)
            {
                if (Audio.Codec == Audio.Codecs[i, 1])
                {
                    comboBoxAudioCodecs.SelectedIndex = i;
                }
            }
            comboBoxAudioCodecs.SelectedIndexChanged += new EventHandler(comboBoxAudioCodecs_SelectedIndexChanged);

            comboBoxAudioEncoders.SelectedIndexChanged -= new EventHandler(comboBoxAudioEncoders_SelectedIndexChanged);
            comboBoxAudioEncoders.Items.Clear();
            for (int i = 0; i < Audio.Encoders.GetLength(0); i++)
            {
                comboBoxAudioEncoders.Items.Add(new ListComboContent(Audio.Encoders[i, 0], Audio.Encoders[i, 1]));

                if (Audio.Encoder == Audio.Encoders[i, 1])
                {
                    comboBoxAudioEncoders.SelectedIndex = i;
                }
            }
            comboBoxAudioEncoders.SelectedIndexChanged += new EventHandler(comboBoxAudioEncoders_SelectedIndexChanged);

            comboBoxSampleRates.SelectedIndexChanged -= new EventHandler(comboBoxSampleRates_SelectedIndexChanged);
            comboBoxSampleRates.Items.Clear();

            for (int i = 0; i < Audio.SampleRates.GetLength(0); i++)
            {
                comboBoxSampleRates.Items.Add(new ListComboContent(Convert.ToString(Audio.SampleRates[i]) + " Hz", Audio.SampleRates[i]));
            }
            comboBoxSampleRates.Items.Add(new ListComboContent("", 0));

            if (Audio.SampleRate != 0)
            {
                for (int i = 0; i < Audio.SampleRates.GetLength(0); i++)
                {
                    if (Audio.SampleRate == Audio.SampleRates[i])
                    {
                        comboBoxSampleRates.SelectedIndex = i;
                        break;
                    }
                }
            }

            comboBoxSampleRates.SelectedIndexChanged += new EventHandler(comboBoxSampleRates_SelectedIndexChanged);

            comboBoxChannels.SelectedIndexChanged -= new EventHandler(comboBoxChannels_SelectedIndexChanged);
            comboBoxChannels.Items.Clear();

            for (int i = 1; i <= Audio.MaxChannels; i++)
            {
                comboBoxChannels.Items.Add(new ListComboContent(Convert.ToString(i), i));
            }
            comboBoxChannels.Items.Add(new ListComboContent("", 0));

            if (Audio.Channels != 0)
            {
                comboBoxChannels.SelectedIndex = Audio.Channels - 1;
            }
            comboBoxChannels.SelectedIndexChanged += new EventHandler(comboBoxChannels_SelectedIndexChanged);

            // Other items
            InitAudioEncPropertiesButton();
            InitAudioBitrates();
        }

        private void InitAudioEncPropertiesButton()
        {
            if (Audio.Encoder == "libfdk_aac")
            {
                buttonAudioCodecProperties.Enabled = true;
            }
            else
            {
                buttonAudioCodecProperties.Enabled = false;
            }
        }

        private void InitAudioBitrates()
        {
            // Check boxes
            checkBoxUseAudioVBR.CheckedChanged -= new EventHandler(checkBoxUseAudioVBR_CheckedChanged);
            checkBoxUseAudioVBR.Visible = Audio.VBRSupported;
            checkBoxUseAudioVBR.Checked = Audio.UseVBR;
            checkBoxUseAudioVBR.CheckedChanged += new EventHandler(checkBoxUseAudioVBR_CheckedChanged);

            // Combo boxes
            comboBoxAudioBitrates.SelectedIndexChanged -= new EventHandler(comboBoxAudioBitrates_SelectedIndexChanged);
            comboBoxAudioBitrates.Items.Clear();

            if (Audio.UseVBR == true)
            {
                // VBR modes
                labelAudioBitrate.Text = "Quality:";

                for (int i = 0; i < Audio.VBRModes.GetLength(0); i++)
                {
                    comboBoxAudioBitrates.Items.Add(new ListComboContent(Convert.ToString(Audio.VBRModes[i]), Audio.VBRModes[i]));
                }
                for (int i = 0; i < Audio.VBRModes.GetLength(0); i++)
                {
                    if (Audio.Quality == Audio.VBRModes[i])
                    {
                        comboBoxAudioBitrates.SelectedIndex = i;
                        break;
                    }
                }
            }
            else
            {
                // ABR and CBR bitrates
                labelAudioBitrate.Text = "Bitrate:";

                for (int i = 0; i < Audio.Bitrates.GetLength(0); i++)
                {
                    comboBoxAudioBitrates.Items.Add(new ListComboContent(Convert.ToString(Audio.Bitrates[i]) + " Kbps", Audio.Bitrates[i]));
                }
                for (int i = 0; i < Audio.Bitrates.GetLength(0); i++)
                {
                    if (Audio.Bitrate == Audio.Bitrates[i])
                    {
                        comboBoxAudioBitrates.SelectedIndex = i;
                        break;
                    }
                }
            }

            comboBoxAudioBitrates.SelectedIndexChanged += new EventHandler(comboBoxAudioBitrates_SelectedIndexChanged);
        }

        private void InitMetadata()
        {
            if (File.Format == "raw" | File.Format == "mpg")
            {
                EnableTaggingControls(false);
            }
            else
            {
                EnableTaggingControls(true);

                switch (File.Format)
                {
                    case "avi":
                        EnableAlbumTagging(true);
                        EnableAlbumArtistTagging(false);
                        EnableArtistTagging(true);
                        EnableCommentTagging(true);
                        EnableDiscTagging(false);
                        EnableGenreTaggin(true);
                        EnablePublisherTagging(false);
                        EnableTitleTagging(true);
                        EnableTrackTagging(true);
                        EnableYearTagging(false);
                        break;
                    case "mkv":
                    case "ts":
                        EnableAlbumTagging(false);
                        EnableAlbumArtistTagging(false);
                        EnableArtistTagging(false);
                        EnableCommentTagging(false);
                        EnableDiscTagging(false);
                        EnableGenreTaggin(false);
                        EnablePublisherTagging(false);
                        EnableTitleTagging(true);
                        EnableTrackTagging(false);
                        EnableYearTagging(false);
                        break;
                    case "wmv":
                        EnableAlbumTagging(false);
                        EnableAlbumArtistTagging(false);
                        EnableArtistTagging(false);
                        EnableCommentTagging(true);
                        EnableDiscTagging(false);
                        EnableGenreTaggin(false);
                        EnablePublisherTagging(false);
                        EnableTitleTagging(true);
                        EnableTrackTagging(false);
                        EnableYearTagging(false);
                        break;
                    default:
                        EnableAlbumTagging(true);
                        EnableAlbumArtistTagging(true);
                        EnableArtistTagging(true);
                        EnableCommentTagging(true);
                        EnableDiscTagging(true);
                        EnableGenreTaggin(true);
                        EnablePublisherTagging(true);
                        EnableTitleTagging(true);
                        EnableTrackTagging(true);
                        EnableYearTagging(true);
                        break;
                }
            }
        }

        // Misc methods
        private void ExitFFmpegCatapult()
        {
            if (Session.SaveProperties == true)
            {
                Session.SaveSettings();
            }
            System.Environment.Exit(0);
        }

        private void EnableRatioControls(bool enable)
        {
            labelRatio.Enabled = enable;
            textBoxRatioA.Enabled = enable;
            labelRatioDash.Enabled = enable;
            textBoxRatioB.Enabled = enable;
        }

        private void EnableLayoutControls(bool enable)
        {
            labelLayoutColour.Enabled = enable;
            labelLayoutHeight.Enabled = enable;
            labelLayoutWidth.Enabled = enable;
            labelHoriz.Enabled = enable;
            labelVert.Enabled = enable;
            textBoxLayoutColour.Enabled = enable;
            textBoxLayoutHeight.Enabled = enable;
            textBoxLayoutHoriz.Enabled = enable;
            textBoxLayoutVert.Enabled = enable;
            textBoxLayoutWidth.Enabled = enable;
        }

        private void EnableResControls(bool enable)
        {
            textBoxHeight.Enabled = enable;
            textBoxWidth.Enabled = enable;
        }

        private void EnableCRFControls(bool enable)
        {
            if (enable == true)
            {
                comboBoxBits.Enabled = false;
                labelVideoBitrate.Enabled = false;
                labelMaxBits.Enabled = false;
                labelMaxBitrate.Enabled = false;
                labelMinBits.Enabled = false;
                labelMinBitrate.Enabled = false;
                labelCRF.Enabled = true;
                textBoxVideoBitrate.Enabled = false;
                textBoxMaxBitrate.Enabled = false;
                textBoxMinBitrate.Enabled = false;
                textBoxCRF.Enabled = true;
            }
            else
            {
                comboBoxBits.Enabled = true;
                labelVideoBitrate.Enabled = true;
                labelMaxBits.Enabled = true;
                labelMaxBitrate.Enabled = true;
                labelMinBits.Enabled = true;
                labelMinBitrate.Enabled = true;
                labelCRF.Enabled = false;
                textBoxVideoBitrate.Enabled = true;
                textBoxMaxBitrate.Enabled = true;
                textBoxMinBitrate.Enabled = true;
                textBoxCRF.Enabled = false;
            }
        }

        private void EnableVideoControls(bool enable)
        {
            checkBoxTwoPassEncoding.Enabled = enable;
            groupBoxVideoBitrate.Enabled = enable;
            groupBoxVideoEncoder.Enabled = enable;
        }

        private void EnableAudioControls(bool enable)
        {
            if (enable == true && Audio.Codec == "copy" || Audio.Codec == "pcm")
            {
                groupBoxAudioBitrate.Enabled = false;
            }
            else
            {
                groupBoxAudioBitrate.Enabled = enable;
            }

            groupBoxAudioEncoder.Enabled = enable;
            groupBoxAudioOutput.Enabled = enable;
        }

        private void EnableTaggingControls(bool enable)
        {
            groupBoxGeneralTags.Enabled = enable;
            groupBoxTrackTags.Enabled = enable;
            groupBoxMiscTags.Enabled = enable;

            if (enable == false)
            {
                ClearMetadataFields();
            }
        }

        private void EnableAlbumTagging(bool enable)
        {
            labelAlbum.Enabled = enable;
            textBoxAlbum.Enabled = enable;

            if (enable == false)
            {
                textBoxAlbum.Text = "";
            }
        }

        private void EnableAlbumArtistTagging(bool enable)
        {
            labelAlbumArtist.Enabled = enable;
            textBoxAlbumArtist.Enabled = enable;

            if (enable == false)
            {
                textBoxAlbumArtist.Text = "";
            }
        }

        private void EnableArtistTagging(bool enable)
        {
            labelArtist.Enabled = enable;
            textBoxArtist.Enabled = enable;

            if (enable == false)
            {
                textBoxArtist.Text = "";
            }
        }

        private void EnableCommentTagging(bool enable)
        {
            labelComment.Enabled = enable;
            textBoxComment.Enabled = enable;

            if (enable == false)
            {
                textBoxComment.Text = "";
            }
        }

        private void EnableDiscTagging(bool enable)
        {
            labelDisc.Enabled = enable;
            labelOfDiscs.Enabled = enable;
            textBoxDisc.Enabled = enable;
            textBoxTotalDiscs.Enabled = enable;

            if (enable == false)
            {
                textBoxDisc.Text = "";
                textBoxTotalDiscs.Text = "";
            }
        }

        private void EnableGenreTaggin(bool enable)
        {
            labelGenre.Enabled = enable;
            textBoxGenre.Enabled = enable;

            if (enable == false)
            {
                textBoxGenre.Text = "";
            }
        }

        private void EnablePublisherTagging(bool enable)
        {
            labelPublisher.Enabled = enable;
            textBoxPublisher.Enabled = enable;

            if (enable == false)
            {
                textBoxPublisher.Text = "";
            }
        }

        private void EnableTitleTagging(bool enable)
        {
            labelTitle.Enabled = enable;
            textBoxTitle.Enabled = enable;

            if (enable == false)
            {
                textBoxTitle.Text = "";
            }
        }

        private void EnableTrackTagging(bool enable)
        {
            labelTrack.Enabled = enable;
            labelOfTrack.Enabled = enable;
            textBoxTrack.Enabled = enable;
            textBoxTotalTracks.Enabled = enable;

            if (enable == false)
            {
                textBoxTrack.Text = "";
                textBoxTotalTracks.Text = "";
            }
        }

        private void EnableYearTagging(bool enable)
        {
            labelYear.Enabled = enable;
            textBoxYear.Enabled = enable;

            if (enable == false)
            {
                textBoxYear.Text = "";
            }
        }

        private void EnableLogFileTextBox(bool enable)
        {
            labelLogName.Enabled = enable;
            textBoxLog.Enabled = enable;
        }

        private void ClearMetadataFields()
        {
            textBoxAlbum.Text = "";
            textBoxAlbumArtist.Text = "";
            textBoxArtist.Text = "";
            textBoxComment.Text = "";
            textBoxDisc.Text = "";
            textBoxGenre.Text = "";
            textBoxPublisher.Text = "";
            textBoxTitle.Text = "";
            textBoxTotalDiscs.Text = "";
            textBoxTotalTracks.Text = "";
            textBoxTrack.Text = "";
            textBoxYear.Text = "";
        }

        // Combobox list helper
        private class ListComboContent
        {
            private string name;
            private string value;
            private int x;

            public ListComboContent(string label, string arg)
            {
                name = label;
                value = arg;
            }
            
            public ListComboContent(string label, int y)
            {
                name = label;
                x = y;
            }

            public int X
            {
                get { return x; }
            }

            public string Value
            {
                get { return value; }
            }

            public string Name
            {
                get { return name; }
            }

            public override string ToString()
            {
                return name;
            }
        }
    }
}