// See https://aka.ms/new-console-template for more information

String Name = "Magdalena";
int Age = 47;
bool Woman = true;

//zaraz chwila prawdy
if (Woman == true)
{
    if (Age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat.");       
    }
    else//ma co najmniej ma 30 lat
    {
        if (Name == "Ewa" && Age == 33)
        {
            Console.WriteLine("Ewa, lat 33.");
        }
        else // nie Ewa i nie ma 33 lat
        {
            Console.WriteLine("Nazywam się " + Name + " i mam lat " + Age + ".");
        }
    }
}
else //mezczyzna
{
    if (Age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna.");
    }
        
}




