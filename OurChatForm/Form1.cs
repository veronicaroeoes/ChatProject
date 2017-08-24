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
            //if (e.Index < 0) return;
            ////if the item state is selected them change the back color 
            //if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            //    e = new DrawItemEventArgs(e.Graphics,
            //                              e.Font,
            //                              e.Bounds,
            //                              e.Index,
            //                              e.State ^ DrawItemState.Selected,
            //                              e.ForeColor,
            //                              Color.Yellow);//Choose the color

            //// Draw the background of the ListBox control for each item.
            //e.DrawBackground();
            //// Draw the current item text
            //e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
        }

        private void buttonSend_Click(object sender, EventArgs e)
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

        public void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDisconnectUser_Click(object sender, EventArgs e)
        {
            //string receiver = listBoxUsers.Items[listBoxUsers.SelectedIndex].ToString();

            //string myMessage = textBoxMessage.Text;

            ClassLibrary.Protocoll myProtocoll = new Protocoll();
            myProtocoll.MessageType = ProtocolType.DeleteClient;
            myProtocoll.Sender = textBoxUserName.Text;

            string jsonmessage = JsonConvert.SerializeObject(myProtocoll);

            MyClient.Send(jsonmessage);
            MyClient.DisconnectMe();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClassLibrary.Protocoll myProtocoll = new Protocoll();
            myProtocoll.MessageType = ProtocolType.DeleteClient;
            myProtocoll.Sender = textBoxUserName.Text;

            string jsonmessage = JsonConvert.SerializeObject(myProtocoll);

            MyClient.Send(jsonmessage);
            MyClient.DisconnectMe();

        }

        private void textBoxMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                // SEND
                buttonSend_Click(sender, e);
            }
        }
    }
}
