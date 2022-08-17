/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
(на примерах демонстрация выводов 5 и 3 размерных массивов, вам же нужно сделать 8)  
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]  
6, 1, 33 -> [6, 1, 33]
*/


const int SIZE_ARRAY = 8;
int[] myArray = new int[SIZE_ARRAY];

try
{
    SetArray(ref myArray);
    Console.WriteLine($"Массив MyArray[{myArray.Length}] -> {PrintArray(myArray)}");
}
catch
{
    Console.WriteLine("Ошибка ввода");
}

string PrintArray(int[] array)
{
    string ret = String.Empty;

    for (int i = 0; i < array.Length; i++)
    {
        if (i + 1 < array.Length)
        {
            ret += $"{array[i]}, ";
        }
        else
        {
            ret += $"{array[i]}";
        }
    }
    ret = $"[{ret}]";

    return ret;
}

void SetArray(ref int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите [{i}] элемент массива myArray, размером {array.Length}x1:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}