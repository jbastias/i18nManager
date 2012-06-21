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

        [HttpGet]
        public ActionResult List(int projectId)
        {
            return View();
        }


        [HttpGet]
        public ActionResult EditResourceStrings(int projectId)
        {
            var proj = ProjectRepository.FindById(projectId);
            return View(proj);
        }

        [HttpPost]
        public ActionResult NewResx(int projectId, string resxName)
        {
            var newResxItem = ResxRepository.CreateProjectResx(projectId, resxName);
            ResxRepository.CreateProjectResxStrings(projectId, newResxItem.id);

            var obj = new {id = newResxItem.id, resourcekey = newResxItem.resourcekey, stringData = new {}};
            foreach (var data in newResxItem.stringDatas)
            {
                //obj.stringData.                 
            }

            return Json( obj );
            //Json(new { id = newResxItem.id, resourcekey = newResxItem.resourcekey, stringData = new {xxxx = "me se solly"} });
            // return Content(string.Format("saved: {0}", newResxItem.id));
        }



    }
}
