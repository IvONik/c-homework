// Максимум из трех чисел
int numberA=new Random().Next(1,99);
System.Console.WriteLine(numberA);
int numberB=new Random().Next(1,99);
System.Console.WriteLine(numberB);
int numberC= new Random().Next(1,99);
System.Console.WriteLine(numberC);


int max=numberA;
if (numberA>max) max=numberA;
if (numberB>max) max=numberB;
if (numberC>max) max=numberC;
System.Console.WriteLine($"Максимальное число ={max}");




