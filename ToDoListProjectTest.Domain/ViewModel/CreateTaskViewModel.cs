using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListProjectTest.Domain.Enum;

namespace ToDoListProjectTest.Domain.ViewModel
{
    public class CreateTaskViewModel
    {
        public string Name { get; set; }

        public Priority Priority { get; set; }

        public string Description { get; set; }
    }
}
