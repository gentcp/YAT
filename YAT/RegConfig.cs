/* -----------------------------------------------------------------------
# File    : RegConfig.cs
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
using Microsoft.Win32;

namespace YAT
{
    public class RegConfig
    {
        private string m_Key = @"Software\A7X-Im.Com Team\YAT";
        private RegistryKey m_RegKey = null;

        public RegConfig()
        {
            // Initialize objects
            this.m_RegKey = Registry.CurrentUser.OpenSubKey(this.m_Key);
            this.m_RegKey = (this.m_RegKey == null) ? Registry.CurrentUser.CreateSubKey(this.m_Key) :
                Registry.CurrentUser.OpenSubKey(this.m_Key, true);
        }
        ~RegConfig()
        {
            if (this.m_RegKey != null)
            {
                this.m_RegKey.Close();
            }
        }
        // Private methods
        void p_SetRegValue(string key, string value)
        {
            if (this.m_RegKey != null)
            {
                try
                {
                    this.m_RegKey.SetValue(key, value);
                }
                catch (Exception)
                {
                    Error.Reason(Errors.DReason);
                }
            }
        }
        void p_RemoveRegKey(string key)
        {
            if (this.m_RegKey != null)
            {
                try
                {
                    this.m_RegKey.DeleteValue(key);
                }
                catch
                {
                    Error.Reason(Errors.DReason);
                }
            }
        }
        private string p_GetRegValue(string key)
        {
            if (this.m_RegKey != null)
            {
                return (string)this.m_RegKey.GetValue(key, "");
            }
            return "";
        }
        // Public methods
        public void SetAPIKey(string APIKey)
        {
            this.p_SetRegValue("APIKey", APIKey);
        }
        public string GetAPIKey()
        {
            return this.p_GetRegValue("APIKey");
        }
        public void SetLang(string lang)
        {
            this.p_SetRegValue("Lang", lang);
        }
        public void RemoveLang()
        {
            this.p_RemoveRegKey("Lang");
        }
        public string GetLang()
        {
            return this.p_GetRegValue("Lang");
        }
        public void SetPositiionAndSize(string ps)
        {
            this.p_SetRegValue("PositiionAndSize", ps);
        }
        public void RemovePositiionAndSize()
        {
            this.p_RemoveRegKey("PositiionAndSize");
        }
        public string GetPositiionAndSize()
        {
            return this.p_GetRegValue("PositiionAndSize");
        }
    }
}
