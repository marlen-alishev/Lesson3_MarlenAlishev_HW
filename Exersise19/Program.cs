// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Please enter the five-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n/10000%10 == n%10 && n/1000%10 == n/10%10) Console.Write("Yes!");
else Console.Write("No!"); 