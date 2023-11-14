using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class PetController : Controller
  {
    [HttpGet("/pet/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/pet")]
    public ActionResult Create(string petName)
    {
      Pet newTamagotchi = new Pet(petName);
      return RedirectToAction("Index");
    }

    [HttpGet("/pet")]
    public ActionResult Index()
    {
      List<Pet> allTamagotchi = Pet.GetAll();
      return View(allTamagotchi);
    }
  }
}