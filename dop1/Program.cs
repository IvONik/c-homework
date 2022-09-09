//Пользователь вводит x и y. Программа печатает, чему равно x² + y².

System.Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число");
int num2 = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Сумма квадратов равна {Math.Pow(num1,2)+Math.Pow(num2,2)} ");