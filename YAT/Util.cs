/* -----------------------------------------------------------------------
# File    : Util.cs
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

namespace YAT
{
    public static class Util
    {
        public static string GetNormalizeLang(string lang)
        {
            if (lang.Length <= 0)
            {
                return lang;
            }
            return lang.Split('-')[0];
        }
        public static Rectangle StringToRectangle(string ps)
        {
            Rectangle r = new Rectangle(0, 0, 0, 0);
            string[] split = ps.Split('+');
            if (split == null || split.Length != 2)
            {
                return r;
            }
            string[] s = split[1].Split('x');
            if (s != null || s.Length == 2)
            {
                try
                {
                    r.Width  = Convert.ToInt32(s[0]);
                    r.Height = Convert.ToInt32(s[1]);
                }
                catch (Exception)
                {
                }
            }
            string[] p = split[0].Split('x');
            if (p == null || p.Length == 2)
            {
                try
                {
                    r.X = Convert.ToInt32(p[0]);
                    r.Y = Convert.ToInt32(p[1]);
                }
                catch (Exception)
                {
                }
            }
            return r;
        }
        public static string RectangleToString(Rectangle r)
        {
            string ps = "0x0+0x0";
            ps = String.Format("{0}x{1}+{2}x{3}", 
                r.X, r.Y, r.Width, r.Height);
            return ps;
        }
    }
}