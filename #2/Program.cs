Console.WriteLine("Ведите первое число");
string number1;
number1 = Console.ReadLine();
int number1a;
number1a = int.Parse(number1);

System.Console.WriteLine("Ведите второе число");
string number2;
number2 = Console.ReadLine();
int number2a;
number2a = int.Parse(number2);
Console.WriteLine("Наибольшее число");

if (number1a>number2a)
{
    
    Console.WriteLine(number1);
}
else
{
   Console.WriteLine(number2);   
}

  

