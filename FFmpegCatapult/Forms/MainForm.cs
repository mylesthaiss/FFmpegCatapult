// MainForm is part of FFmpeg Catapult.

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
using FFmpegCatapult.Models;
using FFmpegCatapult.Core;
using FFmpegCatapult.Helpers;
using FFmpegCatapult.Factories;

namespace FFmpegCatapult
{
    public partial class MainForm : Form
    {
        private FFmpegBin ffmpegBin = new FFmpegBin();
        private Settings settings = new Settings();
        private FilePaths paths = new FilePaths();
        private Container file = ContainerFactory.Create("avi");
        private Audio audio = AudioFactory.Create("aac");
        private Video video = VideoFactory.Create("h264");
        private Picture picture = new Picture();

        public MainForm()
        {
            settings.Load();
            InitializeComponent();
        }

        // Methods
        private void InitPreset(string presetName, string xmlFile)
        {
            file = ContainerFactory.Create(xmlFile, presetName);
            video = VideoFactory.Create(xmlFile, presetName, settings);
            audio = AudioFactory.Create(xmlFile, presetName, settings);
            picture = new Picture(xmlFile, presetName);
        }

        private void InitTabs()
        {
            tabVideo.Enabled = file.SupportedVideoCodecs.Length > 2;
            tabAudio.Enabled = file.SupportedAudioCodecs.Length > 2;
            tabPicture.Enabled = file.SupportedVideoCodecs.Length > 2;
        }

        private void InitMain()
        {
            numericUpDownThreads.Maximum = settings.MaxThreads;
            numericUpDownThreads.Value = settings.Threads;
            numericUpDownProcessors.Maximum = settings.MaxThreads;
            numericUpDownProcessors.Value = settings.Processors;

            // Combo boxes
            comboBoxContainers.SelectedIndexChanged -= new EventHandler(ComboBoxContainers_SelectedIndexChanged);
            comboBoxContainers.SelectedIndex = GetSelectionIndex(file.Format, ContainerFactory.Containers);
            comboBoxContainers.SelectedIndexChanged += new EventHandler(ComboBoxContainers_SelectedIndexChanged);

            // Text boxes
            if (string.IsNullOrEmpty(textBoxTargetFolder.Text))
            {
                textBoxTargetFolder.TextChanged -= new EventHandler(TextBoxTargetFolder_TextChanged);
                textBoxTargetFolder.Text = settings.DefaultOutputFolder;
                textBoxTargetFolder.TextChanged += new EventHandler(TextBoxTargetFolder_TextChanged);
            }
        }

        private void InitOutput()
        {
            checkBoxFastStartTagging.Enabled = file.FastStartSupported;

            checkBoxFastStartTagging.EnabledChanged -= new EventHandler(CheckBoxFastStartTagging_CheckedChanged);
            checkBoxFastStartTagging.Checked = file.FastStartTagging;
            checkBoxFastStartTagging.EnabledChanged += new EventHandler(CheckBoxFastStartTagging_CheckedChanged);
        }

        private void InitPicture()
        {
            // Resolution radio buttons
            radioButtonKeepRes.CheckedChanged -= new EventHandler(RadioButtonKeepRes_CheckedChanged);
            radioButtonHalfRes.CheckedChanged -= new EventHandler(RadioButtonHalfRes_CheckedChanged);
            radioButtonCustomRes.CheckedChanged -= new EventHandler(RadioButtonCustomRes_CheckedChanged);
            if (picture.ScaleOption == 0)
            {
                radioButtonKeepRes.Checked = true;
                EnableResControls(false);
            }
            else if (picture.ScaleOption == 1)
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
            checkBoxAspectRatio.Checked = picture.AspectRatio;
            EnableRatioControls(picture.AspectRatio);
            checkBoxAspectRatio.CheckedChanged += new EventHandler(CheckBoxAspectRatio_CheckedChanged);

            checkBoxCrop.CheckedChanged += new EventHandler(CheckBoxCrop_CheckedChanged);
            checkBoxCrop.Checked = picture.Crop;
            EnableLayoutControls(picture.Crop);
            checkBoxCrop.CheckedChanged += new EventHandler(CheckBoxCrop_CheckedChanged);

            checkBoxDeinterlace.CheckedChanged -= new EventHandler(CheckBoxDeinterlace_CheckedChanged);
            checkBoxDeinterlace.Checked = picture.Deinterlace;
            checkBoxDeinterlace.CheckedChanged += new EventHandler(CheckBoxDeinterlace_CheckedChanged);

            checkBoxPad.CheckedChanged -= new EventHandler(CheckBoxPad_CheckedChanged);
            checkBoxPad.Checked = picture.Pad;
            EnableLayoutControls(picture.Pad);
            checkBoxPad.CheckedChanged += new EventHandler(CheckBoxPad_CheckedChanged);

            // Numeric dropdowns
            numericUpDownFPS.ValueChanged -= new EventHandler(NumericUpDownFPS_ValueChanged);
            numericUpDownFPS.Value = picture.FPS;
            numericUpDownFPS.ValueChanged += new EventHandler(NumericUpDownFPS_ValueChanged);

            numericUpDownHeight.ValueChanged -= new EventHandler(NumericUpDownHeight_ValueChanged);
            numericUpDownHeight.Value = picture.Height;
            numericUpDownHeight.ValueChanged += new EventHandler(NumericUpDownHeight_ValueChanged);

            numericUpDownWidth.ValueChanged -= new EventHandler(NumericUpDownWidth_ValueChanged);
            numericUpDownWidth.Value = picture.Width;
            numericUpDownHeight.ValueChanged += new EventHandler(NumericUpDownWidth_ValueChanged);

            numericUpDownLayoutHeight.ValueChanged -= new EventHandler(NumericUpDownLayoutHeight_ValueChanged);
            numericUpDownLayoutHeight.Value = picture.WinHeight;
            numericUpDownLayoutHeight.ValueChanged += new EventHandler(NumericUpDownLayoutHeight_ValueChanged);

            numericUpDownLayoutWidth.ValueChanged -= new EventHandler(NumericUpDownLayoutWidth_ValueChanged);
            numericUpDownLayoutWidth.Value = picture.WinWidth;
            numericUpDownLayoutWidth.ValueChanged += new EventHandler(NumericUpDownLayoutWidth_ValueChanged);

            numericUpDownLayoutHoriz.ValueChanged -= new EventHandler(NumericUpDownLayoutHoriz_ValueChanged);
            numericUpDownLayoutHoriz.Value = picture.X;
            numericUpDownLayoutHoriz.ValueChanged += new EventHandler(NumericUpDownLayoutHoriz_ValueChanged);

            numericUpDownLayoutVert.ValueChanged -= new EventHandler(NumericUpDownLayoutVert_ValueChanged);
            numericUpDownLayoutVert.Value = picture.Y;
            numericUpDownLayoutVert.ValueChanged += new EventHandler(NumericUpDownLayoutVert_ValueChanged);

            numericUpDownRatioA.ValueChanged -= new EventHandler(NumericUpDownRatio_ValueChanged);
            numericUpDownRatioB.ValueChanged -= new EventHandler(NumericUpDownRatio_ValueChanged);
            string[] ratioValues = picture.Ratio.Split(':');
            numericUpDownRatioA.Value = Convert.ToInt32(ratioValues[0]);
            numericUpDownRatioB.Value = Convert.ToInt32(ratioValues[1]);
            numericUpDownRatioA.ValueChanged += new EventHandler(NumericUpDownRatio_ValueChanged);
            numericUpDownRatioB.ValueChanged += new EventHandler(NumericUpDownRatio_ValueChanged);

            // Text boxes
            textBoxLayoutColour.TextChanged -= new EventHandler(TextBoxLayoutColour_TextChanged);
            textBoxLayoutColour.Text = picture.VideoFilterColour;
            textBoxLayoutColour.TextChanged += new EventHandler(TextBoxLayoutColour_TextChanged);
        }

