/*Напишите программу, которая принимает на вход
число и проверяет,кратно ли оно одновременно 7 и 23.
14  -> нет
46  -> нет
161 -> да*/

/*bool MultipleOfTwoNumbers(int num)
{
    bool multipal = (num % 7 == 0) && (num % 23 == 0);
    return multipal;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

bool result = MultipleOfTwoNumbers(number);
Console.WriteLine(result ? "да" : "нет"); */

//Метод универсальный.//

bool MultipleOfTwoNumbers (int num, int num1, int num2)
{
    return num % num1  == 0 && num % num2 == 0;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

bool result = MultipleOfTwoNumbers(number,7,23);
Console.WriteLine (result ? "да" : "нет");


