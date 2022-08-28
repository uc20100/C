// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// (на вход именно поступает позиция элемента, можете разбить на две переменные или прописать
//  в одну строку и конвертировать в два числа, комментарии в конце семинара по этой задаче)  
// Например, задан массив:  
// 1 4 7 2  
// 5 9 2 3  
// 8 4 2 4  
// 17 -> такого числа в массиве нет  

const int minValueArray = 0;
const int maxValueArray = 9;
const int rowsArray = 3;
const int columnsArray = 4;

try
{
    Console.WriteLine();
    int[,] valueArray = GetArray(rows: rowsArray,
                              columns: columnsArray,
                             minValue: minValueArray,
                             maxValue: maxValueArray);

    PrintArray(valueArray);
    Console.WriteLine();

    Console.Write("Введите номер строки искомого элемента двумерного массива (нумерация начинается с 0): ");
    int viewRows = Convert.ToInt32(ReadFromConsole());
    Console.Write("Введите номер столбца искомого элемента двумерного массива (нумерация начинается с 0): ");
    int viewColumns = Convert.ToInt32(ReadFromConsole());

    Console.WriteLine(ViewElementArray(array: valueArray,
                                        rows: viewRows,
                                     columns: viewColumns));
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
    const int tabColumns = 4;
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
/// Поиск заданного элемента в массиве
/// </summary>
/// <param name="array">Двумерный массив</param>
/// <param name="rows">Строка поиска</param>
/// <param name="columns">Столбец поиска</param>
/// <returns>Результат поиска</returns>
string ViewElementArray(int[,] array, int rows, int columns)
{
    string result = $"Элемента с индексом [{rows},{columns}], нет в массиве";
    if (rows < array.GetLength(0))
    {
        if (columns < array.GetLength(1))
        {
            result = $"Значение элемента с индексом [{rows},{columns}] = {array[rows, columns]}";
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