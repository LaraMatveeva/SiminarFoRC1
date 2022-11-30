// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
array[0] = 0;
array[1] = 1;
Fibonachi(array,number);
PrintArray (array);
void Fibonachi (int[] arr, int num)
{
   for (int i = 2; i < num; i++)
   {
    arr[i] = arr[i-1]+arr[i-2];
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