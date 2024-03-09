﻿using System;
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    {
      //Напишите свое решение здесь
        int rows = array.GetLength(0);
        int[] sums = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            sums[i] = sum;
        }

        return sums;
    }
    
    // Получение индекса минимального элемента в одномерном массиве
    public static int MinIndex(int[] array)
    {
       //Напишите свое решение здесь
        int minIndex = 0;
        int minSum = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minSum)
            {
                minSum = array[i];
                minIndex = i;
            }
        }

        return minIndex;
    }
    public static void PrintResult(int[,] numbers)
    {   
       //Напишите свое решение здесь
        int[] sums = SumRows(numbers);
        int minIndex = MinIndex(sums);

        Console.WriteLine(minIndex);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            
            numbers = new int[,] {
                {1, 2, 3},
                {1, 1, 0},
                {7, 8, 2},
                {9, 10, 11}
    };      
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}