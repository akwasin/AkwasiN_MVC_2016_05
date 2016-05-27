using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AkwasiN_MVC_2016_05.Controllers
{
    public class SpriteController : Controller
    {
        // GET: Sprite
        public ActionResult Index()
        {
            ViewBag.Message = "This is the index page where you arrive at when you enter the URL localhost:14302/Sprite. I opted for the easy option by using the Index page. Chaning the action on row 25 from Index to Hexa in RouteConfig.cs in App_Start folder changes the routing from sprite/index.cshtml to sprite/hexa.cshtml when you enter localhost:14302/Sprite as URL ";
            return View();
        }

        public ActionResult Hexa()
        {
            return View();
        }

        public ActionResult Octa()
        {
            return View();
        }
    }
}