﻿using Microsoft.AspNet.SignalR.Messaging;
using SignalR.NServiceBus.Messages;
using Newtonsoft.Json;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SignalR.NServiceBus.Endpoint
{
    /// <summary>
    /// This handler will receive messages from the backplane and hand them off to SignalR.
    /// </summary>
    public class Receiver: IHandleMessages<MessagesAvailable>
    {
        public NServiceBusMessageBus SignalRMessageBus { get; set; }

        public void Handle(MessagesAvailable message)
        {
            var messages = ScaleoutMessage.FromBytes(message.Payload);

            if (SignalRMessageBus != null)
            {
                SignalRMessageBus.OnReceived(message.StreamIndex, message.PayloadId, messages);
            }
        }
    }
}
