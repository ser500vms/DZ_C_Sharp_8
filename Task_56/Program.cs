/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

List<int> WhatRowMin(int[] arrey)
{
    int minRow = arrey[0];
    int count = 0;
    List<int> whatRowMin = new List<int>();
    for (int i = 0; i < arrey.Length; i++)
    {
        if (minRow >= arrey[i])
        {
            minRow = arrey[i];
            count++;
            whatRowMin.Add(i + 1);
        }
    }
    if (count == 0)
    {
        whatRowMin.Add(1);
    }
    return whatRowMin;
}

int[] FindRowSumm(int[,] arrey)
{
    int[] arrayRowSum = new int[arrey.GetLength(0)];
    {
        for (int i = 0; i < arrey.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < arrey.GetLength(1); j++)
            {
                rowSum += arrey[i, j];
            }
            arrayRowSum[i] = rowSum;
        }
    }
    return arrayRowSum;
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

int[,] arrey = Generate2DArray(4, 5, 1, 10);

Print2DArray(arrey);
int[] findRowSumm = FindRowSumm(arrey);
List<int> whatRowMin = WhatRowMin(findRowSumm);
if (whatRowMin.Count > 1)
{
    Console.WriteLine($"Обнаружено несколько строк с" +
    $" наименьшей суммой элементов: {string.Join(" строка; ", whatRowMin)} строка");
}
else
{
Console.WriteLine($"Строка с наименьшей суммой элементов: {string.Join(" строка, ", whatRowMin)}");
}