

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Cobra Demo/Account's Names", typeof(SereneASP.Cobrademo.Pages.AccountNameController))]

namespace SereneASP.Cobrademo.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("cobrademo/AccountName"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.AccountNameRow))]
    public class AccountNameController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Cobrademo/AccountName/AccountNameIndex.cshtml");
        }
    }
}