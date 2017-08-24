using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ClassLibrary;
using System.Windows.Forms;

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


                    ErrorType errorType = myServer.UserNameOk(deserialized.Sender);

                    if (errorType == ErrorType.NoError)
                    {
                        this.UserName = deserialized.Sender;
                        myServer.AddClient(this);
                        //Todo: Skriv till chattboxen att någon kom med

                        //myServer.Broadcast(this, message, UserName);

                        break;

                    }
                    else
                    {
                        Protocoll errorProtocoll = new Protocoll();
                        errorProtocoll.MessageType = ClassLibrary.ProtocolType.ErrorMessage;
                        errorProtocoll.ErrorType = errorType;

                        switch (errorType)
                        {
                            case ErrorType.UserNameTaken:
                                errorProtocoll.Content = "Username is already taken.";
                                break;
                            case ErrorType.UserNameToShort:
                                errorProtocoll.Content = "Username too short.";
                                break;
                            default:
                                errorProtocoll.Content = "Try again.";
                                break;
                        }

                        var packed = JsonConvert.SerializeObject(errorProtocoll);

                        Send(packed);
                    }
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
                    else if (deserialized.MessageType == ClassLibrary.ProtocolType.PrivateMessage)
                    {
                        myServer.SendPM(this, message, deserialized.Sender, deserialized.Receiver);
                        //myServer.Broadcast(this, )
                    }
                    else if (deserialized.MessageType == ClassLibrary.ProtocolType.DeleteClient)
                    {
                        message = "quit";
                    }
                }

                myServer.DisconnectClient(this); // Path c
                tcpclient.Close(); // stream.... 
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
