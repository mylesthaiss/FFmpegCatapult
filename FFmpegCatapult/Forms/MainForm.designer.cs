﻿// FFmpegCatapultForm is part of FFmpeg Catapult.

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

namespace FFmpegCatapult
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.groupBoxDefaultPaths = new System.Windows.Forms.GroupBox();
            this.checkBoxUrlFilenames = new System.Windows.Forms.CheckBox();
            this.buttonBrowseDefaultOutputPath = new System.Windows.Forms.Button();
            this.textBoxDefaultOutputFolder = new System.Windows.Forms.TextBox();
            this.buttonBrowseDefaultInputPath = new System.Windows.Forms.Button();
            this.textBoxDefaultSourceFolder = new System.Windows.Forms.TextBox();
            this.labelDefaultOutputPath = new System.Windows.Forms.Label();
            this.labelDefaultInputPath = new System.Windows.Forms.Label();
            this.groupBoxSessionOptions = new System.Windows.Forms.GroupBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.checkBoxWriteLog = new System.Windows.Forms.CheckBox();
            this.groupBoxBinaries = new System.Windows.Forms.GroupBox();
            this.textBoxBinArgs = new System.Windows.Forms.TextBox();
            this.labelBinArgs = new System.Windows.Forms.Label();
            this.textBoxTermArgs = new System.Windows.Forms.TextBox();
            this.labelTermArgs = new System.Windows.Forms.Label();
            this.textBoxTermBin = new System.Windows.Forms.TextBox();
            this.labelTermBin = new System.Windows.Forms.Label();
            this.buttonBrowseTermBin = new System.Windows.Forms.Button();
            this.buttonBrowseFFmpegBin = new System.Windows.Forms.Button();
            this.textBoxFFmpegBin = new System.Windows.Forms.TextBox();
            this.labelFFmpegBin = new System.Windows.Forms.Label();
            this.tabTagging = new System.Windows.Forms.TabPage();
            this.groupBoxBroadcast = new System.Windows.Forms.GroupBox();
            this.labelSynopsis = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxNetwork = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxSynopsis = new System.Windows.Forms.TextBox();
            this.textBoxEpisodeId = new System.Windows.Forms.TextBox();
            this.textBoxShow = new System.Windows.Forms.TextBox();
            this.labelNetwork = new System.Windows.Forms.Label();
            this.labelEpisodeId = new System.Windows.Forms.Label();
            this.labelShow = new System.Windows.Forms.Label();
            this.groupBoxGeneralTags = new System.Windows.Forms.GroupBox();
            this.checkBoxCompilation = new System.Windows.Forms.CheckBox();
            this.textBoxCopyright = new System.Windows.Forms.TextBox();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelOfDiscs = new System.Windows.Forms.Label();
            this.textBoxTotalDiscs = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxDisc = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelDisc = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelOfTrack = new System.Windows.Forms.Label();
            this.textBoxTotalTracks = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.textBoxTrack = new System.Windows.Forms.TextBox();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelTrack = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.textBoxAlbumArtist = new System.Windows.Forms.TextBox();
            this.textBoxAlbum = new System.Windows.Forms.TextBox();
            this.labelAlbumArtist = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabAudio = new System.Windows.Forms.TabPage();
            this.groupBoxAudioFiltering = new System.Windows.Forms.GroupBox();
            this.numericUpDownHighPass = new System.Windows.Forms.NumericUpDown();
            this.labelHighPass = new System.Windows.Forms.Label();
            this.numericUpDownLowPass = new System.Windows.Forms.NumericUpDown();
            this.labelLowPass = new System.Windows.Forms.Label();
            this.numericUpDownResamplePrecision = new System.Windows.Forms.NumericUpDown();
            this.labelResamplePrecision = new System.Windows.Forms.Label();
            this.comboBoxResampleDitherMethod = new System.Windows.Forms.ComboBox();
            this.labelDitherMethod = new System.Windows.Forms.Label();
            this.comboBoxResampler = new System.Windows.Forms.ComboBox();
            this.labelResampler = new System.Windows.Forms.Label();
            this.groupBoxAudioBitrate = new System.Windows.Forms.GroupBox();
            this.labelVBRMode = new System.Windows.Forms.Label();
            this.comboBoxAudioVBRModes = new System.Windows.Forms.ComboBox();
            this.labelAudioBitrate = new System.Windows.Forms.Label();
            this.checkBoxUseAudioVBR = new System.Windows.Forms.CheckBox();
            this.comboBoxAudioBitrates = new System.Windows.Forms.ComboBox();
            this.groupBoxAudioOutput = new System.Windows.Forms.GroupBox();
            this.comboBoxChannels = new System.Windows.Forms.ComboBox();
            this.labelVolBoost = new System.Windows.Forms.Label();
            this.numericUpDownVolumeBoost = new System.Windows.Forms.NumericUpDown();
            this.labelChannels = new System.Windows.Forms.Label();
            this.comboBoxSampleRates = new System.Windows.Forms.ComboBox();
            this.labelSampleRate = new System.Windows.Forms.Label();
            this.groupBoxAudioCodec = new System.Windows.Forms.GroupBox();
            this.comboBoxAudioCodecProfile = new System.Windows.Forms.ComboBox();
            this.labelAudioCodecProfile = new System.Windows.Forms.Label();
            this.comboBoxAudioEncoders = new System.Windows.Forms.ComboBox();
            this.comboBoxAudioCodecs = new System.Windows.Forms.ComboBox();
            this.labelAudioEncoder = new System.Windows.Forms.Label();
            this.labelAudioCodec = new System.Windows.Forms.Label();
            this.tabVideo = new System.Windows.Forms.TabPage();
            this.groupBoxVideoSize = new System.Windows.Forms.GroupBox();
            this.numericUpDownTargetSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBufferSize = new System.Windows.Forms.NumericUpDown();
            this.labelTargetSize = new System.Windows.Forms.Label();
            this.labelBuffer = new System.Windows.Forms.Label();
            this.groupBoxVideoEncoding = new System.Windows.Forms.GroupBox();
            this.labelMBCmp = new System.Windows.Forms.Label();
            this.numericUpDownMBCmp = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMEPreCmp = new System.Windows.Forms.NumericUpDown();
            this.labelMEPreCmp = new System.Windows.Forms.Label();
            this.numericUpDownMECmp = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMESubCmp = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBFStrat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTileRows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTileColumns = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBFrames = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDiaSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTrellis = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGOPSize = new System.Windows.Forms.NumericUpDown();
            this.labelMESubCmp = new System.Windows.Forms.Label();
            this.labelMECmp = new System.Windows.Forms.Label();
            this.comboBoxMEMethod = new System.Windows.Forms.ComboBox();
            this.labelMEMethod = new System.Windows.Forms.Label();
            this.labelBFStrat = new System.Windows.Forms.Label();
            this.labelTileCols = new System.Windows.Forms.Label();
            this.labelTileRows = new System.Windows.Forms.Label();
            this.labelTrellis = new System.Windows.Forms.Label();
            this.labelDiaSize = new System.Windows.Forms.Label();
            this.labelGopSize = new System.Windows.Forms.Label();
            this.labelBFrames = new System.Windows.Forms.Label();
            this.groupBoxVideoBitrate = new System.Windows.Forms.GroupBox();
            this.numericUpDownQMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCRF = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVideoMaxBitrate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVideoMinBitrate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVideoBitrate = new System.Windows.Forms.NumericUpDown();
            this.labelQmax = new System.Windows.Forms.Label();
            this.checkBoxTwoPassEncoding = new System.Windows.Forms.CheckBox();
            this.labelQmin = new System.Windows.Forms.Label();
            this.labelCRF = new System.Windows.Forms.Label();
            this.checkBoxUseCRF = new System.Windows.Forms.CheckBox();
            this.labelMaxBitrate = new System.Windows.Forms.Label();
            this.labelMinBitrate = new System.Windows.Forms.Label();
            this.labelVideoBitrate = new System.Windows.Forms.Label();
            this.groupBoxVideoCodec = new System.Windows.Forms.GroupBox();
            this.labelVideoEncoderPreset = new System.Windows.Forms.Label();
            this.comboBoxVideoCodecLevels = new System.Windows.Forms.ComboBox();
            this.comboBoxVideoEncoders = new System.Windows.Forms.ComboBox();
            this.comboBoxVideoEncoderPresets = new System.Windows.Forms.ComboBox();
            this.labelVideoEncoder = new System.Windows.Forms.Label();
            this.comboBoxVCodecProfile = new System.Windows.Forms.ComboBox();
            this.labelVCodecProfile = new System.Windows.Forms.Label();
            this.comboBoxVideoCodecs = new System.Windows.Forms.ComboBox();
            this.labelVideoCodec = new System.Windows.Forms.Label();
            this.labelVCodecLevel = new System.Windows.Forms.Label();
            this.labelPixelFormat = new System.Windows.Forms.Label();
            this.comboBoxPixelFormat = new System.Windows.Forms.ComboBox();
            this.tabPicture = new System.Windows.Forms.TabPage();
            this.groupBoxPictureFiltering = new System.Windows.Forms.GroupBox();
            this.checkBoxDeinterlace = new System.Windows.Forms.CheckBox();
            this.labelLayoutColour = new System.Windows.Forms.Label();
            this.textBoxLayoutColour = new System.Windows.Forms.TextBox();
            this.groupBoxLayout = new System.Windows.Forms.GroupBox();
            this.numericUpDownLayoutHoriz = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLayoutVert = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLayoutHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLayoutWidth = new System.Windows.Forms.NumericUpDown();
            this.labelHoriz = new System.Windows.Forms.Label();
            this.labelVert = new System.Windows.Forms.Label();
            this.labelLayoutHeight = new System.Windows.Forms.Label();
            this.labelLayoutWidth = new System.Windows.Forms.Label();
            this.checkBoxPad = new System.Windows.Forms.CheckBox();
            this.checkBoxCrop = new System.Windows.Forms.CheckBox();
            this.groupBoxScreen = new System.Windows.Forms.GroupBox();
            this.numericUpDownFPS = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRatioB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRatioA = new System.Windows.Forms.NumericUpDown();
            this.labelFPS = new System.Windows.Forms.Label();
            this.labelRatioDash = new System.Windows.Forms.Label();
            this.labelRatio = new System.Windows.Forms.Label();
            this.checkBoxAspectRatio = new System.Windows.Forms.CheckBox();
            this.groupBoxResolution = new System.Windows.Forms.GroupBox();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.comboBoxScalingMethods = new System.Windows.Forms.ComboBox();
            this.labelMethod = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.radioButtonCustomRes = new System.Windows.Forms.RadioButton();
            this.radioButtonHalfRes = new System.Windows.Forms.RadioButton();
            this.radioButtonKeepRes = new System.Windows.Forms.RadioButton();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.groupBoxFileOutput = new System.Windows.Forms.GroupBox();
            this.checkBoxFastStartTagging = new System.Windows.Forms.CheckBox();
            this.textBoxOutputFilename = new System.Windows.Forms.TextBox();
            this.labelOutputFilename = new System.Windows.Forms.Label();
            this.checkBoxOverwrite = new System.Windows.Forms.CheckBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonBrowseOutput = new System.Windows.Forms.Button();
            this.textBoxTargetFolder = new System.Windows.Forms.TextBox();
            this.groupBoxSession = new System.Windows.Forms.GroupBox();
            this.radioButtonRefresh = new System.Windows.Forms.RadioButton();
            this.radioButtonKeep = new System.Windows.Forms.RadioButton();
            this.groupBoxEncoding = new System.Windows.Forms.GroupBox();
            this.numericUpDownProcessors = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownThreads = new System.Windows.Forms.NumericUpDown();
            this.labelProcessors = new System.Windows.Forms.Label();
            this.labelThreads = new System.Windows.Forms.Label();
            this.comboBoxContainers = new System.Windows.Forms.ComboBox();
            this.labelFormat = new System.Windows.Forms.Label();
            this.comboBoxPresets = new System.Windows.Forms.ComboBox();
            this.labelPreset = new System.Windows.Forms.Label();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.buttonBrowseAudioStream = new System.Windows.Forms.Button();
            this.labelAudioStream = new System.Windows.Forms.Label();
            this.textBoxAudioStream = new System.Windows.Forms.TextBox();
            this.buttonBrowseInput = new System.Windows.Forms.Button();
            this.textBoxInFile = new System.Windows.Forms.TextBox();
            this.labelSourceInput = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabOptions.SuspendLayout();
            this.groupBoxDefaultPaths.SuspendLayout();
            this.groupBoxSessionOptions.SuspendLayout();
            this.groupBoxBinaries.SuspendLayout();
            this.tabTagging.SuspendLayout();
            this.groupBoxBroadcast.SuspendLayout();
            this.groupBoxGeneralTags.SuspendLayout();
            this.tabAudio.SuspendLayout();
            this.groupBoxAudioFiltering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResamplePrecision)).BeginInit();
            this.groupBoxAudioBitrate.SuspendLayout();
            this.groupBoxAudioOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolumeBoost)).BeginInit();
            this.groupBoxAudioCodec.SuspendLayout();
            this.tabVideo.SuspendLayout();
            this.groupBoxVideoSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTargetSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBufferSize)).BeginInit();
            this.groupBoxVideoEncoding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMBCmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMEPreCmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMECmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMESubCmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBFStrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiaSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrellis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGOPSize)).BeginInit();
            this.groupBoxVideoBitrate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCRF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVideoMaxBitrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVideoMinBitrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVideoBitrate)).BeginInit();
            this.groupBoxVideoCodec.SuspendLayout();
            this.tabPicture.SuspendLayout();
            this.groupBoxPictureFiltering.SuspendLayout();
            this.groupBoxLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLayoutHoriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLayoutVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLayoutHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLayoutWidth)).BeginInit();
            this.groupBoxScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRatioB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRatioA)).BeginInit();
            this.groupBoxResolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.tabMain.SuspendLayout();
            this.groupBoxFileOutput.SuspendLayout();
            this.groupBoxSession.SuspendLayout();
            this.groupBoxEncoding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProcessors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreads)).BeginInit();
            this.groupBoxFiles.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Enabled = false;
            this.buttonRun.Location = new System.Drawing.Point(512, 366);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 363);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.groupBoxDefaultPaths);
            this.tabOptions.Controls.Add(this.groupBoxSessionOptions);
            this.tabOptions.Controls.Add(this.groupBoxBinaries);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(567, 296);
            this.tabOptions.TabIndex = 4;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // groupBoxDefaultPaths
            // 
            this.groupBoxDefaultPaths.Controls.Add(this.checkBoxUrlFilenames);
            this.groupBoxDefaultPaths.Controls.Add(this.buttonBrowseDefaultOutputPath);
            this.groupBoxDefaultPaths.Controls.Add(this.textBoxDefaultOutputFolder);
            this.groupBoxDefaultPaths.Controls.Add(this.buttonBrowseDefaultInputPath);
            this.groupBoxDefaultPaths.Controls.Add(this.textBoxDefaultSourceFolder);
            this.groupBoxDefaultPaths.Controls.Add(this.labelDefaultOutputPath);
            this.groupBoxDefaultPaths.Controls.Add(this.labelDefaultInputPath);
            this.groupBoxDefaultPaths.Location = new System.Drawing.Point(6, 133);
            this.groupBoxDefaultPaths.Name = "groupBoxDefaultPaths";
            this.groupBoxDefaultPaths.Size = new System.Drawing.Size(555, 99);
            this.groupBoxDefaultPaths.TabIndex = 2;
            this.groupBoxDefaultPaths.TabStop = false;
            this.groupBoxDefaultPaths.Text = "Default Paths";
            // 
            // checkBoxUrlFilenames
            // 
            this.checkBoxUrlFilenames.AutoSize = true;
            this.checkBoxUrlFilenames.Location = new System.Drawing.Point(9, 76);
            this.checkBoxUrlFilenames.Name = "checkBoxUrlFilenames";
            this.checkBoxUrlFilenames.Size = new System.Drawing.Size(165, 17);
            this.checkBoxUrlFilenames.TabIndex = 13;
            this.checkBoxUrlFilenames.Text = "Create URL friendly filenames";
            this.checkBoxUrlFilenames.UseVisualStyleBackColor = true;
            this.checkBoxUrlFilenames.CheckedChanged += new System.EventHandler(this.CheckBoxUrlFilenames_CheckedChanged);
            // 
            // buttonBrowseDefaultOutputPath
            // 
            this.buttonBrowseDefaultOutputPath.Location = new System.Drawing.Point(474, 44);
            this.buttonBrowseDefaultOutputPath.Name = "buttonBrowseDefaultOutputPath";
            this.buttonBrowseDefaultOutputPath.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseDefaultOutputPath.TabIndex = 12;
            this.buttonBrowseDefaultOutputPath.Text = "Browse...";
            this.buttonBrowseDefaultOutputPath.UseVisualStyleBackColor = true;
            this.buttonBrowseDefaultOutputPath.Click += new System.EventHandler(this.ButtonBrowseDefaultOutputPath_Click);
            // 
            // textBoxDefaultOutputFolder
            // 
            this.textBoxDefaultOutputFolder.Location = new System.Drawing.Point(85, 45);
            this.textBoxDefaultOutputFolder.Name = "textBoxDefaultOutputFolder";
            this.textBoxDefaultOutputFolder.Size = new System.Drawing.Size(383, 20);
            this.textBoxDefaultOutputFolder.TabIndex = 11;
            this.textBoxDefaultOutputFolder.TextChanged += new System.EventHandler(this.TextBoxDefaultOutputFolder_TextChanged);
            // 
            // buttonBrowseDefaultInputPath
            // 
            this.buttonBrowseDefaultInputPath.Location = new System.Drawing.Point(474, 18);
            this.buttonBrowseDefaultInputPath.Name = "buttonBrowseDefaultInputPath";
            this.buttonBrowseDefaultInputPath.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseDefaultInputPath.TabIndex = 10;
            this.buttonBrowseDefaultInputPath.Text = "Browse...";
            this.buttonBrowseDefaultInputPath.UseVisualStyleBackColor = true;
            this.buttonBrowseDefaultInputPath.Click += new System.EventHandler(this.ButtonBrowseDefaultInputPath_Click);
            // 
            // textBoxDefaultSourceFolder
            // 
            this.textBoxDefaultSourceFolder.Location = new System.Drawing.Point(85, 19);
            this.textBoxDefaultSourceFolder.Name = "textBoxDefaultSourceFolder";
            this.textBoxDefaultSourceFolder.Size = new System.Drawing.Size(383, 20);
            this.textBoxDefaultSourceFolder.TabIndex = 2;
            this.textBoxDefaultSourceFolder.TextChanged += new System.EventHandler(this.TextBoxDefaultSourceFolder_TextChanged);
            // 
            // labelDefaultOutputPath
            // 
            this.labelDefaultOutputPath.AutoSize = true;
            this.labelDefaultOutputPath.Location = new System.Drawing.Point(8, 48);
            this.labelDefaultOutputPath.Name = "labelDefaultOutputPath";
            this.labelDefaultOutputPath.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultOutputPath.TabIndex = 1;
            this.labelDefaultOutputPath.Text = "Output folder:";
            // 
            // labelDefaultInputPath
            // 
            this.labelDefaultInputPath.AutoSize = true;
            this.labelDefaultInputPath.Location = new System.Drawing.Point(6, 22);
            this.labelDefaultInputPath.Name = "labelDefaultInputPath";
            this.labelDefaultInputPath.Size = new System.Drawing.Size(73, 13);
            this.labelDefaultInputPath.TabIndex = 0;
            this.labelDefaultInputPath.Text = "Source folder:";
            // 
            // groupBoxSessionOptions
            // 
            this.groupBoxSessionOptions.Controls.Add(this.textBoxLog);
            this.groupBoxSessionOptions.Controls.Add(this.checkBoxWriteLog);
            this.groupBoxSessionOptions.Location = new System.Drawing.Point(6, 238);
            this.groupBoxSessionOptions.Name = "groupBoxSessionOptions";
            this.groupBoxSessionOptions.Size = new System.Drawing.Size(555, 52);
            this.groupBoxSessionOptions.TabIndex = 1;
            this.groupBoxSessionOptions.TabStop = false;
            this.groupBoxSessionOptions.Text = "Session";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(96, 19);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(453, 20);
            this.textBoxLog.TabIndex = 3;
            this.textBoxLog.TextChanged += new System.EventHandler(this.TextBoxLog_TextChanged);
            // 
            // checkBoxWriteLog
            // 
            this.checkBoxWriteLog.AutoSize = true;
            this.checkBoxWriteLog.Location = new System.Drawing.Point(9, 21);
            this.checkBoxWriteLog.Name = "checkBoxWriteLog";
            this.checkBoxWriteLog.Size = new System.Drawing.Size(87, 17);
            this.checkBoxWriteLog.TabIndex = 0;
            this.checkBoxWriteLog.Text = "Write log file:";
            this.checkBoxWriteLog.UseVisualStyleBackColor = true;
            this.checkBoxWriteLog.CheckedChanged += new System.EventHandler(this.CheckBoxWriteLog_CheckedChanged);
            // 
            // groupBoxBinaries
            // 
            this.groupBoxBinaries.Controls.Add(this.textBoxBinArgs);
            this.groupBoxBinaries.Controls.Add(this.labelBinArgs);
            this.groupBoxBinaries.Controls.Add(this.textBoxTermArgs);
            this.groupBoxBinaries.Controls.Add(this.labelTermArgs);
            this.groupBoxBinaries.Controls.Add(this.textBoxTermBin);
            this.groupBoxBinaries.Controls.Add(this.labelTermBin);
            this.groupBoxBinaries.Controls.Add(this.buttonBrowseTermBin);
            this.groupBoxBinaries.Controls.Add(this.buttonBrowseFFmpegBin);
            this.groupBoxBinaries.Controls.Add(this.textBoxFFmpegBin);
            this.groupBoxBinaries.Controls.Add(this.labelFFmpegBin);
            this.groupBoxBinaries.Location = new System.Drawing.Point(6, 6);
            this.groupBoxBinaries.Name = "groupBoxBinaries";
            this.groupBoxBinaries.Size = new System.Drawing.Size(555, 121);
            this.groupBoxBinaries.TabIndex = 0;
            this.groupBoxBinaries.TabStop = false;
            this.groupBoxBinaries.Text = "Binaries";
            // 
            // textBoxBinArgs
            // 
            this.textBoxBinArgs.Location = new System.Drawing.Point(112, 92);
            this.textBoxBinArgs.Name = "textBoxBinArgs";
            this.textBoxBinArgs.Size = new System.Drawing.Size(437, 20);
            this.textBoxBinArgs.TabIndex = 9;
            this.textBoxBinArgs.TextChanged += new System.EventHandler(this.TextBoxBinArgs_TextChanged);
            // 
            // labelBinArgs
            // 
            this.labelBinArgs.AutoSize = true;
            this.labelBinArgs.Location = new System.Drawing.Point(6, 95);
            this.labelBinArgs.Name = "labelBinArgs";
            this.labelBinArgs.Size = new System.Drawing.Size(100, 13);
            this.labelBinArgs.TabIndex = 8;
            this.labelBinArgs.Text = "FFmpeg arguments:";
            // 
            // textBoxTermArgs
            // 
            this.textBoxTermArgs.Location = new System.Drawing.Point(112, 66);
            this.textBoxTermArgs.Name = "textBoxTermArgs";
            this.textBoxTermArgs.Size = new System.Drawing.Size(437, 20);
            this.textBoxTermArgs.TabIndex = 7;
            this.textBoxTermArgs.TextChanged += new System.EventHandler(this.TextBoxTermArgs_TextChanged);
            // 
            // labelTermArgs
            // 
            this.labelTermArgs.AutoSize = true;
            this.labelTermArgs.Location = new System.Drawing.Point(20, 69);
            this.labelTermArgs.Name = "labelTermArgs";
            this.labelTermArgs.Size = new System.Drawing.Size(86, 13);
            this.labelTermArgs.TabIndex = 6;
            this.labelTermArgs.Text = "Term arguments:";
            // 
            // textBoxTermBin
            // 
            this.textBoxTermBin.Location = new System.Drawing.Point(112, 40);
            this.textBoxTermBin.Name = "textBoxTermBin";
            this.textBoxTermBin.Size = new System.Drawing.Size(356, 20);
            this.textBoxTermBin.TabIndex = 5;
            this.textBoxTermBin.TextChanged += new System.EventHandler(this.TextBoxTermBin_TextChanged);
            this.textBoxTermBin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_FSFilter);
            // 
            // labelTermBin
            // 
            this.labelTermBin.AutoSize = true;
            this.labelTermBin.Location = new System.Drawing.Point(56, 43);
            this.labelTermBin.Name = "labelTermBin";
            this.labelTermBin.Size = new System.Drawing.Size(50, 13);
            this.labelTermBin.TabIndex = 4;
            this.labelTermBin.Text = "Terminal:";
            // 
            // buttonBrowseTermBin
            // 
            this.buttonBrowseTermBin.Location = new System.Drawing.Point(474, 38);
            this.buttonBrowseTermBin.Name = "buttonBrowseTermBin";
            this.buttonBrowseTermBin.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseTermBin.TabIndex = 3;
            this.buttonBrowseTermBin.Text = "Browse...";
            this.buttonBrowseTermBin.UseVisualStyleBackColor = true;
            this.buttonBrowseTermBin.Click += new System.EventHandler(this.ButtonBrowseTermBin_Click);
            // 
            // buttonBrowseFFmpegBin
            // 
            this.buttonBrowseFFmpegBin.Location = new System.Drawing.Point(474, 13);
            this.buttonBrowseFFmpegBin.Name = "buttonBrowseFFmpegBin";
            this.buttonBrowseFFmpegBin.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseFFmpegBin.TabIndex = 2;
            this.buttonBrowseFFmpegBin.Text = "Browse...";
            this.buttonBrowseFFmpegBin.UseVisualStyleBackColor = true;
            this.buttonBrowseFFmpegBin.Click += new System.EventHandler(this.ButtonBrowseFFmpegBin_Click);
            // 
            // textBoxFFmpegBin
            // 
            this.textBoxFFmpegBin.Location = new System.Drawing.Point(112, 16);
            this.textBoxFFmpegBin.Name = "textBoxFFmpegBin";
            this.textBoxFFmpegBin.Size = new System.Drawing.Size(356, 20);
            this.textBoxFFmpegBin.TabIndex = 1;
            this.textBoxFFmpegBin.TextChanged += new System.EventHandler(this.TextBoxFFmpegBin_TextChanged);
            this.textBoxFFmpegBin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_FSFilter);
            // 
            // labelFFmpegBin
            // 
            this.labelFFmpegBin.AutoSize = true;
            this.labelFFmpegBin.Location = new System.Drawing.Point(56, 19);
            this.labelFFmpegBin.Name = "labelFFmpegBin";
            this.labelFFmpegBin.Size = new System.Drawing.Size(48, 13);
            this.labelFFmpegBin.TabIndex = 0;
            this.labelFFmpegBin.Text = "FFmpeg:";
            // 
            // tabTagging
            // 
            this.tabTagging.Controls.Add(this.groupBoxBroadcast);
            this.tabTagging.Controls.Add(this.groupBoxGeneralTags);
            this.tabTagging.Location = new System.Drawing.Point(4, 22);
            this.tabTagging.Name = "tabTagging";
            this.tabTagging.Padding = new System.Windows.Forms.Padding(3);
            this.tabTagging.Size = new System.Drawing.Size(567, 296);
            this.tabTagging.TabIndex = 5;
            this.tabTagging.Text = "Tagging";
            this.tabTagging.UseVisualStyleBackColor = true;
            // 
            // groupBoxBroadcast
            // 
            this.groupBoxBroadcast.Controls.Add(this.labelSynopsis);
            this.groupBoxBroadcast.Controls.Add(this.textBoxDescription);
            this.groupBoxBroadcast.Controls.Add(this.textBoxNetwork);
            this.groupBoxBroadcast.Controls.Add(this.labelDescription);
            this.groupBoxBroadcast.Controls.Add(this.textBoxSynopsis);
            this.groupBoxBroadcast.Controls.Add(this.textBoxEpisodeId);
            this.groupBoxBroadcast.Controls.Add(this.textBoxShow);
            this.groupBoxBroadcast.Controls.Add(this.labelNetwork);
            this.groupBoxBroadcast.Controls.Add(this.labelEpisodeId);
            this.groupBoxBroadcast.Controls.Add(this.labelShow);
            this.groupBoxBroadcast.Location = new System.Drawing.Point(3, 187);
            this.groupBoxBroadcast.Name = "groupBoxBroadcast";
            this.groupBoxBroadcast.Size = new System.Drawing.Size(558, 103);
            this.groupBoxBroadcast.TabIndex = 1;
            this.groupBoxBroadcast.TabStop = false;
            this.groupBoxBroadcast.Text = "Broadcast";
            // 
            // labelSynopsis
            // 
            this.labelSynopsis.AutoSize = true;
            this.labelSynopsis.Location = new System.Drawing.Point(249, 48);
            this.labelSynopsis.Name = "labelSynopsis";
            this.labelSynopsis.Size = new System.Drawing.Size(52, 13);
            this.labelSynopsis.TabIndex = 1;
            this.labelSynopsis.Text = "Synopsis:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(307, 19);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(245, 20);
            this.textBoxDescription.TabIndex = 2;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.TextBoxDescription_TextChanged);
            // 
            // textBoxNetwork
            // 
            this.textBoxNetwork.Location = new System.Drawing.Point(72, 72);
            this.textBoxNetwork.Name = "textBoxNetwork";
            this.textBoxNetwork.Size = new System.Drawing.Size(148, 20);
            this.textBoxNetwork.TabIndex = 0;
            this.textBoxNetwork.TextChanged += new System.EventHandler(this.TextBoxNetwork_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(238, 22);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxSynopsis
            // 
            this.textBoxSynopsis.Location = new System.Drawing.Point(307, 45);
            this.textBoxSynopsis.Multiline = true;
            this.textBoxSynopsis.Name = "textBoxSynopsis";
            this.textBoxSynopsis.Size = new System.Drawing.Size(245, 47);
            this.textBoxSynopsis.TabIndex = 3;
            this.textBoxSynopsis.TextChanged += new System.EventHandler(this.TextBoxSynopsis_TextChanged);
            // 
            // textBoxEpisodeId
            // 
            this.textBoxEpisodeId.Location = new System.Drawing.Point(72, 45);
            this.textBoxEpisodeId.Name = "textBoxEpisodeId";
            this.textBoxEpisodeId.Size = new System.Drawing.Size(148, 20);
            this.textBoxEpisodeId.TabIndex = 0;
            this.textBoxEpisodeId.TextChanged += new System.EventHandler(this.TextBoxEpisodeId_TextChanged);
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(72, 19);
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.Size = new System.Drawing.Size(148, 20);
            this.textBoxShow.TabIndex = 0;
            this.textBoxShow.TextChanged += new System.EventHandler(this.TextBoxShow_TextChanged);
            // 
            // labelNetwork
            // 
            this.labelNetwork.AutoSize = true;
            this.labelNetwork.Location = new System.Drawing.Point(16, 75);
            this.labelNetwork.Name = "labelNetwork";
            this.labelNetwork.Size = new System.Drawing.Size(50, 13);
            this.labelNetwork.TabIndex = 0;
            this.labelNetwork.Text = "Network:";
            // 
            // labelEpisodeId
            // 
            this.labelEpisodeId.AutoSize = true;
            this.labelEpisodeId.Location = new System.Drawing.Point(6, 48);
            this.labelEpisodeId.Name = "labelEpisodeId";
            this.labelEpisodeId.Size = new System.Drawing.Size(60, 13);
            this.labelEpisodeId.TabIndex = 0;
            this.labelEpisodeId.Text = "Episode Id:";
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(29, 22);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(37, 13);
            this.labelShow.TabIndex = 0;
            this.labelShow.Text = "Show:";
            // 
            // groupBoxGeneralTags
            // 
            this.groupBoxGeneralTags.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBoxGeneralTags.Controls.Add(this.checkBoxCompilation);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxCopyright);
            this.groupBoxGeneralTags.Controls.Add(this.labelCopyright);
            this.groupBoxGeneralTags.Controls.Add(this.labelOfDiscs);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxTotalDiscs);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxComment);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxPublisher);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxDisc);
            this.groupBoxGeneralTags.Controls.Add(this.labelComment);
            this.groupBoxGeneralTags.Controls.Add(this.labelDisc);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxGenre);
            this.groupBoxGeneralTags.Controls.Add(this.labelOfTrack);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxTotalTracks);
            this.groupBoxGeneralTags.Controls.Add(this.labelGenre);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxArtist);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxTrack);
            this.groupBoxGeneralTags.Controls.Add(this.labelPublisher);
            this.groupBoxGeneralTags.Controls.Add(this.labelTrack);
            this.groupBoxGeneralTags.Controls.Add(this.labelArtist);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxAlbumArtist);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxAlbum);
            this.groupBoxGeneralTags.Controls.Add(this.labelAlbumArtist);
            this.groupBoxGeneralTags.Controls.Add(this.labelAlbum);
            this.groupBoxGeneralTags.Controls.Add(this.labelYear);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxYear);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxTitle);
            this.groupBoxGeneralTags.Controls.Add(this.labelTitle);
            this.groupBoxGeneralTags.Location = new System.Drawing.Point(6, 6);
            this.groupBoxGeneralTags.Name = "groupBoxGeneralTags";
            this.groupBoxGeneralTags.Size = new System.Drawing.Size(555, 175);
            this.groupBoxGeneralTags.TabIndex = 0;
            this.groupBoxGeneralTags.TabStop = false;
            this.groupBoxGeneralTags.Text = "General";
            // 
            // checkBoxCompilation
            // 
            this.checkBoxCompilation.AutoSize = true;
            this.checkBoxCompilation.Location = new System.Drawing.Point(436, 147);
            this.checkBoxCompilation.Name = "checkBoxCompilation";
            this.checkBoxCompilation.Size = new System.Drawing.Size(113, 17);
            this.checkBoxCompilation.TabIndex = 12;
            this.checkBoxCompilation.Text = "Part of compilation";
            this.checkBoxCompilation.UseVisualStyleBackColor = true;
            this.checkBoxCompilation.CheckedChanged += new System.EventHandler(this.CheckBoxCompilation_CheckedChanged);
            // 
            // textBoxCopyright
            // 
            this.textBoxCopyright.Location = new System.Drawing.Point(394, 118);
            this.textBoxCopyright.Name = "textBoxCopyright";
            this.textBoxCopyright.Size = new System.Drawing.Size(155, 20);
            this.textBoxCopyright.TabIndex = 11;
            this.textBoxCopyright.TextChanged += new System.EventHandler(this.TextBoxCopyright_TextChanged);
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(336, 122);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(54, 13);
            this.labelCopyright.TabIndex = 10;
            this.labelCopyright.Text = "Copyright:";
            // 
            // labelOfDiscs
            // 
            this.labelOfDiscs.AutoSize = true;
            this.labelOfDiscs.Location = new System.Drawing.Point(281, 149);
            this.labelOfDiscs.Name = "labelOfDiscs";
            this.labelOfDiscs.Size = new System.Drawing.Size(12, 13);
            this.labelOfDiscs.TabIndex = 2;
            this.labelOfDiscs.Text = "/";
            // 
            // textBoxTotalDiscs
            // 
            this.textBoxTotalDiscs.Location = new System.Drawing.Point(299, 145);
            this.textBoxTotalDiscs.Name = "textBoxTotalDiscs";
            this.textBoxTotalDiscs.Size = new System.Drawing.Size(25, 20);
            this.textBoxTotalDiscs.TabIndex = 2;
            this.textBoxTotalDiscs.TextChanged += new System.EventHandler(this.TextBoxTotalDiscs_TextChanged);
            this.textBoxTotalDiscs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(77, 119);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(247, 20);
            this.textBoxComment.TabIndex = 4;
            this.textBoxComment.TextChanged += new System.EventHandler(this.TextBoxComment_TextChanged);
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(394, 92);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(155, 20);
            this.textBoxPublisher.TabIndex = 5;
            this.textBoxPublisher.TextChanged += new System.EventHandler(this.TextBoxPublisher_TextChanged);
            // 
            // textBoxDisc
            // 
            this.textBoxDisc.Location = new System.Drawing.Point(250, 145);
            this.textBoxDisc.Name = "textBoxDisc";
            this.textBoxDisc.Size = new System.Drawing.Size(25, 20);
            this.textBoxDisc.TabIndex = 2;
            this.textBoxDisc.TextChanged += new System.EventHandler(this.TextBoxDisc_TextChanged);
            this.textBoxDisc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(17, 122);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(54, 13);
            this.labelComment.TabIndex = 3;
            this.labelComment.Text = "Comment:";
            // 
            // labelDisc
            // 
            this.labelDisc.AutoSize = true;
            this.labelDisc.Location = new System.Drawing.Point(213, 148);
            this.labelDisc.Name = "labelDisc";
            this.labelDisc.Size = new System.Drawing.Size(31, 13);
            this.labelDisc.TabIndex = 2;
            this.labelDisc.Text = "Disc:";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(394, 66);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(155, 20);
            this.textBoxGenre.TabIndex = 9;
            this.textBoxGenre.TextChanged += new System.EventHandler(this.TextBoxGenre_TextChanged);
            // 
            // labelOfTrack
            // 
            this.labelOfTrack.AutoSize = true;
            this.labelOfTrack.Location = new System.Drawing.Point(110, 148);
            this.labelOfTrack.Name = "labelOfTrack";
            this.labelOfTrack.Size = new System.Drawing.Size(12, 13);
            this.labelOfTrack.TabIndex = 2;
            this.labelOfTrack.Text = "/";
            // 
            // textBoxTotalTracks
            // 
            this.textBoxTotalTracks.Location = new System.Drawing.Point(128, 145);
            this.textBoxTotalTracks.Name = "textBoxTotalTracks";
            this.textBoxTotalTracks.Size = new System.Drawing.Size(25, 20);
            this.textBoxTotalTracks.TabIndex = 2;
            this.textBoxTotalTracks.TextChanged += new System.EventHandler(this.TextBoxTotalTracks_TextChanged);
            this.textBoxTotalTracks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(350, 69);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(39, 13);
            this.labelGenre.TabIndex = 8;
            this.labelGenre.Text = "Genre:";
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(77, 66);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(247, 20);
            this.textBoxArtist.TabIndex = 7;
            this.textBoxArtist.TextChanged += new System.EventHandler(this.TextBoxArtist_TextChanged);
            // 
            // textBoxTrack
            // 
            this.textBoxTrack.Location = new System.Drawing.Point(77, 145);
            this.textBoxTrack.Name = "textBoxTrack";
            this.textBoxTrack.Size = new System.Drawing.Size(25, 20);
            this.textBoxTrack.TabIndex = 2;
            this.textBoxTrack.TextChanged += new System.EventHandler(this.TextBoxTrack_TextChanged);
            this.textBoxTrack.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(336, 96);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(53, 13);
            this.labelPublisher.TabIndex = 2;
            this.labelPublisher.Text = "Publisher:";
            // 
            // labelTrack
            // 
            this.labelTrack.AutoSize = true;
            this.labelTrack.Location = new System.Drawing.Point(33, 149);
            this.labelTrack.Name = "labelTrack";
            this.labelTrack.Size = new System.Drawing.Size(38, 13);
            this.labelTrack.TabIndex = 2;
            this.labelTrack.Text = "Track:";
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Location = new System.Drawing.Point(38, 69);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(33, 13);
            this.labelArtist.TabIndex = 6;
            this.labelArtist.Text = "Artist:";
            // 
            // textBoxAlbumArtist
            // 
            this.textBoxAlbumArtist.Location = new System.Drawing.Point(77, 93);
            this.textBoxAlbumArtist.Name = "textBoxAlbumArtist";
            this.textBoxAlbumArtist.Size = new System.Drawing.Size(247, 20);
            this.textBoxAlbumArtist.TabIndex = 1;
            this.textBoxAlbumArtist.TextChanged += new System.EventHandler(this.TextBoxAlbumArtist_TextChanged);
            // 
            // textBoxAlbum
            // 
            this.textBoxAlbum.Location = new System.Drawing.Point(77, 41);
            this.textBoxAlbum.Name = "textBoxAlbum";
            this.textBoxAlbum.Size = new System.Drawing.Size(364, 20);
            this.textBoxAlbum.TabIndex = 5;
            this.textBoxAlbum.TextChanged += new System.EventHandler(this.TextBoxAlbum_TextChanged);
            // 
            // labelAlbumArtist
            // 
            this.labelAlbumArtist.AutoSize = true;
            this.labelAlbumArtist.Location = new System.Drawing.Point(6, 96);
            this.labelAlbumArtist.Name = "labelAlbumArtist";
            this.labelAlbumArtist.Size = new System.Drawing.Size(65, 13);
            this.labelAlbumArtist.TabIndex = 0;
            this.labelAlbumArtist.Text = "Album Artist:";
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(32, 44);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(39, 13);
            this.labelAlbum.TabIndex = 4;
            this.labelAlbum.Text = "Album:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(455, 44);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 13);
            this.labelYear.TabIndex = 3;
            this.labelYear.Text = "Year:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(493, 41);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(56, 20);
            this.textBoxYear.TabIndex = 2;
            this.textBoxYear.TextChanged += new System.EventHandler(this.TextBoxYear_TextChanged);
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(77, 16);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(472, 20);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.TextBoxTitle_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(41, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title:";
            // 
            // tabAudio
            // 
            this.tabAudio.Controls.Add(this.groupBoxAudioFiltering);
            this.tabAudio.Controls.Add(this.groupBoxAudioBitrate);
            this.tabAudio.Controls.Add(this.groupBoxAudioOutput);
            this.tabAudio.Controls.Add(this.groupBoxAudioCodec);
            this.tabAudio.Location = new System.Drawing.Point(4, 22);
            this.tabAudio.Name = "tabAudio";
            this.tabAudio.Padding = new System.Windows.Forms.Padding(3);
            this.tabAudio.Size = new System.Drawing.Size(567, 296);
            this.tabAudio.TabIndex = 3;
            this.tabAudio.Text = "Audio";
            this.tabAudio.UseVisualStyleBackColor = true;
            // 
            // groupBoxAudioFiltering
            // 
            this.groupBoxAudioFiltering.Controls.Add(this.numericUpDownHighPass);
            this.groupBoxAudioFiltering.Controls.Add(this.labelHighPass);
            this.groupBoxAudioFiltering.Controls.Add(this.numericUpDownLowPass);
            this.groupBoxAudioFiltering.Controls.Add(this.labelLowPass);
            this.groupBoxAudioFiltering.Controls.Add(this.numericUpDownResamplePrecision);
            this.groupBoxAudioFiltering.Controls.Add(this.labelResamplePrecision);
            this.groupBoxAudioFiltering.Controls.Add(this.comboBoxResampleDitherMethod);
            this.groupBoxAudioFiltering.Controls.Add(this.labelDitherMethod);
            this.groupBoxAudioFiltering.Controls.Add(this.comboBoxResampler);
            this.groupBoxAudioFiltering.Controls.Add(this.labelResampler);
            this.groupBoxAudioFiltering.Location = new System.Drawing.Point(6, 210);
            this.groupBoxAudioFiltering.Name = "groupBoxAudioFiltering";
            this.groupBoxAudioFiltering.Size = new System.Drawing.Size(555, 80);
            this.groupBoxAudioFiltering.TabIndex = 4;
            this.groupBoxAudioFiltering.TabStop = false;
            this.groupBoxAudioFiltering.Text = "Filtering";
            // 
            // numericUpDownHighPass
            // 
            this.numericUpDownHighPass.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownHighPass.Location = new System.Drawing.Point(260, 23);
            this.numericUpDownHighPass.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownHighPass.Name = "numericUpDownHighPass";
            this.numericUpDownHighPass.Size = new System.Drawing.Size(86, 20);
            this.numericUpDownHighPass.TabIndex = 11;
            this.numericUpDownHighPass.ValueChanged += new System.EventHandler(this.NumericUpDownHighPass_ValueChanged);
            // 
            // labelHighPass
            // 
            this.labelHighPass.AutoSize = true;
            this.labelHighPass.Location = new System.Drawing.Point(197, 25);
            this.labelHighPass.Name = "labelHighPass";
            this.labelHighPass.Size = new System.Drawing.Size(57, 13);
            this.labelHighPass.TabIndex = 10;
            this.labelHighPass.Text = "High-pass:";
            // 
            // numericUpDownLowPass
            // 
            this.numericUpDownLowPass.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownLowPass.Location = new System.Drawing.Point(72, 23);
            this.numericUpDownLowPass.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownLowPass.Name = "numericUpDownLowPass";
            this.numericUpDownLowPass.Size = new System.Drawing.Size(86, 20);
            this.numericUpDownLowPass.TabIndex = 9;
            this.numericUpDownLowPass.ValueChanged += new System.EventHandler(this.NumericUpDownLowPass_ValueChanged);
            // 
            // labelLowPass
            // 
            this.labelLowPass.AutoSize = true;
            this.labelLowPass.Location = new System.Drawing.Point(11, 25);
            this.labelLowPass.Name = "labelLowPass";
            this.labelLowPass.Size = new System.Drawing.Size(55, 13);
            this.labelLowPass.TabIndex = 8;
            this.labelLowPass.Text = "Low-pass:";
            // 
            // numericUpDownResamplePrecision
            // 
            this.numericUpDownResamplePrecision.Location = new System.Drawing.Point(503, 47);
            this.numericUpDownResamplePrecision.Name = "numericUpDownResamplePrecision";
            this.numericUpDownResamplePrecision.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownResamplePrecision.TabIndex = 7;
            this.numericUpDownResamplePrecision.ValueChanged += new System.EventHandler(this.NumericUpDownResamplePrecision_ValueChanged);
            // 
            // labelResamplePrecision
            // 
            this.labelResamplePrecision.AutoSize = true;
            this.labelResamplePrecision.Location = new System.Drawing.Point(392, 50);
            this.labelResamplePrecision.Name = "labelResamplePrecision";
            this.labelResamplePrecision.Size = new System.Drawing.Size(105, 13);
            this.labelResamplePrecision.TabIndex = 4;
            this.labelResamplePrecision.Text = "Resampler precision:";
            // 
            // comboBoxResampleDitherMethod
            // 
            this.comboBoxResampleDitherMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResampleDitherMethod.FormattingEnabled = true;
            this.comboBoxResampleDitherMethod.Location = new System.Drawing.Point(260, 47);
            this.comboBoxResampleDitherMethod.Name = "comboBoxResampleDitherMethod";
            this.comboBoxResampleDitherMethod.Size = new System.Drawing.Size(121, 21);
            this.comboBoxResampleDitherMethod.TabIndex = 3;
            this.comboBoxResampleDitherMethod.SelectedIndexChanged += new System.EventHandler(this.ComboBoxResampleDitherMethod_SelectedIndexChanged);
            // 
            // labelDitherMethod
            // 
            this.labelDitherMethod.AutoSize = true;
            this.labelDitherMethod.Location = new System.Drawing.Point(178, 50);
            this.labelDitherMethod.Name = "labelDitherMethod";
            this.labelDitherMethod.Size = new System.Drawing.Size(76, 13);
            this.labelDitherMethod.TabIndex = 2;
            this.labelDitherMethod.Text = "Dither method:";
            // 
            // comboBoxResampler
            // 
            this.comboBoxResampler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResampler.FormattingEnabled = true;
            this.comboBoxResampler.Location = new System.Drawing.Point(72, 46);
            this.comboBoxResampler.Name = "comboBoxResampler";
            this.comboBoxResampler.Size = new System.Drawing.Size(86, 21);
            this.comboBoxResampler.TabIndex = 1;
            this.comboBoxResampler.SelectedIndexChanged += new System.EventHandler(this.ComboBoxResampler_SelectedIndexChanged);
            // 
            // labelResampler
            // 
            this.labelResampler.AutoSize = true;
            this.labelResampler.Location = new System.Drawing.Point(6, 50);
            this.labelResampler.Name = "labelResampler";
            this.labelResampler.Size = new System.Drawing.Size(60, 13);
            this.labelResampler.TabIndex = 0;
            this.labelResampler.Text = "Resampler:";
            // 
            // groupBoxAudioBitrate
            // 
            this.groupBoxAudioBitrate.Controls.Add(this.labelVBRMode);
            this.groupBoxAudioBitrate.Controls.Add(this.comboBoxAudioVBRModes);
            this.groupBoxAudioBitrate.Controls.Add(this.labelAudioBitrate);
            this.groupBoxAudioBitrate.Controls.Add(this.checkBoxUseAudioVBR);
            this.groupBoxAudioBitrate.Controls.Add(this.comboBoxAudioBitrates);
            this.groupBoxAudioBitrate.Location = new System.Drawing.Point(6, 92);
            this.groupBoxAudioBitrate.Name = "groupBoxAudioBitrate";
            this.groupBoxAudioBitrate.Size = new System.Drawing.Size(152, 112);
            this.groupBoxAudioBitrate.TabIndex = 3;
            this.groupBoxAudioBitrate.TabStop = false;
            this.groupBoxAudioBitrate.Text = "Bitrate";
            // 
            // labelVBRMode
            // 
            this.labelVBRMode.AutoSize = true;
            this.labelVBRMode.Location = new System.Drawing.Point(25, 83);
            this.labelVBRMode.Name = "labelVBRMode";
            this.labelVBRMode.Size = new System.Drawing.Size(62, 13);
            this.labelVBRMode.TabIndex = 4;
            this.labelVBRMode.Text = "VBR Mode:";
            // 
            // comboBoxAudioVBRModes
            // 
            this.comboBoxAudioVBRModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioVBRModes.FormattingEnabled = true;
            this.comboBoxAudioVBRModes.Location = new System.Drawing.Point(93, 80);
            this.comboBoxAudioVBRModes.Name = "comboBoxAudioVBRModes";
            this.comboBoxAudioVBRModes.Size = new System.Drawing.Size(53, 21);
            this.comboBoxAudioVBRModes.TabIndex = 4;
            this.comboBoxAudioVBRModes.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAudioVBRModes_SelectedIndexChanged);
            // 
            // labelAudioBitrate
            // 
            this.labelAudioBitrate.AutoSize = true;
            this.labelAudioBitrate.Location = new System.Drawing.Point(6, 20);
            this.labelAudioBitrate.Name = "labelAudioBitrate";
            this.labelAudioBitrate.Size = new System.Drawing.Size(40, 13);
            this.labelAudioBitrate.TabIndex = 0;
            this.labelAudioBitrate.Text = "Bitrate:";
            // 
            // checkBoxUseAudioVBR
            // 
            this.checkBoxUseAudioVBR.AutoSize = true;
            this.checkBoxUseAudioVBR.Location = new System.Drawing.Point(6, 63);
            this.checkBoxUseAudioVBR.Name = "checkBoxUseAudioVBR";
            this.checkBoxUseAudioVBR.Size = new System.Drawing.Size(70, 17);
            this.checkBoxUseAudioVBR.TabIndex = 2;
            this.checkBoxUseAudioVBR.Text = "Use VBR";
            this.checkBoxUseAudioVBR.UseVisualStyleBackColor = true;
            this.checkBoxUseAudioVBR.CheckedChanged += new System.EventHandler(this.CheckBoxUseAudioVBR_CheckedChanged);
            // 
            // comboBoxAudioBitrates
            // 
            this.comboBoxAudioBitrates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioBitrates.FormattingEnabled = true;
            this.comboBoxAudioBitrates.Location = new System.Drawing.Point(53, 17);
            this.comboBoxAudioBitrates.Name = "comboBoxAudioBitrates";
            this.comboBoxAudioBitrates.Size = new System.Drawing.Size(75, 21);
            this.comboBoxAudioBitrates.TabIndex = 1;
            this.comboBoxAudioBitrates.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAudioBitrates_SelectedIndexChanged);
            // 
            // groupBoxAudioOutput
            // 
            this.groupBoxAudioOutput.Controls.Add(this.comboBoxChannels);
            this.groupBoxAudioOutput.Controls.Add(this.labelVolBoost);
            this.groupBoxAudioOutput.Controls.Add(this.numericUpDownVolumeBoost);
            this.groupBoxAudioOutput.Controls.Add(this.labelChannels);
            this.groupBoxAudioOutput.Controls.Add(this.comboBoxSampleRates);
            this.groupBoxAudioOutput.Controls.Add(this.labelSampleRate);
            this.groupBoxAudioOutput.Location = new System.Drawing.Point(164, 92);
            this.groupBoxAudioOutput.Name = "groupBoxAudioOutput";
            this.groupBoxAudioOutput.Size = new System.Drawing.Size(397, 112);
            this.groupBoxAudioOutput.TabIndex = 2;
            this.groupBoxAudioOutput.TabStop = false;
            this.groupBoxAudioOutput.Text = "Output";
            // 
            // comboBoxChannels
            // 
            this.comboBoxChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChannels.FormattingEnabled = true;
            this.comboBoxChannels.Location = new System.Drawing.Point(86, 36);
            this.comboBoxChannels.Name = "comboBoxChannels";
            this.comboBoxChannels.Size = new System.Drawing.Size(39, 21);
            this.comboBoxChannels.TabIndex = 3;
            this.comboBoxChannels.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChannels_SelectedIndexChanged);
            // 
            // labelVolBoost
            // 
            this.labelVolBoost.AutoSize = true;
            this.labelVolBoost.Location = new System.Drawing.Point(6, 67);
            this.labelVolBoost.Name = "labelVolBoost";
            this.labelVolBoost.Size = new System.Drawing.Size(74, 13);
            this.labelVolBoost.TabIndex = 5;
            this.labelVolBoost.Text = "Volume boost:";
            // 
            // numericUpDownVolumeBoost
            // 
            this.numericUpDownVolumeBoost.Location = new System.Drawing.Point(86, 63);
            this.numericUpDownVolumeBoost.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownVolumeBoost.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownVolumeBoost.Name = "numericUpDownVolumeBoost";
            this.numericUpDownVolumeBoost.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownVolumeBoost.TabIndex = 6;
            this.numericUpDownVolumeBoost.ValueChanged += new System.EventHandler(this.NumericUpDownVolumeBoost_ValueChanged);
            // 
            // labelChannels
            // 
            this.labelChannels.AutoSize = true;
            this.labelChannels.Location = new System.Drawing.Point(26, 39);
            this.labelChannels.Name = "labelChannels";
            this.labelChannels.Size = new System.Drawing.Size(54, 13);
            this.labelChannels.TabIndex = 1;
            this.labelChannels.Text = "Channels:";
            // 
            // comboBoxSampleRates
            // 
            this.comboBoxSampleRates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSampleRates.FormattingEnabled = true;
            this.comboBoxSampleRates.Location = new System.Drawing.Point(306, 34);
            this.comboBoxSampleRates.Name = "comboBoxSampleRates";
            this.comboBoxSampleRates.Size = new System.Drawing.Size(85, 21);
            this.comboBoxSampleRates.TabIndex = 2;
            this.comboBoxSampleRates.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSampleRates_SelectedIndexChanged);
            // 
            // labelSampleRate
            // 
            this.labelSampleRate.AutoSize = true;
            this.labelSampleRate.Location = new System.Drawing.Point(234, 37);
            this.labelSampleRate.Name = "labelSampleRate";
            this.labelSampleRate.Size = new System.Drawing.Size(66, 13);
            this.labelSampleRate.TabIndex = 0;
            this.labelSampleRate.Text = "Sample rate:";
            // 
            // groupBoxAudioCodec
            // 
            this.groupBoxAudioCodec.Controls.Add(this.comboBoxAudioCodecProfile);
            this.groupBoxAudioCodec.Controls.Add(this.labelAudioCodecProfile);
            this.groupBoxAudioCodec.Controls.Add(this.comboBoxAudioEncoders);
            this.groupBoxAudioCodec.Controls.Add(this.comboBoxAudioCodecs);
            this.groupBoxAudioCodec.Controls.Add(this.labelAudioEncoder);
            this.groupBoxAudioCodec.Controls.Add(this.labelAudioCodec);
            this.groupBoxAudioCodec.Location = new System.Drawing.Point(6, 6);
            this.groupBoxAudioCodec.Name = "groupBoxAudioCodec";
            this.groupBoxAudioCodec.Size = new System.Drawing.Size(555, 80);
            this.groupBoxAudioCodec.TabIndex = 0;
            this.groupBoxAudioCodec.TabStop = false;
            this.groupBoxAudioCodec.Text = "Format";
            // 
            // comboBoxAudioCodecProfile
            // 
            this.comboBoxAudioCodecProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioCodecProfile.FormattingEnabled = true;
            this.comboBoxAudioCodecProfile.Location = new System.Drawing.Point(421, 20);
            this.comboBoxAudioCodecProfile.Name = "comboBoxAudioCodecProfile";
            this.comboBoxAudioCodecProfile.Size = new System.Drawing.Size(128, 21);
            this.comboBoxAudioCodecProfile.TabIndex = 3;
            this.comboBoxAudioCodecProfile.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAudioCodecProfile_SelectedIndexChanged);
            // 
            // labelAudioCodecProfile
            // 
            this.labelAudioCodecProfile.AutoSize = true;
            this.labelAudioCodecProfile.Location = new System.Drawing.Point(376, 23);
            this.labelAudioCodecProfile.Name = "labelAudioCodecProfile";
            this.labelAudioCodecProfile.Size = new System.Drawing.Size(39, 13);
            this.labelAudioCodecProfile.TabIndex = 2;
            this.labelAudioCodecProfile.Text = "Profile:";
            // 
            // comboBoxAudioEncoders
            // 
            this.comboBoxAudioEncoders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioEncoders.FormattingEnabled = true;
            this.comboBoxAudioEncoders.Location = new System.Drawing.Point(62, 47);
            this.comboBoxAudioEncoders.Name = "comboBoxAudioEncoders";
            this.comboBoxAudioEncoders.Size = new System.Drawing.Size(128, 21);
            this.comboBoxAudioEncoders.TabIndex = 1;
            this.comboBoxAudioEncoders.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAudioEncoders_SelectedIndexChanged);
            // 
            // comboBoxAudioCodecs
            // 
            this.comboBoxAudioCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioCodecs.FormattingEnabled = true;
            this.comboBoxAudioCodecs.Location = new System.Drawing.Point(62, 20);
            this.comboBoxAudioCodecs.Name = "comboBoxAudioCodecs";
            this.comboBoxAudioCodecs.Size = new System.Drawing.Size(128, 21);
            this.comboBoxAudioCodecs.TabIndex = 1;
            this.comboBoxAudioCodecs.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAudioCodecs_SelectedIndexChanged);
            // 
            // labelAudioEncoder
            // 
            this.labelAudioEncoder.AutoSize = true;
            this.labelAudioEncoder.Location = new System.Drawing.Point(6, 50);
            this.labelAudioEncoder.Name = "labelAudioEncoder";
            this.labelAudioEncoder.Size = new System.Drawing.Size(50, 13);
            this.labelAudioEncoder.TabIndex = 0;
            this.labelAudioEncoder.Text = "Encoder:";
            // 
            // labelAudioCodec
            // 
            this.labelAudioCodec.AutoSize = true;
            this.labelAudioCodec.Location = new System.Drawing.Point(15, 23);
            this.labelAudioCodec.Name = "labelAudioCodec";
            this.labelAudioCodec.Size = new System.Drawing.Size(41, 13);
            this.labelAudioCodec.TabIndex = 0;
            this.labelAudioCodec.Text = "Codec:";
            // 
            // tabVideo
            // 
            this.tabVideo.Controls.Add(this.groupBoxVideoSize);
            this.tabVideo.Controls.Add(this.groupBoxVideoEncoding);
            this.tabVideo.Controls.Add(this.groupBoxVideoBitrate);
            this.tabVideo.Controls.Add(this.groupBoxVideoCodec);
            this.tabVideo.Location = new System.Drawing.Point(4, 22);
            this.tabVideo.Name = "tabVideo";
            this.tabVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideo.Size = new System.Drawing.Size(567, 296);
            this.tabVideo.TabIndex = 2;
            this.tabVideo.Text = "Video";
            this.tabVideo.UseVisualStyleBackColor = true;
            // 
            // groupBoxVideoSize
            // 
            this.groupBoxVideoSize.Controls.Add(this.numericUpDownTargetSize);
            this.groupBoxVideoSize.Controls.Add(this.numericUpDownBufferSize);
            this.groupBoxVideoSize.Controls.Add(this.labelTargetSize);
            this.groupBoxVideoSize.Controls.Add(this.labelBuffer);
            this.groupBoxVideoSize.Location = new System.Drawing.Point(7, 228);
            this.groupBoxVideoSize.Name = "groupBoxVideoSize";
            this.groupBoxVideoSize.Size = new System.Drawing.Size(250, 57);
            this.groupBoxVideoSize.TabIndex = 21;
            this.groupBoxVideoSize.TabStop = false;
            this.groupBoxVideoSize.Text = "Size (MB)";
            // 
            // numericUpDownTargetSize
            // 
            this.numericUpDownTargetSize.Location = new System.Drawing.Point(186, 22);
            this.numericUpDownTargetSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownTargetSize.Name = "numericUpDownTargetSize";
            this.numericUpDownTargetSize.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownTargetSize.TabIndex = 30;
            this.numericUpDownTargetSize.ValueChanged += new System.EventHandler(this.NumericUpDownTargetSize_ValueChanged);
            // 
            // numericUpDownBufferSize
            // 
            this.numericUpDownBufferSize.Location = new System.Drawing.Point(51, 22);
            this.numericUpDownBufferSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownBufferSize.Name = "numericUpDownBufferSize";
            this.numericUpDownBufferSize.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownBufferSize.TabIndex = 29;
            this.numericUpDownBufferSize.ValueChanged += new System.EventHandler(this.NumericUpDownBufferSize_ValueChanged);
            // 
            // labelTargetSize
            // 
            this.labelTargetSize.AutoSize = true;
            this.labelTargetSize.Location = new System.Drawing.Point(139, 24);
            this.labelTargetSize.Name = "labelTargetSize";
            this.labelTargetSize.Size = new System.Drawing.Size(41, 13);
            this.labelTargetSize.TabIndex = 17;
            this.labelTargetSize.Text = "Target:";
            // 
            // labelBuffer
            // 
            this.labelBuffer.AutoSize = true;
            this.labelBuffer.Location = new System.Drawing.Point(7, 25);
            this.labelBuffer.Name = "labelBuffer";
            this.labelBuffer.Size = new System.Drawing.Size(38, 13);
            this.labelBuffer.TabIndex = 9;
            this.labelBuffer.Text = "Buffer:";
            // 
            // groupBoxVideoEncoding
            // 
            this.groupBoxVideoEncoding.Controls.Add(this.labelMBCmp);
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownMBCmp);
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownMEPreCmp);
            this.groupBoxVideoEncoding.Controls.Add(this.labelMEPreCmp);
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownMECmp);
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownMESubCmp);
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownBFStrat);
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownTileRows);
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownTileColumns);
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownBFrames);
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownDiaSize);
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownTrellis);
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownGOPSize);
            this.groupBoxVideoEncoding.Controls.Add(this.labelMESubCmp);
            this.groupBoxVideoEncoding.Controls.Add(this.labelMECmp);
            this.groupBoxVideoEncoding.Controls.Add(this.comboBoxMEMethod);
            this.groupBoxVideoEncoding.Controls.Add(this.labelMEMethod);
            this.groupBoxVideoEncoding.Controls.Add(this.labelBFStrat);
            this.groupBoxVideoEncoding.Controls.Add(this.labelTileCols);
            this.groupBoxVideoEncoding.Controls.Add(this.labelTileRows);
            this.groupBoxVideoEncoding.Controls.Add(this.labelTrellis);
            this.groupBoxVideoEncoding.Controls.Add(this.labelDiaSize);
            this.groupBoxVideoEncoding.Controls.Add(this.labelGopSize);
            this.groupBoxVideoEncoding.Controls.Add(this.labelBFrames);
            this.groupBoxVideoEncoding.Location = new System.Drawing.Point(263, 92);
            this.groupBoxVideoEncoding.Name = "groupBoxVideoEncoding";
            this.groupBoxVideoEncoding.Size = new System.Drawing.Size(298, 193);
            this.groupBoxVideoEncoding.TabIndex = 3;
            this.groupBoxVideoEncoding.TabStop = false;
            this.groupBoxVideoEncoding.Text = "Encoding";
            // 
            // labelMBCmp
            // 
            this.labelMBCmp.AutoSize = true;
            this.labelMBCmp.Location = new System.Drawing.Point(197, 131);
            this.labelMBCmp.Name = "labelMBCmp";
            this.labelMBCmp.Size = new System.Drawing.Size(49, 13);
            this.labelMBCmp.TabIndex = 43;
            this.labelMBCmp.Text = "MB cmp:";
            // 
            // numericUpDownMBCmp
            // 
            this.numericUpDownMBCmp.Location = new System.Drawing.Point(252, 129);
            this.numericUpDownMBCmp.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericUpDownMBCmp.Name = "numericUpDownMBCmp";
            this.numericUpDownMBCmp.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownMBCmp.TabIndex = 42;
            this.numericUpDownMBCmp.ValueChanged += new System.EventHandler(this.NumericUpDownMBCmp_ValueChanged);
            // 
            // numericUpDownMEPreCmp
            // 
            this.numericUpDownMEPreCmp.Location = new System.Drawing.Point(77, 129);
            this.numericUpDownMEPreCmp.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericUpDownMEPreCmp.Name = "numericUpDownMEPreCmp";
            this.numericUpDownMEPreCmp.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownMEPreCmp.TabIndex = 41;
            this.numericUpDownMEPreCmp.ValueChanged += new System.EventHandler(this.NumericUpDownMEPreCmp_ValueChanged);
            // 
            // labelMEPreCmp
            // 
            this.labelMEPreCmp.AutoSize = true;
            this.labelMEPreCmp.Location = new System.Drawing.Point(7, 131);
            this.labelMEPreCmp.Name = "labelMEPreCmp";
            this.labelMEPreCmp.Size = new System.Drawing.Size(67, 13);
            this.labelMEPreCmp.TabIndex = 40;
            this.labelMEPreCmp.Text = "ME pre-cmp:";
            // 
            // numericUpDownMECmp
            // 
            this.numericUpDownMECmp.Location = new System.Drawing.Point(77, 102);
            this.numericUpDownMECmp.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericUpDownMECmp.Name = "numericUpDownMECmp";
            this.numericUpDownMECmp.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownMECmp.TabIndex = 39;
            this.numericUpDownMECmp.ValueChanged += new System.EventHandler(this.NumericUpDownMECmp_ValueChanged);
            // 
            // numericUpDownMESubCmp
            // 
            this.numericUpDownMESubCmp.Location = new System.Drawing.Point(252, 101);
            this.numericUpDownMESubCmp.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericUpDownMESubCmp.Name = "numericUpDownMESubCmp";
            this.numericUpDownMESubCmp.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownMESubCmp.TabIndex = 38;
            this.numericUpDownMESubCmp.ValueChanged += new System.EventHandler(this.NumericUpDownMESubCmp_ValueChanged);
            // 
            // numericUpDownBFStrat
            // 
            this.numericUpDownBFStrat.Location = new System.Drawing.Point(259, 45);
            this.numericUpDownBFStrat.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownBFStrat.Name = "numericUpDownBFStrat";
            this.numericUpDownBFStrat.Size = new System.Drawing.Size(32, 20);
            this.numericUpDownBFStrat.TabIndex = 37;
            this.numericUpDownBFStrat.ValueChanged += new System.EventHandler(this.NumericUpDownBFStrat_ValueChanged);
            // 
            // numericUpDownTileRows
            // 
            this.numericUpDownTileRows.Location = new System.Drawing.Point(77, 158);
            this.numericUpDownTileRows.Name = "numericUpDownTileRows";
            this.numericUpDownTileRows.Size = new System.Drawing.Size(32, 20);
            this.numericUpDownTileRows.TabIndex = 36;
            this.numericUpDownTileRows.ValueChanged += new System.EventHandler(this.NumericUpDownTileRows_ValueChanged);
            // 
            // numericUpDownTileColumns
            // 
            this.numericUpDownTileColumns.Location = new System.Drawing.Point(259, 158);
            this.numericUpDownTileColumns.Name = "numericUpDownTileColumns";
            this.numericUpDownTileColumns.Size = new System.Drawing.Size(32, 20);
            this.numericUpDownTileColumns.TabIndex = 35;
            this.numericUpDownTileColumns.ValueChanged += new System.EventHandler(this.NumericUpDownTileColumns_ValueChanged);
            // 
            // numericUpDownBFrames
            // 
            this.numericUpDownBFrames.Location = new System.Drawing.Point(77, 45);
            this.numericUpDownBFrames.Name = "numericUpDownBFrames";
            this.numericUpDownBFrames.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownBFrames.TabIndex = 34;
            this.numericUpDownBFrames.ValueChanged += new System.EventHandler(this.NumericUpDownBFrames_ValueChanged);
            // 
            // numericUpDownDiaSize
            // 
            this.numericUpDownDiaSize.Location = new System.Drawing.Point(77, 73);
            this.numericUpDownDiaSize.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownDiaSize.Name = "numericUpDownDiaSize";
            this.numericUpDownDiaSize.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownDiaSize.TabIndex = 33;
            this.numericUpDownDiaSize.ValueChanged += new System.EventHandler(this.NumericUpDownDiaSize_ValueChanged);
            // 
            // numericUpDownTrellis
            // 
            this.numericUpDownTrellis.Location = new System.Drawing.Point(259, 17);
            this.numericUpDownTrellis.Name = "numericUpDownTrellis";
            this.numericUpDownTrellis.Size = new System.Drawing.Size(33, 20);
            this.numericUpDownTrellis.TabIndex = 32;
            this.numericUpDownTrellis.ValueChanged += new System.EventHandler(this.NumericUpDownTrellis_ValueChanged);
            // 
            // numericUpDownGOPSize
            // 
            this.numericUpDownGOPSize.Location = new System.Drawing.Point(77, 17);
            this.numericUpDownGOPSize.Name = "numericUpDownGOPSize";
            this.numericUpDownGOPSize.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownGOPSize.TabIndex = 31;
            this.numericUpDownGOPSize.ValueChanged += new System.EventHandler(this.NumericUpDownGOPSize_ValueChanged);
            // 
            // labelMESubCmp
            // 
            this.labelMESubCmp.AutoSize = true;
            this.labelMESubCmp.Location = new System.Drawing.Point(180, 104);
            this.labelMESubCmp.Name = "labelMESubCmp";
            this.labelMESubCmp.Size = new System.Drawing.Size(66, 13);
            this.labelMESubCmp.TabIndex = 24;
            this.labelMESubCmp.Text = "ME subcmp:";
            // 
            // labelMECmp
            // 
            this.labelMECmp.AutoSize = true;
            this.labelMECmp.Location = new System.Drawing.Point(22, 104);
            this.labelMECmp.Name = "labelMECmp";
            this.labelMECmp.Size = new System.Drawing.Size(49, 13);
            this.labelMECmp.TabIndex = 22;
            this.labelMECmp.Text = "ME cmp:";
            // 
            // comboBoxMEMethod
            // 
            this.comboBoxMEMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMEMethod.FormattingEnabled = true;
            this.comboBoxMEMethod.Location = new System.Drawing.Point(226, 72);
            this.comboBoxMEMethod.Name = "comboBoxMEMethod";
            this.comboBoxMEMethod.Size = new System.Drawing.Size(66, 21);
            this.comboBoxMEMethod.TabIndex = 21;
            this.comboBoxMEMethod.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMEMethod_SelectedIndexChanged);
            // 
            // labelMEMethod
            // 
            this.labelMEMethod.AutoSize = true;
            this.labelMEMethod.Location = new System.Drawing.Point(155, 75);
            this.labelMEMethod.Name = "labelMEMethod";
            this.labelMEMethod.Size = new System.Drawing.Size(64, 13);
            this.labelMEMethod.TabIndex = 20;
            this.labelMEMethod.Text = "ME method:";
            // 
            // labelBFStrat
            // 
            this.labelBFStrat.AutoSize = true;
            this.labelBFStrat.Location = new System.Drawing.Point(190, 48);
            this.labelBFStrat.Name = "labelBFStrat";
            this.labelBFStrat.Size = new System.Drawing.Size(63, 13);
            this.labelBFStrat.TabIndex = 13;
            this.labelBFStrat.Text = "BF strategy:";
            // 
            // labelTileCols
            // 
            this.labelTileCols.AutoSize = true;
            this.labelTileCols.Location = new System.Drawing.Point(183, 161);
            this.labelTileCols.Name = "labelTileCols";
            this.labelTileCols.Size = new System.Drawing.Size(70, 13);
            this.labelTileCols.TabIndex = 11;
            this.labelTileCols.Text = "Tile Columns:";
            // 
            // labelTileRows
            // 
            this.labelTileRows.AutoSize = true;
            this.labelTileRows.Location = new System.Drawing.Point(14, 161);
            this.labelTileRows.Name = "labelTileRows";
            this.labelTileRows.Size = new System.Drawing.Size(57, 13);
            this.labelTileRows.TabIndex = 10;
            this.labelTileRows.Text = "Tile Rows:";
            // 
            // labelTrellis
            // 
            this.labelTrellis.AutoSize = true;
            this.labelTrellis.Location = new System.Drawing.Point(216, 21);
            this.labelTrellis.Name = "labelTrellis";
            this.labelTrellis.Size = new System.Drawing.Size(37, 13);
            this.labelTrellis.TabIndex = 9;
            this.labelTrellis.Text = "Trellis:";
            // 
            // labelDiaSize
            // 
            this.labelDiaSize.AutoSize = true;
            this.labelDiaSize.Location = new System.Drawing.Point(24, 75);
            this.labelDiaSize.Name = "labelDiaSize";
            this.labelDiaSize.Size = new System.Drawing.Size(47, 13);
            this.labelDiaSize.TabIndex = 8;
            this.labelDiaSize.Text = "Dia size:";
            // 
            // labelGopSize
            // 
            this.labelGopSize.AutoSize = true;
            this.labelGopSize.Location = new System.Drawing.Point(17, 21);
            this.labelGopSize.Name = "labelGopSize";
            this.labelGopSize.Size = new System.Drawing.Size(56, 13);
            this.labelGopSize.TabIndex = 7;
            this.labelGopSize.Text = "GOP Size:";
            // 
            // labelBFrames
            // 
            this.labelBFrames.AutoSize = true;
            this.labelBFrames.Location = new System.Drawing.Point(17, 48);
            this.labelBFrames.Name = "labelBFrames";
            this.labelBFrames.Size = new System.Drawing.Size(54, 13);
            this.labelBFrames.TabIndex = 6;
            this.labelBFrames.Text = "B-Frames:";
            // 
            // groupBoxVideoBitrate
            // 
            this.groupBoxVideoBitrate.Controls.Add(this.numericUpDownQMax);
            this.groupBoxVideoBitrate.Controls.Add(this.numericUpDownQMin);
            this.groupBoxVideoBitrate.Controls.Add(this.numericUpDownCRF);
            this.groupBoxVideoBitrate.Controls.Add(this.numericUpDownVideoMaxBitrate);
            this.groupBoxVideoBitrate.Controls.Add(this.numericUpDownVideoMinBitrate);
            this.groupBoxVideoBitrate.Controls.Add(this.numericUpDownVideoBitrate);
            this.groupBoxVideoBitrate.Controls.Add(this.labelQmax);
            this.groupBoxVideoBitrate.Controls.Add(this.checkBoxTwoPassEncoding);
            this.groupBoxVideoBitrate.Controls.Add(this.labelQmin);
            this.groupBoxVideoBitrate.Controls.Add(this.labelCRF);
            this.groupBoxVideoBitrate.Controls.Add(this.checkBoxUseCRF);
            this.groupBoxVideoBitrate.Controls.Add(this.labelMaxBitrate);
            this.groupBoxVideoBitrate.Controls.Add(this.labelMinBitrate);
            this.groupBoxVideoBitrate.Controls.Add(this.labelVideoBitrate);
            this.groupBoxVideoBitrate.Location = new System.Drawing.Point(6, 92);
            this.groupBoxVideoBitrate.Name = "groupBoxVideoBitrate";
            this.groupBoxVideoBitrate.Size = new System.Drawing.Size(251, 130);
            this.groupBoxVideoBitrate.TabIndex = 2;
            this.groupBoxVideoBitrate.TabStop = false;
            this.groupBoxVideoBitrate.Text = "Bitrate (kbps)";
            // 
            // numericUpDownQMax
            // 
            this.numericUpDownQMax.Location = new System.Drawing.Point(207, 102);
            this.numericUpDownQMax.Name = "numericUpDownQMax";
            this.numericUpDownQMax.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownQMax.TabIndex = 30;
            this.numericUpDownQMax.ValueChanged += new System.EventHandler(this.NumericUpDownQMax_ValueChanged);
            // 
            // numericUpDownQMin
            // 
            this.numericUpDownQMin.Location = new System.Drawing.Point(121, 101);
            this.numericUpDownQMin.Name = "numericUpDownQMin";
            this.numericUpDownQMin.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownQMin.TabIndex = 29;
            this.numericUpDownQMin.ValueChanged += new System.EventHandler(this.NumericUpDownQMin_ValueChanged);
            // 
            // numericUpDownCRF
            // 
            this.numericUpDownCRF.Location = new System.Drawing.Point(39, 101);
            this.numericUpDownCRF.Name = "numericUpDownCRF";
            this.numericUpDownCRF.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownCRF.TabIndex = 3;
            this.numericUpDownCRF.ValueChanged += new System.EventHandler(this.NumericUpDownCRF_ValueChanged);
            // 
            // numericUpDownVideoMaxBitrate
            // 
            this.numericUpDownVideoMaxBitrate.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownVideoMaxBitrate.Location = new System.Drawing.Point(62, 45);
            this.numericUpDownVideoMaxBitrate.Maximum = new decimal(new int[] {
            1500000,
            0,
            0,
            0});
            this.numericUpDownVideoMaxBitrate.Name = "numericUpDownVideoMaxBitrate";
            this.numericUpDownVideoMaxBitrate.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownVideoMaxBitrate.TabIndex = 28;
            this.numericUpDownVideoMaxBitrate.ValueChanged += new System.EventHandler(this.NumericUpDownVideoMaxBitrate_ValueChanged);
            // 
            // numericUpDownVideoMinBitrate
            // 
            this.numericUpDownVideoMinBitrate.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownVideoMinBitrate.Location = new System.Drawing.Point(181, 17);
            this.numericUpDownVideoMinBitrate.Maximum = new decimal(new int[] {
            15000000,
            0,
            0,
            0});
            this.numericUpDownVideoMinBitrate.Name = "numericUpDownVideoMinBitrate";
            this.numericUpDownVideoMinBitrate.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownVideoMinBitrate.TabIndex = 27;
            this.numericUpDownVideoMinBitrate.ValueChanged += new System.EventHandler(this.NumericUpDownVideoMinBitrate_ValueChanged);
            // 
            // numericUpDownVideoBitrate
            // 
            this.numericUpDownVideoBitrate.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownVideoBitrate.Location = new System.Drawing.Point(62, 19);
            this.numericUpDownVideoBitrate.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.numericUpDownVideoBitrate.Name = "numericUpDownVideoBitrate";
            this.numericUpDownVideoBitrate.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownVideoBitrate.TabIndex = 26;
            this.numericUpDownVideoBitrate.ValueChanged += new System.EventHandler(this.NumericUpDownVideoBitrate_ValueChanged);
            // 
            // labelQmax
            // 
            this.labelQmax.AutoSize = true;
            this.labelQmax.Location = new System.Drawing.Point(164, 104);
            this.labelQmax.Name = "labelQmax";
            this.labelQmax.Size = new System.Drawing.Size(37, 13);
            this.labelQmax.TabIndex = 23;
            this.labelQmax.Text = "Qmax:";
            // 
            // checkBoxTwoPassEncoding
            // 
            this.checkBoxTwoPassEncoding.AutoSize = true;
            this.checkBoxTwoPassEncoding.Location = new System.Drawing.Point(6, 73);
            this.checkBoxTwoPassEncoding.Name = "checkBoxTwoPassEncoding";
            this.checkBoxTwoPassEncoding.Size = new System.Drawing.Size(119, 17);
            this.checkBoxTwoPassEncoding.TabIndex = 2;
            this.checkBoxTwoPassEncoding.Text = "Two-pass encoding";
            this.checkBoxTwoPassEncoding.UseVisualStyleBackColor = true;
            this.checkBoxTwoPassEncoding.CheckedChanged += new System.EventHandler(this.CheckBoxTwoPassEncoding_CheckedChanged);
            // 
            // labelQmin
            // 
            this.labelQmin.AutoSize = true;
            this.labelQmin.Location = new System.Drawing.Point(83, 104);
            this.labelQmin.Name = "labelQmin";
            this.labelQmin.Size = new System.Drawing.Size(34, 13);
            this.labelQmin.TabIndex = 21;
            this.labelQmin.Text = "Qmin:";
            // 
            // labelCRF
            // 
            this.labelCRF.AutoSize = true;
            this.labelCRF.Location = new System.Drawing.Point(4, 103);
            this.labelCRF.Name = "labelCRF";
            this.labelCRF.Size = new System.Drawing.Size(31, 13);
            this.labelCRF.TabIndex = 12;
            this.labelCRF.Text = "CRF:";
            // 
            // checkBoxUseCRF
            // 
            this.checkBoxUseCRF.AutoSize = true;
            this.checkBoxUseCRF.Location = new System.Drawing.Point(176, 73);
            this.checkBoxUseCRF.Name = "checkBoxUseCRF";
            this.checkBoxUseCRF.Size = new System.Drawing.Size(69, 17);
            this.checkBoxUseCRF.TabIndex = 11;
            this.checkBoxUseCRF.Text = "Use CRF";
            this.checkBoxUseCRF.UseVisualStyleBackColor = true;
            this.checkBoxUseCRF.CheckedChanged += new System.EventHandler(this.CheckBoxUseCRF_CheckedChanged);
            // 
            // labelMaxBitrate
            // 
            this.labelMaxBitrate.AutoSize = true;
            this.labelMaxBitrate.Location = new System.Drawing.Point(26, 48);
            this.labelMaxBitrate.Name = "labelMaxBitrate";
            this.labelMaxBitrate.Size = new System.Drawing.Size(30, 13);
            this.labelMaxBitrate.TabIndex = 5;
            this.labelMaxBitrate.Text = "Max:";
            // 
            // labelMinBitrate
            // 
            this.labelMinBitrate.AutoSize = true;
            this.labelMinBitrate.Location = new System.Drawing.Point(148, 19);
            this.labelMinBitrate.Name = "labelMinBitrate";
            this.labelMinBitrate.Size = new System.Drawing.Size(27, 13);
            this.labelMinBitrate.TabIndex = 2;
            this.labelMinBitrate.Text = "Min:";
            // 
            // labelVideoBitrate
            // 
            this.labelVideoBitrate.AutoSize = true;
            this.labelVideoBitrate.Location = new System.Drawing.Point(6, 21);
            this.labelVideoBitrate.Name = "labelVideoBitrate";
            this.labelVideoBitrate.Size = new System.Drawing.Size(50, 13);
            this.labelVideoBitrate.TabIndex = 0;
            this.labelVideoBitrate.Text = "Average:";
            // 
            // groupBoxVideoCodec
            // 
            this.groupBoxVideoCodec.Controls.Add(this.labelVideoEncoderPreset);
            this.groupBoxVideoCodec.Controls.Add(this.comboBoxVideoCodecLevels);
            this.groupBoxVideoCodec.Controls.Add(this.comboBoxVideoEncoders);
            this.groupBoxVideoCodec.Controls.Add(this.comboBoxVideoEncoderPresets);
            this.groupBoxVideoCodec.Controls.Add(this.labelVideoEncoder);
            this.groupBoxVideoCodec.Controls.Add(this.comboBoxVCodecProfile);
            this.groupBoxVideoCodec.Controls.Add(this.labelVCodecProfile);
            this.groupBoxVideoCodec.Controls.Add(this.comboBoxVideoCodecs);
            this.groupBoxVideoCodec.Controls.Add(this.labelVideoCodec);
            this.groupBoxVideoCodec.Controls.Add(this.labelVCodecLevel);
            this.groupBoxVideoCodec.Location = new System.Drawing.Point(6, 6);
            this.groupBoxVideoCodec.Name = "groupBoxVideoCodec";
            this.groupBoxVideoCodec.Size = new System.Drawing.Size(555, 80);
            this.groupBoxVideoCodec.TabIndex = 0;
            this.groupBoxVideoCodec.TabStop = false;
            this.groupBoxVideoCodec.Text = "Format";
            // 
            // labelVideoEncoderPreset
            // 
            this.labelVideoEncoderPreset.AutoSize = true;
            this.labelVideoEncoderPreset.Location = new System.Drawing.Point(391, 50);
            this.labelVideoEncoderPreset.Name = "labelVideoEncoderPreset";
            this.labelVideoEncoderPreset.Size = new System.Drawing.Size(40, 13);
            this.labelVideoEncoderPreset.TabIndex = 4;
            this.labelVideoEncoderPreset.Text = "Preset:";
            // 
            // comboBoxVideoCodecLevels
            // 
            this.comboBoxVideoCodecLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideoCodecLevels.FormattingEnabled = true;
            this.comboBoxVideoCodecLevels.Location = new System.Drawing.Point(500, 20);
            this.comboBoxVideoCodecLevels.Name = "comboBoxVideoCodecLevels";
            this.comboBoxVideoCodecLevels.Size = new System.Drawing.Size(49, 21);
            this.comboBoxVideoCodecLevels.TabIndex = 5;
            this.comboBoxVideoCodecLevels.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVideoCodecLevels_SelectedIndexChanged);
            // 
            // comboBoxVideoEncoders
            // 
            this.comboBoxVideoEncoders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideoEncoders.FormattingEnabled = true;
            this.comboBoxVideoEncoders.Location = new System.Drawing.Point(62, 47);
            this.comboBoxVideoEncoders.Name = "comboBoxVideoEncoders";
            this.comboBoxVideoEncoders.Size = new System.Drawing.Size(128, 21);
            this.comboBoxVideoEncoders.TabIndex = 1;
            this.comboBoxVideoEncoders.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVideoEncoders_SelectedIndexChanged);
            // 
            // comboBoxVideoEncoderPresets
            // 
            this.comboBoxVideoEncoderPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideoEncoderPresets.FormattingEnabled = true;
            this.comboBoxVideoEncoderPresets.Location = new System.Drawing.Point(437, 47);
            this.comboBoxVideoEncoderPresets.Name = "comboBoxVideoEncoderPresets";
            this.comboBoxVideoEncoderPresets.Size = new System.Drawing.Size(112, 21);
            this.comboBoxVideoEncoderPresets.TabIndex = 3;
            this.comboBoxVideoEncoderPresets.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVideoEncoderPresets_SelectedIndexChanged);
            // 
            // labelVideoEncoder
            // 
            this.labelVideoEncoder.AutoSize = true;
            this.labelVideoEncoder.Location = new System.Drawing.Point(6, 50);
            this.labelVideoEncoder.Name = "labelVideoEncoder";
            this.labelVideoEncoder.Size = new System.Drawing.Size(50, 13);
            this.labelVideoEncoder.TabIndex = 0;
            this.labelVideoEncoder.Text = "Encoder:";
            // 
            // comboBoxVCodecProfile
            // 
            this.comboBoxVCodecProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVCodecProfile.FormattingEnabled = true;
            this.comboBoxVCodecProfile.Location = new System.Drawing.Point(257, 19);
            this.comboBoxVCodecProfile.Name = "comboBoxVCodecProfile";
            this.comboBoxVCodecProfile.Size = new System.Drawing.Size(133, 21);
            this.comboBoxVCodecProfile.TabIndex = 3;
            this.comboBoxVCodecProfile.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVCodecProfile_SelectedIndexChanged);
            // 
            // labelVCodecProfile
            // 
            this.labelVCodecProfile.AutoSize = true;
            this.labelVCodecProfile.Location = new System.Drawing.Point(212, 23);
            this.labelVCodecProfile.Name = "labelVCodecProfile";
            this.labelVCodecProfile.Size = new System.Drawing.Size(39, 13);
            this.labelVCodecProfile.TabIndex = 3;
            this.labelVCodecProfile.Text = "Profile:";
            // 
            // comboBoxVideoCodecs
            // 
            this.comboBoxVideoCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideoCodecs.FormattingEnabled = true;
            this.comboBoxVideoCodecs.Location = new System.Drawing.Point(62, 20);
            this.comboBoxVideoCodecs.Name = "comboBoxVideoCodecs";
            this.comboBoxVideoCodecs.Size = new System.Drawing.Size(128, 21);
            this.comboBoxVideoCodecs.TabIndex = 1;
            this.comboBoxVideoCodecs.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVideoCodecs_SelectedIndexChanged);
            // 
            // labelVideoCodec
            // 
            this.labelVideoCodec.AutoSize = true;
            this.labelVideoCodec.Location = new System.Drawing.Point(15, 23);
            this.labelVideoCodec.Name = "labelVideoCodec";
            this.labelVideoCodec.Size = new System.Drawing.Size(41, 13);
            this.labelVideoCodec.TabIndex = 0;
            this.labelVideoCodec.Text = "Codec:";
            // 
            // labelVCodecLevel
            // 
            this.labelVCodecLevel.AutoSize = true;
            this.labelVCodecLevel.Location = new System.Drawing.Point(458, 23);
            this.labelVCodecLevel.Name = "labelVCodecLevel";
            this.labelVCodecLevel.Size = new System.Drawing.Size(36, 13);
            this.labelVCodecLevel.TabIndex = 4;
            this.labelVCodecLevel.Text = "Level:";
            // 
            // labelPixelFormat
            // 
            this.labelPixelFormat.AutoSize = true;
            this.labelPixelFormat.Location = new System.Drawing.Point(6, 27);
            this.labelPixelFormat.Name = "labelPixelFormat";
            this.labelPixelFormat.Size = new System.Drawing.Size(64, 13);
            this.labelPixelFormat.TabIndex = 5;
            this.labelPixelFormat.Text = "Pixel format:";
            // 
            // comboBoxPixelFormat
            // 
            this.comboBoxPixelFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPixelFormat.FormattingEnabled = true;
            this.comboBoxPixelFormat.Location = new System.Drawing.Point(76, 24);
            this.comboBoxPixelFormat.Name = "comboBoxPixelFormat";
            this.comboBoxPixelFormat.Size = new System.Drawing.Size(126, 21);
            this.comboBoxPixelFormat.TabIndex = 3;
            this.comboBoxPixelFormat.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPixelFormat_SelectedIndexChanged);
            // 
            // tabPicture
            // 
            this.tabPicture.Controls.Add(this.groupBoxPictureFiltering);
            this.tabPicture.Controls.Add(this.groupBoxLayout);
            this.tabPicture.Controls.Add(this.groupBoxScreen);
            this.tabPicture.Controls.Add(this.groupBoxResolution);
            this.tabPicture.Location = new System.Drawing.Point(4, 22);
            this.tabPicture.Name = "tabPicture";
            this.tabPicture.Padding = new System.Windows.Forms.Padding(3);
            this.tabPicture.Size = new System.Drawing.Size(567, 296);
            this.tabPicture.TabIndex = 1;
            this.tabPicture.Text = "Picture";
            this.tabPicture.UseVisualStyleBackColor = true;
            // 
            // groupBoxPictureFiltering
            // 
            this.groupBoxPictureFiltering.Controls.Add(this.checkBoxDeinterlace);
            this.groupBoxPictureFiltering.Controls.Add(this.labelLayoutColour);
            this.groupBoxPictureFiltering.Controls.Add(this.textBoxLayoutColour);
            this.groupBoxPictureFiltering.Controls.Add(this.comboBoxPixelFormat);
            this.groupBoxPictureFiltering.Controls.Add(this.labelPixelFormat);
            this.groupBoxPictureFiltering.Location = new System.Drawing.Point(6, 210);
            this.groupBoxPictureFiltering.Name = "groupBoxPictureFiltering";
            this.groupBoxPictureFiltering.Size = new System.Drawing.Size(555, 80);
            this.groupBoxPictureFiltering.TabIndex = 4;
            this.groupBoxPictureFiltering.TabStop = false;
            this.groupBoxPictureFiltering.Text = "Filtering";
            // 
            // checkBoxDeinterlace
            // 
            this.checkBoxDeinterlace.AutoSize = true;
            this.checkBoxDeinterlace.Location = new System.Drawing.Point(6, 57);
            this.checkBoxDeinterlace.Name = "checkBoxDeinterlace";
            this.checkBoxDeinterlace.Size = new System.Drawing.Size(80, 17);
            this.checkBoxDeinterlace.TabIndex = 1;
            this.checkBoxDeinterlace.Text = "Deinterlace";
            this.checkBoxDeinterlace.UseVisualStyleBackColor = true;
            this.checkBoxDeinterlace.CheckedChanged += new System.EventHandler(this.CheckBoxDeinterlace_CheckedChanged);
            // 
            // labelLayoutColour
            // 
            this.labelLayoutColour.AutoSize = true;
            this.labelLayoutColour.Enabled = false;
            this.labelLayoutColour.Location = new System.Drawing.Point(362, 27);
            this.labelLayoutColour.Name = "labelLayoutColour";
            this.labelLayoutColour.Size = new System.Drawing.Size(81, 13);
            this.labelLayoutColour.TabIndex = 10;
            this.labelLayoutColour.Text = "Padding colour:";
            // 
            // textBoxLayoutColour
            // 
            this.textBoxLayoutColour.Enabled = false;
            this.textBoxLayoutColour.Location = new System.Drawing.Point(449, 24);
            this.textBoxLayoutColour.Name = "textBoxLayoutColour";
            this.textBoxLayoutColour.Size = new System.Drawing.Size(100, 20);
            this.textBoxLayoutColour.TabIndex = 11;
            this.textBoxLayoutColour.TextChanged += new System.EventHandler(this.TextBoxLayoutColour_TextChanged);
            // 
            // groupBoxLayout
            // 
            this.groupBoxLayout.Controls.Add(this.numericUpDownLayoutHoriz);
            this.groupBoxLayout.Controls.Add(this.numericUpDownLayoutVert);
            this.groupBoxLayout.Controls.Add(this.numericUpDownLayoutHeight);
            this.groupBoxLayout.Controls.Add(this.numericUpDownLayoutWidth);
            this.groupBoxLayout.Controls.Add(this.labelHoriz);
            this.groupBoxLayout.Controls.Add(this.labelVert);
            this.groupBoxLayout.Controls.Add(this.labelLayoutHeight);
            this.groupBoxLayout.Controls.Add(this.labelLayoutWidth);
            this.groupBoxLayout.Controls.Add(this.checkBoxPad);
            this.groupBoxLayout.Controls.Add(this.checkBoxCrop);
            this.groupBoxLayout.Location = new System.Drawing.Point(268, 6);
            this.groupBoxLayout.Name = "groupBoxLayout";
            this.groupBoxLayout.Size = new System.Drawing.Size(293, 198);
            this.groupBoxLayout.TabIndex = 2;
            this.groupBoxLayout.TabStop = false;
            this.groupBoxLayout.Text = "Layout";
            // 
            // numericUpDownLayoutHoriz
            // 
            this.numericUpDownLayoutHoriz.Location = new System.Drawing.Point(129, 127);
            this.numericUpDownLayoutHoriz.Maximum = new decimal(new int[] {
            15360,
            0,
            0,
            0});
            this.numericUpDownLayoutHoriz.Name = "numericUpDownLayoutHoriz";
            this.numericUpDownLayoutHoriz.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownLayoutHoriz.TabIndex = 21;
            this.numericUpDownLayoutHoriz.ValueChanged += new System.EventHandler(this.NumericUpDownLayoutHoriz_ValueChanged);
            // 
            // numericUpDownLayoutVert
            // 
            this.numericUpDownLayoutVert.Location = new System.Drawing.Point(229, 92);
            this.numericUpDownLayoutVert.Maximum = new decimal(new int[] {
            8640,
            0,
            0,
            0});
            this.numericUpDownLayoutVert.Name = "numericUpDownLayoutVert";
            this.numericUpDownLayoutVert.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownLayoutVert.TabIndex = 20;
            this.numericUpDownLayoutVert.ValueChanged += new System.EventHandler(this.NumericUpDownLayoutVert_ValueChanged);
            // 
            // numericUpDownLayoutHeight
            // 
            this.numericUpDownLayoutHeight.Location = new System.Drawing.Point(53, 92);
            this.numericUpDownLayoutHeight.Name = "numericUpDownLayoutHeight";
            this.numericUpDownLayoutHeight.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownLayoutHeight.TabIndex = 19;
            this.numericUpDownLayoutHeight.ValueChanged += new System.EventHandler(this.NumericUpDownLayoutHeight_ValueChanged);
            // 
            // numericUpDownLayoutWidth
            // 
            this.numericUpDownLayoutWidth.Location = new System.Drawing.Point(129, 61);
            this.numericUpDownLayoutWidth.Maximum = new decimal(new int[] {
            15360,
            0,
            0,
            0});
            this.numericUpDownLayoutWidth.Name = "numericUpDownLayoutWidth";
            this.numericUpDownLayoutWidth.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownLayoutWidth.TabIndex = 18;
            this.numericUpDownLayoutWidth.ValueChanged += new System.EventHandler(this.NumericUpDownLayoutWidth_ValueChanged);
            // 
            // labelHoriz
            // 
            this.labelHoriz.AutoSize = true;
            this.labelHoriz.Enabled = false;
            this.labelHoriz.Location = new System.Drawing.Point(89, 129);
            this.labelHoriz.Name = "labelHoriz";
            this.labelHoriz.Size = new System.Drawing.Size(34, 13);
            this.labelHoriz.TabIndex = 8;
            this.labelHoriz.Text = "Horiz:";
            // 
            // labelVert
            // 
            this.labelVert.AutoSize = true;
            this.labelVert.Enabled = false;
            this.labelVert.Location = new System.Drawing.Point(194, 94);
            this.labelVert.Name = "labelVert";
            this.labelVert.Size = new System.Drawing.Size(29, 13);
            this.labelVert.TabIndex = 6;
            this.labelVert.Text = "Vert:";
            // 
            // labelLayoutHeight
            // 
            this.labelLayoutHeight.AutoSize = true;
            this.labelLayoutHeight.Enabled = false;
            this.labelLayoutHeight.Location = new System.Drawing.Point(6, 94);
            this.labelLayoutHeight.Name = "labelLayoutHeight";
            this.labelLayoutHeight.Size = new System.Drawing.Size(41, 13);
            this.labelLayoutHeight.TabIndex = 4;
            this.labelLayoutHeight.Text = "Height:";
            // 
            // labelLayoutWidth
            // 
            this.labelLayoutWidth.AutoSize = true;
            this.labelLayoutWidth.Enabled = false;
            this.labelLayoutWidth.Location = new System.Drawing.Point(85, 63);
            this.labelLayoutWidth.Name = "labelLayoutWidth";
            this.labelLayoutWidth.Size = new System.Drawing.Size(38, 13);
            this.labelLayoutWidth.TabIndex = 2;
            this.labelLayoutWidth.Text = "Width:";
            // 
            // checkBoxPad
            // 
            this.checkBoxPad.AutoSize = true;
            this.checkBoxPad.Location = new System.Drawing.Point(242, 20);
            this.checkBoxPad.Name = "checkBoxPad";
            this.checkBoxPad.Size = new System.Drawing.Size(45, 17);
            this.checkBoxPad.TabIndex = 1;
            this.checkBoxPad.Text = "Pad";
            this.checkBoxPad.UseVisualStyleBackColor = true;
            this.checkBoxPad.CheckedChanged += new System.EventHandler(this.CheckBoxPad_CheckedChanged);
            // 
            // checkBoxCrop
            // 
            this.checkBoxCrop.AutoSize = true;
            this.checkBoxCrop.Location = new System.Drawing.Point(9, 20);
            this.checkBoxCrop.Name = "checkBoxCrop";
            this.checkBoxCrop.Size = new System.Drawing.Size(48, 17);
            this.checkBoxCrop.TabIndex = 0;
            this.checkBoxCrop.Text = "Crop";
            this.checkBoxCrop.UseVisualStyleBackColor = true;
            this.checkBoxCrop.CheckedChanged += new System.EventHandler(this.CheckBoxCrop_CheckedChanged);
            // 
            // groupBoxScreen
            // 
            this.groupBoxScreen.Controls.Add(this.numericUpDownFPS);
            this.groupBoxScreen.Controls.Add(this.numericUpDownRatioB);
            this.groupBoxScreen.Controls.Add(this.numericUpDownRatioA);
            this.groupBoxScreen.Controls.Add(this.labelFPS);
            this.groupBoxScreen.Controls.Add(this.labelRatioDash);
            this.groupBoxScreen.Controls.Add(this.labelRatio);
            this.groupBoxScreen.Controls.Add(this.checkBoxAspectRatio);
            this.groupBoxScreen.Location = new System.Drawing.Point(6, 133);
            this.groupBoxScreen.Name = "groupBoxScreen";
            this.groupBoxScreen.Size = new System.Drawing.Size(256, 70);
            this.groupBoxScreen.TabIndex = 1;
            this.groupBoxScreen.TabStop = false;
            this.groupBoxScreen.Text = "Screen";
            // 
            // numericUpDownFPS
            // 
            this.numericUpDownFPS.Location = new System.Drawing.Point(210, 41);
            this.numericUpDownFPS.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.numericUpDownFPS.Name = "numericUpDownFPS";
            this.numericUpDownFPS.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownFPS.TabIndex = 12;
            this.numericUpDownFPS.ValueChanged += new System.EventHandler(this.NumericUpDownFPS_ValueChanged);
            // 
            // numericUpDownRatioB
            // 
            this.numericUpDownRatioB.Location = new System.Drawing.Point(109, 41);
            this.numericUpDownRatioB.Name = "numericUpDownRatioB";
            this.numericUpDownRatioB.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownRatioB.TabIndex = 12;
            this.numericUpDownRatioB.ValueChanged += new System.EventHandler(this.NumericUpDownRatio_ValueChanged);
            // 
            // numericUpDownRatioA
            // 
            this.numericUpDownRatioA.Location = new System.Drawing.Point(47, 41);
            this.numericUpDownRatioA.Name = "numericUpDownRatioA";
            this.numericUpDownRatioA.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownRatioA.TabIndex = 12;
            this.numericUpDownRatioA.ValueChanged += new System.EventHandler(this.NumericUpDownRatio_ValueChanged);
            // 
            // labelFPS
            // 
            this.labelFPS.AutoSize = true;
            this.labelFPS.Location = new System.Drawing.Point(174, 43);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.Size = new System.Drawing.Size(30, 13);
            this.labelFPS.TabIndex = 6;
            this.labelFPS.Text = "FPS:";
            // 
            // labelRatioDash
            // 
            this.labelRatioDash.AutoSize = true;
            this.labelRatioDash.Enabled = false;
            this.labelRatioDash.Location = new System.Drawing.Point(93, 43);
            this.labelRatioDash.Name = "labelRatioDash";
            this.labelRatioDash.Size = new System.Drawing.Size(10, 13);
            this.labelRatioDash.TabIndex = 4;
            this.labelRatioDash.Text = ":";
            // 
            // labelRatio
            // 
            this.labelRatio.AutoSize = true;
            this.labelRatio.Enabled = false;
            this.labelRatio.Location = new System.Drawing.Point(6, 43);
            this.labelRatio.Name = "labelRatio";
            this.labelRatio.Size = new System.Drawing.Size(35, 13);
            this.labelRatio.TabIndex = 2;
            this.labelRatio.Text = "Ratio:";
            // 
            // checkBoxAspectRatio
            // 
            this.checkBoxAspectRatio.AutoSize = true;
            this.checkBoxAspectRatio.Location = new System.Drawing.Point(6, 19);
            this.checkBoxAspectRatio.Name = "checkBoxAspectRatio";
            this.checkBoxAspectRatio.Size = new System.Drawing.Size(82, 17);
            this.checkBoxAspectRatio.TabIndex = 0;
            this.checkBoxAspectRatio.Text = "Aspect ratio";
            this.checkBoxAspectRatio.UseVisualStyleBackColor = true;
            this.checkBoxAspectRatio.CheckedChanged += new System.EventHandler(this.CheckBoxAspectRatio_CheckedChanged);
            // 
            // groupBoxResolution
            // 
            this.groupBoxResolution.Controls.Add(this.numericUpDownHeight);
            this.groupBoxResolution.Controls.Add(this.numericUpDownWidth);
            this.groupBoxResolution.Controls.Add(this.comboBoxScalingMethods);
            this.groupBoxResolution.Controls.Add(this.labelMethod);
            this.groupBoxResolution.Controls.Add(this.labelHeight);
            this.groupBoxResolution.Controls.Add(this.radioButtonCustomRes);
            this.groupBoxResolution.Controls.Add(this.radioButtonHalfRes);
            this.groupBoxResolution.Controls.Add(this.radioButtonKeepRes);
            this.groupBoxResolution.Location = new System.Drawing.Point(6, 6);
            this.groupBoxResolution.Name = "groupBoxResolution";
            this.groupBoxResolution.Size = new System.Drawing.Size(256, 121);
            this.groupBoxResolution.TabIndex = 0;
            this.groupBoxResolution.TabStop = false;
            this.groupBoxResolution.Text = "Resolution";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(192, 63);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            8640,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownHeight.TabIndex = 17;
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.NumericUpDownHeight_ValueChanged);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(68, 63);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            15360,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownWidth.TabIndex = 16;
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.NumericUpDownWidth_ValueChanged);
            // 
            // comboBoxScalingMethods
            // 
            this.comboBoxScalingMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScalingMethods.FormattingEnabled = true;
            this.comboBoxScalingMethods.Location = new System.Drawing.Point(91, 90);
            this.comboBoxScalingMethods.Name = "comboBoxScalingMethods";
            this.comboBoxScalingMethods.Size = new System.Drawing.Size(159, 21);
            this.comboBoxScalingMethods.TabIndex = 1;
            this.comboBoxScalingMethods.SelectedIndexChanged += new System.EventHandler(this.ComboBoxScalingMethods_SelectedIndexChanged);
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Location = new System.Drawing.Point(6, 94);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(83, 13);
            this.labelMethod.TabIndex = 0;
            this.labelMethod.Text = "Scaling method:";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(145, 65);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(41, 13);
            this.labelHeight.TabIndex = 4;
            this.labelHeight.Text = "Height:";
            // 
            // radioButtonCustomRes
            // 
            this.radioButtonCustomRes.AutoSize = true;
            this.radioButtonCustomRes.Location = new System.Drawing.Point(6, 65);
            this.radioButtonCustomRes.Name = "radioButtonCustomRes";
            this.radioButtonCustomRes.Size = new System.Drawing.Size(56, 17);
            this.radioButtonCustomRes.TabIndex = 2;
            this.radioButtonCustomRes.TabStop = true;
            this.radioButtonCustomRes.Text = "Width:";
            this.radioButtonCustomRes.UseVisualStyleBackColor = true;
            this.radioButtonCustomRes.CheckedChanged += new System.EventHandler(this.RadioButtonCustomRes_CheckedChanged);
            // 
            // radioButtonHalfRes
            // 
            this.radioButtonHalfRes.AutoSize = true;
            this.radioButtonHalfRes.Location = new System.Drawing.Point(6, 42);
            this.radioButtonHalfRes.Name = "radioButtonHalfRes";
            this.radioButtonHalfRes.Size = new System.Drawing.Size(92, 17);
            this.radioButtonHalfRes.TabIndex = 1;
            this.radioButtonHalfRes.TabStop = true;
            this.radioButtonHalfRes.Text = "Half resolution";
            this.radioButtonHalfRes.UseVisualStyleBackColor = true;
            this.radioButtonHalfRes.CheckedChanged += new System.EventHandler(this.RadioButtonHalfRes_CheckedChanged);
            // 
            // radioButtonKeepRes
            // 
            this.radioButtonKeepRes.AutoSize = true;
            this.radioButtonKeepRes.Location = new System.Drawing.Point(6, 19);
            this.radioButtonKeepRes.Name = "radioButtonKeepRes";
            this.radioButtonKeepRes.Size = new System.Drawing.Size(134, 17);
            this.radioButtonKeepRes.TabIndex = 0;
            this.radioButtonKeepRes.TabStop = true;
            this.radioButtonKeepRes.Text = "Keep original resolution";
            this.radioButtonKeepRes.UseVisualStyleBackColor = true;
            this.radioButtonKeepRes.CheckedChanged += new System.EventHandler(this.RadioButtonKeepRes_CheckedChanged);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.groupBoxFileOutput);
            this.tabMain.Controls.Add(this.groupBoxSession);
            this.tabMain.Controls.Add(this.groupBoxEncoding);
            this.tabMain.Controls.Add(this.groupBoxFiles);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(567, 296);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // groupBoxFileOutput
            // 
            this.groupBoxFileOutput.Controls.Add(this.checkBoxFastStartTagging);
            this.groupBoxFileOutput.Controls.Add(this.textBoxOutputFilename);
            this.groupBoxFileOutput.Controls.Add(this.labelOutputFilename);
            this.groupBoxFileOutput.Controls.Add(this.checkBoxOverwrite);
            this.groupBoxFileOutput.Controls.Add(this.labelOutput);
            this.groupBoxFileOutput.Controls.Add(this.buttonBrowseOutput);
            this.groupBoxFileOutput.Controls.Add(this.textBoxTargetFolder);
            this.groupBoxFileOutput.Location = new System.Drawing.Point(6, 92);
            this.groupBoxFileOutput.Name = "groupBoxFileOutput";
            this.groupBoxFileOutput.Size = new System.Drawing.Size(555, 112);
            this.groupBoxFileOutput.TabIndex = 3;
            this.groupBoxFileOutput.TabStop = false;
            this.groupBoxFileOutput.Text = "Output";
            // 
            // checkBoxFastStartTagging
            // 
            this.checkBoxFastStartTagging.AutoSize = true;
            this.checkBoxFastStartTagging.Location = new System.Drawing.Point(377, 89);
            this.checkBoxFastStartTagging.Name = "checkBoxFastStartTagging";
            this.checkBoxFastStartTagging.Size = new System.Drawing.Size(178, 17);
            this.checkBoxFastStartTagging.TabIndex = 9;
            this.checkBoxFastStartTagging.Text = "Move tag data at begining of file";
            this.checkBoxFastStartTagging.UseVisualStyleBackColor = true;
            this.checkBoxFastStartTagging.CheckedChanged += new System.EventHandler(this.CheckBoxFastStartTagging_CheckedChanged);
            // 
            // textBoxOutputFilename
            // 
            this.textBoxOutputFilename.Enabled = false;
            this.textBoxOutputFilename.Location = new System.Drawing.Point(82, 47);
            this.textBoxOutputFilename.Name = "textBoxOutputFilename";
            this.textBoxOutputFilename.Size = new System.Drawing.Size(467, 20);
            this.textBoxOutputFilename.TabIndex = 8;
            this.textBoxOutputFilename.TextChanged += new System.EventHandler(this.TextBoxOutputFilename_TextChanged);
            // 
            // labelOutputFilename
            // 
            this.labelOutputFilename.AutoSize = true;
            this.labelOutputFilename.Enabled = false;
            this.labelOutputFilename.Location = new System.Drawing.Point(26, 50);
            this.labelOutputFilename.Name = "labelOutputFilename";
            this.labelOutputFilename.Size = new System.Drawing.Size(52, 13);
            this.labelOutputFilename.TabIndex = 7;
            this.labelOutputFilename.Text = "Filename:";
            // 
            // checkBoxOverwrite
            // 
            this.checkBoxOverwrite.AutoSize = true;
            this.checkBoxOverwrite.Enabled = false;
            this.checkBoxOverwrite.Location = new System.Drawing.Point(6, 89);
            this.checkBoxOverwrite.Name = "checkBoxOverwrite";
            this.checkBoxOverwrite.Size = new System.Drawing.Size(125, 17);
            this.checkBoxOverwrite.TabIndex = 6;
            this.checkBoxOverwrite.Text = "Overwrite existing file";
            this.checkBoxOverwrite.UseVisualStyleBackColor = true;
            this.checkBoxOverwrite.CheckedChanged += new System.EventHandler(this.CheckBoxOverwrite_CheckedChanged);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(8, 23);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(70, 13);
            this.labelOutput.TabIndex = 1;
            this.labelOutput.Text = "Target folder:";
            // 
            // buttonBrowseOutput
            // 
            this.buttonBrowseOutput.Location = new System.Drawing.Point(474, 19);
            this.buttonBrowseOutput.Name = "buttonBrowseOutput";
            this.buttonBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseOutput.TabIndex = 5;
            this.buttonBrowseOutput.Text = "Browse...";
            this.buttonBrowseOutput.UseVisualStyleBackColor = true;
            this.buttonBrowseOutput.Click += new System.EventHandler(this.ButtonBrowseTargetFolder_Click);
            // 
            // textBoxTargetFolder
            // 
            this.textBoxTargetFolder.Location = new System.Drawing.Point(82, 20);
            this.textBoxTargetFolder.Name = "textBoxTargetFolder";
            this.textBoxTargetFolder.Size = new System.Drawing.Size(385, 20);
            this.textBoxTargetFolder.TabIndex = 3;
            this.textBoxTargetFolder.TextChanged += new System.EventHandler(this.TextBoxTargetFolder_TextChanged);
            this.textBoxTargetFolder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_FSFilter);
            // 
            // groupBoxSession
            // 
            this.groupBoxSession.Controls.Add(this.radioButtonRefresh);
            this.groupBoxSession.Controls.Add(this.radioButtonKeep);
            this.groupBoxSession.Location = new System.Drawing.Point(480, 210);
            this.groupBoxSession.Name = "groupBoxSession";
            this.groupBoxSession.Size = new System.Drawing.Size(81, 80);
            this.groupBoxSession.TabIndex = 2;
            this.groupBoxSession.TabStop = false;
            this.groupBoxSession.Text = "Session";
            // 
            // radioButtonRefresh
            // 
            this.radioButtonRefresh.AutoSize = true;
            this.radioButtonRefresh.Location = new System.Drawing.Point(6, 45);
            this.radioButtonRefresh.Name = "radioButtonRefresh";
            this.radioButtonRefresh.Size = new System.Drawing.Size(62, 17);
            this.radioButtonRefresh.TabIndex = 2;
            this.radioButtonRefresh.TabStop = true;
            this.radioButtonRefresh.Text = "Refresh";
            this.radioButtonRefresh.UseVisualStyleBackColor = true;
            this.radioButtonRefresh.CheckedChanged += new System.EventHandler(this.RadioButtonRefresh_CheckedChanged);
            // 
            // radioButtonKeep
            // 
            this.radioButtonKeep.AutoSize = true;
            this.radioButtonKeep.Location = new System.Drawing.Point(6, 22);
            this.radioButtonKeep.Name = "radioButtonKeep";
            this.radioButtonKeep.Size = new System.Drawing.Size(50, 17);
            this.radioButtonKeep.TabIndex = 1;
            this.radioButtonKeep.TabStop = true;
            this.radioButtonKeep.Text = "Keep";
            this.radioButtonKeep.UseVisualStyleBackColor = true;
            this.radioButtonKeep.CheckedChanged += new System.EventHandler(this.RadioButtonKeep_CheckedChanged);
            // 
            // groupBoxEncoding
            // 
            this.groupBoxEncoding.Controls.Add(this.numericUpDownProcessors);
            this.groupBoxEncoding.Controls.Add(this.numericUpDownThreads);
            this.groupBoxEncoding.Controls.Add(this.labelProcessors);
            this.groupBoxEncoding.Controls.Add(this.labelThreads);
            this.groupBoxEncoding.Controls.Add(this.comboBoxContainers);
            this.groupBoxEncoding.Controls.Add(this.labelFormat);
            this.groupBoxEncoding.Controls.Add(this.comboBoxPresets);
            this.groupBoxEncoding.Controls.Add(this.labelPreset);
            this.groupBoxEncoding.Location = new System.Drawing.Point(6, 210);
            this.groupBoxEncoding.Name = "groupBoxEncoding";
            this.groupBoxEncoding.Size = new System.Drawing.Size(468, 80);
            this.groupBoxEncoding.TabIndex = 1;
            this.groupBoxEncoding.TabStop = false;
            this.groupBoxEncoding.Text = "Encoding";
            // 
            // numericUpDownProcessors
            // 
            this.numericUpDownProcessors.Location = new System.Drawing.Point(413, 46);
            this.numericUpDownProcessors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownProcessors.Name = "numericUpDownProcessors";
            this.numericUpDownProcessors.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownProcessors.TabIndex = 9;
            this.numericUpDownProcessors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownProcessors.ValueChanged += new System.EventHandler(this.NumericUpDownProcessors_ValueChanged);
            // 
            // numericUpDownThreads
            // 
            this.numericUpDownThreads.Location = new System.Drawing.Point(283, 46);
            this.numericUpDownThreads.Name = "numericUpDownThreads";
            this.numericUpDownThreads.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownThreads.TabIndex = 8;
            this.numericUpDownThreads.ValueChanged += new System.EventHandler(this.NumericUpDownThreads_ValueChanged);
            // 
            // labelProcessors
            // 
            this.labelProcessors.AutoSize = true;
            this.labelProcessors.Location = new System.Drawing.Point(346, 49);
            this.labelProcessors.Name = "labelProcessors";
            this.labelProcessors.Size = new System.Drawing.Size(62, 13);
            this.labelProcessors.TabIndex = 7;
            this.labelProcessors.Text = "Processors:";
            // 
            // labelThreads
            // 
            this.labelThreads.AutoSize = true;
            this.labelThreads.Location = new System.Drawing.Point(230, 49);
            this.labelThreads.Name = "labelThreads";
            this.labelThreads.Size = new System.Drawing.Size(49, 13);
            this.labelThreads.TabIndex = 6;
            this.labelThreads.Text = "Threads:";
            // 
            // comboBoxContainers
            // 
            this.comboBoxContainers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContainers.FormattingEnabled = true;
            this.comboBoxContainers.Location = new System.Drawing.Point(54, 45);
            this.comboBoxContainers.Name = "comboBoxContainers";
            this.comboBoxContainers.Size = new System.Drawing.Size(160, 21);
            this.comboBoxContainers.TabIndex = 3;
            this.comboBoxContainers.SelectedIndexChanged += new System.EventHandler(this.ComboBoxContainers_SelectedIndexChanged);
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(8, 48);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(42, 13);
            this.labelFormat.TabIndex = 2;
            this.labelFormat.Text = "Format:";
            // 
            // comboBoxPresets
            // 
            this.comboBoxPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPresets.FormattingEnabled = true;
            this.comboBoxPresets.Location = new System.Drawing.Point(54, 18);
            this.comboBoxPresets.Name = "comboBoxPresets";
            this.comboBoxPresets.Size = new System.Drawing.Size(408, 21);
            this.comboBoxPresets.Sorted = true;
            this.comboBoxPresets.TabIndex = 1;
            this.comboBoxPresets.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPresets_SelectedIndexChanged);
            // 
            // labelPreset
            // 
            this.labelPreset.AutoSize = true;
            this.labelPreset.Location = new System.Drawing.Point(8, 21);
            this.labelPreset.Name = "labelPreset";
            this.labelPreset.Size = new System.Drawing.Size(40, 13);
            this.labelPreset.TabIndex = 0;
            this.labelPreset.Text = "Preset:";
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Controls.Add(this.buttonBrowseAudioStream);
            this.groupBoxFiles.Controls.Add(this.labelAudioStream);
            this.groupBoxFiles.Controls.Add(this.textBoxAudioStream);
            this.groupBoxFiles.Controls.Add(this.buttonBrowseInput);
            this.groupBoxFiles.Controls.Add(this.textBoxInFile);
            this.groupBoxFiles.Controls.Add(this.labelSourceInput);
            this.groupBoxFiles.Location = new System.Drawing.Point(6, 6);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(555, 80);
            this.groupBoxFiles.TabIndex = 0;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Files";
            // 
            // buttonBrowseAudioStream
            // 
            this.buttonBrowseAudioStream.Location = new System.Drawing.Point(474, 45);
            this.buttonBrowseAudioStream.Name = "buttonBrowseAudioStream";
            this.buttonBrowseAudioStream.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseAudioStream.TabIndex = 7;
            this.buttonBrowseAudioStream.Text = "Browse...";
            this.buttonBrowseAudioStream.UseVisualStyleBackColor = true;
            this.buttonBrowseAudioStream.Click += new System.EventHandler(this.ButtonBrowseAudioStream_Click);
            // 
            // labelAudioStream
            // 
            this.labelAudioStream.AutoSize = true;
            this.labelAudioStream.Location = new System.Drawing.Point(7, 49);
            this.labelAudioStream.Name = "labelAudioStream";
            this.labelAudioStream.Size = new System.Drawing.Size(71, 13);
            this.labelAudioStream.TabIndex = 6;
            this.labelAudioStream.Text = "Audio stream:";
            // 
            // textBoxAudioStream
            // 
            this.textBoxAudioStream.Location = new System.Drawing.Point(82, 47);
            this.textBoxAudioStream.Name = "textBoxAudioStream";
            this.textBoxAudioStream.Size = new System.Drawing.Size(385, 20);
            this.textBoxAudioStream.TabIndex = 5;
            this.textBoxAudioStream.TextChanged += new System.EventHandler(this.TextBoxAudioStream_TextChanged);
            // 
            // buttonBrowseInput
            // 
            this.buttonBrowseInput.Location = new System.Drawing.Point(474, 19);
            this.buttonBrowseInput.Name = "buttonBrowseInput";
            this.buttonBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseInput.TabIndex = 4;
            this.buttonBrowseInput.Text = "Browse...";
            this.buttonBrowseInput.UseVisualStyleBackColor = true;
            this.buttonBrowseInput.Click += new System.EventHandler(this.ButtonBrowseInput_Click);
            // 
            // textBoxInFile
            // 
            this.textBoxInFile.AllowDrop = true;
            this.textBoxInFile.Location = new System.Drawing.Point(82, 20);
            this.textBoxInFile.Name = "textBoxInFile";
            this.textBoxInFile.Size = new System.Drawing.Size(386, 20);
            this.textBoxInFile.TabIndex = 2;
            this.textBoxInFile.TextChanged += new System.EventHandler(this.TextBoxInFile_TextChanged);
            this.textBoxInFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBoxInFile_DragDrop);
            this.textBoxInFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxInFile_DragEnter);
            this.textBoxInFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_FSFilter);
            // 
            // labelSourceInput
            // 
            this.labelSourceInput.AutoSize = true;
            this.labelSourceInput.Location = new System.Drawing.Point(7, 23);
            this.labelSourceInput.Name = "labelSourceInput";
            this.labelSourceInput.Size = new System.Drawing.Size(70, 13);
            this.labelSourceInput.TabIndex = 0;
            this.labelSourceInput.Text = "Source input:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMain);
            this.tabControl.Controls.Add(this.tabVideo);
            this.tabControl.Controls.Add(this.tabAudio);
            this.tabControl.Controls.Add(this.tabPicture);
            this.tabControl.Controls.Add(this.tabTagging);
            this.tabControl.Controls.Add(this.tabOptions);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(575, 322);
            this.tabControl.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 398);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "FFmpeg Catapult";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabOptions.ResumeLayout(false);
            this.groupBoxDefaultPaths.ResumeLayout(false);
            this.groupBoxDefaultPaths.PerformLayout();
            this.groupBoxSessionOptions.ResumeLayout(false);
            this.groupBoxSessionOptions.PerformLayout();
            this.groupBoxBinaries.ResumeLayout(false);
            this.groupBoxBinaries.PerformLayout();
            this.tabTagging.ResumeLayout(false);
            this.groupBoxBroadcast.ResumeLayout(false);
            this.groupBoxBroadcast.PerformLayout();
            this.groupBoxGeneralTags.ResumeLayout(false);
            this.groupBoxGeneralTags.PerformLayout();
            this.tabAudio.ResumeLayout(false);
            this.groupBoxAudioFiltering.ResumeLayout(false);
            this.groupBoxAudioFiltering.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResamplePrecision)).EndInit();
            this.groupBoxAudioBitrate.ResumeLayout(false);
            this.groupBoxAudioBitrate.PerformLayout();
            this.groupBoxAudioOutput.ResumeLayout(false);
            this.groupBoxAudioOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolumeBoost)).EndInit();
            this.groupBoxAudioCodec.ResumeLayout(false);
            this.groupBoxAudioCodec.PerformLayout();
            this.tabVideo.ResumeLayout(false);
            this.groupBoxVideoSize.ResumeLayout(false);
            this.groupBoxVideoSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTargetSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBufferSize)).EndInit();
            this.groupBoxVideoEncoding.ResumeLayout(false);
            this.groupBoxVideoEncoding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMBCmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMEPreCmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMECmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMESubCmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBFStrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiaSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrellis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGOPSize)).EndInit();
            this.groupBoxVideoBitrate.ResumeLayout(false);
            this.groupBoxVideoBitrate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCRF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVideoMaxBitrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVideoMinBitrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVideoBitrate)).EndInit();
            this.groupBoxVideoCodec.ResumeLayout(false);
            this.groupBoxVideoCodec.PerformLayout();
            this.tabPicture.ResumeLayout(false);
            this.groupBoxPictureFiltering.ResumeLayout(false);
            this.groupBoxPictureFiltering.PerformLayout();
            this.groupBoxLayout.ResumeLayout(false);
            this.groupBoxLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLayoutHoriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLayoutVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLayoutHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLayoutWidth)).EndInit();
            this.groupBoxScreen.ResumeLayout(false);
            this.groupBoxScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRatioB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRatioA)).EndInit();
            this.groupBoxResolution.ResumeLayout(false);
            this.groupBoxResolution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.groupBoxFileOutput.ResumeLayout(false);
            this.groupBoxFileOutput.PerformLayout();
            this.groupBoxSession.ResumeLayout(false);
            this.groupBoxSession.PerformLayout();
            this.groupBoxEncoding.ResumeLayout(false);
            this.groupBoxEncoding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProcessors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreads)).EndInit();
            this.groupBoxFiles.ResumeLayout(false);
            this.groupBoxFiles.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.GroupBox groupBoxBinaries;
        private System.Windows.Forms.TextBox textBoxTermArgs;
        private System.Windows.Forms.Label labelTermArgs;
        private System.Windows.Forms.TextBox textBoxTermBin;
        private System.Windows.Forms.Label labelTermBin;
        private System.Windows.Forms.Button buttonBrowseTermBin;
        private System.Windows.Forms.Button buttonBrowseFFmpegBin;
        private System.Windows.Forms.TextBox textBoxFFmpegBin;
        private System.Windows.Forms.Label labelFFmpegBin;
        private System.Windows.Forms.TabPage tabTagging;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.TextBox textBoxAlbumArtist;
        private System.Windows.Forms.Label labelAlbumArtist;
        private System.Windows.Forms.GroupBox groupBoxBroadcast;
        private System.Windows.Forms.TextBox textBoxTotalDiscs;
        private System.Windows.Forms.Label labelOfDiscs;
        private System.Windows.Forms.TextBox textBoxDisc;
        private System.Windows.Forms.Label labelDisc;
        private System.Windows.Forms.TextBox textBoxTotalTracks;
        private System.Windows.Forms.Label labelOfTrack;
        private System.Windows.Forms.TextBox textBoxTrack;
        private System.Windows.Forms.Label labelTrack;
        private System.Windows.Forms.GroupBox groupBoxGeneralTags;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.TextBox textBoxAlbum;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabPage tabAudio;
        private System.Windows.Forms.GroupBox groupBoxAudioBitrate;
        private System.Windows.Forms.Label labelAudioBitrate;
        private System.Windows.Forms.CheckBox checkBoxUseAudioVBR;
        private System.Windows.Forms.ComboBox comboBoxAudioBitrates;
        private System.Windows.Forms.GroupBox groupBoxAudioOutput;
        private System.Windows.Forms.ComboBox comboBoxChannels;
        private System.Windows.Forms.Label labelChannels;
        private System.Windows.Forms.ComboBox comboBoxSampleRates;
        private System.Windows.Forms.Label labelSampleRate;
        private System.Windows.Forms.ComboBox comboBoxAudioEncoders;
        private System.Windows.Forms.Label labelAudioEncoder;
        private System.Windows.Forms.GroupBox groupBoxAudioCodec;
        private System.Windows.Forms.ComboBox comboBoxAudioCodecs;
        private System.Windows.Forms.Label labelAudioCodec;
        private System.Windows.Forms.TabPage tabVideo;
        private System.Windows.Forms.GroupBox groupBoxVideoBitrate;
        private System.Windows.Forms.Label labelQmax;
        private System.Windows.Forms.Label labelQmin;
        private System.Windows.Forms.Label labelCRF;
        private System.Windows.Forms.CheckBox checkBoxUseCRF;
        private System.Windows.Forms.Label labelBuffer;
        private System.Windows.Forms.Label labelMaxBitrate;
        private System.Windows.Forms.Label labelMinBitrate;
        private System.Windows.Forms.Label labelVideoBitrate;
        private System.Windows.Forms.ComboBox comboBoxVideoEncoders;
        private System.Windows.Forms.Label labelVideoEncoder;
        private System.Windows.Forms.GroupBox groupBoxVideoCodec;
        private System.Windows.Forms.CheckBox checkBoxTwoPassEncoding;
        private System.Windows.Forms.ComboBox comboBoxVideoCodecs;
        private System.Windows.Forms.Label labelVideoCodec;
        private System.Windows.Forms.TabPage tabPicture;
        private System.Windows.Forms.ComboBox comboBoxScalingMethods;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.GroupBox groupBoxLayout;
        private System.Windows.Forms.TextBox textBoxLayoutColour;
        private System.Windows.Forms.Label labelLayoutColour;
        private System.Windows.Forms.Label labelHoriz;
        private System.Windows.Forms.Label labelVert;
        private System.Windows.Forms.Label labelLayoutHeight;
        private System.Windows.Forms.Label labelLayoutWidth;
        private System.Windows.Forms.CheckBox checkBoxPad;
        private System.Windows.Forms.CheckBox checkBoxCrop;
        private System.Windows.Forms.GroupBox groupBoxScreen;
        private System.Windows.Forms.Label labelFPS;
        private System.Windows.Forms.Label labelRatioDash;
        private System.Windows.Forms.Label labelRatio;
        private System.Windows.Forms.CheckBox checkBoxDeinterlace;
        private System.Windows.Forms.CheckBox checkBoxAspectRatio;
        private System.Windows.Forms.GroupBox groupBoxResolution;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.RadioButton radioButtonCustomRes;
        private System.Windows.Forms.RadioButton radioButtonHalfRes;
        private System.Windows.Forms.RadioButton radioButtonKeepRes;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.GroupBox groupBoxSession;
        private System.Windows.Forms.RadioButton radioButtonRefresh;
        private System.Windows.Forms.RadioButton radioButtonKeep;
        private System.Windows.Forms.GroupBox groupBoxEncoding;
        private System.Windows.Forms.ComboBox comboBoxContainers;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.ComboBox comboBoxPresets;
        private System.Windows.Forms.Label labelPreset;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.CheckBox checkBoxOverwrite;
        private System.Windows.Forms.Button buttonBrowseOutput;
        private System.Windows.Forms.Button buttonBrowseInput;
        private System.Windows.Forms.TextBox textBoxTargetFolder;
        private System.Windows.Forms.TextBox textBoxInFile;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelSourceInput;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.GroupBox groupBoxSessionOptions;
        private System.Windows.Forms.CheckBox checkBoxWriteLog;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxBinArgs;
        private System.Windows.Forms.Label labelBinArgs;
        private System.Windows.Forms.Label labelVideoEncoderPreset;
        private System.Windows.Forms.ComboBox comboBoxVideoEncoderPresets;
        private System.Windows.Forms.Label labelPixelFormat;
        private System.Windows.Forms.ComboBox comboBoxPixelFormat;
        private System.Windows.Forms.ComboBox comboBoxVCodecProfile;
        private System.Windows.Forms.Label labelVCodecLevel;
        private System.Windows.Forms.Label labelVCodecProfile;
        private System.Windows.Forms.GroupBox groupBoxVideoEncoding;
        private System.Windows.Forms.ComboBox comboBoxVideoCodecLevels;
        private System.Windows.Forms.GroupBox groupBoxVideoSize;
        private System.Windows.Forms.Label labelTargetSize;
        private System.Windows.Forms.Label labelDiaSize;
        private System.Windows.Forms.Label labelGopSize;
        private System.Windows.Forms.Label labelBFrames;
        private System.Windows.Forms.Label labelTrellis;
        private System.Windows.Forms.Label labelTileCols;
        private System.Windows.Forms.Label labelTileRows;
        private System.Windows.Forms.Label labelBFStrat;
        private System.Windows.Forms.ComboBox comboBoxMEMethod;
        private System.Windows.Forms.Label labelMEMethod;
        private System.Windows.Forms.Label labelMESubCmp;
        private System.Windows.Forms.Label labelMECmp;
        private System.Windows.Forms.ComboBox comboBoxAudioCodecProfile;
        private System.Windows.Forms.Label labelAudioCodecProfile;
        private System.Windows.Forms.GroupBox groupBoxFileOutput;
        private System.Windows.Forms.Label labelOutputFilename;
        private System.Windows.Forms.Button buttonBrowseAudioStream;
        private System.Windows.Forms.Label labelAudioStream;
        private System.Windows.Forms.TextBox textBoxAudioStream;
        private System.Windows.Forms.TextBox textBoxOutputFilename;
        private System.Windows.Forms.Label labelProcessors;
        private System.Windows.Forms.Label labelThreads;
        private System.Windows.Forms.ComboBox comboBoxAudioVBRModes;
        private System.Windows.Forms.Label labelVBRMode;
        private System.Windows.Forms.GroupBox groupBoxAudioFiltering;
        private System.Windows.Forms.GroupBox groupBoxPictureFiltering;
        private System.Windows.Forms.NumericUpDown numericUpDownProcessors;
        private System.Windows.Forms.NumericUpDown numericUpDownThreads;
        private System.Windows.Forms.NumericUpDown numericUpDownRatioB;
        private System.Windows.Forms.NumericUpDown numericUpDownRatioA;
        private System.Windows.Forms.NumericUpDown numericUpDownTargetSize;
        private System.Windows.Forms.NumericUpDown numericUpDownBufferSize;
        private System.Windows.Forms.NumericUpDown numericUpDownVideoMaxBitrate;
        private System.Windows.Forms.NumericUpDown numericUpDownVideoMinBitrate;
        private System.Windows.Forms.NumericUpDown numericUpDownVideoBitrate;
        private System.Windows.Forms.NumericUpDown numericUpDownQMax;
        private System.Windows.Forms.NumericUpDown numericUpDownQMin;
        private System.Windows.Forms.NumericUpDown numericUpDownCRF;
        private System.Windows.Forms.NumericUpDown numericUpDownTileRows;
        private System.Windows.Forms.NumericUpDown numericUpDownTileColumns;
        private System.Windows.Forms.NumericUpDown numericUpDownBFrames;
        private System.Windows.Forms.NumericUpDown numericUpDownDiaSize;
        private System.Windows.Forms.NumericUpDown numericUpDownTrellis;
        private System.Windows.Forms.NumericUpDown numericUpDownGOPSize;
        private System.Windows.Forms.NumericUpDown numericUpDownLayoutHoriz;
        private System.Windows.Forms.NumericUpDown numericUpDownLayoutVert;
        private System.Windows.Forms.NumericUpDown numericUpDownLayoutHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownLayoutWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownFPS;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label labelResamplePrecision;
        private System.Windows.Forms.ComboBox comboBoxResampleDitherMethod;
        private System.Windows.Forms.Label labelDitherMethod;
        private System.Windows.Forms.ComboBox comboBoxResampler;
        private System.Windows.Forms.Label labelResampler;
        private System.Windows.Forms.NumericUpDown numericUpDownResamplePrecision;
        private System.Windows.Forms.NumericUpDown numericUpDownVolumeBoost;
        private System.Windows.Forms.Label labelVolBoost;
        private System.Windows.Forms.NumericUpDown numericUpDownHighPass;
        private System.Windows.Forms.Label labelHighPass;
        private System.Windows.Forms.NumericUpDown numericUpDownLowPass;
        private System.Windows.Forms.Label labelLowPass;
        private System.Windows.Forms.TextBox textBoxCopyright;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.CheckBox checkBoxCompilation;
        private System.Windows.Forms.TextBox textBoxNetwork;
        private System.Windows.Forms.TextBox textBoxEpisodeId;
        private System.Windows.Forms.TextBox textBoxShow;
        private System.Windows.Forms.Label labelNetwork;
        private System.Windows.Forms.Label labelEpisodeId;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxSynopsis;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelSynopsis;
        private System.Windows.Forms.GroupBox groupBoxDefaultPaths;
        private System.Windows.Forms.Button buttonBrowseDefaultOutputPath;
        private System.Windows.Forms.TextBox textBoxDefaultOutputFolder;
        private System.Windows.Forms.Button buttonBrowseDefaultInputPath;
        private System.Windows.Forms.TextBox textBoxDefaultSourceFolder;
        private System.Windows.Forms.Label labelDefaultOutputPath;
        private System.Windows.Forms.Label labelDefaultInputPath;
        private System.Windows.Forms.CheckBox checkBoxUrlFilenames;
        private System.Windows.Forms.CheckBox checkBoxFastStartTagging;
        private System.Windows.Forms.NumericUpDown numericUpDownMESubCmp;
        private System.Windows.Forms.NumericUpDown numericUpDownBFStrat;
        private System.Windows.Forms.Label labelMBCmp;
        private System.Windows.Forms.NumericUpDown numericUpDownMBCmp;
        private System.Windows.Forms.NumericUpDown numericUpDownMEPreCmp;
        private System.Windows.Forms.Label labelMEPreCmp;
        private System.Windows.Forms.NumericUpDown numericUpDownMECmp;
    }
}

