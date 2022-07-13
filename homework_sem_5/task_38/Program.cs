/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным значением элементов массива.*/
Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
RandomArray(num);
Console.WriteLine("Массив случайных числа(сел), с учётом заданного ранее размера: ");
PrintArray(num);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < num.Length; z++)
{
    if (num[z] > max)
        {
            max = num[z];
        }
    if (num[z] < min)
        {
            min = num[z];
        }
}

Console.WriteLine($"всего {num.Length} числа(сел). Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением элементов массива = {max - min}");

void RandomArray(double[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
