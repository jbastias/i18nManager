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

        public static int CreateProjectResx(int projectId, string resxName)
        {
            var resx = new resxItem { project_id = projectId, resourcekey = resxName };
            var proj = (from p in _context.projects where p.id == projectId select p).SingleOrDefault();
            proj.resxItems.Add(resx);
            return _context.SaveChanges();
        }

    }
}