﻿/*Напите программу,которая по заданному 
номеру четверти,
показывает диапозон возможных координат точек 
в этой четверти (x,y).*/

string GetCoordinatesRange(int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return null;
}

Console.WriteLine("Введите номер четверти");
int quater = Convert.ToInt32(Console.ReadLine());

string getCoordinatesRange = GetCoordinatesRange(quater);
string result = getCoordinatesRange != null ? $" заданному номеру четверти соответствует диапозон{getCoordinatesRange}"
                                            : $" Введены не корректные данные";
Console.WriteLine(result);                                            