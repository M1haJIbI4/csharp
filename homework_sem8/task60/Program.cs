/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.*/
Console.WriteLine();
int dimensionX = value("Введите размер массива X:");
int dimensionY = value("Введите размер массива Y:");
int dimensionZ = value("Введите размер массива Z:");
int[,,] randomArr = new int[dimensionX, dimensionY, dimensionZ];
Console.WriteLine();

if ((dimensionX * dimensionY * dimensionZ) > 90)
{
    Console.WriteLine("Заполнить введенный массив неповторяющимися двузначными числами невозможно! Проверьте размер введенного массива.");
    return;
}
FillArr(randomArr, dimensionX, dimensionY, dimensionZ);
ShuffleArr(randomArr);
Console.WriteLine();
Console.WriteLine("Введенный массив:");
Console.WriteLine();
PrintArr(randomArr);

int[,,] FillArr(int[,,] arr, int dimensionX, int dimensionY, int dimensionZ)
{
    int offset = new Random().Next(10, 100);
    int upperBound = 99;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int n = 0; n < arr.GetLength(2); n++)
            {
                arr[i, j, n] = offset;
                if (offset >= arr[0, 0, 0] && offset <= upperBound)
                {
                    offset++;
                }
                else
                {
                    offset--;
                }
                if (offset > upperBound)
                {
                    offset = arr[0, 0, 0] - 1;
                }
            }

        }
    }
    return arr;
}

void PrintArr(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int n = 0; n < arr.GetLength(2); n++)
            {
                Console.Write($"{arr[i, j, n]}[{i},{j},{n}] ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int value(string nameUserData)
{
    Console.Write($"{nameUserData}");
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] ShuffleArr(int[,,] arr)
{
    int temp = 0, i1 = 0, j1 = 0, n1 = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        i1 = new Random().Next(0, arr.GetLength(0));
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            j1 = new Random().Next(0, arr.GetLength(1));
            for (int n = 0; n < arr.GetLength(2); n++)
            {
                n1 = new Random().Next(0, arr.GetLength(2));
                temp = arr[i1, j1, n1];
                arr[i1, j1, n1] = arr[i, j, n];
                arr[i, j, n] = temp;
            }
        }
    }
    return arr;
}