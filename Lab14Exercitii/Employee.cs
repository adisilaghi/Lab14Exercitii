using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14Exercitii
{
    public enum Department
    {
        Development,
        Testing,
        HumanResources,
        Maintenance,
        Logistics 
    }

    public class Employee
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, ID: {Id}, Salary: {Salary}, Department: {Department}";
        }
    }
}
