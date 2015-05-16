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

using fzRec.core.filezilla;
using fzRec.core.filezilla.recover;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fzRec.core.ui.forms
{
    public partial class mainForm : Form
    {
        List<FileZillaCredentials> _credentials;

        public mainForm()
        {
            InitializeComponent();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (FileZillaChecker.fzInstalled)
                {
                    detection_message.ForeColor = Color.Green;
                    detection_message.Text = "FileZilla application has been detected on this computer.";

                    _credentials = new List<FileZillaCredentials>();
                    _credentials = FileZillaCredentialsReader.ReadRecentServers().Union<FileZillaCredentials>(FileZillaCredentialsReader.ReadSiteManager()).ToList<FileZillaCredentials>();
                    if (_credentials.Count == 0)
                    {
                        InformUser.showInfo("No passwords have been recovered..");
                        return;
                    }

                    foreach (FileZillaCredentials fzc in _credentials)
                        credslist.Items.Add(new ListViewItem(
                            new String[] { fzc.Host, fzc.Port, fzc.User, Encoding.UTF8.GetString(Convert.FromBase64String(fzc.Pass)) }
                        ));
                    counter.Text = _credentials.Count + " credentials found";
                }
                else
                {
                    detection_message.ForeColor = Color.Red;
                    detection_message.Text = "FileZilla application has NOT been detected on this computer.";
                }
            }
            catch (Exception ex)
            {
                InformUser.showError(ex.Message);
            }
        }

        private void aboutFzRecMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm af = new aboutForm();
            af.ShowDialog();
            af.Dispose();
            af = null;
        }

        private void popMenuCopyHostItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (credslist.SelectedItems.Count == 1)
                    Clipboard.SetData(DataFormats.Text, credslist.SelectedItems[0].SubItems[0].Text);
            }
            catch (Exception ex)
            {
                InformUser.showError(ex.Message);
            }
        }

        private void popMenuCopyUsernameItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (credslist.SelectedItems.Count == 1)
                    Clipboard.SetData(DataFormats.Text, credslist.SelectedItems[0].SubItems[2].Text);
            }
            catch (Exception ex)
            {
                InformUser.showError(ex.Message);
            }
        }

        private void popMenuCopyPasswordItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (credslist.SelectedItems.Count == 1)
                    Clipboard.SetData(DataFormats.Text, credslist.SelectedItems[0].SubItems[3].Text);
            }
            catch (Exception ex)
            {
                InformUser.showError(ex.Message);
            }
        }

        private void popupMenu_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (credslist.SelectedItems.Count == 1)
                {
                    popMenuCopyHostItem.Visible = true;
                    popMenuCopyUsernameItem.Visible = true;
                    popMenuCopyPasswordItem.Visible = true;
                }
                else
                {
                    popMenuCopyHostItem.Visible = false;
                    popMenuCopyUsernameItem.Visible = false;
                    popMenuCopyPasswordItem.Visible = false;
                }
            }
            catch (Exception ex)
            {
                InformUser.showError(ex.Message);
            }
        }

        private void credslist_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    Point pt = popupMenu.PointToScreen(e.Location);
                    popupMenu.Show(pt);
                }
            }
            catch (Exception ex)
            {
                InformUser.showError(ex.Message);
            }
        }
    }
}
