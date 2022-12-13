// Задача 64: Задайте значение N. Напишите программу, которая 
//выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NumbersNatur(int number)
{
    if (number == 0) return;

    if (number == 1) Console.WriteLine($"{number}\"");
    else
        Console.Write($"{number}, ");
    NumbersNatur(number - 1);
}

void PrintNum(int num)
{
    Console.Write($" N = {num} -> \"");
}

Console.WriteLine("Введите натуральное число: ");
int numberNatur = Convert.ToInt32(Console.ReadLine());
PrintNum(numberNatur);
NumbersNatur(numberNatur);