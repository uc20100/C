// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.  
// [3, 7, 23, 12] -> 19  
// [-4, -6, 89, 6] -> 0

int SIZE_ARRAY = 4;
int MIN_VALUE = -99;
int MAX_VALUE = 99;

int[] myArray = GetArray(SIZE_ARRAY, MIN_VALUE, MAX_VALUE);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {SumNotEvenPositionInArray(myArray)}");



int SumNotEvenPositionInArray(int[] array)
{
    int sumNotEvenNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0 && i != 0)
        {
            sumNotEvenNumber += array[i];
        }
    }
    return sumNotEvenNumber;
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