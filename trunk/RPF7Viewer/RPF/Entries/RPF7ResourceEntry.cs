﻿/*
 
    RPF7Viewer - Viewer for RAGE Package File version 7
    Copyright (C) 2013  koolk <koolkdev at gmail.com>
   
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.
  
    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.
   
    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPF7Viewer.RPF.Entries
{
    public class RPF7ResourceEntry : RPF7FileEntry
    {
        public ulong Parameter;
        public int Type;

        public RPF7ResourceEntry(String filename, IRPFBuffer data, ulong parameter)
            : base(filename, data)
        {
            this.Parameter = parameter;
            this.Type = (int)(((this.Parameter >> 28) & 0xf) | ((this.Parameter >> 56) & 0xf0));
        }
        
    }
}