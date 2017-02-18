/* -----------------------------------------------------------------------
# File    : Errors.Designer.cs
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
    internal class Errors
    {
        private static ResourceManager m_ResourceManager = null;
        private static CultureInfo m_ResourceCulture = null;

        [SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Errors()
        {
        }
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if ((m_ResourceManager == null))
                {
                    m_ResourceManager = new ResourceManager("YAT.Errors", typeof(Errors).Assembly);
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
        internal static string AReason
        {
            get
            {
                return ResourceManager.GetString("1-Reason", m_ResourceCulture);
            }
        }
        internal static string BReason
        {
            get
            {
                return ResourceManager.GetString("2-Reason", m_ResourceCulture);
            }
        }
        internal static string CReason
        {
            get
            {
                return ResourceManager.GetString("3-Reason", m_ResourceCulture);
            }
        }
        internal static string DReason
        {
            get
            {
                return ResourceManager.GetString("4-Reason", m_ResourceCulture);
            }
        }
        internal static string EReason
        {
            get
            {
                return ResourceManager.GetString("5-Reason", m_ResourceCulture);
            }
        }
        internal static string FReason
        {
            get
            {
                return ResourceManager.GetString("6-Reason", m_ResourceCulture);
            }
        }
        internal static string GReason
        {
            get
            {
                return ResourceManager.GetString("7-Reason", m_ResourceCulture);
            }
        }
        internal static string HReason
        {
            get
            {
                return ResourceManager.GetString("8-Reason", m_ResourceCulture);
            }
        }
        internal static string IReason
        {
            get
            {
                return ResourceManager.GetString("9-Reason", m_ResourceCulture);
            }
        }
        internal static string JReason
        {
            get
            {
                return ResourceManager.GetString("10-Reason", m_ResourceCulture);
            }
        }
        internal static string KReason
        {
            get
            {
                return ResourceManager.GetString("11-Reason", m_ResourceCulture);
            }
        }
        internal static string LReason
        {
            get
            {
                return ResourceManager.GetString("12-Reason", m_ResourceCulture);
            }
        }
        internal static string MReason
        {
            get
            {
                return ResourceManager.GetString("13-Reason", m_ResourceCulture);
            }
        }
        internal static string NReason
        {
            get
            {
                return ResourceManager.GetString("14-Reason", m_ResourceCulture);
            }
        }
    }
}
