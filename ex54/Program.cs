//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

using static System.Console;
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(-100, 100);
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
Write("enter quantity of rows: ");
int rows = int.Parse(ReadLine());
Write("enter quantity of columns: ");
int columns = int.Parse(ReadLine());

Write("a two-dimensional array filled with integer numbers: ");
WriteLine();
int[,] array = GetArray(rows, columns);
PrintArray(array);
void SortOfDecreasingElementsInRow (int[,] Array)
{
    for(int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1)-1; j++)
        {
            int MaxInRow = j;
            for(int k = j+1; k < Array.GetLength(1); k++)
                if (Array [i, k] > Array [i,MaxInRow])
                {
                    (Array[i,MaxInRow], Array [i,k]) = (Array [i,k], Array[i,MaxInRow]);              
                }                       
        }
        
    }   
}
WriteLine();
WriteLine("the elements of each row of the two-dimensional array are ordered in descending order: ");
SortOfDecreasingElementsInRow(array);
PrintArray(array);
