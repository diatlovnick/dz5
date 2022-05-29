
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.WriteLine("введите длину массива");
int length = int.Parse(Console.ReadLine());
int [] array = InitArray(length);
int max = GetMax(array);
int min = GetMin(array);
int resault = max - min;
PrintArray(array); 
Console.Write($"-> {resault}");



int [] InitArray(int length)
{
    int [] arr = new int[length];
    Random rnd = new Random();

        for(int i = 0; i < length; i++)
        {
            arr[i] = rnd.Next(0, 100); // [a,b)
        }
    return arr;
}


int GetMax(int [] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        
    }
    Console.WriteLine($"max -> {max}");
    return max;
}


int GetMin(int [] array)
{
    int i = 0;
    int min = array[i];
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"min -> {min}");
    return min;
}

void PrintArray(int [] array)
{
    for (int i=0; i < array.Length; i++)
    {
     Console.Write(array[i] + " " );
    }
}