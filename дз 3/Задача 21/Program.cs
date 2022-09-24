// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите кооддинаты точки А");
Console.WriteLine("x =");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y =");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z =");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кооддинаты точки B");
Console.WriteLine("x =");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y =");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z =");
int zb = Convert.ToInt32(Console.ReadLine());

double length = Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb),2) + Math.Pow((za - zb), 2));
length = Math.Round(length, 2);
Console.WriteLine("Расстояния мжду точками " + length);