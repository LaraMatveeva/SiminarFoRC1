// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество элементов N в массиве : ");
int elements = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальный диапазон массива : ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальный диапазон массива : ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elements];

void RandomArray(int[] arraym, int length, int mmin, int mmax)
{
 Random rnd = new Random();
 for (int i = 0; i < length; i++)
{
arraym[i] = rnd.Next(mmin,mmax);
}
}

void PrintArray(int[] arrayprint)
{
Console.Write("[");  
 for (int i = 0; i < arrayprint.Length; i++)
{
if (i < (arrayprint.Length - 1)) Console.Write($"{arrayprint[i]},");
else Console.Write($"{arrayprint[i]}]");
}
}

RandomArray(array, elements, min, max);
PrintArray(array);
int summ = 0;
for (int i = 0; i < array.Length; i++)
 {
    if (i % 2 != 0) summ += array [i];
 }
Console.WriteLine($"--> {summ}");