        private void InitVideo()
        {
            if (video.Codec != "copy" & video.Codec != "none")
                EnableVideoControls(true);
            else
                EnableVideoControls(false);

            // Combo boxes
            comboBoxVideoCodecs.SelectedIndexChanged -= new EventHandler(ComboBoxVideoCodecs_SelectedIndexChanged);
            comboBoxVideoCodecs = WinFormsHelper.AddMultiArrayToComboBox(comboBoxVideoCodecs, file.SupportedVideoCodecs, video.Codec);
            comboBoxVideoCodecs.SelectedIndexChanged += new EventHandler(ComboBoxVideoCodecs_SelectedIndexChanged);

            comboBoxVideoEncoders.SelectedIndexChanged -= new EventHandler(ComboBoxVideoEncoders_SelectedIndexChanged);
            comboBoxVideoEncoders = WinFormsHelper.AddMultiArrayToComboBox(comboBoxVideoEncoders, video.Encoders, video.Encoder);
            comboBoxVideoEncoders.SelectedIndexChanged += new EventHandler(ComboBoxVideoEncoders_SelectedIndexChanged);

            comboBoxPixelFormat.SelectedIndexChanged -= new EventHandler(ComboBoxPixelFormat_SelectedIndexChanged);
            comboBoxPixelFormat = WinFormsHelper.AddMultiArrayToComboBox(comboBoxPixelFormat, video.PixelFormats, video.PixelFormat);
            comboBoxPixelFormat.SelectedIndexChanged += new EventHandler(ComboBoxPixelFormat_SelectedIndexChanged);

            comboBoxMEMethod.SelectedIndexChanged -= new EventHandler(ComboBoxMEMethod_SelectedIndexChanged);
            comboBoxMEMethod = WinFormsHelper.AddMultiArrayToComboBox(comboBoxMEMethod, video.MotionEstimateMethods, video.MotionEstimateMethod);
            comboBoxMEMethod.SelectedIndexChanged += new EventHandler(ComboBoxMEMethod_SelectedIndexChanged);

            // Check boxes
            checkBoxTwoPassEncoding.CheckedChanged -= new EventHandler(CheckBoxTwoPassEncoding_CheckedChanged);
            checkBoxTwoPassEncoding.Checked = video.TwoPassEncoding;
            checkBoxTwoPassEncoding.CheckedChanged += new EventHandler(CheckBoxTwoPassEncoding_CheckedChanged);

            checkBoxUseCRF.CheckedChanged -= new EventHandler(CheckBoxUseCRF_CheckedChanged);
            checkBoxUseCRF.Checked = video.UseCRF;
            EnableCRFControls(video.UseCRF);
            checkBoxUseCRF.CheckedChanged += new EventHandler(CheckBoxUseCRF_CheckedChanged);

            // Numeric up downs
            numericUpDownVideoBitrate.ValueChanged -= new EventHandler(NumericUpDownVideoBitrate_ValueChanged);
            numericUpDownVideoBitrate.Value = video.Bitrate;
            numericUpDownVideoBitrate.ValueChanged += new EventHandler(NumericUpDownVideoBitrate_ValueChanged);

            numericUpDownVideoMinBitrate.ValueChanged -= new EventHandler(NumericUpDownVideoMinBitrate_ValueChanged);
            numericUpDownVideoMinBitrate.Value = video.MinBitrate;
            numericUpDownVideoMinBitrate.ValueChanged += new EventHandler(NumericUpDownVideoMinBitrate_ValueChanged);

            numericUpDownVideoMaxBitrate.ValueChanged -= new EventHandler(NumericUpDownVideoMaxBitrate_ValueChanged);
            numericUpDownVideoMaxBitrate.Value = video.MaxBitrate;
            numericUpDownVideoMaxBitrate.ValueChanged += new EventHandler(NumericUpDownVideoMaxBitrate_ValueChanged);

            numericUpDownCRF.ValueChanged -= new EventHandler(NumericUpDownCRF_ValueChanged);
            numericUpDownCRF.Value = video.Quality;
            numericUpDownCRF.ValueChanged += new EventHandler(NumericUpDownCRF_ValueChanged);

            numericUpDownQMin.ValueChanged -= new EventHandler(NumericUpDownQMin_ValueChanged);
            numericUpDownQMin.Value = video.QMin;
            numericUpDownQMin.ValueChanged += new EventHandler(NumericUpDownQMin_ValueChanged);

            numericUpDownQMax.ValueChanged -= new EventHandler(NumericUpDownQMax_ValueChanged);
            numericUpDownQMax.Value = video.QMax;
            numericUpDownQMax.ValueChanged += new EventHandler(NumericUpDownQMax_ValueChanged);

            numericUpDownTargetSize.ValueChanged -= new EventHandler(NumericUpDownTargetSize_ValueChanged);
            numericUpDownTargetSize.Value = video.TargetSize;
            numericUpDownTargetSize.ValueChanged += new EventHandler(NumericUpDownTargetSize_ValueChanged);

            numericUpDownBufferSize.ValueChanged -= new EventHandler(NumericUpDownBufferSize_ValueChanged);
            numericUpDownBufferSize.Value = video.BufferSize;
            numericUpDownBufferSize.ValueChanged += new EventHandler(NumericUpDownBufferSize_ValueChanged);

            numericUpDownGOPSize.ValueChanged -= new EventHandler(NumericUpDownGOPSize_ValueChanged);
            numericUpDownGOPSize.Value = video.GOPSize;
            numericUpDownGOPSize.ValueChanged += new EventHandler(NumericUpDownGOPSize_ValueChanged);

            numericUpDownBFrames.ValueChanged -= new EventHandler(NumericUpDownBFrames_ValueChanged);
            numericUpDownBFrames.Value = video.BFrames;
            numericUpDownBFrames.ValueChanged += new EventHandler(NumericUpDownBFrames_ValueChanged);

            numericUpDownBFStrat.ValueChanged -= new EventHandler(NumericUpDownBFStrat_ValueChanged);
            numericUpDownBFStrat.Value = video.BFStrategy;
            numericUpDownBFStrat.ValueChanged += new EventHandler(NumericUpDownBFStrat_ValueChanged);

            numericUpDownTileColumns.ValueChanged -= new EventHandler(NumericUpDownTileColumns_ValueChanged);
            numericUpDownTileColumns.Value = video.TileColumns;
            numericUpDownTileColumns.ValueChanged += new EventHandler(NumericUpDownTileColumns_ValueChanged);

            numericUpDownTileRows.ValueChanged -= new EventHandler(NumericUpDownTileRows_ValueChanged);
            numericUpDownTileRows.Value = video.TileRows;
            numericUpDownTileRows.ValueChanged += new EventHandler(NumericUpDownTileRows_ValueChanged);

            numericUpDownMECmp.ValueChanged -= new EventHandler(NumericUpDownMECmp_ValueChanged);
            numericUpDownMECmp.Value = video.MotionEstimateCompare;
            numericUpDownMECmp.ValueChanged += new EventHandler(NumericUpDownMECmp_ValueChanged);

            numericUpDownMESubCmp.ValueChanged -= new EventHandler(NumericUpDownMESubCmp_ValueChanged);
            numericUpDownMESubCmp.Value = video.MotionEstimateSubCompare;
            numericUpDownMESubCmp.ValueChanged += new EventHandler(NumericUpDownMESubCmp_ValueChanged);

            numericUpDownMEPreCmp.ValueChanged -= new EventHandler(NumericUpDownMEPreCmp_ValueChanged);
            numericUpDownMEPreCmp.Value = video.MotionEstimatePreCompare;
            numericUpDownMEPreCmp.ValueChanged += new EventHandler(NumericUpDownMEPreCmp_ValueChanged);

            numericUpDownMBCmp.ValueChanged -= new EventHandler(NumericUpDownMBCmp_ValueChanged);
            numericUpDownMBCmp.Value = video.MacroBlockingCompare;
            numericUpDownMBCmp.ValueChanged += new EventHandler(NumericUpDownMBCmp_ValueChanged);

            numericUpDownDiaSize.ValueChanged -= new EventHandler(NumericUpDownDiaSize_ValueChanged);
            numericUpDownDiaSize.Value = video.DiaSize;
            numericUpDownDiaSize.ValueChanged += new EventHandler(NumericUpDownDiaSize_ValueChanged);

            numericUpDownTrellis.ValueChanged -= new EventHandler(NumericUpDownTrellis_ValueChanged);
            numericUpDownTrellis.Value = video.Trellis;
            numericUpDownTrellis.ValueChanged += new EventHandler(NumericUpDownTrellis_ValueChanged);

            // Other items
            InitVideoEncoderSettings();
        }

