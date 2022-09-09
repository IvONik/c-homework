// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

System.Console.WriteLine("Введите координаты точки А Х У Z");
string xyA = Console.ReadLine(); // Предполагается, что пользователь ввел числа через пробел
string[] partsA= xyA.Split (" "); // разделить массив parts на две строчки через пробел
int xA = int.Parse(partsA[0]);
int yA = int.Parse(partsA[1]);
int zA = int.Parse(partsA[2]);

System.Console.WriteLine("Введите координаты точки B Х У Z");
string xyB = Console.ReadLine(); 
string[] partsB= xyB.Split (" ");
int xB = int.Parse(partsB[0]);
int yB = int.Parse(partsB[1]);
int zB = int.Parse(partsB[2]);

double diffrenceX=Math.Sqrt(Math.Pow(xA-xB,2)+Math.Pow(yA-yB,2)+Math.Pow(zA-zB,2));    // квадрат гипотинузы равен сумме квадратов катетов

System.Console.WriteLine($"Расстояниеи между двумя точками равно {diffrenceX:F3}");// :F3 округляет до третьего знака