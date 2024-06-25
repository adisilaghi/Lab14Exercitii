using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14Exercitii
{
    internal class ShowDepartment
    {
        public static void DisplayEmployees(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine();
        }
    }
}