        private void InitVideoEncoderSettings()
        {
            if (video.Profiles.Length > 0)
            {
                comboBoxVCodecProfile.SelectedIndexChanged -= new EventHandler(ComboBoxVCodecProfile_SelectedIndexChanged);
                comboBoxVCodecProfile = WinFormsHelper.AddMultiArrayToComboBox(comboBoxVCodecProfile, video.Profiles, video.Profile);
                comboBoxVCodecProfile.SelectedIndexChanged += new EventHandler(ComboBoxVCodecProfile_SelectedIndexChanged);
                labelVCodecProfile.Enabled = true;
                comboBoxVCodecProfile.Enabled = true;
            }
            else
            {
                comboBoxVCodecProfile.Items.Clear();
                labelVCodecProfile.Enabled = false;
                comboBoxVCodecProfile.Enabled = false;
            }

            if (video.CodecLevels.Length > 0)
            {
                comboBoxVideoCodecLevels.SelectedIndexChanged -= new EventHandler(ComboBoxVideoCodecLevels_SelectedIndexChanged);
                comboBoxVideoCodecLevels = WinFormsHelper.AddArrayToComboBox(comboBoxVideoCodecLevels, video.CodecLevels, video.CodecLevel);
                comboBoxVideoCodecLevels.SelectedIndexChanged += new EventHandler(ComboBoxVideoCodecLevels_SelectedIndexChanged);
                labelVCodecLevel.Enabled = true;
                comboBoxVideoCodecLevels.Enabled = true;
            }
            else
            {
                comboBoxVideoCodecLevels.Items.Clear();
                labelVCodecLevel.Enabled = false;
                comboBoxVideoCodecLevels.Enabled = false;
            }

            if (video.EncoderPresets.Length > 0)
            {                
                comboBoxVideoEncoderPresets.SelectedIndexChanged -= new EventHandler(ComboBoxVideoEncoderPresets_SelectedIndexChanged);
                comboBoxVideoEncoderPresets = WinFormsHelper.AddMultiArrayToComboBox(comboBoxVideoEncoderPresets, video.EncoderPresets, video.EncoderPreset);
                comboBoxVideoEncoderPresets.SelectedIndexChanged += new EventHandler(ComboBoxVideoEncoderPresets_SelectedIndexChanged);
                labelVideoEncoderPreset.Enabled = true;
                comboBoxVideoEncoderPresets.Enabled = true;
            }
            else
            {
                comboBoxVideoEncoderPresets.Items.Clear();
                labelVideoEncoderPreset.Enabled = false;
                comboBoxVideoEncoderPresets.Enabled = false;
            }
        }

        private void InitAudio()
        {
            if (audio.Codec != "copy" & audio.Codec != "none")
                EnableAudioControls(true);
            else
                EnableAudioControls(false);

            // Combo boxes
            comboBoxAudioCodecs.SelectedIndexChanged -= new EventHandler(ComboBoxAudioCodecs_SelectedIndexChanged);
            comboBoxAudioCodecs = WinFormsHelper.AddMultiArrayToComboBox(comboBoxAudioCodecs, file.SupportedAudioCodecs, audio.Codec);
            comboBoxAudioCodecs.SelectedIndexChanged += new EventHandler(ComboBoxAudioCodecs_SelectedIndexChanged);

            comboBoxAudioEncoders.SelectedIndexChanged -= new EventHandler(ComboBoxAudioEncoders_SelectedIndexChanged);
            comboBoxAudioEncoders = WinFormsHelper.AddMultiArrayToComboBox(comboBoxAudioEncoders, audio.Encoders, audio.Encoder);
            comboBoxAudioEncoders.SelectedIndexChanged += new EventHandler(ComboBoxAudioEncoders_SelectedIndexChanged);

            comboBoxSampleRates.SelectedIndexChanged -= new EventHandler(ComboBoxSampleRates_SelectedIndexChanged);
            comboBoxSampleRates = WinFormsHelper.AddArrayToComboBox(comboBoxSampleRates, audio.SampleRates, "Hz", audio.SampleRate);
            comboBoxSampleRates.SelectedIndexChanged += new EventHandler(ComboBoxSampleRates_SelectedIndexChanged);

            comboBoxChannels.SelectedIndexChanged -= new EventHandler(ComboBoxChannels_SelectedIndexChanged);
            comboBoxChannels.Items.Clear();

            for (int i = 1; i <= audio.MaxChannels; i++)
            {
                comboBoxChannels.Items.Add(new WinFormsHelper.ListComboContent(Convert.ToString(i), i));
            }
            comboBoxChannels.Items.Add(new WinFormsHelper.ListComboContent("", 0));

            if (audio.Channels != 0)
                comboBoxChannels.SelectedIndex = audio.Channels - 1;

            comboBoxChannels.SelectedIndexChanged += new EventHandler(ComboBoxChannels_SelectedIndexChanged);

            numericUpDownVolumeBoost.ValueChanged -= new EventHandler(NumericUpDownVolumeBoost_ValueChanged);
            numericUpDownVolumeBoost.Value = audio.VolumeBoost;
            numericUpDownVolumeBoost.ValueChanged += new EventHandler(NumericUpDownVolumeBoost_ValueChanged);

            // Other items
            InitAudioProfiles();
            InitAudioBitrates();
            InitAudioFilterSettings();
        }

        private void InitAudioBitrates()
        {
            // Check boxes
            checkBoxUseAudioVBR.CheckedChanged -= new EventHandler(CheckBoxUseAudioVBR_CheckedChanged);
            checkBoxUseAudioVBR.Visible = audio.IsVBRSupported;
            comboBoxAudioVBRModes.Visible = audio.IsVBRSupported;
            labelVBRMode.Visible = audio.IsVBRSupported;
            checkBoxUseAudioVBR.Checked = audio.UseVBR;
            checkBoxUseAudioVBR.CheckedChanged += new EventHandler(CheckBoxUseAudioVBR_CheckedChanged);

            // Audio bitrate combo box
            comboBoxAudioBitrates.SelectedIndexChanged -= new EventHandler(ComboBoxAudioBitrates_SelectedIndexChanged);
            comboBoxAudioBitrates = WinFormsHelper.AddArrayToComboBox(comboBoxAudioBitrates, audio.Bitrates, "Kbps", audio.Bitrate);
            comboBoxAudioBitrates.SelectedIndexChanged += new EventHandler(ComboBoxAudioBitrates_SelectedIndexChanged);

            // Audio VBR modes combo box
            if (audio.IsVBRSupported)
            {
                comboBoxAudioVBRModes.SelectedIndexChanged -= new EventHandler(ComboBoxAudioVBRModes_SelectedIndexChanged);
                comboBoxAudioVBRModes = WinFormsHelper.AddIntArrayToComboBox(comboBoxAudioVBRModes, audio.VBRModes, audio.Quality);
                comboBoxAudioVBRModes.SelectedIndexChanged += new EventHandler(ComboBoxAudioVBRModes_SelectedIndexChanged);
            }

            if (audio.UseVBR)
            {
                labelVBRMode.Enabled = true;
                comboBoxAudioVBRModes.Enabled = true;
                labelAudioBitrate.Enabled = false;
                comboBoxAudioBitrates.Enabled = false;
            } 
            else
            {
                labelVBRMode.Enabled = false;
                comboBoxAudioVBRModes.Enabled = false;
                labelAudioBitrate.Enabled = true;
                comboBoxAudioBitrates.Enabled = true;
                comboBoxAudioBitrates.Enabled = audio.Bitrates.Length > 0;
                labelAudioBitrate.Enabled = comboBoxAudioBitrates.Enabled;
            }
        }

