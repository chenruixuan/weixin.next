﻿using System.Threading.Tasks;
using Weixin.Next.Messaging.Requests;
using Weixin.Next.Messaging.Responses;

namespace Weixin.Next.Messaging
{
    public interface IMessageHandler
    {
        Task<ResponseMessage> Handle(RequestMessage message);
    }
}