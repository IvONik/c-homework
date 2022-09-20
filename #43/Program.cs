// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
System.Console.WriteLine("Введите к1");
double k1 = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите b1");
double b1 = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите к2");
double k2 = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите b2");
double b2 = double.Parse(Console.ReadLine()!);

if (k1 == k2)
   {
      if (b1 != b2)
      {
         System.Console.WriteLine("прямые параллельны");
      }   
      else
      {
         System.Console.WriteLine("прямые совпадают");
      }
   }
else
{
    double XCross = (b2 - b1) / (k1 - k2);
    double YCross = k1 * XCross + b1;

    System.Console.WriteLine($"координата х {XCross}");
    System.Console.WriteLine($"координата y {YCross}");
}
