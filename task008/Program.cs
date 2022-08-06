Console.WriteLine("Введите первое число: ");
string? firstStr = Console.ReadLine();
if (firstStr == "?")
{
    string task8_str = "Задача 8: Напишите программу, которая на вход принимает число (N), \r\n" +
                    "а на выходе показывает все чётные числа от 1 до N.\r\n" +
                    "5 -> 2, 4\r\n" +
                    "8 -> 2, 4, 6, 8\r\n";

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(task8_str);
    Console.ResetColor();
}
else
{
    int num = Convert.ToInt32(firstStr);

    string out_str = "";
    int count = 1;
    while (num >= (2 * count))
    {
        if (count == 1) out_str += $"Все четные числа, числа ({num}): {2 * count}";
        else out_str += $", {2 * count}";
        count++;
    }
    Console.WriteLine(out_str);
}


