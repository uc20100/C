Console.WriteLine("Введите первое число: ");
string? numStr = Console.ReadLine();
if (numStr == "?")
{
    string task6_str = "Задача 6: Напишите программу, которая на вход принимает число и выдаёт,\r\n" +
                    "является ли число чётным (делится ли оно на два без остатка).\r\n" +
                    "4 -> да\r\n" +
                    "-3 -> нет\r\n" +
                    "7 -> нет\r\n";

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(task6_str);
    Console.ResetColor();
}
else
{
    int num = Convert.ToInt32(numStr);
    if (num % 2 == 0) Console.WriteLine($"Число {num} - четное");
    else Console.WriteLine($"Число {num} - не четное");
}

