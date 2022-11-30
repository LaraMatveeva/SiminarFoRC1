// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

int number = -1;
while(number <= 0)
{
    Console.WriteLine("Введите количество элементов массива: ");
    number = Convert.ToInt32(Console.ReadLine());
}    
int[] array = new int[number];
ArrayEnter (array, number);
int sumPos = PositivNumber(array, number);
PrintArray(array, sumPos);

int PositivNumber(int[] arr,int num)
{
    int sumPositiv = 0;
    for (int i = 0; i < num; i++)
    {
       if(arr[i] > 0) sumPositiv +=1;
    }
    return sumPositiv;
}


void ArrayEnter(int[] arr, int num)
{
    for (int i = 0; i < num; i++)
    {
       Console.Write("Введите  следующий элемент массива: ");
       arr[i] = Convert.ToInt32(Console.ReadLine()); 
    }
}

void PrintArray (int[] arr, int sum)
{
 for (int i = 0; i < arr.Length; i++)
{
if (i < (arr.Length - 1)) Console.Write($"{arr[i]},");
else Console.Write($"{arr[i]}-->");
}
Console.WriteLine(sum);
}