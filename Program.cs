void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите значение: ");
        array[i] = Console.ReadLine();
    }
}

Console.Clear();
//Console.Write("Впишите элементы массива через пробел:");
//string[] meaning = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
string[] array = new string[3];
InputArray(array);
Console.Write(array);