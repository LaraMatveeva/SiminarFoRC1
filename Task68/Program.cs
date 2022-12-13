// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int AkkermanFun(int numberM, int numberN)
// {
//     if (numberM == 0) return (numberN + 1);

//     if ((numberM > 0) && (numberN == 0)) 
//     return AkkermanFun(numberM - 1, 1);
    
//     if ((numberM > 0) && (numberN > 0)) 
//     return AkkermanFun(numberM - 1, AkkermanFun(numberM, numberN - 1));
//     return (numberN + 1);
// }

int AkkermanFun(int numberM, int numberN)
{
    while (numberM > 0 && numberN >= 0)
    {
      if (numberN == 0)
      return AkkermanFun(numberM - 1, 1);
      else 
       return AkkermanFun(numberM - 1, AkkermanFun(numberM, numberN - 1));
    }
    return (numberN + 1);
}
    


void PrintNum(int m, int n, int result)
{
    Console.WriteLine($"m = {m}, n = {n} --> A (m,n) = {result}");
}

Console.WriteLine("Введите натуральное число М: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
int akkerman = AkkermanFun(numM, numN);
PrintNum(numM, numN, akkerman);

