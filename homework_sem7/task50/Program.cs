Console.Write("Введите № строки: ");
bool inFirst = int.TryParse(Console.ReadLine(), out int
numRows);

Console.Write("Введите № столбца: ");
bool inSecond = int.TryParse(Console.ReadLine(), out int
numColumns);

if (inFirst && inSecond)
{
    int[,] randomArr = GetFillArray(10, 10);
    PrintArray(randomArr);
    Console.WriteLine();
    FindElementPosition(randomArr, numRows, numColumns);
}
else Console.WriteLine($"Некорректный ввод!");


int[,] GetFillArray(int m, int n)
{
    int[,] arr = new int[m, n];
    Random randomElement = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = randomElement.Next(10);
        }
    }
    return arr;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j]);
        }
        Console.WriteLine();
    }
}
void FindElementPosition(int[,] arr, int positionRows, int positionColumns)
{
    if (positionRows < arr.GetLength(0) && positionColumns < arr.GetLength(1))
    {
        Console.WriteLine($"На позиции строка № {positionRows}, столбец № {positionColumns} " +
                          $"находится элемент со значением: {arr[positionRows - 1, positionColumns - 1]}");
    }
    else Console.WriteLine($"Cтрока № {positionRows}, столбец № {positionColumns} - такой позиции в массиве нет.");
}