        private void InitAudioFilterSettings()
        {
            numericUpDownHighPass.ValueChanged -= new EventHandler(NumericUpDownHighPass_ValueChanged);
            numericUpDownHighPass.Value = audio.HighPass;
            numericUpDownHighPass.ValueChanged += new EventHandler(NumericUpDownHighPass_ValueChanged);

            numericUpDownLowPass.ValueChanged -= new EventHandler(NumericUpDownLowPass_ValueChanged);
            numericUpDownLowPass.Value = audio.LowPass;
            numericUpDownLowPass.ValueChanged += new EventHandler(NumericUpDownLowPass_ValueChanged);

            comboBoxResampler.SelectedIndexChanged -= new EventHandler(ComboBoxResampler_SelectedIndexChanged);
            comboBoxResampler = WinFormsHelper.AddMultiArrayToComboBox(comboBoxResampler, audio.Resamplers, audio.Resampler);
            comboBoxResampler.SelectedIndexChanged += new EventHandler(ComboBoxResampler_SelectedIndexChanged);

            comboBoxResampleDitherMethod.SelectedIndexChanged -= new EventHandler(ComboBoxResampleDitherMethod_SelectedIndexChanged);
            comboBoxResampleDitherMethod = WinFormsHelper.AddMultiArrayToComboBox(comboBoxResampleDitherMethod, audio.DitherMethods, audio.DitherMethod);
            comboBoxResampleDitherMethod.SelectedIndexChanged += new EventHandler(ComboBoxResampleDitherMethod_SelectedIndexChanged);

            numericUpDownResamplePrecision.ValueChanged -= new EventHandler(NumericUpDownResamplePrecision_ValueChanged);
            numericUpDownResamplePrecision.Value = audio.ResamplerPrecision;
            numericUpDownResamplePrecision.ValueChanged += new EventHandler(NumericUpDownResamplePrecision_ValueChanged);

            if (audio.Resampler == "soxr")
                EnableSoxSettings(true);
            else
                EnableSoxSettings(false);
        }

        private void InitAudioProfiles()
        {
            if (audio.Profiles.Length > 0)
            {
                comboBoxAudioCodecProfile.SelectedIndexChanged -= new EventHandler(ComboBoxAudioCodecProfile_SelectedIndexChanged);
                comboBoxAudioCodecProfile = WinFormsHelper.AddMultiArrayToComboBox(comboBoxAudioCodecProfile, audio.Profiles, audio.Profile);
                comboBoxAudioCodecProfile.SelectedIndexChanged -= new EventHandler(ComboBoxAudioCodecProfile_SelectedIndexChanged);
                labelAudioCodecProfile.Enabled = true;
                comboBoxAudioCodecProfile.Enabled = true;
            }
            else
            {
                comboBoxAudioCodecProfile.Items.Clear();
                labelAudioCodecProfile.Enabled = false;
                comboBoxAudioCodecProfile.Enabled = false;
            }
        }

        private void InitMetadata()
        {
            if (file.Format == "raw" | file.Format == "mpeg")
            {
                EnableTaggingControls(false);
            }
            else
            {
                EnableTaggingControls(true);

                switch (file.Format)
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
                        EnableBroadcastTagging(false);
                        break;
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
                        EnableBroadcastTagging(false);
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
                        EnableBroadcastTagging(false);
                        break;
                    case "mp3":
                    case "m4v":
                    case "flac":
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
                        EnableBroadcastTagging(false);
                        break;
                    default:
                        EnableAlbumTagging(true);
                        EnableAlbumArtistTagging(false);
                        EnableArtistTagging(true);
                        EnableCommentTagging(true);
                        EnableDiscTagging(false);
                        EnableGenreTaggin(true);
                        EnablePublisherTagging(true);
                        EnableTitleTagging(true);
                        EnableTrackTagging(false);
                        EnableYearTagging(true);
                        EnableBroadcastTagging(true);
                        break;
                }
            }
        }

        private void InitOptionsTab()
        {
            textBoxFFmpegBin.TextChanged -= new EventHandler(TextBoxFFmpegBin_TextChanged);
            textBoxFFmpegBin.Text = settings.FFmpegPath;
            textBoxFFmpegBin.TextChanged += new EventHandler(TextBoxFFmpegBin_TextChanged);

            textBoxTermBin.TextChanged -= new EventHandler(TextBoxTermBin_TextChanged);
            textBoxTermBin.Text = settings.TerminalPath;
            textBoxTermBin.TextChanged += new EventHandler(TextBoxTermBin_TextChanged);

            textBoxTermArgs.TextChanged -= new EventHandler(TextBoxTermArgs_TextChanged);
            textBoxTermArgs.Text = settings.TerminalArguments;
            textBoxTermArgs.TextChanged += new EventHandler(TextBoxTermArgs_TextChanged);

            textBoxBinArgs.TextChanged -= new EventHandler(TextBoxBinArgs_TextChanged);
            textBoxBinArgs.Text = settings.FFmpegArguments;
            textBoxBinArgs.TextChanged += new EventHandler(TextBoxBinArgs_TextChanged);

            textBoxDefaultSourceFolder.TextChanged -= new EventHandler(TextBoxDefaultSourceFolder_TextChanged);
            textBoxDefaultSourceFolder.Text = settings.DefaultSourceFolder;
            textBoxDefaultSourceFolder.TextChanged += new EventHandler(TextBoxDefaultSourceFolder_TextChanged);

            textBoxDefaultOutputFolder.TextChanged -= new EventHandler(TextBoxDefaultOutputFolder_TextChanged);
            textBoxDefaultOutputFolder.Text = settings.DefaultOutputFolder;
            textBoxDefaultOutputFolder.TextChanged += new EventHandler(TextBoxDefaultOutputFolder_TextChanged);

            checkBoxUrlFilenames.CheckedChanged -= new EventHandler(CheckBoxUrlFilenames_CheckedChanged);
            checkBoxUrlFilenames.Checked = settings.UrlFileNames;
            checkBoxUrlFilenames.CheckedChanged += new EventHandler(CheckBoxUrlFilenames_CheckedChanged);

            checkBoxWriteLog.CheckedChanged -= new EventHandler(CheckBoxWriteLog_CheckedChanged);
            checkBoxWriteLog.Checked = settings.WriteLog;
            checkBoxWriteLog.CheckedChanged += new EventHandler(CheckBoxWriteLog_CheckedChanged);
            textBoxLog.TextChanged -= new EventHandler(TextBoxLog_TextChanged);
            textBoxLog.Text = settings.LogFilename;
            textBoxLog.TextChanged += new EventHandler(TextBoxLog_TextChanged);
            EnableLogFileTextBox(settings.WriteLog);

            checkBoxPreferNonGPL.CheckedChanged -= new EventHandler(CheckBoxPreferNonGPL_CheckedChanged);
            checkBoxPreferNonGPL.Checked = settings.PreferNonFree;
            checkBoxPreferNonGPL.CheckedChanged += new EventHandler(CheckBoxPreferNonGPL_CheckedChanged);
        }

        //
        // Misc methods
        //
        private void ExitFFmpegCatapult()
        {
            if (settings.SaveSettings)
                settings.Save();

            System.Environment.Exit(0);
        }

        private void EnableFileOutputControls(bool enable)
        {
            labelOutputFilename.Enabled = enable;
            textBoxOutputFilename.Enabled = enable;
            checkBoxOverwrite.Enabled = enable;
        }

        private void EnableRatioControls(bool enable)
        {
            labelRatio.Enabled = enable;
            numericUpDownRatioA.Enabled = enable;
            labelRatioDash.Enabled = enable;
            numericUpDownRatioB.Enabled = enable;
        }

        private void EnableLayoutControls(bool enable)
        {
            labelLayoutColour.Enabled = enable;
            labelLayoutHeight.Enabled = enable;
            labelLayoutWidth.Enabled = enable;
            labelHoriz.Enabled = enable;
            labelVert.Enabled = enable;
            textBoxLayoutColour.Enabled = enable;
            numericUpDownLayoutHeight.Enabled = enable;
            numericUpDownLayoutWidth.Enabled = enable;
            numericUpDownLayoutHoriz.Enabled = enable;
            numericUpDownLayoutVert.Enabled = enable;
        }

        private void EnableResControls(bool enable)
        {
            numericUpDownHeight.Enabled = enable;
            numericUpDownWidth.Enabled = enable;
            comboBoxScalingMethods.Enabled = enable;
        }

        private void EnableCRFControls(bool enable)
        {
            if (enable)
            {
                labelCRF.Enabled = true;
                numericUpDownCRF.Enabled = true;
                labelVideoBitrate.Enabled = false;
                labelMaxBitrate.Enabled = false;
                labelMinBitrate.Enabled = false;                
                numericUpDownVideoBitrate.Enabled = false;
                numericUpDownVideoMaxBitrate.Enabled = false;
                numericUpDownVideoMinBitrate.Enabled = false;
            }
            else
            {
                labelVideoBitrate.Enabled = true;
                labelMaxBitrate.Enabled = true;
                labelMinBitrate.Enabled = true;                
                numericUpDownVideoBitrate.Enabled = true;
                numericUpDownVideoMaxBitrate.Enabled = true;
                numericUpDownVideoMinBitrate.Enabled = true;
                labelCRF.Enabled = false;
                numericUpDownCRF.Enabled = false;
            }
        }

