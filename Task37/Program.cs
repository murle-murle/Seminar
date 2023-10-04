/*Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент,
второй и предпоследний и т.д.
Результат запишите в новом массиве.
[12345] ->5 8 3
[6736]  ->36 21
*/


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] ProductPairsNumbers(int[] arr)
{
    int size = arr.Length / 2 + arr.Length % 2;
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length % 2 != 0) result[size - 1] = arr[arr.Length / 2];
    return result;
}
int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);

int[] newArray = ProductPairsNumbers(array);
PrintArray(newArray);