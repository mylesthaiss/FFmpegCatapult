// WinFormHelpers is part of FFmpeg Catapult.

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

namespace FFmpegCatapult.Helpers
{
    class WinFormsHelper
    {       
        /// <summary>
        /// Combobox list helper.
        /// </summary>
        public class ListComboContent
        {
            private string name;
            private string value;
            private int x;

            public ListComboContent(string label, string arg)
            {
                name = label;
                value = arg;
            }

            public ListComboContent(string label, int y)
            {
                name = label;
                x = y;
            }

            public int X
            {
                get { return x; }
            }

            public string Value
            {
                get { return value; }
            }

            public string Name
            {
                get { return name; }
            }

            public override string ToString()
            {
                return name;
            }
        }

        public static ComboBox AddMultiArrayToComboBox(ComboBox comboBox, string[,] values, string selectedValue = null)
        {
            comboBox.Items.Clear();

            for (int i = 0; i < values.GetLength(0); i ++)
            {
                comboBox.Items.Add(new ListComboContent(values[i, 0], values[i, 1]));
            }

            if (selectedValue != null)
            {
                int x = 0;

                for (int i = 0; i < values.GetLength(0); i++)
                {
                    if (selectedValue == values[i, 1])
                    {
                        x = i;
                        break;
                    }
                }

                comboBox.SelectedIndex = x;
            }

            return comboBox;
        }

        public static ComboBox AddArrayToComboBox(ComboBox comboBox, double[] values, double selectedValue = 0)
        {
            comboBox.Items.Clear();

            for (int i = 0; i < values.GetLength(0); i++)
            {
                comboBox.Items.Add(string.Format("{0:0.0}", values[i]));
            }

            if (selectedValue != 0)
            {
                int x = 0;

                for (int i = 0; i < values.GetLength(0); i++)
                {
                    if (selectedValue == values[i])
                    {
                        x = i;
                        break;
                    }
                }

                comboBox.SelectedIndex = x;
            }

            return comboBox;
        }

        public static ComboBox AddIntArrayToComboBox(ComboBox comboBox, int[] values, int selectedValue = 0)
        {
            comboBox.Items.Clear();

            for (int i = 0; i < values.GetLength(0); i++)
            {
                comboBox.Items.Add(Convert.ToString(values[i]));
            }

            if (selectedValue != 0)
            {
                int x = 0;

                for (int i = 0; i < values.GetLength(0); i++)
                {
                    if (selectedValue == values[i])
                    {
                        x = i;
                        break;
                    }
                }

                comboBox.SelectedIndex = x;
            }

            return comboBox;
        }

        public static ComboBox AddArrayToComboBox(ComboBox comboBox, int[] values, string unit, int selectedValue = 0)
        {
            comboBox.Items.Clear();

            for (int i = 0; i < values.GetLength(0); i++)
            {
                comboBox.Items.Add(new ListComboContent(string.Format("{0} {1}", values[i], unit), values[i]));
            }

            if (selectedValue != 0)
            {
                int x = 0;

                for (int i = 0; i < values.GetLength(0); i++)
                {
                    if (selectedValue == values[i])
                    {
                        x = i;
                        break;
                    }
                }

                comboBox.SelectedIndex = x;
            }

            return comboBox;
        }

        public static string GetSelectedValueFromArrayComboBox(ComboBox comboBox)
        {
            ListComboContent item = (ListComboContent)comboBox.SelectedItem;
            return item.Value;
        }
    }
}
