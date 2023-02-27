Console.Clear();

int LengthCalculation(string[] array, int numChar = 3)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numChar)
            count++;
    }
    return count;
}

string[] CreatingNewArray(string[] array, int numChar = 3)
{
    string[] finishArray = new string [LengthCalculation(array)];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numChar)
        {
            finishArray[index] = array[i];
            index++;
        }
    }
    return finishArray;
}

void PrintArray(string[] array, string msg)
{
    System.Console.WriteLine(msg);
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i != array.Length-1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}
string[] firstArray = {"hello", "2", "world", ":-)", "1234", "1567", "-2", "Russia", "Denmark", "Kazan"};
string[] secondArray = CreatingNewArray(firstArray);
PrintArray(firstArray, "Базовый массив:");
System.Console.WriteLine();
PrintArray(secondArray, "Итоговый массив:");