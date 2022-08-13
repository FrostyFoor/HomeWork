// Задача №10
Console.WriteLine("Введите число");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра -> " +stringNumber[1]);



// Задача №13
Console.Write("Введите число");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
    if (anyNumberText.Length > 2)
    {
        Console.WriteLine("третья цифра -> " + anyNumberText[2]);
    }
    else 
    {
        Console.WriteLine("-> третьей цифры нет");
    }


//Задача №15
Console.WriteLine("Введите день недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNumber) 
{
    if (dayNumber == 6 || dayNumber == 7) 
        {
            Console.WriteLine("Выходной день");
        }
    else 
        if (dayNumber < 1 || dayNumber > 7)
        {
            Console.WriteLine("Непонятный день.");
        }
        
        else 
            Console.WriteLine("Рабочий день");
}
CheckingTheDayOfTheWeek(dayNumber);