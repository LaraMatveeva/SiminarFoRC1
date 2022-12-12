// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int count = rows * columns;
    int number = 0;
    int i = 0;
    int j;
    int k; 

    while (number < count)
    {   
        j=i;
        while (j < matrix.GetLength(1)-i) //  вправо
        {
            number++;
            matrix[i, j] = number;
            j++;
        }
        j--;
        k = i + 1;
        while (k <= matrix.GetLength(0) - (i + 1))  //вниз
        {
            number ++;
            matrix[k, j] = number;
            k++;
        }
        k--;
        j = matrix.GetLength(1) -(i+2);
        while (j >=i) //влево
        {
            number ++;
            matrix[k, j] = number;
            j--;
        }
        j++;
        k =matrix.GetLength(0)-(i+2);
        while (k >= i+1) //вверх
        {
            number++;
            matrix[k, j] = number;
            k--;
        }
        i++;
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
            if (matrix[i,j] < 10) Console.Write($"  0{matrix[i, j]} ");
            else
            {
              Console.Write($"{matrix[i, j],4} ");  
            }
        }
        Console.WriteLine("|");
    }
    Console.WriteLine();
}

Console.Write("Введите размерность массива i: ");
int rowRnd = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность массива j: ");
int colomnRnd = Convert.ToInt32(Console.ReadLine());
int[,] array2D = CreateMatrixRndInt(rowRnd, colomnRnd);
PrintMatrix(array2D);