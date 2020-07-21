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
      List<Parcels> allParcels = Parcels.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpGet("/parcels")]
    public ActionResult Create(int width, int height, int depth)
    {
      Parcels myParcel = new Parcels (width, height, depth);
      return RedirectToAction("Index");
    }
  }
}