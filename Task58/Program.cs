// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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


int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int k, l;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            k = 0; l = 0;
            while (k < matrix1.GetLength(1))
            {
                matrix[i, j] = matrix[i, j] + (matrix1[i, k] * matrix2[l, j]);
                k = k + 1;
                l = l + 1;
            }
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
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
    Console.WriteLine();
}

Console.Write("Введите  количество строк для М: ");
int rowRnd = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  количество столбцов для М: ");
int colomnRnd = Convert.ToInt32(Console.ReadLine());
int[,] array2D = CreateMatrixRndInt(rowRnd, colomnRnd, 0, 10);
PrintMatrix(array2D);
int[,] array3D = CreateMatrixRndInt(colomnRnd, rowRnd, 0, 10);
PrintMatrix(array3D);
int[,] matrixMulti = MultiMatrix(array2D, array3D);
PrintMatrix(matrixMulti);
