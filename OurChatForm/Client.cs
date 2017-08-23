using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ClassLibrary;

namespace OurChatForm
{
    public class Client
    {
        private TcpClient client;
        private string Username;
        private string IPAddress;
        private Form1 Form;

        public Client(string username, string ipaddress, Form1 form)
        {
            this.Username = username;
            this.IPAddress = ipaddress;
            Form = form;
        }

        public void Start()
        {
            //client = new TcpClient("192.168.25.126", 5000);
            //client = new TcpClient("192.168.25.126", 5000);
            client = new TcpClient(IPAddress, 5000);
            //client = new TcpClient("192.168.25.116", 5000);Veronica
            //client = new TcpClient("192.168.25.126", 5000); //Niklas L

            Thread listenerThread = new Thread(Listen);
            listenerThread.Start();

            //Thread senderThread = new Thread(Send);
            //senderThread.Start();

            //senderThread.Join();

            //listenerThread.Join();
        }

        public void Listen()
        {
            string message = "";

            while (true)
            {
                try
                {
                    NetworkStream n = client.GetStream();
                    message = new BinaryReader(n).ReadString();

                    //Form.listBoxChat.Items.Add(message);

                    var deserialized = JsonConvert.DeserializeObject<Protocoll>(message);

                    if (deserialized.MessageType == ClassLibrary.ProtocolType.ListUsers)
                    {
                        string[] Users = deserialized.Content.Split(';');
                        Form.listBoxUsers.Items.Clear();
                        foreach (var user in Users)
                        {
                            
                            Form.listBoxUsers.Items.Add(user);
                        }
                        Form.listBoxUsers.SelectedIndex = 0;
                    }
                    else if (deserialized.MessageType == ClassLibrary.ProtocolType.Message)
                    {
                        Form.listBoxChat.Items.Add($"{deserialized.Sender}: {deserialized.Content}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        //För att skicka meddelande:
        public void Send(string message)
        {
            //string message = "";

            try
            {
                //while (!message.Equals("quit"))
                //{
                NetworkStream n = client.GetStream();

                //message = Console.ReadLine();

                BinaryWriter w = new BinaryWriter(n);
                w.Write(message);
                w.Flush();
                //}

                //client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
