// Проверить на вход числа: являются ли они сторонами треугольника
Console.Clear();
System.Console.WriteLine("Введите первую сторону: ");
int lineA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите вторую: ");
int lineB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третью сторону: ");
int lineC = Convert.ToInt32(Console.ReadLine());

bool Triangle (int a, int b, int c)
{
    if (((a + b) < c) || ((a + c) < b) || ((c + b) < a)) return true; 
    else return false;
}

bool tri = Triangle(lineA, lineB, lineC);
Console.WriteLine(tri ? "нет" : "да");