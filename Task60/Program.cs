// Задача 60.Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[] CreateArrayRnd(int min, int max)
{
    int[] arrayNumber = new int[max - min];
    for (int i = 0; i < arrayNumber.Length; i++)
    {
        arrayNumber[i] = min;
        min += 1;
    }
    int number;
    int position1;
    int position2;
    Random rnd = new Random();
    for (int j = 0; j < arrayNumber.Length; j++)
    {
        position1 = rnd.Next(0,arrayNumber.Length);
        position2 = rnd.Next(0,arrayNumber.Length);
        number = arrayNumber[position1];
        arrayNumber[position1] = arrayNumber[position2];
        arrayNumber[position2]= number;  
    }
    return arrayNumber;
}

int[,,] CreateMatrixRndInt(int[] numberRnd, int rows, int columns, int other)
{
    int[,,] matrix3D = new int[rows, columns, other];
    int numPosition = 0;
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = numberRnd[numPosition]; 
                numPosition +=1;        
            }
        }
    }
    return matrix3D;
}

void PrintMatrix3D(int[,,] matrix)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    Console.Write($"{matrix[i, j, k]}({i},{j},{k})  ");
                }
            }
        }
        Console.WriteLine();
}

Console.Write("Введите размерность массива i: ");
int rowRnd = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность массива j: ");
int colomnRnd = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность массива k: ");
int otherRnd = Convert.ToInt32(Console.ReadLine());
int [] arrayNum = CreateArrayRnd(10, 99);
int[,,] array3D = CreateMatrixRndInt(arrayNum,rowRnd, colomnRnd, otherRnd);
PrintMatrix3D(array3D);