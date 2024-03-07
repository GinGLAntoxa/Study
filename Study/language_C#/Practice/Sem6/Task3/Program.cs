//Считать строку с консоли, состоящую из латинских
//букв в нижнем регистре. Выяснить, сколько среди
//введённых букв гласных.
//Пример
//“hello” => 2
//“world” => 1
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