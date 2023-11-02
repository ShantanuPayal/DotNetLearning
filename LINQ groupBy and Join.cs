// See https://aka.ms/new-console-template for more 
using System;
using System.Linq;
class Employee
{
    public int Id { get; set; } 
    public string Name { get; set; }

    public int Salary { get; set; }

    public int DeptId { get; set; }

    public Employee(int id, String name, int salary, int deptId)
    {
        Id = id;
        Name = name;
        Salary = salary;
        DeptId = deptId;
    }
}
class Department
{
    public int DeptId { get; set; }
    public string DeptName { get; set; }

    public Department(int deptId, string deptName)
    {
        DeptId = deptId;
        DeptName = deptName;
    }
}

class Temp
{
    public string DeptName { get; set; }
    public string Name { get; set; }

    public Temp( string deptName, string name)
    {
        
        DeptName = deptName;
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        Employee[] employees =
        {
            new Employee(01,  "Shantanu", 52000, 500),
            new Employee(03, "Shekhar", 72000, 501),
            new Employee(02, "Payal", 44500, 500),
            new Employee(05, "ShantanuPayal", 43000, 501),
            new Employee(04, "Payalpayal", 11000, 502),
            new Employee(06, "Payalll", 15000, 502)
        };

        Department[] departments =
        {
            new Department(500, "ADMIN"),
            new Department(501, "ADV"),
            new Department(502, "HR")
        };



        var inDepartList = from employee in employees
                           join entry in departments
                           on employee.DeptId equals entry.DeptId
                           select new Temp(entry.DeptName, employee.Name);


        Console.WriteLine("Employee list with their Respective departemnts Using Join");

        foreach (Temp t in inDepartList) Console.WriteLine("{0}\t{1}", t.DeptName, t.Name);

        Console.WriteLine("---------------------------------------------------------------------------------------");
        Console.WriteLine("Grouping the employes by theris Depts Using GroupBy");

        var orderGroups = from employee in employees
                          group employee by employee.DeptId into g
                          select new { DeptId = g.Key, employees = g };

        foreach (var og in orderGroups)

        {
            Console.WriteLine(og.DeptId);
            foreach (var i in og.employees)
            {
                Console.WriteLine("{0} \t{1}\t{2}\t", i.Id, i.Name, i.DeptId);
            }

        }
                          


    }
}