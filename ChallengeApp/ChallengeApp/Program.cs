//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using ChallengeApp;


var employee = new Employee("Ad", "Ka");
employee.addMarks(new float[5] { 1.0f, 3.2f, 4.5f, 3.8f, 7.2f });
var statistics = employee.getStatistics();

Console.WriteLine($"Minimum: {statistics.Min}");
Console.WriteLine($"Maximum: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");


//lista
//List<Employee> listOfEmpls = new List<Employee>();
//dodanie pracownikow
//listOfEmpls.Add(new Employee("Magdalena", "Pejas", 47));
//dodanie kazdemu ocenn
//listOfEmpls[0].addMarks(new int[5] {2,5,3,6,4});









