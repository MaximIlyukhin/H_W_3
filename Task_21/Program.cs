//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


using static System.Console;
Clear();

Write("Enter x1 = ");
int x1 = int.Parse(ReadLine());
Write("Enter y1 = ");
int y1 = int.Parse(ReadLine());
Write("Enter z1 = ");
int z1 = int.Parse(ReadLine());
Write("Enter x2 = ");
int x2 = int.Parse(ReadLine());
Write("Enter y2 = ");
int y2 = int.Parse(ReadLine());
Write("Enter z2 = ");
int z2 = int.Parse(ReadLine());

int z = (x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2);

Write(Math.Sqrt(z));