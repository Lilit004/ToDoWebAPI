using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoWebAPI.Domain.Entities
{
    public class ToDo
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int ToDoStatusesId { get; set; }
        public ToDoStatus ToDoStatuses { get; set; }
    }
}