        private void EnableVideoControls(bool enable)
        {
            checkBoxTwoPassEncoding.Enabled = enable;
            groupBoxVideoBitrate.Enabled = enable;
            groupBoxVideoEncoding.Enabled = enable;
        }

        private void EnableAudioControls(bool enable)
        {
            if (enable == true && audio.Codec == "copy" || audio.Codec == "pcm")
                groupBoxAudioBitrate.Enabled = false;
            else
                groupBoxAudioBitrate.Enabled = enable;

            labelAudioEncoder.Enabled = enable;
            comboBoxAudioEncoders.Enabled = enable;
            groupBoxAudioOutput.Enabled = enable;
        }

        private void EnableTaggingControls(bool enable)
        {
            groupBoxGeneralTags.Enabled = enable;
            groupBoxBroadcast.Enabled = enable;

            if (!enable)
                ClearMetadataFields();
        }

        private void EnableAlbumTagging(bool enable)
        {
            labelAlbum.Enabled = enable;
            textBoxAlbum.Enabled = enable;

            if (!enable)
                textBoxAlbum.Text = "";
        }

        private void EnableAlbumArtistTagging(bool enable)
        {
            labelAlbumArtist.Enabled = enable;
            textBoxAlbumArtist.Enabled = enable;
            checkBoxCompilation.Enabled = enable;

            if (!enable)
            {
                textBoxAlbumArtist.Text = "";
                checkBoxCompilation.Checked = false;
            }                
        }

        private void EnableArtistTagging(bool enable)
        {
            labelArtist.Enabled = enable;
            textBoxArtist.Enabled = enable;

            if (!enable)
                textBoxArtist.Text = "";
        }

        private void EnableCommentTagging(bool enable)
        {
            labelComment.Enabled = enable;
            textBoxComment.Enabled = enable;

            if (!enable)
                textBoxComment.Text = "";
        }

        private void EnableDiscTagging(bool enable)
        {
            labelDisc.Enabled = enable;
            labelOfDiscs.Enabled = enable;
            textBoxDisc.Enabled = enable;
            textBoxTotalDiscs.Enabled = enable;

            if (!enable)
            {
                textBoxDisc.Text = "";
                textBoxTotalDiscs.Text = "";
            }
        }

        private void EnableGenreTaggin(bool enable)
        {
            labelGenre.Enabled = enable;
            textBoxGenre.Enabled = enable;

            if (!enable)
                textBoxGenre.Text = "";
        }

        private void EnablePublisherTagging(bool enable)
        {
            labelPublisher.Enabled = enable;
            textBoxPublisher.Enabled = enable;

            if (!enable)
                textBoxPublisher.Text = "";
        }

        private void EnableTitleTagging(bool enable)
        {
            labelTitle.Enabled = enable;
            textBoxTitle.Enabled = enable;

            if (!enable)
                textBoxTitle.Text = "";
        }

        private void EnableTrackTagging(bool enable)
        {
            labelTrack.Enabled = enable;
            labelOfTrack.Enabled = enable;
            textBoxTrack.Enabled = enable;
            textBoxTotalTracks.Enabled = enable;

            if (!enable)
            {
                textBoxTrack.Text = "";
                textBoxTotalTracks.Text = "";
            }
        }

        private void EnableYearTagging(bool enable)
        {
            labelYear.Enabled = enable;
            textBoxYear.Enabled = enable;

            if (!enable)
                textBoxYear.Text = "";
        }

        private void EnableBroadcastTagging(bool enable)
        {
            groupBoxBroadcast.Enabled = enable;

            if (!enable)
            {
                textBoxShow.Text = "";
                textBoxDescription.Text = "";
                textBoxEpisodeId.Text = "";
                textBoxSynopsis.Text = "";
                textBoxNetwork.Text = "";
            }
        }

        private void EnableLogFileTextBox(bool enable)
        {
            textBoxLog.Enabled = enable;
        }

        private void EnableSoxSettings(bool enable)
        {
            labelResamplePrecision.Enabled = enable;
            labelDitherMethod.Enabled = enable;
            comboBoxResampleDitherMethod.Enabled = enable;
            numericUpDownResamplePrecision.Enabled = enable;
        }

        private int GetSelectionIndex(string value, string[,] values)
        {
            for (int i = 0; i < values.GetLength(0); i++)
            {
                if (value == values[i, 1])
                    return i;
            }

            return 0;
        }

        private void ClearMetadataFields()
        {
            checkBoxCompilation.Checked = false;
            textBoxAlbum.Text = "";
            textBoxAlbumArtist.Text = "";
            textBoxArtist.Text = "";
            textBoxComment.Text = "";
            textBoxDisc.Text = "";
            textBoxGenre.Text = "";
            textBoxTitle.Text = "";
            textBoxTotalDiscs.Text = "";
            textBoxTotalTracks.Text = "";
            textBoxTrack.Text = "";
            textBoxYear.Text = "";
            textBoxPublisher.Text = "";
            textBoxCopyright.Text = "";
            textBoxDescription.Text = "";
            textBoxSynopsis.Text = "";
            textBoxShow.Text = "";
            textBoxEpisodeId.Text ="";
            textBoxNetwork.Text = "";
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
            binFile.Filter = "Executable (*.exe)|*.exe|Any file (*.*)|*.*";
            binFile.ShowDialog();

            if (!string.IsNullOrEmpty(binFile.FileName))
                textBoxFFmpegBin.Text = binFile.FileName;
        }

        private void NewOutputFileName()
        {
            if (string.IsNullOrEmpty(textBoxOutputFilename.Text) && !string.IsNullOrEmpty(textBoxTargetFolder.Text))
            {
                string inFile = Path.GetFileName(textBoxInFile.Text);

                if (settings.UrlFileNames)
                    inFile = inFile.ToLower().Replace(" ", "_");

                textBoxOutputFilename.Text = Path.ChangeExtension(inFile, file.DefaultFileExtension);
            }
        }

        private void UpdateOutputFilename()
        {
            if (!string.IsNullOrEmpty(textBoxOutputFilename.Text))
            {
                textBoxOutputFilename.Text = Path.ChangeExtension(textBoxOutputFilename.Text, file.DefaultFileExtension);
            }
        }

        private void UpdateOutputFilePath()
        {
            if (!string.IsNullOrEmpty(textBoxTargetFolder.Text) && !string.IsNullOrEmpty(textBoxOutputFilename.Text))
            {
                paths.Output = Path.Combine(textBoxTargetFolder.Text, textBoxOutputFilename.Text);
                buttonRun.Enabled = !string.IsNullOrEmpty(textBoxInFile.Text);
            }
            else
            {
                paths.Output = null;
                buttonRun.Enabled = false;
            }
        }

        //
        // Event handlers
        //
        private void MainForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.FFmpegCatapult;
            InitTabs();

            // Main tab
            textBoxTargetFolder.Text = settings.DefaultOutputFolder;
            comboBoxContainers = WinFormsHelper.AddMultiArrayToComboBox(comboBoxContainers, ContainerFactory.Containers, file.Format);

            // Populate combobox with parsed XML files and preset names
            string presetFolder = Path.Combine(Directory.GetCurrentDirectory(), "Presets");
            string xmlPath = Directory.Exists(presetFolder) ? presetFolder : Directory.GetCurrentDirectory();
            string[] presetFiles = Directory.GetFiles(xmlPath, "*.xml");

            foreach (string file in presetFiles)
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
                            comboBoxPresets.Items.Add(new WinFormsHelper.ListComboContent(title, file));
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

            if (settings.KeepValues == true)
            {
                radioButtonKeep.CheckedChanged -= new EventHandler(RadioButtonKeep_CheckedChanged);
                radioButtonKeep.Checked = true;
                radioButtonKeep.CheckedChanged += new EventHandler(RadioButtonKeep_CheckedChanged);
            }
            else
            {
                radioButtonRefresh.CheckedChanged -= new EventHandler(RadioButtonRefresh_CheckedChanged);
                radioButtonRefresh.Checked = true;
                radioButtonRefresh.CheckedChanged += new EventHandler(RadioButtonRefresh_CheckedChanged);
            }

