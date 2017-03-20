

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Cobrademo/Account", typeof(SereneASP.Cobrademo.Pages.AccountController))]

namespace SereneASP.Cobrademo.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Cobrademo/Account"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.AccountRow))]
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Cobrademo/Account/AccountIndex.cshtml");
        }
    }
}