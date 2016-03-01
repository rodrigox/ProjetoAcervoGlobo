using System.Web.Mvc;

namespace AcervoGlobo.Web.Areas.AreaTeste
{
    public class AreaTesteAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AreaTeste";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AreaTeste_default",
                "AreaTeste/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}