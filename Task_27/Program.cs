/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/

Console.WriteLine("Введите число");
string number = Console.ReadLine();
string numberStr = number.ToString();
int sum = 0;
for (int i = 0; i < numberStr.Length; i++)
{
    sum = sum + (numberStr[i]-'0');
}
Console.WriteLine(sum);
