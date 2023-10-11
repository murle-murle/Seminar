/* Задайте двумерный массив размером mxn, 
заполненный случайными числами.
m = 3, n = 4.
     0   1  2  3                                                //чтоб читалось по столбцам нужно заменить 
 0   1   4  8 19                                                    for (int j = 0; j < matrix.GetLength(1); j++)
 1   5  -2 33 -2                                                    {
 2   77  3  8  1                                                      for (int i = 0; i < matrix.GetLength(0); i++)
                                                                       {
                                                                       matrix[i, j] = rnd.Next(min, max + 1);
                                                                       }
                                                                    }
                                                                    return matrix;
 
*/

// проход по строкам
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

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);