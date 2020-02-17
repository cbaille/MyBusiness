using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MyBusiness.Controllers;

namespace MyBusiness.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyBusinessControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
