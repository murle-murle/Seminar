/*Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
23432 ->  да
12821 ->  да
*/
/*int num, r, sum = 0, t;
Console.Write("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if (num > 9999 && num < 100000)
{
    for (t = num; num != 0; num = num / 10)
    {
        r = num % 10;
        sum = sum * 10 + r;
    }
    if (t == sum)
        Console.Write($"{ t} является палиндромом.");
else
        Console.Write($"{ t } не является палиндромом.");
}
else
    Console.Write("Введите пятизначное число! ");*/



public class Answer
{
    static bool IsPalindrome(int number)
    {
        if (number < 10000 || number > 99999)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }

        int originalNumber = number;
        int reverseNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reverseNumber = reverseNumber * 10 + digit;
            number = number / 10;
        }

        if (originalNumber == reverseNumber)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /*static void Main(string[] args)
    {
        int number = 14212;

        if (IsPalindrome(number))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }*/
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 234322;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}  

