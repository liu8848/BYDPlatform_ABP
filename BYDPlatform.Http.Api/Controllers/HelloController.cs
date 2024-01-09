using BYDPlatform.Domain.Shared.Localization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace BYDPlatform.Http.Api.Controllers;

[Route("Hello")]
[ApiController]
public class HelloController:AbpController
{
    
    [HttpGet("index")]
    public ActionResult<string> Index()
    {
        return "hello";
    }
}