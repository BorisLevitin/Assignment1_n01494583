using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01494583.Controllers
{
    public class GreetingController : ApiController
    {
            public string Get(int id)
            {
            string message = "Greeting to " + id + " people!";
            return message;
            }
        public string Post()
            {

                return "Hello World";
            }


    }
}
