﻿//Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

int number= new Random (). Next (10, 100);
Console.WriteLine ($"Случайное число из отрезка 10-99 --> {number}");

int firstdigit = number / 10; // 7 целочисленное деление
int seconddigit = number % 10; // 8

if(firstdigit > secondDigit)Console.Writeline($"Наибольшая цифра числа --> {firstDigit}");
else Console.Writeline($"Наибольшая цифра числа --> {secondDigit}");

    
nt number = new Random().Next(10, 100);
Console.WriteLine($"Случйное число из отрезка 10 - 99 --> {number}");

// int firstDigit = number / 10; // 7
// int secondDigit = number % 10; // 8

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}");

int MaxDigit(int num) // int num = number
{
    int firstDigit = num / 10; // 7
    int secondDigit = num % 10; // 8
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");

nt MaxDigit(int num) // int num = number
{
    int firstDigit = num / 10; // 7
    int secondDigit = num % 10; // 8
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");