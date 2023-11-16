using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
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

    [HttpGet("/pet/{id}")]
    public ActionResult Show(int id)
    {
      Pet foundPet = Pet.Find(id);
      return View(foundPet);
    }

    [HttpPost("/pet/{id}/food")]
    public ActionResult FoodPatch(int id)
    {
      Pet.FeedPet(id);
      Pet.TimePassage();
      Pet.PetDeathCheck();
      return RedirectToAction("Show", new{id = id});
    }

    [HttpPost("/pet/{id}/rest")]
    public ActionResult RestPatch(int id)
    {
      Pet.RestPet(id);
      Pet.TimePassage();
      Pet.PetDeathCheck();
      return RedirectToAction("Show", new{id = id});
    }

    [HttpPost("/pet/{id}/play")]
    public ActionResult PlayPatch(int id)
    {
      Pet.AttentionPet(id);
      Pet.TimePassage();
      Pet.PetDeathCheck();
      return RedirectToAction("Show", new{id = id});
    }
  }
}