﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
if (n==1)
Console.WriteLine("сегодня понедельник");
if (n==2)
Console.WriteLine("сегодня вторник");
if (n==3)
Console.WriteLine("сегодня среда");
if (n==4)
Console.WriteLine("сегодня четверг");
if (n==5)
Console.WriteLine("сегодня пятница");
if (n==6)
Console.WriteLine("УРА, сегодня суббота");
if (n==7)
Console.WriteLine("Ура, сегодня воскресенье");
if (n>7)
System.Console.WriteLine("это число не соответствует дню недели");

