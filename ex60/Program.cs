//   Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


using static System.Console;
int[,,] GetArray(int m, int n, int l)
{
    int[,,] result = new int[m, n, l];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            for(int k = 0; k < l; k++)
            {
                result[i,j,k] = new Random().Next(10, 100);
            }
        }
    }
    return result;
}
void PrintArray(int[,,]inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            for(int k = 0; k < inArray.GetLength(2); k++)
            {
                Write( $"{inArray[i,j,k]}({i}, {j}, {k}) ");
            }
            WriteLine();
        }
        WriteLine();
    }
}

Clear();
Write("enter quantity of rows in 3d-array: ");
int rows = int.Parse(ReadLine());
Write("enter quantity of columns in 3d-array: ");
int columns = int.Parse(ReadLine());
Write("enter height of 3d-array: ");
int height = int.Parse(ReadLine());
if (rows * columns * height > 90)
{
    WriteLine("3д массив невозможно заполнить неповторяющимися двузначными числами");
    WriteLine("уменьшите размерность 3д массива для заполнения массива уникальными двузначными числами");
}
else
{
    WriteLine();
    WriteLine("row-by-row output of an 3d-array with added indexes of each element: ");
}

int[,,] array3d = GetArray(rows, columns, height);
PrintArray(array3d);
