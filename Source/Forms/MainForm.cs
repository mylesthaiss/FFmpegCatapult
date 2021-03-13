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

namespace FFmpegCatapult
{
    public partial class MainForm : Form
    {
        private FFmpegBin ffmpegBin = new FFmpegBin();
        private Settings settings = new Settings();
        private FilePaths paths = new FilePaths();
        private FileFormat file = new FileFormat();
        private Audio audio = new Audio();
        private Video video = new Video();
        private Picture picture = new Picture();
        private Tags tags = new Tags();

        public MainForm()
        {
            settings.Load();
            InitializeComponent();
        }

        // Methods
        private void InitPreset(string presetName, string xmlFile)
        {
            file = new FileFormat(xmlFile, presetName);
            video = new Video(xmlFile, presetName);
            audio = new Audio(xmlFile, presetName);
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
            comboBoxContainers.SelectedIndex = GetSelectionIndex(file.Format, file.Formats);
            comboBoxContainers.SelectedIndexChanged += new EventHandler(ComboBoxContainers_SelectedIndexChanged);

            // Text boxes
            if (textBoxTargetFolder.Text != "")
            {
                textBoxTargetFolder.TextChanged -= new EventHandler(TextBoxTargetFolder_TextChanged);
                paths.Output = textBoxTargetFolder.Text;
                textBoxTargetFolder.Text = paths.Output;
                textBoxTargetFolder.TextChanged += new EventHandler(TextBoxTargetFolder_TextChanged);
            }
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
            numericUpDownRatioA.ValueChanged -= new EventHandler(NumericUpDownRatio_ValueChanged);
            numericUpDownRatioB.ValueChanged -= new EventHandler(NumericUpDownRatio_ValueChanged);
            string[] ratioValues = picture.Ratio.Split(':');
            numericUpDownRatioA.Value = Convert.ToInt32(ratioValues[0]);
            numericUpDownRatioB.Value = Convert.ToInt32(ratioValues[1]);
            numericUpDownRatioA.ValueChanged += new EventHandler(NumericUpDownRatio_ValueChanged);
            numericUpDownRatioB.ValueChanged += new EventHandler(NumericUpDownRatio_ValueChanged);
        }

        private void InitVideo()
        {
            if (video.Codec == "copy" | video.Codec == "none")
            {
                EnableVideoControls(false);
            }
            else
            {
                EnableVideoControls(true);
            }

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

            // Other items
            InitVideoEncoderSettings();
        }

        private void InitVideoEncoderSettings()
        {
            if (video.Profiles != null)
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

            if (video.CodecLevels != null)
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

            if (video.EncoderPresets != null)
            {                
                comboBoxVideoEncoderPresets.SelectedIndexChanged -= new EventHandler(ComboBoxVideoEncoders_SelectedIndexChanged);
                comboBoxVideoEncoderPresets = WinFormsHelper.AddMultiArrayToComboBox(comboBoxVideoEncoderPresets, video.EncoderPresets, video.EncoderPreset);
                comboBoxVideoEncoderPresets.SelectedIndexChanged += new EventHandler(ComboBoxVideoEncoders_SelectedIndexChanged);
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
            if (audio.Codec == "copy" | audio.Codec == "none")
            {
                EnableAudioControls(false);
            }
            else
            {
                EnableAudioControls(true);
            }

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
            {
                comboBoxChannels.SelectedIndex = audio.Channels - 1;
            }
            comboBoxChannels.SelectedIndexChanged += new EventHandler(ComboBoxChannels_SelectedIndexChanged);

            // Other items
            InitAudioProfiles();
            InitAudioBitrates();
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
            }
        }

