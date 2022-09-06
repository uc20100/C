// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.  
// M = 1; N = 5. -> ""5, 4, 3, 2, 1""  
// M = 4; N = 8. -> ""8, 7, 6, 5, 4""


Console.WriteLine();
Console.Write("Введите значение \"М\" : ");
int mValue = Convert.ToInt32(ReadFromConsole());
Console.Write("Введите значение \"N\" : ");
int nValue = Convert.ToInt32(ReadFromConsole());
Console.WriteLine();
Console.WriteLine($"M={mValue}; N={nValue} -> {GetNumber(minValue: mValue, maxValue: nValue)}");
Console.WriteLine();



/// <summary>
/// Выводит все натуральные числа в промежутке от минимального до максимального
/// </summary>
/// <param name="minValue">Минимальное число</param>
/// <param name="maxValue">Максимальное число</param>
/// <returns>Результат выполнения</returns>
string GetNumber(int minValue, int maxValue)
{
    if (minValue > maxValue)
    {
        return string.Empty;
    }
    else
    {
        if (maxValue == minValue)
        {
            return $"{maxValue}" + GetNumber(minValue, maxValue - 1);
        }
        else
        {
            return $"{maxValue}, " + GetNumber(minValue, maxValue - 1);
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