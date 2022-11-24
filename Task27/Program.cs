// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число A: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = Math.Abs(number);

int SumDigits(int numsum)
{ 
    int digist = numsum;
    int summa = 0;
    while(digist >= 1)
    {
       summa = summa + digist % 10;
       digist = digist / 10;
    }
    return (summa);
}
int summadig = SumDigits(number);
Console.WriteLine($"Сумма цифр числа {number}  равна {summadig}");

