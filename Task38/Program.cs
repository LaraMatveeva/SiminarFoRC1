// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите количество элементов N в массиве : ");
int elements = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальный диапазон массива : ");
double min = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите максимальный диапазон массива : ");
double max = Convert.ToDouble(Console.ReadLine());

double[] array = new double[elements];

void RandomArray(double[] arraym, int length, double mmin, double mmax)
{
 Random rnd = new Random();
 for (int i = 0; i < length; i++)
{
arraym[i] = rnd.NextDouble() * (mmax - mmin) + mmin;
arraym[i] = Math.Round(arraym[i],2);
}
}

void PrintArray(double[] arrayprint)
{
Console.Write("[");  
 for (int i = 0; i < arrayprint.Length; i++)
{
if (i < (arrayprint.Length - 1)) Console.Write($"{arrayprint[i]}   ");
else Console.Write($"{arrayprint[i]}]");
}
}

RandomArray(array, elements, min, max);
PrintArray(array);

double Minimum(double[] arr)
{
    double minsum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
     if (minsum > arr[i]) minsum = arr[i];
    }
    return minsum;

}

double Maximum(double[] arr)
{
    double maxsum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
     if (maxsum < arr[i]) maxsum = arr[i];
    }
    return maxsum;
}     

double rezult = Maximum(array) - Minimum(array);
rezult = Math.Round(rezult,2);
Console.WriteLine($"--> {rezult}");

