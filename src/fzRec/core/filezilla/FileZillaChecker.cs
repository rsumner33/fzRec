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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fzRec.core.filezilla
{
    class FileZillaChecker
    {
        public static Boolean fzInstalled
        {
            get
            {
                return fzFolderExists && fzRecentServersFileExists && fzSiteManagerFileExists;
            }
        }

        public static Boolean fzFolderExists
        {
            get
            {
                return Directory.Exists(Settings.FileZillaFolder);
            }
        }

        public static Boolean fzRecentServersFileExists
        {
            get
            {
                return File.Exists(Settings.FileZillaRecentServersFile);
            }
        }

        public static Boolean fzSiteManagerFileExists
        {
            get
            {
                return File.Exists(Settings.FileZillaSiteManagerFile);
            }
        }
    }
}
