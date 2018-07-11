using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bot.Distributed.TestApi.Models
{
    public class Response<TData>
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public string Trace { get; set; }
        public TData Data { get; set; }

        public Response()
        {

        }

        public Response(TData data)
        {
            Status = true;
            Message = string.Empty;
            Trace = string.Empty;
            Data = data;
        }

        public Response(string asMensaje, string asTraza)
        {
            Status = false;
            Message = asMensaje;
            Trace = asTraza;
            Data = default(TData);
        }
    }
}