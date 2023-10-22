/*Задача 66: Задайте значения M и N. 
Напишите программу,
которая найдёт сумму натуральных элементов 
в промежутке от M до N.
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 1 || numberN < 1)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

PrintRangeNaturalNumbers(numberM, numberN);

void PrintRangeNaturalNumbers(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write($"{numM} ");
        PrintRangeNaturalNumbers(numM + 1, numN);
    }

    else if (numM > numN)
    {
        Console.Write($"{numM} ");
        PrintRangeNaturalNumbers(numM - 1, numN);
    }

    else Console.Write($"{numM} ");

}

int SumNaturalNumBetweenMandN(int numberM, int numberN)
{
    if (numberM == numberN)
        return numberN;
    else return numberM + SumNaturalNumBetweenMandN(numberM + 1, numberN);
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {SumNaturalNumBetweenMandN(numberM, numberN)}");












