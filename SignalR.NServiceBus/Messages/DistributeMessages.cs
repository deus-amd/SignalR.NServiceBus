﻿using Microsoft.AspNet.SignalR.Messaging;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SignalR.NServiceBus.Messages
{
    /// <summary>
    /// Command that instructs the backplane to distribute the payload to all SignalR nodes.
    /// </summary>
    public class DistributeMessages: ICommand
    {
        /// <summary>
        /// The payload consisting of a serialized IList of SignalR messages.
        /// </summary>
        public string Payload { get; set; }
    }
}
