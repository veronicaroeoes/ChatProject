namespace OurChatForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textboxIpadress = new System.Windows.Forms.TextBox();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.listBoxChat = new System.Windows.Forms.ListBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.labelFriendsOnline = new System.Windows.Forms.Label();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(30, 43);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(73, 17);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Username";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(189)))), ((int)(((byte)(104)))));
            this.textBoxUserName.Location = new System.Drawing.Point(33, 63);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(133, 22);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // textboxIpadress
            // 
            this.textboxIpadress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(189)))), ((int)(((byte)(104)))));
            this.textboxIpadress.Location = new System.Drawing.Point(33, 108);
            this.textboxIpadress.Name = "textboxIpadress";
            this.textboxIpadress.Size = new System.Drawing.Size(133, 22);
            this.textboxIpadress.TabIndex = 3;
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.ForeColor = System.Drawing.Color.White;
            this.labelIPAddress.Location = new System.Drawing.Point(30, 88);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(76, 17);
            this.labelIPAddress.TabIndex = 2;
            this.labelIPAddress.Text = "IP-address";
            // 
            // listBoxChat
            // 
            this.listBoxChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(189)))), ((int)(((byte)(104)))));
            this.listBoxChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxChat.FormattingEnabled = true;
            this.listBoxChat.ItemHeight = 16;
            this.listBoxChat.Location = new System.Drawing.Point(192, 43);
            this.listBoxChat.Name = "listBoxChat";
            this.listBoxChat.Size = new System.Drawing.Size(805, 420);
            this.listBoxChat.TabIndex = 4;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(110)))), ((int)(((byte)(158)))));
            this.buttonSend.Location = new System.Drawing.Point(33, 431);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(133, 32);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Send message";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(189)))), ((int)(((byte)(104)))));
            this.textBoxMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMessage.Location = new System.Drawing.Point(33, 403);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(133, 22);
            this.textBoxMessage.TabIndex = 6;
            this.textBoxMessage.Text = "write message...";
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(189)))), ((int)(((byte)(104)))));
            this.listBoxUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 16;
            this.listBoxUsers.Location = new System.Drawing.Point(33, 223);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(133, 160);
            this.listBoxUsers.TabIndex = 7;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // labelFriendsOnline
            // 
            this.labelFriendsOnline.AutoSize = true;
            this.labelFriendsOnline.ForeColor = System.Drawing.Color.White;
            this.labelFriendsOnline.Location = new System.Drawing.Point(33, 200);
            this.labelFriendsOnline.Name = "labelFriendsOnline";
            this.labelFriendsOnline.Size = new System.Drawing.Size(85, 17);
            this.labelFriendsOnline.TabIndex = 8;
            this.labelFriendsOnline.Text = "Your friends";
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(110)))), ((int)(((byte)(158)))));
            this.buttonCreateUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCreateUser.ForeColor = System.Drawing.Color.White;
            this.buttonCreateUser.Location = new System.Drawing.Point(33, 147);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(133, 31);
            this.buttonCreateUser.TabIndex = 9;
            this.buttonCreateUser.Text = "Go!";
            this.buttonCreateUser.UseVisualStyleBackColor = false;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(177)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1034, 506);
            this.Controls.Add(this.buttonCreateUser);
            this.Controls.Add(this.labelFriendsOnline);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.listBoxChat);
            this.Controls.Add(this.textboxIpadress);
            this.Controls.Add(this.labelIPAddress);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Chattify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textboxIpadress;
        private System.Windows.Forms.Label labelIPAddress;
        public System.Windows.Forms.ListBox listBoxChat;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxMessage;
        public System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label labelFriendsOnline;
        private System.Windows.Forms.Button buttonCreateUser;
    }
}

