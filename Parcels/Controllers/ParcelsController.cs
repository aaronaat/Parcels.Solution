using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/parcels")]
    public ActionResult Index()
    {

      return View();
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateParcel()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(int length, int width, int height, int weight)
    {
      Parcel myItem = new Parcel(length,width,height,weight);
      return View("Index", myItem);
    }

  }
}
