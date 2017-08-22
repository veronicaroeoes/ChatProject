using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum ProtocolType
    {
        ListUsers,
        Message,
        PrivateMessage
    }
    public class Protocoll
    {
        public ProtocolType MessageType { get; set; }
        public string Content { get; set; }
        public string Version { get; set; } = "1.0";
        public string Sender { get; set; }
        public string Receiver { get; set; }


        // prop command
        // prop användarid
        // prop mottagarid (om privat meddelande) 

    }
}
