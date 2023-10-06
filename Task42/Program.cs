/*Напигите программу,которая 
будет преобразовывать десятичное число в двоичное.
46 -> 101110
13 -> 1101
2 ->10

/*Массива нет*/


int DecToBaseNum(int number, int baseNum)
{
    int result = 0;
    int mult = 1;
    /*взяли цикл этот потому что не знаем 
    сколько итераций будет*/
    while (number > 0)
    {
        result += number % baseNum * mult;
        number /= baseNum;
        mult *= 10;

    }
    return result;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите основание системы счисления");
int baseNumber = Convert.ToInt32(Console.ReadLine());

int res = DecToBaseNum(number, baseNumber);

Console.WriteLine($" -> {res}");