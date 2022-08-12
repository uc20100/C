/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.  

14212 -> нет  
12821 -> да  
23432 -> да
*/

Console.WriteLine("Введите число:");
try
{
    Console.WriteLine(palindromeStatus(Convert.ToInt32(Console.ReadLine())));
}
catch
{
    Console.WriteLine("Ошибка ввода");
}


string palindromeStatus(int number)
{
    string retValue = "Да, число палиндром";
    double degreeNumber = 0;
    int leftNumber, rightNumber;

    while (number > Math.Pow(10, degreeNumber))
    {
        degreeNumber++;
    }
    if (degreeNumber > 1)
    {
        for (int i = 0; i < degreeNumber / 2; i++)
        {
            leftNumber = number % (int)Math.Pow(10, (degreeNumber - i)) / (int)Math.Pow(10, (degreeNumber - i - 1));
            rightNumber = number % (int)Math.Pow(10, (i + 1)) / (int)Math.Pow(10, (i));
            if (leftNumber != rightNumber)
            {
                retValue = "Нет, число не палиндром";
            }
        }
    }
    else
    {
        retValue = "Введите число больше одного знака";
    }
    return retValue;
}