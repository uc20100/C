// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.  
// M = 1; N = 15 -> 56  
// M = 4; N = 8. -> 18  

Console.WriteLine();
Console.Write("Введите значение \"М\" : ");
int mValue = Convert.ToInt32(ReadFromConsole());
Console.Write("Введите значение \"N\" : ");
int nValue = Convert.ToInt32(ReadFromConsole());
Console.WriteLine();
Console.WriteLine($"M={mValue}; N={nValue} -> {SumEvenNumber(minValue: mValue, maxValue: nValue)}");
Console.WriteLine();



/// <summary>
/// Находит сумму чётных чисел натуральных элементов
/// </summary>
/// <param name="minValue">Минимальное число</param>
/// <param name="maxValue">Максимальное число</param>
/// <returns>Результат выполнения</returns>
int SumEvenNumber(int minValue, int maxValue)
{
    if (minValue > maxValue)
    {
        return 0;
    }
    else
    {
        if (minValue % 2 == 0)
        {
            return minValue + SumEvenNumber(minValue + 1, maxValue);
        }
        else
        {
            return SumEvenNumber(minValue + 1, maxValue);
        }
    }
}

/// <summary>
/// Чтение только цифр с консоли
/// </summary>
/// <returns>Строка из цифр</returns>
string ReadFromConsole()
{
    string result = string.Empty;
    while (true)
    {
        var k = Console.ReadKey(true);
        switch (k.Key)
        {
            case ConsoleKey.Backspace:
                if (result.Length > 0)
                {
                    result = result.Remove(startIndex: result.Length - 1, count: 1);
                    Console.Write(value: $"{k.KeyChar} {k.KeyChar}");
                }
                break;
            case ConsoleKey.Enter:
                if (result != string.Empty)
                {
                    Console.WriteLine();
                    return result;
                }
                else
                {
                    break;
                }
            default:
                if (char.IsDigit(c: k.KeyChar))
                {
                    Console.Write(value: k.KeyChar);
                    result += k.KeyChar;
                }
                break;
        }
    }
}