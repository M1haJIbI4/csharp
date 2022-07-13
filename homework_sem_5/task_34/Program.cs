/*Console.WriteLine("Укажите размер массива");
int size = Convert.ToInt32(Console.ReadLine());*/
int[] num = new int[5];
RandomArray(num);
Console.WriteLine("Текущие случайные числа в массиве: ");
PrintArray(num);
int count = 0;

for (int z = 0; z < num.Length; z++)
if (num[z] % 2 == 0)
count++;

Console.WriteLine($"всего {num.Length} чисел(о), из них чётных - {count}");

void RandomArray(int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}