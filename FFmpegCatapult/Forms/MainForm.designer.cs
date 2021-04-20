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
            this.groupBoxMiscTags = new System.Windows.Forms.GroupBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.textBoxAlbumArtist = new System.Windows.Forms.TextBox();
            this.labelAlbumArtist = new System.Windows.Forms.Label();
            this.groupBoxTrackTags = new System.Windows.Forms.GroupBox();
            this.textBoxTotalDiscs = new System.Windows.Forms.TextBox();
            this.labelOfDiscs = new System.Windows.Forms.Label();
            this.textBoxDisc = new System.Windows.Forms.TextBox();
            this.labelDisc = new System.Windows.Forms.Label();
            this.textBoxTotalTracks = new System.Windows.Forms.TextBox();
            this.labelOfTrack = new System.Windows.Forms.Label();
            this.textBoxTrack = new System.Windows.Forms.TextBox();
            this.labelTrack = new System.Windows.Forms.Label();
            this.groupBoxGeneralTags = new System.Windows.Forms.GroupBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.labelArtist = new System.Windows.Forms.Label();
            this.textBoxAlbum = new System.Windows.Forms.TextBox();
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
            this.label8 = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelBuffer = new System.Windows.Forms.Label();
            this.groupBoxVideoEncoding = new System.Windows.Forms.GroupBox();
            this.numericUpDownTileRows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTileColumns = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBFrames = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDiaSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTrellis = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGOPSize = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMESubcmp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMECmp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMEMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxBFStrat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTileRows = new System.Windows.Forms.Label();
            this.labelTrellis = new System.Windows.Forms.Label();
            this.labelDiaSize = new System.Windows.Forms.Label();
            this.labelGopSize = new System.Windows.Forms.Label();
            this.labelBFrames = new System.Windows.Forms.Label();
            this.labelPixelFormat = new System.Windows.Forms.Label();
            this.comboBoxPixelFormat = new System.Windows.Forms.ComboBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.label7 = new System.Windows.Forms.Label();
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
            this.groupBoxSessionOptions.SuspendLayout();
            this.groupBoxBinaries.SuspendLayout();
            this.tabTagging.SuspendLayout();
            this.groupBoxMiscTags.SuspendLayout();
            this.groupBoxTrackTags.SuspendLayout();
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
            this.groupBox1.SuspendLayout();
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
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 363);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // tabOptions
            // 
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
            // 
            // buttonBrowseFFmpegBin
            // 
            this.buttonBrowseFFmpegBin.Location = new System.Drawing.Point(474, 13);
            this.buttonBrowseFFmpegBin.Name = "buttonBrowseFFmpegBin";
            this.buttonBrowseFFmpegBin.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseFFmpegBin.TabIndex = 2;
            this.buttonBrowseFFmpegBin.Text = "Browse...";
            this.buttonBrowseFFmpegBin.UseVisualStyleBackColor = true;
            // 
            // textBoxFFmpegBin
            // 
            this.textBoxFFmpegBin.Location = new System.Drawing.Point(112, 16);
            this.textBoxFFmpegBin.Name = "textBoxFFmpegBin";
            this.textBoxFFmpegBin.Size = new System.Drawing.Size(356, 20);
            this.textBoxFFmpegBin.TabIndex = 1;
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
            this.tabTagging.Controls.Add(this.groupBoxMiscTags);
            this.tabTagging.Controls.Add(this.groupBoxTrackTags);
            this.tabTagging.Controls.Add(this.groupBoxGeneralTags);
            this.tabTagging.Location = new System.Drawing.Point(4, 22);
            this.tabTagging.Name = "tabTagging";
            this.tabTagging.Padding = new System.Windows.Forms.Padding(3);
            this.tabTagging.Size = new System.Drawing.Size(567, 296);
            this.tabTagging.TabIndex = 5;
            this.tabTagging.Text = "Tagging";
            this.tabTagging.UseVisualStyleBackColor = true;
            // 
            // groupBoxMiscTags
            // 
            this.groupBoxMiscTags.Controls.Add(this.textBoxPublisher);
            this.groupBoxMiscTags.Controls.Add(this.textBoxComment);
            this.groupBoxMiscTags.Controls.Add(this.labelComment);
            this.groupBoxMiscTags.Controls.Add(this.labelPublisher);
            this.groupBoxMiscTags.Controls.Add(this.textBoxAlbumArtist);
            this.groupBoxMiscTags.Controls.Add(this.labelAlbumArtist);
            this.groupBoxMiscTags.Location = new System.Drawing.Point(148, 107);
            this.groupBoxMiscTags.Name = "groupBoxMiscTags";
            this.groupBoxMiscTags.Size = new System.Drawing.Size(413, 78);
            this.groupBoxMiscTags.TabIndex = 2;
            this.groupBoxMiscTags.TabStop = false;
            this.groupBoxMiscTags.Text = "Misc";
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(211, 19);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(196, 20);
            this.textBoxPublisher.TabIndex = 5;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(66, 45);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(341, 20);
            this.textBoxComment.TabIndex = 4;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(6, 48);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(54, 13);
            this.labelComment.TabIndex = 3;
            this.labelComment.Text = "Comment:";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(153, 22);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(53, 13);
            this.labelPublisher.TabIndex = 2;
            this.labelPublisher.Text = "Publisher:";
            // 
            // textBoxAlbumArtist
            // 
            this.textBoxAlbumArtist.Location = new System.Drawing.Point(47, 19);
            this.textBoxAlbumArtist.Name = "textBoxAlbumArtist";
            this.textBoxAlbumArtist.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlbumArtist.TabIndex = 1;
            // 
            // labelAlbumArtist
            // 
            this.labelAlbumArtist.AutoSize = true;
            this.labelAlbumArtist.Location = new System.Drawing.Point(6, 22);
            this.labelAlbumArtist.Name = "labelAlbumArtist";
            this.labelAlbumArtist.Size = new System.Drawing.Size(35, 13);
            this.labelAlbumArtist.TabIndex = 0;
            this.labelAlbumArtist.Text = "Band:";
            // 
            // groupBoxTrackTags
            // 
            this.groupBoxTrackTags.Controls.Add(this.textBoxTotalDiscs);
            this.groupBoxTrackTags.Controls.Add(this.labelOfDiscs);
            this.groupBoxTrackTags.Controls.Add(this.textBoxDisc);
            this.groupBoxTrackTags.Controls.Add(this.labelDisc);
            this.groupBoxTrackTags.Controls.Add(this.textBoxTotalTracks);
            this.groupBoxTrackTags.Controls.Add(this.labelOfTrack);
            this.groupBoxTrackTags.Controls.Add(this.textBoxTrack);
            this.groupBoxTrackTags.Controls.Add(this.labelTrack);
            this.groupBoxTrackTags.Location = new System.Drawing.Point(6, 107);
            this.groupBoxTrackTags.Name = "groupBoxTrackTags";
            this.groupBoxTrackTags.Size = new System.Drawing.Size(136, 78);
            this.groupBoxTrackTags.TabIndex = 1;
            this.groupBoxTrackTags.TabStop = false;
            this.groupBoxTrackTags.Text = "Track";
            // 
            // textBoxTotalDiscs
            // 
            this.textBoxTotalDiscs.Location = new System.Drawing.Point(100, 45);
            this.textBoxTotalDiscs.Name = "textBoxTotalDiscs";
            this.textBoxTotalDiscs.Size = new System.Drawing.Size(25, 20);
            this.textBoxTotalDiscs.TabIndex = 2;
            this.textBoxTotalDiscs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // labelOfDiscs
            // 
            this.labelOfDiscs.AutoSize = true;
            this.labelOfDiscs.Location = new System.Drawing.Point(82, 48);
            this.labelOfDiscs.Name = "labelOfDiscs";
            this.labelOfDiscs.Size = new System.Drawing.Size(12, 13);
            this.labelOfDiscs.TabIndex = 2;
            this.labelOfDiscs.Text = "/";
            // 
            // textBoxDisc
            // 
            this.textBoxDisc.Location = new System.Drawing.Point(51, 45);
            this.textBoxDisc.Name = "textBoxDisc";
            this.textBoxDisc.Size = new System.Drawing.Size(25, 20);
            this.textBoxDisc.TabIndex = 2;
            this.textBoxDisc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // labelDisc
            // 
            this.labelDisc.AutoSize = true;
            this.labelDisc.Location = new System.Drawing.Point(6, 47);
            this.labelDisc.Name = "labelDisc";
            this.labelDisc.Size = new System.Drawing.Size(31, 13);
            this.labelDisc.TabIndex = 2;
            this.labelDisc.Text = "Disc:";
            // 
            // textBoxTotalTracks
            // 
            this.textBoxTotalTracks.Location = new System.Drawing.Point(100, 19);
            this.textBoxTotalTracks.Name = "textBoxTotalTracks";
            this.textBoxTotalTracks.Size = new System.Drawing.Size(25, 20);
            this.textBoxTotalTracks.TabIndex = 2;
            this.textBoxTotalTracks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // labelOfTrack
            // 
            this.labelOfTrack.AutoSize = true;
            this.labelOfTrack.Location = new System.Drawing.Point(82, 22);
            this.labelOfTrack.Name = "labelOfTrack";
            this.labelOfTrack.Size = new System.Drawing.Size(12, 13);
            this.labelOfTrack.TabIndex = 2;
            this.labelOfTrack.Text = "/";
            // 
            // textBoxTrack
            // 
            this.textBoxTrack.Location = new System.Drawing.Point(51, 19);
            this.textBoxTrack.Name = "textBoxTrack";
            this.textBoxTrack.Size = new System.Drawing.Size(25, 20);
            this.textBoxTrack.TabIndex = 2;
            this.textBoxTrack.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // labelTrack
            // 
            this.labelTrack.AutoSize = true;
            this.labelTrack.Location = new System.Drawing.Point(6, 22);
            this.labelTrack.Name = "labelTrack";
            this.labelTrack.Size = new System.Drawing.Size(38, 13);
            this.labelTrack.TabIndex = 2;
            this.labelTrack.Text = "Track:";
            // 
            // groupBoxGeneralTags
            // 
            this.groupBoxGeneralTags.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBoxGeneralTags.Controls.Add(this.textBoxGenre);
            this.groupBoxGeneralTags.Controls.Add(this.labelGenre);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxArtist);
            this.groupBoxGeneralTags.Controls.Add(this.labelArtist);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxAlbum);
            this.groupBoxGeneralTags.Controls.Add(this.labelAlbum);
            this.groupBoxGeneralTags.Controls.Add(this.labelYear);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxYear);
            this.groupBoxGeneralTags.Controls.Add(this.textBoxTitle);
            this.groupBoxGeneralTags.Controls.Add(this.labelTitle);
            this.groupBoxGeneralTags.Location = new System.Drawing.Point(6, 6);
            this.groupBoxGeneralTags.Name = "groupBoxGeneralTags";
            this.groupBoxGeneralTags.Size = new System.Drawing.Size(555, 95);
            this.groupBoxGeneralTags.TabIndex = 0;
            this.groupBoxGeneralTags.TabStop = false;
            this.groupBoxGeneralTags.Text = "General";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(394, 66);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(155, 20);
            this.textBoxGenre.TabIndex = 9;
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
            this.textBoxArtist.Location = new System.Drawing.Point(51, 66);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(293, 20);
            this.textBoxArtist.TabIndex = 7;
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Location = new System.Drawing.Point(6, 69);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(30, 13);
            this.labelArtist.TabIndex = 6;
            this.labelArtist.Text = "Artist";
            // 
            // textBoxAlbum
            // 
            this.textBoxAlbum.Location = new System.Drawing.Point(51, 41);
            this.textBoxAlbum.Name = "textBoxAlbum";
            this.textBoxAlbum.Size = new System.Drawing.Size(390, 20);
            this.textBoxAlbum.TabIndex = 5;
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(6, 44);
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
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(51, 16);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(498, 20);
            this.textBoxTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(6, 19);
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
            // 
            // comboBoxAudioBitrates
            // 
            this.comboBoxAudioBitrates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioBitrates.FormattingEnabled = true;
            this.comboBoxAudioBitrates.Location = new System.Drawing.Point(53, 17);
            this.comboBoxAudioBitrates.Name = "comboBoxAudioBitrates";
            this.comboBoxAudioBitrates.Size = new System.Drawing.Size(75, 21);
            this.comboBoxAudioBitrates.TabIndex = 1;
            // 
            // groupBoxAudioOutput
            // 
            this.groupBoxAudioOutput.Controls.Add(this.comboBoxChannels);
            this.groupBoxAudioOutput.Controls.Add(this.label8);
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
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Volume boost:";
            // 
            // numericUpDownVolumeBoost
            // 
            this.numericUpDownVolumeBoost.Location = new System.Drawing.Point(86, 63);
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
            // 
            // comboBoxAudioCodecs
            // 
            this.comboBoxAudioCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioCodecs.FormattingEnabled = true;
            this.comboBoxAudioCodecs.Location = new System.Drawing.Point(62, 20);
            this.comboBoxAudioCodecs.Name = "comboBoxAudioCodecs";
            this.comboBoxAudioCodecs.Size = new System.Drawing.Size(128, 21);
            this.comboBoxAudioCodecs.TabIndex = 1;
            // 
            // labelAudioEncoder
            // 
            this.labelAudioEncoder.AutoSize = true;
            this.labelAudioEncoder.Location = new System.Drawing.Point(6, 49);
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
            this.groupBoxVideoSize.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Target:";
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
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownTileRows);
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownTileColumns);
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownBFrames);
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownDiaSize);
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownTrellis);
            this.groupBoxVideoEncoding.Controls.Add(this.numericUpDownGOPSize);
            this.groupBoxVideoEncoding.Controls.Add(this.comboBoxMESubcmp);
            this.groupBoxVideoEncoding.Controls.Add(this.label6);
            this.groupBoxVideoEncoding.Controls.Add(this.comboBoxMECmp);
            this.groupBoxVideoEncoding.Controls.Add(this.label5);
            this.groupBoxVideoEncoding.Controls.Add(this.comboBoxMEMethod);
            this.groupBoxVideoEncoding.Controls.Add(this.label4);
            this.groupBoxVideoEncoding.Controls.Add(this.comboBoxBFStrat);
            this.groupBoxVideoEncoding.Controls.Add(this.label3);
            this.groupBoxVideoEncoding.Controls.Add(this.label2);
            this.groupBoxVideoEncoding.Controls.Add(this.labelTileRows);
            this.groupBoxVideoEncoding.Controls.Add(this.labelTrellis);
            this.groupBoxVideoEncoding.Controls.Add(this.labelDiaSize);
            this.groupBoxVideoEncoding.Controls.Add(this.labelGopSize);
            this.groupBoxVideoEncoding.Controls.Add(this.labelBFrames);
            this.groupBoxVideoEncoding.Controls.Add(this.labelPixelFormat);
            this.groupBoxVideoEncoding.Controls.Add(this.comboBoxPixelFormat);
            this.groupBoxVideoEncoding.Location = new System.Drawing.Point(263, 92);
            this.groupBoxVideoEncoding.Name = "groupBoxVideoEncoding";
            this.groupBoxVideoEncoding.Size = new System.Drawing.Size(298, 193);
            this.groupBoxVideoEncoding.TabIndex = 3;
            this.groupBoxVideoEncoding.TabStop = false;
            this.groupBoxVideoEncoding.Text = "Encoding";
            // 
            // numericUpDownTileRows
            // 
            this.numericUpDownTileRows.Location = new System.Drawing.Point(77, 127);
            this.numericUpDownTileRows.Name = "numericUpDownTileRows";
            this.numericUpDownTileRows.Size = new System.Drawing.Size(32, 20);
            this.numericUpDownTileRows.TabIndex = 36;
            this.numericUpDownTileRows.ValueChanged += new System.EventHandler(this.NumericUpDownTileRows_ValueChanged);
            // 
            // numericUpDownTileColumns
            // 
            this.numericUpDownTileColumns.Location = new System.Drawing.Point(259, 126);
            this.numericUpDownTileColumns.Name = "numericUpDownTileColumns";
            this.numericUpDownTileColumns.Size = new System.Drawing.Size(32, 20);
            this.numericUpDownTileColumns.TabIndex = 35;
            this.numericUpDownTileColumns.ValueChanged += new System.EventHandler(this.NumericUpDownTileColumns_ValueChanged);
            // 
            // numericUpDownBFrames
            // 
            this.numericUpDownBFrames.Location = new System.Drawing.Point(77, 101);
            this.numericUpDownBFrames.Name = "numericUpDownBFrames";
            this.numericUpDownBFrames.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownBFrames.TabIndex = 34;
            this.numericUpDownBFrames.ValueChanged += new System.EventHandler(this.NumericUpDownBFrames_ValueChanged);
            // 
            // numericUpDownDiaSize
            // 
            this.numericUpDownDiaSize.Location = new System.Drawing.Point(77, 43);
            this.numericUpDownDiaSize.Name = "numericUpDownDiaSize";
            this.numericUpDownDiaSize.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownDiaSize.TabIndex = 33;
            this.numericUpDownDiaSize.ValueChanged += new System.EventHandler(this.NumericUpDownDiaSize_ValueChanged);
            // 
            // numericUpDownTrellis
            // 
            this.numericUpDownTrellis.Location = new System.Drawing.Point(244, 17);
            this.numericUpDownTrellis.Name = "numericUpDownTrellis";
            this.numericUpDownTrellis.Size = new System.Drawing.Size(48, 20);
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
            // comboBoxMESubcmp
            // 
            this.comboBoxMESubcmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMESubcmp.FormattingEnabled = true;
            this.comboBoxMESubcmp.Location = new System.Drawing.Point(225, 70);
            this.comboBoxMESubcmp.Name = "comboBoxMESubcmp";
            this.comboBoxMESubcmp.Size = new System.Drawing.Size(66, 21);
            this.comboBoxMESubcmp.TabIndex = 25;
            this.comboBoxMESubcmp.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMESubcmp_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "ME subcmp:";
            // 
            // comboBoxMECmp
            // 
            this.comboBoxMECmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMECmp.FormattingEnabled = true;
            this.comboBoxMECmp.Location = new System.Drawing.Point(77, 69);
            this.comboBoxMECmp.Name = "comboBoxMECmp";
            this.comboBoxMECmp.Size = new System.Drawing.Size(64, 21);
            this.comboBoxMECmp.TabIndex = 23;
            this.comboBoxMECmp.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMECmp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "ME cmp:";
            // 
            // comboBoxMEMethod
            // 
            this.comboBoxMEMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMEMethod.FormattingEnabled = true;
            this.comboBoxMEMethod.Location = new System.Drawing.Point(225, 42);
            this.comboBoxMEMethod.Name = "comboBoxMEMethod";
            this.comboBoxMEMethod.Size = new System.Drawing.Size(66, 21);
            this.comboBoxMEMethod.TabIndex = 21;
            this.comboBoxMEMethod.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMEMethod_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "ME method:";
            // 
            // comboBoxBFStrat
            // 
            this.comboBoxBFStrat.FormattingEnabled = true;
            this.comboBoxBFStrat.Location = new System.Drawing.Point(259, 99);
            this.comboBoxBFStrat.Name = "comboBoxBFStrat";
            this.comboBoxBFStrat.Size = new System.Drawing.Size(32, 21);
            this.comboBoxBFStrat.TabIndex = 17;
            this.comboBoxBFStrat.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBFStrat_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "BF strategy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tile Columns:";
            // 
            // labelTileRows
            // 
            this.labelTileRows.AutoSize = true;
            this.labelTileRows.Location = new System.Drawing.Point(14, 129);
            this.labelTileRows.Name = "labelTileRows";
            this.labelTileRows.Size = new System.Drawing.Size(57, 13);
            this.labelTileRows.TabIndex = 10;
            this.labelTileRows.Text = "Tile Rows:";
            // 
            // labelTrellis
            // 
            this.labelTrellis.AutoSize = true;
            this.labelTrellis.Location = new System.Drawing.Point(201, 19);
            this.labelTrellis.Name = "labelTrellis";
            this.labelTrellis.Size = new System.Drawing.Size(37, 13);
            this.labelTrellis.TabIndex = 9;
            this.labelTrellis.Text = "Trellis:";
            // 
            // labelDiaSize
            // 
            this.labelDiaSize.AutoSize = true;
            this.labelDiaSize.Location = new System.Drawing.Point(24, 45);
            this.labelDiaSize.Name = "labelDiaSize";
            this.labelDiaSize.Size = new System.Drawing.Size(47, 13);
            this.labelDiaSize.TabIndex = 8;
            this.labelDiaSize.Text = "Dia size:";
            // 
            // labelGopSize
            // 
            this.labelGopSize.AutoSize = true;
            this.labelGopSize.Location = new System.Drawing.Point(15, 19);
            this.labelGopSize.Name = "labelGopSize";
            this.labelGopSize.Size = new System.Drawing.Size(56, 13);
            this.labelGopSize.TabIndex = 7;
            this.labelGopSize.Text = "GOP Size:";
            // 
            // labelBFrames
            // 
            this.labelBFrames.AutoSize = true;
            this.labelBFrames.Location = new System.Drawing.Point(17, 103);
            this.labelBFrames.Name = "labelBFrames";
            this.labelBFrames.Size = new System.Drawing.Size(54, 13);
            this.labelBFrames.TabIndex = 6;
            this.labelBFrames.Text = "B-Frames:";
            // 
            // labelPixelFormat
            // 
            this.labelPixelFormat.AutoSize = true;
            this.labelPixelFormat.Location = new System.Drawing.Point(7, 161);
            this.labelPixelFormat.Name = "labelPixelFormat";
            this.labelPixelFormat.Size = new System.Drawing.Size(64, 13);
            this.labelPixelFormat.TabIndex = 5;
            this.labelPixelFormat.Text = "Pixel format:";
            // 
            // comboBoxPixelFormat
            // 
            this.comboBoxPixelFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPixelFormat.FormattingEnabled = true;
            this.comboBoxPixelFormat.Location = new System.Drawing.Point(77, 158);
            this.comboBoxPixelFormat.Name = "comboBoxPixelFormat";
            this.comboBoxPixelFormat.Size = new System.Drawing.Size(126, 21);
            this.comboBoxPixelFormat.TabIndex = 3;
            this.comboBoxPixelFormat.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPixelFormat_SelectedIndexChanged);
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
            this.labelVideoEncoderPreset.Location = new System.Drawing.Point(387, 49);
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
            this.labelVideoEncoder.Location = new System.Drawing.Point(6, 49);
            this.labelVideoEncoder.Name = "labelVideoEncoder";
            this.labelVideoEncoder.Size = new System.Drawing.Size(50, 13);
            this.labelVideoEncoder.TabIndex = 0;
            this.labelVideoEncoder.Text = "Encoder:";
            // 
            // comboBoxVCodecProfile
            // 
            this.comboBoxVCodecProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVCodecProfile.FormattingEnabled = true;
            this.comboBoxVCodecProfile.Location = new System.Drawing.Point(267, 20);
            this.comboBoxVCodecProfile.Name = "comboBoxVCodecProfile";
            this.comboBoxVCodecProfile.Size = new System.Drawing.Size(112, 21);
            this.comboBoxVCodecProfile.TabIndex = 3;
            this.comboBoxVCodecProfile.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVCodecProfile_SelectedIndexChanged);
            // 
            // labelVCodecProfile
            // 
            this.labelVCodecProfile.AutoSize = true;
            this.labelVCodecProfile.Location = new System.Drawing.Point(222, 23);
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
            this.checkBoxDeinterlace.Location = new System.Drawing.Point(6, 19);
            this.checkBoxDeinterlace.Name = "checkBoxDeinterlace";
            this.checkBoxDeinterlace.Size = new System.Drawing.Size(80, 17);
            this.checkBoxDeinterlace.TabIndex = 1;
            this.checkBoxDeinterlace.Text = "Deinterlace";
            this.checkBoxDeinterlace.UseVisualStyleBackColor = true;
            // 
            // labelLayoutColour
            // 
            this.labelLayoutColour.AutoSize = true;
            this.labelLayoutColour.Enabled = false;
            this.labelLayoutColour.Location = new System.Drawing.Point(403, 23);
            this.labelLayoutColour.Name = "labelLayoutColour";
            this.labelLayoutColour.Size = new System.Drawing.Size(40, 13);
            this.labelLayoutColour.TabIndex = 10;
            this.labelLayoutColour.Text = "Colour:";
            // 
            // textBoxLayoutColour
            // 
            this.textBoxLayoutColour.Enabled = false;
            this.textBoxLayoutColour.Location = new System.Drawing.Point(449, 19);
            this.textBoxLayoutColour.Name = "textBoxLayoutColour";
            this.textBoxLayoutColour.Size = new System.Drawing.Size(100, 20);
            this.textBoxLayoutColour.TabIndex = 11;
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
            this.numericUpDownLayoutHoriz.Name = "numericUpDownLayoutHoriz";
            this.numericUpDownLayoutHoriz.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownLayoutHoriz.TabIndex = 21;
            this.numericUpDownLayoutHoriz.ValueChanged += new System.EventHandler(this.numericUpDownLayoutHoriz_ValueChanged);
            // 
            // numericUpDownLayoutVert
            // 
            this.numericUpDownLayoutVert.Location = new System.Drawing.Point(229, 92);
            this.numericUpDownLayoutVert.Name = "numericUpDownLayoutVert";
            this.numericUpDownLayoutVert.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownLayoutVert.TabIndex = 20;
            this.numericUpDownLayoutVert.ValueChanged += new System.EventHandler(this.numericUpDownLayoutVert_ValueChanged);
            // 
            // numericUpDownLayoutHeight
            // 
            this.numericUpDownLayoutHeight.Location = new System.Drawing.Point(53, 92);
            this.numericUpDownLayoutHeight.Name = "numericUpDownLayoutHeight";
            this.numericUpDownLayoutHeight.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownLayoutHeight.TabIndex = 19;
            this.numericUpDownLayoutHeight.ValueChanged += new System.EventHandler(this.numericUpDownLayoutHeight_ValueChanged);
            // 
            // numericUpDownLayoutWidth
            // 
            this.numericUpDownLayoutWidth.Location = new System.Drawing.Point(129, 61);
            this.numericUpDownLayoutWidth.Name = "numericUpDownLayoutWidth";
            this.numericUpDownLayoutWidth.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownLayoutWidth.TabIndex = 18;
            this.numericUpDownLayoutWidth.ValueChanged += new System.EventHandler(this.numericUpDownLayoutWidth_ValueChanged);
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
            this.numericUpDownFPS.Name = "numericUpDownFPS";
            this.numericUpDownFPS.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownFPS.TabIndex = 12;
            this.numericUpDownFPS.ValueChanged += new System.EventHandler(this.numericUpDownFPS_ValueChanged);
            // 
            // numericUpDownRatioB
            // 
            this.numericUpDownRatioB.Location = new System.Drawing.Point(109, 41);
            this.numericUpDownRatioB.Name = "numericUpDownRatioB";
            this.numericUpDownRatioB.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownRatioB.TabIndex = 12;
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
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownHeight.TabIndex = 17;
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.NumericUpDownHeight_ValueChanged);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(68, 63);
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
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.groupBox1);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxOutputFilename);
            this.groupBox1.Controls.Add(this.labelOutputFilename);
            this.groupBox1.Controls.Add(this.checkBoxOverwrite);
            this.groupBox1.Controls.Add(this.labelOutput);
            this.groupBox1.Controls.Add(this.buttonBrowseOutput);
            this.groupBox1.Controls.Add(this.textBoxTargetFolder);
            this.groupBox1.Location = new System.Drawing.Point(6, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 112);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
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
            // 
            // textBoxTargetFolder
            // 
            this.textBoxTargetFolder.Location = new System.Drawing.Point(82, 20);
            this.textBoxTargetFolder.Name = "textBoxTargetFolder";
            this.textBoxTargetFolder.Size = new System.Drawing.Size(385, 20);
            this.textBoxTargetFolder.TabIndex = 3;
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
            // 
            // groupBoxEncoding
            // 
            this.groupBoxEncoding.Controls.Add(this.numericUpDownProcessors);
            this.groupBoxEncoding.Controls.Add(this.numericUpDownThreads);
            this.groupBoxEncoding.Controls.Add(this.label7);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Processors:";
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
            this.comboBoxPresets.TabIndex = 1;
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
            // 
            // buttonBrowseInput
            // 
            this.buttonBrowseInput.Location = new System.Drawing.Point(474, 19);
            this.buttonBrowseInput.Name = "buttonBrowseInput";
            this.buttonBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseInput.TabIndex = 4;
            this.buttonBrowseInput.Text = "Browse...";
            this.buttonBrowseInput.UseVisualStyleBackColor = true;
            // 
            // textBoxInFile
            // 
            this.textBoxInFile.AllowDrop = true;
            this.textBoxInFile.Location = new System.Drawing.Point(82, 20);
            this.textBoxInFile.Name = "textBoxInFile";
            this.textBoxInFile.Size = new System.Drawing.Size(386, 20);
            this.textBoxInFile.TabIndex = 2;
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabOptions.ResumeLayout(false);
            this.groupBoxSessionOptions.ResumeLayout(false);
            this.groupBoxSessionOptions.PerformLayout();
            this.groupBoxBinaries.ResumeLayout(false);
            this.groupBoxBinaries.PerformLayout();
            this.tabTagging.ResumeLayout(false);
            this.groupBoxMiscTags.ResumeLayout(false);
            this.groupBoxMiscTags.PerformLayout();
            this.groupBoxTrackTags.ResumeLayout(false);
            this.groupBoxTrackTags.PerformLayout();
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxMiscTags;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.TextBox textBoxAlbumArtist;
        private System.Windows.Forms.Label labelAlbumArtist;
        private System.Windows.Forms.GroupBox groupBoxTrackTags;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDiaSize;
        private System.Windows.Forms.Label labelGopSize;
        private System.Windows.Forms.Label labelBFrames;
        private System.Windows.Forms.Label labelTrellis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTileRows;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBFStrat;
        private System.Windows.Forms.ComboBox comboBoxMEMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMESubcmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMECmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxAudioCodecProfile;
        private System.Windows.Forms.Label labelAudioCodecProfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelOutputFilename;
        private System.Windows.Forms.Button buttonBrowseAudioStream;
        private System.Windows.Forms.Label labelAudioStream;
        private System.Windows.Forms.TextBox textBoxAudioStream;
        private System.Windows.Forms.TextBox textBoxOutputFilename;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownHighPass;
        private System.Windows.Forms.Label labelHighPass;
        private System.Windows.Forms.NumericUpDown numericUpDownLowPass;
        private System.Windows.Forms.Label labelLowPass;
    }
}

