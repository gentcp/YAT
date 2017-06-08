/* -----------------------------------------------------------------------
# File    : MainWindow.cs
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
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAT
{
    public partial class MainWindow : Form
    {
        private System.Windows.Forms.Timer m_UTimer = null;
        private System.Windows.Forms.Timer m_ATimer = null;
        private APIManager m_APIManager = null;
        private RegConfig m_RegConfig = null;

        public MainWindow()
        {
            // Initialize objects
            this.m_UTimer = new System.Windows.Forms.Timer();
            this.m_ATimer = new System.Windows.Forms.Timer();
            this.m_APIManager = new APIManager();
            this.m_RegConfig = new RegConfig();

            // Setup culture
            string lang = this.m_RegConfig.GetLang();
            bool regLang = true;
            if (lang == "")
            {
                lang = Thread.CurrentThread.CurrentUICulture.Name;
                regLang = false;
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            }

            // Initialize component
            this.InitializeComponent();

            // Menu language
            lang = Thread.CurrentThread.CurrentUICulture.Name;
            lang = Util.GetNormalizeLang(lang);
            this.SetMenuLang(lang, regLang);

            // Timer <StartUp>
            this.m_UTimer.Interval = 1000;
            this.m_UTimer.Tick += new EventHandler(this.M_UTimer_Tick);
            this.m_UTimer.Start();

            // Timer <Automatically detecting>
            this.m_ATimer.Interval = 2000;
            this.m_ATimer.Tick += new EventHandler(this.M_ATimer_Tick);
        }
        // Protected override methods
        protected override void OnHandleDestroyed(EventArgs e)
        {
            if (this.m_TSMISave.Checked)
            {
                this.p_SetPositionAndSize();
            }
            base.OnHandleDestroyed(e);
        }
        // Private EventHandler methods
        private void M_TSMIGetKey_Click(object sender, EventArgs e)
        {
            Process.Start("https://tech.yandex.ru/keys/get/?service=trnsl");
        }
        private void M_TSMIEnFKey_Click(object sender, EventArgs e)
        {
            EnterKeyFile dlg = new EnterKeyFile();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.p_UpdateLangs();
            }
        }
        private void M_TSMIEnTKey_Click(object sender, EventArgs e)
        {
            EnterKeyText dlg = new EnterKeyText();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.p_UpdateLangs();
            }
        }
        private void M_TSMIRefresh_Click(object sender, EventArgs e)
        {
            this.DisableElements();
            this.m_UTimer.Start();
        }
        private void M_TSMIQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void M_TSMISystem_Click(object sender, EventArgs e)
        {
            string lang = CultureInfo.InstalledUICulture.Name;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            this.m_RegConfig.RemoveLang();
            this.UpdateInterface();
            this.DisableElements();
            this.m_UTimer.Start();
        }
        private void M_TSMINoDef_Click(object sender, EventArgs e)
        {
            if (this.m_TSMINoDef.Checked)
            {
                this.m_RegConfig.RemovePrefLang();
                this.m_TSCBPref.Enabled = false;

                // Select CurrentUICulture
                string lang = "";
                lang = Thread.CurrentThread.CurrentUICulture.Name;
                lang = Util.GetNormalizeLang(lang);

                // Correct ComboBox <From> selected
                if (!this.m_RegConfig.GetHoldLang())
                {
                    this.p_SetSelectedItem(lang, this.m_FComboBox);
                }
            }
            else
            {
                this.m_TSCBPref.Enabled = true;
            }
        }
        private void M_TSMIAuto_Click(object sender, EventArgs e)
        {
            bool on = this.m_TSMIAuto.Checked;
            this.m_RegConfig.SetAutoDetect(on);

            // Enable or disable switching
            this.m_TSMIAutoOn.Enabled = on;
        }
        private void M_TSMIAutoOn_Click(object sender, EventArgs e)
        {
            this.m_RegConfig.SetAutoSwitch(this.m_TSMIAutoOn.Checked);
        }
        private void M_TSMISave_Click(object sender, EventArgs e)
        {
            if (!this.m_TSMISave.Checked)
            {
                this.p_RemovePositionAndSize();
                return;
            }
            this.p_SetPositionAndSize();
        }
        private void M_TSMISaveOn_Click(object sender, EventArgs e)
        {
            if (this.m_TSMISaveOn.Checked)
            {
                ToolStripLabel tsl = (ToolStripLabel)this.m_TComboBox.SelectedItem;
                if (tsl != null && tsl.Name != "")
                {
                    this.m_RegConfig.SetLastLang(tsl.Name);
                }
                return;
            }
            this.m_RegConfig.RemoveLastLang();
        }
        private void M_TSMIContent_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.a7x-im.com/YAT/");
        }
        private void M_TSMIAbout_Click(object sender, EventArgs e)
        {
            About dlg = new YAT.About();
            dlg.ShowDialog();
        }
        private void M_tsmi_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(tsmi.Name);
                this.m_RegConfig.SetLang(tsmi.Name);
                this.UpdateInterface();
                this.DisableElements();
                this.m_UTimer.Start();
            }
        }
        private void M_TSCBPref_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m_TSMINoDef.Checked)
            {
                return;
            }
            ToolStripLabel tsl = (ToolStripLabel)this.m_TSCBPref.SelectedItem;
            if (tsl != null && tsl.Name != "")
            {
                this.m_RegConfig.SetPrefLang(tsl.Name);

                // Correct ComboBox <From> selected
                if (!this.m_RegConfig.GetHoldLang())
                {
                    this.p_SetSelectedItem(tsl.Name, this.m_FComboBox);
                }
            }
        } 
        private void M_FRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!this.m_TSMIAuto.Checked ||
                    this.m_RegConfig.GetHoldLang())
            {
                return;
            }
            if (this.m_FRichTextBox.Text.Length == 0)
            {
                this.m_TRichTextBox.Text = "";
            }
            else
            {
                this.m_ATimer.Stop ();
                this.m_ATimer.Start();
            }
        }
        private void M_HButton_Click(object sender, EventArgs e)
        {
            bool on = this.m_RegConfig.GetHoldLang();
            this.m_HButton.Image = on ? Pixmaps.HoldD : Pixmaps.HoldE;
            this.m_FComboBox.Enabled = on;
            this.m_TComboBox.Enabled = on;
            this.m_RegConfig.SetHoldLang(!on);
            if (!on)
            {
                string f = ((ToolStripLabel)this.m_FComboBox.SelectedItem).Name;
                string t = ((ToolStripLabel)this.m_TComboBox.SelectedItem).Name;
                this.m_RegConfig.SetHoldLangs(f + ":" + t);
            }
            else
            {
                this.m_RegConfig.RemoveHoldLangs();
            }
        }
        private void M_SButton_Click(object sender, EventArgs e)
        {
            string f = "";
            string t = "";

            ToolStripLabel tsl = null;

            // From
            tsl = (ToolStripLabel)this.m_FComboBox.SelectedItem;
            f = tsl.Name;

            // To
            tsl = (ToolStripLabel)this.m_TComboBox.SelectedItem;
            t = tsl.Name;

            // ComboBox
            this.p_SetSelectedItem(t, this.m_FComboBox);
            this.p_SetSelectedItem(f, this.m_TComboBox);
        }
        private async void M_TButton_Click(object sender, EventArgs e)
        {
            this.m_ATimer.Stop();
            string text = this.m_FRichTextBox.Text;
            if (text.Length <= 0)
            {
                return;
            }
            string from = ((ToolStripLabel)this.m_FComboBox.SelectedItem).Name;
            string to   = ((ToolStripLabel)this.m_TComboBox.SelectedItem).Name;
            this.SetStatusText(this.m_CRManager.GetString("Translation"));
            string r = "";
            try
            {
                r = await this.m_APIManager.TranslationText(from, to, text);
            }
            catch (Exception)
            {
            }
            XMLTTData data = new XMLTTData(r);
            this.SetTranslatedText(data);
        }
        private async void M_UTimer_Tick(object sender, EventArgs e)
        {
            this.m_UTimer.Stop();
            this.SetStatusText(this.m_CRManager.GetString("GetLangs"));
            string r = "";
            try
            {
                r = await this.m_APIManager.GetLanguages();
            }
            catch (Exception)
            {
                Refresh dlg = new YAT.Refresh();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.m_UTimer.Start();
                    return;
                }
                else
                {
                    this.Close();
                }
            }
            XMLRLData data = new XMLRLData(r);
            this.SetPMLanguageList(data);
            this.SetLanguageList(data);
        }
        private async void M_ATimer_Tick(object sender, EventArgs e)
        {
            this.m_ATimer.Stop();
            string text = this.m_FRichTextBox.Text;
            if (text.Length <= 0)
            {
                return;
            }
            this.SetStatusText(this.m_CRManager.GetString("AutoDetect"));
            string r = "";
            try
            {
                r = await this.m_APIManager.AutoDetect(text, null);
            }
            catch
            {
            }
            XMLDLData data = new XMLDLData(r);
            this.SetAutoDetect(data);
        }
        private void M_ComboBox_Click(object sender, EventArgs e)
        {
            this.m_ATimer.Stop();
        }
        private void M_TComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.m_TSMISaveOn.Checked)
            {
                return;
            }
            ToolStripLabel tsl = (ToolStripLabel)this.m_TComboBox.SelectedItem;
            if (tsl != null && tsl.Name != "")
            {
                this.m_RegConfig.SetLastLang(tsl.Name);
            }
        }
        private void M_STimer_Tick(object sender, EventArgs e)
        {
            this.m_STimer.Stop();
            this.m_TSSLabel.Text = "";
        }
        // Private methods
        private void p_SetPositionAndSize()
        {
            Rectangle r = new Rectangle(this.DesktopLocation, this.Size);
            string rs = Util.RectangleToString(r);
            this.m_RegConfig.SetPositiionAndSize(rs);
        }
        private void p_RemovePositionAndSize()
        {
            this.m_RegConfig.RemovePositiionAndSize();
        }
        private void p_UpdateLangs()
        {
            this.m_APIManager.UpdateAPIKey();
            this.DisableElements();
            this.m_UTimer.Start();
        }
    }
}
