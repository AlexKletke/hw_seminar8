//   Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


using static System.Console;
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(0, 10);
        }
    }
    return result;
}
void PrintArray(int[,]inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"\t{inArray[i,j]}");
        }
        WriteLine();
    }
}
Clear();
Write("enter quantity of rows in first matrix: ");
int rows = int.Parse(ReadLine());
Write("enter quantity of columns in first matrix: ");
int columns = int.Parse(ReadLine());
WriteLine();
WriteLine("first matrix filled with integer numbers: ");

int[,] array1 = GetArray(rows, columns);
PrintArray(array1);
WriteLine();
int[,] array2 = GetArray(columns, rows);
WriteLine("second matrix filled with integer numbers: ");
PrintArray(array2);

int[,] ProductOfTwoMatrices (int[,] array1, int[,] array2)
{
    int[,] result1 = new int[array1.GetLength(0), array2.GetLength(1)];
    for(int m = 0; m < result1.GetLength(0); m++)
    {
        for (int n = 0; n < result1.GetLength(1); n++)
        {
            result1[m, n] = 0;
            for (int l = 0; l < array1.GetLength(1); l++)
            {
                result1[m, n] = result1[m, n] + array1 [m, l] * array2 [l, n];
            }            
        }
    }
    return result1;    
}
int [,] result1 = ProductOfTwoMatrices (array1, array2);
WriteLine();
WriteLine("the product of two matrices: ");
PrintArray(result1);

