using System.Web;
using System.Web.Mvc;

namespace PhamTuanPhong_KiemTraFe
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
