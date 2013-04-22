using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment4.Controllers
{
    public class FireCodeController : ApiController
    {

        const string TRUEFIRECODE = "AZ035T29Z1984";

        public string Get(string fireCode)
        {
            if (fireCode == TRUEFIRECODE)
            {
                return "AUTHENTICATED";
            }

            return "DRILL";
        }
    }
}
