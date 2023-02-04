

int number = 221115377;
int[] arrayOfSumsOfDigits = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
int iterator;

string numberToString = number.ToString();//Console.WriteLine(numberToString);
char[] arrayOfLetters = numberToString.ToCharArray();//Console.WriteLine(arrayOfLetters.Length);

for(iterator=0; iterator< arrayOfLetters.Length; iterator++)
{
    int digitFromChar = (int)arrayOfLetters[iterator];
    arrayOfSumsOfDigits[digitFromChar - 48]++;
}

for (iterator = 0; iterator < 10; iterator++) 
{
    Console.WriteLine(iterator + " => " + arrayOfSumsOfDigits[iterator]);
}
    

