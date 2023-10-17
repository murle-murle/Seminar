/*Задайте значение N.
Напишите программу,которая выведет все натуральные числа
в промежуточные от 1 до N.
N = 5-> "1,2,3,4,5"
N = 6-> "1,2,3,4,5,6"
*/

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

PrintNaturalNumbers(number);

void PrintNaturalNumbers(int num)
{
    if(num == 0) return;
    //Console.Write($"{num} ");   //5 = -> 5 4 3 2 1
    PrintNaturalNumbers(num - 1);
    Console.Write($"{num} "); //5 = ->1 2 3 4 5 нам подходит этот вариант.
}