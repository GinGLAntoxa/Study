//Напишите программу, которая принимает на вход
//трёхзначное целое число и на выходе показывает сумму
//первой и последней цифры этого числа.
//456 => 10
//782 => 9
//918 => 17

Console.WriteLine("Введите трёхзначное целое число");
int num = Convert.ToInt32(Console.ReadLine());

int numCheck = num;
if (num < 0) numCheck = -num;

if(num >= 100 && num <= 999)
{
    int digitFirst = num / 100;
    int digitLast = num % 10;
    int sumDigits = digitFirst + digitLast;
    Console.WriteLine($"{num} => {sumDigits}");
}
else
{
    Console.WriteLine("число минусовое");
}