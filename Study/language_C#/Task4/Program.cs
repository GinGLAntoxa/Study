int a = 4;
int b = 42;
int c = 41;
int d = 5;
int e = 7;
int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
if (d > max)
{
    max = d;
}
if (e > max)
{
    max = e;
}

Console.WriteLine(max);