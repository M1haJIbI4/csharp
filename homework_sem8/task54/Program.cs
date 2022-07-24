/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.*/
Console.WriteLine($"Задайте массив.");
int m = InputNum("Введите количество строк: ");
int n = InputNum("Введите количество столбцов: ");
int range = InputNum("Введите диапазон цифр: от 1 до ");
int[,] arr = new int[m, n];
CreateArr(arr);
WriteArr(arr);
Console.WriteLine($"массив со строками в порядке убывания: ");
OrderArrLines(arr);
WriteArr(arr);
void OrderArrLines(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(1) - 1; k++)
      {
        if (arr[i, k] < arr[i, k + 1])
        {
          int temp = arr[i, k + 1];
          arr[i, k + 1] = arr[i, k];
          arr[i, k] = temp;
        }
      }
    }
  }
}

int InputNum(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void CreateArr(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(range);
    }
  }
}
void WriteArr(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
  }
}