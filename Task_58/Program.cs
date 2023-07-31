/*
Задача 58: 
Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:

2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:

18 20
15 18
*/

int[,] ResultMatrix(int[,] arrey1, int[,] arrey2)
{
    int[,] resultMatrix = new int[arrey1.GetLength(0), arrey1.GetLength(1)];

    for (int i = 0; i < arrey1.GetLength(0); i++)
    {
        for (int j = 0; j < arrey2.GetLength(1); j++)
        {
            int result = 0;
            for (int k = 0; k < arrey2.GetLength(0); k++)
            {
                result += arrey1[i, k] * arrey2[k, j];
            }
            resultMatrix[i, j] = result;
        }
    }
    return resultMatrix;
}

void PrintTwoMatrix(int[,] arrey1, int[,] arrey2)
{
    for (int i = 0; i < arrey1.GetLength(0); i++)
    {
        for (int j = 0; j < arrey1.GetLength(1); j++)
        {
            Console.Write(arrey1[i, j] + " ");
        }
        Console.Write("| ");
        for (int j = 0; j < arrey2.GetLength(1); j++)
        {
            Console.Write(arrey2[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Generate2DArray(int rows, int collums, int startValue, int finishValue)
{
    int[,] arrey = new int[rows, collums];
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return arrey;
}

void Print2DArray(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.Write(String.Format("{0, 3}", arrey[i, j]));
            Console.Write("\t", -5);
        }
        Console.WriteLine();
    }
}

int[,] arrey1 = Generate2DArray(5, 5, 1, 9);
int[,] arrey2 = Generate2DArray(5, 5, 1, 9);
PrintTwoMatrix(arrey1 , arrey2);
int[,] resultMatrix = ResultMatrix(arrey1, arrey2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица будет:");
Console.WriteLine();
Print2DArray(resultMatrix);