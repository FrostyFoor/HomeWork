int a, b;
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
b = Convert.ToInt32(Console.ReadLine());
    if (a > b)
    {
    Console.WriteLine("{0} наибольшее число", a);
    }
    else
    {
    Console.WriteLine("{0} наибольшее число ", b);
    }
Console.ReadLine();




int a, b, c;
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    Console.WriteLine("{0} наибольшее число", a);
    else
    Console.WriteLine("{0} наибольшее число", c);
}
else
{
    if(b > c)
    Console.WriteLine("{0} наибольшее число", b);
    else
    Console.WriteLine("{0} наибольшее число", c);
}
Console.ReadLine();




int n;
Console.WriteLine("Введите число");
n = int.Parse(Console.ReadLine());
if (n % 2 == 0)
{
    Console.WriteLine("Введенное число является четным");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Введенное число нечетное");
    Console.ReadLine();
}



Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
    
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);