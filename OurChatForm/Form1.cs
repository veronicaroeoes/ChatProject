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
            listBoxUsers.Items.Add("Veronica");
            CheckForIllegalCrossThreadCalls = false;
            
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            MyClient = new Client(textBoxUserName.Text, textboxIpadress.Text, this);

            MyClient.Start();

            string usertemp = textBoxUserName.Text;

            ClassLibrary.Protocoll myProtocoll = new Protocoll();
            myProtocoll.MessageType = ProtocolType.UserName;
            myProtocoll.Sender = usertemp;

            string jsonmessage = JsonConvert.SerializeObject(myProtocoll);
            
            MyClient.Send(jsonmessage);
            //MyClient.Listen();
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Client> users = new List<Client>();
            //todo: List of Clients ska innehålla clients från servern

            foreach (var user in users)
            {
                listBoxUsers.Items.Add(user);
            }

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string receiver = listBoxUsers.Items[listBoxUsers.SelectedIndex].ToString();

            string myMessage = textBoxMessage.Text;

            ClassLibrary.Protocoll myProtocoll = new Protocoll();
            myProtocoll.MessageType = ProtocolType.Message;
            myProtocoll.Receiver = receiver;
            myProtocoll.Content = myMessage;

            string jsonmessage = JsonConvert.SerializeObject(myProtocoll);

            MyClient.Send(jsonmessage);
        }
    }
}
