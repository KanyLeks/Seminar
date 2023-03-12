/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


Console.Clear();

int[,] array = FillArray(4, 4, 1, 10);
Console.WriteLine("1 матрица");
Console.WriteLine("————————————————");
PrintArray(array);
Console.WriteLine();

int[,] twoArray = FillTwoArray(4, 4, 1, 10);
Console.WriteLine("2 матрица");
Console.WriteLine("————————————————");

PrintArr(array);
mult(array, twoArray);




int[,] FillArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < columns; k++)
        {
            array[i, k] = rnd.Next(minValue, maxValue);
        }
    }
    return array;
}


void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int k = 0; k < inputArray.GetLength(1); k++)
        {
            Console.Write(inputArray[i, k] + " ");
        }
        Console.WriteLine();
    }
}



int[,] FillTwoArray(int rowsArr, int columnsArr, int minValueArr, int maxValueArr)
{
    int[,] twoArray = new int[rowsArr, columnsArr];
    Random rnd = new Random();
    for (int k = 0; k < rowsArr; k++)
    {
        for (int l = 0; l < columnsArr; l++)
        {
            array[k, l] = rnd.Next(minValueArr, maxValueArr);
        }
    }
    return twoArray;
}


void PrintArr(int[,] inputArr)
{
    for (int k = 0; k < inputArr.GetLength(0); k++)
    {
        for (int l = 0; l < inputArr.GetLength(1); l++)
        {
            Console.Write(inputArr[k, l] + " ");
        }
        Console.WriteLine();


    }

}


int[,] mult(int[,] array, int[,] twoArray)
{
    int[,] m = new int[array.GetLength(0), twoArray.GetLength(1)];

    for (int i = 1; i < array.GetLength(0) - 1; ++i)
    {
        for (int k = 1; k < twoArray.GetLength(0)-1; ++k)
        {
            for (int l = 1; l < twoArray.GetLength(1)-1; ++l)
            {
                m[i, l] += array[i, k] * twoArray[k, l]; // ПО мне это не произведение двух матриц!???

                Console.WriteLine(m[i, l]); // На консоль выводит 0 0 0, не пойму почему.
            }

        }
    }
    return m;

}




