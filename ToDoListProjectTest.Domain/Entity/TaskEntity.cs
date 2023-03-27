using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListProjectTest.Domain.Enum;

namespace ToDoListProjectTest.Domain.Entity
{
    public class TaskEntity
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public bool IsDone { get; set; }

        public string Description { get; set; }

        public Priority Priority { get; set; }

        public DateTime Created { get; set; }

    }
}
