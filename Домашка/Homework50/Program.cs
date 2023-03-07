using System;

/*Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве,
  и возвращает значение этого элемента или же указание, что такого элемента нет.
  Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1,1 -> 9
1,7 -> элемента с данными индексами в массиве нет
*/

public class MainClass
{
	public static void Main()
	{
        
		int rows = Prompt("Введите число в строке: ") ;
		int columns = Prompt("Введите число в столбце: ");
		int[,] array = GetArray(4, 3, 1, 10);
		//FillArray(array);
		PrintArray(array);

		int Prompt(string message)
		{
			
			Console.Write(message);
			string value = Console.ReadLine();
		    int result = Convert.ToInt32(value);
			return result;
		}




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



		void PrintArray(int[,] array)
		{
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					Console.Write($"{array[i,j]}  ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
            
		}
		
		
		
		
		
		if(rows< array.GetLength(0) && columns < array.GetLength(1))	
		{
		Console.WriteLine($"{rows},{columns} -> {array[rows, columns]}");
		}
        else 
		{
		Console.WriteLine($"{rows},{columns} -> такого числа в массиве нет");
      }
	}
}