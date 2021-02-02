﻿// Main Windows Form logic methods for FFmpeg Catapult

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
using System.IO;
using System.Xml;

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
            comboBoxContainers.SelectedIndexChanged -= new EventHandler(ComboBoxContainers_SelectedIndexChanged);
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
            comboBoxContainers.SelectedIndexChanged += new EventHandler(ComboBoxContainers_SelectedIndexChanged);

            comboBoxThreads.SelectedIndexChanged -= new EventHandler(ComboBoxThreads_SelectedIndexChanged);
            comboBoxThreads.SelectedIndex = Session.Threads;
            comboBoxThreads.SelectedIndexChanged += new EventHandler(ComboBoxThreads_SelectedIndexChanged);

            // Text boxes
            if (textBoxOutFile.Text != "")
            {
                textBoxOutFile.TextChanged -= new EventHandler(TextBoxOutFile_TextChanged);
                File.Output = textBoxOutFile.Text;
                textBoxOutFile.Text = File.Output;
                textBoxOutFile.TextChanged += new EventHandler(TextBoxOutFile_TextChanged);
            }

            // Checkboxes
            checkBoxMultiThreading.CheckedChanged -= new EventHandler(CheckBoxMultiThreading_CheckedChanged);
            checkBoxMultiThreading.Checked = Session.MultiThreading;
            comboBoxThreads.Enabled = Session.MultiThreading;
            checkBoxMultiThreading.CheckedChanged += new EventHandler(CheckBoxMultiThreading_CheckedChanged);
        }

        private void InitPicture()
        {
            // Resolution radio buttons
            radioButtonKeepRes.CheckedChanged -= new EventHandler(RadioButtonKeepRes_CheckedChanged);
            radioButtonHalfRes.CheckedChanged -= new EventHandler(RadioButtonHalfRes_CheckedChanged);
            radioButtonCustomRes.CheckedChanged -= new EventHandler(RadioButtonCustomRes_CheckedChanged);
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
            radioButtonKeepRes.CheckedChanged += new EventHandler(RadioButtonKeepRes_CheckedChanged);
            radioButtonHalfRes.CheckedChanged += new EventHandler(RadioButtonHalfRes_CheckedChanged);
            radioButtonCustomRes.CheckedChanged += new EventHandler(RadioButtonCustomRes_CheckedChanged);

            // Check boxes
            checkBoxAspectRatio.CheckedChanged -= new EventHandler(CheckBoxAspectRatio_CheckedChanged);
            checkBoxAspectRatio.Checked = Screen.AspectRatio;
            EnableRatioControls(Screen.AspectRatio);
            checkBoxAspectRatio.CheckedChanged += new EventHandler(CheckBoxAspectRatio_CheckedChanged);

            checkBoxCrop.CheckedChanged += new EventHandler(CheckBoxCrop_CheckedChanged);
            checkBoxCrop.Checked = Screen.CropVideo;
            EnableLayoutControls(Screen.CropVideo);
            checkBoxCrop.CheckedChanged += new EventHandler(CheckBoxCrop_CheckedChanged);

            checkBoxDeinterlace.CheckedChanged -= new EventHandler(CheckBoxDeinterlace_CheckedChanged);
            checkBoxDeinterlace.Checked = Screen.Deinterlace;
            checkBoxDeinterlace.CheckedChanged += new EventHandler(CheckBoxDeinterlace_CheckedChanged);

            checkBoxPad.CheckedChanged -= new EventHandler(CheckBoxPad_CheckedChanged);
            checkBoxPad.Checked = Screen.PadVideo;
            EnableLayoutControls(Screen.PadVideo);
            checkBoxPad.CheckedChanged += new EventHandler(CheckBoxPad_CheckedChanged);

            // Text boxes
            textBoxWidth.TextChanged -= new EventHandler(TextBoxWidth_TextChanged);
            textBoxWidth.Text = Methods.NumToText(Screen.Width);
            textBoxWidth.TextChanged += new EventHandler(TextBoxWidth_TextChanged);

            textBoxHeight.TextChanged -= new EventHandler(TextBoxHeight_TextChanged);
            textBoxHeight.Text = Methods.NumToText(Screen.Height);
            textBoxHeight.TextChanged += new EventHandler(TextBoxHeight_TextChanged);

            textBoxRatioA.TextChanged -= new EventHandler(TextBoxRatioA_TextChanged);
            textBoxRatioA.Text = Methods.NumToText(Screen.RatioA);
            textBoxRatioA.TextChanged += new EventHandler(TextBoxRatioA_TextChanged);

            textBoxRatioB.TextChanged -= new EventHandler(TextBoxRatioB_TextChanged);
            textBoxRatioB.Text = Methods.NumToText(Screen.RatioB);
            textBoxRatioB.TextChanged += new EventHandler(TextBoxRatioB_TextChanged);

            textBoxFPS.TextChanged -= new EventHandler(TextBoxFPS_TextChanged);
            textBoxFPS.Text = Methods.NumToText(Screen.FPS);
            textBoxFPS.TextChanged += new EventHandler(TextBoxFPS_TextChanged);

            textBoxLayoutWidth.TextChanged -= new EventHandler(TextBoxLayoutWidth_TextChanged);
            textBoxLayoutWidth.Text = Methods.NumToText(Screen.WinWidth);
            textBoxLayoutWidth.TextChanged += new EventHandler(TextBoxLayoutWidth_TextChanged);

            textBoxLayoutHeight.TextChanged -= new EventHandler(TextBoxLayoutHeight_TextChanged);
            textBoxLayoutHeight.Text = Methods.NumToText(Screen.WinHeight);
            textBoxLayoutHeight.TextChanged += new EventHandler(TextBoxLayoutHeight_TextChanged);

            textBoxLayoutVert.TextChanged -= new EventHandler(TextBoxLayoutVert_TextChanged);
            textBoxLayoutVert.Text = Methods.NumToText(Screen.X);
            textBoxLayoutVert.TextChanged += new EventHandler(TextBoxLayoutVert_TextChanged);

            textBoxLayoutHoriz.TextChanged -= new EventHandler(TextBoxLayoutHoriz_TextChanged);
            textBoxLayoutHoriz.Text = Methods.NumToText(Screen.Y);
            textBoxLayoutHoriz.TextChanged += new EventHandler(TextBoxLayoutHoriz_TextChanged);

            // Set selected scaling method
            comboBoxScalingMethods.SelectedIndexChanged -= new EventHandler(ComboBoxScalingMethods_SelectedIndexChanged);
            for (int i = 0; i < Screen.ScalingMethods.GetLength(0); i++)
            {
                if (Screen.ScalingMethod == Screen.ScalingMethods[i, 1])
                {
                    comboBoxScalingMethods.SelectedIndex = i;
                    break;
                }
            }
            comboBoxScalingMethods.SelectedIndexChanged += new EventHandler(ComboBoxScalingMethods_SelectedIndexChanged);
        }

        private void InitVideo()
        {
            comboBoxVideoCodecs.Items.Clear();
            for (int i = 0; i < Video.Codecs.GetLength(0); i++)
            {
                comboBoxVideoCodecs.Items.Add(new Methods.ListComboContent(Video.Codecs[i, 0], Video.Codecs[i, 1]));
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
            comboBoxVideoCodecs.SelectedIndexChanged -= new EventHandler(ComboBoxVideoCodecs_SelectedIndexChanged);
            for (int i = 0; i < Video.Codecs.GetLength(0); i++)
            {
                if (Video.Codec == Video.Codecs[i, 1])
                {
                    comboBoxVideoCodecs.SelectedIndex = i;
                    break;
                }
            }
            comboBoxVideoCodecs.SelectedIndexChanged += new EventHandler(ComboBoxVideoCodecs_SelectedIndexChanged);

            comboBoxVideoEncoders.SelectedIndexChanged -= new EventHandler(ComboBoxVideoEncoders_SelectedIndexChanged);
            comboBoxVideoEncoders.Items.Clear();
            for (int i = 0; i < Video.Encoders.GetLength(0); i++)
            {
                comboBoxVideoEncoders.Items.Add(new Methods.ListComboContent(Video.Encoders[i, 0], Video.Encoders[i, 1]));

                if (Video.Encoder == Video.Encoders[i, 1])
                {
                    comboBoxVideoEncoders.SelectedIndex = i;
                }
            }
            comboBoxVideoEncoders.SelectedIndexChanged += new EventHandler(ComboBoxVideoEncoders_SelectedIndexChanged);

            comboBoxBits.SelectedIndexChanged -= new EventHandler(ComboBoxBits_SelectedIndexChanged);
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
            comboBoxBits.SelectedIndexChanged += new EventHandler(ComboBoxBits_SelectedIndexChanged);

            comboBoxBytes.SelectedIndexChanged -= new EventHandler(ComboBoxBytes_SelectedIndexChanged);
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
            comboBoxBytes.SelectedIndexChanged += new EventHandler(ComboBoxBytes_SelectedIndexChanged);

            // Check boxes
            checkBoxTwoPassEncoding.CheckedChanged -= new EventHandler(CheckBoxTwoPassEncoding_CheckedChanged);
            checkBoxTwoPassEncoding.Checked = Session.TwoPassEncoding;
            checkBoxTwoPassEncoding.CheckedChanged += new EventHandler(CheckBoxTwoPassEncoding_CheckedChanged);

            checkBoxUseCRF.CheckedChanged -= new EventHandler(CheckBoxUseCRF_CheckedChanged);
            checkBoxUseCRF.Checked = Video.UseCRF;
            EnableCRFControls(Video.UseCRF);
            checkBoxUseCRF.CheckedChanged += new EventHandler(CheckBoxUseCRF_CheckedChanged);

            // Text boxes
            textBoxVideoBitrate.TextChanged -= new EventHandler(TextBoxVideoBitrate_TextChanged);
            textBoxVideoBitrate.Text = Methods.NumToText(Video.Bitrate);
            textBoxVideoBitrate.TextChanged += new EventHandler(TextBoxVideoBitrate_TextChanged);

            textBoxMinBitrate.TextChanged -= new EventHandler(TextBoxMinBitrate_TextChanged);
            textBoxMinBitrate.Text = Methods.NumToText(Video.MinBitrate);
            textBoxMinBitrate.TextChanged += new EventHandler(TextBoxMinBitrate_TextChanged);

            textBoxMaxBitrate.TextChanged -= new EventHandler(TextBoxMaxBitrate_TextChanged);
            textBoxMaxBitrate.Text = Methods.NumToText(Video.MaxBitrate);
            textBoxMaxBitrate.TextChanged += new EventHandler(TextBoxMaxBitrate_TextChanged);

            textBoxBufferSize.TextChanged -= new EventHandler(TextBoxBufferSize_TextChanged);
            textBoxBufferSize.Text = Methods.NumToText(Video.BufferSize);
            textBoxBufferSize.TextChanged += new EventHandler(TextBoxBufferSize_TextChanged);

            textBoxCRF.TextChanged -= new EventHandler(TextBoxCRF_TextChanged);
            textBoxCRF.Text = Methods.NumToText(Video.CRF);
            textBoxCRF.TextChanged += new EventHandler(TextBoxCRF_TextChanged);

            textBoxQmax.TextChanged -= new EventHandler(TextBoxQmax_TextChanged);
            textBoxQmax.Text = Methods.NumToText(Video.Qmax);
            textBoxQmax.TextChanged += new EventHandler(TextBoxQmax_TextChanged);

            textBoxQmin.TextChanged -= new EventHandler(TextBoxQmin_TextChanged);
            textBoxQmin.Text = Methods.NumToText(Video.Qmin);
            textBoxQmin.TextChanged += new EventHandler(TextBoxQmin_TextChanged);
        }

        private void InitAudio()
        {
            comboBoxAudioCodecs.Items.Clear();
            for (int i = 0; i < Audio.Codecs.GetLength(0); i++)
            {
                comboBoxAudioCodecs.Items.Add(new Methods.ListComboContent(Audio.Codecs[i, 0], Audio.Codecs[i, 1]));
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
            comboBoxAudioCodecs.SelectedIndexChanged -= new EventHandler(ComboBoxAudioCodecs_SelectedIndexChanged);
            for (int i = 0; i < Audio.Codecs.GetLength(0); i++)
            {
                if (Audio.Codec == Audio.Codecs[i, 1])
                {
                    comboBoxAudioCodecs.SelectedIndex = i;
                }
            }
            comboBoxAudioCodecs.SelectedIndexChanged += new EventHandler(ComboBoxAudioCodecs_SelectedIndexChanged);

            comboBoxAudioEncoders.SelectedIndexChanged -= new EventHandler(ComboBoxAudioEncoders_SelectedIndexChanged);
            comboBoxAudioEncoders.Items.Clear();
            for (int i = 0; i < Audio.Encoders.GetLength(0); i++)
            {
                comboBoxAudioEncoders.Items.Add(new Methods.ListComboContent(Audio.Encoders[i, 0], Audio.Encoders[i, 1]));

                if (Audio.Encoder == Audio.Encoders[i, 1])
                {
                    comboBoxAudioEncoders.SelectedIndex = i;
                }
            }
            comboBoxAudioEncoders.SelectedIndexChanged += new EventHandler(ComboBoxAudioEncoders_SelectedIndexChanged);

            comboBoxSampleRates.SelectedIndexChanged -= new EventHandler(ComboBoxSampleRates_SelectedIndexChanged);
            comboBoxSampleRates.Items.Clear();

            for (int i = 0; i < Audio.SampleRates.GetLength(0); i++)
            {
                comboBoxSampleRates.Items.Add(new Methods.ListComboContent(Convert.ToString(Audio.SampleRates[i]) + " Hz", Audio.SampleRates[i]));
            }
            comboBoxSampleRates.Items.Add(new Methods.ListComboContent("", 0));

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

            comboBoxSampleRates.SelectedIndexChanged += new EventHandler(ComboBoxSampleRates_SelectedIndexChanged);

            comboBoxChannels.SelectedIndexChanged -= new EventHandler(ComboBoxChannels_SelectedIndexChanged);
            comboBoxChannels.Items.Clear();

            for (int i = 1; i <= Audio.MaxChannels; i++)
            {
                comboBoxChannels.Items.Add(new Methods.ListComboContent(Convert.ToString(i), i));
            }
            comboBoxChannels.Items.Add(new Methods.ListComboContent("", 0));

            if (Audio.Channels != 0)
            {
                comboBoxChannels.SelectedIndex = Audio.Channels - 1;
            }
            comboBoxChannels.SelectedIndexChanged += new EventHandler(ComboBoxChannels_SelectedIndexChanged);

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
            checkBoxUseAudioVBR.CheckedChanged -= new EventHandler(CheckBoxUseAudioVBR_CheckedChanged);
            checkBoxUseAudioVBR.Visible = Audio.VBRSupported;
            checkBoxUseAudioVBR.Checked = Audio.UseVBR;
            checkBoxUseAudioVBR.CheckedChanged += new EventHandler(CheckBoxUseAudioVBR_CheckedChanged);

            // Combo boxes
            comboBoxAudioBitrates.SelectedIndexChanged -= new EventHandler(ComboBoxAudioBitrates_SelectedIndexChanged);
            comboBoxAudioBitrates.Items.Clear();

            if (Audio.UseVBR == true)
            {
                // VBR modes
                labelAudioBitrate.Text = "Quality:";

                for (int i = 0; i < Audio.VBRModes.GetLength(0); i++)
                {
                    comboBoxAudioBitrates.Items.Add(new Methods.ListComboContent(Convert.ToString(Audio.VBRModes[i]), Audio.VBRModes[i]));
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
                    comboBoxAudioBitrates.Items.Add(new Methods.ListComboContent(Convert.ToString(Audio.Bitrates[i]) + " Kbps", Audio.Bitrates[i]));
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

            comboBoxAudioBitrates.SelectedIndexChanged += new EventHandler(ComboBoxAudioBitrates_SelectedIndexChanged);
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

        private void EnableFileOutputControls(bool enable)
        {
            labelOutput.Enabled = enable;
            textBoxOutFile.Enabled = enable;
            buttonBrowseOutput.Enabled = enable;
            checkBoxOverwrite.Enabled = enable;
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
            groupBoxScalingMethods.Enabled = enable;
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

        private void EnableBinArgsControls(bool enable)
        {
            labelBinArgs.Enabled = enable;
            textBoxBinArgs.Enabled = enable;
            buttonBrowseFFmpegBin.Enabled = enable;
        }

        private void EnableTermArgsControls(bool enable)
        {
            labelTermArgs.Enabled = enable;
            textBoxTermArgs.Enabled = enable;
            buttonBrowseTermBin.Enabled = enable;
        }

        private void BrowseFFmpegBin()
        {
            OpenFileDialog binFile = new OpenFileDialog();
            binFile.Title = "Locate FFmpeg";
            binFile.Filter = "Executable (*.exe) | *.exe | Any file (*.*) | *.*";
            binFile.ShowDialog();

            if (binFile.FileName != "")
            {
                textBoxFFmpegBin.Text = binFile.FileName;
            }
        }

        //
        // Event handlers
        //

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitTabs();

            // Main tab
            if (File.Input != null)
            {
                textBoxInFile.Text = File.Input;
                buttonBrowseInput.Enabled = true;
            }
            textBoxInFile.DragDrop += new DragEventHandler(TextBoxInFile_DragDrop);
            textBoxInFile.DragEnter += new DragEventHandler(TextBoxInFile_DragEnter);
            textBoxInFile.TextChanged += new EventHandler(TextBoxInFile_TextChanged);
            buttonBrowseInput.Click += new EventHandler(ButtonBrowseInput_Click);

            if (File.Output != null)
            {
                textBoxOutFile.Text = File.Output;
            }
            textBoxOutFile.TextChanged += new EventHandler(TextBoxOutFile_TextChanged);
            buttonBrowseOutput.Click += new EventHandler(ButtonBrowseOutput_Click);

            for (int i = 0; i < File.Formats.GetLength(0); i++)
            {
                comboBoxContainers.Items.Add(new Methods.ListComboContent(File.Formats[i, 0], File.Formats[i, 1]));
            }

            comboBoxPresets.Items.Add(new Methods.ListComboContent("Default", null));

            // Populate combobox with parsed XML files and preset names
            string path = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(path, "*.xml");

            foreach (string file in files)
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(file);
                    XmlNodeList nodes = doc.SelectNodes("/presets/preset");

                    foreach (XmlNode node in nodes)
                    {
                        if (node.Attributes["name"] != null)
                        {
                            string title = node.Attributes["name"].Value;
                            comboBoxPresets.Items.Add(new Methods.ListComboContent(title, file));
                        }
                    }
                }
                catch (XmlException)
                {
                    MessageBox.Show("Invalid XML file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (IOException)
                {
                    MessageBox.Show("Unable to access file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            // Set selected preset
            int x = 0;
            for (int i = 0; i < comboBoxPresets.Items.Count; i++)
            {
                Methods.ListComboContent preset = (Methods.ListComboContent)comboBoxPresets.Items[i];
                if (preset.Name == Session.Preset)
                {
                    x = i;
                    break;
                }
            }
            comboBoxPresets.SelectedIndex = x;
            comboBoxPresets.SelectedIndexChanged += new EventHandler(ComboBoxPresets_SelectedIndexChanged);

            comboBoxThreads.Items.Add(new Methods.ListComboContent("Auto", 0));
            for (int i = 1; i <= Session.MaxThreads; i++)
            {
                comboBoxThreads.Items.Add(new Methods.ListComboContent(Convert.ToString(i), i));
            }

            if (Session.KeepValues == true)
            {
                radioButtonKeep.Checked = true;
            }
            else
            {
                radioButtonRefresh.Checked = true;
            }
            radioButtonKeep.CheckedChanged += new EventHandler(RadioButtonKeep_CheckedChanged);
            radioButtonRefresh.CheckedChanged += new EventHandler(RadioButtonRefresh_CheckedChanged);

            InitMain();

            checkBoxOverwrite.Checked = Session.Overwrite;
            checkBoxOverwrite.CheckedChanged += new EventHandler(CheckBoxOverwrite_CheckedChanged);

            this.FormClosing += MainForm_Closing;
            buttonExit.Click += new EventHandler(ButtonExit_Click);
            buttonRun.Click += new EventHandler(ButtonRun_Click);

            // Streams
            textBoxAudioStream.TextChanged += new EventHandler(TextBoxAudioStream_TextChanged);
            buttonBrowseAudioStream.Click += new EventHandler(ButtonBrowseAudioStream_Click);

            // Picture tab
            for (int i = 0; i < Screen.ScalingMethods.GetLength(0); i++)
            {
                comboBoxScalingMethods.Items.Add(new Methods.ListComboContent(Screen.ScalingMethods[i, 0], Screen.ScalingMethods[i, 1]));
            }

            InitPicture();

            // Video tab
            comboBoxBits.Items.Add(new Methods.ListComboContent("Kbps", "k"));
            comboBoxBits.Items.Add(new Methods.ListComboContent("Mbps", "M"));
            comboBoxBytes.Items.Add(new Methods.ListComboContent("KB", "k"));
            comboBoxBytes.Items.Add(new Methods.ListComboContent("MB", "M"));
            comboBoxBytes.Items.Add(new Methods.ListComboContent("GB", "G"));

            buttonVideoCodecProperties.Click += new EventHandler(buttonVideoCodecProperties_Clicked);

            InitVideo();

            // Audio tab
            buttonAudioCodecProperties.Click += new EventHandler(ButtonAudioCodecProperties_Clicked);

            InitAudio();

            // Options           
            if (Bin.FFmpegBin != null)
            {
                textBoxFFmpegBin.Text = Bin.FFmpegBin;
                EnableBinArgsControls(true);
                EnableTermArgsControls(true);
            }
            else
            {
                EnableBinArgsControls(false);
                EnableTermArgsControls(false);
            }
            textBoxFFmpegBin.TextChanged += new EventHandler(TextBoxFFmpegBin_TextChanged);
            buttonBrowseFFmpegBin.Click += new EventHandler(ButtonBrowseFFmpegBin_Click);

            if (Bin.TermBin != null)
            {
                textBoxTermBin.Text = Bin.TermBin;
                EnableTermArgsControls(true);
            }
            else
            {
                EnableTermArgsControls(false);
            }
            textBoxTermBin.TextChanged += new EventHandler(TextBoxTermBin_TextChanged);
            buttonBrowseTermBin.Click += new EventHandler(ButtonBrowseTermBin_Click);

            if (Bin.BinArgs != null)
            {
                textBoxBinArgs.Text = Bin.BinArgs;
            }
            textBoxBinArgs.TextChanged += new EventHandler(TextBoxBinArgs_TextChanged);

            if (Bin.TermArgs != null)
            {
                textBoxTermArgs.Text = Bin.TermArgs;
            }
            textBoxTermArgs.TextChanged += new EventHandler(TextBoxTermArgs_TextChanged);

            checkBoxWriteLog.Checked = Session.WriteLog;
            checkBoxWriteLog.CheckedChanged += new EventHandler(CheckBoxWriteLog_CheckedChanged);
            EnableLogFileTextBox(Session.WriteLog);
            textBoxLog.Text = File.Log;
            textBoxLog.TextChanged += new EventHandler(TextBoxLog_TextChanged);
            checkBoxSaveSettings.Checked = Session.SaveProperties;
            checkBoxSaveSettings.CheckedChanged += new EventHandler(CheckBoxSaveSettings_CheckedChanged);

            // Metadata tab
            textBoxAlbum.TextChanged += new EventHandler(TextBoxAlbum_TextChanged);
            textBoxAlbumArtist.TextChanged += new EventHandler(TextBoxAlbumArtist_TextChanged);
            textBoxArtist.TextChanged += new EventHandler(TextBoxArtist_TextChanged);
            textBoxComment.TextChanged += new EventHandler(TextBoxComment_TextChanged);
            textBoxDisc.TextChanged += new EventHandler(TextBoxDisc_TextChanged);
            textBoxGenre.TextChanged += new EventHandler(TextBoxGenre_TextChanged);
            textBoxTitle.TextChanged += new EventHandler(TextBoxTitle_TextChanged);
            textBoxTotalDiscs.TextChanged += new EventHandler(TextBoxTotalDiscs_TextChanged);
            textBoxTotalTracks.TextChanged += new EventHandler(TextBoxTotalTracks_TextChanged);
            textBoxTrack.TextChanged += new EventHandler(TextBoxTrack_TextChanged);
            textBoxTrack.TextChanged += new EventHandler(TextBoxTrack_TextChanged);
            textBoxYear.TextChanged += new EventHandler(TextBoxYear_TextChanged);

            InitMetadata();
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            ExitFFmpegCatapult();
        }

        void ButtonExit_Click(object sender, EventArgs e)
        {
            ExitFFmpegCatapult();
        }

        void ButtonRun_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Bin.FFmpegBin) | Methods.EnvironmentPathExists(Bin.FFmpegBin))
            {
                Bin.Run();

                if (Session.KeepValues == false)
                {
                    textBoxInFile.Text = "";
                    textBoxOutFile.Text = "";
                    ClearMetadataFields();
                }
            }
            else
            {
                MessageBox.Show("FFmpeg not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BrowseFFmpegBin();
            }
        }

        // Key press event handler for numbered values
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void TextBoxBitrate_KeyPressDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (e.KeyChar != '.' | Video.Bits == "k")
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }
            }
        }

        // Key press event handler to filter invalid chars
        private void TextBox_KeyPress_FSFilter(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '<':
                case '>':
                case '*':
                case '?':
                case '"':
                case '|':
                case '/':
                    e.Handled = e.KeyChar != (char)Keys.Back;
                    break;
                default:
                    break;
            }
        }

        private void TextBoxBufferSize_KeyPressDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (e.KeyChar != '.' | Video.Bytes == "k")
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }
            }
        }

        // Main tab event handlers
        private void TextBoxInFile_TextChanged(object sender, EventArgs e)
        {
            File.Input = textBoxInFile.Text;

            if (!string.IsNullOrEmpty(textBoxInFile.Text))
            {
                EnableFileOutputControls(true);
                File.Output = textBoxInFile.Text;
                textBoxOutFile.TextChanged -= this.TextBoxOutFile_TextChanged;
                textBoxOutFile.Text = File.Output;
                textBoxOutFile.TextChanged += this.TextBoxOutFile_TextChanged;
            }
            else
            {
                EnableFileOutputControls(false);
                textBoxOutFile.Text = "";
            }

            if (System.IO.File.Exists(File.Input) && !string.IsNullOrEmpty(textBoxOutFile.Text))
            {
                buttonRun.Enabled = true;
            }
            else
            {
                buttonRun.Enabled = false;
            }
        }

        private void TextBoxOutFile_TextChanged(object sender, EventArgs e)
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

        private void ButtonBrowseInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog inFile = new OpenFileDialog();
            inFile.ShowDialog();
            inFile.Filter = "Any file (*.*) | *.*";

            if (inFile.FileName != "")
            {
                textBoxInFile.Text = inFile.FileName;
            }
        }

        private void ButtonBrowseOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog outFile = new SaveFileDialog();
            outFile.FileName = Path.GetFileName(File.Output);
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

        void TextBoxInFile_DragEnter(object sender, DragEventArgs e)
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

        void TextBoxInFile_DragDrop(object sender, DragEventArgs e)
        {
            String[] file = (String[])e.Data.GetData(DataFormats.FileDrop);
            if (file != null && file.Length != 0)
            {
                textBoxInFile.Text = file[0];
                textBoxOutFile.Text = file[0];
            }
        }

        void CheckBoxOverwrite_CheckedChanged(object sender, EventArgs e)
        {
            Session.Overwrite = checkBoxOverwrite.Checked;
        }

        void CheckBoxMultiThreading_CheckedChanged(object sender, EventArgs e)
        {
            Session.MultiThreading = checkBoxMultiThreading.Checked;
            comboBoxThreads.Enabled = Session.MultiThreading;
        }

        void ComboBoxContainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Methods.ListComboContent format = (Methods.ListComboContent)comboBoxContainers.SelectedItem;

            if (format.Value != File.Format)
            {
                File.Format = format.Value;
                fileContainer = format.Name;
                fileExtension = format.Value;

                if (textBoxOutFile.Text != "" && File.Format != "custom")
                {
                    textBoxOutFile.TextChanged -= new EventHandler(TextBoxOutFile_TextChanged);
                    File.Output = textBoxOutFile.Text;
                    textBoxOutFile.Text = File.Output;
                    textBoxOutFile.TextChanged += new EventHandler(TextBoxOutFile_TextChanged);
                }
            }

            InitTabs();
            InitAudio();
            InitVideo();
            InitMetadata();
        }

        void ComboBoxPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            Methods.ListComboContent preset = (Methods.ListComboContent)comboBoxPresets.SelectedItem;
            Session.Preset = preset.Name;
            Preset.InitPreset(preset.Name, preset.Value);
            InitTabs();
            InitMain();
            InitPicture();
            InitVideo();
            InitAudio();
            InitMetadata();
        }

        void ComboBoxThreads_SelectedIndexChanged(object sender, EventArgs e)
        {
            Methods.ListComboContent threads = (Methods.ListComboContent)comboBoxThreads.SelectedItem;
            Session.Threads = threads.X;
        }

        void RadioButtonKeep_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKeep.Checked == true)
            {
                Session.KeepValues = true;
            }
        }

        void RadioButtonRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRefresh.Checked == true)
            {
                Session.KeepValues = false;
            }
        }

        // Picture tab events
        void RadioButtonKeepRes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKeepRes.Checked == true)
            {
                Screen.ScaleOption = 0;
                EnableResControls(false);
            }
        }

        void RadioButtonCustomRes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCustomRes.Checked == true)
            {
                Screen.ScaleOption = 1;
                EnableResControls(true);
            }
        }

        void RadioButtonHalfRes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHalfRes.Checked == true)
            {
                Screen.ScaleOption = 2;
                EnableResControls(false);
            }
        }

        void CheckBoxAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            Screen.AspectRatio = checkBoxAspectRatio.Checked;
            EnableRatioControls(Screen.AspectRatio);
        }

        void CheckBoxCrop_CheckedChanged(object sender, EventArgs e)
        {
            Screen.CropVideo = checkBoxCrop.Checked;
            EnableLayoutControls(Screen.CropVideo);
        }

        void CheckBoxDeinterlace_CheckedChanged(object sender, EventArgs e)
        {
            Screen.Deinterlace = checkBoxDeinterlace.Checked;
        }

        void CheckBoxPad_CheckedChanged(object sender, EventArgs e)
        {
            Screen.PadVideo = checkBoxPad.Checked;
            EnableLayoutControls(Screen.PadVideo);
        }

        void TextBoxWidth_TextChanged(object sender, EventArgs e)
        {
            Screen.Width = Methods.TextToInt(textBoxWidth.Text);
        }

        void TextBoxHeight_TextChanged(object sender, EventArgs e)
        {
            Screen.Height = Methods.TextToInt(textBoxHeight.Text);
        }

        void TextBoxRatioA_TextChanged(object sender, EventArgs e)
        {
            Screen.RatioA = Methods.TextToInt(textBoxRatioA.Text);
        }

        void TextBoxRatioB_TextChanged(object sender, EventArgs e)
        {
            Screen.RatioB = Methods.TextToInt(textBoxRatioB.Text);
        }

        void TextBoxFPS_TextChanged(object sender, EventArgs e)
        {
            Screen.FPS = Methods.TextToInt(textBoxFPS.Text);
        }

        void TextBoxLayoutWidth_TextChanged(object sender, EventArgs e)
        {
            Screen.WinWidth = Methods.TextToInt(textBoxLayoutWidth.Text);
        }

        void TextBoxLayoutHeight_TextChanged(object sender, EventArgs e)
        {
            Screen.WinHeight = Methods.TextToInt(textBoxLayoutHeight.Text);
        }

        void TextBoxLayoutVert_TextChanged(object sender, EventArgs e)
        {
            Screen.X = Methods.TextToInt(textBoxLayoutVert.Text);
        }

        void TextBoxLayoutHoriz_TextChanged(object sender, EventArgs e)
        {
            Screen.Y = Methods.TextToInt(textBoxLayoutHoriz.Text);
        }

        void ComboBoxScalingMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            Methods.ListComboContent scalingMethod = (Methods.ListComboContent)comboBoxScalingMethods.SelectedItem;
            Screen.ScalingMethod = scalingMethod.Value;
        }

        // Video tab events
        void buttonVideoCodecProperties_Clicked(object sender, EventArgs e)
        {
            VideoSettingsForm videoProperties = new VideoSettingsForm();
            videoProperties.StartPosition = FormStartPosition.CenterParent;
            videoProperties.ShowDialog(this);
        }

        void ComboBoxVideoCodecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Methods.ListComboContent codec = (Methods.ListComboContent)comboBoxVideoCodecs.SelectedItem;
            if (codec.Value != Video.Codec)
            {
                Video.Codec = codec.Value;
                InitTabs();
                InitVideo();
            }
        }

        void ComboBoxVideoEncoders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Methods.ListComboContent encoder = (Methods.ListComboContent)comboBoxVideoEncoders.SelectedItem;
            Video.Encoder = encoder.Value;
        }

        void ComboBoxBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            Methods.ListComboContent bits = (Methods.ListComboContent)comboBoxBits.SelectedItem;
            Video.Bits = bits.Value;
            labelMaxBits.Text = bits.Name;
            labelMinBits.Text = bits.Name;
        }

        void ComboBoxBytes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Methods.ListComboContent bytes = (Methods.ListComboContent)comboBoxBytes.SelectedItem;
            Video.Bytes = bytes.Value;
        }

        void CheckBoxTwoPassEncoding_CheckedChanged(object sender, EventArgs e)
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

        void CheckBoxUseCRF_CheckedChanged(object sender, EventArgs e)
        {
            Video.UseCRF = checkBoxUseCRF.Checked;
            EnableCRFControls(Video.UseCRF);
        }

        void TextBoxVideoBitrate_TextChanged(object sender, EventArgs e)
        {
            Video.Bitrate = Methods.TextToDouble(textBoxVideoBitrate.Text);
        }

        void TextBoxMinBitrate_TextChanged(object sender, EventArgs e)
        {
            Video.MinBitrate = Methods.TextToDouble(textBoxMinBitrate.Text);
        }

        void TextBoxMaxBitrate_TextChanged(object sender, EventArgs e)
        {
            Video.MaxBitrate = Methods.TextToDouble(textBoxMaxBitrate.Text);
        }

        void TextBoxBufferSize_TextChanged(object sender, EventArgs e)
        {
            Video.BufferSize = Methods.TextToDouble(textBoxBufferSize.Text);
        }

        void TextBoxCRF_TextChanged(object sender, EventArgs e)
        {
            Video.CRF = Methods.TextToInt(textBoxCRF.Text);
        }

        void TextBoxQmax_TextChanged(object sender, EventArgs e)
        {
            Video.Qmax = Methods.TextToInt(textBoxQmax.Text);
        }

        void TextBoxQmin_TextChanged(object sender, EventArgs e)
        {
            Video.Qmin = Methods.TextToInt(textBoxQmin.Text);
        }

        // Audio tab events
        void ButtonAudioCodecProperties_Clicked(object sender, EventArgs e)
        {
            AudioSettingsForm audioProperties = new AudioSettingsForm();
            audioProperties.StartPosition = FormStartPosition.CenterParent;
            audioProperties.ShowDialog(this);
        }

        void ComboBoxAudioCodecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Methods.ListComboContent codec = (Methods.ListComboContent)comboBoxAudioCodecs.SelectedItem;
            if (codec.Value != Audio.Codec)
            {
                Audio.Codec = codec.Value;
                InitAudio();
            }
        }

        void ComboBoxAudioEncoders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Methods.ListComboContent encoder = (Methods.ListComboContent)comboBoxAudioEncoders.SelectedItem;
            if (encoder.Value != Audio.Encoder)
            {
                Audio.Encoder = encoder.Value;
                InitAudioEncPropertiesButton();
                InitAudioBitrates();
            }
        }

        void ComboBoxSampleRates_SelectedIndexChanged(object sender, EventArgs e)
        {
            Methods.ListComboContent sampleRate = (Methods.ListComboContent)comboBoxSampleRates.SelectedItem;
            if (sampleRate.X != Audio.SampleRate)
            {
                Audio.SampleRate = sampleRate.X;
                InitAudioBitrates();
            }
        }

        void ComboBoxChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Methods.ListComboContent channels = (Methods.ListComboContent)comboBoxChannels.SelectedItem;
            if (channels.X != Audio.Channels)
            {
                Audio.Channels = channels.X;
            }
        }

        void CheckBoxUseAudioVBR_CheckedChanged(object sender, EventArgs e)
        {
            Audio.UseVBR = checkBoxUseAudioVBR.Checked;
            InitAudioBitrates();
        }

        void ComboBoxAudioBitrates_SelectedIndexChanged(object sender, EventArgs e)
        {
            Methods.ListComboContent bitrate = (Methods.ListComboContent)comboBoxAudioBitrates.SelectedItem;

            if (Audio.UseVBR == true)
            {
                Audio.Quality = bitrate.X;
            }
            else
            {
                Audio.Bitrate = bitrate.X;
            }
        }

        void ButtonBrowseAudioStream_Click(object sender, EventArgs e)
        {
            OpenFileDialog audioFile = new OpenFileDialog();
            audioFile.ShowDialog();

            if (audioFile.FileName != "")
            {
                textBoxAudioStream.Text = audioFile.FileName;
            }
        }

        void TextBoxAudioStream_TextChanged(object sender, EventArgs e)
        {
            File.AudioStream = textBoxAudioStream.Text;
        }

        // Tagging tab events
        void TextBoxAlbum_TextChanged(object sender, EventArgs e)
        {
            Metadata.Album = textBoxAlbum.Text;
        }

        void TextBoxAlbumArtist_TextChanged(object sender, EventArgs e)
        {
            Metadata.AlbumArtist = textBoxAlbumArtist.Text;
        }

        void TextBoxArtist_TextChanged(object sender, EventArgs e)
        {
            Metadata.Artist = textBoxArtist.Text;
        }

        void TextBoxComment_TextChanged(object sender, EventArgs e)
        {
            Metadata.Comment = textBoxComment.Text;
        }

        void TextBoxDisc_TextChanged(object sender, EventArgs e)
        {
            Metadata.Disc = Methods.TextToInt(textBoxDisc.Text);
        }

        void TextBoxGenre_TextChanged(object sender, EventArgs e)
        {
            Metadata.Genre = textBoxGenre.Text;
        }

        void TextBoxTitle_TextChanged(object sender, EventArgs e)
        {
            Metadata.Title = textBoxTitle.Text;
        }

        void TextBoxTotalDiscs_TextChanged(object sender, EventArgs e)
        {
            Metadata.Disc = Methods.TextToInt(textBoxDisc.Text);
        }

        void TextBoxTotalTracks_TextChanged(object sender, EventArgs e)
        {
            Metadata.TotalTracks = Methods.TextToInt(textBoxTotalTracks.Text);
        }

        void TextBoxTrack_TextChanged(object sender, EventArgs e)
        {
            Metadata.Track = Methods.TextToInt(textBoxTrack.Text);
        }

        void TextBoxYear_TextChanged(object sender, EventArgs e)
        {
            Metadata.Year = Methods.TextToInt(textBoxYear.Text);
        }

        // Options tab events
        void TextBoxFFmpegBin_TextChanged(object sender, EventArgs e)
        {
            Bin.FFmpegBin = textBoxFFmpegBin.Text;
            EnableBinArgsControls(!string.IsNullOrEmpty(textBoxFFmpegBin.Text));
        }

        void TextBoxTermBin_TextChanged(object sender, EventArgs e)
        {
            Bin.TermBin = textBoxTermBin.Text;
            EnableTermArgsControls(!string.IsNullOrEmpty(textBoxTermBin.Text));
        }

        void TextBoxBinArgs_TextChanged(object sender, EventArgs e)
        {
            Bin.BinArgs = textBoxBinArgs.Text;
        }

        void TextBoxTermArgs_TextChanged(object sender, EventArgs e)
        {
            Bin.TermArgs = textBoxTermArgs.Text;
        }

        void TextBoxLog_TextChanged(object sender, EventArgs e)
        {
            File.Log = textBoxLog.Text;
        }

        void ButtonBrowseFFmpegBin_Click(object sender, EventArgs e)
        {
            BrowseFFmpegBin();
        }

        void CheckBoxWriteLog_CheckedChanged(object sender, EventArgs e)
        {
            Session.WriteLog = checkBoxWriteLog.Checked;
            EnableLogFileTextBox(Session.WriteLog);
        }

        void CheckBoxSaveSettings_CheckedChanged(object sender, EventArgs e)
        {
            Session.SaveProperties = checkBoxSaveSettings.Checked;
            Properties.Settings.Default.SaveSettings = Session.SaveProperties;
            Properties.Settings.Default.Save();
        }

        void ButtonBrowseTermBin_Click(object sender, EventArgs e)
        {
            OpenFileDialog termBinFile = new OpenFileDialog();
            termBinFile.Title = "Locate Terminal Emulator";
            termBinFile.Filter = "Executable (*.exe) | *.exe | Any file (*.*) | *.*";
            termBinFile.ShowDialog();

            if (termBinFile.FileName != "")
            {
                textBoxTermBin.Text = termBinFile.FileName;
            }
        }
    }
}