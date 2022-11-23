// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number <= 1)
{ 
    Console.WriteLine("Введите другое число больше 1:");
    number = Convert.ToInt32(Console.ReadLine()); 
}
int count = 2;
while (count <= number)
{
   Console.WriteLine(count);
   count = count + 2; 
}
