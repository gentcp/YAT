/* -----------------------------------------------------------------------
# File    : Error.Designer.cs
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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace YAT
{
    partial class Error
    {
        private IContainer m_Components = null;
        private ComponentResourceManager m_CRManager = null;
        private TableLayoutPanel m_CTableLPanel = null;
        private PictureBox m_PictureBox = null;
        private Label m_RLabel = null;
        private Button m_CButton = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.m_Components != null))
            {
                this.m_Components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            // Initialize objects
            this.m_CRManager = new ComponentResourceManager(typeof(Error));
            this.m_CTableLPanel = new TableLayoutPanel();
            this.m_PictureBox = new PictureBox();
            this.m_RLabel = new Label();
            this.m_CButton = new Button();

            // Suspended
            this.m_CTableLPanel.SuspendLayout();
            this.SuspendLayout();

            // TableLayoutPanel <Central>
            this.m_CTableLPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.m_CTableLPanel.Dock = DockStyle.Fill;
            this.m_CTableLPanel.Name = "C-TableLayoutPanel";
            this.m_CTableLPanel.TabIndex = 0;
            this.m_CTableLPanel.ColumnCount = 2;
            this.m_CTableLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            this.m_CTableLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.m_CTableLPanel.RowCount = 2;
            this.m_CTableLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.m_CTableLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.m_CTableLPanel.Controls.Add(this.m_PictureBox, 0, 0);
            this.m_CTableLPanel.Controls.Add(this.m_RLabel,     1, 0);
            this.m_CTableLPanel.Controls.Add(this.m_CButton,    0, 1);
            this.m_CTableLPanel.SetColumnSpan(this.m_CButton, 2);

            // PictureBox
            this.m_PictureBox.Anchor = AnchorStyles.None;
            this.m_PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            this.m_PictureBox.Name = "E-PictureBox";
            this.m_PictureBox.Image = Pixmaps.Error;

            // Label <Reason>
            this.m_RLabel.Anchor = AnchorStyles.None;
            this.m_RLabel.AutoSize = true;
            this.m_RLabel.Dock = DockStyle.Fill;
            this.m_RLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.m_RLabel.ForeColor = Color.Red;
            this.m_RLabel.Name = "R-Label";
            this.m_RLabel.TabIndex = 1;

            // Button <Close>
            this.m_CButton.Anchor = AnchorStyles.None;
            this.m_CButton.AutoSize = true;
            this.m_CButton.UseVisualStyleBackColor = true;
            this.m_CButton.Name = "C-Button";
            this.m_CButton.TabIndex = 2;
            this.m_CButton.Click += new EventHandler(this.M_CButton_Click);

            // Error
            this.Icon = Icon.FromHandle(Pixmaps.ErrorIcon.GetHicon());
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(340, 150);
            this.MinimumSize = new Size(320, 130);
            this.Name = "Error";
            this.Controls.Add(this.m_CTableLPanel);

            // ComponentResourceManager
            this.m_CRManager.ApplyResources(this, "$this");
            this.m_CRManager.ApplyResources(this.m_CButton, "C-Button");

            // Resume
            this.m_CTableLPanel.ResumeLayout(false);
            this.m_CTableLPanel.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}