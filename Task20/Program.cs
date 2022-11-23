// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// int n = 12345;
// double res = Math.Sqrt(n);

// double n1 = 5.099985645;
// double nRound = Math.Round(n1, 2, MidpointRounding.ToZero);

Console.WriteLine("Введите координаты точки A");
Console.Write("X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Rast (int x1, int y1, int x2, int y2)
{
    Console.Write(x1);Console.Write(x2);Console.Write(y1);Console.WriteLine(y2);
    double rez = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
    return rez;
}

double res = Rast (xa, ya, xb, yb);
Console.WriteLine(res);

double rast = Math.Sqrt(res);
double rastR = Math.Round (rast, 2, MidpointRounding.ToZero);
Console.WriteLine(rastR);
