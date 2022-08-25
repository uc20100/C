// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.  
// 0, 7, 8, -2, -2 -> 2  
// 1, -7, 567, 89, 223-> 3


int[] myArray = new int[0];

SetArray(ref myArray);
Console.WriteLine($"[{String.Join(",", myArray)}] -> {CheckNumberMoreZero(myArray)}");



int CheckNumberMoreZero(int[] array)
{
    int count = 0;
    foreach (int i in array)
    {
        if (i > 0)
        {
            count++;
        }
    }
    return count;
}

string ReadFromConsole()
{
    string result = string.Empty;
    while (true)
    {
        var k = Console.ReadKey(true);
        switch (k.Key)
        {
            case ConsoleKey.Backspace:
                if (result.Length > 0)
                {
                    result = result.Remove(startIndex: result.Length - 1, count: 1);
                    Console.Write(value: $"{k.KeyChar} {k.KeyChar}");
                }
                break;
            case ConsoleKey.Enter:
                Console.WriteLine();
                return result;
            case ConsoleKey.Escape:
                result = "out";
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.WriteLine(value: "Нажали Esc, выходим из цикла ввода массива  ");
                return result;
            default:
                if (char.IsDigit(c: k.KeyChar) || (k.KeyChar == '-' && result.Length == 0))
                {
                    Console.Write(value: k.KeyChar);
                    result += k.KeyChar;
                }
                break;
        }
    }
}

void SetArray(ref int[] array)
{
    while (true)
    {
        Console.WriteLine($"Введите число №{array.Length + 1} (Для окончания цикла ввода нажмите Esc):");
        try
        {
            string st = ReadFromConsole();
            if (st == "out")
            {
                break;
            }
            int number = Convert.ToInt32(st);
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = number;
        }
        catch
        {
            Console.WriteLine("Ошибка преобразования числа");
        }
    }
}


