using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using i18nEntities;

namespace i18nManager.DataAccess
{

    public class ResxRepository : BaseRepository
    {
        public static IEnumerable<resxItem> GetAllProjectResx(int projectId)
        {
            var resx = from r in _context.resxItems where r.project_id == projectId select r;
            return resx;
        }

        public static int UpdateProjectLanguages(int projectId, string[] languages)
        {
            return 0;
        }

        public static resxItem CreateProjectResx(int projectId, string resxName)
        {
            var resx = new resxItem { project_id = projectId, resourcekey = resxName };
            var proj = (from p in _context.projects where p.id == projectId select p).SingleOrDefault();
            if (proj != null) proj.resxItems.Add(resx);
            _context.SaveChanges();
            return resx;
        }


        public static void CreateProjectResxStrings(int projectId, int resxId)
        {
            var proj = (from p in  _context.projects where p.id == projectId select p).SingleOrDefault();
            if (proj == null) return;
            var resx = (from r in _context.resxItems where r.id == resxId select r).SingleOrDefault();
            if (resx == null) return;
            foreach (var lang in proj.langs )
            {
                var resxString = new stringData {lang_id = lang.id, resxItem_id = resxId};
                resx.stringDatas.Add(resxString);
            }
            _context.SaveChanges();
        }



        public static int DeleteResx(string resxId)
        {
            return _context.SaveChanges();
        }




    }
}