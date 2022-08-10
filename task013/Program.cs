/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число:");
try
{
    int thirdNamber = thirdCharacterNumber(Convert.ToInt32(Console.ReadLine()));
    if (thirdNamber != -1) Console.WriteLine($"Третье число {thirdNamber}");
    else Console.WriteLine("Третьей цифры нет");
}
catch
{
    Console.WriteLine("Ошибка ввода");
}


int thirdCharacterNumber(int number)
{
    int retValue = -1;
    double degreeNumber = 0;
    while (number > Math.Pow(10, degreeNumber)) degreeNumber++;
    if (degreeNumber >= 3) retValue = number % (int)Math.Pow(10, (degreeNumber - 2)) / (int)Math.Pow(10, (degreeNumber - 3));
    return retValue;
}
