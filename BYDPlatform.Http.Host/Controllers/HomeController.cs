using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace BYDPlatform.Http.Host.Controllers;

public class HomeController:AbpController
{
    public ActionResult Index()
    {
        return Redirect("~/swagger");
    }
}