        private void InitAudioProfiles()
        {
            if (audio.Profiles != null)
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
            if (file.Format == "raw" | file.Format == "mpg")
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

        //
        // Misc methods
        //
        private void ExitFFmpegCatapult()
        {
            if (settings.SaveSettings == true)
            {
                settings.Save();
            }

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
            if (enable == true)
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
            {
                groupBoxAudioBitrate.Enabled = false;
            }
            else
            {
                groupBoxAudioBitrate.Enabled = enable;
            }

            labelAudioEncoder.Enabled = enable;
            comboBoxAudioEncoders.Enabled = enable;
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

        private int GetSelectionIndex(string value, string[,] values)
        {
            for (int i = 0; i < values.GetLength(0); i++)
            {
                if (value == values[i, 1])
                {
                    return i;
                }
            }

            return 0;
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

        private void NewOutputFileName()
        {
            if (string.IsNullOrEmpty(textBoxOutputFilename.Text) && !string.IsNullOrEmpty(textBoxTargetFolder.Text))
            {
                string inFile = Path.GetFileName(textBoxOutputFilename.Text);
                textBoxOutputFilename.Text = Path.ChangeExtension(inFile, file.Format);
            }
        }

        private void UpdateOutputFilename()
        {
            if (!string.IsNullOrEmpty(textBoxOutputFilename.Text))
            {
                textBoxOutputFilename.Text = Path.ChangeExtension(textBoxOutputFilename.Text, file.Format);
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
            //if (paths.Source != null)
            //{
            //    textBoxInFile.Text = paths.Source;
            //    buttonBrowseInput.Enabled = true;
            //}
            textBoxInFile.DragDrop += new DragEventHandler(TextBoxInFile_DragDrop);
            textBoxInFile.DragEnter += new DragEventHandler(TextBoxInFile_DragEnter);
            textBoxInFile.TextChanged += new EventHandler(TextBoxInFile_TextChanged);
            buttonBrowseInput.Click += new EventHandler(ButtonBrowseInput_Click);

            //if (paths.Output != null)
            //{
            //    textBoxOutFile.Text = paths.Output;
            //}
            textBoxTargetFolder.TextChanged += new EventHandler(TextBoxTargetFolder_TextChanged);
            buttonBrowseOutput.Click += new EventHandler(ButtonBrowseTargetFolder_Click);
            comboBoxContainers = WinFormsHelper.AddMultiArrayToComboBox(comboBoxContainers, file.Formats, file.Format);

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

            comboBoxPresets.SelectedIndexChanged += new EventHandler(ComboBoxPresets_SelectedIndexChanged);

            if (settings.KeepValues == true)
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

            checkBoxOverwrite.Checked = paths.Overwrite;
            checkBoxOverwrite.CheckedChanged += new EventHandler(CheckBoxOverwrite_CheckedChanged);

            this.FormClosing += MainForm_Closing;
            buttonExit.Click += new EventHandler(ButtonExit_Click);
            buttonRun.Click += new EventHandler(ButtonRun_Click);

            // Streams
            textBoxAudioStream.TextChanged += new EventHandler(TextBoxAudioStream_TextChanged);
            buttonBrowseAudioStream.Click += new EventHandler(ButtonBrowseAudioStream_Click);

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
            if (settings.FFmpegPath != null)
            {
                textBoxFFmpegBin.Text = settings.FFmpegPath;
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

            textBoxBinArgs -= new EventHandler(TextBoxBinArgs_TextChanged);
            textBoxBinArgs.Text = settings.FFmpegArguments;
            textBoxBinArgs += new EventHandler(TextBoxBinArgs_TextChanged);

            if (settings.TerminalPath != null)
            {
                textBoxTermBin.Text = settings.TerminalPath;
                EnableTermArgsControls(true);
            }
            else
            {
                EnableTermArgsControls(false);
            }
            textBoxTermBin.TextChanged += new EventHandler(TextBoxTermBin_TextChanged);
            buttonBrowseTermBin.Click += new EventHandler(ButtonBrowseTermBin_Click);

            if (settings.TerminalArguments != null)
            {
                //textBoxBinArgs.Text = ffmpeg.;
            }
            textBoxBinArgs.TextChanged += new EventHandler(TextBoxBinArgs_TextChanged);

            if (settings.TerminalArguments != null)
            {
                textBoxTermArgs.Text = settings.TerminalArguments;
            }
            textBoxTermArgs.TextChanged += new EventHandler(TextBoxTermArgs_TextChanged);

            checkBoxWriteLog.Checked = settings.WriteLog;
            checkBoxWriteLog.CheckedChanged += new EventHandler(CheckBoxWriteLog_CheckedChanged);
            EnableLogFileTextBox(settings.WriteLog);
            textBoxLog.Text = settings.LogFilename;
            textBoxLog.TextChanged += new EventHandler(TextBoxLog_TextChanged);

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
            if (System.IO.File.Exists(settings.FFmpegPath))
            {
                ffmpegBin.Run(file, audio, video, picture, tags, paths, settings);

                if (settings.KeepValues == false)
                {
                    textBoxInFile.Text = "";
                    textBoxTargetFolder.Text = "";
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
                if (e.KeyChar != '.')
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
                if (e.KeyChar != '.')
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }
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
            inFile.ShowDialog();
            inFile.Filter = "Any file (*.*) | *.*";

            if (inFile.FileName != "")
            {
                textBoxInFile.Text = inFile.FileName;
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
            paths.Audio = textBoxAudioStream.Text;
        }

        private void ButtonBrowseTargetFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog targetDir = new FolderBrowserDialog();
            targetDir.ShowDialog();

            if (!string.IsNullOrEmpty(targetDir.SelectedPath))
            {
                textBoxTargetFolder.Text = targetDir.SelectedPath;
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
                textBoxTargetFolder.Text = file[0];
            }
        }

        void CheckBoxOverwrite_CheckedChanged(object sender, EventArgs e)
        {
            paths.Overwrite = checkBoxOverwrite.Checked;
        }

        void ComboBoxContainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormsHelper.ListComboContent format = (WinFormsHelper.ListComboContent)comboBoxContainers.SelectedItem;

            if (format.Value != file.Format)
            {
                file.Format = format.Value;

                if (!file.IsCodecSupported(audio))
                {
                    audio.Codec = file.SupportedAudioCodecs[0, 1];
                }

                if (!file.IsCodecSupported(video))
                {
                    video.Codec = file.SupportedVideoCodecs[0, 1];
                }

                if (!string.IsNullOrEmpty(textBoxOutputFilename.Text))
                {
                    textBoxOutputFilename.Text = Path.ChangeExtension(textBoxOutputFilename.Text, file.Format);
                }

                InitTabs();
                InitAudio();
                InitVideo();
                InitMetadata();
            }
        }

        void ComboBoxPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormsHelper.ListComboContent preset = (WinFormsHelper.ListComboContent)comboBoxPresets.SelectedItem;
            settings.Preset = preset.Name;
            InitPreset(preset.Name, preset.Value);
            InitTabs();
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
            if (radioButtonKeep.Checked == true)
            {
                settings.KeepValues = true;
            }
        }

        void RadioButtonRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRefresh.Checked == true)
            {
                settings.KeepValues = false;
            }
        }
    
        //
        // Video tab events
        //
        void ComboBoxVideoCodecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormsHelper.ListComboContent codec = (WinFormsHelper.ListComboContent)comboBoxVideoCodecs.SelectedItem;
            if (codec.Value != video.Codec)
            {
                video.Codec = codec.Value;
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
            video.CodecLevel = Convert.ToDouble(WinFormsHelper.GetSelectedValueFromArrayComboBox(comboBoxVideoCodecLevels));
        }

        private void ComboBoxMEMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            video.MEMethod = WinFormsHelper.GetSelectedValueFromArrayComboBox(comboBoxMEMethod);
        }

        private void ComboBoxMECmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            video.CMP = Convert.ToInt16(WinFormsHelper.GetSelectedValueFromArrayComboBox(comboBoxMECmp));
        }

