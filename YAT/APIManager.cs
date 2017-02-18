/* -----------------------------------------------------------------------
# File    : APIManager.cs
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
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace YAT
{
    public class APIManager
    {
        private string m_HostName = "http://translate.yandex.net/";
        private string m_RL = "https://translate.yandex.net/api/v1.5/tr/getLangs?key={0}&ui={1}";
        private string m_TT = "https://translate.yandex.net/api/v1.5/tr/translate?key={0}&text={1}&lang={2}&format=plain&option=1";
        private string m_DL = "https://translate.yandex.net/api/v1.5/tr/detect?key={0}&text={1}&hint={2}";

        private HttpClient m_HTTPClient = null;
        private string m_APIKey = null;

        public APIManager()
        {
            // Initialize objects
            this.m_HTTPClient = new HttpClient();
            this.m_APIKey = new RegConfig().GetAPIKey();

            // HttpClient
            this.m_HTTPClient.BaseAddress = new Uri(this.m_HostName);
            this.m_HTTPClient.DefaultRequestHeaders.Accept.Clear();
            //this.m_HTTPClient.Timeout = new TimeSpan(0, 0, 1);

            // APIKey
            UpdateAPIKey();
        }
        /* Public async methods */
        public async Task<string> GetLanguages()
        {
            string lang = Thread.CurrentThread.CurrentUICulture.Name;
            string req = String.Format(this.m_RL, this.m_APIKey, Util.GetNormalizeLang(lang));
            HttpResponseMessage rsp = await this.m_HTTPClient.GetAsync(req);
            if (rsp.StatusCode == HttpStatusCode.OK)
            {
                return await rsp.Content.ReadAsStringAsync();
            }
            return "";
        }
        public async Task<string> TranslationText(string from, string to, string text)
        {
            string req = String.Format(this.m_TT, this.m_APIKey, Uri.EscapeDataString(text), from + "-" + to);
            HttpResponseMessage rsp = await this.m_HTTPClient.GetAsync(req);
            if (rsp.StatusCode == HttpStatusCode.OK)
            {
                return await rsp.Content.ReadAsStringAsync();
            }
            return "";
        }
        public async Task<string> AutoDetect(string text, List<string> filter)
        {
            string flt = "";
            if (filter != null)
            {
                foreach (string f in filter)
                {
                    flt += f + ",";
                }
            }
            string req = String.Format(this.m_DL, this.m_APIKey, Uri.EscapeDataString(text), flt);
            HttpResponseMessage rsp = await this.m_HTTPClient.GetAsync(req);
            if (rsp.StatusCode == HttpStatusCode.OK)
            {
                return await rsp.Content.ReadAsStringAsync();
            }
            return "";
        }
        public void UpdateAPIKey()
        {
            this.m_APIKey = (this.m_APIKey.Length == 0) ? 
                Docs.APIKey : this.m_APIKey;
        }
    }
}