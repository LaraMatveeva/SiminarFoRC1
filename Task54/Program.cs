//Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] OrderRows(int[,] matrix)
{
int number;
int max;
int k;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < (matrix.GetLength(1))-1; j++)
        {
            k=j;
            max=j;
            while(k < (matrix.GetLength(1)) -1)
            {
                if (matrix[i, max] < matrix[i, k+1])
                 {
                    max = k+1;
                 }
                k+=1;
            }
            number = matrix[i,j];
            matrix[i,j] = matrix[i, max];
            matrix[i, max] = number;
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

Random rnd = new Random();
int rowRnd = rnd.Next(1, 8);
int colomnRnd = rnd.Next(1, 8);
int[,] array2D = CreateMatrixRndInt(rowRnd, colomnRnd, 0, 10);
PrintMatrix(array2D);
int[,] arrayOrder = OrderRows (array2D);
PrintMatrix(arrayOrder);


