// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.  
// [3 7 22 2 78] -> 76

int SIZE_ARRAY = 4;
int MIN_VALUE = 1;
int MAX_VALUE = 99;

double[] myArray = GetArray(SIZE_ARRAY, MIN_VALUE, MAX_VALUE);
Console.WriteLine($"Разница между максимальным и минимальным значениями элементов массива: {DifferenceMaxMin(myArray)}");



double DifferenceMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max - min;
}

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    string str = String.Empty;
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        res[i] = (double)rnd.Next(minValue, maxValue + 1);
        if (i < size - 1)
        {
            str += $"{res[i]}, ";
        }
        else
        {
            str += $"{res[i]}";
        }
    }
    Console.WriteLine($"Массив: [{str}]");
    return res;
}