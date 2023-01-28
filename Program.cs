
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

void PrintArray(string[] matr)
{
    System.Console.WriteLine();
    for(int i = 0; i < matr.Length; i++)
    {
        Console.Write(matr[i] + "   ");
    }

}

string [] NewArray (string []array)
{
    int count = 0;
    string [] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}


int ElementsCount=ReadInt("Введите количество элементов массива: ");
string [] array = Zapolnenie(ElementsCount);
PrintArray(array);
System.Console.WriteLine();
string [] array2 = NewArray(array);
PrintArray(array2);