// See https://aka.ms/new-console-template for more information

String name = "Magdalena";
int age = 47;
bool woman = true;

if (woman)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat.");       
    }
    else//ma co najmniej ma 30 lat
    {
        if (name == "Ewa" && age == 33)
        {
            Console.WriteLine("Ewa, lat 33.");
        }
        else // nie Ewa i nie ma 33 lat
        {
            Console.WriteLine("Nazywam się " + name + " i mam lat " + age + ".");
        }
    }
}
else //mezczyzna
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna.");
    }
    else
    {
        Console.WriteLine("Mężczyzna jest pełnoletni..");
    }    
}




