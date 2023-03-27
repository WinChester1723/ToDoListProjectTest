using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ToDoListProjectTest.Domain.Enum
{
    public enum Priority
    {
        [Display(Name = "Low")]
        Easy = 0,
        [Display(Name = "Important")]
        Medium = 1,
        [Display(Name = "Critical")]
        High = 2
    }
}
