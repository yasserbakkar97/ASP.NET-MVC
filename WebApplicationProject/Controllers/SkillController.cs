using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationProject.Models;

namespace WebApplicationProject.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        Context db = new Context();
        public ActionResult Index()
        {
           List<Skill> skillList =  db.Skills.ToList();
           List<Info> infoList =  db.Infos.ToList();

            MyModelWrapper model = new MyModelWrapper
            {
                Skills = skillList,
                Infos = infoList
            };

            return View(model);
        }
    }
}