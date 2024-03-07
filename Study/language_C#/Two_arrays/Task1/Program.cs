//Итак, укажем тип возвращаемого значения int [,] - то есть двумерный массив
//целых чисел. Далее укажем имя функции, например CreateMatrix и её параметры.
//Их будет два, назовем первый rowsCount (от англ. число строк), второй –
//ColumnsCount (число столбцов).
int[,] GreateMatrix(int rowCount, int columnsCount)
{
    int[,] matrix = new int[rowCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
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
int[,] matrix = GreateMatrix(4, 5);

ShowMatrix(matrix);