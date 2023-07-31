/*
Задача 54:
Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] ArrayDescending(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0);  ++i)
    {
        int count = 0;
        while (count < arrey.GetLength(1))
        {
            for (int j = count + 1; j < arrey.GetLength(1); j++)
            {
                if (arrey[i, count] < arrey[i, j])
                {
                    int temporary = arrey[i, count];
                    arrey[i, count] = arrey[i, j];
                    arrey[i, j] = temporary;
                }
            }
            count++;
        }
    }
    return arrey;
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

int[,] arrey = Generate2DArray(6, 5, 1, 10);
Print2DArray(arrey);
Console.WriteLine("В итоге получается вот такой массив:");
int[,] arrayDescending = ArrayDescending(arrey);
Print2DArray(arrayDescending);