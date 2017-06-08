/* -----------------------------------------------------------------------
# File    : MainWindow.Designer.cs
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
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace YAT
{
    partial class MainWindow
    {
        private IContainer m_Components = null;
        private ComponentResourceManager m_CRManager = null;
        private TableLayoutPanel m_CTableLPanel = null;
        private MenuStrip m_MenuStrip = null;
        private ComboBox m_FComboBox = null;
        private ComboBox m_TComboBox = null;
        private Button m_HButton = null;
        private Button m_SButton = null;
        private Button m_TButton = null;
        private RichTextBox m_FRichTextBox = null;
        private RichTextBox m_TRichTextBox = null;
        private Label m_FLabel = null;
        private Label m_TLabel = null;
        private Label m_FLName = null;
        private Label m_TLName = null;
        private StatusStrip m_StatusStrip = null;
        private ToolStripComboBox m_TSCBPref = null;
        private ToolTip m_THTip = null;
        private ToolTip m_TSTip = null;
        private ToolTip m_TTTip = null;

        // RichTextBox <RTBContextMenuStrip>
        private RTBContextMenuStrip m_FRTBContextMenu = null;
        private RTBContextMenuStrip m_TRTBContextMenu = null;

        // MenuStrip <ToolStripMenuItem>
        private ToolStripMenuItem m_TSMIFile = null;
        private ToolStripMenuItem m_TSMISettings = null;
        private ToolStripMenuItem m_TSMIHelp = null;
        private ToolStripMenuItem m_TSMIGetKey = null;
        private ToolStripMenuItem m_TSMIEnFKey = null;
        private ToolStripMenuItem m_TSMIEnTKey = null;
        private ToolStripMenuItem m_TSMIRefresh = null;
        private ToolStripMenuItem m_TSMIQuit = null;
        private ToolStripMenuItem m_TSMILang = null;
        private ToolStripMenuItem m_TSMIPref = null;
        private ToolStripMenuItem m_TSMIContent = null;
        private ToolStripMenuItem m_TSMIAbout = null;
        private ToolStripMenuItem m_TSMISystem = null;
        private ToolStripMenuItem m_TSMINoDef = null;
        private ToolStripMenuItem m_TSMISave = null;
        private ToolStripMenuItem m_TSMISaveOn = null;
        private ToolStripMenuItem m_TSMIAuto = null;
        private ToolStripMenuItem m_TSMIAutoOn = null;

        // StatusStrip <ToolStripStatusLabel>
        private ToolStripStatusLabel m_TSSLabel = null;

        // Timer
        private System.Windows.Forms.Timer m_STimer = null;

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
            this.m_CRManager = new ComponentResourceManager(typeof(MainWindow));
            this.m_CTableLPanel = new TableLayoutPanel();
            this.m_MenuStrip = new MenuStrip();
            this.m_FComboBox = new ComboBox();
            this.m_TComboBox = new ComboBox();
            this.m_HButton = new Button();
            this.m_SButton = new Button();
            this.m_TButton = new Button();
            this.m_FRichTextBox = new RichTextBox();
            this.m_TRichTextBox = new RichTextBox();
            this.m_FLabel = new Label();
            this.m_TLabel = new Label();
            this.m_FLName = new Label();
            this.m_TLName = new Label();
            this.m_StatusStrip = new StatusStrip();
            this.m_TSSLabel = new ToolStripStatusLabel();
            this.m_STimer = new System.Windows.Forms.Timer();
            this.m_THTip = new ToolTip();
            this.m_TSTip = new ToolTip();
            this.m_TTTip = new ToolTip();

            // Suspended
            this.m_CTableLPanel.SuspendLayout();
            this.m_MenuStrip.SuspendLayout();
            this.m_StatusStrip.SuspendLayout();
            this.SuspendLayout();

            // TableLayoutPanel <Central>
            this.m_CTableLPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.m_CTableLPanel.Dock = DockStyle.Fill;
            this.m_CTableLPanel.Name = "C-TablePanelLayout";
            this.m_CTableLPanel.TabIndex = 0;
            this.m_CTableLPanel.ColumnCount = 5;
            this.m_CTableLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            this.m_CTableLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.m_CTableLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            this.m_CTableLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            this.m_CTableLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            this.m_CTableLPanel.RowCount = 8;
            this.m_CTableLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            this.m_CTableLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.m_CTableLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.m_CTableLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.m_CTableLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.m_CTableLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.m_CTableLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.m_CTableLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.m_CTableLPanel.Controls.Add(this.m_MenuStrip, 0, 0);
            this.m_CTableLPanel.Controls.Add(this.m_FLName, 0, 1);
            this.m_CTableLPanel.Controls.Add(this.m_FComboBox, 1, 1);
            this.m_CTableLPanel.Controls.Add(this.m_TLName, 0, 2);
            this.m_CTableLPanel.Controls.Add(this.m_TComboBox, 1, 2);
            this.m_CTableLPanel.Controls.Add(this.m_HButton, 2, 1);
            this.m_CTableLPanel.Controls.Add(this.m_SButton, 3, 1);
            this.m_CTableLPanel.Controls.Add(this.m_TButton, 4, 1);
            this.m_CTableLPanel.Controls.Add(this.m_FLabel, 0, 3);
            this.m_CTableLPanel.Controls.Add(this.m_FRichTextBox, 0, 4);
            this.m_CTableLPanel.Controls.Add(this.m_TLabel, 0, 5);
            this.m_CTableLPanel.Controls.Add(this.m_TRichTextBox, 0, 6);
            this.m_CTableLPanel.Controls.Add(this.m_StatusStrip, 0, 7);
            this.m_CTableLPanel.SetColumnSpan(this.m_MenuStrip, 5);
            this.m_CTableLPanel.SetColumnSpan(this.m_FLabel, 5);
            this.m_CTableLPanel.SetColumnSpan(this.m_FRichTextBox, 5);
            this.m_CTableLPanel.SetColumnSpan(this.m_TLabel, 5);
            this.m_CTableLPanel.SetColumnSpan(this.m_TRichTextBox, 5);
            this.m_CTableLPanel.SetColumnSpan(this.m_StatusStrip, 5);
            this.m_CTableLPanel.SetRowSpan(this.m_HButton, 2);
            this.m_CTableLPanel.SetRowSpan(this.m_SButton, 2);
            this.m_CTableLPanel.SetRowSpan(this.m_TButton, 2);

            // MenuStrip
            this.m_MenuStrip.Name = "G-MenuStrip";
            this.m_MenuStrip.TabIndex = 1;
            this.p_InitializeMenu();

            // ComboBox <From>
            this.m_FComboBox.Anchor = AnchorStyles.None;
            this.m_FComboBox.Dock = DockStyle.Fill;
            this.m_FComboBox.FormattingEnabled = false;
            this.m_FComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.m_FComboBox.Sorted = true;
            this.m_FComboBox.Name = "F-ComboBox";
            this.m_FComboBox.TabIndex = 2;
            this.m_FComboBox.Click += new EventHandler(this.M_ComboBox_Click);

            // ComboBox <To>
            this.m_TComboBox.Anchor = AnchorStyles.None;
            this.m_TComboBox.Dock = DockStyle.Fill;
            this.m_TComboBox.FormattingEnabled = false;
            this.m_TComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.m_TComboBox.Sorted = true;
            this.m_TComboBox.Name = "T-ComboBox";
            this.m_TComboBox.TabIndex = 3;
            this.m_TComboBox.Click += new EventHandler(this.M_ComboBox_Click);
            this.m_TComboBox.SelectedIndexChanged +=
                new EventHandler(this.M_TComboBox_SelectedIndexChanged);

            // Button <Hold>
            this.m_HButton.Anchor = AnchorStyles.None;
            this.m_HButton.UseVisualStyleBackColor = true;
            this.m_HButton.Name = "H-Button";
            this.m_HButton.Image = Pixmaps.HoldD;
            this.m_HButton.Size = new Size(30, 45);
            this.m_HButton.TabIndex = 4;
            this.m_HButton.Click += new EventHandler(this.M_HButton_Click);

            // Button <Switching>
            this.m_SButton.Anchor = AnchorStyles.None;
            this.m_SButton.UseVisualStyleBackColor = true;
            this.m_SButton.Name = "S-Button";
            this.m_SButton.Image = Pixmaps.Switch;
            this.m_SButton.Size = new Size(45, 45);
            this.m_SButton.TabIndex = 4;
            this.m_SButton.Click += new EventHandler(this.M_SButton_Click);

            // Button <Translate>
            this.m_TButton.Anchor = AnchorStyles.None;
            this.m_TButton.UseVisualStyleBackColor = true;
            this.m_TButton.Name = "T-Button";
            this.m_TButton.Image = Pixmaps.Translate;
            this.m_TButton.Size = new Size(45, 45);
            this.m_TButton.TabIndex = 4;
            this.m_TButton.Click += new EventHandler(this.M_TButton_Click);

            // ToolTip <Hold>
            this.m_THTip.SetToolTip(this.m_HButton, ToolTipHelper.Hold);

            // ToolTip <Switching>
            this.m_TSTip.SetToolTip(this.m_SButton, ToolTipHelper.Switch);

            // ToolTip <Translate>
            this.m_TTTip.SetToolTip(this.m_TButton, ToolTipHelper.Translate);

            // Label <From>
            this.m_FLabel.AutoSize = true;
            this.m_FLabel.Dock = DockStyle.Fill;
            this.m_FLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.m_FLabel.Font = new Font(this.m_FLabel.Font, FontStyle.Bold);
            this.m_FLabel.Name = "F-Label";
            this.m_FLabel.TabIndex = 5;

            // Label <To>
            this.m_TLabel.AutoSize = true;
            this.m_TLabel.Dock = DockStyle.Fill;
            this.m_TLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.m_TLabel.Font = new Font(this.m_TLabel.Font, FontStyle.Bold);
            this.m_TLabel.Name = "T-Label";
            this.m_TLabel.TabIndex = 6;

            // Label <From name>
            this.m_FLName.AutoSize = true;
            this.m_FLName.Dock = DockStyle.Fill;
            this.m_FLName.TextAlign = ContentAlignment.MiddleCenter;
            this.m_FLName.Name = "F-LName";
            this.m_FLName.TabIndex = 5;

            // Label <To name>
            this.m_TLName.AutoSize = true;
            this.m_TLName.Dock = DockStyle.Fill;
            this.m_TLName.TextAlign = ContentAlignment.MiddleCenter;
            this.m_TLName.Name = "T-LName";
            this.m_TLName.TabIndex = 6;

            // RichTextBox <From>
            this.m_FRichTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left |
                AnchorStyles.Right | AnchorStyles.Top;
            this.m_FRichTextBox.Name = "F-RichTextBox";
            this.m_FRichTextBox.TabIndex = 7;
            this.m_FRichTextBox.TextChanged += new EventHandler(this.M_FRichTextBox_TextChanged);

            // RTBContextMenuStrip <From>
            this.m_FRTBContextMenu = new RTBContextMenuStrip(this.m_FRichTextBox);
            this.m_FRichTextBox.ContextMenuStrip = this.m_FRTBContextMenu;

            // RichTextBox <To>
            this.m_TRichTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left |
                AnchorStyles.Right | AnchorStyles.Top;
            this.m_TRichTextBox.ReadOnly = true;
            this.m_TRichTextBox.Name = "T-RichTextBox";
            this.m_TRichTextBox.TabIndex = 8;

            // RTBContextMenuStrip <To>
            this.m_TRTBContextMenu = new RTBContextMenuStrip(this.m_TRichTextBox);
            this.m_TRichTextBox.ContextMenuStrip = this.m_TRTBContextMenu;

            // StatusStrip
            this.m_StatusStrip.Name = "G-StatusStrip";
            this.m_StatusStrip.Items.Add(this.m_TSSLabel);
            this.m_StatusStrip.TabIndex = 9;

            // MainWindow
            this.Icon = Icon.FromHandle(Pixmaps.Icon.GetHicon());
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MinimumSize = new Size(380, 540);
            this.Name = "MainWindow";
            this.Text = "YAT";
            this.Controls.Add(this.m_CTableLPanel);

            // ComponentResourceManager
            this.p_UpdateInterfaceLang();

            // Resume
            this.m_CTableLPanel.ResumeLayout(false);
            this.m_CTableLPanel.PerformLayout();
            this.m_MenuStrip.ResumeLayout(false);
            this.m_MenuStrip.PerformLayout();
            this.m_StatusStrip.ResumeLayout(false);
            this.m_StatusStrip.PerformLayout();
            this.ResumeLayout(false);

            // Timer
            this.m_STimer.Interval = 3000;
            this.m_STimer.Tick += new EventHandler(M_STimer_Tick);

            // Initialize
            this.p_Initialize();

            // MainWindow <Configure>
            string ps = this.m_RegConfig.GetPositiionAndSize();
            Rectangle r = Util.StringToRectangle(ps);
            if (!r.IsEmpty)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.DesktopLocation = new Point(r.X, r.Y);
                this.Size = new Size(r.Width, r.Height);
                this.m_TSMISave.Checked = true;
            }
            else
            {
                this.StartPosition = 
                    FormStartPosition.CenterScreen;
                this.Size = new Size(480, 640);
            }

            // Bool
            bool on = false;

            // Enable auto detect
            on = this.m_RegConfig.GetAutoDetect();
            this.m_TSMIAuto.Checked = on;
            this.m_TSMIAutoOn.Enabled = on;

            // Enable auto switch
            on = this.m_RegConfig.GetAutoSwitch();
            this.m_TSMIAutoOn.Checked = on;

            // Last language
            this.m_TSMISaveOn.Checked = this.m_RegConfig.GetSaveOn();
        }
        // Private methods
        private void p_InitializeMenu()
        {
            // ToolStripMenuItem <Initialize objects>
            this.m_TSMIFile = new ToolStripMenuItem();
            this.m_TSMISettings = new ToolStripMenuItem();
            this.m_TSMIHelp = new ToolStripMenuItem();

            // ToolStripMenuItem <File>
            this.m_TSMIFile.Name = "TSMI-File";
            this.m_MenuStrip.Items.Add(this.m_TSMIFile);

            // ToolStripMenuItem <Settings>
            this.m_TSMISettings.Name = "TSMI-Settings";
            this.m_MenuStrip.Items.Add(this.m_TSMISettings);

            // ToolStripMenuItem <Help>
            this.m_TSMIHelp.Name = "TSMI-Help";
            this.m_MenuStrip.Items.Add(this.m_TSMIHelp);

            // ToolStripMenuItem <Initialize objects>
            this.m_TSMIGetKey = new ToolStripMenuItem();
            this.m_TSMIEnFKey = new ToolStripMenuItem();
            this.m_TSMIEnTKey = new ToolStripMenuItem();
            this.m_TSMIRefresh = new ToolStripMenuItem();
            this.m_TSMIQuit = new ToolStripMenuItem();
            this.m_TSMILang = new ToolStripMenuItem();
            this.m_TSMIPref = new ToolStripMenuItem();
            this.m_TSMIContent = new ToolStripMenuItem();
            this.m_TSMIAbout = new ToolStripMenuItem();
            this.m_TSMISave = new ToolStripMenuItem();
            this.m_TSMISaveOn = new ToolStripMenuItem();
            this.m_TSMIAuto = new ToolStripMenuItem();
            this.m_TSMIAutoOn = new ToolStripMenuItem();

            // ToolStripMenuItem <Get API key>
            this.m_TSMIGetKey.Name = "TSMI-GetKey";
            this.m_TSMIGetKey.Click += new EventHandler(this.M_TSMIGetKey_Click);
            this.m_TSMIFile.DropDownItems.Add(this.m_TSMIGetKey);

            // ToolStripMenuItem <Enter API key from file>
            this.m_TSMIEnFKey.Name = "TSMI-EnFKey";
            this.m_TSMIEnFKey.Click += new EventHandler(this.M_TSMIEnFKey_Click);
            this.m_TSMIFile.DropDownItems.Add(this.m_TSMIEnFKey);

            // ToolStripMenuItem <Enter API key from text>
            this.m_TSMIEnTKey.Name = "TSMI-EnTKey";
            this.m_TSMIEnTKey.Click += new EventHandler(this.M_TSMIEnTKey_Click);
            this.m_TSMIFile.DropDownItems.Add(this.m_TSMIEnTKey);

            // ToolStripSeparator
            this.m_TSMIFile.DropDownItems.Add(new ToolStripSeparator());

            // ToolStripMenuItem <Refresh list languages>
            this.m_TSMIRefresh.Name = "TSMI-Refresh";
            this.m_TSMIRefresh.Click += new EventHandler(this.M_TSMIRefresh_Click);
            this.m_TSMIFile.DropDownItems.Add(this.m_TSMIRefresh);

            // ToolStripSeparator
            this.m_TSMIFile.DropDownItems.Add(new ToolStripSeparator());

            // ToolStripMenuItem <Quit>
            this.m_TSMIQuit.Name = "TSMI-Quit";
            this.m_TSMIQuit.Click += new EventHandler(this.M_TSMIQuit_Click);
            this.m_TSMIFile.DropDownItems.Add(this.m_TSMIQuit);

            // ToolStripMenuItem <Language>
            this.m_TSMILang.Name = "TSMI-Lang";
            this.m_TSMISettings.DropDownItems.Add(this.m_TSMILang);
            this.p_LanguageMenu();

            // ToolStripSeparator
            this.m_TSMISettings.DropDownItems.Add(new ToolStripSeparator());

            // ToolStripMenuItem <Language preferred>
            this.m_TSMIPref.Name = "TSMI-Pref";
            this.m_TSMISettings.DropDownItems.Add(this.m_TSMIPref);
            this.p_PreferredMenu();

            // ToolStripSeparator
            this.m_TSMISettings.DropDownItems.Add(new ToolStripSeparator());

            // ToolStripMenuItem <Enable automatically detect language>
            this.m_TSMIAuto.CheckOnClick = true;
            this.m_TSMIAuto.Name = "TSMI-Auto";
            this.m_TSMIAuto.Click += new EventHandler(this.M_TSMIAuto_Click);
            this.m_TSMISettings.DropDownItems.Add(this.m_TSMIAuto);

            // ToolStripMenuItem <Enable automatic language switching>
            this.m_TSMIAutoOn.CheckOnClick = true;
            this.m_TSMIAutoOn.Name = "TSMI-AutoOn";
            this.m_TSMIAutoOn.Click += new EventHandler(this.M_TSMIAutoOn_Click);
            this.m_TSMISettings.DropDownItems.Add(this.m_TSMIAutoOn);

            // ToolStripMenuItem <Save position and size>
            this.m_TSMISave.CheckOnClick = true;
            this.m_TSMISave.Name = "TSMI-Save";
            this.m_TSMISave.Click += new EventHandler(this.M_TSMISave_Click);
            this.m_TSMISettings.DropDownItems.Add(this.m_TSMISave);

            // ToolStripMenuItem <Save last selected language>
            this.m_TSMISaveOn.CheckOnClick = true;
            this.m_TSMISaveOn.Name = "TSMI-SaveOn";
            this.m_TSMISaveOn.Click += new EventHandler(this.M_TSMISaveOn_Click);
            this.m_TSMISettings.DropDownItems.Add(this.m_TSMISaveOn);

            // ToolStripMenuItem <Content>
            this.m_TSMIContent.Name = "TSMI-Content";
            this.m_TSMIContent.Click += new EventHandler(this.M_TSMIContent_Click);
            this.m_TSMIHelp.DropDownItems.Add(this.m_TSMIContent);

            // ToolStripMenuItem <About>
            this.m_TSMIAbout.Name = "TSMI-About";
            this.m_TSMIAbout.Click += new EventHandler(this.M_TSMIAbout_Click);
            this.m_TSMIHelp.DropDownItems.Add(this.m_TSMIAbout);
        }
        private void p_LanguageMenu()
        {
            // System language
            this.m_TSMISystem = new ToolStripRadioButtonMenuItem();
            this.m_TSMISystem.Name = "TSMI-System";
            this.m_TSMISystem.Click += new EventHandler(this.M_TSMISystem_Click);
            this.m_TSMILang.DropDownItems.Add(this.m_TSMISystem);

            // ToolStripSeparator
            this.m_TSMILang.DropDownItems.Add(new ToolStripSeparator());

            // Add other language
            ToolStripRadioButtonMenuItem tsmi = null;
            tsmi = new ToolStripRadioButtonMenuItem("English");
            tsmi.Name = "en";
            tsmi.Click += new EventHandler(this.M_tsmi_Click);
            this.m_TSMILang.DropDownItems.Add(tsmi);
            tsmi = new ToolStripRadioButtonMenuItem("Русский");
            tsmi.Name = "ru";
            tsmi.Click += new EventHandler(this.M_tsmi_Click);
            this.m_TSMILang.DropDownItems.Add(tsmi);
        }
        private void p_PreferredMenu()
        {
            // No defined
            this.m_TSMINoDef = new ToolStripMenuItem();
            this.m_TSMINoDef.CheckOnClick = true;
            this.m_TSMINoDef.Name = "TSMI-NoDef";
            this.m_TSMINoDef.Click += new EventHandler(this.M_TSMINoDef_Click);
            this.m_TSMIPref.DropDownItems.Add(this.m_TSMINoDef);

            // ToolStripSeparator
            this.m_TSMIPref.DropDownItems.Add(new ToolStripSeparator());

            // ComboBox <Language>
            this.m_TSCBPref = new ToolStripComboBox();
            this.m_TSCBPref.Width = this.m_TSMIPref.Width;
            this.m_TSCBPref.DropDownStyle = ComboBoxStyle.DropDownList;
            this.m_TSCBPref.Sorted = true;
            this.m_TSCBPref.Enabled = false;
            this.m_TSCBPref.Name = "TSCB-Pref";
            this.m_TSCBPref.SelectedIndexChanged += 
                new EventHandler(this.M_TSCBPref_SelectedIndexChanged);
            this.m_TSMIPref.DropDownItems.Add(this.m_TSCBPref);
        }
        private void p_UpdateInterfaceLang()
        {
            // ComponentResourceManager
            //this.m_CRManager.ApplyResources(this.m_HButton, "H-Button");
            //this.m_CRManager.ApplyResources(this.m_SButton, "S-Button");
            //this.m_CRManager.ApplyResources(this.m_TButton, "T-Button");
            this.m_CRManager.ApplyResources(this.m_FLabel, "F-Label");
            this.m_CRManager.ApplyResources(this.m_TLabel, "T-Label");
            this.m_CRManager.ApplyResources(this.m_FLName, "F-LName");
            this.m_CRManager.ApplyResources(this.m_TLName, "T-LName");
            this.m_CRManager.ApplyResources(this.m_TSMIFile, "TSMI-File");
            this.m_CRManager.ApplyResources(this.m_TSMIGetKey, "TSMI-GetKey");
            this.m_CRManager.ApplyResources(this.m_TSMIEnFKey, "TSMI-EnFKey");
            this.m_CRManager.ApplyResources(this.m_TSMIEnTKey, "TSMI-EnTKey");
            this.m_CRManager.ApplyResources(this.m_TSMIRefresh, "TSMI-Refresh");
            this.m_CRManager.ApplyResources(this.m_TSMIQuit, "TSMI-Quit");
            this.m_CRManager.ApplyResources(this.m_TSMISettings, "TSMI-Settings");
            this.m_CRManager.ApplyResources(this.m_TSMILang, "TSMI-Lang");
            this.m_CRManager.ApplyResources(this.m_TSMIPref, "TSMI-Pref");
            this.m_CRManager.ApplyResources(this.m_TSMIAuto, "TSMI-Auto");
            this.m_CRManager.ApplyResources(this.m_TSMIAutoOn, "TSMI-AutoOn");
            this.m_CRManager.ApplyResources(this.m_TSMISave, "TSMI-Save");
            this.m_CRManager.ApplyResources(this.m_TSMISaveOn, "TSMI-SaveOn");
            this.m_CRManager.ApplyResources(this.m_TSMIHelp, "TSMI-Help");
            this.m_CRManager.ApplyResources(this.m_TSMIContent, "TSMI-Content");
            this.m_CRManager.ApplyResources(this.m_TSMIAbout, "TSMI-About");
            this.m_CRManager.ApplyResources(this.m_TSMISystem, "TSMI-System");
            this.m_CRManager.ApplyResources(this.m_TSMINoDef, "TSMI-NoDef");
            // ToolTip <Updates>
            this.m_THTip.SetToolTip(this.m_HButton, ToolTipHelper.Hold);
            this.m_TSTip.SetToolTip(this.m_SButton, ToolTipHelper.Switch);
            this.m_TTTip.SetToolTip(this.m_TButton, ToolTipHelper.Translate);
        }
        private void p_Initialize()
        {
            // Disabled
            this.m_TSMIRefresh.Enabled = false;
            this.m_TSMILang.Enabled = false;
            this.m_TSMIPref.Enabled = false;
            this.m_FComboBox.Enabled = false;
            this.m_TComboBox.Enabled = false;
            this.m_FRichTextBox.Enabled = false;
            this.m_TRichTextBox.Enabled = false;
            this.m_TButton.Enabled = false;
            this.m_SButton.Enabled = false;
            this.m_HButton.Enabled = false;
        }
        private void p_Enabled()
        {
            // Enabled
            this.m_TSMIRefresh.Enabled = true;
            this.m_TSMILang.Enabled = true;
            this.m_TSMIPref.Enabled = true;
            this.m_FComboBox.Enabled = true;
            this.m_TComboBox.Enabled = true;
            this.m_FRichTextBox.Enabled = true;
            this.m_TRichTextBox.Enabled = true;
            this.m_TButton.Enabled = true;
            this.m_SButton.Enabled = true;
            this.m_HButton.Enabled = true;
        }
        private void p_ErrorReason(int code, bool var = false)
        {
            switch (code)
            {
                case (int)APIResult.TRANSLATE_BAD_KEY:
                    this.SetStatusText(Errors.EReason);
                    return;
                case (int)APIResult.TRANSLATE_BLOCK_KEY:
                    this.SetStatusText(Errors.FReason);
                    return;
                case (int)APIResult.TRANSLATE_MAX_COUNT:
                    this.SetStatusText(Errors.HReason);
                    return;
                case (int)APIResult.TRANSLATE_MAX_REQUEST:
                    this.SetStatusText(Errors.IReason);
                    return;
                case (int)APIResult.TRANSLATE_MAX_SIZE:
                    this.SetStatusText(Errors.JReason);
                    return;
                case (int)APIResult.TRANSLATE_NOT_COULD:
                    this.SetStatusText(Errors.KReason);
                    return;
                case (int)APIResult.TRANSLATE_NOT_SUPPORT:
                    this.SetStatusText(Errors.LReason);
                    return;
                default:
                    break;
            }
            this.SetStatusText(var ?
                Errors.MReason : Errors.NReason);
        }
        private void p_SetSelectedItem(string name, ComboBox comboBox)
        {
            foreach (ToolStripLabel tsl in comboBox.Items)
            {
                if (tsl.Name == name)
                {
                    comboBox.SelectedItem = tsl;
                }
            }
        }
        private void p_HoldLang()
        {
            // Button <Hold>
            this.m_HButton.Image = Pixmaps.HoldE;

            // Setup languages
            string ft = this.m_RegConfig.GetHoldLangs();
            string[] sp = ft.Split(':');
            if (sp.Count<string>() == 2)
            {
                this.p_SetSelectedItem(sp[0], this.m_FComboBox);
                this.p_SetSelectedItem(sp[1], this.m_TComboBox);
            }

            // ComboBox
            this.m_FComboBox.Enabled = false;
            this.m_TComboBox.Enabled = false;
        }
        // Public methods
        public void SetLanguageList(XMLRLData data)
        {
            if (data.IsNull())
            {
                switch (data.GetCode())
                {
                    case (int)APIError.GETLANGS_BAD_KEY:
                        this.SetStatusText(Errors.EReason);
                        break;
                    case (int)APIError.GETLANGS_BLOCK_KEY:
                        this.SetStatusText(Errors.FReason);
                        break;
                    default:
                        this.SetStatusText(Errors.GReason);
                        break;
                }
                return;
            }
            this.m_FComboBox.Items.Clear();
            this.m_TComboBox.Items.Clear();
            foreach (KeyValuePair<string, string> kv in data.GetList())
            {
                // Initialize object
                ToolStripLabel tsl = new ToolStripLabel(kv.Value);

                // ToolStripLabel
                tsl.Name = kv.Key;

                // ComboBox
                this.m_FComboBox.Items.Add(tsl);
                this.m_TComboBox.Items.Add(tsl);

            }
            this.p_Enabled();

            // Hold languages
            bool on = this.m_RegConfig.GetHoldLang();
            if (!on)
            {
                string lang = "";

                // Preffered language translation or <System> CurrentUICulture
                lang = this.m_RegConfig.GetPrefLang();
                if (lang == "")
                {
                    lang = Thread.CurrentThread.CurrentUICulture.Name;
                    lang = Util.GetNormalizeLang(lang);
                }

                // ComboBox <From>
                this.p_SetSelectedItem(lang, this.m_FComboBox);

                // Save last language
                lang = this.m_RegConfig.GetLastLang();
                if (lang == "")
                {
                    this.m_TComboBox.SelectedIndex = 0;
                    return;
                }

                // ComboBox <To>
                this.p_SetSelectedItem(lang, this.m_TComboBox);
            }
            else
            {
                this.p_HoldLang();
            }
        }
        public void SetPMLanguageList(XMLRLData data)
        {
            if (data.IsNull())
            {
                return;
            }
            this.m_TSCBPref.Items.Clear();
            foreach (KeyValuePair<string, string> kv in data.GetList())
            {
                // Initialize object
                ToolStripLabel tsl = new ToolStripLabel(kv.Value);

                // ToolStripLabel
                tsl.Name = kv.Key;

                // ToolStripComboBox
                this.m_TSCBPref.Items.Add(tsl);
            }

            // Enabled
            string lang = this.m_RegConfig.GetPrefLang();
            if (lang == "")
            {
                this.m_TSMINoDef.Checked = true;
                this.m_TSCBPref.SelectedIndex = 0;
                return;
            }
            this.p_SetSelectedItem(lang, this.m_TSCBPref.ComboBox);
            this.m_TSCBPref.Enabled = true;
        }
        public void SetTranslatedText(XMLTTData data)
        {
            if (data.IsEmpty())
            {
                this.p_ErrorReason(data.GetCode(), true);
                return;
            }
            this.m_TRichTextBox.Text = data.GetText();
        }
        public void SetAutoDetect(XMLDLData data)
        {
            if (data.IsEmpty())
            {
                this.p_ErrorReason(data.GetCode());
                return;
            }
            string ft = ((ToolStripLabel)this.m_FComboBox.SelectedItem).Name;
            if (ft != data.GetLang())
            {
                this.p_SetSelectedItem(data.GetLang(), this.m_FComboBox);
                string tt = ((ToolStripLabel)this.m_TComboBox.SelectedItem).Name;
                if (this.m_TSMIAutoOn.Checked || data.GetLang() == tt)
                {
                    this.p_SetSelectedItem(ft, this.m_TComboBox);
                }
            }
        }
        public void SetStatusText(string text)
        {
            this.m_STimer.Stop();
            this.m_TSSLabel.Text = text;
            this.m_STimer.Start();
        }
        public void SetMenuLang(string lang, bool regLang)
        {
            if (regLang)
            {
                foreach (object obj in this.m_TSMILang.DropDownItems)
                {
                    ToolStripRadioButtonMenuItem item =
                        obj as ToolStripRadioButtonMenuItem;
                    if (item != null && item.Name == lang)
                    {
                        item.Checked = true;
                        return;
                    }
                }
            }
            this.m_TSMISystem.Checked = true;
        }
        public void UpdateInterface()
        {
            this.m_FRTBContextMenu.UpdateInterface();
            this.m_TRTBContextMenu.UpdateInterface();
            this.p_UpdateInterfaceLang();
        }
        public void DisableElements()
        {
            this.p_Initialize();
        }
    }
}

