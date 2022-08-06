Console.WriteLine("Введите первое число: ");
string? firstStr = Console.ReadLine();
if (firstStr == "?")
{
    string task2_str = "Задача 2: Напишите программу, которая на вход принимает два числа\r\n" +
                        "и выдаёт, какое число большее, а какое меньшее.\r\n" +
                        "a = 5; b = 7 -> max = 7\r\n" +
                        "a = 2 b = 10 -> max = 10\r\n" +
                        "a = -9 b = -3 -> max = -3\r\n";

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(task2_str);
    Console.ResetColor();
}
else
{
    int first = Convert.ToInt32(firstStr);
    Console.WriteLine("Введите второе число: ");
    int second = Convert.ToInt32(Console.ReadLine());

    if (first == second) Console.WriteLine($"Результат: {first}={second}");
    else
    {
        if (first > second) Console.WriteLine($"Результат: {first}>{second}");
        else Console.WriteLine($"Результат: {first}<{second}");
    }
}


