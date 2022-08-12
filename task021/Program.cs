/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.  

A (3,6,8); B (2,1,-7), -> 15.84  
A (7,-5, 0); B (1,-1,9) -> 11.53 
*/




Point A = new Point();
Point B = new Point();
try
{
    Console.WriteLine("Введите координаты А.x:");
    A.x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты А.y:");
    A.y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты А.z:");
    A.z = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты B.x:");
    B.x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты B.y:");
    B.y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты B.z:");
    B.z = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Расстояние между двумя точками в 3D пространстве: {lengtSegment(A, B)}");
}
catch
{
    Console.WriteLine("Ошибка ввода");
}

double lengtSegment(Point a, Point b)
{
    double outValue = Math.Round(Math.Sqrt(Math.Pow((A.x - B.x), 2) + Math.Pow((A.y - B.y), 2) + Math.Pow((A.z - B.z), 2)), 2);

    return outValue;
}



public struct Point
{
    public int x, y, z;
    public Point()
    {
        x = 0;
        y = 0;
        z = 0;
    }
}