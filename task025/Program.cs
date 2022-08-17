/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.  
3, 5 -> 243 (3⁵)  
2, 4 -> 16
*/


try
{
    Console.WriteLine("Введите число:");
    int nam = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень числа:");
    int deg = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(DegreeNumber(nam, deg));
}
catch
{
    Console.WriteLine("Ошибка ввода");
}


string DegreeNumber(int number, int degree)
{
    int val = 1;
    
    if (degree != 0)
    {
        for (int i = 0; i < degree; i++)
        {
            val *= number;
        }
    }
    return $"Число {number} в степени {degree} -> {val}";
}
