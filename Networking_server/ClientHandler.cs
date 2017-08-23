using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ClassLibrary;

namespace Networking_server
{
    public class ClientHandler
    {
        public string UserName;
        public TcpClient tcpclient;
        private Server myServer;

        public ClientHandler(TcpClient c, Server server, string username)
        {
            tcpclient = c;
            this.myServer = server;
            UserName = username;
        }

        public void Run()
        {
            try
            {
                string message = "";
                while (UserName == "test")
                {
                    NetworkStream n = tcpclient.GetStream();
                    message = new BinaryReader(n).ReadString();

                    var deserialized = JsonConvert.DeserializeObject<Protocoll>(message);
                    

                    if (deserialized.MessageType == ClassLibrary.ProtocolType.UserName)
                    {
                        if (myServer.UserNameOk(deserialized.Sender))
                        {
                            this.UserName = deserialized.Sender;
                            myServer.AddClient(this);
                            //Todo: Skriv till chattboxen att någon kom med
                            //Todo: uppdatera listboxen?? varje gång något händer
                           
                            break;
                        }
                        else
                        {
                            Protocoll errorProtocoll = new Protocoll();
                            errorProtocoll.MessageType = ClassLibrary.ProtocolType.ErrorMessage;
                            errorProtocoll.Content = "Username is already taken.";

                            Send(JsonConvert.SerializeObject(errorProtocoll.Content));
                        }
                    }

                    myServer.Broadcast(this, message, UserName);
                    //Console.WriteLine(message);
                }

                message = "";
                while (message != "quit")
                {
                    NetworkStream n = tcpclient.GetStream();
                    message = new BinaryReader(n).ReadString();

                    var deserialized = JsonConvert.DeserializeObject<Protocoll>(message);


                    if (deserialized.MessageType == ClassLibrary.ProtocolType.Message)
                    {
                        myServer.Broadcast(this, message, deserialized.Sender);
                    }
                }

                myServer.DisconnectClient(this);
                tcpclient.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Send(string v)
        {
            NetworkStream n = tcpclient.GetStream();
            BinaryWriter w = new BinaryWriter(n);

            w.Write(v);
            w.Flush();
        }
    }
}
