using System;

class UserInputToCompileForTest
{
    public static int FindElementByPosition(int[,] array, int x, int y)
    {
        if (ValidatePosition(array, x, y))
        {
            return array[x - 1, y - 1];
        }
        return -1;
    }

    public static bool ValidatePosition(int[,] array, int x, int y)
    {
        return (x >= 1 && x <= array.GetLength(0)) && (y >= 1 && y <= array.GetLength(1));
    }

    public static void PrintResult(int[,] numbers, int x, int y)
    {
        if (ValidatePosition(numbers, x, y))
        {
            int element = FindElementByPosition(numbers, x, y);
            if (element != -1)
            {
                Console.WriteLine($"{element}");
            }
            else
            {
                Console.WriteLine("Такого элемента нет.");
            }
        }
        else
        {
            if (x < 1 || x > numbers.GetLength(0))
            {
                Console.WriteLine("Позиция по рядам выходит за пределы массива");
            }
            if (y < 1 || y > numbers.GetLength(1))
            {
                Console.WriteLine("Позиция по колонкам выходит за пределы массива");
            }
        }
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        if (args.Length >= 3)
        {
            int[,] array;

            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            array = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        array[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }

            if (int.TryParse(args[1], out int x) && int.TryParse(args[2], out int y))
            {
                UserInputToCompileForTest.PrintResult(array, x, y);
            }
            else
            {
                Console.WriteLine("Error parsing x or y to an integer.");
            }
        }
        else
        {
            int[,] array = {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
            int x = 2;
            int y = 2;

            UserInputToCompileForTest.PrintResult(array, x, y);
        }
    }
}