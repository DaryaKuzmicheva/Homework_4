/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.*/

int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
    {
    array[i] = rand.Next(1, 100);
    }
Console.WriteLine(string.Join(", " , array));
