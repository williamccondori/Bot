using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Helpers.FacebookMessengerApi.Models
{
    public class Message
    {
        public string text { get; set; }

        public Message()
        {

        }

        public Message(string text)
        {
            this.text = text;
        }
    }

    public class Recipient
    {
        public Recipient()
        {

        }

        public Recipient(string id)
        {
            this.id = id;
        }

        public string id { get; set; }
    }

    public class SendApiMessage
    {
        public SendApiMessage()
        {

        }

        public static SendApiMessage CreateMessageText(string message, string id)
        {
            return new SendApiMessage
            {
                messaging_type = "UPDATE",
                recipient = new Recipient(id),
                message  =new Message(message)
            };
        }

        public string messaging_type { get; set; }
        public Recipient recipient { get; set; }
        public Message message { get; set; }
    }
}
