using Bot.Helpers.FacebookMessengerApi;
using Bot.Helpers.FacebookMessengerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Application.Service.MessageTest
{
    public class MessageService
    {
        private string _accessToken = "";
        private MessageManager _messageManager;

        public MessageService(string accessToken)
        {
            _accessToken = accessToken;
        }

        public bool Send(string message, string id)
        {
            _messageManager = new MessageManager(_accessToken);
            return _messageManager.SendText(SendApiMessage.CreateMessageText(message, id));
        }
    }
}
