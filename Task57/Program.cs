/*Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько 
раз встречается элемент входных данных.
набор данных:                 частотный массив:
{1,9,9,0,2,8,0,9}          0 встречается 2 раза
                           1 встречается 1 раз
                           2 встречается 1 раз
                           8 встречается 1 раз
                           9 встречается 3 раза

1,2,3                      1 встречается 3 раза  
4,6,1                      2 встречается 2 раза
2,1,6                      3 встречсется 1 раз
                           4 встречается 1 раз
                           6 встречается 2 раза

 */

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

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
        
    }
    return array;
}
void PrintArray(int[] array)
{
    //Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    //Console.WriteLine("]");
}
void PrintFrequancyDictionary(int[] array)
{
    int count = 0;
    int currentNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currentNumber) count++;
        else
        {
            Console.WriteLine($"{currentNumber,3} -> {count,3}");
            currentNumber = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{currentNumber,3} -> {count,3}");
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[] arr = MatrixToArray(array2d);
Array.Sort(arr);
PrintArray(arr);
Console.WriteLine();
PrintFrequancyDictionary(arr);


