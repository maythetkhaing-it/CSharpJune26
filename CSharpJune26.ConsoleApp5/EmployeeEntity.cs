using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJune26.ConsoleApp5
{
    [Table("Employees")] // Add attributes to map the class to the table name.
    public class EmployeeEntity
    {
        [Key] // refer to primary key
        public int employeeID {  get; set; }

        public string username { get; set; }

        public string? address { get; set; } //string? //string + null

    }
}
