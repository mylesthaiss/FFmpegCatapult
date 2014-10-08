﻿// VideoSettingsForm is part of FFmpeg Catapult.
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

namespace FFmpegCatapult
{
    partial class VideoSettingsForm
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
            this.groupBoxEncoding = new System.Windows.Forms.GroupBox();
            this.comboBoxTrellis = new System.Windows.Forms.ComboBox();
            this.labelTrellis = new System.Windows.Forms.Label();
            this.textBoxDiaSize = new System.Windows.Forms.TextBox();
            this.labelDieSize = new System.Windows.Forms.Label();
            this.comboBoxMEMethods = new System.Windows.Forms.ComboBox();
            this.labelMEMethod = new System.Windows.Forms.Label();
            this.comboBoxEncoderPresets = new System.Windows.Forms.ComboBox();
            this.labelEncoderPreset = new System.Windows.Forms.Label();
            this.groupBoxCodec = new System.Windows.Forms.GroupBox();
            this.textBoxCodecLevel = new System.Windows.Forms.TextBox();
            this.labelEncodingLevel = new System.Windows.Forms.Label();
            this.labelCodecProfile = new System.Windows.Forms.Label();
            this.comboBoxCodecProfiles = new System.Windows.Forms.ComboBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxBFrames = new System.Windows.Forms.GroupBox();
            this.comboBoxBFStrats = new System.Windows.Forms.ComboBox();
            this.labelBFStrategy = new System.Windows.Forms.Label();
            this.textBoxBFrames = new System.Windows.Forms.TextBox();
            this.labelBFrames = new System.Windows.Forms.Label();
            this.groupBoxPicture = new System.Windows.Forms.GroupBox();
            this.comboBoxPictureFormats = new System.Windows.Forms.ComboBox();
            this.labelPicFormat = new System.Windows.Forms.Label();
            this.textBoxGOPSize = new System.Windows.Forms.TextBox();
            this.labelGOPSize = new System.Windows.Forms.Label();
            this.groupBoxGOP = new System.Windows.Forms.GroupBox();
            this.groupBoxMotionComp = new System.Windows.Forms.GroupBox();
            this.labelSubCMP = new System.Windows.Forms.Label();
            this.comboBoxSubCMPFuncs = new System.Windows.Forms.ComboBox();
            this.comboBoxCMPFuncs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEncoding.SuspendLayout();
            this.groupBoxCodec.SuspendLayout();
            this.groupBoxBFrames.SuspendLayout();
            this.groupBoxPicture.SuspendLayout();
            this.groupBoxGOP.SuspendLayout();
            this.groupBoxMotionComp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEncoding
            // 
            this.groupBoxEncoding.Controls.Add(this.comboBoxTrellis);
            this.groupBoxEncoding.Controls.Add(this.labelTrellis);
            this.groupBoxEncoding.Controls.Add(this.textBoxDiaSize);
            this.groupBoxEncoding.Controls.Add(this.labelDieSize);
            this.groupBoxEncoding.Controls.Add(this.comboBoxMEMethods);
            this.groupBoxEncoding.Controls.Add(this.labelMEMethod);
            this.groupBoxEncoding.Controls.Add(this.comboBoxEncoderPresets);
            this.groupBoxEncoding.Controls.Add(this.labelEncoderPreset);
            this.groupBoxEncoding.Location = new System.Drawing.Point(12, 61);
            this.groupBoxEncoding.Name = "groupBoxEncoding";
            this.groupBoxEncoding.Size = new System.Drawing.Size(278, 70);
            this.groupBoxEncoding.TabIndex = 0;
            this.groupBoxEncoding.TabStop = false;
            this.groupBoxEncoding.Text = "Encoding";
            // 
            // comboBoxTrellis
            // 
            this.comboBoxTrellis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrellis.FormattingEnabled = true;
            this.comboBoxTrellis.Location = new System.Drawing.Point(206, 17);
            this.comboBoxTrellis.Name = "comboBoxTrellis";
            this.comboBoxTrellis.Size = new System.Drawing.Size(66, 21);
            this.comboBoxTrellis.TabIndex = 9;
            this.comboBoxTrellis.TextChanged += new System.EventHandler(this.valueChanged);
            // 
            // labelTrellis
            // 
            this.labelTrellis.AutoSize = true;
            this.labelTrellis.Location = new System.Drawing.Point(163, 20);
            this.labelTrellis.Name = "labelTrellis";
            this.labelTrellis.Size = new System.Drawing.Size(37, 13);
            this.labelTrellis.TabIndex = 8;
            this.labelTrellis.Text = "Trellis:";
            // 
            // textBoxDiaSize
            // 
            this.textBoxDiaSize.Location = new System.Drawing.Point(237, 41);
            this.textBoxDiaSize.Name = "textBoxDiaSize";
            this.textBoxDiaSize.Size = new System.Drawing.Size(35, 20);
            this.textBoxDiaSize.TabIndex = 6;
            this.textBoxDiaSize.TextChanged += new System.EventHandler(this.valueChanged);
            this.textBoxDiaSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelDieSize
            // 
            this.labelDieSize.AutoSize = true;
            this.labelDieSize.Location = new System.Drawing.Point(184, 44);
            this.labelDieSize.Name = "labelDieSize";
            this.labelDieSize.Size = new System.Drawing.Size(47, 13);
            this.labelDieSize.TabIndex = 5;
            this.labelDieSize.Text = "Dia size:";
            // 
            // comboBoxMEMethods
            // 
            this.comboBoxMEMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMEMethods.FormattingEnabled = true;
            this.comboBoxMEMethods.Location = new System.Drawing.Point(76, 41);
            this.comboBoxMEMethods.Name = "comboBoxMEMethods";
            this.comboBoxMEMethods.Size = new System.Drawing.Size(102, 21);
            this.comboBoxMEMethods.TabIndex = 4;
            this.comboBoxMEMethods.TextChanged += new System.EventHandler(this.valueChanged);
            // 
            // labelMEMethod
            // 
            this.labelMEMethod.AutoSize = true;
            this.labelMEMethod.Location = new System.Drawing.Point(6, 44);
            this.labelMEMethod.Name = "labelMEMethod";
            this.labelMEMethod.Size = new System.Drawing.Size(64, 13);
            this.labelMEMethod.TabIndex = 2;
            this.labelMEMethod.Text = "ME method:";
            // 
            // comboBoxEncoderPresets
            // 
            this.comboBoxEncoderPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEncoderPresets.Enabled = false;
            this.comboBoxEncoderPresets.FormattingEnabled = true;
            this.comboBoxEncoderPresets.Location = new System.Drawing.Point(51, 17);
            this.comboBoxEncoderPresets.Name = "comboBoxEncoderPresets";
            this.comboBoxEncoderPresets.Size = new System.Drawing.Size(106, 21);
            this.comboBoxEncoderPresets.TabIndex = 1;
            this.comboBoxEncoderPresets.TextChanged += new System.EventHandler(this.valueChanged);
            // 
            // labelEncoderPreset
            // 
            this.labelEncoderPreset.AutoSize = true;
            this.labelEncoderPreset.Enabled = false;
            this.labelEncoderPreset.Location = new System.Drawing.Point(6, 20);
            this.labelEncoderPreset.Name = "labelEncoderPreset";
            this.labelEncoderPreset.Size = new System.Drawing.Size(40, 13);
            this.labelEncoderPreset.TabIndex = 0;
            this.labelEncoderPreset.Text = "Preset:";
            // 
            // groupBoxCodec
            // 
            this.groupBoxCodec.Controls.Add(this.textBoxCodecLevel);
            this.groupBoxCodec.Controls.Add(this.labelEncodingLevel);
            this.groupBoxCodec.Controls.Add(this.labelCodecProfile);
            this.groupBoxCodec.Controls.Add(this.comboBoxCodecProfiles);
            this.groupBoxCodec.Enabled = false;
            this.groupBoxCodec.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCodec.Name = "groupBoxCodec";
            this.groupBoxCodec.Size = new System.Drawing.Size(278, 43);
            this.groupBoxCodec.TabIndex = 1;
            this.groupBoxCodec.TabStop = false;
            this.groupBoxCodec.Text = "Codec";
            // 
            // textBoxCodecLevel
            // 
            this.textBoxCodecLevel.Location = new System.Drawing.Point(237, 15);
            this.textBoxCodecLevel.Name = "textBoxCodecLevel";
            this.textBoxCodecLevel.Size = new System.Drawing.Size(35, 20);
            this.textBoxCodecLevel.TabIndex = 2;
            this.textBoxCodecLevel.TextChanged += new System.EventHandler(this.valueChanged);
            this.textBoxCodecLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressDecimal);
            // 
            // labelEncodingLevel
            // 
            this.labelEncodingLevel.AutoSize = true;
            this.labelEncodingLevel.Location = new System.Drawing.Point(195, 18);
            this.labelEncodingLevel.Name = "labelEncodingLevel";
            this.labelEncodingLevel.Size = new System.Drawing.Size(36, 13);
            this.labelEncodingLevel.TabIndex = 2;
            this.labelEncodingLevel.Text = "Level:";
            // 
            // labelCodecProfile
            // 
            this.labelCodecProfile.AutoSize = true;
            this.labelCodecProfile.Location = new System.Drawing.Point(6, 17);
            this.labelCodecProfile.Name = "labelCodecProfile";
            this.labelCodecProfile.Size = new System.Drawing.Size(39, 13);
            this.labelCodecProfile.TabIndex = 0;
            this.labelCodecProfile.Text = "Profile:";
            // 
            // comboBoxCodecProfiles
            // 
            this.comboBoxCodecProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCodecProfiles.FormattingEnabled = true;
            this.comboBoxCodecProfiles.Location = new System.Drawing.Point(51, 14);
            this.comboBoxCodecProfiles.Name = "comboBoxCodecProfiles";
            this.comboBoxCodecProfiles.Size = new System.Drawing.Size(138, 21);
            this.comboBoxCodecProfiles.TabIndex = 1;
            this.comboBoxCodecProfiles.SelectedIndexChanged += new System.EventHandler(this.valueChanged);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(215, 295);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(134, 295);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxBFrames
            // 
            this.groupBoxBFrames.Controls.Add(this.comboBoxBFStrats);
            this.groupBoxBFrames.Controls.Add(this.labelBFStrategy);
            this.groupBoxBFrames.Controls.Add(this.textBoxBFrames);
            this.groupBoxBFrames.Controls.Add(this.labelBFrames);
            this.groupBoxBFrames.Location = new System.Drawing.Point(12, 137);
            this.groupBoxBFrames.Name = "groupBoxBFrames";
            this.groupBoxBFrames.Size = new System.Drawing.Size(278, 47);
            this.groupBoxBFrames.TabIndex = 4;
            this.groupBoxBFrames.TabStop = false;
            this.groupBoxBFrames.Text = "B-Frames";
            // 
            // comboBoxBFStrats
            // 
            this.comboBoxBFStrats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBFStrats.FormattingEnabled = true;
            this.comboBoxBFStrats.Location = new System.Drawing.Point(163, 16);
            this.comboBoxBFStrats.Name = "comboBoxBFStrats";
            this.comboBoxBFStrats.Size = new System.Drawing.Size(109, 21);
            this.comboBoxBFStrats.TabIndex = 3;
            this.comboBoxBFStrats.TextChanged += new System.EventHandler(this.valueChanged);
            // 
            // labelBFStrategy
            // 
            this.labelBFStrategy.AutoSize = true;
            this.labelBFStrategy.Location = new System.Drawing.Point(108, 19);
            this.labelBFStrategy.Name = "labelBFStrategy";
            this.labelBFStrategy.Size = new System.Drawing.Size(49, 13);
            this.labelBFStrategy.TabIndex = 2;
            this.labelBFStrategy.Text = "Strategy:";
            // 
            // textBoxBFrames
            // 
            this.textBoxBFrames.Location = new System.Drawing.Point(66, 16);
            this.textBoxBFrames.Name = "textBoxBFrames";
            this.textBoxBFrames.Size = new System.Drawing.Size(35, 20);
            this.textBoxBFrames.TabIndex = 1;
            this.textBoxBFrames.TextChanged += new System.EventHandler(this.valueChanged);
            this.textBoxBFrames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelBFrames
            // 
            this.labelBFrames.AutoSize = true;
            this.labelBFrames.Location = new System.Drawing.Point(6, 19);
            this.labelBFrames.Name = "labelBFrames";
            this.labelBFrames.Size = new System.Drawing.Size(54, 13);
            this.labelBFrames.TabIndex = 0;
            this.labelBFrames.Text = "B-Frames:";
            // 
            // groupBoxPicture
            // 
            this.groupBoxPicture.Controls.Add(this.comboBoxPictureFormats);
            this.groupBoxPicture.Controls.Add(this.labelPicFormat);
            this.groupBoxPicture.Location = new System.Drawing.Point(12, 243);
            this.groupBoxPicture.Name = "groupBoxPicture";
            this.groupBoxPicture.Size = new System.Drawing.Size(187, 43);
            this.groupBoxPicture.TabIndex = 5;
            this.groupBoxPicture.TabStop = false;
            this.groupBoxPicture.Text = "Picture";
            // 
            // comboBoxPictureFormats
            // 
            this.comboBoxPictureFormats.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBoxPictureFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPictureFormats.FormattingEnabled = true;
            this.comboBoxPictureFormats.Location = new System.Drawing.Point(54, 14);
            this.comboBoxPictureFormats.Name = "comboBoxPictureFormats";
            this.comboBoxPictureFormats.Size = new System.Drawing.Size(124, 21);
            this.comboBoxPictureFormats.TabIndex = 3;
            this.comboBoxPictureFormats.TextChanged += new System.EventHandler(this.valueChanged);
            // 
            // labelPicFormat
            // 
            this.labelPicFormat.AutoSize = true;
            this.labelPicFormat.Location = new System.Drawing.Point(6, 17);
            this.labelPicFormat.Name = "labelPicFormat";
            this.labelPicFormat.Size = new System.Drawing.Size(42, 13);
            this.labelPicFormat.TabIndex = 2;
            this.labelPicFormat.Text = "Format:";
            // 
            // textBoxGOPSize
            // 
            this.textBoxGOPSize.Location = new System.Drawing.Point(42, 14);
            this.textBoxGOPSize.Name = "textBoxGOPSize";
            this.textBoxGOPSize.Size = new System.Drawing.Size(35, 20);
            this.textBoxGOPSize.TabIndex = 1;
            this.textBoxGOPSize.TextChanged += new System.EventHandler(this.valueChanged);
            this.textBoxGOPSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelGOPSize
            // 
            this.labelGOPSize.AutoSize = true;
            this.labelGOPSize.Location = new System.Drawing.Point(6, 17);
            this.labelGOPSize.Name = "labelGOPSize";
            this.labelGOPSize.Size = new System.Drawing.Size(30, 13);
            this.labelGOPSize.TabIndex = 0;
            this.labelGOPSize.Text = "Size:";
            // 
            // groupBoxGOP
            // 
            this.groupBoxGOP.Controls.Add(this.labelGOPSize);
            this.groupBoxGOP.Controls.Add(this.textBoxGOPSize);
            this.groupBoxGOP.Location = new System.Drawing.Point(205, 243);
            this.groupBoxGOP.Name = "groupBoxGOP";
            this.groupBoxGOP.Size = new System.Drawing.Size(85, 43);
            this.groupBoxGOP.TabIndex = 6;
            this.groupBoxGOP.TabStop = false;
            this.groupBoxGOP.Text = "GOP";
            // 
            // groupBoxMotionComp
            // 
            this.groupBoxMotionComp.Controls.Add(this.labelSubCMP);
            this.groupBoxMotionComp.Controls.Add(this.comboBoxSubCMPFuncs);
            this.groupBoxMotionComp.Controls.Add(this.comboBoxCMPFuncs);
            this.groupBoxMotionComp.Controls.Add(this.label1);
            this.groupBoxMotionComp.Location = new System.Drawing.Point(12, 190);
            this.groupBoxMotionComp.Name = "groupBoxMotionComp";
            this.groupBoxMotionComp.Size = new System.Drawing.Size(278, 47);
            this.groupBoxMotionComp.TabIndex = 7;
            this.groupBoxMotionComp.TabStop = false;
            this.groupBoxMotionComp.Text = "Motion Estimation Compare";
            // 
            // labelSubCMP
            // 
            this.labelSubCMP.AutoSize = true;
            this.labelSubCMP.Location = new System.Drawing.Point(139, 19);
            this.labelSubCMP.Name = "labelSubCMP";
            this.labelSubCMP.Size = new System.Drawing.Size(53, 13);
            this.labelSubCMP.TabIndex = 3;
            this.labelSubCMP.Text = "Sub pixel:";
            // 
            // comboBoxSubCMPFuncs
            // 
            this.comboBoxSubCMPFuncs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubCMPFuncs.FormattingEnabled = true;
            this.comboBoxSubCMPFuncs.Location = new System.Drawing.Point(198, 16);
            this.comboBoxSubCMPFuncs.Name = "comboBoxSubCMPFuncs";
            this.comboBoxSubCMPFuncs.Size = new System.Drawing.Size(74, 21);
            this.comboBoxSubCMPFuncs.TabIndex = 2;
            this.comboBoxSubCMPFuncs.TextChanged += new System.EventHandler(this.valueChanged);
            // 
            // comboBoxCMPFuncs
            // 
            this.comboBoxCMPFuncs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCMPFuncs.FormattingEnabled = true;
            this.comboBoxCMPFuncs.Location = new System.Drawing.Point(38, 16);
            this.comboBoxCMPFuncs.Name = "comboBoxCMPFuncs";
            this.comboBoxCMPFuncs.Size = new System.Drawing.Size(74, 21);
            this.comboBoxCMPFuncs.TabIndex = 1;
            this.comboBoxCMPFuncs.TextChanged += new System.EventHandler(this.valueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full:";
            // 
            // VideoSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 330);
            this.Controls.Add(this.groupBoxMotionComp);
            this.Controls.Add(this.groupBoxGOP);
            this.Controls.Add(this.groupBoxPicture);
            this.Controls.Add(this.groupBoxBFrames);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.groupBoxCodec);
            this.Controls.Add(this.groupBoxEncoding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoSettingsForm";
            this.ShowIcon = false;
            this.Text = "Video Properties";
            this.Load += new System.EventHandler(this.VideoSettingsForm_Load);
            this.groupBoxEncoding.ResumeLayout(false);
            this.groupBoxEncoding.PerformLayout();
            this.groupBoxCodec.ResumeLayout(false);
            this.groupBoxCodec.PerformLayout();
            this.groupBoxBFrames.ResumeLayout(false);
            this.groupBoxBFrames.PerformLayout();
            this.groupBoxPicture.ResumeLayout(false);
            this.groupBoxPicture.PerformLayout();
            this.groupBoxGOP.ResumeLayout(false);
            this.groupBoxGOP.PerformLayout();
            this.groupBoxMotionComp.ResumeLayout(false);
            this.groupBoxMotionComp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEncoding;
        private System.Windows.Forms.GroupBox groupBoxCodec;
        private System.Windows.Forms.Label labelCodecProfile;
        private System.Windows.Forms.ComboBox comboBoxCodecProfiles;
        private System.Windows.Forms.Label labelEncoderPreset;
        private System.Windows.Forms.TextBox textBoxCodecLevel;
        private System.Windows.Forms.Label labelEncodingLevel;
        private System.Windows.Forms.ComboBox comboBoxEncoderPresets;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxMEMethods;
        private System.Windows.Forms.Label labelMEMethod;
        private System.Windows.Forms.TextBox textBoxDiaSize;
        private System.Windows.Forms.Label labelDieSize;
        private System.Windows.Forms.GroupBox groupBoxBFrames;
        private System.Windows.Forms.Label labelBFStrategy;
        private System.Windows.Forms.TextBox textBoxBFrames;
        private System.Windows.Forms.Label labelBFrames;
        private System.Windows.Forms.ComboBox comboBoxBFStrats;
        private System.Windows.Forms.GroupBox groupBoxPicture;
        private System.Windows.Forms.ComboBox comboBoxPictureFormats;
        private System.Windows.Forms.Label labelPicFormat;
        private System.Windows.Forms.TextBox textBoxGOPSize;
        private System.Windows.Forms.Label labelGOPSize;
        private System.Windows.Forms.GroupBox groupBoxGOP;
        private System.Windows.Forms.GroupBox groupBoxMotionComp;
        private System.Windows.Forms.Label labelSubCMP;
        private System.Windows.Forms.ComboBox comboBoxSubCMPFuncs;
        private System.Windows.Forms.ComboBox comboBoxCMPFuncs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTrellis;
        private System.Windows.Forms.Label labelTrellis;
    }
}