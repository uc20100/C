// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.  
// Например, даны 2 матрицы:  
// 2 4 | 3 4  
// 3 2 | 3 3  
// Результирующая матрица будет:  
// 18 20  
// 15 18



const int minValueArray = 0;
const int maxValueArray = 9;


Console.WriteLine();
Console.Write("Введите количество строк, первого массива: ");
int rowsFirstArray = Convert.ToInt32(ReadFromConsole());
Console.Write("Введите количество столбцов, первого массива: ");
int columnsFirstArray = Convert.ToInt32(ReadFromConsole());
Console.Write("Введите количество столбцов, второго массива: ");
int columnsSecondArray = Convert.ToInt32(ReadFromConsole());

int[,] firstArray = GetFirstArray(rows: rowsFirstArray,
                               columns: columnsFirstArray,
                              minValue: minValueArray,
                              maxValue: maxValueArray);
Console.WriteLine();
PrintArray(array: firstArray, note: "Массив А");
Console.WriteLine();
int[,] secondArray = GetSecondArray(array: firstArray,
                                  columns: columnsSecondArray,
                                 minValue: minValueArray,
                                 maxValue: maxValueArray);
PrintArray(array: secondArray, note: "Массив B");
Console.WriteLine();
int[,] resultArray = MulArray(array1: firstArray, array2: secondArray);
PrintArray(array: resultArray, note: "Массив A*B=C  ");
Console.WriteLine();




/// <summary>
/// Умножает массив1 * массив2
/// </summary>
/// <param name="array1">Массив1</param>
/// <param name="array2">Массив2</param>
/// <returns>Результат умножения</returns>
int[,] MulArray(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    result[i, k] += array1[i, j] * array2[j, k];
                }
            }
        }
    }
    return result;
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
int[,] GetFirstArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

/// <summary>
/// Создает второй массив
/// </summary>
/// <param name="array">Первый массив</param>
/// <param name="columns">Количество колонок</param>
/// <param name="minValue">Минимальное случайное значение</param>
/// <param name="maxValue">Максимальное случайное значение</param>
/// <returns>Двумерный массив</returns>
int[,] GetSecondArray(int[,] array, int columns, int minValue, int maxValue)
{
    int[,] result = new int[array.GetLength(1), columns];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
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