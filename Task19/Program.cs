// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите чсило  N");
int number = Convert.ToInt32(Console.ReadLine());
int perem = number;
int ten = 1;
int newnumber = 0;
while (perem != 0)
{
    perem = perem / 10;
    ten = ten * 10;
}
perem = number;
while (ten >= 10)
{
    newnumber = newnumber + perem % 10 * (ten / 10);
    ten = ten / 10;
    perem = perem / 10;
}
newnumber = newnumber + perem % 10;
if(number == newnumber) Console.WriteLine("ДА");
else Console.WriteLine("НЕТ");
