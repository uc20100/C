/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число:");
try
{
    int secondNamber = secondCharacterNumber(Convert.ToInt32(Console.ReadLine()));
    if (secondNamber != -1) Console.WriteLine($"Второе число {secondNamber}");
    else Console.WriteLine("Число не трехзначное");
}
catch
{
    Console.WriteLine("Ошибка ввода");
}



int secondCharacterNumber(int number)
{
    int retValue = -1;
    double degreeNumber = 0;
    while (number > Math.Pow(10, degreeNumber)) degreeNumber++;
    if (degreeNumber == 3) retValue = number % 100 / 10;
    return retValue;
}



