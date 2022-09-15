//Программа заполняет массив 8 случайными числами. 
//Напишите функцию, которая принимает массив и находит в нём наибольший элемент. 
//Используйте накопительную переменную. Эта переменная изначально равна первому элементу массива; 
//когда встречается лучший кандидат на максимум, она его запоминает.
int[] array = new int[8];
int length = array.Length;

rdm(length);
System.Console.WriteLine(" ");
int max=findmax(length);

void rdm(int length)
{

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 100);
        System.Console.Write($"{array[i]}  ");
    }
}

int findmax (int length)
{
    int max=array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        
    }
   System.Console.Write($"максимум равен {max}");
   return max;
}


    


