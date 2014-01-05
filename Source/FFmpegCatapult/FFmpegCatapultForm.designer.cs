// Main WinForms layout FFmpeg Catapult.
// Copyright (C) 2013 Myles Thaiss

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
    partial class FFmpegCatapultForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.groupBoxSession = new System.Windows.Forms.GroupBox();
            this.radioButtonRefresh = new System.Windows.Forms.RadioButton();
            this.radioButtonKeep = new System.Windows.Forms.RadioButton();
            this.groupBoxEncoding = new System.Windows.Forms.GroupBox();
            this.comboBoxThreads = new System.Windows.Forms.ComboBox();
            this.labelThreads = new System.Windows.Forms.Label();
            this.comboBoxContainers = new System.Windows.Forms.ComboBox();
            this.labelFormat = new System.Windows.Forms.Label();
            this.comboBoxPresets = new System.Windows.Forms.ComboBox();
            this.labelPreset = new System.Windows.Forms.Label();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.checkBoxOverwrite = new System.Windows.Forms.CheckBox();
            this.buttonBrowseOutput = new System.Windows.Forms.Button();
            this.buttonBrowseInput = new System.Windows.Forms.Button();
            this.textBoxOutFile = new System.Windows.Forms.TextBox();
            this.textBoxInFile = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.tabPicture = new System.Windows.Forms.TabPage();
            this.groupBoxScalingMethods = new System.Windows.Forms.GroupBox();
            this.comboBoxScalingMethods = new System.Windows.Forms.ComboBox();
            this.labelMethod = new System.Windows.Forms.Label();
            this.groupBoxLayout = new System.Windows.Forms.GroupBox();
            this.textBoxLayoutHoriz = new System.Windows.Forms.TextBox();
            this.textBoxLayoutVert = new System.Windows.Forms.TextBox();
            this.textBoxLayoutHeight = new System.Windows.Forms.TextBox();
            this.textBoxLayoutWidth = new System.Windows.Forms.TextBox();
            this.textBoxLayoutColour = new System.Windows.Forms.TextBox();
            this.labelLayoutColour = new System.Windows.Forms.Label();
            this.labelHoriz = new System.Windows.Forms.Label();
            this.labelVert = new System.Windows.Forms.Label();
            this.labelLayoutHeight = new System.Windows.Forms.Label();
            this.labelLayoutWidth = new System.Windows.Forms.Label();
            this.checkBoxPad = new System.Windows.Forms.CheckBox();
            this.checkBoxCrop = new System.Windows.Forms.CheckBox();
            this.groupBoxScreen = new System.Windows.Forms.GroupBox();
            this.textBoxFPS = new System.Windows.Forms.TextBox();
            this.textBoxRatioB = new System.Windows.Forms.TextBox();
            this.textBoxRatioA = new System.Windows.Forms.TextBox();
            this.labelFPS = new System.Windows.Forms.Label();
            this.labelRatioDash = new System.Windows.Forms.Label();
            this.labelRatio = new System.Windows.Forms.Label();
            this.checkBoxDeinterlace = new System.Windows.Forms.CheckBox();
            this.checkBoxAspectRatio = new System.Windows.Forms.CheckBox();
            this.groupBoxResolution = new System.Windows.Forms.GroupBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.radioButtonCustomRes = new System.Windows.Forms.RadioButton();
            this.radioButtonHalfRes = new System.Windows.Forms.RadioButton();
            this.radioButtonKeepRes = new System.Windows.Forms.RadioButton();
            this.tabVideo = new System.Windows.Forms.TabPage();
            this.groupBoxVideoBitrate = new System.Windows.Forms.GroupBox();
            this.textBoxQmax = new System.Windows.Forms.TextBox();
            this.labelQmax = new System.Windows.Forms.Label();
            this.textBoxQmin = new System.Windows.Forms.TextBox();
            this.labelQmin = new System.Windows.Forms.Label();
            this.textBoxBufferSize = new System.Windows.Forms.TextBox();
            this.textBoxMaxBitrate = new System.Windows.Forms.TextBox();
            this.textBoxMinBitrate = new System.Windows.Forms.TextBox();
            this.textBoxVideoBitrate = new System.Windows.Forms.TextBox();
            this.comboBoxBytes = new System.Windows.Forms.ComboBox();
            this.labelMinBits = new System.Windows.Forms.Label();
            this.labelMaxBits = new System.Windows.Forms.Label();
            this.textBoxCRF = new System.Windows.Forms.TextBox();
            this.labelCRF = new System.Windows.Forms.Label();
            this.checkBoxUseCRF = new System.Windows.Forms.CheckBox();
            this.labelBuffer = new System.Windows.Forms.Label();
            this.labelMaxBitrate = new System.Windows.Forms.Label();
            this.comboBoxBits = new System.Windows.Forms.ComboBox();
            this.labelMinBitrate = new System.Windows.Forms.Label();
            this.labelVideoBitrate = new System.Windows.Forms.Label();
            this.groupBoxVideoEncoder = new System.Windows.Forms.GroupBox();
            this.comboBoxVideoEncoders = new System.Windows.Forms.ComboBox();
            this.labelVideoEncoder = new System.Windows.Forms.Label();
            this.groupBoxVideoCodec = new System.Windows.Forms.GroupBox();
            this.checkBoxTwoPassEncoding = new System.Windows.Forms.CheckBox();
            this.comboBoxVideoCodecs = new System.Windows.Forms.ComboBox();
            this.labelVideoCodec = new System.Windows.Forms.Label();
            this.tabAudio = new System.Windows.Forms.TabPage();
            this.groupBoxAudioStream = new System.Windows.Forms.GroupBox();
            this.buttonBrowseAudioStream = new System.Windows.Forms.Button();
            this.labelAudioStream = new System.Windows.Forms.Label();
            this.textBoxAudioStream = new System.Windows.Forms.TextBox();
            this.groupBoxVolume = new System.Windows.Forms.GroupBox();
            this.groupBoxAudioOutput = new System.Windows.Forms.GroupBox();
            this.comboBoxChannels = new System.Windows.Forms.ComboBox();
            this.comboBoxSampleRates = new System.Windows.Forms.ComboBox();
            this.labelChannels = new System.Windows.Forms.Label();
            this.labelSampleRate = new System.Windows.Forms.Label();
            this.groupBoxAudioBitrate = new System.Windows.Forms.GroupBox();
            this.checkBoxUseAudioVBR = new System.Windows.Forms.CheckBox();
            this.comboBoxAudioBitrates = new System.Windows.Forms.ComboBox();
            this.labelAudioBitrate = new System.Windows.Forms.Label();
            this.groupBoxAudioEncoder = new System.Windows.Forms.GroupBox();
            this.comboBoxAudioEncoders = new System.Windows.Forms.ComboBox();
            this.labelAudioEncoder = new System.Windows.Forms.Label();
            this.groupBoxAudioCodec = new System.Windows.Forms.GroupBox();
            this.comboBoxAudioCodecs = new System.Windows.Forms.ComboBox();
            this.labelAudioCodec = new System.Windows.Forms.Label();
            this.tabMisc = new System.Windows.Forms.TabPage();
            this.groupBoxBinaries = new System.Windows.Forms.GroupBox();
            this.textBoxTermArgs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTermBin = new System.Windows.Forms.TextBox();
            this.labelTermBin = new System.Windows.Forms.Label();
            this.buttonBrowseTermBin = new System.Windows.Forms.Button();
            this.buttonBrowseFFmpegBin = new System.Windows.Forms.Button();
            this.textBoxFFmpegBin = new System.Windows.Forms.TextBox();
            this.labelFFmpegBin = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.groupBoxSession.SuspendLayout();
            this.groupBoxEncoding.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.tabPicture.SuspendLayout();
            this.groupBoxScalingMethods.SuspendLayout();
            this.groupBoxLayout.SuspendLayout();
            this.groupBoxScreen.SuspendLayout();
            this.groupBoxResolution.SuspendLayout();
            this.tabVideo.SuspendLayout();
            this.groupBoxVideoBitrate.SuspendLayout();
            this.groupBoxVideoEncoder.SuspendLayout();
            this.groupBoxVideoCodec.SuspendLayout();
            this.tabAudio.SuspendLayout();
            this.groupBoxAudioStream.SuspendLayout();
            this.groupBoxAudioOutput.SuspendLayout();
            this.groupBoxAudioBitrate.SuspendLayout();
            this.groupBoxAudioEncoder.SuspendLayout();
            this.groupBoxAudioCodec.SuspendLayout();
            this.tabMisc.SuspendLayout();
            this.groupBoxBinaries.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Enabled = false;
            this.buttonRun.Location = new System.Drawing.Point(416, 245);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 245);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMain);
            this.tabControl.Controls.Add(this.tabPicture);
            this.tabControl.Controls.Add(this.tabVideo);
            this.tabControl.Controls.Add(this.tabAudio);
            this.tabControl.Controls.Add(this.tabMisc);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(479, 220);
            this.tabControl.TabIndex = 2;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.groupBoxSession);
            this.tabMain.Controls.Add(this.groupBoxEncoding);
            this.tabMain.Controls.Add(this.groupBoxFiles);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(471, 194);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // groupBoxSession
            // 
            this.groupBoxSession.Controls.Add(this.radioButtonRefresh);
            this.groupBoxSession.Controls.Add(this.radioButtonKeep);
            this.groupBoxSession.Location = new System.Drawing.Point(384, 107);
            this.groupBoxSession.Name = "groupBoxSession";
            this.groupBoxSession.Size = new System.Drawing.Size(81, 78);
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
            this.radioButtonKeep.Location = new System.Drawing.Point(6, 19);
            this.radioButtonKeep.Name = "radioButtonKeep";
            this.radioButtonKeep.Size = new System.Drawing.Size(50, 17);
            this.radioButtonKeep.TabIndex = 1;
            this.radioButtonKeep.TabStop = true;
            this.radioButtonKeep.Text = "Keep";
            this.radioButtonKeep.UseVisualStyleBackColor = true;
            // 
            // groupBoxEncoding
            // 
            this.groupBoxEncoding.Controls.Add(this.comboBoxThreads);
            this.groupBoxEncoding.Controls.Add(this.labelThreads);
            this.groupBoxEncoding.Controls.Add(this.comboBoxContainers);
            this.groupBoxEncoding.Controls.Add(this.labelFormat);
            this.groupBoxEncoding.Controls.Add(this.comboBoxPresets);
            this.groupBoxEncoding.Controls.Add(this.labelPreset);
            this.groupBoxEncoding.Location = new System.Drawing.Point(6, 107);
            this.groupBoxEncoding.Name = "groupBoxEncoding";
            this.groupBoxEncoding.Size = new System.Drawing.Size(372, 78);
            this.groupBoxEncoding.TabIndex = 1;
            this.groupBoxEncoding.TabStop = false;
            this.groupBoxEncoding.Text = "Encoding";
            // 
            // comboBoxThreads
            // 
            this.comboBoxThreads.FormattingEnabled = true;
            this.comboBoxThreads.Location = new System.Drawing.Point(313, 45);
            this.comboBoxThreads.Name = "comboBoxThreads";
            this.comboBoxThreads.Size = new System.Drawing.Size(53, 21);
            this.comboBoxThreads.TabIndex = 5;
            // 
            // labelThreads
            // 
            this.labelThreads.AutoSize = true;
            this.labelThreads.Location = new System.Drawing.Point(258, 48);
            this.labelThreads.Name = "labelThreads";
            this.labelThreads.Size = new System.Drawing.Size(49, 13);
            this.labelThreads.TabIndex = 4;
            this.labelThreads.Text = "Threads:";
            // 
            // comboBoxContainers
            // 
            this.comboBoxContainers.FormattingEnabled = true;
            this.comboBoxContainers.Location = new System.Drawing.Point(67, 45);
            this.comboBoxContainers.Name = "comboBoxContainers";
            this.comboBoxContainers.Size = new System.Drawing.Size(185, 21);
            this.comboBoxContainers.TabIndex = 3;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(6, 48);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(55, 13);
            this.labelFormat.TabIndex = 2;
            this.labelFormat.Text = "Container:";
            // 
            // comboBoxPresets
            // 
            this.comboBoxPresets.FormattingEnabled = true;
            this.comboBoxPresets.Location = new System.Drawing.Point(67, 18);
            this.comboBoxPresets.Name = "comboBoxPresets";
            this.comboBoxPresets.Size = new System.Drawing.Size(299, 21);
            this.comboBoxPresets.TabIndex = 1;
            // 
            // labelPreset
            // 
            this.labelPreset.AutoSize = true;
            this.labelPreset.Location = new System.Drawing.Point(6, 21);
            this.labelPreset.Name = "labelPreset";
            this.labelPreset.Size = new System.Drawing.Size(40, 13);
            this.labelPreset.TabIndex = 0;
            this.labelPreset.Text = "Preset:";
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Controls.Add(this.checkBoxOverwrite);
            this.groupBoxFiles.Controls.Add(this.buttonBrowseOutput);
            this.groupBoxFiles.Controls.Add(this.buttonBrowseInput);
            this.groupBoxFiles.Controls.Add(this.textBoxOutFile);
            this.groupBoxFiles.Controls.Add(this.textBoxInFile);
            this.groupBoxFiles.Controls.Add(this.labelOutput);
            this.groupBoxFiles.Controls.Add(this.labelInput);
            this.groupBoxFiles.Location = new System.Drawing.Point(6, 6);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(459, 95);
            this.groupBoxFiles.TabIndex = 0;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Files";
            // 
            // checkBoxOverwrite
            // 
            this.checkBoxOverwrite.AutoSize = true;
            this.checkBoxOverwrite.Location = new System.Drawing.Point(9, 68);
            this.checkBoxOverwrite.Name = "checkBoxOverwrite";
            this.checkBoxOverwrite.Size = new System.Drawing.Size(125, 17);
            this.checkBoxOverwrite.TabIndex = 6;
            this.checkBoxOverwrite.Text = "Overwrite existing file";
            this.checkBoxOverwrite.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseOutput
            // 
            this.buttonBrowseOutput.Location = new System.Drawing.Point(378, 40);
            this.buttonBrowseOutput.Name = "buttonBrowseOutput";
            this.buttonBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseOutput.TabIndex = 5;
            this.buttonBrowseOutput.Text = "Save";
            this.buttonBrowseOutput.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseInput
            // 
            this.buttonBrowseInput.Location = new System.Drawing.Point(378, 13);
            this.buttonBrowseInput.Name = "buttonBrowseInput";
            this.buttonBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseInput.TabIndex = 4;
            this.buttonBrowseInput.Text = "Browse";
            this.buttonBrowseInput.UseVisualStyleBackColor = true;
            // 
            // textBoxOutFile
            // 
            this.textBoxOutFile.Location = new System.Drawing.Point(54, 42);
            this.textBoxOutFile.Name = "textBoxOutFile";
            this.textBoxOutFile.Size = new System.Drawing.Size(318, 20);
            this.textBoxOutFile.TabIndex = 3;
            // 
            // textBoxInFile
            // 
            this.textBoxInFile.AllowDrop = true;
            this.textBoxInFile.Location = new System.Drawing.Point(54, 16);
            this.textBoxInFile.Name = "textBoxInFile";
            this.textBoxInFile.Size = new System.Drawing.Size(318, 20);
            this.textBoxInFile.TabIndex = 2;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(6, 45);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(42, 13);
            this.labelOutput.TabIndex = 1;
            this.labelOutput.Text = "Output:";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(6, 19);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(34, 13);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input:";
            // 
            // tabPicture
            // 
            this.tabPicture.Controls.Add(this.groupBoxScalingMethods);
            this.tabPicture.Controls.Add(this.groupBoxLayout);
            this.tabPicture.Controls.Add(this.groupBoxScreen);
            this.tabPicture.Controls.Add(this.groupBoxResolution);
            this.tabPicture.Location = new System.Drawing.Point(4, 22);
            this.tabPicture.Name = "tabPicture";
            this.tabPicture.Padding = new System.Windows.Forms.Padding(3);
            this.tabPicture.Size = new System.Drawing.Size(471, 194);
            this.tabPicture.TabIndex = 1;
            this.tabPicture.Text = "Picture";
            this.tabPicture.UseVisualStyleBackColor = true;
            // 
            // groupBoxScalingMethods
            // 
            this.groupBoxScalingMethods.Controls.Add(this.comboBoxScalingMethods);
            this.groupBoxScalingMethods.Controls.Add(this.labelMethod);
            this.groupBoxScalingMethods.Location = new System.Drawing.Point(250, 133);
            this.groupBoxScalingMethods.Name = "groupBoxScalingMethods";
            this.groupBoxScalingMethods.Size = new System.Drawing.Size(215, 52);
            this.groupBoxScalingMethods.TabIndex = 3;
            this.groupBoxScalingMethods.TabStop = false;
            this.groupBoxScalingMethods.Text = "Scaling";
            // 
            // comboBoxScalingMethods
            // 
            this.comboBoxScalingMethods.FormattingEnabled = true;
            this.comboBoxScalingMethods.Location = new System.Drawing.Point(58, 19);
            this.comboBoxScalingMethods.Name = "comboBoxScalingMethods";
            this.comboBoxScalingMethods.Size = new System.Drawing.Size(151, 21);
            this.comboBoxScalingMethods.TabIndex = 1;
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Location = new System.Drawing.Point(6, 22);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(46, 13);
            this.labelMethod.TabIndex = 0;
            this.labelMethod.Text = "Method:";
            // 
            // groupBoxLayout
            // 
            this.groupBoxLayout.Controls.Add(this.textBoxLayoutHoriz);
            this.groupBoxLayout.Controls.Add(this.textBoxLayoutVert);
            this.groupBoxLayout.Controls.Add(this.textBoxLayoutHeight);
            this.groupBoxLayout.Controls.Add(this.textBoxLayoutWidth);
            this.groupBoxLayout.Controls.Add(this.textBoxLayoutColour);
            this.groupBoxLayout.Controls.Add(this.labelLayoutColour);
            this.groupBoxLayout.Controls.Add(this.labelHoriz);
            this.groupBoxLayout.Controls.Add(this.labelVert);
            this.groupBoxLayout.Controls.Add(this.labelLayoutHeight);
            this.groupBoxLayout.Controls.Add(this.labelLayoutWidth);
            this.groupBoxLayout.Controls.Add(this.checkBoxPad);
            this.groupBoxLayout.Controls.Add(this.checkBoxCrop);
            this.groupBoxLayout.Location = new System.Drawing.Point(250, 6);
            this.groupBoxLayout.Name = "groupBoxLayout";
            this.groupBoxLayout.Size = new System.Drawing.Size(215, 121);
            this.groupBoxLayout.TabIndex = 2;
            this.groupBoxLayout.TabStop = false;
            this.groupBoxLayout.Text = "Layout";
            // 
            // textBoxLayoutHoriz
            // 
            this.textBoxLayoutHoriz.Enabled = false;
            this.textBoxLayoutHoriz.Location = new System.Drawing.Point(159, 65);
            this.textBoxLayoutHoriz.Name = "textBoxLayoutHoriz";
            this.textBoxLayoutHoriz.Size = new System.Drawing.Size(50, 20);
            this.textBoxLayoutHoriz.TabIndex = 15;
            // 
            // textBoxLayoutVert
            // 
            this.textBoxLayoutVert.Enabled = false;
            this.textBoxLayoutVert.Location = new System.Drawing.Point(50, 65);
            this.textBoxLayoutVert.Name = "textBoxLayoutVert";
            this.textBoxLayoutVert.Size = new System.Drawing.Size(50, 20);
            this.textBoxLayoutVert.TabIndex = 14;
            // 
            // textBoxLayoutHeight
            // 
            this.textBoxLayoutHeight.Enabled = false;
            this.textBoxLayoutHeight.Location = new System.Drawing.Point(159, 41);
            this.textBoxLayoutHeight.Name = "textBoxLayoutHeight";
            this.textBoxLayoutHeight.Size = new System.Drawing.Size(50, 20);
            this.textBoxLayoutHeight.TabIndex = 13;
            // 
            // textBoxLayoutWidth
            // 
            this.textBoxLayoutWidth.Enabled = false;
            this.textBoxLayoutWidth.Location = new System.Drawing.Point(50, 41);
            this.textBoxLayoutWidth.Name = "textBoxLayoutWidth";
            this.textBoxLayoutWidth.Size = new System.Drawing.Size(50, 20);
            this.textBoxLayoutWidth.TabIndex = 12;
            // 
            // textBoxLayoutColour
            // 
            this.textBoxLayoutColour.Enabled = false;
            this.textBoxLayoutColour.Location = new System.Drawing.Point(50, 91);
            this.textBoxLayoutColour.Name = "textBoxLayoutColour";
            this.textBoxLayoutColour.Size = new System.Drawing.Size(100, 20);
            this.textBoxLayoutColour.TabIndex = 11;
            // 
            // labelLayoutColour
            // 
            this.labelLayoutColour.AutoSize = true;
            this.labelLayoutColour.Enabled = false;
            this.labelLayoutColour.Location = new System.Drawing.Point(6, 94);
            this.labelLayoutColour.Name = "labelLayoutColour";
            this.labelLayoutColour.Size = new System.Drawing.Size(40, 13);
            this.labelLayoutColour.TabIndex = 10;
            this.labelLayoutColour.Text = "Colour:";
            // 
            // labelHoriz
            // 
            this.labelHoriz.AutoSize = true;
            this.labelHoriz.Enabled = false;
            this.labelHoriz.Location = new System.Drawing.Point(112, 69);
            this.labelHoriz.Name = "labelHoriz";
            this.labelHoriz.Size = new System.Drawing.Size(34, 13);
            this.labelHoriz.TabIndex = 8;
            this.labelHoriz.Text = "Horiz:";
            // 
            // labelVert
            // 
            this.labelVert.AutoSize = true;
            this.labelVert.Enabled = false;
            this.labelVert.Location = new System.Drawing.Point(6, 69);
            this.labelVert.Name = "labelVert";
            this.labelVert.Size = new System.Drawing.Size(29, 13);
            this.labelVert.TabIndex = 6;
            this.labelVert.Text = "Vert:";
            // 
            // labelLayoutHeight
            // 
            this.labelLayoutHeight.AutoSize = true;
            this.labelLayoutHeight.Enabled = false;
            this.labelLayoutHeight.Location = new System.Drawing.Point(112, 44);
            this.labelLayoutHeight.Name = "labelLayoutHeight";
            this.labelLayoutHeight.Size = new System.Drawing.Size(41, 13);
            this.labelLayoutHeight.TabIndex = 4;
            this.labelLayoutHeight.Text = "Height:";
            // 
            // labelLayoutWidth
            // 
            this.labelLayoutWidth.AutoSize = true;
            this.labelLayoutWidth.Enabled = false;
            this.labelLayoutWidth.Location = new System.Drawing.Point(6, 44);
            this.labelLayoutWidth.Name = "labelLayoutWidth";
            this.labelLayoutWidth.Size = new System.Drawing.Size(38, 13);
            this.labelLayoutWidth.TabIndex = 2;
            this.labelLayoutWidth.Text = "Width:";
            // 
            // checkBoxPad
            // 
            this.checkBoxPad.AutoSize = true;
            this.checkBoxPad.Location = new System.Drawing.Point(159, 19);
            this.checkBoxPad.Name = "checkBoxPad";
            this.checkBoxPad.Size = new System.Drawing.Size(45, 17);
            this.checkBoxPad.TabIndex = 1;
            this.checkBoxPad.Text = "Pad";
            this.checkBoxPad.UseVisualStyleBackColor = true;
            // 
            // checkBoxCrop
            // 
            this.checkBoxCrop.AutoSize = true;
            this.checkBoxCrop.Location = new System.Drawing.Point(9, 19);
            this.checkBoxCrop.Name = "checkBoxCrop";
            this.checkBoxCrop.Size = new System.Drawing.Size(48, 17);
            this.checkBoxCrop.TabIndex = 0;
            this.checkBoxCrop.Text = "Crop";
            this.checkBoxCrop.UseVisualStyleBackColor = true;
            // 
            // groupBoxScreen
            // 
            this.groupBoxScreen.Controls.Add(this.textBoxFPS);
            this.groupBoxScreen.Controls.Add(this.textBoxRatioB);
            this.groupBoxScreen.Controls.Add(this.textBoxRatioA);
            this.groupBoxScreen.Controls.Add(this.labelFPS);
            this.groupBoxScreen.Controls.Add(this.labelRatioDash);
            this.groupBoxScreen.Controls.Add(this.labelRatio);
            this.groupBoxScreen.Controls.Add(this.checkBoxDeinterlace);
            this.groupBoxScreen.Controls.Add(this.checkBoxAspectRatio);
            this.groupBoxScreen.Location = new System.Drawing.Point(6, 107);
            this.groupBoxScreen.Name = "groupBoxScreen";
            this.groupBoxScreen.Size = new System.Drawing.Size(238, 78);
            this.groupBoxScreen.TabIndex = 1;
            this.groupBoxScreen.TabStop = false;
            this.groupBoxScreen.Text = "Screen";
            // 
            // textBoxFPS
            // 
            this.textBoxFPS.Location = new System.Drawing.Point(207, 48);
            this.textBoxFPS.Name = "textBoxFPS";
            this.textBoxFPS.Size = new System.Drawing.Size(25, 20);
            this.textBoxFPS.TabIndex = 10;
            // 
            // textBoxRatioB
            // 
            this.textBoxRatioB.Enabled = false;
            this.textBoxRatioB.Location = new System.Drawing.Point(91, 46);
            this.textBoxRatioB.Name = "textBoxRatioB";
            this.textBoxRatioB.Size = new System.Drawing.Size(25, 20);
            this.textBoxRatioB.TabIndex = 9;
            // 
            // textBoxRatioA
            // 
            this.textBoxRatioA.Enabled = false;
            this.textBoxRatioA.Location = new System.Drawing.Point(44, 46);
            this.textBoxRatioA.Name = "textBoxRatioA";
            this.textBoxRatioA.Size = new System.Drawing.Size(25, 20);
            this.textBoxRatioA.TabIndex = 8;
            // 
            // labelFPS
            // 
            this.labelFPS.AutoSize = true;
            this.labelFPS.Location = new System.Drawing.Point(171, 51);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.Size = new System.Drawing.Size(30, 13);
            this.labelFPS.TabIndex = 6;
            this.labelFPS.Text = "FPS:";
            // 
            // labelRatioDash
            // 
            this.labelRatioDash.AutoSize = true;
            this.labelRatioDash.Enabled = false;
            this.labelRatioDash.Location = new System.Drawing.Point(75, 48);
            this.labelRatioDash.Name = "labelRatioDash";
            this.labelRatioDash.Size = new System.Drawing.Size(10, 13);
            this.labelRatioDash.TabIndex = 4;
            this.labelRatioDash.Text = ":";
            // 
            // labelRatio
            // 
            this.labelRatio.AutoSize = true;
            this.labelRatio.Enabled = false;
            this.labelRatio.Location = new System.Drawing.Point(3, 48);
            this.labelRatio.Name = "labelRatio";
            this.labelRatio.Size = new System.Drawing.Size(35, 13);
            this.labelRatio.TabIndex = 2;
            this.labelRatio.Text = "Ratio:";
            // 
            // checkBoxDeinterlace
            // 
            this.checkBoxDeinterlace.AutoSize = true;
            this.checkBoxDeinterlace.Location = new System.Drawing.Point(152, 19);
            this.checkBoxDeinterlace.Name = "checkBoxDeinterlace";
            this.checkBoxDeinterlace.Size = new System.Drawing.Size(80, 17);
            this.checkBoxDeinterlace.TabIndex = 1;
            this.checkBoxDeinterlace.Text = "Deinterlace";
            this.checkBoxDeinterlace.UseVisualStyleBackColor = true;
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
            this.groupBoxResolution.Controls.Add(this.textBoxHeight);
            this.groupBoxResolution.Controls.Add(this.textBoxWidth);
            this.groupBoxResolution.Controls.Add(this.labelHeight);
            this.groupBoxResolution.Controls.Add(this.radioButtonCustomRes);
            this.groupBoxResolution.Controls.Add(this.radioButtonHalfRes);
            this.groupBoxResolution.Controls.Add(this.radioButtonKeepRes);
            this.groupBoxResolution.Location = new System.Drawing.Point(6, 6);
            this.groupBoxResolution.Name = "groupBoxResolution";
            this.groupBoxResolution.Size = new System.Drawing.Size(238, 95);
            this.groupBoxResolution.TabIndex = 0;
            this.groupBoxResolution.TabStop = false;
            this.groupBoxResolution.Text = "Resolution";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Enabled = false;
            this.textBoxHeight.Location = new System.Drawing.Point(177, 64);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(55, 20);
            this.textBoxHeight.TabIndex = 7;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Enabled = false;
            this.textBoxWidth.Location = new System.Drawing.Point(68, 64);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(55, 20);
            this.textBoxWidth.TabIndex = 6;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(130, 67);
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
            // tabVideo
            // 
            this.tabVideo.Controls.Add(this.groupBoxVideoBitrate);
            this.tabVideo.Controls.Add(this.groupBoxVideoEncoder);
            this.tabVideo.Controls.Add(this.groupBoxVideoCodec);
            this.tabVideo.Location = new System.Drawing.Point(4, 22);
            this.tabVideo.Name = "tabVideo";
            this.tabVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideo.Size = new System.Drawing.Size(471, 194);
            this.tabVideo.TabIndex = 2;
            this.tabVideo.Text = "Video";
            this.tabVideo.UseVisualStyleBackColor = true;
            // 
            // groupBoxVideoBitrate
            // 
            this.groupBoxVideoBitrate.Controls.Add(this.textBoxQmax);
            this.groupBoxVideoBitrate.Controls.Add(this.labelQmax);
            this.groupBoxVideoBitrate.Controls.Add(this.textBoxQmin);
            this.groupBoxVideoBitrate.Controls.Add(this.labelQmin);
            this.groupBoxVideoBitrate.Controls.Add(this.textBoxBufferSize);
            this.groupBoxVideoBitrate.Controls.Add(this.textBoxMaxBitrate);
            this.groupBoxVideoBitrate.Controls.Add(this.textBoxMinBitrate);
            this.groupBoxVideoBitrate.Controls.Add(this.textBoxVideoBitrate);
            this.groupBoxVideoBitrate.Controls.Add(this.comboBoxBytes);
            this.groupBoxVideoBitrate.Controls.Add(this.labelMinBits);
            this.groupBoxVideoBitrate.Controls.Add(this.labelMaxBits);
            this.groupBoxVideoBitrate.Controls.Add(this.textBoxCRF);
            this.groupBoxVideoBitrate.Controls.Add(this.labelCRF);
            this.groupBoxVideoBitrate.Controls.Add(this.checkBoxUseCRF);
            this.groupBoxVideoBitrate.Controls.Add(this.labelBuffer);
            this.groupBoxVideoBitrate.Controls.Add(this.labelMaxBitrate);
            this.groupBoxVideoBitrate.Controls.Add(this.comboBoxBits);
            this.groupBoxVideoBitrate.Controls.Add(this.labelMinBitrate);
            this.groupBoxVideoBitrate.Controls.Add(this.labelVideoBitrate);
            this.groupBoxVideoBitrate.Location = new System.Drawing.Point(6, 90);
            this.groupBoxVideoBitrate.Name = "groupBoxVideoBitrate";
            this.groupBoxVideoBitrate.Size = new System.Drawing.Size(459, 95);
            this.groupBoxVideoBitrate.TabIndex = 2;
            this.groupBoxVideoBitrate.TabStop = false;
            this.groupBoxVideoBitrate.Text = "Bitrate";
            // 
            // textBoxQmax
            // 
            this.textBoxQmax.Location = new System.Drawing.Point(217, 65);
            this.textBoxQmax.Name = "textBoxQmax";
            this.textBoxQmax.Size = new System.Drawing.Size(35, 20);
            this.textBoxQmax.TabIndex = 24;
            // 
            // labelQmax
            // 
            this.labelQmax.AutoSize = true;
            this.labelQmax.Location = new System.Drawing.Point(174, 68);
            this.labelQmax.Name = "labelQmax";
            this.labelQmax.Size = new System.Drawing.Size(37, 13);
            this.labelQmax.TabIndex = 23;
            this.labelQmax.Text = "Qmax:";
            // 
            // textBoxQmin
            // 
            this.textBoxQmin.Location = new System.Drawing.Point(133, 65);
            this.textBoxQmin.Name = "textBoxQmin";
            this.textBoxQmin.Size = new System.Drawing.Size(35, 20);
            this.textBoxQmin.TabIndex = 22;
            // 
            // labelQmin
            // 
            this.labelQmin.AutoSize = true;
            this.labelQmin.Location = new System.Drawing.Point(93, 68);
            this.labelQmin.Name = "labelQmin";
            this.labelQmin.Size = new System.Drawing.Size(34, 13);
            this.labelQmin.TabIndex = 21;
            this.labelQmin.Text = "Qmin:";
            // 
            // textBoxBufferSize
            // 
            this.textBoxBufferSize.Location = new System.Drawing.Point(326, 67);
            this.textBoxBufferSize.Name = "textBoxBufferSize";
            this.textBoxBufferSize.Size = new System.Drawing.Size(80, 20);
            this.textBoxBufferSize.TabIndex = 20;
            // 
            // textBoxMaxBitrate
            // 
            this.textBoxMaxBitrate.Location = new System.Drawing.Point(326, 42);
            this.textBoxMaxBitrate.Name = "textBoxMaxBitrate";
            this.textBoxMaxBitrate.Size = new System.Drawing.Size(80, 20);
            this.textBoxMaxBitrate.TabIndex = 19;
            // 
            // textBoxMinBitrate
            // 
            this.textBoxMinBitrate.Location = new System.Drawing.Point(326, 17);
            this.textBoxMinBitrate.Name = "textBoxMinBitrate";
            this.textBoxMinBitrate.Size = new System.Drawing.Size(80, 20);
            this.textBoxMinBitrate.TabIndex = 18;
            // 
            // textBoxVideoBitrate
            // 
            this.textBoxVideoBitrate.Location = new System.Drawing.Point(50, 18);
            this.textBoxVideoBitrate.Name = "textBoxVideoBitrate";
            this.textBoxVideoBitrate.Size = new System.Drawing.Size(80, 20);
            this.textBoxVideoBitrate.TabIndex = 17;
            // 
            // comboBoxBytes
            // 
            this.comboBoxBytes.FormattingEnabled = true;
            this.comboBoxBytes.Location = new System.Drawing.Point(412, 66);
            this.comboBoxBytes.Name = "comboBoxBytes";
            this.comboBoxBytes.Size = new System.Drawing.Size(41, 21);
            this.comboBoxBytes.TabIndex = 16;
            this.comboBoxBytes.Text = "MB";
            // 
            // labelMinBits
            // 
            this.labelMinBits.AutoSize = true;
            this.labelMinBits.Location = new System.Drawing.Point(412, 21);
            this.labelMinBits.Name = "labelMinBits";
            this.labelMinBits.Size = new System.Drawing.Size(33, 13);
            this.labelMinBits.TabIndex = 15;
            this.labelMinBits.Text = "Mbps";
            // 
            // labelMaxBits
            // 
            this.labelMaxBits.AutoSize = true;
            this.labelMaxBits.Location = new System.Drawing.Point(412, 46);
            this.labelMaxBits.Name = "labelMaxBits";
            this.labelMaxBits.Size = new System.Drawing.Size(33, 13);
            this.labelMaxBits.TabIndex = 14;
            this.labelMaxBits.Text = "Mbps";
            // 
            // textBoxCRF
            // 
            this.textBoxCRF.Location = new System.Drawing.Point(43, 65);
            this.textBoxCRF.Name = "textBoxCRF";
            this.textBoxCRF.Size = new System.Drawing.Size(35, 20);
            this.textBoxCRF.TabIndex = 13;
            // 
            // labelCRF
            // 
            this.labelCRF.AutoSize = true;
            this.labelCRF.Location = new System.Drawing.Point(6, 68);
            this.labelCRF.Name = "labelCRF";
            this.labelCRF.Size = new System.Drawing.Size(31, 13);
            this.labelCRF.TabIndex = 12;
            this.labelCRF.Text = "CRF:";
            // 
            // checkBoxUseCRF
            // 
            this.checkBoxUseCRF.AutoSize = true;
            this.checkBoxUseCRF.Location = new System.Drawing.Point(9, 45);
            this.checkBoxUseCRF.Name = "checkBoxUseCRF";
            this.checkBoxUseCRF.Size = new System.Drawing.Size(69, 17);
            this.checkBoxUseCRF.TabIndex = 11;
            this.checkBoxUseCRF.Text = "Use CRF";
            this.checkBoxUseCRF.UseVisualStyleBackColor = true;
            // 
            // labelBuffer
            // 
            this.labelBuffer.AutoSize = true;
            this.labelBuffer.Location = new System.Drawing.Point(282, 69);
            this.labelBuffer.Name = "labelBuffer";
            this.labelBuffer.Size = new System.Drawing.Size(38, 13);
            this.labelBuffer.TabIndex = 9;
            this.labelBuffer.Text = "Buffer:";
            // 
            // labelMaxBitrate
            // 
            this.labelMaxBitrate.AutoSize = true;
            this.labelMaxBitrate.Location = new System.Drawing.Point(290, 45);
            this.labelMaxBitrate.Name = "labelMaxBitrate";
            this.labelMaxBitrate.Size = new System.Drawing.Size(30, 13);
            this.labelMaxBitrate.TabIndex = 5;
            this.labelMaxBitrate.Text = "Max:";
            // 
            // comboBoxBits
            // 
            this.comboBoxBits.FormattingEnabled = true;
            this.comboBoxBits.Location = new System.Drawing.Point(138, 18);
            this.comboBoxBits.Name = "comboBoxBits";
            this.comboBoxBits.Size = new System.Drawing.Size(53, 21);
            this.comboBoxBits.TabIndex = 4;
            // 
            // labelMinBitrate
            // 
            this.labelMinBitrate.AutoSize = true;
            this.labelMinBitrate.Location = new System.Drawing.Point(293, 20);
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
            this.labelVideoBitrate.Size = new System.Drawing.Size(40, 13);
            this.labelVideoBitrate.TabIndex = 0;
            this.labelVideoBitrate.Text = "Bitrate:";
            // 
            // groupBoxVideoEncoder
            // 
            this.groupBoxVideoEncoder.Controls.Add(this.comboBoxVideoEncoders);
            this.groupBoxVideoEncoder.Controls.Add(this.labelVideoEncoder);
            this.groupBoxVideoEncoder.Location = new System.Drawing.Point(196, 6);
            this.groupBoxVideoEncoder.Name = "groupBoxVideoEncoder";
            this.groupBoxVideoEncoder.Size = new System.Drawing.Size(269, 78);
            this.groupBoxVideoEncoder.TabIndex = 1;
            this.groupBoxVideoEncoder.TabStop = false;
            this.groupBoxVideoEncoder.Text = "Encoder";
            // 
            // comboBoxVideoEncoders
            // 
            this.comboBoxVideoEncoders.FormattingEnabled = true;
            this.comboBoxVideoEncoders.Location = new System.Drawing.Point(62, 19);
            this.comboBoxVideoEncoders.Name = "comboBoxVideoEncoders";
            this.comboBoxVideoEncoders.Size = new System.Drawing.Size(201, 21);
            this.comboBoxVideoEncoders.TabIndex = 1;
            // 
            // labelVideoEncoder
            // 
            this.labelVideoEncoder.AutoSize = true;
            this.labelVideoEncoder.Location = new System.Drawing.Point(6, 22);
            this.labelVideoEncoder.Name = "labelVideoEncoder";
            this.labelVideoEncoder.Size = new System.Drawing.Size(50, 13);
            this.labelVideoEncoder.TabIndex = 0;
            this.labelVideoEncoder.Text = "Encoder:";
            // 
            // groupBoxVideoCodec
            // 
            this.groupBoxVideoCodec.Controls.Add(this.checkBoxTwoPassEncoding);
            this.groupBoxVideoCodec.Controls.Add(this.comboBoxVideoCodecs);
            this.groupBoxVideoCodec.Controls.Add(this.labelVideoCodec);
            this.groupBoxVideoCodec.Location = new System.Drawing.Point(6, 6);
            this.groupBoxVideoCodec.Name = "groupBoxVideoCodec";
            this.groupBoxVideoCodec.Size = new System.Drawing.Size(184, 78);
            this.groupBoxVideoCodec.TabIndex = 0;
            this.groupBoxVideoCodec.TabStop = false;
            this.groupBoxVideoCodec.Text = "Codec";
            // 
            // checkBoxTwoPassEncoding
            // 
            this.checkBoxTwoPassEncoding.AutoSize = true;
            this.checkBoxTwoPassEncoding.Location = new System.Drawing.Point(9, 46);
            this.checkBoxTwoPassEncoding.Name = "checkBoxTwoPassEncoding";
            this.checkBoxTwoPassEncoding.Size = new System.Drawing.Size(119, 17);
            this.checkBoxTwoPassEncoding.TabIndex = 2;
            this.checkBoxTwoPassEncoding.Text = "Two-pass encoding";
            this.checkBoxTwoPassEncoding.UseVisualStyleBackColor = true;
            // 
            // comboBoxVideoCodecs
            // 
            this.comboBoxVideoCodecs.FormattingEnabled = true;
            this.comboBoxVideoCodecs.Location = new System.Drawing.Point(53, 19);
            this.comboBoxVideoCodecs.Name = "comboBoxVideoCodecs";
            this.comboBoxVideoCodecs.Size = new System.Drawing.Size(125, 21);
            this.comboBoxVideoCodecs.TabIndex = 1;
            // 
            // labelVideoCodec
            // 
            this.labelVideoCodec.AutoSize = true;
            this.labelVideoCodec.Location = new System.Drawing.Point(6, 22);
            this.labelVideoCodec.Name = "labelVideoCodec";
            this.labelVideoCodec.Size = new System.Drawing.Size(41, 13);
            this.labelVideoCodec.TabIndex = 0;
            this.labelVideoCodec.Text = "Codec:";
            // 
            // tabAudio
            // 
            this.tabAudio.Controls.Add(this.groupBoxAudioStream);
            this.tabAudio.Controls.Add(this.groupBoxVolume);
            this.tabAudio.Controls.Add(this.groupBoxAudioOutput);
            this.tabAudio.Controls.Add(this.groupBoxAudioBitrate);
            this.tabAudio.Controls.Add(this.groupBoxAudioEncoder);
            this.tabAudio.Controls.Add(this.groupBoxAudioCodec);
            this.tabAudio.Location = new System.Drawing.Point(4, 22);
            this.tabAudio.Name = "tabAudio";
            this.tabAudio.Padding = new System.Windows.Forms.Padding(3);
            this.tabAudio.Size = new System.Drawing.Size(471, 194);
            this.tabAudio.TabIndex = 3;
            this.tabAudio.Text = "Audio";
            this.tabAudio.UseVisualStyleBackColor = true;
            // 
            // groupBoxAudioStream
            // 
            this.groupBoxAudioStream.Controls.Add(this.buttonBrowseAudioStream);
            this.groupBoxAudioStream.Controls.Add(this.labelAudioStream);
            this.groupBoxAudioStream.Controls.Add(this.textBoxAudioStream);
            this.groupBoxAudioStream.Location = new System.Drawing.Point(6, 142);
            this.groupBoxAudioStream.Name = "groupBoxAudioStream";
            this.groupBoxAudioStream.Size = new System.Drawing.Size(459, 43);
            this.groupBoxAudioStream.TabIndex = 5;
            this.groupBoxAudioStream.TabStop = false;
            this.groupBoxAudioStream.Text = "Stream";
            // 
            // buttonBrowseAudioStream
            // 
            this.buttonBrowseAudioStream.Location = new System.Drawing.Point(378, 13);
            this.buttonBrowseAudioStream.Name = "buttonBrowseAudioStream";
            this.buttonBrowseAudioStream.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseAudioStream.TabIndex = 2;
            this.buttonBrowseAudioStream.Text = "Browse";
            this.buttonBrowseAudioStream.UseVisualStyleBackColor = true;
            // 
            // labelAudioStream
            // 
            this.labelAudioStream.AutoSize = true;
            this.labelAudioStream.Location = new System.Drawing.Point(6, 18);
            this.labelAudioStream.Name = "labelAudioStream";
            this.labelAudioStream.Size = new System.Drawing.Size(37, 13);
            this.labelAudioStream.TabIndex = 1;
            this.labelAudioStream.Text = "Audio:";
            // 
            // textBoxAudioStream
            // 
            this.textBoxAudioStream.Location = new System.Drawing.Point(49, 15);
            this.textBoxAudioStream.Name = "textBoxAudioStream";
            this.textBoxAudioStream.Size = new System.Drawing.Size(323, 20);
            this.textBoxAudioStream.TabIndex = 0;
            // 
            // groupBoxVolume
            // 
            this.groupBoxVolume.Location = new System.Drawing.Point(332, 66);
            this.groupBoxVolume.Name = "groupBoxVolume";
            this.groupBoxVolume.Size = new System.Drawing.Size(133, 70);
            this.groupBoxVolume.TabIndex = 4;
            this.groupBoxVolume.TabStop = false;
            this.groupBoxVolume.Text = "Volume";
            // 
            // groupBoxAudioOutput
            // 
            this.groupBoxAudioOutput.Controls.Add(this.comboBoxChannels);
            this.groupBoxAudioOutput.Controls.Add(this.comboBoxSampleRates);
            this.groupBoxAudioOutput.Controls.Add(this.labelChannels);
            this.groupBoxAudioOutput.Controls.Add(this.labelSampleRate);
            this.groupBoxAudioOutput.Location = new System.Drawing.Point(161, 66);
            this.groupBoxAudioOutput.Name = "groupBoxAudioOutput";
            this.groupBoxAudioOutput.Size = new System.Drawing.Size(165, 70);
            this.groupBoxAudioOutput.TabIndex = 3;
            this.groupBoxAudioOutput.TabStop = false;
            this.groupBoxAudioOutput.Text = "Output";
            // 
            // comboBoxChannels
            // 
            this.comboBoxChannels.FormattingEnabled = true;
            this.comboBoxChannels.Location = new System.Drawing.Point(70, 40);
            this.comboBoxChannels.Name = "comboBoxChannels";
            this.comboBoxChannels.Size = new System.Drawing.Size(89, 21);
            this.comboBoxChannels.TabIndex = 3;
            // 
            // comboBoxSampleRates
            // 
            this.comboBoxSampleRates.FormattingEnabled = true;
            this.comboBoxSampleRates.Location = new System.Drawing.Point(70, 16);
            this.comboBoxSampleRates.Name = "comboBoxSampleRates";
            this.comboBoxSampleRates.Size = new System.Drawing.Size(89, 21);
            this.comboBoxSampleRates.TabIndex = 2;
            // 
            // labelChannels
            // 
            this.labelChannels.AutoSize = true;
            this.labelChannels.Location = new System.Drawing.Point(6, 43);
            this.labelChannels.Name = "labelChannels";
            this.labelChannels.Size = new System.Drawing.Size(54, 13);
            this.labelChannels.TabIndex = 1;
            this.labelChannels.Text = "Channels:";
            // 
            // labelSampleRate
            // 
            this.labelSampleRate.AutoSize = true;
            this.labelSampleRate.Location = new System.Drawing.Point(6, 19);
            this.labelSampleRate.Name = "labelSampleRate";
            this.labelSampleRate.Size = new System.Drawing.Size(31, 13);
            this.labelSampleRate.TabIndex = 0;
            this.labelSampleRate.Text = "Freq:";
            // 
            // groupBoxAudioBitrate
            // 
            this.groupBoxAudioBitrate.Controls.Add(this.checkBoxUseAudioVBR);
            this.groupBoxAudioBitrate.Controls.Add(this.comboBoxAudioBitrates);
            this.groupBoxAudioBitrate.Controls.Add(this.labelAudioBitrate);
            this.groupBoxAudioBitrate.Location = new System.Drawing.Point(6, 66);
            this.groupBoxAudioBitrate.Name = "groupBoxAudioBitrate";
            this.groupBoxAudioBitrate.Size = new System.Drawing.Size(149, 70);
            this.groupBoxAudioBitrate.TabIndex = 2;
            this.groupBoxAudioBitrate.TabStop = false;
            this.groupBoxAudioBitrate.Text = "Bitrate";
            // 
            // checkBoxUseAudioVBR
            // 
            this.checkBoxUseAudioVBR.AutoSize = true;
            this.checkBoxUseAudioVBR.Location = new System.Drawing.Point(10, 43);
            this.checkBoxUseAudioVBR.Name = "checkBoxUseAudioVBR";
            this.checkBoxUseAudioVBR.Size = new System.Drawing.Size(70, 17);
            this.checkBoxUseAudioVBR.TabIndex = 2;
            this.checkBoxUseAudioVBR.Text = "Use VBR";
            this.checkBoxUseAudioVBR.UseVisualStyleBackColor = true;
            // 
            // comboBoxAudioBitrates
            // 
            this.comboBoxAudioBitrates.FormattingEnabled = true;
            this.comboBoxAudioBitrates.Location = new System.Drawing.Point(53, 16);
            this.comboBoxAudioBitrates.Name = "comboBoxAudioBitrates";
            this.comboBoxAudioBitrates.Size = new System.Drawing.Size(90, 21);
            this.comboBoxAudioBitrates.TabIndex = 1;
            // 
            // labelAudioBitrate
            // 
            this.labelAudioBitrate.AutoSize = true;
            this.labelAudioBitrate.Location = new System.Drawing.Point(7, 19);
            this.labelAudioBitrate.Name = "labelAudioBitrate";
            this.labelAudioBitrate.Size = new System.Drawing.Size(40, 13);
            this.labelAudioBitrate.TabIndex = 0;
            this.labelAudioBitrate.Text = "Bitrate:";
            // 
            // groupBoxAudioEncoder
            // 
            this.groupBoxAudioEncoder.Controls.Add(this.comboBoxAudioEncoders);
            this.groupBoxAudioEncoder.Controls.Add(this.labelAudioEncoder);
            this.groupBoxAudioEncoder.Location = new System.Drawing.Point(196, 6);
            this.groupBoxAudioEncoder.Name = "groupBoxAudioEncoder";
            this.groupBoxAudioEncoder.Size = new System.Drawing.Size(269, 54);
            this.groupBoxAudioEncoder.TabIndex = 1;
            this.groupBoxAudioEncoder.TabStop = false;
            this.groupBoxAudioEncoder.Text = "Encoder";
            // 
            // comboBoxAudioEncoders
            // 
            this.comboBoxAudioEncoders.FormattingEnabled = true;
            this.comboBoxAudioEncoders.Location = new System.Drawing.Point(62, 19);
            this.comboBoxAudioEncoders.Name = "comboBoxAudioEncoders";
            this.comboBoxAudioEncoders.Size = new System.Drawing.Size(201, 21);
            this.comboBoxAudioEncoders.TabIndex = 1;
            // 
            // labelAudioEncoder
            // 
            this.labelAudioEncoder.AutoSize = true;
            this.labelAudioEncoder.Location = new System.Drawing.Point(6, 22);
            this.labelAudioEncoder.Name = "labelAudioEncoder";
            this.labelAudioEncoder.Size = new System.Drawing.Size(50, 13);
            this.labelAudioEncoder.TabIndex = 0;
            this.labelAudioEncoder.Text = "Encoder:";
            // 
            // groupBoxAudioCodec
            // 
            this.groupBoxAudioCodec.Controls.Add(this.comboBoxAudioCodecs);
            this.groupBoxAudioCodec.Controls.Add(this.labelAudioCodec);
            this.groupBoxAudioCodec.Location = new System.Drawing.Point(6, 6);
            this.groupBoxAudioCodec.Name = "groupBoxAudioCodec";
            this.groupBoxAudioCodec.Size = new System.Drawing.Size(184, 54);
            this.groupBoxAudioCodec.TabIndex = 0;
            this.groupBoxAudioCodec.TabStop = false;
            this.groupBoxAudioCodec.Text = "Codec";
            // 
            // comboBoxAudioCodecs
            // 
            this.comboBoxAudioCodecs.FormattingEnabled = true;
            this.comboBoxAudioCodecs.Location = new System.Drawing.Point(53, 19);
            this.comboBoxAudioCodecs.Name = "comboBoxAudioCodecs";
            this.comboBoxAudioCodecs.Size = new System.Drawing.Size(125, 21);
            this.comboBoxAudioCodecs.TabIndex = 1;
            // 
            // labelAudioCodec
            // 
            this.labelAudioCodec.AutoSize = true;
            this.labelAudioCodec.Location = new System.Drawing.Point(6, 22);
            this.labelAudioCodec.Name = "labelAudioCodec";
            this.labelAudioCodec.Size = new System.Drawing.Size(41, 13);
            this.labelAudioCodec.TabIndex = 0;
            this.labelAudioCodec.Text = "Codec:";
            // 
            // tabMisc
            // 
            this.tabMisc.Controls.Add(this.groupBoxBinaries);
            this.tabMisc.Location = new System.Drawing.Point(4, 22);
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tabMisc.Size = new System.Drawing.Size(471, 194);
            this.tabMisc.TabIndex = 4;
            this.tabMisc.Text = "Misc";
            this.tabMisc.UseVisualStyleBackColor = true;
            // 
            // groupBoxBinaries
            // 
            this.groupBoxBinaries.Controls.Add(this.textBoxTermArgs);
            this.groupBoxBinaries.Controls.Add(this.label3);
            this.groupBoxBinaries.Controls.Add(this.textBoxTermBin);
            this.groupBoxBinaries.Controls.Add(this.labelTermBin);
            this.groupBoxBinaries.Controls.Add(this.buttonBrowseTermBin);
            this.groupBoxBinaries.Controls.Add(this.buttonBrowseFFmpegBin);
            this.groupBoxBinaries.Controls.Add(this.textBoxFFmpegBin);
            this.groupBoxBinaries.Controls.Add(this.labelFFmpegBin);
            this.groupBoxBinaries.Location = new System.Drawing.Point(6, 6);
            this.groupBoxBinaries.Name = "groupBoxBinaries";
            this.groupBoxBinaries.Size = new System.Drawing.Size(459, 97);
            this.groupBoxBinaries.TabIndex = 0;
            this.groupBoxBinaries.TabStop = false;
            this.groupBoxBinaries.Text = "Binaries";
            // 
            // textBoxTermArgs
            // 
            this.textBoxTermArgs.Location = new System.Drawing.Point(98, 66);
            this.textBoxTermArgs.Name = "textBoxTermArgs";
            this.textBoxTermArgs.Size = new System.Drawing.Size(355, 20);
            this.textBoxTermArgs.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Term arguments:";
            // 
            // textBoxTermBin
            // 
            this.textBoxTermBin.Location = new System.Drawing.Point(62, 41);
            this.textBoxTermBin.Name = "textBoxTermBin";
            this.textBoxTermBin.Size = new System.Drawing.Size(310, 20);
            this.textBoxTermBin.TabIndex = 5;
            // 
            // labelTermBin
            // 
            this.labelTermBin.AutoSize = true;
            this.labelTermBin.Location = new System.Drawing.Point(6, 44);
            this.labelTermBin.Name = "labelTermBin";
            this.labelTermBin.Size = new System.Drawing.Size(50, 13);
            this.labelTermBin.TabIndex = 4;
            this.labelTermBin.Text = "Terminal:";
            // 
            // buttonBrowseTermBin
            // 
            this.buttonBrowseTermBin.Location = new System.Drawing.Point(378, 39);
            this.buttonBrowseTermBin.Name = "buttonBrowseTermBin";
            this.buttonBrowseTermBin.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseTermBin.TabIndex = 3;
            this.buttonBrowseTermBin.Text = "Browse";
            this.buttonBrowseTermBin.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseFFmpegBin
            // 
            this.buttonBrowseFFmpegBin.Location = new System.Drawing.Point(378, 13);
            this.buttonBrowseFFmpegBin.Name = "buttonBrowseFFmpegBin";
            this.buttonBrowseFFmpegBin.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseFFmpegBin.TabIndex = 2;
            this.buttonBrowseFFmpegBin.Text = "Browse";
            this.buttonBrowseFFmpegBin.UseVisualStyleBackColor = true;
            // 
            // textBoxFFmpegBin
            // 
            this.textBoxFFmpegBin.Location = new System.Drawing.Point(62, 16);
            this.textBoxFFmpegBin.Name = "textBoxFFmpegBin";
            this.textBoxFFmpegBin.Size = new System.Drawing.Size(310, 20);
            this.textBoxFFmpegBin.TabIndex = 1;
            // 
            // labelFFmpegBin
            // 
            this.labelFFmpegBin.AutoSize = true;
            this.labelFFmpegBin.Location = new System.Drawing.Point(6, 19);
            this.labelFFmpegBin.Name = "labelFFmpegBin";
            this.labelFFmpegBin.Size = new System.Drawing.Size(48, 13);
            this.labelFFmpegBin.TabIndex = 0;
            this.labelFFmpegBin.Text = "FFmpeg:";
            // 
            // FFmpegCatapultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 280);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FFmpegCatapultForm";
            this.Text = "FFmpeg Catapult";
            this.Load += new System.EventHandler(this.FFmpegCatapultForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.groupBoxSession.ResumeLayout(false);
            this.groupBoxSession.PerformLayout();
            this.groupBoxEncoding.ResumeLayout(false);
            this.groupBoxEncoding.PerformLayout();
            this.groupBoxFiles.ResumeLayout(false);
            this.groupBoxFiles.PerformLayout();
            this.tabPicture.ResumeLayout(false);
            this.groupBoxScalingMethods.ResumeLayout(false);
            this.groupBoxScalingMethods.PerformLayout();
            this.groupBoxLayout.ResumeLayout(false);
            this.groupBoxLayout.PerformLayout();
            this.groupBoxScreen.ResumeLayout(false);
            this.groupBoxScreen.PerformLayout();
            this.groupBoxResolution.ResumeLayout(false);
            this.groupBoxResolution.PerformLayout();
            this.tabVideo.ResumeLayout(false);
            this.groupBoxVideoBitrate.ResumeLayout(false);
            this.groupBoxVideoBitrate.PerformLayout();
            this.groupBoxVideoEncoder.ResumeLayout(false);
            this.groupBoxVideoEncoder.PerformLayout();
            this.groupBoxVideoCodec.ResumeLayout(false);
            this.groupBoxVideoCodec.PerformLayout();
            this.tabAudio.ResumeLayout(false);
            this.groupBoxAudioStream.ResumeLayout(false);
            this.groupBoxAudioStream.PerformLayout();
            this.groupBoxAudioOutput.ResumeLayout(false);
            this.groupBoxAudioOutput.PerformLayout();
            this.groupBoxAudioBitrate.ResumeLayout(false);
            this.groupBoxAudioBitrate.PerformLayout();
            this.groupBoxAudioEncoder.ResumeLayout(false);
            this.groupBoxAudioEncoder.PerformLayout();
            this.groupBoxAudioCodec.ResumeLayout(false);
            this.groupBoxAudioCodec.PerformLayout();
            this.tabMisc.ResumeLayout(false);
            this.groupBoxBinaries.ResumeLayout(false);
            this.groupBoxBinaries.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabPicture;
        private System.Windows.Forms.TabPage tabVideo;
        private System.Windows.Forms.TabPage tabAudio;
        private System.Windows.Forms.TabPage tabMisc;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.TextBox textBoxInFile;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Button buttonBrowseOutput;
        private System.Windows.Forms.Button buttonBrowseInput;
        private System.Windows.Forms.TextBox textBoxOutFile;
        private System.Windows.Forms.GroupBox groupBoxEncoding;
        private System.Windows.Forms.CheckBox checkBoxOverwrite;
        private System.Windows.Forms.ComboBox comboBoxThreads;
        private System.Windows.Forms.Label labelThreads;
        private System.Windows.Forms.ComboBox comboBoxContainers;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.ComboBox comboBoxPresets;
        private System.Windows.Forms.Label labelPreset;
        private System.Windows.Forms.GroupBox groupBoxSession;
        private System.Windows.Forms.RadioButton radioButtonRefresh;
        private System.Windows.Forms.RadioButton radioButtonKeep;
        private System.Windows.Forms.GroupBox groupBoxResolution;
        private System.Windows.Forms.RadioButton radioButtonCustomRes;
        private System.Windows.Forms.RadioButton radioButtonHalfRes;
        private System.Windows.Forms.RadioButton radioButtonKeepRes;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.GroupBox groupBoxScreen;
        private System.Windows.Forms.Label labelFPS;
        private System.Windows.Forms.Label labelRatioDash;
        private System.Windows.Forms.Label labelRatio;
        private System.Windows.Forms.CheckBox checkBoxDeinterlace;
        private System.Windows.Forms.CheckBox checkBoxAspectRatio;
        private System.Windows.Forms.GroupBox groupBoxLayout;
        private System.Windows.Forms.Label labelVert;
        private System.Windows.Forms.Label labelLayoutHeight;
        private System.Windows.Forms.Label labelLayoutWidth;
        private System.Windows.Forms.CheckBox checkBoxPad;
        private System.Windows.Forms.CheckBox checkBoxCrop;
        private System.Windows.Forms.GroupBox groupBoxScalingMethods;
        private System.Windows.Forms.ComboBox comboBoxScalingMethods;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.TextBox textBoxLayoutColour;
        private System.Windows.Forms.Label labelLayoutColour;
        private System.Windows.Forms.Label labelHoriz;
        private System.Windows.Forms.GroupBox groupBoxVideoCodec;
        private System.Windows.Forms.CheckBox checkBoxTwoPassEncoding;
        private System.Windows.Forms.ComboBox comboBoxVideoCodecs;
        private System.Windows.Forms.Label labelVideoCodec;
        private System.Windows.Forms.GroupBox groupBoxVideoBitrate;
        private System.Windows.Forms.GroupBox groupBoxVideoEncoder;
        private System.Windows.Forms.ComboBox comboBoxVideoEncoders;
        private System.Windows.Forms.Label labelVideoEncoder;
        private System.Windows.Forms.TextBox textBoxCRF;
        private System.Windows.Forms.Label labelCRF;
        private System.Windows.Forms.CheckBox checkBoxUseCRF;
        private System.Windows.Forms.Label labelBuffer;
        private System.Windows.Forms.Label labelMaxBitrate;
        private System.Windows.Forms.ComboBox comboBoxBits;
        private System.Windows.Forms.Label labelMinBitrate;
        private System.Windows.Forms.Label labelVideoBitrate;
        private System.Windows.Forms.ComboBox comboBoxBytes;
        private System.Windows.Forms.Label labelMinBits;
        private System.Windows.Forms.Label labelMaxBits;
        private System.Windows.Forms.GroupBox groupBoxAudioEncoder;
        private System.Windows.Forms.ComboBox comboBoxAudioEncoders;
        private System.Windows.Forms.Label labelAudioEncoder;
        private System.Windows.Forms.GroupBox groupBoxAudioCodec;
        private System.Windows.Forms.ComboBox comboBoxAudioCodecs;
        private System.Windows.Forms.Label labelAudioCodec;
        private System.Windows.Forms.GroupBox groupBoxAudioOutput;
        private System.Windows.Forms.ComboBox comboBoxChannels;
        private System.Windows.Forms.ComboBox comboBoxSampleRates;
        private System.Windows.Forms.Label labelChannels;
        private System.Windows.Forms.Label labelSampleRate;
        private System.Windows.Forms.GroupBox groupBoxAudioBitrate;
        private System.Windows.Forms.CheckBox checkBoxUseAudioVBR;
        private System.Windows.Forms.ComboBox comboBoxAudioBitrates;
        private System.Windows.Forms.Label labelAudioBitrate;
        private System.Windows.Forms.GroupBox groupBoxAudioStream;
        private System.Windows.Forms.TextBox textBoxAudioStream;
        private System.Windows.Forms.GroupBox groupBoxVolume;
        private System.Windows.Forms.Button buttonBrowseAudioStream;
        private System.Windows.Forms.Label labelAudioStream;
        private System.Windows.Forms.GroupBox groupBoxBinaries;
        private System.Windows.Forms.TextBox textBoxTermArgs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTermBin;
        private System.Windows.Forms.Label labelTermBin;
        private System.Windows.Forms.Button buttonBrowseTermBin;
        private System.Windows.Forms.Button buttonBrowseFFmpegBin;
        private System.Windows.Forms.TextBox textBoxFFmpegBin;
        private System.Windows.Forms.Label labelFFmpegBin;
        private System.Windows.Forms.TextBox textBoxFPS;
        private System.Windows.Forms.TextBox textBoxRatioB;
        private System.Windows.Forms.TextBox textBoxRatioA;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxLayoutHoriz;
        private System.Windows.Forms.TextBox textBoxLayoutVert;
        private System.Windows.Forms.TextBox textBoxLayoutHeight;
        private System.Windows.Forms.TextBox textBoxLayoutWidth;
        private System.Windows.Forms.TextBox textBoxBufferSize;
        private System.Windows.Forms.TextBox textBoxMaxBitrate;
        private System.Windows.Forms.TextBox textBoxMinBitrate;
        private System.Windows.Forms.TextBox textBoxVideoBitrate;
        private System.Windows.Forms.TextBox textBoxQmax;
        private System.Windows.Forms.Label labelQmax;
        private System.Windows.Forms.TextBox textBoxQmin;
        private System.Windows.Forms.Label labelQmin;
    }
}

