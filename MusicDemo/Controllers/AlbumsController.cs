using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicDemo.Controllers
{
    public class AlbumsController : Controller
    {
        //
        // GET: /Albums/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Albums/Details/5

        public ActionResult Details(int id)
        {
            ViewBag.AlbumId = id;
            return View();
        }

        
    }
}
