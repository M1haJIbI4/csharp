/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов, 
заполненный псевдослучайными числами и выводит их на экран.*/
int [] elements = new int[8];
Console.Write("[");
for (int i = 0; i < elements.Length; i++)
 {
    elements [i] = new Random().Next(0, 11);
    Console.Write(" " + Meth (i) + " ");
 }
Console.Write("]");
int Meth (int a)
{
    return elements[a];
}