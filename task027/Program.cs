/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.  
452 -> 11  
82 -> 10  
9012 -> 12
*/

try
{
    Console.WriteLine("Введите число:");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма цифр числа {num} -> {SumDischargesNumber(num)}");
}
catch
{
    Console.WriteLine("Ошибка ввода");
}

int SumDischargesNumber(int number)
{
    int sum = 0;

    for (int i = 0; number >= (int)Math.Pow(10, i); i++)
    {
        sum += number % (int)Math.Pow(10, (i + 1)) / (int)Math.Pow(10, (i));
    }
    return sum;
}
