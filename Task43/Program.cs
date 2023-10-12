/*Задача 43: Напишите программу,
 которая найдёт точку пересечения двух прямых, 
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;



double[] lineDate1 = InputLineDate(LINE1);
double[] lineDate2 = InputLineDate(LINE2);

if (ValidateLines(lineDate1, lineDate2))
{
    double[] coord = FindCoords(lineData1, lineDate2);
    Console.Write($"Точка пересечения уравнений y = {lineDate1[COEFFICIENT]}*x + {lineDate1[CONSTANT]} и y = {lineDate2[COEFFICIENT]} *x + {lineDate2[CONSTANT]}");
    Console.WriteLine($"имеет координаты ({coord[X_COORD]},{coord[Y_COORD]})");
}

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double[] ImputLineDate(int numberOfLine)
{
    double[] lineDate = new double[2];
    lineDate[COEFFICIENT] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
    lineDate[CONSTANT] = Prompt($"Введите константу для {numberOfLine} прямой >");
    return lineDate;
}

double[] FindCoords(double[] lineData1, double[] lineDate2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData1[CONSTANT] - lineDate2[CONSTANT]) / (lineDate2[COEFFICIENT] - lineDate1[COEFFICIENT]);
    coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] + lineData1[CONSTANT];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineDate2)
{
    if (lineData1[COEFFICIENT] == lineDate2[COEFFICIENT])
        if (lineData1[CONSTANT] == lineDate2[CONSTANT])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    return true;
}