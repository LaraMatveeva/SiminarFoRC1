// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите  номер четверти");
Console.Write("q: ");
int q = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

string Iks (int qx)
{
// if(xc > 0 && yc > 0) return 1;
// if(xc < 0 && yc > 0) return 2;
// if(xc < 0 && yc < 0) return 3;
// if(xc > 0 && yc < 0) return 4;

if (qx==1) return ("Координаты точки лежат в диапазоне [X > 0; Y>0]");
if (qx==2) return ("Координаты точки лежат в диапазоне [X > 0; Y<0]");
if (qx==3) return ("Координаты точки лежат в диапазоне [X < 0; Y>0]");
if (qx==4) return ("Координаты точки лежат в диапазоне [X < 0; Y<0]");
return ("Нет такой четверти");
}

string xy = Iks(q);
// string result = quarter > 0
// ? $"Указанные координаты соответствуют четверти -> {quarter}"
// : "Введены некорректные координаты";
Console.WriteLine(xy);