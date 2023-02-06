//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using ChallengeApp;
//utworzenie listy na pracownikó
List<Employee> listOfEmpls = new List<Employee>();
//dodanie pracownikow
listOfEmpls.Add(new Employee("Magdalena", "Pejas", 47));
listOfEmpls.Add(new Employee("Adam", "Kamiz", 30));
listOfEmpls.Add(new Employee("Zuzanna", "Xinska", 35));

//dodanie kazdemu ocen
listOfEmpls[0].addMarks(new int[5] {2,5,3,6,4});
listOfEmpls[1].addMarks(new int[5] {5,2,9,8,2});
listOfEmpls[2].addMarks(new int[5] {4,2,7,5,3});

//szukaniepracownika o najwyzszej sumie ocen
int maxResult = -1;
Employee theChampion = null;
foreach (var oneEmpl in listOfEmpls)
{
    //Console.WriteLine(oneEmpl.firstName + oneEmpl.getSumOfScores());
    int thisScore = oneEmpl.getSumOfScores();
    if (thisScore > maxResult)
    {
        theChampion = oneEmpl;
        maxResult = thisScore;
    }
}
//wypisanie danych pracownika o najlepszym wyniku (sumie ocen)
if (theChampion !=null)
{
    Console.WriteLine("Najlepszy: " + theChampion.firstName + " " + theChampion.lastName);
    Console.WriteLine("Wiek: " + theChampion.age);
    Console.WriteLine("Punkty - suma: " + theChampion.getSumOfScores());
}






