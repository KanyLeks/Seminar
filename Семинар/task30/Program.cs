/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

Console.Clear();
void WriteBinNumValue(int[] arr)
{
    int arrLenght = arr.Length;
    for(int i = 0; i < arrLenght; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
}


void PrintArr(int[] arr)
{
    foreach(int num in arr)
    {
        Console.Write($"{num}. ");
    }
    Console.WriteLine($"");
}


int arrLenght = 5;
int[] arrBinNumRand = new int[arrLenght];


WriteBinNumValue(arrBinNumRand);
PrintArr(arrBinNumRand);


// for(int i = 0; i < arrLenght; i++)
// {
//     arrBinNumRand[i] = new Random().Next(0, 2);
// }
