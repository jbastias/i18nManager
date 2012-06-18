using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace i18nManager.Controllers
{
    public class ResxController : Controller
    {
        //
        // GET: /Resx/


        public ActionResult List(int projectId)
        {


            return View();
        }



        public ActionResult ListLang(int projectId, int languageId)
        {
            return null;
        }

    }
}
