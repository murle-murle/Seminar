/*Напишите программу,которая принимает на вход
координаты точки (X,Y), причём X зачёркнутое равно 0
и Y заркнутое равно 0 и выдёт номер четверти плоскости, 
в которой находится эта точка.*/

int Quater(int x, int y);
{
    if (x > && y > 0) return 1;
    if (x < && y > 0) return 2;
    if (x < && y < 0) return 3;
    if (x > && y < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quater = Quater(xCoordinate, yCoordinate);

string result = quater > 0
                ? $"Указанные координаты соответсвуют четверти {quater}"
                : "Введены некорректные координаты";
Console.WriteLine(result);