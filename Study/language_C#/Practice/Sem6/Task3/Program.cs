//Считать строку с консоли, состоящую из латинских
//букв в нижнем регистре. Выяснить, сколько среди
//введённых букв гласных.
//Пример
//“hello” => 2
//“world” => 1
static char[] StringToCharArray(string str)
{
    char[] charsArray = new char[str.Length];
    for (int i = 0; i < charsArray.Length; i++)
    {
        charsArray[i] = str[i];
    }
    return charsArray;
}
void PrintArray(char[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
static int GetCountValue(string str)
{
    int count = 0;
    string vowels = "aoeyui";

    for (int i = 0; i < str.Length; i++)
    {
        char cyrrentchar = str[i];
        for (int j = 0; j < vowels.Length; j++)
        {
            if (vowels[j] == cyrrentchar)
            {
                count++;
            }
        }
    }
    return count;
}
Console.WriteLine("Введите текст");
string str = Console.ReadLine()!;

Console.WriteLine(GetCountValue(str));