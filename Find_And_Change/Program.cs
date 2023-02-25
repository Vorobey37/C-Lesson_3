/*
Дан текст, в тексте все пробелы заменить черточками,
маленькие буквы к заменить большими К, а 
маленькие с заменить большими З.
*/
Console.Clear();
string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "еслибы вас послали вместо нашего милого Винценгероде"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Change(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int lenght = text.Length;
    for (int i=0; i<lenght; i++)
    {
        if (text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Change(text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();
string newText1 = Change(newText, 'к', 'К');
Console.WriteLine(newText1);
Console.WriteLine();
string newText2 = Change(newText1, 'с', 'З');
Console.WriteLine(newText2);