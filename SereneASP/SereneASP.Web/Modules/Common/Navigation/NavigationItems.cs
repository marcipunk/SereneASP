using Serenity.Navigation;
using Administration = SereneASP.Administration.Pages;
using Cobrademo = SereneASP.Cobrademo.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "icon-speedometer")]

[assembly: NavigationMenu(2000, "Cobra Demo", icon: "fa-chevron-circle-down")]
[assembly: NavigationLink(2100, "Cobra Demo/Account Codes",
typeof(Cobrademo.AccountController), icon: "fa-money")]