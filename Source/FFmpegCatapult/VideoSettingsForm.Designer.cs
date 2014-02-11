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
            this.groupBoxCodec = new System.Windows.Forms.GroupBox();
            this.labelCodecProfile = new System.Windows.Forms.Label();
            this.comboBoxCodecProfiles = new System.Windows.Forms.ComboBox();
            this.labelEncodingLevel = new System.Windows.Forms.Label();
            this.textBoxCodecLevel = new System.Windows.Forms.TextBox();
            this.labelEncoderPreset = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxEncoding.SuspendLayout();
            this.groupBoxCodec.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEncoding
            // 
            this.groupBoxEncoding.Controls.Add(this.comboBox1);
            this.groupBoxEncoding.Controls.Add(this.labelEncoderPreset);
            this.groupBoxEncoding.Location = new System.Drawing.Point(12, 78);
            this.groupBoxEncoding.Name = "groupBoxEncoding";
            this.groupBoxEncoding.Size = new System.Drawing.Size(278, 123);
            this.groupBoxEncoding.TabIndex = 0;
            this.groupBoxEncoding.TabStop = false;
            this.groupBoxEncoding.Text = "Encoding";
            // 
            // groupBoxCodec
            // 
            this.groupBoxCodec.Controls.Add(this.textBoxCodecLevel);
            this.groupBoxCodec.Controls.Add(this.labelEncodingLevel);
            this.groupBoxCodec.Controls.Add(this.labelCodecProfile);
            this.groupBoxCodec.Controls.Add(this.comboBoxCodecProfiles);
            this.groupBoxCodec.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCodec.Name = "groupBoxCodec";
            this.groupBoxCodec.Size = new System.Drawing.Size(278, 51);
            this.groupBoxCodec.TabIndex = 1;
            this.groupBoxCodec.TabStop = false;
            this.groupBoxCodec.Text = "Codec";
            // 
            // labelCodecProfile
            // 
            this.labelCodecProfile.AutoSize = true;
            this.labelCodecProfile.Location = new System.Drawing.Point(6, 22);
            this.labelCodecProfile.Name = "labelCodecProfile";
            this.labelCodecProfile.Size = new System.Drawing.Size(39, 13);
            this.labelCodecProfile.TabIndex = 0;
            this.labelCodecProfile.Text = "Profile:";
            // 
            // comboBoxCodecProfiles
            // 
            this.comboBoxCodecProfiles.FormattingEnabled = true;
            this.comboBoxCodecProfiles.Location = new System.Drawing.Point(51, 18);
            this.comboBoxCodecProfiles.Name = "comboBoxCodecProfiles";
            this.comboBoxCodecProfiles.Size = new System.Drawing.Size(138, 21);
            this.comboBoxCodecProfiles.TabIndex = 1;
            // 
            // labelEncodingLevel
            // 
            this.labelEncodingLevel.AutoSize = true;
            this.labelEncodingLevel.Location = new System.Drawing.Point(195, 22);
            this.labelEncodingLevel.Name = "labelEncodingLevel";
            this.labelEncodingLevel.Size = new System.Drawing.Size(36, 13);
            this.labelEncodingLevel.TabIndex = 2;
            this.labelEncodingLevel.Text = "Level:";
            // 
            // textBoxCodecLevel
            // 
            this.textBoxCodecLevel.Location = new System.Drawing.Point(237, 19);
            this.textBoxCodecLevel.Name = "textBoxCodecLevel";
            this.textBoxCodecLevel.Size = new System.Drawing.Size(35, 20);
            this.textBoxCodecLevel.TabIndex = 2;
            // 
            // labelEncoderPreset
            // 
            this.labelEncoderPreset.AutoSize = true;
            this.labelEncoderPreset.Location = new System.Drawing.Point(6, 25);
            this.labelEncoderPreset.Name = "labelEncoderPreset";
            this.labelEncoderPreset.Size = new System.Drawing.Size(40, 13);
            this.labelEncoderPreset.TabIndex = 0;
            this.labelEncoderPreset.Text = "Preset:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // VideoSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 323);
            this.Controls.Add(this.groupBoxCodec);
            this.Controls.Add(this.groupBoxEncoding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoSettingsForm";
            this.ShowIcon = false;
            this.Text = "Video Properties";
            this.groupBoxEncoding.ResumeLayout(false);
            this.groupBoxEncoding.PerformLayout();
            this.groupBoxCodec.ResumeLayout(false);
            this.groupBoxCodec.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox1;
    }
}