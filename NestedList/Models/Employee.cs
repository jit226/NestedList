using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NestedList.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }

        public static List<Employee> GetList()
        {
            List<Employee> employees = new List<Employee> {
                        new Employee { Id = 1, Name = "A", ParentId = 0 },
                        new Employee { Id = 2, Name = "B", ParentId = 0 },
                        new Employee { Id = 3, Name = "A-1", ParentId = 1 },
                        new Employee { Id = 4, Name = "A-2", ParentId = 1 },
                        new Employee { Id = 5, Name = "A-3", ParentId = 1 },
                        new Employee { Id = 6, Name = "B-1", ParentId = 2 },
                        new Employee { Id = 7, Name = "B-2", ParentId = 2 },
                        new Employee { Id = 8, Name = "A2-1", ParentId =4 },
                        new Employee { Id = 9, Name = "A2-2", ParentId = 4 },
                        new Employee { Id = 10, Name = "B2-1", ParentId = 7 },
                        new Employee { Id = 11, Name = "A2-2-1", ParentId = 9 }
            };
            return employees;
        }
    }
}