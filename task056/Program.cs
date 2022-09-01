// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.  
// Например, задан массив:  
// 1 4 7 2  
// 5 9 2 3  
// 8 4 2 4  
// 5 2 6 7  
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


const int minValueArray = 0;
const int maxValueArray = 9;


Console.WriteLine();
Console.Write("Введите количество строк, двумерного массива: ");
int rowsArray = Convert.ToInt32(ReadFromConsole());
Console.Write("Введите количество столбцов, двумерного массива: ");
int columnsArray = Convert.ToInt32(ReadFromConsole());
int[,] valueArray = GetArray(rows: rowsArray,
                          columns: columnsArray,
                         minValue: minValueArray,
                         maxValue: maxValueArray);
Console.WriteLine();
PrintArrayMin(array: valueArray,
           minValue: MinIndexSumRowArray(valueArray),
               note: $"Рандомный от {minValueArray} до {maxValueArray}");


/// <summary>
/// Возвращает индекс строки сумма которой минимальна
/// </summary>
/// <param name="array">Массив</param>
/// <returns>Индекс строки сумма которых минимальна</returns>
int MinIndexSumRowArray(int[,] array)
{
    int minSum = int.MaxValue;
    int sum;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            result = i;
        }
    }
    return result;
}

/// <summary>
/// Вывод массива на консоль
/// </summary>
/// <param name="array">Массив</param>
/// <param name="minValue">Индекс строки сумма которых минимальна</param>
/// <param name="note">Заметки (не обязательно)</param>
void PrintArrayMin(int[,] array, int minValue, string note = "")
{
    const int tabColumns = 4;
    Console.WriteLine($"Массив {array.GetLength(0)}х{array.GetLength(1)}:     {note}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],tabColumns}");
        }
        if (i == minValue)
        {
            Console.Write(" -> Наименьшая сумма в строке");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Получение массива случайных чисел
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="columns">Количество столбцов</param>
/// <param name="minValue">Минимальное случайное значение</param>
/// <param name="maxValue">Максимальное случайное значение</param>
/// <returns>Двумерный массив</returns>
int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
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