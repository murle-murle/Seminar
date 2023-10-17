/*Здесь нужно возвращать значения. Факториал.

Напишите программу,
которая будет принимать на вход число 
и возвращать сумму его цифр.
453 -> 12
45  -> 9
*/
///////////////////////////////////////////////////
//шаблон для задачи на возврат//
/*
int Factorial(int n) //5 4 3 2 1
{
    if(n == 1) return 1;   
    return n * Factorial(n - 1); //5 4 3 2 
    // return 1 * 2 * 3 * 4 * 5
}
Console.WriteLine(Factorial(5)); //120
*/
//////////////////////////////////////////////////////

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumOfDigits(int n) //453 45 4 0
{
    if (n == 0) return 0;
    return n % 10 + SumOfDigits(n / 10); //453 45 4
    //return 0 + 4 % 10 + 45 % 10 + 453 % 10 =12
}
Console.WriteLine(SumOfDigits(number));
