/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/

Console.WriteLine("Введите числоми А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = Convert.ToInt32(Math.Pow(numberA, numberB));
Console.WriteLine(result);
