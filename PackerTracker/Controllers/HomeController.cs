using Microsoft.AspNetCore.Mvc;

namespace Items.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View("Index");
    }
  }
}