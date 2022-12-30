void SelectedArray(string[] array1, string[] array2)
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        array2[index++] = array1[i];
    }
}

void ReliseArray(string[] array1)
{
    Console.Write("Ваш массив: ");
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}

void ReliseSelectedArray(string[] array2)
{
    Console.Write("Перебраный массив массив: ");
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int count = 0;
string[] array1 = new string[size];
for (int i = 0; i < array1.Length; i++)
    {
        Console.Write("Введите значение: ");
        array1[i] = Console.ReadLine();
        if(array1[i].Length <= 3) 
        {
            count++;
        }
    }

string[] array2 = new string[count];

ReliseArray(array1);
SelectedArray(array1, array2);
ReliseSelectedArray(array2);