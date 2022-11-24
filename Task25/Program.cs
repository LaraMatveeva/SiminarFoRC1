// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень B, в которую хотите возвеcти число A: ");
int stepen = Convert.ToInt32(Console.ReadLine());
while (stepen <= 0)
    {
        Console.WriteLine("Неверно. Попробуйте еще раз");
        Console.WriteLine("Введите натуральную степень B, в которую хотите возвеcти число A: ");
        stepen = Convert.ToInt32(Console.ReadLine());
    }
int StepenB(int numA, int stepB)
{
    int prom = numA;
    // int i = 2;
    for (int i = 1; i < stepB; i++)
    {
        prom = prom * numA;

    }
    return (prom);
}
int itog = StepenB(number,stepen);

Console.WriteLine($"{number} в степени {stepen} равно {itog}");
