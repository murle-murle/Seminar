﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет


Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 2 == 0)
{
    System.Console.WriteLine($"Число:{number1} четное");
}
else
{
    System.Console.WriteLine($"Число:{number1} нечетное");
}