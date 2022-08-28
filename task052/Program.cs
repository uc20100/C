// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.  
// Например, задан массив:  
// 1 4 7 2  
// 5 9 2 3  
// 8 4 2 4  
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.  


const int minValueArray = 0;
const int maxValueArray = 9;
const int rowsArray = 3;
const int columnsArray = 4;


int[,] valueArray = GetArray(rows: rowsArray,
                          columns: columnsArray,
                         minValue: minValueArray,
                         maxValue: maxValueArray);

PrintArray(valueArray);
Console.WriteLine();
PrintAvgArray(valueArray);

/// <summary>
/// Получение массива случайных чисел
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="columns">Количество столбцов</param>
/// <param name="minValue">Минимальное случайное значение</param>
/// <param name="maxValue">Максимальное случайное значение</param>
/// <returns></returns>
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
///  Вывод массива на консоль
/// </summary>
/// <param name="array">Массив</param>
void PrintArray(int[,] array)
{
    const int tabColumns = 6;
    Console.WriteLine($"Массив {array.GetLength(0)}х{array.GetLength(1)}:");
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
/// Выводит на консоль среднеарифметическое каждого столбца двухмерного массива
/// </summary>
/// <param name="array">Массив</param>
void PrintAvgArray(int[,] array)
{
    const int tabColumns = 6;
    double avgSumColumns = 0;
    int countRows = 0;
    Console.WriteLine("Среднеарифметическое колонок массива:");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        countRows = 0;
        avgSumColumns = 0;
        while (countRows < array.GetLength(0))
        {
            avgSumColumns += array[countRows, i];
            countRows++;
        }
        Console.Write($"{Math.Round(avgSumColumns / countRows, 1),tabColumns}");
    }
}