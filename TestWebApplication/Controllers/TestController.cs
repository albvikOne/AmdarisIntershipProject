using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWebApplication.Controllers
{
    public class TestController : Controller
    {
        // GET: /Test/
        public string Index()
        {
            return "This is my <i> test</i> action..";
        }

        //Get /Test/Welcome

        public string Welcome()
        {
            return "This is the welcome mthod :D";
        }
      
    }
}