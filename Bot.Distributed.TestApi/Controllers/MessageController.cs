using Bot.Application.Service.MessageTest;
using Bot.Distributed.TestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bot.Distributed.TestApi.Controllers
{
    [RoutePrefix("api/message")]
    public class MessageController : BaseApiController
    {

        private string _accessToken = "EAADTPsw1mMsBAH13deGJpzvUu59EXB0QCh3ZCNaEiLkJPO8rY7ZA7Fe3MOjvp9aUvZAbFbHoKfq8b7diNMA92wAAtgK1qH7LvGEEJOcpNzkDNIukUgOklQzThNwggOW9SLvfCeNrc9EfPYR2o8AQcY4JZA0c6mx45sZBvzLxNO6fln81Jmrw5";
        private MessageService _messageService;

        public MessageController()
        {
            _messageService = new MessageService(_accessToken);
        }

        [HttpGet, Route(Predeterminado)]
        public Response<string> Get()
        {
            return Ejecutar(() =>
            {
                return new Response<string>("Hello World!");
            });
        }

        [HttpPost, Route(Predeterminado)]
        public Response<bool> Post(MessageRequest message)
        {
            return Ejecutar(() =>
            {
                return new Response<bool>(_messageService.Send(message.Message, ""));
            });
        }
    }
}
