﻿int Fact(int n)
{
    if(n == 1)
    {
        return 1;
    }
    return n * Fact(n - 1);
}

Console.Write(Fact(5));
