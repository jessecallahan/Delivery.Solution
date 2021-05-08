using Microsoft.AspNetCore.Mvc;

namespace Delivery.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}