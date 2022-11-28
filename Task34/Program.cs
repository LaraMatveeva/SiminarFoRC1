// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите количество элементов N в массиве : ");
int elements = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elements];

void RandomArray(int[] arraym, int length)
{
 Random rnd = new Random();
 for (int i = 0; i < length; i++)
{
arraym[i] = rnd.Next(100,1000);
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
int summ = 0;
for (int i = 0; i < array.Length; i++)
 {
    if (array[i] % 2 == 0) summ++;
 }
Console.WriteLine($"--> {summ}");



