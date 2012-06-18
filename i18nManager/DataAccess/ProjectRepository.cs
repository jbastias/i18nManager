using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using i18nEntities;

namespace i18nManager.DataAccess
{
    public class ProjectRepository
    {

        public static ResourceStringManagerEntities GetContext()
        {
            return new ResourceStringManagerEntities();
        }

        public static IEnumerable<project> GetAllProjects()
        {
            var context = GetContext();
            var projectList = from p in context.projects select p;
            return projectList;

            /*

            var ResxElements = from ls in context.LanguageStrings
                               where ls.lang == "zh-CHS"
                               select new ResxStringManager.Models.ResourceElement
                               {
                                   Name = ls.name,
                                   Content = ls.value,
                                   FileName = ls.fileName,
                                   Language = ls.lang
                               };
            
             * 
             */

        }

        public static int SaveProject(project project)
        {
            var context = GetContext();
            context.projects.AddObject(project);
            return context.SaveChanges();
        }

        public static project FindById(int id)
        {
            var context = GetContext();
            var project = (from p in context.projects where p.id == id select p).FirstOrDefault();
            return project;
        }

        public static void DeleteProject(int id)
        {
            var context = GetContext();
            var project = (from p in context.projects where p.id == id select p).FirstOrDefault();
            context.projects.DeleteObject(project);
            context.SaveChanges();
        }



        public static int Update(int id, string name, string outputdir, string outputfilename)
        {

            var context = GetContext();
            var project = (from p in context.projects where p.id == id select p).FirstOrDefault();

            if(project != null)
            {
                project.name = name;
                project.outputdir = outputdir;
                project.outputfilename = outputfilename;
                context.SaveChanges();

                
            }

            return 0;




        }
 


        public static int Update(project project)
        {
            var context = GetContext();
//            var project = (from p in context.projects where p.id == id select p).FirstOrDefault();
            // context.projects.AddObject(project);
            int returnVal = context.SaveChanges();
            return returnVal;

        }
    }
}