/* -----------------------------------------------------------------------
# File    : APICode.cs
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

namespace YAT
{
    enum APIResult : int
    {
        TRANSLATE_SUCCESS       = 200,
        TRANSLATE_BAD_KEY       = 401,
        TRANSLATE_BLOCK_KEY     = 402,
        TRANSLATE_MAX_REQUEST   = 403,
        TRANSLATE_MAX_COUNT     = 404,
        TRANSLATE_MAX_SIZE      = 413,
        TRANSLATE_NOT_COULD     = 422,
        TRANSLATE_NOT_SUPPORT   = 501
    };
    enum APIError : int
    {
        GETLANGS_BAD_KEY    = 401,
        GETLANGS_BLOCK_KEY  = 402
    };
}