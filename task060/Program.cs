// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.  
// Массив размером 2 x 2 x 2  
// 66(0,0,0) 25(0,1,0)  
// 34(1,0,0) 41(1,1,0)  
// 27(0,0,1) 90(0,1,1)  
// 26(1,0,1) 55(1,1,1)  

const int minValueArray = 10;
const int maxValueArray = 99;
const int rowsValue = 2;
const int columns1Value = 2;
const int columns2Value = 2;

int[,,] valueArray = GetArray(rows: rowsValue,
                          columns1: columns1Value,
                          columns2: columns2Value,
                          minValue: minValueArray,
                          maxValue: maxValueArray);
Console.WriteLine();
PrintArray(valueArray);
Console.WriteLine();



/// <summary>
/// Получение массива случайных чисел
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="columns1">Количество столбцов1</param>
/// <param name="columns2">Количество столбцов2</param>
/// <param name="minValue">Минимальное случайное значение</param>
/// <param name="maxValue">Максимальное случайное значение</param>
/// <returns>Трехмерный массив</returns>
int[,,] GetArray(int rows, int columns1, int columns2, int minValue, int maxValue)
{
    int[,,] array = new int[rows, columns1, columns2];
    int value;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            for (int k = 0; k < columns2; k++)
            {
                do
                {
                    value = new Random().Next(minValue, maxValue + 1);
                } while (DoublingNumber(array, value));
                array[i, j, k] = value;
            }
        }
    }
    return array;
}

/// <summary>
/// Вывод массива на консоль
/// </summary>
/// <param name="array">Массив</param>
/// <param name="note">Заметки (не обязательно)</param>
void PrintArray(int[,,] array, string note = "")
{
    Console.WriteLine($"Массив {array.GetLength(0)}х{array.GetLength(1)}x{array.GetLength(2)}:   {note}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
}

/// <summary>
/// Проверка на совпадение числа в массиве
/// </summary>
/// <param name="array">Массив</param>
/// <param name="number">Число</param>
/// <returns>Истина, если такое число есть в массиве</returns>
bool DoublingNumber(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number)
                {
                    return true;
                }
            }

        }
    }
    return false;
}