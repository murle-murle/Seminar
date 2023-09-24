// Напишите программу,которая на вход принимает два числа и роверяет,является ли первое число квадратом второго.
// а=25, b=5-> да
// а= 2, b=10-> нет
// а= 9, b=-3-> да
// а=-3, b=9->нет

Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine($"{number1} является квадратом {number2}");
}
else
{
    Console.WriteLine($"{number1} не является квадратом {number2}");
}
