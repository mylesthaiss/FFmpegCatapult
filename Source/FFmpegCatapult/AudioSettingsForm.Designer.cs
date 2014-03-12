// WinForms code and events for FFmpeg Catapult.
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
    partial class AudioSettingsForm
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
            this.groupBoxCodec = new System.Windows.Forms.GroupBox();
            this.comboBoxCodecProfiles = new System.Windows.Forms.ComboBox();
            this.labelProfile = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxCodec.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCodec
            // 
            this.groupBoxCodec.Controls.Add(this.comboBoxCodecProfiles);
            this.groupBoxCodec.Controls.Add(this.labelProfile);
            this.groupBoxCodec.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCodec.Name = "groupBoxCodec";
            this.groupBoxCodec.Size = new System.Drawing.Size(200, 43);
            this.groupBoxCodec.TabIndex = 0;
            this.groupBoxCodec.TabStop = false;
            this.groupBoxCodec.Text = "Codec";
            // 
            // comboBoxCodecProfiles
            // 
            this.comboBoxCodecProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCodecProfiles.FormattingEnabled = true;
            this.comboBoxCodecProfiles.Location = new System.Drawing.Point(51, 14);
            this.comboBoxCodecProfiles.Name = "comboBoxCodecProfiles";
            this.comboBoxCodecProfiles.Size = new System.Drawing.Size(143, 21);
            this.comboBoxCodecProfiles.TabIndex = 1;
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Location = new System.Drawing.Point(6, 17);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(39, 13);
            this.labelProfile.TabIndex = 0;
            this.labelProfile.Text = "Profile:";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(137, 61);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(56, 61);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AudioSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 95);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.groupBoxCodec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AudioSettingsForm";
            this.ShowIcon = false;
            this.Text = "Audio Properties";
            this.Load += new System.EventHandler(this.AudioSettingsForm_Load);
            this.groupBoxCodec.ResumeLayout(false);
            this.groupBoxCodec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCodec;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.ComboBox comboBoxCodecProfiles;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
    }
}