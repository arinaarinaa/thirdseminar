// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

Console.WriteLine(" koord x1 - ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("koord x2 - ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("koord y1 - ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("koord y2 - ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" koord z1 - ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" koord z2 - ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine(distance);

