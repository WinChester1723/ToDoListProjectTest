using ToDoListProjectTest.Dal.Interfaces;
using ToDoListProjectTest.Dal.Repository;
using ToDoListProjectTest.Domain.Entity;

namespace ToDoListProjectTest
{
    public static class Initializer
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<TaskEntity>, TaskRepository>();
        }
    }
}
