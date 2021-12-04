using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class DemoController : ApiController
    {
        /*public string Get()
        {
            return "Welcome to my WEB API";
        }*/
       public List<string> Get()
        {
            List<string> elist = new List<string>();
                elist.Add("data1");
            elist.Add("data2");
            return elist;
        }
    }
}
