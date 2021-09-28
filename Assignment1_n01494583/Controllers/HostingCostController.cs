using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01494583.Controllers
{
    public class HostingCostController : ApiController
    {
        public string Get(int id)
        {
            int numberFortnights = (id/14)+1;
            double cost = numberFortnights * 5.50;
            cost = Math.Round(cost, 2);
            double hst = cost * 0.13;
            hst = Math.Round(hst, 2);
            double total = cost + hst;
            total = Math.Round(total, 2);
            string message = numberFortnights + " fortnights at $5.50/FN = $" + cost + " CAD" + " | HST 13% = $" + hst + " CAD" + " |Total = $" + total + " CAD";
            return message;

        }
    }
}
