using System;

/*Задача 52. Задайте двумерный массив из целых чисел.
  Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

public class MainClass
{
	public static void Main()
	{
        
		int[,] array = GetArray(3, 4, 1, 10);
		
		PrintArray(array);
		sumArray(array);





		int[,] GetArray(int m, int n, int minValue, int maxValue)
		{
			 
			
		    int [,] array = new int[m,n];
			Random rnd = new Random();
			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < n; j++)
				{
					array[i, j] = rnd.Next(minValue, maxValue+1);
				}
			}
			return array;
		}



		void PrintArray(int[,] arr)
		{
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					Console.Write($"{array[i,j]}  ");
				}
				Console.WriteLine();
			}
			
		}
		
		
		
		
		void sumArray(int[,] array)
		{
		double sum = 0;
		double sum1 = 0;
		double sum2 = 0;
		double sum3 = 0;
		
		for(int i = 0; i< array.GetLength(1); i++)
		{
		for(int j = 0; j< array.GetLength(0); j++)
		{
		
		
		
		sum += array[j, 0];
		i++;
		
		sum1 += array[j, 1];
		i++;
		
		sum2 += array[j, 2];
		i++;
		
		sum3 += array[j, 3];
		i++;
		
		
		
		}
        
		Console.WriteLine($"Среднее арефметическое 1 столбца = {sum}/{array.GetLength(0)} = {sum/array.GetLength(0)}");
		Console.WriteLine($"Среднее арефметическое 2 столбца = {sum1}/{array.GetLength(0)} = {sum1/array.GetLength(0)}");
		Console.WriteLine($"Среднее арефметическое 3 столбца = {sum2}/{array.GetLength(0)} = {sum2/array.GetLength(0)}");
		Console.WriteLine($"Среднее арефметическое 4 столбца = {sum3}/{array.GetLength(0)} = {sum3/array.GetLength(0)}");
        //Math.Round(sum/array.GetLength(0), 2);


		
		}
		
		}
		
	
		
		
		
		
		
		
		
    }
}