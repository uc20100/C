/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.  

3 -> 1, 8, 27  
5 -> 1, 8, 27, 64, 125
 */


Console.WriteLine("Введите цифру:");
try
{
    Console.WriteLine(cubeArrayNumber(Convert.ToInt32(Console.ReadLine())));
}
catch
{
    Console.WriteLine("Ошибка ввода");
}


string cubeArrayNumber(int number)
{
    string retValue = $"{number} -> ";

    for (int i = 1; i <= number; i++)
    {
        if (i != number)
        {
            retValue += Convert.ToString(Math.Pow(i, 3)) + ", ";
        }
        else
        {
            retValue += Convert.ToString(Math.Pow(i, 3));
        }
    }

    return retValue;
}