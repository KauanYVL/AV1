using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AV1.Models;

namespace AV1.Controllers;
public class KauanController : Controller{
public IActionResult Index()
    {
        return View();
    }

}