/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


Console.WriteLine("Введите цифру дня недели:");
try
{
    Console.WriteLine(dayStatusNumber(Convert.ToInt32(Console.ReadLine())));
}
catch
{
    Console.WriteLine("Ошибка ввода");
}


string dayStatusNumber(int day)
{
    string retValue;
    if (day == 6 || day == 7)
    {
        retValue = "Выходной";
    }
    else
    {
        if (day < 6 && day > 0)
        {
            retValue = "Рабочий";
        }
        else
        {
            retValue = "Ошибка ввода";
        }
    }
    return retValue;
}