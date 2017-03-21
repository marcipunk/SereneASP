

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Cobra Demo/Tax Years", typeof(SereneASP.Cobrademo.Pages.TaxYearController))]

namespace SereneASP.Cobrademo.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("cobrademo/TaxYear"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.TaxYearRow))]
    public class TaxYearController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Cobrademo/TaxYear/TaxYearIndex.cshtml");
        }
    }
}