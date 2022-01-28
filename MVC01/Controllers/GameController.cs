using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC01.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public string Index()
        {
            return "This is Game Controlle.";
        }

        public string Names(string fname, string lname)
        {
            return "Firstname : " + fname +" "+ "Lastname : " + lname;
        }
    }
}