/* -----------------------------------------------------------------------
# File    : XMLManager.cs
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
using System.Xml;

namespace YAT
{
    public class XMLRLData
    {
        private XmlDocument m_XmlDocument = null;
        private Dictionary<string, string> m_List = null;
        private int m_Code = 0;

        public XMLRLData(string data)
        {
            // Initialize objects
            this.m_XmlDocument = new XmlDocument();
            this.m_List = new Dictionary<string, string>();

            // XML handle
            if (data.Length <= 0)
            {
                return;
            }
            this.m_XmlDocument.LoadXml(data);
            XmlElement xe = this.m_XmlDocument.DocumentElement;
            if (xe.Name != "Langs")
            {
                return;
            }
            try
            {
                this.m_Code = Convert.ToInt32(xe.GetAttribute("code"));
            }
            catch (Exception)
            {
            }
            switch (this.m_Code)
            {
                case (int)APIError.GETLANGS_BAD_KEY:
                case (int)APIError.GETLANGS_BLOCK_KEY:
                    return;
                default:
                    break;
            }
            XmlElement e = null;
            for (XmlNode n = xe.FirstChild; n != null; n = n.NextSibling)
            {
                if (n.NodeType != XmlNodeType.Element)
                {
                    continue;
                }
                if (n.Name == "langs")
                {
                    e = (XmlElement)n;
                    break;
                }
            }
            if (e == null)
            {
                return;
            }
            for (XmlNode n = e.FirstChild; n != null; n = n.NextSibling)
            {
                if (n.NodeType != XmlNodeType.Element)
                {
                    continue;
                }
                if (n.Name != "Item")
                {
                    continue;
                }
                XmlElement i = (XmlElement)n;
                string v = i.GetAttribute("value");
                string k = i.GetAttribute("key");
                if (v.Length > 0 &&
                    k.Length > 0)
                {
                    this.m_List.Add(k, v);
                }
            }
        }
        // Public methods
        public Dictionary<string, string> GetList()
        {
            return this.m_List;
        }
        public int GetCode()
        {
            return this.m_Code;
        }
        public bool IsNull()
        {
            return (this.m_List.Count == 0 &&
                this.m_Code == 0);
        }
        public bool IsEmpty()
        {
            return (this.m_List.Count == 0);
        }
    }
    public class XMLTTData
    {
        private XmlDocument m_XmlDocument = null;
        private string m_Text = null;
        private string m_Lang = null;
        private int m_Code = 0;

        public XMLTTData(string data)
        {
            // Initialize objects
            this.m_XmlDocument = new XmlDocument();
            this.m_Text = "";
            this.m_Lang = "";

            // XML handle
            if (data.Length <= 0)
            {
                return;
            }
            this.m_XmlDocument.LoadXml(data);
            XmlElement xe = this.m_XmlDocument.DocumentElement;
            if (xe.Name != "Translation")
            {
                return;
            }
            try
            {
                this.m_Code = Convert.ToInt32(xe.GetAttribute("code"));
            }
            catch (Exception)
            {
            }
            switch (this.m_Code)
            {
                case (int)APIResult.TRANSLATE_SUCCESS:
                    break;
                default:
                    return;
            }
            this.m_Lang = xe.GetAttribute("lang");
            XmlElement e = null;
            for (XmlNode n = xe.FirstChild; n != null; n = n.NextSibling)
            {
                if (n.NodeType != XmlNodeType.Element)
                {
                    continue;
                }
                if (n.Name == "text")
                {
                    e = (XmlElement)n;
                    break;
                }
            }
            if (e == null)
            {
                return;
            }
            this.m_Text = e.FirstChild.Value;
        }
        // Public methods
        public string GetText()
        {
            return this.m_Text;
        }
        public string GetLang()
        {
            return this.m_Lang;
        }
        public int GetCode()
        {
            return this.m_Code;
        }
        public bool IsNull()
        {
            return (this.m_Text.Length == 0 && this.m_Code == 0 &&
                this.m_Lang.Length == 0);
        }
        public bool IsEmpty()
        {
            return (this.m_Text.Length == 0);
        }
    }
    public class XMLDLData
    {
        private XmlDocument m_XmlDocument = null;
        private string m_Lang = null;
        private int m_Code = 0;

        public XMLDLData(string data)
        {
            // initialize objects
            this.m_XmlDocument = new XmlDocument();
            this.m_Lang = "";

            // XML handle
            if (data.Length <= 0)
            {
                return;
            }
            this.m_XmlDocument.LoadXml(data);
            XmlElement xe = this.m_XmlDocument.DocumentElement;
            if (xe.Name != "DetectedLang")
            {
                return;
            }
            try
            {
                this.m_Code = Convert.ToInt32(xe.GetAttribute("code"));
            }
            catch (Exception)
            {
            }
            switch (this.m_Code)
            {
                case (int)APIResult.TRANSLATE_SUCCESS:
                    break;
                default:
                    return;
            }
            this.m_Lang = xe.GetAttribute("lang");
        }
        // Public methods
        public string GetLang()
        {
            return this.m_Lang;
        }
        public int GetCode()
        {
            return this.m_Code;
        }
        public bool IsNull()
        {
            return (this.m_Lang.Length == 0 &&
                this.m_Code == 0);
        }
        public bool IsEmpty()
        {
            return (this.m_Lang.Length == 0);
        }
    }
}