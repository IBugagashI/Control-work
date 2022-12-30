void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите значение: ");
        array[i] = Console.ReadLine();
    }
}

void ReliseArray(string[] array)
{
    Console.Write("Ваш массив: ");
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
}

Console.Clear();
Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
InputArray(array);
ReliseArray(array);