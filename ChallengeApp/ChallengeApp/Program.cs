//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using ChallengeApp;


float f = 45.000f;
int i = 99;
long l = 11111l;
short h = 12;
double d = 45.00d;
decimal c = 77.000000000m;
string s1 = "54";
string s2 = "54f";
string s3 = "5.4";//parse float nie zadziała, tryparse zwróci false

var employee = new Employee("Ad", "Ka");
employee.addGrade(f);
employee.addGrade(i);
employee.addGrade(l);
employee.addGrade(h);
employee.addGrade(d);
employee.addGrade(c);
employee.addGrade(s1);
employee.addGrade(s2);
employee.addGrade(s3);

var statistics = employee.getStatistics();
Console.WriteLine($"Minimum: {statistics.Min}");
Console.WriteLine($"Maximum: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");



//lista
//List<Employee> listOfEmpls = new List<Employee>();
//dodanie pracownikow
//listOfEmpls.Add(new Employee("Magdalena", "Pejas", 47));
//dodanie kazdemu ocen
//employee.addGrades(new float[5] { 1.0f, 3.2f, 4.5f, 3.8f, 7.2f });










