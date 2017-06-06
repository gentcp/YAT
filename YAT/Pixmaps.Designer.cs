/* -----------------------------------------------------------------------
# File    : Pixmaps.Designer.cs
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
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace YAT
{
    [GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCodeAttribute()]
    [CompilerGeneratedAttribute()]
    internal class Pixmaps
    {
        private static ResourceManager m_ResourceManager = null;
        private static CultureInfo m_ResourceCulture = null;

        [SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Pixmaps()
        {
        }
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if ((m_ResourceManager == null))
                {
                    m_ResourceManager = new ResourceManager("YAT.Pixmaps", typeof(Pixmaps).Assembly);
                }
                return m_ResourceManager;
            }
        }
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return m_ResourceCulture;
            }
            set
            {
                m_ResourceCulture = value;
            }
        }
        // Internal methods
        internal static System.Drawing.Bitmap Error
        {
            get
            {
                object obj = ResourceManager.GetObject("Error", m_ResourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        internal static System.Drawing.Bitmap ErrorIcon
        {
            get
            {
                object obj = ResourceManager.GetObject("ErrorIcon", m_ResourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        internal static System.Drawing.Bitmap Icon
        {
            get
            {
                object obj = ResourceManager.GetObject("Icon", m_ResourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        internal static System.Drawing.Bitmap Key
        {
            get
            {
                object obj = ResourceManager.GetObject("Key", m_ResourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        internal static System.Drawing.Bitmap Logo
        {
            get
            {
                object obj = ResourceManager.GetObject("Logo", m_ResourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        internal static System.Drawing.Bitmap Translate
        {
            get
            {
                object obj = ResourceManager.GetObject("Translate", m_ResourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        internal static System.Drawing.Bitmap Switch
        {
            get
            {
                object obj = ResourceManager.GetObject("Switch", m_ResourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
