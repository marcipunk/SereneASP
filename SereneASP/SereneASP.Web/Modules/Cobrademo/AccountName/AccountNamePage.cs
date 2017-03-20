

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Cobrademo/AccountName", typeof(SereneASP.Cobrademo.Pages.AccountNameController))]

namespace SereneASP.Cobrademo.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Cobrademo/AccountName"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.AccountNameRow))]
    public class AccountNameController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Cobrademo/AccountName/AccountNameIndex.cshtml");
        }
    }
}