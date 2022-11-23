// Задача 23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите чсило  N");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
void Qube (int param)
{
    Console.Write($"{param} | ");
    param = param * param * param;
    Console.WriteLine(param);
}
while (i <= number)
{
  Qube (i);  
  i++;  
}