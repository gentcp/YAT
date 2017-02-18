/* -----------------------------------------------------------------------
# File    : Error.cs
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
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YAT
{
    public partial class Error : Form
    {
        public Error()
        {
            this.InitializeComponent();
        }
        // Private EventHandler methods
        private void M_CButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Public methods
        public void SetReason(string reason)
        {
            this.m_RLabel.Text = reason;
        }
        // Static public methods
        static public void Reason(string reason)
        {
            Error dlg = new YAT.Error();
            dlg.SetReason(reason);
            dlg.ShowDialog();
        }
    }
}
