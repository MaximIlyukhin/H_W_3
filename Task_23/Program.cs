//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

using static System.Console;
Clear();

Write("Enter N = ");
int N = int.Parse(ReadLine());
for(int i = 1; i<N; i++)
    Write(Math.Pow(i,3) + ", ");
Write(Math.Pow(N,3));    