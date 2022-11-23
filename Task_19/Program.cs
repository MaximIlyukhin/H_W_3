//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

using static System.Console;
Clear();

Write("Enter N = ");
string N = ReadLine();
if(N[0]==N[4] && N[1]==N[3])
    Write("YES");
else
    Write("NO");  