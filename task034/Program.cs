// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.  
// [345, 897, 568, 234] -> 2 


int SIZE_ARRAY = 4;
int MIN_VALUE = 100;
int MAX_VALUE = 999;

int[] myArray = GetArray(SIZE_ARRAY, MIN_VALUE, MAX_VALUE);
Console.WriteLine($"Число четных цифр в массиве равно: {EvenNumberInArray(myArray)}");



int EvenNumberInArray(int[] array)
{
    int evenNumber = 0;
    foreach (int i in array)
    {
        if (i % 2 == 0)
        {
            evenNumber++;
        }
    }
    return evenNumber;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    string str = String.Empty;
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
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