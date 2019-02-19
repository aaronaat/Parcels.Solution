using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      Parcel starterItem = new Parcel(4, 4, 4, 4);
      return View(starterItem);
    }

  }
}
