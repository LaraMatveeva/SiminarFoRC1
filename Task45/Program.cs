// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.WriteLine("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int[] copyArray = new int[number];
array = ArrayEnter(array,number);
CoppyArr(copyArray,array,number);
PrintArray(array);
Console.WriteLine(" Копия массива: ");
PrintArray(copyArray);

int[] ArrayEnter(int[] arr,int num)
{
    for (int i = 0; i < num; i++)
    {
       Console.Write("Введите  следующий элемент массива: ");
       arr[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    return arr;
}
void CoppyArr(int[] coppyArr,int[] arr,int num)
{
    for (int i = 0; i < num; i++)
    {
       coppyArr[i]=arr[i];
    }
}
void PrintArray (int[] arr1)
{
    Console.Write("[");  
 for (int i = 0; i < arr1.Length; i++)
{
if (i < (arr1.Length - 1)) Console.Write($"{arr1[i]},");
else Console.Write($"{arr1[i]}]");
}
}
