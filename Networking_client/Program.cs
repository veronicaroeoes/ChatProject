﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary;

namespace Networking_client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client myClient = new Client();

            Thread clientThread = new Thread(myClient.Start);
            clientThread.Start();
            clientThread.Join();
        }

        public class Client
        {
            private TcpClient client;

            public void Start()
            {
                //client = new TcpClient("192.168.25.126", 5000);
                //client = new TcpClient("192.168.25.126", 5000);
                //client = new TcpClient("192.168.25.116", 5000); //Veronica
                client = new TcpClient("192.168.25.126", 5000); //Niklas L

                Thread listenerThread = new Thread(Send);
                listenerThread.Start();

                Thread senderThread = new Thread(Listen);
                senderThread.Start();

                senderThread.Join();
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
                        Console.WriteLine("Other: " + message);                       
                    }                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            public void Send()
            {
                string message = "";

                try
                {
                    while (!message.Equals("quit"))
                    {
                        NetworkStream n = client.GetStream();

       
    }
}
