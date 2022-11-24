// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите количество элементов N в массиве : ");
int elements = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elements];

void RandomArray(int[] arraym, int length)
{
 Random rnd = new Random();
 for (int i = 0; i < length; i++)
{
arraym[i] = rnd.Next(100);
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

RandomArray(array, elements);

PrintArray(array);

