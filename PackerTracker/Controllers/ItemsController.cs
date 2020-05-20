using Microsoft.AspNetCore.Mvc;
using Items.Models;
using System.Collections.Generic;

namespace Items.Models
{
  public class ItemsController : Controller
  {
    // [HttpGet("/items")]
    // public ActionResult Index()
    // {
    //   List<Item> listItem = Item.GetAll(); 
    //   return View("index", listItem);
    // }

    [HttpGet("/items")]
    public ActionResult Index(string listType)
    {
      List<Item> listItem = Item.GetAll(); 
      //filter into 2nd list based on listType acquired from View
      //return View("index", filteredList)
      return View("index", listItem);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View("New");
    }

    [HttpPost("/items")]      
    public ActionResult Create(string name, string purchased, int price, string packed, float weight)
    {
      bool isPurchased;
      bool isPacked;
      if (purchased == "on")
      {
        isPurchased = true;
      }
      else
      {
          isPurchased = false;
      }
      if(packed == "on")
      {
        isPacked = true;
      }
      else
      {
        isPacked = false;
      }

      Item entry = new Item(name,isPurchased,price,isPacked,weight);
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