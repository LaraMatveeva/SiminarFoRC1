// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNatur(int numberM, int numberN)
{
    if (numberN <= numberM) return numberN;

    return numberN + SumNatur(numberM, numberN - 1);
}

void PrintNum(int m, int n, int summ)
{
    Console.WriteLine($"M = {m}; N = {n} --> {summ}");
}

Console.WriteLine("Введите натуральное число М: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
int sum;
if (numM < numN) sum = SumNatur(numM, numN);
else sum = SumNatur(numN, numM);
PrintNum(numM, numN, sum);

