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
    public partial class AudioSettingsForm : Form
    {
        public AudioSettingsForm()
        {
            InitializeComponent();
        }

        private void AudioSettingsForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Audio.CodecProfiles.GetLength(0); i++)
            {
                comboBoxCodecProfiles.Items.Add(new ListComboContent(Audio.CodecProfiles[i, 0], Audio.CodecProfiles[i, 1]));

                if (Audio.CodecProfile == Audio.CodecProfiles[i, 1])
                {
                    comboBoxCodecProfiles.SelectedIndex = i;
                }
            }
        }

        // Combobox list helpers
        private class ListComboContent
        {
            public string Name;
            public string Value;

            public ListComboContent(string name, string value)
            {
                this.Name = name;
                this.Value = value;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        // Event handlers
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            ListComboContent codecProfile = (ListComboContent)comboBoxCodecProfiles.SelectedItem;
            Audio.CodecProfile = codecProfile.Value;
            this.Close();
        }
    }
}
