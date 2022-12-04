// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4
//1, 7 -> такого элемента в массиве нет


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}


Random rnd = new Random();
int rowRnd = rnd.Next(1, 10);
int colomnRnd = rnd.Next(1, 10);
int[,] array2D = CreateMatrixRndInt(rowRnd, colomnRnd, -10, 10);
PrintMatrix(array2D);


Console.Write("Введите позицию элемента, начиная с 1:  строка   ");
int positionI = Convert.ToInt32(Console.ReadLine());
Console.Write("столбец  ");
int positionJ = Convert.ToInt32(Console.ReadLine());
if (positionI > rowRnd
    || positionI <= 0
    || positionJ > colomnRnd
    || positionJ <= 0)
    Console.WriteLine($"{positionI}, {positionJ} --> Такого элемента не существует");
else Console.WriteLine($"{positionI}, {positionJ} --> {array2D[(positionI - 1), (positionJ - 1)]}");







