﻿using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.NServiceBus.Messages
{
    /// <summary>
    /// Published when the backplane receives a set of SignalR messages that must be distributed.
    /// </summary>
    public class MessagesAvailable: IEvent
    {
        /// <summary>
        /// Unique payload Id
        /// </summary>
        public ulong PayloadId { get; set; }

        /// <summary>
        /// Serialized IList of Messages
        /// </summary>
        public string Payload { get; set; }
    }
}
