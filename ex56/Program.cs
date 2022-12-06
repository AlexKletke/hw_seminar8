//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов

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
Write("enter quantity of columns more or less of rows: ");
int columns = int.Parse(ReadLine());

Write("a two-dimensional array filled with integer numbers: ");
WriteLine();
int[,] array = GetArray(rows, columns);
PrintArray(array);

int[] ArrayOfSumsOfNumbersInStrings (int[,] Array)
{
    int[] result1 = new int[Array.GetLength(0)];
    for(int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            result1[i] = result1[i] + Array[i, j];                        
        }               
    }
    WriteLine(string.Join(", ", result1));
    return result1;
}

WriteLine();
WriteLine("the sum elements of each row of the two-dimensional array: ");
int[] result1 = ArrayOfSumsOfNumbersInStrings(array);
int indexminSum = result1.Length-1;
int IndexMinSum (int[] array)
{
    for(int i = 0; i < result1.Length-1; i++)
    {
        for(int j = i+1; j < result1.Length; j++)
        {
            if (result1[j] < result1[indexminSum])
                indexminSum = j;
        } 
    }
    return indexminSum;
}
IndexMinSum (result1);
WriteLine($"the number of the row with the smallest sum of elements = {indexminSum+1}");