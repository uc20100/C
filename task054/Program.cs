// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.  
// Например, задан массив:  
// 1 4 7 2  
// 5 9 2 3  
// 8 4 2 4  
// В итоге получается вот такой массив:  
// 7 4 2 1  
// 9 5 3 2  
// 8 4 4 2

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
PrintArray(valueArray, "Рандомный");
Console.WriteLine();
SortArray(ref valueArray);
PrintArray(valueArray, "Отсортированный");



/// <summary>
/// Процедура сортировки по убыванию
/// </summary>
/// <param name="array">Массив</param>
void SortArray(ref int[,] array)
{
    int max;
    int tempValue;
    int iMax;
    int jMax;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            max = array[i, k];
            iMax = i;
            jMax = k;
            for (int j = k; j < array.GetLength(1); j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                    iMax = i;
                    jMax = j;
                }
            }
            tempValue = array[i, k];
            array[i, k] = array[iMax, jMax];
            array[iMax, jMax] = tempValue;
        }
    }
}

/// <summary>
/// Вывод массива на консоль
/// </summary>
/// <param name="array">Массив</param>
/// <param name="note">Заметки (не обязательно)</param>
void PrintArray(int[,] array, string note = "")
{
    const int tabColumns = 4;
    Console.WriteLine($"Массив {array.GetLength(0)}х{array.GetLength(1)}:   {note}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],tabColumns}");
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