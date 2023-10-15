/*Задайте двумерный массив.
Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно,
программа должна вывести сообщение для пользователя.
*/
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{                         //0       1
    int[,] matrix = new int[rows, columns]; //rows = 3, columns = 4
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine(" ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" ");
        Console.WriteLine();
    }
}

//1 5 7 5
//7 8 9 7
//8 5 9 6
void ReplaceRowsColumns2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}
void ReplaceRowsColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0)-1; i++)
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

int[,] array2d = CreateMatrixRndInt(4, 4, -100, 100);
PrintMatrix(array2d);

ReplaceRowsColumns(array2d);
Console.WriteLine();
PrintMatrix(array2d);

ReplaceRowsColumns2(array2d);
Console.WriteLine();
PrintMatrix(array2d);