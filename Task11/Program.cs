/*Напиши программу,которая выводит случайное трёхзначное чило 
и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98*/

/*int number = new Random().Next(100, 1000);
int firstDigit = number / 100;
int lastDigit = number % 10;
int numResult = firstDigit * 10 + lastDigit;
Console.WriteLine($"{number} -> {numResult}");*/

//Метод

int number = new Random().Next(100, 1000);

int deleteSecondDigit = DeleteSecondDigit(number);
Console.WriteLine($"{number} -> {deleteSecondDigit}");

int DeleteSecondDigit(int num)
{
    int firstDigit = number / 100;
    int lastDigit = number % 10;
    int numResult = firstDigit * 10 + lastDigit;
    return numResult;
}