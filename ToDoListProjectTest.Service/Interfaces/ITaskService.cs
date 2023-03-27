using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListProjectTest.Domain.Entity;
using ToDoListProjectTest.Domain.Response;
using ToDoListProjectTest.Domain.ViewModel;

namespace ToDoListProjectTest.Service.Interfaces
{
    public interface ITaskService
    {
        Task<IBaseResponse<TaskEntity>> Create(CreateTaskViewModel model);
    }
}
