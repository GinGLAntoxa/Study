int[,] GreateMatrix(int rowCount, int columnsCount)
{
    int[,] matrix = new int[rowCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfGigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}
int GetSumOfGigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}

int[,] matrix = GreateMatrix(3, 4);
ShowMatrix(matrix);
foreach (int e in matrix)
{
    if (IsInteresting(e) == true)
    {
        Console.Write($"{e} ");
    }
}

