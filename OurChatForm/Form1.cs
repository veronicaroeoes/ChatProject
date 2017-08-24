using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using Newtonsoft.Json;

namespace OurChatForm
{
    public partial class Form1 : Form
    {
        private Client MyClient;

        public Form1()
        {
            InitializeComponent();
            listBoxUsers.Items.Add("Public");
            listBoxUsers.SelectedIndex = 0;
            CheckForIllegalCrossThreadCalls = false;
            textBoxMessage.Enabled = false;
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }

        public void setTextBoxes(bool status)
        {
            textBoxUserName.Enabled = status;
            textboxIpadress.Enabled = status;
            buttonCreateUser.Enabled = status;

            textBoxMessage.Enabled = !status;
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {

            if (MyClient == null)
            {
                MyClient = new Client(textBoxUserName.Text, textboxIpadress.Text, this);

                MyClient.Start();
            }

            string usertemp = textBoxUserName.Text;

            ClassLibrary.Protocoll myProtocoll = new Protocoll();
            myProtocoll.MessageType = ProtocolType.UserName;
            myProtocoll.Sender = usertemp;

            string jsonmessage = JsonConvert.SerializeObject(myProtocoll);


            listBoxUsers.SelectedIndex = 0;
            MyClient.Send(jsonmessage);

            setTextBoxes(false);

            //markerad kanal är den som du skickar till.
            //MyClient.Listen();
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxUsers.Invalidate();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedIndex != -1)
            {
                string receiver = listBoxUsers.Items[listBoxUsers.SelectedIndex].ToString();

                string myMessage = textBoxMessage.Text;

                ClassLibrary.Protocoll myProtocoll = new Protocoll();

                if (receiver == listBoxUsers.Items[0].ToString())
                {
                    myProtocoll.MessageType = ProtocolType.Message;
                }
                else
                {
                    myProtocoll.MessageType = ProtocolType.PrivateMessage;
                }

                myProtocoll.Receiver = receiver;
                myProtocoll.Content = myMessage;
                myProtocoll.Sender = textBoxUserName.Text;

                string jsonmessage = JsonConvert.SerializeObject(myProtocoll);


                MyClient.Send(jsonmessage);

                //
                listBoxUsers.SelectedIndex = 0;
                textBoxMessage.Text = "";
            }
            else
                MessageBox.Show("HOX! Select a receiver.");
        }

        public void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDisconnectUser_Click(object sender, EventArgs e)
        {
            //string receiver = listBoxUsers.Items[listBoxUsers.SelectedIndex].ToString();

            //string myMessage = textBoxMessage.Text;

            listBoxChat.Items.Add($"{textBoxUserName.Text} has left the chat");
            listBoxUsers.Items.Remove(textBoxUserName.Text);

            ClassLibrary.Protocoll myProtocoll = new Protocoll();
            myProtocoll.MessageType = ProtocolType.DeleteClient;
            myProtocoll.Sender = textBoxUserName.Text;

            string jsonmessage = JsonConvert.SerializeObject(myProtocoll);

            MyClient.Send(jsonmessage);
            MyClient.DisconnectMe();

            setTextBoxes(true);
            MyClient = null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClassLibrary.Protocoll myProtocoll = new Protocoll();
            myProtocoll.MessageType = ProtocolType.DeleteClient;
            myProtocoll.Sender = textBoxUserName.Text;

            string jsonmessage = JsonConvert.SerializeObject(myProtocoll);

            // ????????????????????????????????????????????????????????????????????????????????????

            if (MyClient != null)
                MyClient.DisconnectMe();
            if (MyClient != null)
                MyClient.Send(jsonmessage);

            // ????????????????????????????????????????????????????????????????????????????????????

        }

        private void textBoxMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                // SEND
                buttonSend_Click(sender, e);
            }
        }

        private void listBoxUsers_DrawItem(object sender, DrawItemEventArgs e)
        {
            //set the color values of your own color.
            int alpha = 255, red = 237, green = 43, blue = 136;

            //Set the color variable c to get your color values in ARGB blend mode.
            Color c = new Color();
            c = Color.FromArgb(alpha, red, green, blue);

            int index = e.Index;
            Graphics g = e.Graphics;

            foreach (int itemIndex in listBoxUsers.SelectedIndices)
            {

                if (index == itemIndex)
                {
                    // Draw the new background colour
                    e.DrawBackground();
                    g.FillRectangle(new SolidBrush(c), e.Bounds);
                }
            }

            // Get the item details
            Font font = listBoxUsers.Font;
            Color colour = listBoxUsers.BackColor;
            string text = listBoxUsers.Items[index].ToString();

            // Print the text
            g.DrawString(text, font, new SolidBrush(Color.White), (float)e.Bounds.X, (float)e.Bounds.Y);
            e.DrawFocusRectangle();

        }
    }
}
