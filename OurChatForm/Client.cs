﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;

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
            client = new TcpClient(IPAddress, 5000); //Veronica
                                                            //client = new TcpClient("192.168.25.126", 5000); //Niklas L
                                                            //todo: Gör startsida där användaren får fylla i ip-adress att koppla upp mot

            Thread listenerThread = new Thread(Listen);
            listenerThread.Start();

            //Thread senderThread = new Thread(Send);
            //senderThread.Start();

            //senderThread.Join();

            listenerThread.Join();
        }

        public void Listen()
        {
            string message = "";

            try
            {
                while (true)
                {
                    NetworkStream n = client.GetStream();
                    message = new BinaryReader(n).ReadString();
                //Console.WriteLine("Other: " + message);

                Form.listBoxChat.Items.Add(message);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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