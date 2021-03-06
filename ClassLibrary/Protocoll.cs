﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum ErrorType
    {
        UserNameTaken,
        UserNameToShort,
        Other,
        NoError
    }

    public enum ProtocolType
    {
        ListUsers,
        Message,
        PrivateMessage,
        UserName,
        ErrorMessage,
        DeleteClient
    }
    public class Protocoll
    {
        public ProtocolType MessageType { get; set; }
        public ErrorType ErrorType { get; set; } = ErrorType.Other;
        public string Content { get; set; }
        public string Version { get; set; } = "1.0";
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public DateTime DateTime { get; set; }
    }
}
