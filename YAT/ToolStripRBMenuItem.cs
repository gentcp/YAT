/* -----------------------------------------------------------------------
# File    : ToolStripRBMenuItem.cs
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
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

public class ToolStripRadioButtonMenuItem : ToolStripMenuItem
{
    private bool m_mouseDownState  = false;
    private bool m_mouseHoverState = false;

    public ToolStripRadioButtonMenuItem(string text, Image image,
        params ToolStripItem[] dropDownItems) : base(text, image, dropDownItems)
    {
        this.p_Initialize();
    }
    public ToolStripRadioButtonMenuItem(string text, Image image,
        EventHandler onClick, Keys shortcutKeys) : base(text, image, onClick, shortcutKeys)
    {
        this.p_Initialize();
        this.ShortcutKeys = shortcutKeys;
    }
    public ToolStripRadioButtonMenuItem(string text, Image image,
        EventHandler onClick, string name) : base(text, image, onClick, name)
    {
        this.p_Initialize();
    }
    public ToolStripRadioButtonMenuItem(string text, Image image,
        EventHandler onClick) : base(text, image, onClick)
    {
        this.p_Initialize();
    }
    public ToolStripRadioButtonMenuItem(string text, Image image) 
        : base(text, image, (EventHandler)null)
    {
        this.p_Initialize();
    }
    public ToolStripRadioButtonMenuItem(Image image)
        : base(null, image, (EventHandler)null)
    {
        this.p_Initialize();
    }
    public ToolStripRadioButtonMenuItem(string text)
        : base(text, null, (EventHandler)null)
    {
        this.p_Initialize();
    }
    public ToolStripRadioButtonMenuItem()
        : base()
    {
        this.p_Initialize();
    }
    // Protected override methods
    protected override void OnCheckedChanged(EventArgs e)
    {
        base.OnCheckedChanged(e);
        if (!this.Checked)
        {
            return;
        }
        foreach (ToolStripItem item in this.Parent.Items)
        {
            ToolStripRadioButtonMenuItem rbItem = item as ToolStripRadioButtonMenuItem;
            if (rbItem != null && rbItem != this && rbItem.Checked)
            {
                rbItem.Checked = false;
                return;
            } 
        }
    }
    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (this.Image != null)
        {
            return;
        }
        RadioButtonState state = RadioButtonState.UncheckedNormal;
        if (this.Enabled)
        {
            if (this.m_mouseDownState)
            {
                state = this.Checked ? RadioButtonState.CheckedPressed :
                    RadioButtonState.UncheckedPressed;
            }
            else if (this.m_mouseHoverState)
            {
                state = this.Checked ? RadioButtonState.CheckedHot :
                    RadioButtonState.UncheckedHot;
            }
            else
            {
                state = this.Checked ? RadioButtonState.CheckedNormal :
                    RadioButtonState.UncheckedNormal;
            }
        }
        else
        {
            state = this.Checked ? RadioButtonState.CheckedDisabled : 
                RadioButtonState.UncheckedDisabled;
        }
        Int32 offset = (ContentRectangle.Height -
            RadioButtonRenderer.GetGlyphSize(e.Graphics, state).Height) / 2;
        Point imageLocation = new Point(ContentRectangle.Location.X + 4,
            ContentRectangle.Location.Y + offset);
        if (this.Checked && 
            RadioButtonRenderer.IsBackgroundPartiallyTransparent(state))
        {
            Size glyphSize = RadioButtonRenderer.GetGlyphSize(e.Graphics, state);
            glyphSize.Width --;
            glyphSize.Height--;
            Rectangle backgroundRectangle = 
                new Rectangle(imageLocation, glyphSize);
            e.Graphics.FillEllipse(SystemBrushes.Control, 
                backgroundRectangle);
        }
        RadioButtonRenderer.DrawRadioButton(e.Graphics, 
            imageLocation, state);
    }
    protected override void OnMouseEnter(EventArgs e)
    {
        this.m_mouseHoverState = true;
        base.OnMouseEnter(e);
    }
    protected override void OnMouseLeave(EventArgs e)
    {
        this.m_mouseHoverState = false;
        base.OnMouseLeave(e);
    }
    protected override void OnMouseDown(MouseEventArgs e)
    {
        this.m_mouseDownState = true;
        this.Invalidate();
        base.OnMouseDown(e);
    }
    protected override void OnMouseUp(MouseEventArgs e)
    {
        this.m_mouseDownState = false;
        base.OnMouseUp(e);
    }
    protected override void OnOwnerChanged(EventArgs e)
    {
        ToolStripMenuItem item = this.OwnerItem as ToolStripMenuItem;
        if (item != null && item.CheckOnClick)
        {
            item.CheckedChanged += new EventHandler(Item_CheckedChanged);
        }
        base.OnOwnerChanged(e);
    }
    // Public ovveride method
    public override bool Enabled
    {
        get
        {
            ToolStripMenuItem item = this.OwnerItem as ToolStripMenuItem;
            if (!this.DesignMode && item != null && item.CheckOnClick)
            {
                return (base.Enabled && item.Checked);
            }
            return base.Enabled;
        }
        set
        {
            base.Enabled = value;
        }
    }
    // Private EventHandler methods
    private void Item_CheckedChanged(object sender, EventArgs e)
    {
        this.Invalidate();
    }
    // Private methods
    private void p_Initialize()
    {
        this.CheckOnClick = true;
    }
}

