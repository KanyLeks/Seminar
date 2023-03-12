/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

{

    int[,] array = FillArray(4, 4, 1, 10);
    PrintArray(array);
    sumRowsArray(array);

  







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









    void sumRowsArray(int[,] inputArray)
    {
        int minRows = 0;
        int minSumRows = 0;
        int sumRows = 0;
        for (int i = 0; i < inputArray.GetLength(1); i++)
        {
            minRows += inputArray[0, i];
        }
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
                sumRows += inputArray[i, j];
            if (sumRows < minRows)
            {
                minRows = sumRows;
                minSumRows = i;
            }
            sumRows = 0;
        }
        Console.WriteLine();
        Console.Write($"Строка с наименьшей суммой элементов => {minSumRows + 1}  ");
    }









}



