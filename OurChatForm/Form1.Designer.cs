using System.Windows.Forms;

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
            this.textBoxMessage = new System.Windows.Forms.RichTextBox();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.labelFriendsOnline = new System.Windows.Forms.Label();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.buttonDisconnectUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(34, 121);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(92, 23);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Username";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(189)))), ((int)(((byte)(104)))));
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(37, 147);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(133, 20);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // textboxIpadress
            // 
            this.textboxIpadress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(189)))), ((int)(((byte)(104)))));
            this.textboxIpadress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxIpadress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxIpadress.Location = new System.Drawing.Point(37, 196);
            this.textboxIpadress.Name = "textboxIpadress";
            this.textboxIpadress.Size = new System.Drawing.Size(133, 20);
            this.textboxIpadress.TabIndex = 3;
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIPAddress.ForeColor = System.Drawing.Color.White;
            this.labelIPAddress.Location = new System.Drawing.Point(34, 170);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(92, 23);
            this.labelIPAddress.TabIndex = 2;
            this.labelIPAddress.Text = "IP-address";
            // 
            // listBoxChat
            // 
            this.listBoxChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(189)))), ((int)(((byte)(104)))));
            this.listBoxChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxChat.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxChat.FormattingEnabled = true;
            this.listBoxChat.ItemHeight = 23;
            this.listBoxChat.Location = new System.Drawing.Point(196, 121);
            this.listBoxChat.Name = "listBoxChat";
            this.listBoxChat.Size = new System.Drawing.Size(805, 322);
            this.listBoxChat.TabIndex = 4;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(110)))), ((int)(((byte)(158)))));
            this.buttonSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSend.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(868, 562);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(133, 32);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Send message";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            this.buttonSend.Enter += new System.EventHandler(this.textBoxMessage_TextChanged);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(189)))), ((int)(((byte)(104)))));
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMessage.Font = new System.Drawing.Font("Open Sans", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMessage.ForeColor = System.Drawing.Color.Black;
            this.textBoxMessage.Location = new System.Drawing.Point(196, 466);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(805, 87);
            this.textBoxMessage.TabIndex = 6;
            this.textBoxMessage.Text = "";
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            this.textBoxMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxMessage_KeyUp);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(189)))), ((int)(((byte)(104)))));
            this.listBoxUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxUsers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxUsers.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 23;
            this.listBoxUsers.Location = new System.Drawing.Point(37, 301);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(133, 253);
            this.listBoxUsers.TabIndex = 7;
            this.listBoxUsers.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxUsers_DrawItem);
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // labelFriendsOnline
            // 
            this.labelFriendsOnline.AutoSize = true;
            this.labelFriendsOnline.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsOnline.ForeColor = System.Drawing.Color.White;
            this.labelFriendsOnline.Location = new System.Drawing.Point(37, 278);
            this.labelFriendsOnline.Name = "labelFriendsOnline";
            this.labelFriendsOnline.Size = new System.Drawing.Size(106, 23);
            this.labelFriendsOnline.TabIndex = 8;
            this.labelFriendsOnline.Text = "Your friends";
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(110)))), ((int)(((byte)(158)))));
            this.buttonCreateUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCreateUser.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateUser.ForeColor = System.Drawing.Color.White;
            this.buttonCreateUser.Location = new System.Drawing.Point(37, 232);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(133, 31);
            this.buttonCreateUser.TabIndex = 9;
            this.buttonCreateUser.Text = "Go!";
            this.buttonCreateUser.UseVisualStyleBackColor = false;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // buttonDisconnectUser
            // 
            this.buttonDisconnectUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(110)))), ((int)(((byte)(158)))));
            this.buttonDisconnectUser.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnectUser.ForeColor = System.Drawing.Color.White;
            this.buttonDisconnectUser.Location = new System.Drawing.Point(868, 31);
            this.buttonDisconnectUser.Name = "buttonDisconnectUser";
            this.buttonDisconnectUser.Size = new System.Drawing.Size(133, 33);
            this.buttonDisconnectUser.TabIndex = 11;
            this.buttonDisconnectUser.Text = "Disconnect";
            this.buttonDisconnectUser.UseVisualStyleBackColor = false;
            this.buttonDisconnectUser.Click += new System.EventHandler(this.buttonDisconnectUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OurChatForm.Properties.Resources.Chattify_logo_vit3;
            this.pictureBox1.Location = new System.Drawing.Point(37, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(177)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1034, 610);
            this.Controls.Add(this.buttonDisconnectUser);
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
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Chattify";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        //private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.RichTextBox textBoxMessage;
        public System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label labelFriendsOnline;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDisconnectUser;
    }
}

