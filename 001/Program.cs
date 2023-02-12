Console.Clear();
Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Квадрат числа " + value + " равен: " + value * value);
Console.WriteLine("Способо 2. Квадрат числа " + value + " равен: " + Math.Pow(value, 2));