        private void ComboBoxMESubcmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            video.SubCMP = Convert.ToInt16(WinFormsHelper.GetSelectedValueFromArrayComboBox(comboBoxMESubcmp));
        }

        private void ComboBoxBFStrat_SelectedIndexChanged(object sender, EventArgs e)
        {
            video.BFStrategy = Convert.ToInt16(WinFormsHelper.GetSelectedValueFromArrayComboBox(comboBoxBFStrat));
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

        //
        // Audio tab events
        //
        void ComboBoxAudioCodecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormsHelper.ListComboContent codec = (WinFormsHelper.ListComboContent)comboBoxAudioCodecs.SelectedItem;
            if (codec.Value != audio.Codec)
            {
                audio.Codec = codec.Value;
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

        private void numericUpDownFPS_ValueChanged(object sender, EventArgs e)
        {
            picture.FPS = (int)numericUpDownFPS.Value;
        }

        private void numericUpDownLayoutWidth_ValueChanged(object sender, EventArgs e)
        {
            picture.WinWidth = (int)numericUpDownLayoutWidth.Value;
        }

        private void numericUpDownLayoutHeight_ValueChanged(object sender, EventArgs e)
        {
            picture.WinHeight = (int)numericUpDownLayoutHeight.Value;
        }

        private void numericUpDownLayoutVert_ValueChanged(object sender, EventArgs e)
        {
            picture.X = (int)numericUpDownLayoutVert.Value;
        }

        private void numericUpDownLayoutHoriz_ValueChanged(object sender, EventArgs e)
        {
            picture.Y = (int)numericUpDownLayoutHoriz.Value;
        }

        private void NumericUpDownRatio_ValueChanged(object sender, EventArgs e)
        {
            picture.Ratio = string.Format("{0}:{1}", numericUpDownRatioA.Value, numericUpDownRatioB.Value);
        }

        //
        // Tagging tab events
        //
        void TextBoxAlbum_TextChanged(object sender, EventArgs e)
        {
            tags.Album = textBoxAlbum.Text;
        }

        void TextBoxAlbumArtist_TextChanged(object sender, EventArgs e)
        {
            tags.AlbumArtist = textBoxAlbumArtist.Text;
        }

        void TextBoxArtist_TextChanged(object sender, EventArgs e)
        {
            tags.Artist = textBoxArtist.Text;
        }

        void TextBoxComment_TextChanged(object sender, EventArgs e)
        {
            tags.Comment = textBoxComment.Text;
        }

        void TextBoxDisc_TextChanged(object sender, EventArgs e)
        {
            //tags.Disc = WinFormsHelper.TextToInt(textBoxDisc.Text);
        }

        void TextBoxGenre_TextChanged(object sender, EventArgs e)
        {
            tags.Genre = textBoxGenre.Text;
        }

        void TextBoxTitle_TextChanged(object sender, EventArgs e)
        {
            tags.Title = textBoxTitle.Text;
        }

        void TextBoxTotalDiscs_TextChanged(object sender, EventArgs e)
        {
            //tags.Disc = WinFormsHelper.TextToInt(textBoxDisc.Text);
        }

        void TextBoxTotalTracks_TextChanged(object sender, EventArgs e)
        {
            //tags.TotalTracks = WinFormsHelper.TextToInt(textBoxTotalTracks.Text);
        }

        void TextBoxTrack_TextChanged(object sender, EventArgs e)
        {
            //tags.Track = WinFormsHelper.TextToInt(textBoxTrack.Text);
        }

        void TextBoxYear_TextChanged(object sender, EventArgs e)
        {
            //tags.Year = WinFormsHelper.TextToInt(textBoxYear.Text);
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
            termBinFile.Filter = "Executable (*.exe) | *.exe | Any file (*.*) | *.*";
            termBinFile.ShowDialog();

            if (termBinFile.FileName != "")
            {
                textBoxTermBin.Text = termBinFile.FileName;
            }
        }
    }
}