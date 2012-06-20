using System.Web.Mvc;
using i18nEntities;
using i18nManager.DataAccess;

namespace i18nManager.Controllers
{
    public class ProjectController : Controller
    {
        [HttpGet]
        public ActionResult List()
        {
            var projects  = ProjectRepository.GetAllProjects();
            return View(projects);
        }

        [HttpGet]
        public ActionResult New()
        {
            ViewBag.Languages = Utils.LangUtils.GetLanguageList() ;
            return View();
        }

        [HttpPost]
        public ActionResult Create(string name, string outputdir, string outputfilename, string[] mylanguages)
        {
            var project = new project {name = name, outputdir = outputdir, outputfilename = outputfilename };
            ProjectRepository.SaveProject(project);
            LanguageRepository.CreateProjectLanguages(project.id, mylanguages);
            return Content("saved");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Languages = Utils.LangUtils.GetLanguageList();            
            var project = ProjectRepository.FindById(id);
            return View(project);
        }

        [HttpPost]
        public ActionResult Update(int id, string name, string outputdir, string outputfilename, string[] mylanguages)
        {
            ProjectRepository.Update(id, name, outputdir, outputfilename);
            LanguageRepository.UpdateProjectLanguages(id, mylanguages);
            return Content(string.Format("updated: {0}", id));
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            ProjectRepository.DeleteProject(id);
            return Content(string.Format("deleted - {0}", id));
        }

    }
}
