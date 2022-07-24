/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.*/
Console.WriteLine($"Введите размер матриц и диапазон случайных значений:");
int m = InputNum("Введите число строк 1-й матрицы: ");
int n = InputNum("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int l = InputNum("Введите число столбцов 2-й матрицы: ");
int range = InputNum("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArr(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArr(firstMartrix);

int[,] secondMartrix = new int[n, l];
CreateArr(secondMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArr(secondMartrix);

int[,] resultMatrix = new int[m,l];

MultiplMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Проиведение 1 и 2 матриц:");
WriteArr(resultMatrix);

void MultiplMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int prod = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        prod += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = prod;
    }
  }
}

int InputNum(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArr(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArr (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}