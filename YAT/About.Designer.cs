/* -----------------------------------------------------------------------
# File    : About.Designer.cs
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
    partial class About
    {
        private IContainer m_Components = null;
        private ComponentResourceManager m_CRManager = null;
        private TableLayoutPanel m_CTableLPanel = null;
        private TableLayoutPanel m_TTableLPanel = null;
        private RichTextBox m_LRichTextBox = null;
        private TabControl m_TabControl = null;
        private Button m_CButton = null;
        private PictureBox m_PictureBox = null;
        private LinkLabel m_LinkLabel = null;

        // TabPage
        private TabPage m_ATabPage = null;
        private TabPage m_LTabPage = null;

        // Label
        private Label m_NLabel = null;
        private Label m_DLabel = null;
        private Label m_ALabel = null;
        private Label m_CLabel = null;

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
            this.m_CRManager = new ComponentResourceManager(typeof(About));
            this.m_CTableLPanel = new TableLayoutPanel();
            this.m_TTableLPanel = new TableLayoutPanel();
            this.m_LRichTextBox = new RichTextBox();
            this.m_TabControl = new TabControl();
            this.m_CButton = new Button();
            this.m_PictureBox = new PictureBox();
            this.m_LinkLabel = new LinkLabel();
            this.m_NLabel = new Label();
            this.m_DLabel = new Label();
            this.m_ALabel = new Label();
            this.m_CLabel = new Label();

            // Suspended
            this.m_CTableLPanel.SuspendLayout();
            this.m_TTableLPanel.SuspendLayout();
            this.m_TabControl.SuspendLayout();
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
            this.m_CTableLPanel.Controls.Add(this.m_TabControl, 0, 0);
            this.m_CTableLPanel.Controls.Add(this.m_CButton,    0, 1);

            // TableLayoutPanel <Tab>
            this.m_TTableLPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.m_TTableLPanel.Dock = DockStyle.Fill;
            this.m_TTableLPanel.Name = "T-TableLayoutPanel";
            this.m_TTableLPanel.TabIndex = 1;
            this.m_TTableLPanel.ColumnCount = 1;
            this.m_TTableLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.m_TTableLPanel.RowCount = 6;
            this.m_TTableLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.m_TTableLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.m_TTableLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.m_TTableLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.m_TTableLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.m_TTableLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.m_TTableLPanel.Controls.Add(this.m_PictureBox, 0, 0);
            this.m_TTableLPanel.Controls.Add(this.m_NLabel,     0, 1);
            this.m_TTableLPanel.Controls.Add(this.m_DLabel,     0, 2);
            this.m_TTableLPanel.Controls.Add(this.m_ALabel,     0, 3);
            this.m_TTableLPanel.Controls.Add(this.m_CLabel,     0, 4);
            this.m_TTableLPanel.Controls.Add(this.m_LinkLabel,  0, 5);

            // RichTextBox
            this.m_LRichTextBox.Dock = DockStyle.Fill;
            this.m_LRichTextBox.ReadOnly = true;
            this.m_LRichTextBox.Name = "L-RichTextBox";
            this.m_LRichTextBox.Text = Docs.LICENSE;
            this.m_LRichTextBox.TabIndex = 2;

            // TabControl
            this.m_TabControl.Dock = DockStyle.Fill;
            this.m_TabControl.Name = "C-TabControl";
            this.m_TabControl.TabIndex = 3;
            this.p_InitializeTabs();

            // Button
            this.m_CButton.Anchor = AnchorStyles.None;
            this.m_CButton.UseVisualStyleBackColor = true;
            this.m_CButton.Name = "C-Button";
            this.m_CButton.TabIndex = 4;
            this.m_CButton.Click += new EventHandler(M_CButton_Click);

            // PictureBox
            this.m_PictureBox.Anchor = AnchorStyles.None;
            this.m_PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            this.m_PictureBox.Name = "L-PictureBox";
            this.m_PictureBox.Image = Pixmaps.Logo;

            // LinkLabel
            this.m_LinkLabel.AutoSize = true;
            this.m_LinkLabel.Dock = DockStyle.Fill;
            this.m_LinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.m_LinkLabel.Font = new Font(m_LinkLabel.Font.FontFamily,
                m_LinkLabel.Font.Size - 1, FontStyle.Regular);
            this.m_LinkLabel.Name = "U-LinkLabel";
            this.m_LinkLabel.Text = "http://www.a7x-im.com/";
            this.m_LinkLabel.TabIndex = 5;
            this.m_LinkLabel.LinkClicked += 
                new LinkLabelLinkClickedEventHandler(M_LinkLabel_Clicked);

            // Label <Name && Version>
            this.m_NLabel.AutoSize = true;
            this.m_NLabel.Dock = DockStyle.Fill;
            this.m_NLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.m_NLabel.Font = new Font(m_NLabel.Font, FontStyle.Bold);
            this.m_NLabel.Name = "N-Label";
            this.m_NLabel.Text = "YAT 1.4";
            this.m_NLabel.TabIndex = 6;

            // Label <Description>
            this.m_DLabel.AutoSize = true;
            this.m_DLabel.Dock = DockStyle.Fill;
            this.m_DLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.m_DLabel.Font = new Font(m_DLabel.Font, FontStyle.Italic);
            this.m_DLabel.Name = "D-Label";
            this.m_DLabel.TabIndex = 7;

            // Label <Author>
            this.m_ALabel.AutoSize = true;
            this.m_ALabel.Dock = DockStyle.Fill;
            this.m_ALabel.TextAlign = ContentAlignment.MiddleCenter;
            this.m_ALabel.Font = new Font(m_ALabel.Font.FontFamily,
                m_ALabel.Font.Size - 1, FontStyle.Regular);
            this.m_ALabel.Name = "A-Label";
            this.m_ALabel.TabIndex = 8;

            // Label <Copyright>
            this.m_CLabel.AutoSize = true;
            this.m_CLabel.Dock = DockStyle.Fill;
            this.m_CLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.m_CLabel.Font = new Font(m_CLabel.Font.FontFamily,
                m_CLabel.Font.Size - 1, FontStyle.Regular);
            this.m_CLabel.Name = "C-Label";
            this.m_CLabel.Text = "Copyright (C) 2017 A7X-Im.Com Team";
            this.m_CLabel.TabIndex = 9;

            // About
            this.Icon = Icon.FromHandle(Pixmaps.Icon.GetHicon());
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(320, 400);
            this.MinimumSize = new Size(280, 360);
            this.Name = "About";
            this.Controls.Add(this.m_CTableLPanel);

            // ComponentResourceManager
            this.m_CRManager.ApplyResources(this, "$this");
            this.m_CRManager.ApplyResources(this.m_ATabPage, "A-TabPage");
            this.m_CRManager.ApplyResources(this.m_LTabPage, "L-TabPage");
            this.m_CRManager.ApplyResources(this.m_CButton,  "C-Button");
            this.m_CRManager.ApplyResources(this.m_DLabel,   "D-Label");
            this.m_CRManager.ApplyResources(this.m_ALabel,   "A-Label");

            // Resume
            this.m_CTableLPanel.ResumeLayout(false);
            this.m_CTableLPanel.PerformLayout();
            this.m_TTableLPanel.ResumeLayout(false);
            this.m_TTableLPanel.PerformLayout();
            this.m_TabControl.ResumeLayout(false);
            this.m_TabControl.PerformLayout();
            this.ResumeLayout(false);
        }
        // Private methods
        private void p_InitializeTabs()
        {
            // Initialize objects
            this.m_ATabPage = new TabPage();
            this.m_LTabPage = new TabPage();

            // TabPage <About>
            this.m_ATabPage.Name = "A-TabPage";
            this.m_ATabPage.Controls.Add(this.m_TTableLPanel);
            this.m_TabControl.TabPages.Add(this.m_ATabPage);

            // TabPage <License>
            this.m_LTabPage.Name = "L-TabPage";
            this.m_LTabPage.Controls.Add(this.m_LRichTextBox);
            this.m_TabControl.TabPages.Add(this.m_LTabPage);
        }
    }
}