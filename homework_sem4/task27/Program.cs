/*Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.*/
Console.Write("Введите число n: ");
int numN = Convert.ToInt32(Console.ReadLine());

  int SumNum(int numN)
  {
    int count = Convert.ToString(numN).Length;
    int ost = 0;
    int res = 0;

    for (int i = 0; i < count; i++)
    {
      ost = numN - numN % 10;
      res = res + (numN - ost);
      numN = numN / 10;
    }
   return res;
  }

int sumNumber = SumNum (numN);
Console.WriteLine($"Сумма цифр в числе {numN}: " + sumNumber);