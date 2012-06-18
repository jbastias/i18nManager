using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//using i18nEntities;

using i18nEntities;

namespace i18nManager.DataAccess
{

    public class LanguageRepository : BaseRepository
    {
        public static IEnumerable<lang> GetAllProjectLanagues(int projectId)
        {
            var languages = from l in _context.langs where l.project_id == projectId select l;
            return languages;
        }

        public static int CreateProjectLanguages(int projectId, string[] languages)
        {
            foreach (var code in languages)
            {
                var lang = new lang {project_id = projectId, code = code};
                _context.langs.AddObject(lang);

            }
            return _context.SaveChanges();
        }

    }
}