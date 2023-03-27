using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDoListProjectTest.Models;

namespace ToDoListProjectTest.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();

    }
}