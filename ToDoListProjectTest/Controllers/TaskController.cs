using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDoListProjectTest.Domain.ViewModel;
using ToDoListProjectTest.Models;
using ToDoListProjectTest.Service.Interfaces;

namespace ToDoListProjectTest.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> Create(CreateTaskViewModel model)
        {
            var response = await _taskService.Create(model);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return Ok(new { description = response.Description });
            }
            return BadRequest(new { description = response.Description });
        }

    }
}