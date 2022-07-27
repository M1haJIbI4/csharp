/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму чисел натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int M = InputNum("Введите M: ");
int N = InputNum("Введите N: ");
int temp = M;
if (M > N) 
{
  M = N; 
  N = temp;
}
PrintSum(M, N, temp = 0);
void PrintSum(int M, int N, int sum)
{
  sum = sum + N;
  if (N <= M)
  {
    Console.Write($"Сумма чисел = {sum} ");
    return;
  }
  PrintSum(M, N - 1, sum);
}
int InputNum(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}