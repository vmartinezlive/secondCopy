using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class CategoriesController : Controller
  {

    [HttpGet("/categories")]
    public ActionResult Index()
    {
      return View();
    }
//
//     [HttpPost("/categories")]
//     public ActionResult Create(string categoryName)
//     {
//       Category newCategory = new Category(categoryName);
//       List<Category> allCategories = Category.GetAll();
//       return View("Index", allCategories);
//     }

  }
}
