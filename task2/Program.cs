/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Введите размерность массива");
int length = int.Parse(Console.ReadLine());
int [] arr = InitArray(length);
Console.WriteLine("Массив: ");
PrintArray(arr);
int pariti = GetPariti(arr);
Console.Write($" -> {pariti} ");




int [] InitArray(int length)
{
    int [] arr = new int[length];
    Random rnd = new Random();

        for(int i = 0; i < length; i++)
        {
            arr[i] = rnd.Next(100, 1000); // [a,b)
        }
    return arr;
}

   
int GetPariti(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int paritiArray = array [i] % 2; 
        if (paritiArray == 0 )
        {
            amount++;
        }
    } 
    return amount;
    
}

void PrintArray(int [] array)

{
    for (int i=0; i < array.Length; i++)
    {
     Console.Write(array[i] + " " );
    }
}