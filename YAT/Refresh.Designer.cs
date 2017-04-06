/* -----------------------------------------------------------------------
# File    : Refresh.Designer.cs
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
    partial class Refresh
    {
        private IContainer m_Components = null;
        private ComponentResourceManager m_CRManager = null;
        private TableLayoutPanel m_CTableLPanel = null;
        private TableLayoutPanel m_BTableLPanel = null;
        private Label m_DLabel = null;
        private Button m_AButton = null;
        private Button m_RButton = null;

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
            this.m_CRManager = new ComponentResourceManager(typeof(Refresh));
            this.m_CTableLPanel = new TableLayoutPanel();
            this.m_BTableLPanel = new TableLayoutPanel();
            this.m_DLabel = new Label();
            this.m_AButton = new Button();
            this.m_RButton = new Button();

            // Suspended
            this.m_CTableLPanel.SuspendLayout();
            this.m_BTableLPanel.SuspendLayout();
            this.SuspendLayout();

            // TableLayoutPanel <Central>
            this.m_CTableLPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.m_CTableLPanel.Dock = DockStyle.Fill;
            this.m_CTableLPanel.Name = "C-TableLayoutPanel";
            this.m_CTableLPanel.TabIndex = 0;
            this.m_CTableLPanel.ColumnCount = 1;
            this.m_CTableLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.m_CTableLPanel.RowCount = 2;
            this.m_CTableLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.m_CTableLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.m_CTableLPanel.Controls.Add(this.m_DLabel,       0, 0);
            this.m_CTableLPanel.Controls.Add(this.m_BTableLPanel, 0, 1);

            // TableLayoutPanel <Button>
            this.m_BTableLPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.m_BTableLPanel.Dock = DockStyle.Fill;
            this.m_BTableLPanel.Padding = new Padding(0, 0, 0, 0);
            this.m_BTableLPanel.Margin = new Padding(0, 0, 0, 0);
            this.m_BTableLPanel.Name = "B-TableLayoutPanel";
            this.m_BTableLPanel.TabIndex = 1;
            this.m_BTableLPanel.ColumnCount = 2;
            this.m_BTableLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.m_BTableLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.m_BTableLPanel.RowCount = 1;
            this.m_BTableLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.m_BTableLPanel.Controls.Add(this.m_AButton, 0, 0);
            this.m_BTableLPanel.Controls.Add(this.m_RButton, 1, 0);

            // Label <Description>
            this.m_DLabel.Anchor = AnchorStyles.None;
            this.m_DLabel.AutoSize = true;
            this.m_DLabel.Dock = DockStyle.Fill;
            this.m_DLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.m_DLabel.ForeColor = Color.Red;
            this.m_DLabel.Name = "D-Label";
            this.m_DLabel.TabIndex = 2;

            // Button <Accept>
            this.m_AButton.Anchor = AnchorStyles.Right;
            this.m_AButton.AutoSize = true;
            this.m_AButton.UseVisualStyleBackColor = true;
            this.m_AButton.Name = "A-Button";
            this.m_AButton.TabIndex = 5;
            this.m_AButton.Click += new EventHandler(this.M_AButton_Click);

            // Button <Reject>
            this.m_RButton.Anchor = AnchorStyles.Left;
            this.m_RButton.AutoSize = true;
            this.m_RButton.UseVisualStyleBackColor = true;
            this.m_RButton.Name = "R-Button";
            this.m_RButton.TabIndex = 6;
            this.m_RButton.Click += new EventHandler(this.M_RButton_Click);

            // Refresh
            this.Icon = Icon.FromHandle(Pixmaps.ErrorIcon.GetHicon());
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(340, 120);
            this.MinimumSize = new Size(320, 100);
            this.Name = "Refresh";
            this.Controls.Add(this.m_CTableLPanel);

            // ComponentResourceManager
            this.m_CRManager.ApplyResources(this, "$this");
            this.m_CRManager.ApplyResources(this.m_DLabel, "D-Label");
            this.m_CRManager.ApplyResources(this.m_AButton, "A-Button");
            this.m_CRManager.ApplyResources(this.m_RButton, "R-Button");

            // Resume
            this.m_CTableLPanel.ResumeLayout(false);
            this.m_CTableLPanel.PerformLayout();
            this.m_BTableLPanel.ResumeLayout(false);
            this.m_BTableLPanel.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}