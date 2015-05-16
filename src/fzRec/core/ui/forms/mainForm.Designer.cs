namespace fzRec.core.ui.forms
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.ver = new System.Windows.Forms.ToolStripStatusLabel();
            this.spacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.counter = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutFzRecMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detection_message = new System.Windows.Forms.Label();
            this.credslist = new System.Windows.Forms.ListView();
            this.host = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.popupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.popMenuCopyHostItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popMenuCopyUsernameItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popMenuCopyPasswordItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.popupMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ver,
            this.spacer,
            this.counter});
            this.statusBar.Location = new System.Drawing.Point(0, 369);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(664, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // ver
            // 
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(44, 17);
            this.ver.Text = "ver. 1.0";
            // 
            // spacer
            // 
            this.spacer.Name = "spacer";
            this.spacer.Size = new System.Drawing.Size(557, 17);
            this.spacer.Spring = true;
            // 
            // counter
            // 
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(48, 17);
            this.counter.Text = "counter";
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(664, 24);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutFzRecMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutFzRecMenuItem
            // 
            this.aboutFzRecMenuItem.Name = "aboutFzRecMenuItem";
            this.aboutFzRecMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutFzRecMenuItem.Text = "About fzRec";
            this.aboutFzRecMenuItem.Click += new System.EventHandler(this.aboutFzRecMenuItem_Click);
            // 
            // detection_message
            // 
            this.detection_message.Dock = System.Windows.Forms.DockStyle.Top;
            this.detection_message.Location = new System.Drawing.Point(0, 24);
            this.detection_message.Name = "detection_message";
            this.detection_message.Size = new System.Drawing.Size(664, 26);
            this.detection_message.TabIndex = 2;
            this.detection_message.Text = "detection message";
            this.detection_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // credslist
            // 
            this.credslist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.credslist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.host,
            this.port,
            this.username,
            this.password});
            this.credslist.ContextMenuStrip = this.popupMenu;
            this.credslist.FullRowSelect = true;
            this.credslist.Location = new System.Drawing.Point(3, 53);
            this.credslist.MultiSelect = false;
            this.credslist.Name = "credslist";
            this.credslist.Size = new System.Drawing.Size(661, 313);
            this.credslist.TabIndex = 3;
            this.credslist.UseCompatibleStateImageBehavior = false;
            this.credslist.View = System.Windows.Forms.View.Details;
            this.credslist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.credslist_MouseClick);
            // 
            // host
            // 
            this.host.Text = "Host";
            this.host.Width = 250;
            // 
            // port
            // 
            this.port.Text = "Port";
            // 
            // username
            // 
            this.username.Text = "Username";
            this.username.Width = 200;
            // 
            // password
            // 
            this.password.Text = "Password";
            this.password.Width = 140;
            // 
            // popupMenu
            // 
            this.popupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popMenuCopyHostItem,
            this.popMenuCopyUsernameItem,
            this.popMenuCopyPasswordItem});
            this.popupMenu.Name = "popupMenu";
            this.popupMenu.Size = new System.Drawing.Size(159, 70);
            this.popupMenu.Opening += new System.ComponentModel.CancelEventHandler(this.popupMenu_Opening);
            // 
            // popMenuCopyHostItem
            // 
            this.popMenuCopyHostItem.Name = "popMenuCopyHostItem";
            this.popMenuCopyHostItem.Size = new System.Drawing.Size(158, 22);
            this.popMenuCopyHostItem.Text = "Copy Host";
            this.popMenuCopyHostItem.Visible = false;
            this.popMenuCopyHostItem.Click += new System.EventHandler(this.popMenuCopyHostItem_Click);
            // 
            // popMenuCopyUsernameItem
            // 
            this.popMenuCopyUsernameItem.Name = "popMenuCopyUsernameItem";
            this.popMenuCopyUsernameItem.Size = new System.Drawing.Size(158, 22);
            this.popMenuCopyUsernameItem.Text = "Copy Username";
            this.popMenuCopyUsernameItem.Visible = false;
            this.popMenuCopyUsernameItem.Click += new System.EventHandler(this.popMenuCopyUsernameItem_Click);
            // 
            // popMenuCopyPasswordItem
            // 
            this.popMenuCopyPasswordItem.Name = "popMenuCopyPasswordItem";
            this.popMenuCopyPasswordItem.Size = new System.Drawing.Size(158, 22);
            this.popMenuCopyPasswordItem.Text = "Copy Password";
            this.popMenuCopyPasswordItem.Visible = false;
            this.popMenuCopyPasswordItem.Click += new System.EventHandler(this.popMenuCopyPasswordItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 391);
            this.Controls.Add(this.credslist);
            this.Controls.Add(this.detection_message);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fzRec - FileZilla Password Recovery Tool";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.popupMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutFzRecMenuItem;
        private System.Windows.Forms.Label detection_message;
        private System.Windows.Forms.ToolStripStatusLabel ver;
        private System.Windows.Forms.ListView credslist;
        private System.Windows.Forms.ColumnHeader host;
        private System.Windows.Forms.ColumnHeader port;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader password;
        private System.Windows.Forms.ToolStripStatusLabel counter;
        private System.Windows.Forms.ContextMenuStrip popupMenu;
        private System.Windows.Forms.ToolStripMenuItem popMenuCopyHostItem;
        private System.Windows.Forms.ToolStripMenuItem popMenuCopyUsernameItem;
        private System.Windows.Forms.ToolStripMenuItem popMenuCopyPasswordItem;
        private System.Windows.Forms.ToolStripStatusLabel spacer;
    }
}

