/*Напишите программу, 
которая подсчитывает количество 
четных элементов в массиве целых положительных 
трехзначных чисел и выводит результат на экран.

*/


public class Answer
{
    public static int CountEvenElements(int[] array)
    { 
    
      int count = 0;
      foreach(int number in array)
      {
        if(number % 2 ==0)
        {
          count++;
        }
      }
      return count;
  }

    public static void PrintArray(int[] array)
    {
    
     foreach(int number in array)
     {
       Console.Write($"{number}\t");
     }
     Console.WriteLine();
 }



    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           
            array = new int[] { 124, 378, 593, 821, 456 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        
        Console.WriteLine("Массив:");
        PrintArray(array);
        int evenCount = CountEvenElements(array);
        Console.WriteLine($"Количество четных элементов: {evenCount}");
    }
}