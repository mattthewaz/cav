using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cav.Code
{
    /// <summary>
    /// Summary description for LobbyHandler
    /// </summary>
    public class LobbyHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}