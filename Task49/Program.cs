// Задача 49: Задайте двумерный массив. Найдите элементы, у
//которых оба индекса чётные, и замените эти элементы на их
//квадраты.

int[,]CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++) //3
{
for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(2)
{
matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3
}
}
return matrix;
}

int[,]SquMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        if (i % 2 == 0)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (j % 2 == 0)
                    matrix[i, j] *= matrix[i, j];
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
if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
else Console.Write($"{matrix[i, j], 4} ");  // 4 -это длина вывода строки для числа
}
Console.WriteLine("|");
}
}

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[,] arraySq = SquMatrix(array2D);
PrintMatrix(arraySq);