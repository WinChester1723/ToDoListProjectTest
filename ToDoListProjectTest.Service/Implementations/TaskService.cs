using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListProjectTest.Dal.Interfaces;
using ToDoListProjectTest.Domain.Entity;
using ToDoListProjectTest.Domain.Enum;
using ToDoListProjectTest.Domain.Response;
using ToDoListProjectTest.Domain.ViewModel;
using ToDoListProjectTest.Service.Interfaces;

namespace ToDoListProjectTest.Service.Implementations
{
    public class TaskService : ITaskService
    {
        private ILogger<TaskService> _logger;

        private readonly IBaseRepository<TaskEntity> _taskRepository;

        public TaskService(ILogger<TaskService> logger, IBaseRepository<TaskEntity> taskRepository)
        {
            _taskRepository = taskRepository;
            _logger = logger;
        }

        public async Task<IBaseResponse<TaskEntity>> Create(CreateTaskViewModel model)
        {
            try
            {
                _logger.LogInformation($"Request for a create Task - {model.Name}");

                //get task name
                //if we have this task, dont added, message - we have this task
                //
                var task = await _taskRepository.GetAll()
                    .Where(x => x.Created == DateTime.Today)
                    .FirstOrDefaultAsync(x => x.Name == model.Name);

                if (task != null)
                {
                    return new BaseResponse<TaskEntity>()
                    {
                        Description = "There is already task with this name",
                        StatusCode = StatusCode.InternalServerError

                    };
                }

                task = new TaskEntity()
                {
                    Name = model.Name,
                    Description = model.Description,
                    Priority = model.Priority,
                    Created = DateTime.Now
                };

                await _taskRepository.Create(task);

                _logger.LogInformation($"Task added: {task.Name} {task.Created}");
                return new BaseResponse<TaskEntity>()
                {
                    Description = "Task added",
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[TaskService.Created]: {ex.Message}");
                return new BaseResponse<TaskEntity>()
                {
                    Description = "Internal Error",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
