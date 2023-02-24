Console.Clear();
// Метод 1
// Ничего не возвращают и ничего не принимают
void Method1()
{
    Console.WriteLine("автор Алексей Воробьев");
}
//Вызываются следующим образом:
Method1();

// Метод 2
// Ничего не возвращают, но что-то принимают
void Method2 (string msg)
{
    Console.WriteLine(msg);
}
Method2 (msg: "Текст сообщения");
void Method21 (string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст сообщения", 4);

// Метод 3
// Что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Метод 4
// Что то принимают и что-то возвращают
string Method4 (int count, string c)
{
    int i = 0;
    string result = string.Empty;
    while (i<count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4 (3, "текст ");
Console.WriteLine(res);


