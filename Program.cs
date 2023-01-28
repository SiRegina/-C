
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

string [] Zapolnenie(int count)
{
string[] array = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива под индексом {i}:  ");
        array[i]=Console.ReadLine();
    }
    return array;
}





int ElementsCount=ReadInt("Введите количество элементов массива: ");
string [] array = Zapolnenie(ElementsCount);