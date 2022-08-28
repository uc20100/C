// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.  
// m = 3, n = 4.  
// 0,5 7 -2 -0,2  
// 1 -3,3 8 -9,9  
// 8 7,8 -7,1 9 


const int minValueArray = -10;
const int maxValueArray = 10;

try
{
    Console.Write("Введите количество строк двумерного массива: ");
    int rowsArray = Convert.ToInt32(ReadFromConsole());
    Console.Write("Введите количество столбцов двумерного массива: ");
    int columnsArray = Convert.ToInt32(ReadFromConsole());

    double[,] valueArray = GetArray(rows: rowsArray,
                                 columns: columnsArray,
                                minValue: minValueArray,
                                maxValue: maxValueArray);
    Console.WriteLine();
    PrintArray(valueArray);
}
catch
{
    Console.WriteLine("Ошибка ввода");
}


/// <summary>
/// Получение массива случайных чисел
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="columns">Количество столбцов</param>
/// <param name="minValue">Минимальное случайное значение</param>
/// <param name="maxValue">Максимальное случайное значение</param>
/// <returns>Массив</returns>
double[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().NextDouble() * new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

/// <summary>
/// Вывод массива на консоль
/// </summary>
/// <param name="array">Массив</param>
void PrintArray(double[,] array)
{
    const int tabColumns = 6;
    Console.WriteLine($"Массив {array.GetLength(0)}х{array.GetLength(1)}:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 1),tabColumns}");
        }
        Console.WriteLine();
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
                Console.WriteLine();
                return result;
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