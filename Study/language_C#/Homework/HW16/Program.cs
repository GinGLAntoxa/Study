using System;

class UserInputToCompileForTest
{
    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static void SwapItems(int[,] array, int i)
    {
            //Напишите свое решение здесь
        int lastRow = array.GetLength(0) - 1;
        int colCount = array.GetLength(1);
    
        for (int j = 0; j < colCount; j++)
        {
            int temp = array[i, j];
            array[i, j] = array[lastRow, j];
            array[lastRow, j] = temp;
        }
    }
    public static int[,] SwapFirstLastRows(int[,] array)
    {
        int lastRow = array.GetLength(0) - 1;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            int temp = array[0, i];
            array[0, i] = array[lastRow, i];
            array[lastRow, i] = temp;
        }
        return array;
    }

    public static void PrintResult(int[,] numbers)
    {
        Console.WriteLine("Original Array:");
        PrintArray(numbers);

        int[,] swappedArray = SwapFirstLastRows(numbers);

        Console.WriteLine("\nArray after swapping first and last rows:");
        PrintArray(swappedArray);
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
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
            numbers = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}