/* -----------------------------------------------------------------------
# File    : ToolTipHelper.Designer.cs
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
    internal class ToolTipHelper
    {
        private static ResourceManager m_ResourceManager = null;
        private static CultureInfo m_ResourceCulture = null;

        [SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ToolTipHelper()
        {
        }
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if ((m_ResourceManager == null))
                {
                    m_ResourceManager = new ResourceManager("YAT.ToolTipHelper", typeof(ToolTipHelper).Assembly);
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
        internal static string Hold
        {
            get
            {
                return ResourceManager.GetString("Hold", m_ResourceCulture);
            }
        }
        internal static string Switch
        {
            get
            {
                return ResourceManager.GetString("Switch", m_ResourceCulture);
            }
        }
        internal static string Translate
        {
            get
            {
                return ResourceManager.GetString("Translate", m_ResourceCulture);
            }
        }
    }
}
