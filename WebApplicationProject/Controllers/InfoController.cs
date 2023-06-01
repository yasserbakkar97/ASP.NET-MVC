using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationProject.Models;

namespace WebApplicationProject.Controllers
{
    public class InfoController : Controller
    {
        // GET: Info
        Context db = new Context();
        public ActionResult Index()
        {
            List<Info> infoList = db.Infos.ToList();
            return View(infoList);
        }
    }
}