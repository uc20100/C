// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.(необязательная)
// m = 2, n = 3 -> A(m,n) = 29  

Console.WriteLine();
Console.Write("Введите значение \"М\" : ");
int mValue = Convert.ToInt32(ReadFromConsole());
Console.Write("Введите значение \"N\" : ");
int nValue = Convert.ToInt32(ReadFromConsole());
Console.WriteLine();
Console.WriteLine($"Функция Аккермана A=({mValue},{nValue}) -> {Akm(mValue, nValue)}");




/// <summary>
/// Функция Аккермана
/// </summary>
/// <param name="m">М параметр функции</param>
/// <param name="n">N параметр функции</param>
/// <returns>Результат выполнения</returns>
double Akm(int m, int n)
{
    if (m >= 0)
    {
        switch (m)
        {
            case 0:
                return n + 1;
            case 1:
                return 2 + (n + 3) - 3;
            case 2:
                return 2 * (n + 3) - 3;
            case 3:
                return -3 + Akm(-(n + 3 + 1), n);
            case 4:
                int degree = 2;
                for (int i = 0; i < n + 1; i++)
                {
                    degree = degree * degree;
                }
                return -3 + Akm(-(degree + 1), n);
            default:
                return 0;
        }
    }
    else
    {
        if (m == -1)
        {
            return 1;
        }
        else
        {
            return 2 * Akm(m + 1, n);
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