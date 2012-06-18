using System.Collections.Generic;
using System.Linq;
using i18nEntities;

namespace i18nManager.DataAccess
{


    public class ProjectRepository : BaseRepository
    {

        public ProjectRepository()
        {
            _context = GetContext();
        }

        public static IEnumerable<project> GetAllProjects()
        {
            _context = GetContext();
            var projectList = from p in _context.projects select p;
            return projectList;
        }

        public static int SaveProject(project project)
        {
            _context = GetContext();
            _context.projects.AddObject(project);
            return _context.SaveChanges();
        }

        public static project FindById(int id)
        {
            var project = (from p in _context.projects where p.id == id select p).FirstOrDefault();
            return project;
        }

        public static void DeleteProject(int id)
        {
            var project = (from p in _context.projects where p.id == id select p).FirstOrDefault();
            _context.projects.DeleteObject(project);
            _context.SaveChanges();
        }



        public static int Update(int id, string name, string outputdir, string outputfilename)
        {
            var project = (from p in _context.projects where p.id == id select p).FirstOrDefault();

            if (project != null)
            {
                project.name = name;
                project.outputdir = outputdir;
                project.outputfilename = outputfilename;
                _context.SaveChanges();
            }
            return 0;
        }

    }
}