            checkBoxOverwrite.CheckedChanged -= new EventHandler(CheckBoxOverwrite_CheckedChanged);
            checkBoxOverwrite.Checked = paths.Overwrite;
            checkBoxOverwrite.CheckedChanged += new EventHandler(CheckBoxOverwrite_CheckedChanged);

            InitMain();
            InitOutput();

            // Picture tab
            comboBoxScalingMethods.SelectedIndexChanged -= new EventHandler(ComboBoxScalingMethods_SelectedIndexChanged);
            comboBoxScalingMethods = WinFormsHelper.AddMultiArrayToComboBox(comboBoxScalingMethods, picture.ScalingMethods, picture.ScalingMethod);
            comboBoxScalingMethods.SelectedIndexChanged += new EventHandler(ComboBoxScalingMethods_SelectedIndexChanged);

            InitPicture();

            // Video tab
            InitVideo();

            // Audio tab
            InitAudio();

            // Options
            InitOptionsTab();

            // Metadata tab
            InitMetadata();

            // Ensure that path for ffmpeg is set correctly
            if (!File.Exists(settings.FFmpegPath))
            {
                MessageBox.Show("Please set path of where you have ffmpeg installed.", "FFmpeg Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BrowseFFmpegBin();
                BringToFront();
                TopMost = true;
            }
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
            if (System.IO.File.Exists(settings.FFmpegPath))
            {
                ffmpegBin.Run(file, audio, video, picture, paths, settings);

                if (!settings.KeepValues)
                {
                    textBoxInFile.Text = "";
                    textBoxAudioStream.Text = "";
                    textBoxOutputFilename.Text = "";
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

        //
        // Main tab event handlers
        //
        private void TextBoxInFile_TextChanged(object sender, EventArgs e)
        {
            paths.Source = textBoxInFile.Text;
            NewOutputFileName();
            EnableFileOutputControls(!string.IsNullOrEmpty(textBoxInFile.Text));
        }

        private void TextBoxTargetFolder_TextChanged(object sender, EventArgs e)
        {
            UpdateOutputFilePath();
        }

        private void TextBoxOutputFilename_TextChanged(object sender, EventArgs e)
        {
            UpdateOutputFilePath();
        }

        private void ButtonBrowseInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog inFile = new OpenFileDialog();
            inFile.Title = "Locate Main Input File";
            inFile.Filter = "Video files|*.asf;*.avi;*.flv;*.m4v;*.mkv;*.mp4;*.mpeg;*.mpg;*.mov;*.ogv;*.webm;*.wmv;*.y4m|"
                          + "Audio files|*.aac;*.ac3;*.adts;*.ape;*.flac;*.m4a;*.mp3;*.mpc;*.ogg;*.snd;*.vox;*.w64;*.wav;*.wma;*.wv|"
                          + "Any file (*.*)|*.*";

            if (string.IsNullOrEmpty(settings.DefaultSourceFolder))
                inFile.InitialDirectory = settings.DefaultSourceFolder;
            
            DialogResult result = inFile.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrEmpty(inFile.FileName))
                textBoxInFile.Text = inFile.FileName;
        }

        void ButtonBrowseAudioStream_Click(object sender, EventArgs e)
        {
            OpenFileDialog audioFile = new OpenFileDialog();
            audioFile.Title = "Locate Audio Stream File";
            audioFile.Filter = "Audio files|*.aac;*.ac3;*.adts;*.ape;*.flac;*.m4a;*.mp3;*.mpc;*.ogg;*.snd;*.vox;*.w64;*.wav;*.wma;*.wv|"
                             + "Any file (*.*)|*.*";
            
            audioFile.ShowDialog();

            if (!string.IsNullOrEmpty(audioFile.FileName))
                textBoxAudioStream.Text = audioFile.FileName;
        }

        void TextBoxAudioStream_TextChanged(object sender, EventArgs e)
        {
            paths.Audio = textBoxAudioStream.Text;
        }

        private void ButtonBrowseTargetFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog targetDir = new FolderBrowserDialog();
            targetDir.ShowDialog();

            if (!string.IsNullOrEmpty(targetDir.SelectedPath))
                textBoxTargetFolder.Text = targetDir.SelectedPath;
        }

        void TextBoxInFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        void TextBoxInFile_DragDrop(object sender, DragEventArgs e)
        {
            String[] file = (String[])e.Data.GetData(DataFormats.FileDrop);
            if (file != null && file.Length != 0)
            {
                textBoxInFile.Text = file[0];
                textBoxTargetFolder.Text = file[0];
            }
        }

        void CheckBoxOverwrite_CheckedChanged(object sender, EventArgs e)
        {
            paths.Overwrite = checkBoxOverwrite.Checked;
        }

        private void CheckBoxFastStartTagging_CheckedChanged(object sender, EventArgs e)
        {
            file.FastStartTagging = checkBoxFastStartTagging.Checked;
        }

        void ComboBoxContainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormsHelper.ListComboContent format = (WinFormsHelper.ListComboContent)comboBoxContainers.SelectedItem;

