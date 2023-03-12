/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int[,] array = FillArray(3, 4, 1, 10);
PrintArray(array);
orderArray(array);
Console.WriteLine("__________");
Console.WriteLine();
PrintArray(array);







int[,] FillArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return array;
}


void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}









void orderArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {

        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(1) - 1; k++)
            {
                int sortValue = array[i, k + 1];
                if (array[i, k] < array[i, k + 1])

                {
                    array[i, k + 1] = array[i, k];
                    array[i, k] = sortValue;
                }
            }
        }
    }
}









	