//На основе символов строки (тип string) сформировать массив
//символов (тип char[]). Вывести массив на экран.
//Метод строки ToCharArray() не использовать.
//Пример
//“Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

Console.WriteLine("Введите текст");
string str = Console.ReadLine()!;

char[] stringg = StringToCharArray(str);
PrintArray(stringg);

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