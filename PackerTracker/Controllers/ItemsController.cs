using Microsoft.AspNetCore.Mvc;
using Items.Models;
using System.Collections.Generic;

namespace Items.Models
{
  public class PlacesController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> listItem = Item.GetAll(); 
      return View("index", listItem);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View("New");
    }

    [HttpPost("/items")]      
    public ActionResult Create(string name, bool purchased, int price, bool packed, float weight)
    {
      Item entry = new Item(name,purchased,price,packed,weight);
      return RedirectToAction("Index");
    }

     [HttpGet("/items/{id}")]
     public ActionResult Show(int id)
     {
       Item foundItem = Item.Find(id);
       return View("Show", foundItem);
     }

  }
}