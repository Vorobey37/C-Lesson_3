// Нужно отсортировать массив по возрастанию

Console.Clear();
int []mass = {5, 9, 1, 3, 8, 4, 2, 0, 10, 6, 7};
void PrintMass(int []mass)
{
    int count = mass.Length;
    for (int i=0; i<count; i++)
    {
        Console.Write($"{mass[i]} ");
    }
    Console.WriteLine();
}
PrintMass(mass);

void Sortirize(int []mass)
{
    for (int i=0; i<mass.Length-1; i++)
    {
        int min = i;

        for (int j=i+1; j<mass.Length; j++)
        {
            if (mass[j]<mass[min])
            {
                min = j;
            }
        }

        int temp = mass[i];
        mass[i] = mass[min];
        mass[min] = temp;
        Console.Write($"{mass[i]} ");

    }
    Console.Write($"{mass[mass.Length-1]} ");
}
Sortirize(mass);
