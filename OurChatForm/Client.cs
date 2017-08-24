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
            

            // Är IP-adressen valid? Om inte, backa!
            try
            {
                client = new TcpClient(IPAddress, 5000);
                Thread listenerThread = new Thread(Listen);
                listenerThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("IP-adress is invalid. Check it again by typing 'ipconfig' and hitting enter in the terminal.");
            }


        }

        public void Listen()
        {
            string message = "";

            while (client.Connected)
            {
                try
                {
                    NetworkStream n = client.GetStream();
                    message = new BinaryReader(n).ReadString();

                    //Form.listBoxChat.Items.Add(message);

                    var deserialized = JsonConvert.DeserializeObject<Protocoll>(message);

                    if (deserialized.MessageType == ClassLibrary.ProtocolType.ListUsers)
                    {
                        string[] users = deserialized.Content.Split(';');
                        string[] users2 = new string[Form.listBoxUsers.Items.Count];
                        Form.listBoxUsers.Items.CopyTo(users2, 0);

                        WriteUserEvent(users, users2);

                        Form.listBoxUsers.Items.Clear();
                        foreach (var user in users)
                        {
                            Form.listBoxUsers.Items.Add(user);
                        }

                        //Form.listBoxUsers.SelectedIndex = 0;
                    }

                    else if (deserialized.MessageType == ClassLibrary.ProtocolType.Message)
                    {
                        Form.listBoxChat.Items.Add($"{deserialized.Sender} to {deserialized.Receiver}: {deserialized.Content}");
                    }

                    else if (deserialized.MessageType == ClassLibrary.ProtocolType.ErrorMessage)
                    {
                        if (deserialized.ErrorType == ClassLibrary.ErrorType.UserNameTaken || deserialized.ErrorType == ClassLibrary.ErrorType.UserNameToShort)
                        {
                            Form.setTextBoxes(true);
                        }
                        if (client.Connected)
                        {
                            MessageBox.Show(deserialized.Content);
                        }
                    }

                    else if (deserialized.MessageType == ClassLibrary.ProtocolType.PrivateMessage)
                    {
                        Form.listBoxChat.Items.Add($"{deserialized.Sender} to {deserialized.Receiver}: {deserialized.Content}");
                    }

                    else if (deserialized.MessageType == ClassLibrary.ProtocolType.DeleteClient)
                    {
                        break;
                    }
                }

                catch (Exception ex)
                {
                    if (client.Connected)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }
        }

        public void WriteUserEvent(string[] users, string[] users2)
        {
            if (users.Length > Form.listBoxUsers.Items.Count)
            {
                // Då har en användare lagts till
                foreach (var user in users.Except(users2))
                {
                    Form.listBoxChat.Items.Add($"User {user} joined the chat");
                }
            }
            else if (users.Length < Form.listBoxUsers.Items.Count)
            {
                //Då har någon gått ur
                foreach (var result in users2.Except(users))
                {
                    Form.listBoxChat.Items.Add($"User {result} left the chat");
                }
            }
        }

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
        public void DisconnectMe()
        {
            client.Close();
        }
    }
}
