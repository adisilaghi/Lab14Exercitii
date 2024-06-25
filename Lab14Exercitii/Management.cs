using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14Exercitii
{
    public class Management
    {
        private List<Employee> employees = new();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(Guid id)
        {
            employees.RemoveAll(e => e.Id == id);
        }

        public List<Employee> GetNoOfWellPayedEmployees(double threshold)
        {
            return employees.FindAll(e => e.Salary > threshold);
        }

        public List<Employee> GetEmployeesByDepartment(Department department)
        {
            return employees.FindAll(e => e.Department == department);
        }

        public List<Employee> GetEmployeesWithMaxSalary()
        {
            double maxSalary = employees.Max(e => e.Salary);
            return employees.FindAll(e => e.Salary == maxSalary);
        }

        public List<Employee> GetEmployeesWithMaxSalaryByDepartment(Department department)
        {
            double maxSalary = employees.Where(e => e.Department == department).Max(e => e.Salary);
            return employees.FindAll(e => e.Department == department && e.Salary == maxSalary);
        }

        public double GetTotalCost()
        {
            return employees.Sum(e => e.Salary);
        }

        public double GetCostForDepartment(Department department)
        {
            return employees.Where(e => e.Department == department).Sum(e => e.Salary);
        }

        public void IncreaseSalary(Guid id, double percentage)
        {
            Employee employee = employees.Find(e => e.Id == id);
            if (employee != null)
            {
                employee.Salary *= (1 + percentage / 100);
            }
        }

        public void IncreaseSalary(Department department, double percentage)
        {
            employees.FindAll(e => e.Department == department).ForEach(e => e.Salary *= (1 + percentage / 100));
        }
    }
}
