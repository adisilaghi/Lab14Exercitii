

using Lab14Exercitii;

Employee user1 = new Employee { Name = "Mario", Id = Guid.NewGuid(), Salary = 1250, Department = Department.Development };
Employee user2 = new Employee { Name = "Jane", Id = Guid.NewGuid(), Salary = 700, Department = Department.HumanResources };
Employee user3 = new Employee { Name = "Alice", Id = Guid.NewGuid(), Salary = 1300, Department = Department.Development };
Employee user4 = new Employee { Name = "John", Id = Guid.NewGuid(), Salary = 700, Department = Department.HumanResources };


Management management = new Management();

management.AddEmployee(user1);
management.AddEmployee(user2);
management.AddEmployee(user3);
management.AddEmployee(user4);

Console.WriteLine("\nEmployees with salary greater than 1000:");
var wellPaidEmployees = management.GetNoOfWellPayedEmployees(1000);
ShowDepartment.DisplayEmployees(wellPaidEmployees);

Console.WriteLine("\nEmployees in the Development department:");
var devEmployees = management.GetEmployeesByDepartment(Department.Development);
ShowDepartment.DisplayEmployees(devEmployees);

Console.WriteLine("\nEmployees in the Human Resources department:");
var hrEmployees = management.GetEmployeesByDepartment(Department.HumanResources);
ShowDepartment.DisplayEmployees(hrEmployees);

Console.WriteLine("\nEmployees with the maximum salary:");
var maxSalaryEmployees = management.GetEmployeesWithMaxSalary();
ShowDepartment.DisplayEmployees(maxSalaryEmployees);

Console.WriteLine("Removing an employee" + " " + user2.Name + " with ID: " + user2.Id);
management.RemoveEmployee(user2.Id);

Console.WriteLine("\nTotal cost of salaries in the company: $" + management.GetTotalCost());

Console.WriteLine("\nTotal cost of salaries in the Development department: $" + management.GetCostForDepartment(Department.Development));
Console.WriteLine("\nTotal cost of salaries in the HR department: $" + management.GetCostForDepartment(Department.HumanResources));

Console.WriteLine("\nIncreasing salary of employee with ID " + user1.Id + " by 10%...");
management.IncreaseSalary(user1.Id, 10);

Console.WriteLine("\nIncreasing salary of all employees in the Development department by 5%...");
management.IncreaseSalary(Department.Development, 5);

    
