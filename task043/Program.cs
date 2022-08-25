// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.  
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




double xMinValue = -10;
double xMaxValue = 10;
double step = 0.001;

try
{
    Console.WriteLine("Введите коэффициент b1: ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент k1: ");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b2: ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент k2: ");
    int k2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(LineIntersection(xMinValue, xMaxValue, step, b1, k1, b2, k2));
}
catch
{
    Console.WriteLine("Ошибка ввода");
}






string LineIntersection(double xMin, double xMax, double step, int b1, int k1, int b2, int k2)
{
    double y1, y2;
    double x = xMin;
    while (true)
    {
        y1 = Math.Round((k1 * x + b1), 3);
        y2 = Math.Round((k2 * x + b2), 3);
        if (y1 != y2 && x < xMax)
        {
            // Console.WriteLine($"если y1!=y2 х={Math.Round(x, 3)}, y1={Math.Round(y1, 3)}, y2={Math.Round(y2, 3)}");
            x += step;
        }
        else
        {
            if (x >= xMax)
            {
                return $"В диапазоне переменной Х от {Math.Round(xMin, 2)} до {Math.Round(xMax, 2)}, нет пересечений";
            }
            else
            {
                return $"Пересечение отрезков = (x: {Math.Round(x, 2)}, y: {Math.Round(y1, 2)})";
            }
        }
    }
}

