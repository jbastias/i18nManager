using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace i18nManager.Utils
{
    public class LangUtils

    {
        private static SortedList<string, string> CreateLanguageList()
        {
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            var sortedLangs = new SortedList<string, string>();

            foreach (var lang in cultures)
            {
                sortedLangs.Add(lang.Name, lang.DisplayName);
                System.Diagnostics.Debug.WriteLine("{0} - {1}", lang.Name, lang.DisplayName);
            }
            return sortedLangs;
        }


        public static SortedList<string, string> GetLanguageList()
        {
            var langs = CreateLanguageList();
            langs.RemoveAt(0);
            return langs;
        }


    }
}