            if (format.Value != file.Format)
            {
                file = ContainerFactory.Create(format.Value);

                if (!file.IsCodecSupported(audio))
                    audio = AudioFactory.Create(file.SupportedAudioCodecs[0, 1]);

                if (!file.IsCodecSupported(video))
                    video = VideoFactory.Create(file.SupportedVideoCodecs[0, 1]);

                if (!string.IsNullOrEmpty(textBoxOutputFilename.Text))
                    textBoxOutputFilename.Text = Path.ChangeExtension(textBoxOutputFilename.Text, file.DefaultFileExtension);

                InitTabs();
                InitOutput();
                InitAudio();
                InitVideo();
                InitMetadata();
            }
        }

        void ComboBoxPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormsHelper.ListComboContent preset = (WinFormsHelper.ListComboContent)comboBoxPresets.SelectedItem;
            InitPreset(preset.Name, preset.Value);
            InitTabs();
            InitOutput();
            InitMain();
            InitPicture();
            InitVideo();
            InitAudio();
            InitMetadata();
            UpdateOutputFilename();
        }

        private void ComboBoxAudioVBRModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            audio.Quality = Convert.ToInt32(comboBoxAudioVBRModes.Text);
        }

        private void NumericUpDownThreads_ValueChanged(object sender, EventArgs e)
        {
            settings.Threads = (int)numericUpDownThreads.Value;
        }

        private void NumericUpDownProcessors_ValueChanged(object sender, EventArgs e)
        {
            settings.Processors = (int)numericUpDownProcessors.Value;
        }

        void RadioButtonKeep_CheckedChanged(object sender, EventArgs e)
        {
            settings.KeepValues = radioButtonKeep.Checked;
        }

        void RadioButtonRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRefresh.Checked)
                settings.KeepValues = false;
        }
    
        //
        // Video tab events
        //
        void ComboBoxVideoCodecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormsHelper.ListComboContent codec = (WinFormsHelper.ListComboContent)comboBoxVideoCodecs.SelectedItem;
            if (codec.Value != video.Codec)
            {
                //video.Codec = codec.Value;
                video = VideoFactory.Create(codec.Value);
                InitTabs();
                InitVideo();
            }
        }

        void ComboBoxVideoEncoders_SelectedIndexChanged(object sender, EventArgs e)
        {
            video.Encoder = WinFormsHelper.GetSelectedValueFromArrayComboBox(comboBoxVideoEncoders);
            InitVideoEncoderSettings();
        }

        private void ComboBoxVCodecProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            video.Profile = WinFormsHelper.GetSelectedValueFromArrayComboBox(comboBoxVCodecProfile);
        }

        private void ComboBoxVideoEncoderPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            video.EncoderPreset = WinFormsHelper.GetSelectedValueFromArrayComboBox(comboBoxVideoEncoderPresets);
        }

        private void ComboBoxVideoCodecLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = Convert.ToString(comboBoxVideoCodecLevels.SelectedItem);
            video.CodecLevel = double.TryParse(selected, out double level) ? level : 1.0;
        }

        private void ComboBoxMEMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            video.MotionEstimateMethod = WinFormsHelper.GetSelectedValueFromArrayComboBox(comboBoxMEMethod);
        }

        private void ComboBoxPixelFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            video.PixelFormat = WinFormsHelper.GetSelectedValueFromArrayComboBox(comboBoxPixelFormat);
        }

        void CheckBoxTwoPassEncoding_CheckedChanged(object sender, EventArgs e)
        {
            video.TwoPassEncoding = checkBoxTwoPassEncoding.Checked;
            if (video.TwoPassEncoding)
            {
                checkBoxUseCRF.Enabled = false;
                EnableCRFControls(false);
            }
            else
            {
                checkBoxUseCRF.Enabled = true;
                EnableCRFControls(video.UseCRF);
            }
        }

        void CheckBoxUseCRF_CheckedChanged(object sender, EventArgs e)
        {
            video.UseCRF = checkBoxUseCRF.Checked;
            EnableCRFControls(video.UseCRF);
        }

        private void NumericUpDownVideoBitrate_ValueChanged(object sender, EventArgs e)
        {
            video.Bitrate = (int)numericUpDownVideoBitrate.Value;
        }

        private void NumericUpDownVideoMaxBitrate_ValueChanged(object sender, EventArgs e)
        {
            video.MaxBitrate = (int)numericUpDownVideoMaxBitrate.Value;
        }

        private void NumericUpDownVideoMinBitrate_ValueChanged(object sender, EventArgs e)
        {
            video.MinBitrate = (int)numericUpDownVideoMinBitrate.Value;
        }

        private void NumericUpDownCRF_ValueChanged(object sender, EventArgs e)
        {
            video.Quality = (int)numericUpDownCRF.Value;
        }

        private void NumericUpDownQMin_ValueChanged(object sender, EventArgs e)
        {
            video.QMin = (int)numericUpDownQMin.Value;
        }

        private void NumericUpDownQMax_ValueChanged(object sender, EventArgs e)
        {
            video.QMax = (int)numericUpDownQMax.Value;
        }

        private void NumericUpDownBufferSize_ValueChanged(object sender, EventArgs e)
        {
            video.BufferSize = (int)numericUpDownBufferSize.Value;
        }

        private void NumericUpDownTargetSize_ValueChanged(object sender, EventArgs e)
        {
            video.TargetSize = (int)numericUpDownTargetSize.Value;
        }

        private void NumericUpDownGOPSize_ValueChanged(object sender, EventArgs e)
        {
            video.GOPSize = (int)numericUpDownGOPSize.Value;
        }

        private void NumericUpDownDiaSize_ValueChanged(object sender, EventArgs e)
        {
            video.DiaSize = (int)numericUpDownDiaSize.Value;
        }

        private void NumericUpDownBFrames_ValueChanged(object sender, EventArgs e)
        {
            video.BFrames = (int)numericUpDownBFrames.Value;
        }

        private void NumericUpDownBFStrat_ValueChanged(object sender, EventArgs e)
        {
            video.BFStrategy = (int)numericUpDownBFStrat.Value;
        }

        private void NumericUpDownTileRows_ValueChanged(object sender, EventArgs e)
        {
            video.TileRows = (int)numericUpDownTileRows.Value;
        }

        private void NumericUpDownTileColumns_ValueChanged(object sender, EventArgs e)
        {
            video.TileColumns = (int)numericUpDownTileColumns.Value;
        }

        private void NumericUpDownTrellis_ValueChanged(object sender, EventArgs e)
        {
            video.Trellis = (int)numericUpDownTrellis.Value;
        }

        private void NumericUpDownMECmp_ValueChanged(object sender, EventArgs e)
        {
            video.MotionEstimateCompare = (int)numericUpDownMECmp.Value;
        }

        private void NumericUpDownMEPreCmp_ValueChanged(object sender, EventArgs e)
        {
            video.MotionEstimatePreCompare = (int)numericUpDownMEPreCmp.Value;
        }

        private void NumericUpDownMESubCmp_ValueChanged(object sender, EventArgs e)
        {
            video.MacroBlockingCompare = (int)numericUpDownMBCmp.Value;
        }

        private void NumericUpDownMBCmp_ValueChanged(object sender, EventArgs e)
        {
            video.MacroBlockingCompare = (int)numericUpDownMBCmp.Value;
        }

        //
        // Audio tab events
        //
        void ComboBoxAudioCodecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormsHelper.ListComboContent codec = (WinFormsHelper.ListComboContent)comboBoxAudioCodecs.SelectedItem;
            if (codec.Value != audio.Codec)
            {
                audio = AudioFactory.Create(codec.Value);
                InitAudio();
            }
        }

        private void ComboBoxAudioCodecProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            audio.Profile = WinFormsHelper.GetSelectedValueFromArrayComboBox(comboBoxAudioCodecProfile);
        }

        void ComboBoxAudioEncoders_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormsHelper.ListComboContent encoder = (WinFormsHelper.ListComboContent)comboBoxAudioEncoders.SelectedItem;
            if (encoder.Value != audio.Encoder)
            {
                audio.Encoder = encoder.Value;
                InitAudioProfiles();
                InitAudioBitrates();
            }
        }

        void ComboBoxSampleRates_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormsHelper.ListComboContent sampleRate = (WinFormsHelper.ListComboContent)comboBoxSampleRates.SelectedItem;
            if (sampleRate.X != audio.SampleRate)
            {
                audio.SampleRate = sampleRate.X;
                InitAudioBitrates();
            }
        }

        void ComboBoxChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormsHelper.ListComboContent channels = (WinFormsHelper.ListComboContent)comboBoxChannels.SelectedItem;
            if (channels.X != audio.Channels)
            {
                audio.Channels = channels.X;
            }
        }

        void CheckBoxUseAudioVBR_CheckedChanged(object sender, EventArgs e)
        {
            audio.UseVBR = checkBoxUseAudioVBR.Checked;
            InitAudioBitrates();
        }

        void ComboBoxAudioBitrates_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormsHelper.ListComboContent bitrate = (WinFormsHelper.ListComboContent)comboBoxAudioBitrates.SelectedItem;

            if (audio.UseVBR == true)
            {
                audio.Quality = bitrate.X;
            }
            else
            {
                audio.Bitrate = bitrate.X;
            }
        }

        private void NumericUpDownVolumeBoost_ValueChanged(object sender, EventArgs e)
        {
            audio.VolumeBoost = (int)numericUpDownVolumeBoost.Value;
        }

        private void NumericUpDownHighPass_ValueChanged(object sender, EventArgs e)
        {
            audio.HighPass = (int)numericUpDownHighPass.Value;
        }

        private void NumericUpDownLowPass_ValueChanged(object sender, EventArgs e)
        {
            audio.LowPass = (int)numericUpDownLowPass.Value;
        }

        private void NumericUpDownResamplePrecision_ValueChanged(object sender, EventArgs e)
        {
            audio.ResamplerPrecision = (int)numericUpDownResamplePrecision.Value;
        }

        private void ComboBoxResampler_SelectedIndexChanged(object sender, EventArgs e)
        {
            audio.Resampler = WinFormsHelper.GetSelectedValueFromArrayComboBox(comboBoxResampler);
            InitAudioFilterSettings();
        }

        private void ComboBoxResampleDitherMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            audio.DitherMethod = WinFormsHelper.GetSelectedValueFromArrayComboBox(comboBoxResampleDitherMethod);
        }

        //
        // Picture tab events
        //
        void RadioButtonKeepRes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKeepRes.Checked == true)
            {
                picture.ScaleOption = 0;
                EnableResControls(false);
            }
        }

        void RadioButtonCustomRes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCustomRes.Checked == true)
            {
                picture.ScaleOption = 1;
                EnableResControls(true);
            }
        }

        void RadioButtonHalfRes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHalfRes.Checked == true)
            {
                picture.ScaleOption = 2;
                EnableResControls(false);
            }
        }

        void CheckBoxAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            picture.AspectRatio = checkBoxAspectRatio.Checked;
            EnableRatioControls(picture.AspectRatio);
        }

        void CheckBoxCrop_CheckedChanged(object sender, EventArgs e)
        {
            picture.Crop = checkBoxCrop.Checked;
            EnableLayoutControls(picture.Crop);
        }

        void CheckBoxDeinterlace_CheckedChanged(object sender, EventArgs e)
        {
            picture.Deinterlace = checkBoxDeinterlace.Checked;
        }

        void CheckBoxPad_CheckedChanged(object sender, EventArgs e)
        {
            picture.Pad = checkBoxPad.Checked;
            EnableLayoutControls(picture.Pad);
        }

        void ComboBoxScalingMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormsHelper.ListComboContent scalingMethod = (WinFormsHelper.ListComboContent)comboBoxScalingMethods.SelectedItem;
            picture.ScalingMethod = scalingMethod.Value;
        }

        private void NumericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            picture.Width = (int)numericUpDownWidth.Value;
        }

        private void NumericUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            picture.Height = (int)numericUpDownHeight.Value;
        }

        private void NumericUpDownFPS_ValueChanged(object sender, EventArgs e)
        {
            picture.FPS = (int)numericUpDownFPS.Value;
        }

        private void NumericUpDownLayoutWidth_ValueChanged(object sender, EventArgs e)
        {
            picture.WinWidth = (int)numericUpDownLayoutWidth.Value;
        }

        private void NumericUpDownLayoutHeight_ValueChanged(object sender, EventArgs e)
        {
            picture.WinHeight = (int)numericUpDownLayoutHeight.Value;
        }

        private void NumericUpDownLayoutVert_ValueChanged(object sender, EventArgs e)
        {
            picture.X = (int)numericUpDownLayoutVert.Value;
        }

        private void NumericUpDownLayoutHoriz_ValueChanged(object sender, EventArgs e)
        {
            picture.Y = (int)numericUpDownLayoutHoriz.Value;
        }

        private void NumericUpDownRatio_ValueChanged(object sender, EventArgs e)
        {
            picture.Ratio = string.Format("{0}:{1}", numericUpDownRatioA.Value, numericUpDownRatioB.Value);
        }

        private void TextBoxLayoutColour_TextChanged(object sender, EventArgs e)
        {
            picture.VideoFilterColour = textBoxLayoutColour.Text;
        }

        //
        // Tagging tab events
        //
        void TextBoxAlbum_TextChanged(object sender, EventArgs e)
        {
            file.Album = textBoxAlbum.Text;
        }

        void TextBoxAlbumArtist_TextChanged(object sender, EventArgs e)
        {
            file.AlbumArtist = textBoxAlbumArtist.Text;
        }

        void TextBoxArtist_TextChanged(object sender, EventArgs e)
        {
            file.Artist = textBoxArtist.Text;
        }

        void TextBoxComment_TextChanged(object sender, EventArgs e)
        {
            file.Comment = textBoxComment.Text;
        }

        void TextBoxDisc_TextChanged(object sender, EventArgs e)
        {
            file.Disc = int.TryParse(textBoxDisc.Text, out int disc) ? disc : 0;
        }

        void TextBoxGenre_TextChanged(object sender, EventArgs e)
        {
            file.Genre = textBoxGenre.Text;
        }

        void TextBoxTitle_TextChanged(object sender, EventArgs e)
        {
            file.Title = textBoxTitle.Text;
        }

        void TextBoxTotalDiscs_TextChanged(object sender, EventArgs e)
        {
            file.Disc = int.TryParse(textBoxTotalDiscs.Text, out int totalDiscs) ? totalDiscs : 0;
        }

        void TextBoxTotalTracks_TextChanged(object sender, EventArgs e)
        {
            file.TotalTracks = int.TryParse(textBoxTotalTracks.Text, out int totalTracks) ? totalTracks : 0;
        }

        void TextBoxTrack_TextChanged(object sender, EventArgs e)
        {
            file.Track = int.TryParse(textBoxTrack.Text, out int track) ? track : 0;
        }

        void TextBoxYear_TextChanged(object sender, EventArgs e)
        {
            file.Year = int.TryParse(textBoxYear.Text, out int year) ? year : 0;
        }

        private void CheckBoxCompilation_CheckedChanged(object sender, EventArgs e)
        {
            file.Compilation = checkBoxCompilation.Checked;
        }

        private void TextBoxPublisher_TextChanged(object sender, EventArgs e)
        {
            file.Publisher = textBoxPublisher.Text;
        }

        private void TextBoxCopyright_TextChanged(object sender, EventArgs e)
        {
            file.Copyright = textBoxCopyright.Text;
        }

        private void TextBoxShow_TextChanged(object sender, EventArgs e)
        {
            file.Show = textBoxShow.Text;
        }

        private void TextBoxEpisodeId_TextChanged(object sender, EventArgs e)
        {
            file.EpisodeId = textBoxEpisodeId.Text;
        }

        private void TextBoxNetwork_TextChanged(object sender, EventArgs e)
        {
            file.Network = textBoxNetwork.Text;
        }

        private void TextBoxDescription_TextChanged(object sender, EventArgs e)
        {
            file.Description = textBoxDescription.Text;
        }

        private void TextBoxSynopsis_TextChanged(object sender, EventArgs e)
        {
            file.Synopsis = textBoxSynopsis.Text;
        }

        //
        // Options tab events
        //
        void TextBoxFFmpegBin_TextChanged(object sender, EventArgs e)
        {
            settings.FFmpegPath = textBoxFFmpegBin.Text;
            EnableBinArgsControls(!string.IsNullOrEmpty(textBoxFFmpegBin.Text));
            settings.SaveSettings = true;
        }

        void TextBoxTermBin_TextChanged(object sender, EventArgs e)
        {
            settings.TerminalPath = textBoxTermBin.Text;
            EnableTermArgsControls(!string.IsNullOrEmpty(textBoxTermBin.Text));
            settings.SaveSettings = true;
        }

        void TextBoxBinArgs_TextChanged(object sender, EventArgs e)
        {
            settings.FFmpegArguments = textBoxBinArgs.Text;
            settings.SaveSettings = true;
        }

        void TextBoxTermArgs_TextChanged(object sender, EventArgs e)
        {
            settings.TerminalArguments = textBoxTermArgs.Text;
            settings.SaveSettings = true;
        }

        void TextBoxLog_TextChanged(object sender, EventArgs e)
        {
            settings.LogFilename = textBoxLog.Text;
            settings.SaveSettings = true;
        }

        void ButtonBrowseFFmpegBin_Click(object sender, EventArgs e)
        {
            settings.SaveSettings = true;
            BrowseFFmpegBin();
        }

        void CheckBoxWriteLog_CheckedChanged(object sender, EventArgs e)
        {
            settings.WriteLog = checkBoxWriteLog.Checked;
            EnableLogFileTextBox(settings.WriteLog);
            settings.SaveSettings = true;
        }

        void ButtonBrowseTermBin_Click(object sender, EventArgs e)
        {
            OpenFileDialog termBinFile = new OpenFileDialog();
            termBinFile.Title = "Locate Terminal Emulator";
            termBinFile.Filter = "Executable (*.exe)|*.exe|Any file (*.*)|*.*";
            termBinFile.ShowDialog();

            if (!string.IsNullOrEmpty(termBinFile.FileName))
                textBoxTermBin.Text = termBinFile.FileName;
        }

        private void TextBoxDefaultSourceFolder_TextChanged(object sender, EventArgs e)
        {
            settings.DefaultSourceFolder = textBoxDefaultSourceFolder.Text;
            settings.SaveSettings = true;
        }

        private void TextBoxDefaultOutputFolder_TextChanged(object sender, EventArgs e)
        {
            settings.DefaultOutputFolder = textBoxDefaultOutputFolder.Text;
            settings.SaveSettings = true;

            if (string.IsNullOrEmpty(textBoxTargetFolder.Text) & !string.IsNullOrEmpty(settings.DefaultOutputFolder))
                textBoxTargetFolder.Text = settings.DefaultOutputFolder;
        }

        private void CheckBoxUrlFilenames_CheckedChanged(object sender, EventArgs e)
        {
            settings.UrlFileNames = checkBoxUrlFilenames.Checked;
            settings.SaveSettings = true;
        }

        private void ButtonBrowseDefaultInputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sourceFolderDialog = new FolderBrowserDialog();
            DialogResult result = sourceFolderDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrEmpty(sourceFolderDialog.SelectedPath))
                textBoxDefaultSourceFolder.Text = sourceFolderDialog.SelectedPath;
        }

        private void ButtonBrowseDefaultOutputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog outputFolderDialog = new FolderBrowserDialog();
            DialogResult result = outputFolderDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrEmpty(outputFolderDialog.SelectedPath))
                textBoxDefaultOutputFolder.Text = outputFolderDialog.SelectedPath;
        }

        private void CheckBoxPreferNonGPL_CheckedChanged(object sender, EventArgs e)
        {
            settings.PreferNonFree = checkBoxPreferNonGPL.Checked;
            settings.SaveSettings = true;
        }
    }
}