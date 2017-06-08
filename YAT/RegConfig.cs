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
        private string p_GetRegValue(string key, string defaultValue = "")
        {
            if (this.m_RegKey != null)
            {
                return (string)this.m_RegKey.GetValue(key, defaultValue);
            }
            return defaultValue;
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
            this.p_SetRegValue("PositionAndSize", ps);
        }
        public void RemovePositiionAndSize()
        {
            this.p_RemoveRegKey("PositionAndSize");
        }
        public string GetPositiionAndSize()
        {
            return this.p_GetRegValue("PositionAndSize");
        }
        public void SetPrefLang(string lang)
        {
            this.p_SetRegValue("PreferredLang", lang);
        }
        public void RemovePrefLang()
        {
            this.p_RemoveRegKey("PreferredLang");
        }
        public string GetPrefLang()
        {
            return this.p_GetRegValue("PreferredLang");
        }
        public void SetAutoDetect(bool on)
        {
            this.p_SetRegValue("AutoDetect", on.ToString());
        }
        public bool GetAutoDetect()
        {
            return this.p_GetRegValue("AutoDetect", "True") == "True";
        }
        public void SetAutoSwitch(bool on)
        {
            this.p_SetRegValue("AutoSwitch", on.ToString());
        }
        public bool GetAutoSwitch()
        {
            return this.p_GetRegValue("AutoSwitch", "True") == "True";
        }
        public void SetLastLang(string lang)
        {
            this.p_SetRegValue("LastLang", lang);
        }
        public void RemoveLastLang()
        {
            this.p_RemoveRegKey("LastLang");
        }
        public string GetLastLang()
        {
            return this.p_GetRegValue("LastLang");
        }
        public bool GetSaveOn()
        {
            return this.p_GetRegValue("LastLang") != null;
        }
        public void SetHoldLang(bool on)
        {
            this.p_SetRegValue("HoldLang", on.ToString());
        }
        public bool GetHoldLang()
        {
            return this.p_GetRegValue("HoldLang", "False") == "True";
        }
        public void SetHoldLangs(string langs)
        {
            this.p_SetRegValue("HoldLangs", langs);
        }
        public void RemoveHoldLangs()
        {
            this.p_RemoveRegKey("HoldLangs");
        }
        public string GetHoldLangs()
        {
            return this.p_GetRegValue("HoldLangs");
        }
    }
}
