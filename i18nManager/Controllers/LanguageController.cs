using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace i18nManager.Controllers
{
    public class LanguageController : Controller
    {
        //
        // GET: /Language/

        [HttpGet]
        public ActionResult List(int projectId)
        {
            return View();
        }


/*        [HttpPost, HttpGet]
  
 */
        [HttpGet]
        public ActionResult New(int projectId)
        {
            return null;
        }

        [HttpGet]
        public ActionResult Delete(int projectId, int languageId)
        {
            return null;
        }


    }
}
