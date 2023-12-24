using static MyMethods;
using static System.Console;


string[] stringSearch(string[] arr)
{
    string[] str = new string[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Array.Resize(ref str, str.Length + 1);
            str[str.Length - 1] = arr[i];
        }
    }
    return str;
}


int count = ReadInt("введите количество слов");
string[] arrstr = new string[count];
for (int i = 0; i < arrstr.Length; i++)
{
    WriteLine($"введите {i + 1} слово");
    arrstr[i] = ReadLine()!;
}
string output1 = string.Join(", ", arrstr);
string output2 = string.Join(", ", stringSearch(arrstr));
WriteLine($"[{output1}] -> [{output2}]");