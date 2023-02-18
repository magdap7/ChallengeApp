//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using ChallengeApp;

string name, surname, type, response;
EmployeeInMemory employeeMem;
EmployeeInFile employeeFile;


Console.WriteLine("==========================WITAMY=============================");
Console.WriteLine("");
Console.WriteLine($"Podaj imię pracownika:");
name = Console.ReadLine();
Console.WriteLine($"Podaj nazwisko pracownika:");
surname = Console.ReadLine();
Console.WriteLine($"Podaj typ zapisu ocen pracownika: m albo f (zapis ocen do pamięci lub do pliku.");
type = Console.ReadLine();


if (type == "m")
{
    employeeMem = new EmployeeInMemory(name, surname);
    employeeMem.GradeAdded += EmployeeGradeAdded;
    PrintInstructions();
    do
    {
        Console.WriteLine($"Wpisz kolejną ocenę pracownika.");
        response = Console.ReadLine();
        if (response == "q")
            break;
        try
        {
            employeeMem.AddGrade(response);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exeption catched: {ex.Message}");
        }
    } while (response != "q");
    var statistics = employeeMem.GetStatistics();
    PrintStatistics(statistics);
}
else if (type == "f")
{
    employeeFile = new EmployeeInFile(name, surname);
    employeeFile.GradeAdded += EmployeeGradeAdded;
    PrintInstructions();
    do
    {
        Console.WriteLine($"Wpisz kolejną ocenę pracownika.");
        response = Console.ReadLine();
        if (response == "q")
            break;
        try
        {
            employeeFile.AddGrade(response);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exeption catched: {ex.Message}");
        }
    } while (response != "q");
    var statistics = employeeFile.GetStatistics();
    PrintStatistics(statistics);
}
else
{
    Console.WriteLine("nie wybrano typu zapisywania ocen.");
}


void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano ocenę.");
}

void PrintInstructions()
{
    Console.WriteLine("Wpisz dowolną ilość ocen pracownika w jednej z postaci:");
    Console.WriteLine("-litery dużej lub małej od a do F");
    Console.WriteLine("-liczby zminnnoprzecinkowej od 0 do 100, np.: 25,0");
    Console.WriteLine("Aby wyjść z trybu wprowadzania ocen, naciśnij q.");
}

void PrintStatistics(Statistics statistics)
{
    Console.WriteLine("");
    Console.WriteLine("==========================STATYSTYKI=============================");

    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
    Console.WriteLine($"Sum: {statistics.Sum}");
    Console.WriteLine($"Cnt: {statistics.Count}");
    Console.WriteLine($"Avg: {statistics.Average:n2}");
    Console.WriteLine($"AvL: {statistics.AverageLetter}");
}








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









