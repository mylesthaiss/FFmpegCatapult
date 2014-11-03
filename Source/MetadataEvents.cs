﻿// Metadata tab event handlers for FFmpeg Catapult.
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
    partial class MainForm : Form
    {
        void textBoxAlbum_TextChanged(object sender, EventArgs e)
        {
            Metadata.Album = textBoxAlbum.Text;
        }

        void textBoxAlbumArtist_TextChanged(object sender, EventArgs e)
        {
            Metadata.AlbumArtist = textBoxAlbumArtist.Text;
        }

        void textBoxArtist_TextChanged(object sender, EventArgs e)
        {
            Metadata.Artist = textBoxArtist.Text;
        }

        void textBoxComment_TextChanged(object sender, EventArgs e)
        {
            Metadata.Comment = textBoxComment.Text;
        }

        void textBoxDisc_TextChanged(object sender, EventArgs e)
        {
            Metadata.Disc = Methods.TextToInt(textBoxDisc.Text);
        }

        void textBoxGenre_TextChanged(object sender, EventArgs e)
        {
            Metadata.Genre = textBoxGenre.Text;
        }

        void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            Metadata.Title = textBoxTitle.Text;
        }

        void textBoxTotalDiscs_TextChanged(object sender, EventArgs e)
        {
            Metadata.Disc = Methods.TextToInt(textBoxDisc.Text);
        }

        void textBoxTotalTracks_TextChanged(object sender, EventArgs e)
        {
            Metadata.TotalTracks = Methods.TextToInt(textBoxTotalTracks.Text);
        }

        void textBoxTrack_TextChanged(object sender, EventArgs e)
        {
            Metadata.Track = Methods.TextToInt(textBoxTrack.Text);
        }

        void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            Metadata.Year = Methods.TextToInt(textBoxYear.Text);
        }
    }
}
