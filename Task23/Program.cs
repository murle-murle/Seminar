/*Напишите программу,которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1,8,27
5 -> 1,8,27,64,125
*/

/*int number = ReadInt("Введите число: ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i}, ");
}

// Метод
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

/*void ShowCube(int num)
{

    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i * i * i}, ");
    }
}
Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

ShowCube(number);*/


/*
public class Answer
{
    static void ShowCube(int N)
    {
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine($"{i * i * i}, ");
        }
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int N;

        if (args.Length >= 1)
        {
            N = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 3;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}*/

using System;

public class Answer
{
   static void ShowCube(int N)
    {
      for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(Cube (i));
        }// Введите свое решение ниже
        
    }
public static int Cube(int number)
{
  return number * number * number;
}
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) 
     {
        int N;

        if (args.Length >= 1) 
        {
            N = int.Parse(args[0]);
        } else
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 5;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}