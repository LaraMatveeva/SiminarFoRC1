// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1 : ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1 : ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2 : ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение K2 : ");
int k2 = Convert.ToInt32(Console.ReadLine());
double x = MethodXX(b1, k1, b2, k2);
double y = MethodYY(b1, k1, x);
PrintArray(x, y, b1, k1, b2, k2);


double MethodXX(int b11, int k11, int b22, int k22)
{
    double x11 = b22 - b11;
    x11 /= k11 - k22;
    x11 = Math.Round(x11,2);
    return x11;
}

double MethodYY(int b11, int k11, double x11)
{
    double y11 = k11 * x11 + b11;
    y11 = Math.Round(y11,2);
    return y11;
}

void PrintArray(double x11, double y11, int b11, int k11, int b22, int k22)
{
Console.Write($"b1={b11}, k1={k11}, b2={b22}, k2={k22} -->");  
Console.WriteLine($"({x11};{y11})");
}