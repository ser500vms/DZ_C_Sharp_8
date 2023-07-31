/*
Задача 60. 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] Generate3DArray(int layers, int rows, int collums,  int startValue, int finishValue)
{
    HashSet<int> set = new HashSet<int>();
    while (set.Count < layers * rows * collums)
    {
        set.Add(new Random().Next(startValue, finishValue + 1));
    }
    int[] nonRepeatingNumbers = set.ToArray();

    int[,,] arrey = new int[layers, rows, collums];
    int count = 0;
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            for (int k = 0; k < arrey.GetLength(2); k++)
            {
                arrey[i, j, k] = nonRepeatingNumbers[count];
                count++;
            }     
        }
    }
    return arrey;
}

void Print3DArray(int[,,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            for (int k = 0; k < arrey.GetLength(2); k++)
            {
                Console.Write($"{String.Format("{0, 3}", arrey[i, j, k])} ({i},{j},{k})");
                Console.Write("\t", -5);
            }

        }
        Console.WriteLine();
    }
}

int[,,] arrey = Generate3DArray(2, 2, 2, 10, 99);
Print3DArray(arrey);