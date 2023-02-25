/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


Console.Clear();

int Prompt(string message)
{
    Console.Write(message); // Выводим приглошение ко вводу
    string readInput = Console.ReadLine(); // Вводим значение
    int result = int.Parse(readInput); // Приводим к числу
    return result; // Возвращаем результат
}

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10; // result = result + number % 10;
        number /= 10; //number = number / 10;
    }
    return result;
}

int number = Prompt("Введите число: ");
Console.WriteLine($"Сумма всех цифр в числе {number} = {SumAllDigit(number)}");




//int n = Prompt("Введите основание: ");
