

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Cobrademo/AccountSheetCore", typeof(SereneASP.Cobrademo.Pages.AccountSheetCoreController))]

namespace SereneASP.Cobrademo.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Cobrademo/AccountSheetCore"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.AccountSheetCoreRow))]
    public class AccountSheetCoreController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Cobrademo/AccountSheetCore/AccountSheetCoreIndex.cshtml");
        }
    }
}