// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// double Faktorial(int n)
// {
// if (n==1)return 1;
// else
// return n*Faktorial(n-1);
// }

// for(int i =1;i<40;i++)
// {
// Console.WriteLine($"{i}!={Faktorial(i)}");
// }

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);

void NaturalNumbers (int num)
{
if (num == 0) return;
NaturalNumbers (num - 1);
Console.Write($"{num} ");
}