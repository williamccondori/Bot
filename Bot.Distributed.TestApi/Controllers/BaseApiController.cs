using Bot.Distributed.TestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Bot.Distributed.TestApi.Controllers
{
    public class BaseApiController : ApiController
    {
        public const string Predeterminado = "";

        protected Response<T> Ejecutar<T>(Func<Response<T>> funcion)
        {
            try
            {
                return funcion();
            }
            catch (ApplicationException excepcion)
            {
                return new Response<T>(excepcion.Message, excepcion.StackTrace);
            }
            catch (Exception excepcion)
            {
                return new Response<T>(excepcion.Message, excepcion.StackTrace);
            }
        }
    }
}