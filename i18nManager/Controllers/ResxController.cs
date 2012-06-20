using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using i18nManager.DataAccess;

namespace i18nManager.Controllers
{
    public class ResxController : Controller
    {

        public ActionResult List(int projectId)
        {


            return View();
        }



        public ActionResult EditResourceStrings(int projectId)
        {
            ViewData["pid"] = projectId;
//            ViewBag.projectId = projectId.ToString();
            return View();
        }

        [HttpPost]
        public ActionResult NewResx(int projectId, string resxName)
        {
            var newId = ResxRepository.CreateProjectResx(projectId, resxName);


            return Content("xxxxxxx");
        }



    }
}
