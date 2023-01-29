int StrLess3 (string [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string [] ArrayStrLess3 (string [] array, int count)
{
    string [] arr = new string [count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[j] = array[i];
            j++;
        }
    }
    return arr;
}

void PrintArray (string [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    } 
    Console.WriteLine();
}

string [] array = {"hello", "2", "world", ":-)"};
int count = StrLess3 (array);
string [] arr = ArrayStrLess3 (array, count);
PrintArray (arr);