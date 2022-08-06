Console.WriteLine("Введите первое число: ");
string? firstStr = Console.ReadLine();
if (firstStr == "?")
{
    string task4_str = "Задача 4: Напишите программу, которая принимает на вход три числа \r\n" +
                    "и выдаёт максимальное из этих чисел.\r\n" +
                    "2, 3, 7 -> 7\r\n" +
                    "44 5 78 -> 78\r\n" +
                    "22 3 9 -> 22\r\n";

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(task4_str);
    Console.ResetColor();
}
else
{
    int first = Convert.ToInt32(firstStr);
    Console.WriteLine("Введите второе число: ");
    int second = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число: ");
    int third = Convert.ToInt32(Console.ReadLine());

    int max = first;
    if (max < second) max = second;
    if (max < third) max = third;

    Console.WriteLine($"Максимальное число: {max}");
}

