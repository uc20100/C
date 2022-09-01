
// Задача 62(). Напишите программу, которая заполнит спирально массив 4 на 4. ( - необязательная)  
// Например, на выходе получается вот такой массив:  
// 01 02 03 04  
// 12 13 14 05  
// 11 16 15 06  
// 10 09 08 07

Console.WriteLine();
Console.Write("Введите количество строк, двумерного массива: ");
int rowsArray = Convert.ToInt32(ReadFromConsole());
Console.Write("Введите количество столбцов, двумерного массива: ");
int columnsArray = Convert.ToInt32(ReadFromConsole());

int[,] valueArray = GetArray(rowsArray, columnsArray);
Snap snapInfo = new Snap(valueArray);
GetSnapArray(ref valueArray, snapInfo);
Console.WriteLine();
PrintArray(valueArray, "Спирально");
Console.WriteLine();



/// <summary>
/// Создание двумерного массива
/// </summary>
/// <param name="rows">Число строк</param>
/// <param name="columns">Число сталбцов</param>
/// <returns>Массив</returns>
static int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    return array;
}

/// <summary>
/// Заполняет массив "змейкой" из чисел
/// </summary>
/// <param name="array">Чистый массив (заполненный нулями)</param>
/// <param name="infoArray">Переменная состояния массива</param>
static void GetSnapArray(ref int[,] array, Snap infoArray)
{
    bool breakStatus;

    while (true)
    {
        breakStatus = true;
        // Шагаем вправо
        infoArray.Right();
        while (infoArray.columnLength > infoArray.CountColumn &&
               array[infoArray.CountRow, infoArray.CountColumn + 1] == 0)
        {
            StepSnap(ref array, infoArray);
            breakStatus = false;
        }
        // Шагаем вниз
        infoArray.Down();
        while (infoArray.rowLength > infoArray.CountRow &&
               array[infoArray.CountRow + 1, infoArray.CountColumn] == 0)
        {
            StepSnap(ref array, infoArray);
            breakStatus = false;
        }
        // Шагаем влево
        infoArray.Left();
        while (0 < infoArray.CountColumn &&
               array[infoArray.CountRow, infoArray.CountColumn - 1] == 0)
        {
            StepSnap(ref array, infoArray);
            breakStatus = false;
        }
        // Шагаем вверх
        infoArray.Up();
        while (0 < infoArray.CountRow &&
               array[infoArray.CountRow - 1, infoArray.CountColumn] == 0)
        {
            StepSnap(ref array, infoArray);
            breakStatus = false;
        }

        if (breakStatus)
        {
            array[infoArray.CountRow, infoArray.CountColumn] = ++infoArray.Count;
            break;
        }
    }
}


/// <summary>
/// Процедура записи одного числа в массив, в виде "змейки"
/// </summary>
/// <param name="array">Массив</param>
/// <param name="info">Переменная состояния массива</param>
static void StepSnap(ref int[,] array, Snap info)
{
    info.Count++;
    array[info.CountRow, info.CountColumn] = info.Count;
    info.CountRow += info.RowIncrement;
    info.CountColumn += info.ColumnIncrement;
}



/// <summary>
/// Вывод массива на консоль
/// </summary>
/// <param name="array">Массив</param>
/// <param name="note">Заметки (не обязательно)</param>
static void PrintArray(int[,] array, string note = "")
{
    const int tabColumns = 6;
    Console.WriteLine($"Массив {array.GetLength(0)}х{array.GetLength(1)}:   {note}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],tabColumns}");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Чтение только цифр с консоли
/// </summary>
/// <returns>Строка из цифр</returns>
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
                if (result != string.Empty)
                {
                    Console.WriteLine();
                    return result;
                }
                else
                {
                    break;
                }
            default:
                if (char.IsDigit(c: k.KeyChar))
                {
                    Console.Write(value: k.KeyChar);
                    result += k.KeyChar;
                }
                break;
        }
    }
}

/// <summary>
/// Класс "змея" 
/// </summary>
class Snap
{
    private int countRow;
    private int countColumn;
    private int count;
    private int rowIncrement;
    private int columnIncrement;
    public readonly int rowLength;
    public readonly int columnLength;

    public Snap(int[,] array)
    {
        countRow = 0;
        countColumn = 0;
        count = 0;
        rowIncrement = 0;
        columnIncrement = 0;
        rowLength = array.GetLength(0) - 1;
        columnLength = array.GetLength(1) - 1;
    }

    public void Right()
    {
        rowIncrement = 0;
        columnIncrement = 1;
    }

    public void Left()
    {
        rowIncrement = 0;
        columnIncrement = -1;
    }

    public void Down()
    {
        rowIncrement = 1;
        columnIncrement = 0;
    }

    public void Up()
    {
        rowIncrement = -1;
        columnIncrement = 0;
    }

    public int RowIncrement
    {
        get
        {
            return rowIncrement;
        }
    }

    public int CountRow
    {
        get
        {
            return countRow;
        }
        set
        {
            countRow = value;
        }
    }

    public int CountColumn
    {
        get
        {
            return countColumn;
        }
        set
        {
            countColumn = value;
        }
    }

    public int Count
    {
        get
        {
            return count;
        }
        set
        {
            count = value;
        }
    }

    public int ColumnIncrement
    {
        get
        {
            return columnIncrement;
        }
    }
}

