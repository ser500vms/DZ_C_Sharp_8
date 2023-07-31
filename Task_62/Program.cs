/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] SpiralFilledArray(int rows, int collum)
{
    int[,] spiralFilledArray = new int[rows, collum];
    int value = 1;
    int row = 0, col = 0;
    int maxRow = rows - 1, maxCol = collum - 1;
    int minRow = 0, minCol = 0;

    while (value <= rows * collum)
    {
        // Заполнение верхней горизонтальной строки
        for (col = minCol; col <= maxCol; col++)
        {
            spiralFilledArray[minRow, col] = value++;
        }
        minRow++;

        // Заполнение правой вертикальной строки
        for (row = minRow; row <= maxRow; row++)
        {
            spiralFilledArray[row, maxCol] = value++;
        }
        maxCol--;

        // Заполнение нижней горизонтальной строки
        for (col = maxCol; col >= minCol; col--)
        {
            spiralFilledArray[maxRow, col] = value++;
        }
        maxRow--;

        // Заполнение левой вертикальной строки
        for (row = maxRow; row >= minRow; row--)
        {
            spiralFilledArray[row, minCol] = value++;
        }
        minCol++;
    }
    return spiralFilledArray;
}

void Print2DArray(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.Write(arrey[i, j].ToString("00") + " ");
            //Console.Write("\t", -5);
        }
        Console.WriteLine();
    }
}

int[,] spiralFilledArray = SpiralFilledArray(9, 9);
Print2DArray(spiralFilledArray);