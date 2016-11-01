using System.Web;
using System.Web.Mvc;

namespace visualStudio2015_angular_quickstart {
    public class FilterConfig {
        public static void RegisterGlobalFilters( GlobalFilterCollection filters ) {
            filters.Add( new HandleErrorAttribute( ) );
        }
    }
}
