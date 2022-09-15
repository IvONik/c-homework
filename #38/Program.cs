// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
System.Console.WriteLine("Введите длину массива");
int size=int.Parse(Console.ReadLine()!);

int[] arrayDig=new int[size];

createArray(size);
System.Console.WriteLine(" ");
int max= findMax (size);
int min=findMin (size);
int result=findDiffrend (max, min);

void createArray(int size)
{
for (int i = 0; i < size; i++)
{
arrayDig [i] =new Random().Next(0,100);
System.Console.Write($"{arrayDig[i]} ");
}
}

int findMax (int size)
{
int max=arrayDig[0];
for (int i = 0; i < size; i++)
{
if( arrayDig[i]>max)
{
max=arrayDig[i];
}
} 
System.Console.WriteLine($"Максимум равен {max}"); 

return max;
}

int findMin (int size)
{
int min=arrayDig[0];
for (int i = 0; i < size; i++)
{
if( arrayDig[i]<min)
{
min=arrayDig[i];
}
} 
System.Console.WriteLine($"Минимум равен {min}"); 

return min;
}

int findDiffrend (int max, int min)
{
int result=max-min;
System.Console.WriteLine($"Рвзница между максимальным и минимальным равна {result}");
return result;
}