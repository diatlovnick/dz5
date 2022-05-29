/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


Console.WriteLine("Введите размерность массива");
int length = int.Parse(Console.ReadLine());
int [] arr = InitArray(length);
Console.WriteLine("Массив: ");
PrintArray(arr);
int sum = GetSum(arr);
Console.Write($" -> {sum} ");




int [] InitArray(int length) //метод, который инициализирует массив из length элементов в промежутке от [-99, 99]
{
    int [] arr = new int[length];
    Random rnd = new Random();

        for(int i = 0; i < length; i++)
        {
            arr[i] = rnd.Next(-99, 100); // [a,b)
        }
    return arr;
}

   
int GetSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int numberArray = i % 2; 
        if (numberArray == 0 )
        {
            sum = sum + array[i];
        }
    } 
    return sum;
    
}

void PrintArray(int [] array)

{
    for (int i=0; i < array.Length; i++)
    {
     Console.Write(array[i] + " " );
    }
}