using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurChatForm
{
    public partial class Form1 : Form
    {
        private Client MyClient;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            MyClient = new Client(textBoxUserName.Text, textboxIpadress.Text, this);
            MyClient.Start();
            MyClient.Listen();

        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string myMessage = textBoxMessage.Text;
            MyClient.Send(myMessage);
        }
    }
}
