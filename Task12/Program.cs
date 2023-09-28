/*Напишите программу,которая будет принимать на вход два числа
и выводить,является ли первое число кратным второму.
Если первое число не кратно второму, то программа
выводит остаток от деления.
34, 5 ->  не кратно,остаток 4
16, 4 ->  кратно */

Console.Write("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int Remainder(int firstPar, int secondPar)
{
    return firstPar % secondPar;
}
int remainder = Remainder(firstNumber, secondNumber);
if (remainder == 0) Console.WriteLine("кратно");
else Console.WriteLine($"не кратно, остаток {remainder}");
