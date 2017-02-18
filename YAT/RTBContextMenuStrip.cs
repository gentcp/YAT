/* -----------------------------------------------------------------------
# File    : RTBContextMenuStrip.cs
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
using System.Windows.Forms;

namespace YAT
{
    public class RTBContextMenuStrip : ContextMenuStrip
    {
        private ComponentResourceManager m_CRManager = null;
        private RichTextBox m_CRichTextBox = null;

        // ToolStripMenuItem
        private ToolStripMenuItem m_TSMIUndo = null;
        private ToolStripMenuItem m_TSMIRedo = null;
        private ToolStripMenuItem m_TSMICut = null;
        private ToolStripMenuItem m_TSMICopy = null;
        private ToolStripMenuItem m_TSMIPaste = null;
        private ToolStripMenuItem m_TSMIDelete = null;
        private ToolStripMenuItem m_TSMISelectAll = null;
        private ToolStripMenuItem m_TSMIClear = null;

        public RTBContextMenuStrip(RichTextBox rtb) : base()
        {
            // Control object
            this.m_CRichTextBox = rtb;
            this.m_CRichTextBox.SelectionChanged +=
                new EventHandler(M_CRichTextBox_SelectionChanged);
            this.m_CRichTextBox.TextChanged += 
                new EventHandler(M_CRichTextBox_TextChanged);

            // Initialize objects
            this.m_CRManager = new ComponentResourceManager(typeof(RTBContextMenuStrip));
            this.m_TSMIUndo = new ToolStripMenuItem();
            this.m_TSMIRedo = new ToolStripMenuItem();
            this.m_TSMICut = new ToolStripMenuItem();
            this.m_TSMICopy = new ToolStripMenuItem();
            this.m_TSMIPaste = new ToolStripMenuItem();
            this.m_TSMIDelete = new ToolStripMenuItem();
            this.m_TSMISelectAll = new ToolStripMenuItem();
            this.m_TSMIClear = new ToolStripMenuItem();

            // Undo
            this.m_TSMIUndo.Name = "Undo";
            this.m_TSMIUndo.ShortcutKeys = Keys.Control | Keys.Z;
            this.m_TSMIUndo.Click += new EventHandler(M_TSMIUndo_Click);

            // Redo
            this.m_TSMIRedo.Name = "Redo";
            this.m_TSMIRedo.ShortcutKeys = Keys.Control | Keys.Y;
            this.m_TSMIRedo.Click += new EventHandler(M_TSMIRedo_Click);

            // Cut
            this.m_TSMICut.Name = "Cut";
            this.m_TSMICut.ShortcutKeys = Keys.Control | Keys.X;
            this.m_TSMICut.Click += new EventHandler(M_TSMICut_Click);

            // Copy
            this.m_TSMICopy.Name = "Copy";
            this.m_TSMICopy.ShortcutKeys = Keys.Control | Keys.C;
            this.m_TSMICopy.Click += new EventHandler(M_TSMICopy_Click);

            // Paste
            this.m_TSMIPaste.Name = "Paste";
            this.m_TSMIPaste.ShortcutKeys = Keys.Control | Keys.V;
            this.m_TSMIPaste.Click += new EventHandler(M_TSMIPaste_Click);

            // Delete
            this.m_TSMIDelete.Name = "Delete";
            this.m_TSMIDelete.ShortcutKeys = Keys.Delete;
            this.m_TSMIDelete.Click += new EventHandler(M_TSMIDelete_Click);

            // Select all
            this.m_TSMISelectAll.Name = "SelectAll";
            this.m_TSMISelectAll.ShortcutKeys = Keys.Control | Keys.A;
            this.m_TSMISelectAll.Click += new EventHandler(M_TSMISelectAll_Click);

            // Clear
            this.m_TSMIClear.Name = "Clear";
            this.m_TSMIClear.Click += new EventHandler(M_TSMIClear_Click);

            // Adding items
            if (!this.m_CRichTextBox.ReadOnly)
            {
                this.Items.Add(this.m_TSMIUndo);
                this.Items.Add(this.m_TSMIRedo);
                this.Items.Add(new ToolStripSeparator());
                this.Items.Add(this.m_TSMICut);
            }
            this.Items.Add(this.m_TSMICopy);
            if (!this.m_CRichTextBox.ReadOnly)
            {
                this.Items.Add(this.m_TSMIPaste);
                this.Items.Add(this.m_TSMIDelete);
            }
            this.Items.Add(new ToolStripSeparator());
            this.Items.Add(this.m_TSMISelectAll);
            if (!this.m_CRichTextBox.ReadOnly)
            {
                this.Items.Add(new ToolStripSeparator());
                this.Items.Add(this.m_TSMIClear);
            }

            // ComponentResourceManager
            this.p_UpdateInterfaceLang();

            // Disabling
            this.m_TSMIUndo.Enabled      = false;
            this.m_TSMIRedo.Enabled      = false;
            this.m_TSMICut.Enabled       = false;
            this.m_TSMICopy.Enabled      = false;
            this.m_TSMIPaste.Enabled     = false;
            this.m_TSMIDelete.Enabled    = false;
            this.m_TSMISelectAll.Enabled = false;
            this.m_TSMIClear.Enabled     = false;
        }
        // Protected override methods
        protected override void OnOpening(CancelEventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                object obj = Clipboard.GetDataObject().GetData(DataFormats.Text);
                if (((string)obj).Length > 0)
                {
                    this.m_TSMIPaste.Enabled = true;
                }
            }
            base.OnOpening(e);
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
        // Private EventHandler methods
        private void M_TSMIUndo_Click(object sender, EventArgs e)
        {
            if (this.m_CRichTextBox.CanUndo)
            {
                this.m_CRichTextBox.Undo();
                //this.m_CRichTextBox.ClearUndo();
            }
        }
        private void M_TSMIRedo_Click(object sender, EventArgs e)
        {
            if (this.m_CRichTextBox.CanRedo)
            {
                this.m_CRichTextBox.Redo();
            }
        }
        private void M_TSMICut_Click(object sender, EventArgs e)
        {
            if (this.m_CRichTextBox.SelectionLength > 0)
            {
                this.m_CRichTextBox.Cut();
            }
        }
        private void M_TSMICopy_Click(object sender, EventArgs e)
        {
            if (this.m_CRichTextBox.SelectionLength > 0)
            {
                Clipboard.SetDataObject(this.m_CRichTextBox.SelectedText);
            }
        }
        private void M_TSMIPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                if (this.m_CRichTextBox.SelectionLength > 0)
                {
                    this.m_CRichTextBox.SelectedText = "";
                }
                this.m_CRichTextBox.Paste();
            }
        }
        private void M_TSMIDelete_Click(object sender, EventArgs e)
        {
            if (this.m_CRichTextBox.SelectionLength > 0)
            {
                this.m_CRichTextBox.SelectedText = "";
            }
        }
        private void M_TSMISelectAll_Click(object sender, EventArgs e)
        {
            this.m_CRichTextBox.SelectAll();
        }
        private void M_TSMIClear_Click(object sender, EventArgs e)
        {
            this.m_CRichTextBox.Clear();
        }
        private void M_CRichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            bool b = (this.m_CRichTextBox.SelectionLength > 0);
            this.m_TSMICut.Enabled    = b;
            this.m_TSMICopy.Enabled   = b;
            this.m_TSMIDelete.Enabled = b;
        }
        private void M_CRichTextBox_TextChanged(object sender, EventArgs e)
        {
            bool b = (this.m_CRichTextBox.TextLength > 0);
            this.m_TSMIUndo.Enabled  = b;
            this.m_TSMISelectAll.Enabled = b;
            this.m_TSMIClear.Enabled = b;
            this.m_TSMIRedo.Enabled = this.m_CRichTextBox.CanRedo;
        }
        // Private methods
        private void p_UpdateInterfaceLang()
        {
            this.m_CRManager.ApplyResources(this.m_TSMIUndo,      "Undo");
            this.m_CRManager.ApplyResources(this.m_TSMIRedo,      "Redo");
            this.m_CRManager.ApplyResources(this.m_TSMICut,       "Cut");
            this.m_CRManager.ApplyResources(this.m_TSMICopy,      "Copy");
            this.m_CRManager.ApplyResources(this.m_TSMIPaste,     "Paste");
            this.m_CRManager.ApplyResources(this.m_TSMIDelete,    "Delete");
            this.m_CRManager.ApplyResources(this.m_TSMISelectAll, "SelectAll");
            this.m_CRManager.ApplyResources(this.m_TSMIClear,     "Clear");
        }
        // Public methods
        public void UpdateInterface()
        {
            this.p_UpdateInterfaceLang();
        }
    }
}