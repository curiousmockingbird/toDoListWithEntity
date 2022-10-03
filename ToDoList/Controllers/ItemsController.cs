using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult Form()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string description, int id)
    {
      Item myItem = new Item(description, 1);
      return RedirectToAction("Index");
    }

  }
}