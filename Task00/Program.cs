// Задача 00
// Написать программу, которая 
//1. На вход принимает число
//2. Выдает его квадрат

//Например:
//4->16
//-3->9
//-7->49

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine()); //конверт строку в число
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");

