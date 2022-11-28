// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
//  Вывести массив в консоль    
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

// Методы для создания и вывода массива

int[] CreateArrayRndInt (int size, int min, int max)
{
int[] arr = new int[size];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(min, max + 1);
}
return arr;
}

void PrintArray (int[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
else Console.Write($"{arr[i]}");
}
Console.Write("]");
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);

// Методы нахождения сумм чисел в массивах

int GetSumNegativeElem(int[] arr)
{
int sum = 0;
for (int i = 0; i < arr.Length; i++)
if (arr[i] < 0) sum += arr[i]; // sumNegativ = sumNegativ + arr[i];
return sum;
}

int GetSumPositiveElem(int[] arr)
{
int sum = 0;
for (int i = 0; i < arr.Length; i++)
if (arr[i] > 0) sum += arr[i]; // sumPositive = sumPositive + arr[i];
return sum;
}

// Запуск программы с вызовами методов

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int sumNegative = GetSumNegativeElem(array);
int sumPositive = GetSumPositiveElem(array);
Console.WriteLine($"Сумма пололжительных чисел = {sumPositive}");
Console.WriteLine($"Сумма отрицательных чисел = {sumNegative}");