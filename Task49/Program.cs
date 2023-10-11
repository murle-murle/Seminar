/*Задайте двумерный массив.
Найдите элементы,
у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Начальный массив выглядит так:
1 2 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядить так:
1  2 49 2
5  9  2 3
64 4  4 4
*/
void ReplaceEvenIndexesNumbersToSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {

            matrix[i, j] *= matrix[i, j];

        }
    }
}
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

ReplaceEvenIndexesNumbersToSquare(array2d);
PrintMatrix(array2d);