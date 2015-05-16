/*
 * 
    fzRec - FileZilla Password Recovery Tool
    Copyright (C) 2015 uberalles - uber_alles999@yahoo.com

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
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fzRec.core.filezilla.recover
{
    class FileZillaCredentials
    {
        public FileZillaCredentials()
        {
            Host = "not found";
            Port = "not found";
            User = "not found";
            Pass = "not found";
        }

        public FileZillaCredentials(String host, String port, String username, String password)
        {
            Host = host;
            Port = port;
            User = username;
            Pass = password;
        }

        public String Host { get; set; }
        public String Port { get; set; }
        public String User { get; set; }
        public String Pass { get; set; }
    }
}
