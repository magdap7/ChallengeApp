// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
String strImie = "Magdalena";
int iWiek = 47;
bool bKobieta = true;

//zaraz chwila prawdy
if (bKobieta == true)
{
    if (iWiek < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat.");       
    }
    else if ( strImie=="Ewa" && iWiek==33)
    {
        Console.WriteLine("Ewa, lat 33.");
    }
    else//pisze moje dane
    {
        Console.WriteLine("Nazywam się " + strImie + " i mam lat " + iWiek + ".");
    }
}
else //mezczyzna
{
    if (iWiek < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna.");
    }
        
}




