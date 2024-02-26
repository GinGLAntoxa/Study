void PrintSquares(int limit)//void == она не чего не возращает
{
    int i = 1;
    while(i <= limit)
    {
        Console.Write($"{i*i} ");
        i++;
    }
}

PrintSquares(4);
PrintSquares(5);
PrintSquares(10);
