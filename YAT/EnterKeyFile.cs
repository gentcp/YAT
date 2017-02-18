/* -----------------------------------------------------------------------
# File    : EnterKeyFile.cs
# Author  : Mihailov Artem <a7x@a7x-im.com>
# Purpose : This file is part C# project developed A7X-Im.Com Team
#
# Copyright (C) 2008-2017
#
# This program is free software; you can redistribute it and/or
# modify it under the terms of the GNU General Public License as
# published by the Free Software Foundation; either version 2 of the
# License, or (at your option) any later version.
#
# This program is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
# General Public License for more details.
#
# You should have received a copy of the GNU General Public License
# along with this program; if not, write to the Free Software
# Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA
# 02111-1307 USA
#
----------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YAT
{
    public partial class EnterKeyFile : Form
    {
        public EnterKeyFile()
        {
            this.InitializeComponent();
        }
        // Private EventHandler methods
        private void M_FTextBox_TextChanged(object sender, EventArgs e)
        {
            this.m_AButton.Enabled = (this.m_FTextBox.Text.Length != 0);
        }
        private void M_FButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "C:\\";
            dlg.Multiselect = false;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.m_FTextBox.Text = dlg.FileName;
                this.m_AButton.Enabled = true;
            }
        }
        private void M_AButton_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(this.m_FTextBox.Text);
            if (!fileInfo.Exists)
            {
                Error.Reason(Errors.AReason);
                return;
            }
            try
            {
                FileStream fileStream = new FileStream(fileInfo.FullName, 
                    FileMode.Open, FileAccess.Read);
                int length = (int)fileStream.Length;
                if (length >= 100)
                {
                    Error.Reason(Errors.BReason);
                    return;
                }
                byte[] array = new byte[100];
                fileStream.Read(array, 0, length);
                fileStream.Close();
                string APIKey = Encoding.ASCII.GetString(array).Trim();
                bool valid = true;
                for (int i = 0; i < APIKey.Length; i++)
                {
                    if (APIKey[i] == 9 || APIKey[i] == 13 ||
                        APIKey[i] == 32)
                    {
                        valid = false;
                        break;
                    }
                }
                if (!valid)
                {
                    Error.Reason(Errors.CReason);
                    return;
                }
                RegConfig regConfing = new RegConfig();
                regConfing.SetAPIKey(APIKey);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (IOException except)
            {
                Error.Reason(except.Message);
            }
        }
        private void M_RButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
