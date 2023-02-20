// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
Console.Clear();
Console.WriteLine("Enter X1:");
int X1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Y1:");
int Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Z1:");
int Z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter X2:");
int X2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Y3:");
int Y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Z3:");
int Z2 = int.Parse(Console.ReadLine());

int X = (X2 - X1);
int Y = (Y2 - Y1);
int Z = (Z2 - Z1);

int XYZ = (X * X + Y * Y + Z * Z);

double SqrtXYZ = Math.Sqrt(XYZ);
Console.WriteLine("{0:0.00}",SqrtXYZ);

