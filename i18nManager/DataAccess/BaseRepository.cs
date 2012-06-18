using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using i18nEntities;

namespace i18nManager.DataAccess
{

    public class BaseRepository
    {
        public BaseRepository()
        {
            GetContext();
        }

        protected static ResourceStringManagerEntities _context;        

        public static ResourceStringManagerEntities GetContext()
        {
            if (_context == null)
            {
                _context = new ResourceStringManagerEntities();
            }
            return _context;
        }
    }
}