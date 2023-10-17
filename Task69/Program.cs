/*Напишите программу,
которая на вход принимает два числа А и В, 
и возводит число А в целую степень В с помощью рекурсии.
А = 3; В = 5 -> 243 (3 степени 5)
А = 2; B = 3 -> 8
*/


int Pow(int a, int b) //3,5 - 3,4 - 3,3 - 3,2 - 3,1 - 3,0
{
    if (b == 0) return 1;
    return a * Pow(a, b - 1); //3,5 - 3,4 - 3,3 - 3,2 - 3,1
    //return(1)* 3 * 3 * 3 * 3* 3 = 243
}


Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целую степень числа A: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0)  //Реализация для отрицательных степенней с double
{
    Console.WriteLine(1 / (double)Pow(numberA, -numberB));
}
else Console.WriteLine(Pow(numberA, numberB));

Console.WriteLine(Pow(numberA, numberB));