using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using Newtonsoft.Json;

namespace Networking_server
{
    public class Server
    {
        List<ClientHandler> clients = new List<ClientHandler>();

        public void Run()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 5000);
            Console.WriteLine("Server up and running, waiting for messages...");

            try
            {
                listener.Start();

                while (true)
                {
                    TcpClient c = listener.AcceptTcpClient();
                    ClientHandler newClient = new ClientHandler(c, this, "test");
                    //clients.Add(newClient);
                    Console.WriteLine("New connection");
                    

                    Thread clientThread = new Thread(newClient.Run);
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (listener != null)
                    listener.Stop();
            }
        }

        internal void AddClient(ClientHandler clientHandler)
        {
            clients.Add(clientHandler);

            string tmp = "Public";

            foreach (ClientHandler client in clients)
            {
                tmp += ";" + client.UserName;
            }

            Protocoll listOfUsers = new Protocoll();
            listOfUsers.MessageType = ClassLibrary.ProtocolType.ListUsers;
            listOfUsers.Content = tmp;
            listOfUsers.Sender = clientHandler.UserName;

            string jsonmessage = JsonConvert.SerializeObject(listOfUsers);

            Broadcast(clientHandler, jsonmessage, clientHandler.UserName);

        }

        internal bool UserNameOk(string sender)
        {
            if (sender == "Public" || sender.Length < 1)
            {
                return false;
            }

            return clients.FindAll(x => x.UserName == sender).Count == 0;

            //if (sender == "Public" || clients.FindAll(x => x.UserName == sender).Count == 0)
            //{
            //    return ErrorType.UserNameTaken;
            //}

            //else if (sender.Length < 1)
            //{
            //    return ErrorType.UserNameToShort;
            //}

            //return ErrorType.Other;
        }

        public void Broadcast(ClientHandler client, string jsonmessage, string user)
        {
            
            foreach (ClientHandler tmpClient in clients)
            {
                NetworkStream n = tmpClient.tcpclient.GetStream();
                BinaryWriter w = new BinaryWriter(n);

                w.Write(jsonmessage);
                w.Flush();
            }
        }

        public void DisconnectClient(ClientHandler client)
        {
            clients.Remove(client);
            Console.WriteLine("Client X has left the building...");
            Broadcast(client, "Client X has left the building...", client.UserName);
        }

        internal void SendPM(ClientHandler clientHandler, string message, string sender, string receiver)
        {
            var result = clients
                .FirstOrDefault(c => c.UserName == receiver);

            NetworkStream n1 = result.tcpclient.GetStream();
            BinaryWriter w1 = new BinaryWriter(n1);
            w1.Write(message);
            w1.Flush();


            NetworkStream n = clientHandler.tcpclient.GetStream();
            BinaryWriter w = new BinaryWriter(n);
            w.Write(message);
            w.Flush();

        }
    }
}
