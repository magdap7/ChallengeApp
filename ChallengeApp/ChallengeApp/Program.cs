//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using ChallengeApp;

Console.WriteLine("==========================WITAMY=============================");
Console.WriteLine("");
Console.WriteLine("Wpisz dowolną ilość ocen pracownika w jednej z postaci:");
//Console.WriteLine("-oceny szkolnej od 1 do 6, np.: 2, 5+, -4");
Console.WriteLine("-litery dużej lub małej od a do F");
Console.WriteLine("-liczby zminnnoprzecinkowej od 0 do 100, np.: 25,0");
Console.WriteLine("Aby wyjść z trybu wprowadzania ocen, naciśnij q.");

var employeeInFile = new EmployeeInFile("A","K");



string response = "";
do
{
    Console.WriteLine($"Wpisz kolejną ocenę pracownika.");
    response = Console.ReadLine();
    if (response == "q")
        break;
    try
    {
        employeeInFile.AddGrade(response);
    } 
    catch (Exception ex)
    {
        Console.WriteLine($"Exeption catched: {ex.Message}");
    }
} while (response != "q");


var statistics = employeeInFile.GetStatistics();

Console.WriteLine("==========================statystyki=============================");
Console.WriteLine($"minimum: {statistics.Min}");
Console.WriteLine($"maximum: {statistics.Max}");
Console.WriteLine($"average: {statistics.Average:n2}");
//Console.writeline($"average: {statistics.averageletter}");





/////////////////////////////////////////////////ZABAWY////////////////////////////////////////////
///


//char[] array = new char[3]{'a','b','c'};
//char c1 = array.Max();  
//char c2 = array.Min();
//String s1 = array.ToString();
//String s2 = array.Reverse().ToString();
//char[] array1 = array.Reverse().ToArray();

//try
//{
//    char c3 = array[3];
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{//zasze wywołuje
//    Console.WriteLine("I'm here.");
//}

//float f = 45.000f;
//int i = 99;
//long l = 11111l;
//short h = 12;
//double d = 45.00d;
//decimal c = 77.000000000m;
//string s1 = "54";
//string s2 = "54f";
//string s3 = "5.4";//parse float nie zadziała, tryparse zwróci false
//char c1 = 'C';
//char c2 = 'd';

//lista
//List<Employee> listOfEmpls = new List<Employee>();
//dodanie pracownikow
//listOfEmpls.Add(new Employee("Magdalena", "Pejas", 47));
//dodanie kazdemu ocen
//employee.AddGrades(new float[5] { 1.0f, 3.2f, 4.5f, 3.8f, 7.2f });
//: {employee.lastName} {employee.firstName}









