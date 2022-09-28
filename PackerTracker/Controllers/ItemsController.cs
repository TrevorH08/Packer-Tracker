using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/items/zombie")]
    public ActionResult ZombieIndex()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/zombie/new")]
    public ActionResult ZombieNew()
    {
      return View();
    }

    [HttpPost("/items/zombie")]
    public ActionResult ZombieCreate(string name, float cost, float weight, bool necessity, string type, bool purchased)
    {
      Item myItem = new Item(name, cost, weight, necessity, type, purchased);
      return RedirectToAction("ZombieIndex");
    }

    [HttpPost("/items/zombie/delete")]
    public ActionResult ZombieDeleteAll()
    {
      Item.ClearAll();
      return View();
    }

    [HttpGet("/items/zombie/{id}")]
    public ActionResult ZombieShow(int id)
    {
      Item foundItem = Item.Find(id);
      return View(foundItem);
    }
  }
}