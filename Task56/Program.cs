// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SumRows(int[,] matrix, int rows)
{
    int[] sum = new int[rows];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum[i]=0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] = sum[i] + matrix[i, j];
        }
    }
    return sum;
}

int NumberMinRows(int[] arrayMax)
{
    int i = 0;
    int minNumber = i;
    while (i < arrayMax.Length - 1)
    {
        if (arrayMax[minNumber] > arrayMax[i + 1])
        {
            minNumber = i + 1;
        }
        i += 1;
    }
    minNumber += 1;
    return minNumber;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
    Console.WriteLine();
}

void PrintRowsNumber(int number)
{
    Console.WriteLine($"Строка с наименьшей суммой чисел --> {number} ");
}

Random rnd = new Random();
int rowRnd = rnd.Next(1, 8);
int colomnRnd = rnd.Next(1, 8);
int[,] array2D = CreateMatrixRndInt(rowRnd, colomnRnd, 0, 10);
PrintMatrix(array2D);
int[] arraySum = SumRows(array2D, rowRnd);
int rowsMinNumber = NumberMinRows(arraySum);
PrintRowsNumber(rowsMinNumber);
